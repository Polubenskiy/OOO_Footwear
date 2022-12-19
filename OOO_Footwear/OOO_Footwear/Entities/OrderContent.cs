namespace OOO_Footwear.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrderContent")]
    public partial class OrderContent
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderContnentId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string OrderContentProduct { get; set; }

        public int OrderContentCount { get; set; }

        public virtual Order Order { get; set; }

        public virtual Product Product { get; set; }
    }
}
