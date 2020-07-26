using System;
using System.Collections.Generic;
using System.Text;

namespace congelador
{
    class congelador
    {
        public congelador()
        {
            this.Detalle = new List<detalledecongelado>();
        }

        public List<detalledecongelado> Detalle { get; }

        public listadodecongelados Cabecera { get; set; }
    }
}