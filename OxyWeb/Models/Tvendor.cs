namespace OxyWeb.Models
{
    using OxyWeb.ViewModels;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Tvendor")]
    public partial class Tvendor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tvendor()
        {
            TEquipments = new HashSet<VEquipment>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public int idRol { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VEquipment> TEquipments { get; set; }
    }
}
