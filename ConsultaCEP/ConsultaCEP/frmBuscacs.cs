using ConsultaCEP.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Compression;
using System.IO;

namespace ConsultaCEP
{
    public partial class frmBuscar : Form
    {
        List<CEP.Unit> _listaDeCep = new List<CEP.Unit>();
        

        public frmBuscar(List<List<string>> listaDeTodos, List<CEP.Unit> listaDeCep)
        {
            _listaDeCep = listaDeCep;
            InitializeComponent();
            PreencherLista();
        }


        private void PreencherLista()
        {
            var teste = ConfigurationManager.AppSettings["Caminho"];

            grvDados.Rows.Clear();
            grvDados.DataSource = _listaDeCep;
            grvDados.Columns["complemento"].Visible = false;
            grvDados.Columns["erro"].Visible = false;
            grvDados.Columns["logradouro"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void tlsbtnFechar_ButtonClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tlsbtnSelecionar_Click(object sender, EventArgs e)
        {
            
        }



  

  
    }
}
