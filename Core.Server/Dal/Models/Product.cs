﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Server.Dal.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        public string Tag { get; set; }
        public string Brand { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string DefaultImageUrl { get; set; }
        public int? SubscriptionId { get; set; }
        public int? Memory { get; set; }

        public List<Image> Images { get; set; }
        public List<Color> Colors { get; set; }
    }
}
