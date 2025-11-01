using BancaEnLinea.BC.Categorias;

namespace BancaEnLinea.BC.Modelos
{
    public class Cuenta
    {
        public int Cedula {  get; set; }
        public int IdCuenta { get; set; }
        public string Contrasena { get; set; }
        public Rol RolCuenta { get; set; }
        public Cuenta()
        {
            IdCuenta = new int();
            //genera id automaticamente
            RolCuenta = Rol.Cliente;
            //al crease se vuelve cliente, solo admin podra cambiar roles
        }
    }
}
