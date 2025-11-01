using BancaEnLinea.BC.Categorias;
using BancaEnLinea.BC.Modelos;

namespace BancaEnLinea.BC.ReglasDeBancaEnLinea
{
    public static class ReglasDeCuentaBancaria
    {
        public static bool laCuentaBancariaEsValida (CuentaBancaria cuentabancaria)
        {
            return cuentabancaria != null &&
                cuentabancaria.NumeroCuentaBancaria > 0 &&
                cuentabancaria.Saldo > 0 &&
                cuentabancaria.MaximoTransferencia > 0 &&
                Enum.IsDefined(typeof(TipoCuentaBancaria), cuentabancaria.TipoCuentaBancaria) &&
                Enum.IsDefined(typeof(TipoMoneda), cuentabancaria.Moneda);
        }
        public static bool elNumeroCuentaEsValido (int numeroCuentaBancaria)
        {
            return numeroCuentaBancaria > 99999999999 &&
                numeroCuentaBancaria < 1000000000000;
        }
    }
}
