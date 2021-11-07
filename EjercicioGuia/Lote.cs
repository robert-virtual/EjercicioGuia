using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioGuia
{
    public class Lote
    {

        public string Nombre { get; set; }
        public List<Pieza> PiezasAptas { get; set; }
        public List<Pieza> PiezasInAptas { get; set; }
        public DateTime Fecha { get; set; }
        public Lote()
        {
            Fecha = DateTime.Now;
            PiezasAptas = new List<Pieza>();
            PiezasInAptas = new List<Pieza>();
        }
    }
}
