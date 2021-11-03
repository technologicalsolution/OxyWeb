namespace OxyWeb.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("TEquipment")]
    public partial class TEquipment
    {
        public int id { get; set; }

        [Required]
        [StringLength(20)]
        public string EquipmentType { get; set; }

        public int VendorID { get; set; }

        [Required]
        [StringLength(10)]
        public string PartNumber { get; set; }

        [Required]
        [StringLength(10)]
        public string SerialNumber { get; set; }

        [Required]
        [StringLength(50)]
        public string EquipmentDescription { get; set; }

        [Required]
        [StringLength(50)]
        public string EquipmentTag { get; set; }

        [Column(TypeName = "date")]
        public DateTime EqpTagDate { get; set; }

        public double EqpPrice { get; set; }
        public int idRol { get; set; }
    }
}
