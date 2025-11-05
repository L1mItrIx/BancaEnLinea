using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BancaEnLinea.DA.Entidades
{
    [Table("Cuentas")]
    public class CuentaDA
    {
        [Required]
        public int Cedula { get; set; }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdCuenta { get; set; }
        [Required]
        public string Contrasena { get; set; }
        [Required]
        public string RolCuenta { get; set; }
    }
}
