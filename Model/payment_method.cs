using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestApi.Model
{
    public class payment_method
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public int is_active { get; set; }
    }
}
