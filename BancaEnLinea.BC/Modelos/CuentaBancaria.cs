using BancaEnLinea.BC.Categorias;
namespace BancaEnLinea.BC.Modelos
{
    public  class CuentaBancaria
    {
        public int IdCuenta { get; set; }
        public long NumeroCuentaBancaria { get; set; }
        public TipoMoneda Moneda { get; set; }
        public decimal Saldo { get; set; }
        public TipoCuentaBancaria TipoCuentaBancaria { get; set; }
        public EstadoCuentaBancaria EstadoCuentaBancaria { get; set; }
        public decimal MaximoTransferencia { get; set; }

        public CuentaBancaria()
        {
            MaximoTransferencia = 20000;
        }
    }
}
