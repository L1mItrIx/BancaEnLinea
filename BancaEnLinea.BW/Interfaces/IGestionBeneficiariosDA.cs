using BancaEnLinea.BC.Modelos;

namespace BancaEnLinea.BW.Interfaces.DA
{
    public interface IGestionBeneficiariosDA
    {
        // CRUD
        Task<bool> CrearBeneficiario(Beneficiarios beneficiario);
        Task<Beneficiarios?> ObtenerBeneficiarioPorId(int idBeneficiario);
        Task<List<Beneficiarios>> ObtenerBeneficiariosPorCliente(int idCliente);
        Task<bool> ActualizarBeneficiario(Beneficiarios beneficiario);
        Task<bool> EliminarBeneficiario(int idBeneficiario);

        // Operaciones específicas (RF-C1)
        Task<bool> ConfirmarBeneficiario(int idBeneficiario);

        // Filtros (RF-C3)
        Task<List<Beneficiarios>> FiltrarBeneficiarios(
            int idCliente,
            string? alias = null,
            string? banco = null,
            string? pais = null);

        // Validaciones
        Task<bool> ExisteAlias(int idCliente, string alias);
        Task<bool> TieneTransferenciasProgramadas(int idBeneficiario);
    }
}