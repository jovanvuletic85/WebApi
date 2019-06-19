namespace WebApiVehicle.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Model")]
    public partial class Model
    {
        public int ModelId { get; set; }

        public int BrandId { get; set; }

        [Required(ErrorMessage ="You need to enter model name")]
        [StringLength(15,ErrorMessage = "String length is maximum 15 characters")]
        public string ModelName { get; set; }

        public int YearsOfAge { get; set; }

        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        [StringLength(10,ErrorMessage = "String length is maximum 10 characters")]
        public string Fuel { get; set; }

        public virtual Brand Brand { get; set; }
    }
}
