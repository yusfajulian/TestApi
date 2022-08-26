using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestApi.Model
{
    public class product
    {
        [Key]
        public int id { get; set; }
        public string name_product { get; set; }
        public int price { get; set; }
    }
}
