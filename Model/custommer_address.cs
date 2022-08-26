using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestApi.Model
{
    public class custommer_address
    {
        [Key]
        public int id { get; set; }
        public custommer custommer { get; set; }
        public DateTime address { get; set; }
    }
}
