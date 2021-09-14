namespace DatabaseCodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RequestProduct")]
    public partial class RequestProduct
    {
        public int RequestProductId { get; set; }

        public int RequestId { get; set; }

        public int ProductId { get; set; }

        public double Price { get; set; }

        public virtual Product Product { get; set; }

        public virtual Request Request { get; set; }
    }
}
