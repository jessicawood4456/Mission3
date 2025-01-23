using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission3
{
    public class FoodItem
    {
        public string name;
        public string category;
        public int quantity;
        public DateTime date;
        
        // Constructor that creates food item objects
        public FoodItem(string name, string category, int quantity, DateTime date)
        {
            this.name = name;
            this.category = category;
            this.quantity = quantity;
            this.date = date;
        }
    }
}
