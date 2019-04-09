using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Eventos.Lib.Mensageiro
{
    public class SMS
    {
        public void EnviarMensagem(object sender, VideoEventArgs args)
        {
            Console.WriteLine("SMS Enviado para o video" + args.Video.Nome);
        }
    }
}
