

using BancaEnLinea.BC.Modelos;

namespace BancaEnLinea.BC.ReglasDeBancaEnLinea
{
    public static class ReglasDeTransferencias
    {
        public static bool ReglasDeTransferencias(Transferencias transferencia)
        {
            return transferencia != null &&
                transferencia.CuentaReceptora > 9999999999 &&
                transferencia.CuentaReceptora < 10000000000 &&
                transferencia.Monto < CuentaBancaria.Saldo &&

        }
    }
}
