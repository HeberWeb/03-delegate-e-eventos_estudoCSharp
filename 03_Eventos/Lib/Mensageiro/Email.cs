using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Eventos.Lib.Mensageiro
{
    public class Email
    {
        public void EnviarMensagem(object sender, VideoEventArgs args)
        {
            Console.WriteLine("Email Enviado para o video" + args.Video.Nome);
        }
    }
}
