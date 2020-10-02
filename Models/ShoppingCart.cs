using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CubeX.Models
{
    public class ShoppingCart
    {
        [Required]
        public string ID { get; set; }

        [DataType(DataType.Currency, ErrorMessage = "Value must be a Currency ex. $20")]
        public decimal Sum { get; set; }

        public string ApplicationUserID { get; set; }


        public virtual ICollection<CartItem> Items { get; set; }
    }
}