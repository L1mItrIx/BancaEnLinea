using BancaEnLinea.BC.Categorias;
using System.Security.Cryptography.X509Certificates;
namespace BancaEnLinea.BC.Modelos
{
    public class Transferencias
    {
        public int NumeroCuentaBancaria { get; set; }
        public int CuentaReceptora { get; set; }
        public Guid IdTransferencias { get; set; }
        public decimal Monto { get; set; }
        public string DetalleTransferencia { get; set; }
        public DateTime FechaTransferencia { get; set; }
        public TipoTransferencia TipoTransferencia { get; set; }
        public EstadoTransferencia EstadoTransferencia { get; set; }

    }
    public Transferencias()
        {
            IdTransferencias = Guid.NewGuid();
        }
    }
        
}
