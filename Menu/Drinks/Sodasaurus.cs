using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;

namespace DinoDiner.Menu.Drinks
{
    public class Sodasaurus
    {
        private SodasaurusFlavor flavor;
        private Size size;

        public SodasaurusFlavor Flavor
        {
            get
            {
                return flavor;
            }
            set
            {
                flavor = value;
            }
        }

        public double Price { get; set; } = 1.5;

        public Size Size
        {
            get
            {
                return size;
            }
            set
            {
                switch(value)
                {
                    case Size.Small:
                        size = Size.Small;
                        Price = 1.5;
                        break;
                    case Size.Medium:
                        size = Size.Medium;
                        Price = 2;
                        break;
                    case Size.Large:
                        size = Size.Large;
                        Price = 2.5;
                        break;
                }
            }
        }

        public bool Ice { get; set; } = true;

        public Sodasaurus()
        {
            
        }
    }
}
