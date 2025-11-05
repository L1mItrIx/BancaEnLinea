using BancaEnLinea.BC.Categorias;
namespace BancaEnLinea.BC.Modelos
{
    public class Transferencias
    {
        public int NumeroCuentaBancariaOrigen { get; set; }
        public int NumeroCuentaBancariaDestino { get; set; }
        public Guid IdTransferencias { get; set; }
        public decimal Monto { get; set; }
        public string DetalleTransferencia { get; set; }
        public DateTime FechaTransferencia { get; set; }
        public TipoTransferencia TipoTransferencia { get; set; }
        public EstadoTransferencia EstadoTransferencia { get; set; }
        public decimal Comision { get; set;}

    }
    public Transferencias()
        {
            IdTransferencias = Guid.NewGuid();
        }
    }
        
}
