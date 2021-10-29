using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace hmart.Models
{
    public class Review
    {
        public int Id { get; set; }

        public double Rate { get; set; }

        [StringLength(maximumLength: 700)]
        public string Message { get; set; }

        public DateTime Date { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }
    }
}
