using BancaEnLinea.BC.Categorias;
using BancaEnLinea.BC.Modelos;

namespace BancaEnLinea.BW.Interfaces.DA
{
    public interface IGestionTransferenciaDA
    {
        // Operaciones principales
        Task<bool> RegistrarTransferencia(Transferencias transferencia);
        Task<bool> EjecutarTransferencia(Transferencias transferencia);
        Task<bool> ActualizarTransferencia(Transferencias transferencia);

        // Consultas
        Task<Transferencias?> ObtenerTransferenciaPorId(Guid idTransferencia);
        Task<List<Transferencias>> ObtenerHistorialTransferencias(
            long numeroCuenta,
            DateTime? fechaInicio = null,
            DateTime? fechaFin = null,
            EstadoTransferencia? estado = null);

        // Transferencias programadas (RF-D3)
        Task<List<Transferencias>> ObtenerTransferenciasProgramadas();

        // Idempotency (RF-D2)
        Task<bool> ExisteIdempotencyKey(string idempotencyKey);
    }
}