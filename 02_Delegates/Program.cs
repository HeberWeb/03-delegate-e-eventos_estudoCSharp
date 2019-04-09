using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02_Delegates.Lib;
namespace _02_Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tela de cadastro de usuários: gerar Thumb para foto de perfil
            Foto foto = new Foto() { Nome = "perfil.jpg", TamanhoX = 1920, TamanhoY = 1080 };
            FotoProcessador.filtros = new FotoFiltro().GerarThumb;
            FotoProcessador.Processar(foto);

            //Tela de cadastro de produtos: Colorir + Redimenciona tamanho
            Foto foto2 = new Foto() { Nome = "produto.jpg", TamanhoX = 1920, TamanhoY = 1080 };
            FotoProcessador.filtros = new FotoFiltro().Colorir;
            FotoProcessador.filtros += new FotoFiltro().RedimensionarTamMedio;
            FotoProcessador.Processar(foto2);

            //Tela de cadastro de usuário retro:: Preto e Branco
            Foto foto3 = new Foto() { Nome = "album.jpg", TamanhoX = 1920, TamanhoY = 1080 };
            FotoProcessador.filtros = new FotoFiltro().PretoBranco;
            FotoProcessador.Processar(foto3);
            
            Console.ReadKey();

        }
    }
}
