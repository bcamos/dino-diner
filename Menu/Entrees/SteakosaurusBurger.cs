/**
 * SteakosaurusBurger.cs
 * Author: Ben Amos
 */
using System.Collections.Generic;

/// <summary>
/// Class SteakosaurusBurger represents the menu item a SteakosaurusBurger. 
/// Per request by the customer, the bun, pickles, kethcup and mustard may be removed.
/// </summary>
public class SteakosaurusBurger
{
    private bool bun = true; // Whether the bun is included
    private bool pickle = true; // Whether pickles are included
    private bool ketchup = true; // Whether ketchup is included
    private bool mustard = true; // Whether mustard is included

    public double Price { get; set; } // The selling price of the Steakosaurus Burger
    public uint Calories { get; set; } // The total calories of the Steakosaurus Burger

    // A list containing all the ingredients in the Steakosaurus Burger
    public List<string> Ingredients
    {
        get
        {
            List<string> ingredients = new List<string>() { "Steakburger Pattie" };
            if (bun) ingredients.Add("Whole Wheat Bun");
            if (pickle) ingredients.Add("Pickle");
            if (ketchup) ingredients.Add("Ketchup");
            if (mustard) ingredients.Add("Mustard");
            return ingredients;
        }
    }

    /// <summary>
    /// Default constructor which initializes price and calories
    /// </summary>
	public SteakosaurusBurger()
	{
        Price = 5.15;
        Calories = 621;
	}

    /// <summary>
    /// Remove the bun from the burger
    /// </summary>
    public void HoldBun()
    {
        bun = false;
    }

    /// <summary>
    /// Remove pickles from the burger
    /// </summary>
    public void HoldPickle()
    {
        pickle = false;
    }

    /// <summary>
    /// Remove ketchup from the burger
    /// </summary>
    public void HoldKetchup()
    {
        ketchup = false;
    }

    /// <summary>
    /// Remove mustard from the burger
    /// </summary>
    public void HoldMustard()
    {
        mustard = false;
    }
} // end class SteakosaurusBurger
