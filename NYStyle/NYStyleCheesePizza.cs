using System;
using System.Collections.Generic;
using System.Text;

namespace p1zzaitoshisae
{
    class NYStyleCheesePizza : Pizza
    {
        public NYStyleCheesePizza()
        {
            name = "NY Style Sauce and Cheese Pizza";
            dough = "Thin Crust Dough";
            sauce = "Mariana sauce";
            toppings.Add("Grated Reggia Cheese");
        }
    }
}
