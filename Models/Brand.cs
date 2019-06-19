namespace WebApiVehicle.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Brand")]
    public partial class Brand
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Brand()
        {
            Models = new HashSet<Model>();
        }

        public int BrandId { get; set; }

        [Required(ErrorMessage ="You need to enter brand name")]
        [StringLength(15,ErrorMessage = "String length is maximum 15 characters")]
        public string BrandName { get; set; }

        [Required(ErrorMessage = "You need to enter country of origin")]
        [StringLength(15, ErrorMessage = "String length is maximum 15 characters")]
        public string CountryOfOrigin { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Model> Models { get; set; }
    }
}
