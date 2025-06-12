using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2sem7lab
{
    /// <summary>
    /// класс "Блюдо"
    /// </summary>
    public class Dish
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public CuisineType Cuisine { get; set; }
    }
}
