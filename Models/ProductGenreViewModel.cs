using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace  MyWeb.Models
{
    public class ProductGenreViewModel
    {
        public List <Product> Products;
        
        public SelectList Genres { get; set; }

        public string ProductGenre { get; set; }             

        public string SearchString { get; set; }

    }
}
