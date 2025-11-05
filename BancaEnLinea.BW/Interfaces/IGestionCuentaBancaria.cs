using BancaEnLinea.BC.Categorias;
using BancaEnLinea.BC.Modelos;

namespace BancaEnLinea.BW.Interfaces.DA
{
    public interface IGestionCuentaBancariaDA
    {
        // CRUD básico
        Task<bool> CrearCuenta(CuentaBancaria cuenta);
        Task<CuentaBancaria?> ObtenerCuentaPorNumero(long numeroCuenta);
        Task<List<CuentaBancaria>> ObtenerCuentasPorCliente(int idCliente);
        Task<bool> ActualizarCuenta(CuentaBancaria cuenta);

        // Operaciones específicas
        Task<bool> ActualizarSaldo(long numeroCuenta, decimal nuevoSaldo);
        Task<bool> CambiarEstadoCuenta(long numeroCuenta, EstadoCuentaBancaria nuevoEstado);

        // Validaciones
        Task<int> ContarCuentasPorTipoYMoneda(int idCliente, TipoCuentaBancaria tipo, TipoMoneda moneda);
    }
}