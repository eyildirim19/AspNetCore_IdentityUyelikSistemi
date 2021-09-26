using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore_IdentityUyelikSistemi.Models
{
    public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public virtual List<Product> Products { get; set; }
    }

    public class Product
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }

    public class Dealer
    {
        public int ID { get; set; }

        public string Title { get; set; }

        public string ContactPerson { get; set; }
    }
}
