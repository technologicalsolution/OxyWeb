namespace OxyWeb.ViewModels
{
    using OxyWeb.Enums;
    using System.ComponentModel.DataAnnotations;

    public partial class VUser
    {
        public int Id { get; set; }
        
        [StringLength(50)]
        public string user { get; set; }
        
        [StringLength(20)]
        public string pass { get; set; }

        public int idRol { get; set; }

        public string nameRol { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        [StringLength(20)]
        public string lastName { get; set; }

        public bool active { get; set; }
    }
}
