using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Order
    {
        public int Id { get; set; }
        [Required]
        public int ProductId { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public System.DateTime Date { get; set; }
        [Required]
        public int CustomerId { get; set; }
        [Required]
        public string Status { get; set; }
    }
}
