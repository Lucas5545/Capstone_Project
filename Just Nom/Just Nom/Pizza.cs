using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Just_Nom
{
    public class Pizza
    {
        public string Name { get; }
        private List<string> toppings = new List<string>();
        public decimal Price { get; set; }

        public Pizza(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public void AddToppings(string[] arreyToppings)
        {
            foreach (string topping in arreyToppings)
            {
                toppings.Add(topping);
            }
        }
    }
}
