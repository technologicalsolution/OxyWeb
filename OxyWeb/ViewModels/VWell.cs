namespace OxyWeb.ViewModels
{
    using System.ComponentModel.DataAnnotations;

    public partial class VWell
    {
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string Name { get; set; }

        public int FieldId { get; set; }

        public virtual string TfieldName { get; set; }
    }
}
