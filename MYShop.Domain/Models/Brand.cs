using MyShop.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Domain.Models
{
    public class Brand : BaseModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public int EstablishedYear{ get; set; }
        public string Description { get; set; }
    }
}
