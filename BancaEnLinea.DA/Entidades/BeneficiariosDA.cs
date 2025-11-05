

using BancaEnLinea.BC.Categorias;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BancaEnLinea.DA.Entidades
{
    [Table("Beneficiarios")]
    public class BeneficiariosDA
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdBeneficiario { get; set; }
        [Required]
        public int IdCuenta { get; set; }
        [Required]
        public string Alias { get; set; }
        [Required]
        public string Banco { get; set; }
        [Required]
        public TipoMoneda TipoMoneda { get; set; }
        [Required]
        public int NumeroCuenta { get; set; }
        [Required]
        public string Pais { get; set; }
    }
}
