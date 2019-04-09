using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Delegates.Lib
{
    public class FotoProcessador
    {
        //Handler palavra comum para identificar delegates
        public delegate void FotoFiltroHandler(Foto foto);

        public static FotoFiltroHandler filtros;

        public static void Processar(Foto foto)
        {
            filtros(foto);
        }

        //Aplica todos os efeitos de uma vez
        public static void ProcessarTodos(Foto foto)
        {
            FotoFiltro filtros = new FotoFiltro();
            filtros.Colorir(foto);
            filtros.PretoBranco(foto);
            filtros.GerarThumb(foto);
            filtros.RedimensionarTamMedio(foto);
        }
    }
}
