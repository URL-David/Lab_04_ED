using Lab_04_ED.LibreriaGenericos.Estructuras;
using Lab_04_ED.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_04_ED.Models
{
    public class Admin
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Usiario { get; set; }
        public string Contraseña { get; set; }
        public int TotalDesarrolladores { get; set; }

        public List<DesarolladoresInf> EmpleadosDV = new List<DesarolladoresInf>();
        // La lista de tareas debe ser una tabla Hash
        public TablaHash<AddTarea> HashTable = new TablaHash<AddTarea>();

    }
}
