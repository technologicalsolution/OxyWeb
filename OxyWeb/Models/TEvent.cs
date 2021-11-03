namespace OxyWeb.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("TEvents")]
    public partial class TEvent
    {
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string Name { get; set; }

        [Column(TypeName = "date")]
        public DateTime date { get; set; }

        public int idRol { get; set; }
    }
}
