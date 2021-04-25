using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_04_ED.Clases
{
    public class TareaC
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public int Prioridad { get; set; }

        public Comparison<TareaC> CPrioridad = delegate (TareaC Far1, TareaC Far2)
        {
            return Far1.Prioridad.CompareTo(Far2.Prioridad);
        };

        public Comparison<TareaC> CTitulo = delegate (TareaC Far1, TareaC Far2)
        {
            return Far1.Titulo.CompareTo(Far2.Titulo);
        };

        public Comparison<TareaC> CID = delegate (TareaC Far1, TareaC Far2)
        {
            return Far1.Titulo.CompareTo(Far2.Titulo);
        };
    }
}
