﻿using System;
using System.Collections.Generic;
using System.Text;

namespace p1zzaitoshisae
{
    class ChicagoPizzaStore : PizzaStore
    {
        protected override Pizza createPizza(string type)
        {
            if (type == "cheese")
            {
                return new ChicagoStyleCheesePizza();
            }
            else if (type == "veggie")
            {
                return new ChicagoStyleVeggiePizza();
            }
            return null;
        }

    }
}
