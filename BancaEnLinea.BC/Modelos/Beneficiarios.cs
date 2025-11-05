using BancaEnLinea.BC.Categorias;

namespace BancaEnLinea.BC.Modelos
{
    public class Beneficiarios
    {
        public int IdCuenta { get; set; }
        public int IdBeneficiario { get; set; }
        public string Alias { get; set; }
        public string Banco { get; set; }
        public TipoMoneda TipoMoneda { get; set; }
        public int NumeroCuenta { get; set; }
        public string Pais { get; set; }
    }
}
