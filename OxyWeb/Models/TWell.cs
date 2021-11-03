namespace OxyWeb.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("TWells")]
    public partial class TWell
    {
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string Name { get; set; }

        public int FieldId { get; set; }

        public int idRol { get; set; }
    }
}
