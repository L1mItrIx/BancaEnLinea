using BancaEnLinea.BC.Modelos;

namespace BancaEnLinea.BW.Interfaces.DA
{
    public interface IGestionUsuarioDA
    {
        // Registro
        Task<bool> CrearUsuarioConCuenta(Usuario usuario, Cuenta cuenta);

        // Consultas
        Task<Usuario?> ObtenerUsuarioPorCedula(int cedula);
        Task<Cuenta?> ObtenerCuentaPorCorreo(string correo);
        Task<List<Usuario>> ObtenerTodosLosUsuarios();
        Task<bool> ExisteCorreo(string correo);

        // Actualizaciones
        Task<bool> ActualizarUsuario(Usuario usuario);

        // Control de intentos de login (RF-A2)
        Task<bool> IncrementarIntentosLogin(int idCuenta);
        Task<bool> BloquearCuentaPorIntentos(int idCuenta);
        Task<bool> ResetearIntentosLogin(int idCuenta);
    }
}