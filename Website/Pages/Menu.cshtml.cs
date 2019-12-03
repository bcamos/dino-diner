using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DinoDiner.Menu;

namespace Website.Pages
{
    public class MenuModel : PageModel
    {
        public Menu Menu { get; set; }

        public List<CretaceousCombo> Combos { get; set; }

        public List<Entree> Entrees { get; set; }

        public List<Drink> Drinks { get; set; }

        public List<Side> Sides { get; set; }

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
                Combos = Menu.FilterByName(Combos, search);
                Entrees = Menu.FilterByName(Entrees, search);
                Drinks = Menu.FilterByName(Drinks, search);
                Sides = Menu.FilterByName(Sides, search);
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
            if(minimumPrice != null)
            {
                Combos = Menu.FilterByMinPrice(Combos, (float)minimumPrice);
                Entrees = Menu.FilterByMinPrice(Entrees, (float)minimumPrice);
                Drinks = Menu.FilterByMinPrice(Drinks, (float)minimumPrice);
                Sides = Menu.FilterByMinPrice(Sides, (float)minimumPrice);
            }

            //Filter on max price
            if (maximumPrice != null)
            {
                Combos = Menu.FilterByMaxPrice(Combos, (float)maximumPrice);
                Entrees = Menu.FilterByMaxPrice(Entrees, (float)maximumPrice);
                Drinks = Menu.FilterByMaxPrice(Drinks, (float)maximumPrice);
                Sides = Menu.FilterByMaxPrice(Sides, (float)maximumPrice);
            }
        }
    }
}