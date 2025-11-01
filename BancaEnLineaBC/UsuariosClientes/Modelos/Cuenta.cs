namespace BancaEnLineaBC.UsuariosClientes.Modelos
{
    public class Cuenta
    {
        public int Cedula { get; set; }
        public int IdCuenta { get; set; }
        public string Correo { get; set; }
        public string Contrasena { get; set; }
        public Rol Rol { get; set; }
        public bool CuentaActiva { get; set; }
    }
    
}
