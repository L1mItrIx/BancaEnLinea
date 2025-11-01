using BancaEnLinea.BC.Categorias;
using BancaEnLinea.BC.Modelos;

namespace BancaEnLinea.BC.ReglasDeBancaEnLinea
{
    public static class ReglasDeBeneficiarios
    {
        public static bool elBeneficiarioEsValido(Beneficiarios beneficiario)
        {
            return beneficiario != null &&
                !string.IsNullOrEmpty(beneficiario.Alias) &&
                !string.IsNullOrEmpty(beneficiario.Banco) &&
                Enum.IsDefined(typeof(TipoMoneda), beneficiario.TipoMoneda) &&
                beneficiario.NumeroCuenta > 99999999999 &&
                !string.IsNullOrEmpty(beneficiario.Pais);
        }
    }
}
