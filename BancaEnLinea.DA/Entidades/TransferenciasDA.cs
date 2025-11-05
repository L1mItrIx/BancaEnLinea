using BancaEnLinea.BC.Categorias;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BancaEnLinea.DA.Entidades
{
    [Table("Transferencias")]
    public class TransferenciasDA
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid IdTransferencias { get; set; }
        [Required]
        public int NumeroCuentaBancariaOrigen { get; set; }
        [Required]
        public int NumeroCuentaBancariaDestino { get; set; }
        [Required]
        public decimal Monto { get; set; }
        [Required]
        public string DetalleTransferencia { get; set; }
        [Required]
        public DateTime FechaTransferencia { get; set; }
        [Required]
        public TipoTransferencia TipoTransferencia { get; set; }
        [Required]
        public EstadoTransferencia EstadoTransferencia { get; set; }
        [Required]
        public decimal Comision { get; set; }
    }
}
