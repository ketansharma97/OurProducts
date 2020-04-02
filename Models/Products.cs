using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OurProducts.Models
{
    [Table("Product")]
    public class Products
    {
        [Key]
        public int PId { get; set; }
        public string Pname { get; set; }
        public string Pdesc { get; set; }
        public int Pprice { get; set; }
    }
}
