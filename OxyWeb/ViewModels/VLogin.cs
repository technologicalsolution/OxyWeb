namespace OxyWeb.ViewModels
{
    using System.ComponentModel.DataAnnotations;
    public class VLogin : VError
    {
        [StringLength(50)]
        public string user { get; set; }

        [StringLength(20)]
        public string pass { get; set; }
    }
}
