namespace billing_withEntity.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class snack
    {
        public int Id { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        public int? Cost { get; set; }

        [StringLength(100)]
        public string Company { get; set; }
    }
}
