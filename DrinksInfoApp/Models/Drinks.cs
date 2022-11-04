using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinksInfoApp.Models
{
    public class Drinks
    {
        [JsonProperty("drinks")]

        public List<Drink> DrinksList { get; set; }
    }
}
