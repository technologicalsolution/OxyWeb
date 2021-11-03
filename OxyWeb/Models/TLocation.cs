namespace OxyWeb.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("TLocation")]
    public partial class TLocation
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(20)]
        public string location { get; set; }

        public int idRol { get; set; }
    }
}
