using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace hmart.Models
{
    public class Product
    {
        public int Id { get; set; }

        [StringLength(maximumLength: 100)]
        public string Name { get; set; }

        [StringLength(maximumLength: 100)]
        public string Image { get; set; }

        [NotMapped]
        public IFormFile ImageFile { get; set; }

        [StringLength(maximumLength: 800)]
        public string Desc { get; set; }

        [StringLength(maximumLength: 50)]
        public string Code { get; set; }

        public double? CostPrice { get; set; }
        public double? Price { get; set; }
        public int? DiscountPercent { get; set; }
        public double? Rate { get; set; }

        [StringLength(maximumLength: 50)]
        public string Weight { get; set; }

        [StringLength(maximumLength: 50)]
        public string Dimensions { get; set; }

        [StringLength(maximumLength: 100)]
        public string Materials { get; set; }

        [StringLength(maximumLength: 200)]
        public string OtherInfo { get; set; }
        public bool? IsNew { get; set; }
        public bool? IsAvailable { get; set; }
        public bool? IsOnOffer { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public int BrandId { get; set; }
        public Brand Brand { get; set; }

        public List<ProductTagProduct> ProductTagProducts { get; set; }
        public List<ProductColor> ProductColors { get; set; }
    }
}
