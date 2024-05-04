using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Just_Nom
{
    public class Burger
    {
        public string Name { get; }
        private List<string> garnishes = new List<string>();
        public decimal Price { get; set; }

        public Burger(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public void AddGarnishes(string[] arreyGarnishes) 
        {
            foreach (string garnish in arreyGarnishes) 
            {
                garnishes.Add(garnish);
            }
        }
    }
}
