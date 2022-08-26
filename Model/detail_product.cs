using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestApi.Model
{
    public class detail_product
    {
        [Key]
        public int id { get; set; }
        public product product { get; set; }
        public int jumlah { get; set; }
    }
}
