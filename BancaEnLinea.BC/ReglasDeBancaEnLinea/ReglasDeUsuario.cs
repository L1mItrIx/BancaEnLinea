using BancaEnLinea.BC.Modelos;

namespace BancaEnLinea.BC.ReglasDeBancaEnLinea
{
    public static class ReglasDeUsuario
    {
        public static bool elUsuarioEsValido(Usuario usuario)
        {
            return usuario != null &&
                !string.IsNullOrEmpty(usuario.Nombre) &&
                !string.IsNullOrEmpty(usuario.Apellidos) &&
                !string.IsNullOrEmpty(usuario.Correo) &&
                usuario.Cedula > 99999999 &&
                usuario.Cedula < 1000000000000;
        }

        public static bool laCedulaEsValida(int cedula)
        {
            return cedula > 99999999 && 
                cedula < 1000000000000;
            //regla de cedulas que tengan de 7 a 13 digitos
        }
    }
}
