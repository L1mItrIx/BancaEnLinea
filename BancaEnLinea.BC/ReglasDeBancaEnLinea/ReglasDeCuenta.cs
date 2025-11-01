using BancaEnLinea.BC.Modelos;

namespace BancaEnLinea.BC.ReglasDeBancaEnLinea
{
    public static class ReglasDeCuenta
    {
        public static bool laCuentaEsValida(Cuenta cuenta)
        {
            return cuenta != null &&
                cuenta.IdCuenta > 0 &&
                !string.IsNullOrEmpty(cuenta.Contrasena);
        }

        public static bool elIdCuentaEsValido(int idCuenta)
        {
            return idCuenta > 0;
        }

        public static bool contrasenaEsValida(string contrasena)
        {
            return contrasena.Length >= 8 &&
                contrasena.Any(char.IsLower) &&
                contrasena.Any(char.IsUpper) &&
                contrasena.Any(char.IsDigit) &&
                contrasena.Any(caracterEspecial => !char.IsLetterOrDigit(caracterEspecial));
        }
    }
}
