using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_04_ED.Models
{
    public class AddTarea
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descripccion { get; set; }
        public string Proyecto { get; set; }
        public DateTime Fecha { get; set; }
        public int IdDesarrollador { get; set; }
        public int Prioridad { get; set; }

        public Comparison<AddTarea> CTitulo = delegate (AddTarea Far1, AddTarea Far2)
        {
            return Far1.Titulo.CompareTo(Far2.Titulo);
        };

        public Comparison<AddTarea> CID = delegate (AddTarea Far1, AddTarea Far2)
        {
            return Far1.Id.CompareTo(Far2.Id);
        };
        public Comparison<AddTarea> CPrioridad = delegate (AddTarea Far1, AddTarea Far2)
        {
            return Far1.Prioridad.CompareTo(Far2.Prioridad);
        };

    }
}
