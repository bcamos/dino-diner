using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DinoDiner.Menu;
using System.Linq;

namespace Website.Pages
{
    public class MenuModel : PageModel
    {
        public Menu Menu { get; set; }

        public IEnumerable<CretaceousCombo> Combos { get; set; }

        public IEnumerable<Entree> Entrees { get; set; }

        public IEnumerable<Drink> Drinks { get; set; }

        public IEnumerable<Side> Sides { get; set; }

        public void OnGet()
        {
            Menu = new Menu();
            Combos = Menu.AvailableCombos;
            Entrees = Menu.AvailableEntrees;
            Drinks = Menu.AvailableDrinks;
            Sides = Menu.AvailableSides;
        }

        public void OnPost(string search, List<string> menuCategory, float? minimumPrice, float? maximumPrice, List<string> ingredient)
        {
            Menu = new Menu();
            Combos = Menu.AvailableCombos;
            Entrees = Menu.AvailableEntrees;
            Drinks = Menu.AvailableDrinks;
            Sides = Menu.AvailableSides;

            //Filter on name
            if (search != null)
            {
                Combos = Combos.Where(combo => combo.ToString().Contains(search));
                Entrees = Entrees.Where(entree => entree.ToString().Contains(search));
                Drinks = Drinks.Where(drink => drink.ToString().Contains(search));
                Sides = Sides.Where(side => side.ToString().Contains(search));
            }

            //Filter on category
            if(menuCategory != null)
            {
                if(!menuCategory.Contains("Combo"))
                {
                    Combos = new List<CretaceousCombo>();
                }
                if(!menuCategory.Contains("Entree"))
                {
                    Entrees = new List<Entree>();
                }
                if(!menuCategory.Contains("Drink"))
                {
                    Drinks = new List<Drink>();
                }
                if(!menuCategory.Contains("Side"))
                {
                    Sides = new List<Side>();
                }
            }

            //Filter on min price
            if (minimumPrice != null)
            {
                Combos = Combos.Where(combo => combo.Price >= minimumPrice);
                Entrees = Entrees.Where(entree => entree.Price >= minimumPrice);
                Drinks = Drinks.Where(drink => drink.Price >= minimumPrice);
                Sides = Sides.Where(side => side.Price >= minimumPrice);
            }

            //Filter on max price
            if (maximumPrice != null)
            {
                Combos = Combos.Where(combo => combo.Price <= maximumPrice);
                Entrees = Entrees.Where(entree => entree.Price <= maximumPrice);
                Drinks = Drinks.Where(drink => drink.Price <= maximumPrice);
                Sides = Sides.Where(side => side.Price <= maximumPrice);
            }

            //Filter on ingredients
            if (ingredient != null)
            {
                Combos = Combos.Where(combo => combo.Ingredients.Where(ingred => ingredient.Contains(ingred)).Count() == 0);
                Entrees = Entrees.Where(entree => entree.Ingredients.Where(ingred => ingredient.Contains(ingred)).Count() == 0);
                Drinks = Drinks.Where(drink => drink.Ingredients.Where(ingred => ingredient.Contains(ingred)).Count() == 0);
                Sides = Sides.Where(side => side.Ingredients.Where(ingred => ingredient.Contains(ingred)).Count() == 0);
            }
        }
    }
}