using System;

namespace PropietariaPlayGround.Models
{
    public class Asiento
    {

        public int Id { get; set; }
        public int NumeroAsiento { get; set; }
        public int IdTipoMovimiento { get; set; }

        public string Descripcion { get; set; }

        public DateTime FechaEntrega { get; set; }

        public string Cuenta { get; set; }

        public double MontoMovimiento { get; set; }

        public TipoMovimiento TipoMovimiento { get; set; }

    }
}
