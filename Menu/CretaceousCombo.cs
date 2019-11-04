/** CretaceousCombo.cs
 * Author: Nathan Bean, Ben Amos
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class CretaceousCombo : IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        // Backing Variables          
        private Entree entree;
        private Size size;
        private Drink drink = new Sodasaurus();
        private Side side = new Fryceritops();

        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        
        /// <summary>
        /// Gets and sets the entree
        /// </summary>
        public Entree Entree
        {
            get
            {
                return entree;
            }
            protected set
            {
                entree = value;                
                NotifyOfPropertyChanged("Entree");
                NotifyOfAllPropertyChanges();
            }
        }

        
        /// <summary>
        /// Gets and sets the side
        /// </summary>
        public Side Side
        {
            get
            {
                return side;
            }
            set
            {
                side = value;
                NotifyOfPropertyChanged("Side");
                NotifyOfAllPropertyChanges();
            }
        }       


        /// <summary>
        /// Gets and sets the drink
        /// </summary>
        public Drink Drink
        {
            get
            {
                return drink;
            }
            set
            {
                drink = value;
                NotifyOfPropertyChanged("Drink");
                NotifyOfAllPropertyChanges();
            }
        }

        /// <summary>
        /// Gets the price of the combo
        /// </summary>
        public double Price
        {
            get
            {
                return Entree.Price + Side.Price + Drink.Price - 0.25;
            }
        }

        /// <summary>
        /// Gets the calories of the combo
        /// </summary>
        public uint Calories
        {
            get
            {
                return Entree.Calories + Side.Calories + Drink.Calories;
            }
        }

        /// <summary>
        /// Gets or sets the size of the combo
        /// </summary>
        public Size Size
        {
            get { return size; }
            set
            {
                size = value;
                Drink.Size = value;
                Side.Size = value;
                NotifyOfAllPropertyChanges();
            }
        }

        /// <summary>
        /// Gets the list of ingredients for the combo
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.AddRange(Entree.Ingredients);
                ingredients.AddRange(Side.Ingredients);
                ingredients.AddRange(Drink.Ingredients);
                return ingredients;
            }
        }

        /// <summary>
        /// A description of what the combo is
        /// </summary>
        public string Description
        {
            get
            {
                return this.ToString();
            }
        }

        /// <summary>
        /// An array of all the special accomodations to this order of a combo
        /// </summary>
        public string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                special.AddRange(Entree.Special);
                special.Add(Side.Description);
                special.AddRange(Side.Special);
                special.Add(Drink.Description);
                special.AddRange(Drink.Special);
                return special.ToArray();
            }
        }

        /// <summary>
        /// Constructs a new combo with the specified entree
        /// </summary>
        /// <param name="entree">The entree to use</param>
        public CretaceousCombo(Entree entree)
        {
            this.Entree = entree;
        }

        /// <summary>
        /// Notify of all property changes
        /// </summary>
        public void NotifyOfAllPropertyChanges()
        {            
            NotifyOfPropertyChanged("Special");
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Price");
            NotifyOfPropertyChanged("Calories");
            NotifyOfPropertyChanged("Description");
        }

        /// <summary>
        /// Returns what the combo is
        /// </summary>
        /// <returns>What the combo is</returns>
        public override string ToString()
        {
            return Entree.ToString() + " Combo";
        }       
    }
}
