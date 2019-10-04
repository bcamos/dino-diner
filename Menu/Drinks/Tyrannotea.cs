﻿/* Tyrannotea.cs
 * Author: Ben Amos
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    /// <summary>
    /// Class Tyrannotea represents the menu item tyronnotea which is tea
    /// </summary>
    public class Tyrannotea : Drink
    {
        private Size size;
        private bool sweet;

        /// <summary>
        /// Whether the tea contains sugar/sweetner in it
        /// </summary>
        public bool Sweet
        {
            get
            {
                return sweet;
            }
            set
            {
                if(value && !sweet)
                {
                    Calories *= 2;
                }
                else if(!value && sweet)
                {
                    Calories /= 2;
                }
                sweet = value;
            }
        }

        /// <summary>
        /// Whether the tea contains a lemon
        /// </summary>
        public bool Lemon { get; set; } = false;

        /// <summary>
        /// The size of the tea; adjusts price and calories as needed when changed.
        /// </summary>
        public override Size Size
        {
            get
            {
                return size;
            }
            set
            {
                switch (value)
                {
                    case Size.Small:
                        size = Size.Small;
                        Calories = 8;
                        Price = .99;
                        break;
                    case Size.Medium:
                        size = Size.Medium;
                        Calories = 16;
                        Price = 1.49;
                        break;
                    case Size.Large:
                        size = Size.Large;
                        Calories = 32;
                        Price = 1.99;
                        break;
                }
                if(Sweet)
                {
                    Calories *= 2;
                }
            }
        }

        /// <summary>
        /// The ingredients of the tea
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Water", "Tea" };
                if (Lemon) ingredients.Add("Lemon");
                if (Sweet) ingredients.Add("Cane Sugar");
                return ingredients;
            }
        }

        /// <summary>
        /// Default constructor sets tea to small
        /// </summary>
        public Tyrannotea()
        {
            Size = Size.Small;
        }

        public void AddLemon()
        {
            Lemon = true;
        }
    }
}