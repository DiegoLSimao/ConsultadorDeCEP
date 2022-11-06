using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsultaCEP.Classes
{
    public class ConsultarCep
    {
        public delegate void CepRecebidoEventHandler(object sender, string args, Stopwatch sw);
        public event CepRecebidoEventHandler AoReceberCEP;

        string cepRecebido;
        Stopwatch stopwatch = new Stopwatch();

        public void ConsultarViaCep(string cep)
        {
            BackgroundWorker worker = new BackgroundWorker();
            worker.DoWork += (o, e) =>
            {
                stopwatch.Restart();
                //*** Monta link da viacep com CEP a ser consultado
                System.Net.HttpWebRequest requisicao = (HttpWebRequest)WebRequest.Create("https://viacep.com.br/ws/" + cep + "/json/");

                //*** Recebe json da internet, no formato http web response
                HttpWebResponse resposta = (HttpWebResponse)requisicao.GetResponse();

                int cont;
                byte[] buffer = new byte[1000];
                StringBuilder sb = new StringBuilder();
                string temp;
                Stream stream = resposta.GetResponseStream();
                do
                {
                    Thread.Sleep(2000);
                    cont = stream.Read(buffer, 0, buffer.Length);
                    temp = Encoding.UTF8.GetString(buffer, 0, cont).Trim();
                    sb.Append(temp);

                } while (cont > 0);
                cepRecebido = sb.ToString();
            };
            worker.RunWorkerCompleted += (o, e) =>
            {
                CepRecebidoSucesso();
            };
            //bw.ProgressChanged += Bw_ProgressChanged;
            worker.WorkerReportsProgress = false;
            worker.WorkerSupportsCancellation = false; //Allow for the process to be cancelled
            worker.RunWorkerAsync();
        }



        private void CepRecebidoSucesso()
        {
            stopwatch.Stop();
            if (AoReceberCEP != null)
            {
                AoReceberCEP(this, cepRecebido,stopwatch);
            }
        }
    }


}
