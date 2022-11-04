using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinksInfoApp.Models
{
    internal class DrinkDetailObject
    {
        [JsonProperty("drinks")]

        public List<DrinkDetail> DrinkDetailList { get; set; }
    }
}
