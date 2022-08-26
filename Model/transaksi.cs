using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestApi.Model
{
    public class transaksi
    {
        [Key]
        public int id { get; set; }
        public product product { get; set; }
        public payment_method payment_Method { get; set; }
        public custommer_address custommer_Address { get; set; }
    }
}
