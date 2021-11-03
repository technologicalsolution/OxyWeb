namespace OxyWeb.Models
{
    using OxyWeb.ViewModels;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Tfield")]
    public partial class Tfield
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tfield()
        {
            TWells = new HashSet<VWell>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string Name { get; set; }

        public int idRol { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VWell> TWells { get; set; }
    }
}
