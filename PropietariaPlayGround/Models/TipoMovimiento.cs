using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PropietariaPlayGround.Models
{
    public class TipoMovimiento
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public List<Asiento> Asientos { get; set; }
    }
}
