using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows;
using System.Windows.Forms;

namespace ConsultaCEP.Database
{
    public class Fichario
    {
        private string _diretorio;

        public Fichario(string diretorio)
        {
            if (!Directory.Exists(diretorio))
            {
                Directory.CreateDirectory(diretorio);
            }
            _diretorio = diretorio;

        }

        public void Incluir(string cep, string json)
        {
            var arquivo = _diretorio + "\\"+ cep + ".json";

            if (!File.Exists(arquivo))
            {
                File.WriteAllText(arquivo, json);
            }
            
        }

        public List<string> BuscarTodos()
        {
            var ret = new List<string>();
            try
            {
                var arquivos = Directory.GetFiles(_diretorio,"*.json");

                foreach (var arquivo in arquivos)
                {
                    ret.Add(File.ReadAllText(arquivo));
                }
            }
            catch (Exception ex)
            {
                
            }


            return ret;
        }
    }
}
