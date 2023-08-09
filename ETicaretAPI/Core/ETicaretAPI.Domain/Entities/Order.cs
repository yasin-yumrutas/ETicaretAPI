using ETicaretAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Domain.Entities
{
   public class Order:BaseEntity 
    {
        public int CustomerId { get; set; }
        public string Description { get; set; } = string.Empty;
        public string Adress { get; set; } = string.Empty;

        public ICollection<Product> Products { get; set; } = new List<Product>();
        public Customer Customer { get; set; } = new Customer();
    }
}
