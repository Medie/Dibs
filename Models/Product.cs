using System;
using System.ComponentModel.DataAnnotations;
namespace MyWeb.Models {
        public class Product {
            public Product (int iD, string title, DateTime releaseDate, string genre, decimal price, string rating) {
                this.ID = iD;
                this.Title = title;
                this.ReleaseDate = releaseDate;
                this.Genre = genre;
                this.Price = price;
                this.Rating = rating;

            }
            public int ID { get; set; }

            [StringLength (60, MinimumLength = 3)]
            [Required]

            public string Title { get; set; }

            [Display (Name = "Expire Date")]
            [DataType (DataType.Date)]

            public DateTime ReleaseDate { get; set; }

            [Range (1, 100)]
            [DataType (DataType.Currency)]

            public decimal Price { get; set; }

            [RegularExpression (@"^[A-Z]+[a-zA-Z""'\s-]*$")]
            [Required]

            [StringLength (30)]
            public string Genre { get; set; }

            [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
            [StringLength (5)]
            [Required]

            public string Rating { get; set; }
        }
}