using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; //Don't know what it's for

namespace CubeX.Models
{
    public class FoodItem
    {
        [Key] //Need to learn
        public string ID { get; set; }

        [Required]
        public string Name { get; set; }

        [DataType(DataType.Currency, ErrorMessage = "You did not enter a valid currency value ex. $15.6")]
        public decimal Price { get; set; }

        [ScaffoldColumn(false)] // neeed to understand
        public bool? isEnabled { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.ForeignKey("Category")]
        public int? CategoryID { get; set; }

        public Category Category { get; set; }

        [Required]
        [StringLength(128)]
        public string Discriminator { get; set; }

        [NotMapped]                            // need to learn
        public string CartItemId { get; set; } // need to learn
    }
}