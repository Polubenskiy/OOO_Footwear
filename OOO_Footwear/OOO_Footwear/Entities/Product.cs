namespace OOO_Footwear.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            OrderContent = new HashSet<OrderContent>();
        }

        [Key]
        [StringLength(100)]
        public string ProductArticleNumber { get; set; }

        public int ProductClassificationId { get; set; }

        [Required]
        [StringLength(100)]
        public string ProductDescription { get; set; }

        public int ProductCategoryId { get; set; }

        [StringLength(int.MaxValue)]
        public string ProductPhoto { get; set; }

        public int ProductManufacuturerId { get; set; }

        public decimal ProductCost { get; set; }

        public byte ProductDiscountMax { get; set; }

        public byte ProductDiscountNow { get; set; }

        public int ProductQuantityInStock { get; set; }

        public int ProductUnitId { get; set; }

        public int ProductProviderId { get; set; }

        public virtual Category Category { get; set; }

        public virtual Classification Classification { get; set; }

        public virtual Manufacturer Manufacturer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderContent> OrderContent { get; set; }

        public virtual Provider Provider { get; set; }

        public virtual Unit Unit { get; set; }
    }
}
