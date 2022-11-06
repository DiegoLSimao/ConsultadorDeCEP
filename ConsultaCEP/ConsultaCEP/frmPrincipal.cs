using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsultaCEP.Classes;
using ConsultaCEP.Database;
using ConsultaCEP;
using System.IO;
using AutoUpdaterDotNET;
using System.Reflection;
using System.Diagnostics;

namespace ConsultaCEP
{
    public partial class frmPrincipal : Form
    {
        ConsultarCep consultaCEP =  new ConsultarCep();
        Fichario fichario = new Fichario(Application.StartupPath + "\\Consultas");

        

        public frmPrincipal()
        {
            InitializeComponent();
            Version versionAss = Assembly.GetEntryAssembly().GetName().Version;
            Text = "Consulta CEP - Versão: " + versionAss.ToString();
            var teste = Properties.Settings.Default.Usuario;

            //***Assinatura de evento
            consultaCEP.AoReceberCEP += ConsultaCEP_AoReceberCEP;
        }

        private void ConsultaCEP_AoReceberCEP(object sender, string args, Stopwatch sw)
        {
            var strCep = args;
            CEP.Unit cep = new CEP.Unit();     
            cep = CEP.ConverterJsonParaClasseUnit(strCep);
            lblTempoConsulta.Text = $"OK!  ({sw.ElapsedMilliseconds / 1000.0} seg)";
            PopularCampos(cep);
            if(!cep.erro)
            {
                fichario.Incluir((cep.cep).Replace("-",string.Empty),strCep);
            }
        }


        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtCEP.Text))
            {
                var mensagem = $"Preencha o campo CEP!";
                MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if((txtCEP.TextLength<8) || (txtCEP.TextLength > 8))
            {
                var mensagem = $"CEP deve ter 8 números!";
                MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var cep = txtCEP.Text;
            LimparCampos();
            lblTempoConsulta.Text = "Aguarde...";
            consultaCEP.ConsultarViaCep(cep);
        }



        private void PopularCampos(CEP.Unit cep)
        {
            if(cep.erro)
            {
                var user =  Environment.UserName;
                var mensagem = $"Usuário: {user} \nCEP não encontrado!";
                MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimparCampos();
                return;
            }

            txtEndereco.Text = cep.logradouro.ToString();
            txtBairro.Text = cep.bairro.ToString();
            txtCidade.Text = cep.localidade.ToString();
            txtComplemento.Text = cep.complemento.ToString();   
            txtDDD.Text = cep.ddd.ToString();   
            txtGia.Text = cep.gia.ToString();
            txtIbge.Text = cep.ibge.ToString();
            txtSiafi.Text = cep.siafi.ToString();
            txtEstado.Text = cep.uf;
            txtCEP.Text = cep.cep.ToString();
            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtEndereco.Text = String.Empty;
            txtBairro.Text = String.Empty;
            txtCidade.Text = String.Empty;
            txtComplemento.Text = String.Empty;
            txtDDD.Text = String.Empty;
            txtGia.Text = String.Empty;
            txtIbge.Text = String.Empty;
            txtSiafi.Text = String.Empty;
            txtEstado.Text = String.Empty;
            txtCEP.Text = String.Empty;
            lblTempoConsulta.Text = String.Empty;
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            var user = Environment.UserName;
            var maquina = Environment.MachineName;
            var diretorio = Environment.CurrentDirectory;
            var os = Environment.OSVersion.ToString();
            var programador = "Diego de Lima Simão";
            Version versionAss = Assembly.GetEntryAssembly().GetName().Version;

            var mensagem = $"Usuário: {user} \nMáquina: {maquina} \nCaminho: {diretorio}\nOS: {os} \nVersão Assembly: {versionAss}\nProgramador: {programador}";
            MessageBox.Show(mensagem, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnExportarTxt_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "txt files(*.txt) | *.txt ";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;
            

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (var sw = File.CreateText(saveFileDialog.FileName))
                {
                    sw.WriteLine("Rua: " + txtEndereco.Text);
                    sw.WriteLine("Bairro: " + txtBairro.Text);
                    sw.WriteLine("Cidade: " + txtCidade.Text);
                    sw.WriteLine("Estado: " + txtEstado.Text);
                    sw.WriteLine("CEP: " + txtCEP.Text);
                    sw.WriteLine("Complemento: " + txtComplemento.Text);
                }
            }
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                //caminho deve apontar para o arquivo xml na rede, onde vai estar a versão atualizada
                //AutoUpdater.Start(@"file://C:\Users\diego\Desktop\Diego\Lima\Simao\Recent\infoVersaoAtualizada.xml");
               
            }
            catch(Exception ex)
            {
                MessageBox.Show("Não foi possível verificar atualizações!\n" + ex.Message, "Falha!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }         
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            var buscarTodos = fichario.BuscarTodos();
            var listaDeTodos = new List<List<string>>();
            var litaDeCep = new List<CEP.Unit>();

            foreach (var item in buscarTodos)
            {
                CEP.Unit cep = CEP.ConverterJsonParaClasseUnit(item);
                litaDeCep.Add(cep);
                listaDeTodos.Add(new List<string> { cep.cep, cep.logradouro });
            }

            frmBuscar F = new frmBuscar(listaDeTodos, litaDeCep);
            F.ShowDialog();
        }
    }
}
