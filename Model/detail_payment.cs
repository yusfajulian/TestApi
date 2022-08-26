using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestApi.Model
{
    public class detail_payment
    {
        [Key]
        public int id { get; set; }
        public payment_method payment_Method { get; set; }
        public  int jumlah { get; set; }
    }
}
