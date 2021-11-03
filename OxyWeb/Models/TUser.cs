namespace OxyWeb.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("TUser")]
    public partial class TUser
    {
        public int Id { get; set; }
        
        [StringLength(50)]
        public string user { get; set; }
        
        [StringLength(20)]
        public string pass { get; set; }

        public int idRol { get; set; }
        
        [StringLength(50)]
        public string name { get; set; }
        
        [StringLength(20)]
        public string lastName { get; set; }

        public bool active { get; set; }
    }
}
