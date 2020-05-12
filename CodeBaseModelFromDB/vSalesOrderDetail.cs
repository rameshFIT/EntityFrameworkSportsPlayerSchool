namespace CodeBaseModelFromDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vSalesOrderDetail")]
    public partial class vSalesOrderDetail
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SalesOrderID { get; set; }

        [Key]
        [Column(Order = 1)]
        public int SalesOrderDetailID { get; set; }

        public short? OrderQty { get; set; }

        public int? ProductID { get; set; }

        [Column(TypeName = "money")]
        public decimal? UnitPrice { get; set; }

        [Column(TypeName = "money")]
        public decimal? UnitPriceDiscount { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "numeric")]
        public decimal LineTotal { get; set; }

        public Guid? rowguid { get; set; }

        public DateTime? ModifiedDate { get; set; }
    }
}
