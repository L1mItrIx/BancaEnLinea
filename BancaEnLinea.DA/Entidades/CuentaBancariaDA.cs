using BancaEnLinea.BC.Categorias;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BancaEnLinea.DA.Entidades
{
    [Table("CuentaBancaria")]
    public class CuentaBancariaDA
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long NumeroCuentaBancaria { get; set; }
        [Required]
        public int IdCuenta { get; set; }
        [Required]
        public TipoMoneda TipoMoneda { get; set; }
        [Required]
        public decimal Saldo { get; set; }
        [Required]
        public TipoCuentaBancaria TipoCuentaBancaria { get; set; }
        [Required]
        public EstadoCuentaBancaria EstadoCuentaBancaria { get; set; }
        [Required]
        public decimal MaximoTransferencia { get; set; }
    }
}
