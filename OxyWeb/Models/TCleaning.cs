namespace OxyWeb.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("TCleaning")]
    public partial class TCleaning
    {
        public int Id { get; set; }

        [StringLength(10)]
        public string name { get; set; }

        public int idRol { get; set; }
    }
}
