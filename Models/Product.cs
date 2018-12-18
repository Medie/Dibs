using System;
using System.ComponentModel.DataAnnotations;
namespace MyWeb.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Title { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        
        [Display(Name = "Expire Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        public string Genre { get; set; }
        public decimal Price { get; set; }

        public string Rating { get; set; }
    }
}