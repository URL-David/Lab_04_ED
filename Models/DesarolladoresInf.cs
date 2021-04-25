using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab_04_ED.LibreriaGenericos.Estructuras;
using Lab_04_ED.Clases;

namespace Lab_04_ED.Models
{
    public class DesarolladoresInf
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public ColaPrioridad<TareaC> TareasDV = new ColaPrioridad<TareaC>();
    }
}
