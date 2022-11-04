using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinksInfoApp.Models
{
    public class Categories
    {
        [JsonProperty("drinks")]

        public List<Category> CategoriesList { get; set; }
    }
}
