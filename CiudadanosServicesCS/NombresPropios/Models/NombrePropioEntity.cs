using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CiudadanosServicesCS.NombresPropios.Models
{
    [Table("TB_NombresPropios", Schema = "Ciudadanos")]
    public class NombrePropioEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("PkiNombrePropio")]
        public int Id { get; set; }

        [Required]
        [Column("FcNombrePropio", TypeName = "varchar(60)")]
        [MaxLength(60)]
        public string NombrePropio { get; set; }  = string.Empty;

        [Required]
        [Column("FdFechaCreacion", TypeName = "datetime2(0)")]
        public DateTime FechaCreacion { get; set; }

        [Required]
        [Column("FiUsuarioCreacion")]
        public string UsuarioCreacion { get; set; } = string.Empty;
    }
}
