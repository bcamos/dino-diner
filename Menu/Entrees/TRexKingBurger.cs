/**
 * TRexKingBurger.cs
 * Author: Ben Amos
 */
using System.Collections.Generic;

/// <summary>
/// Class TRexKingBurger represents the menu item a T-Rex King Burger.
/// Per request by the customer, the bun, lettuce, tomato, onion, pickles, ketchup, mustard, and mayo can be removed.
/// </summary>
public class TRexKingBurger : Entree
{
    private bool bun = true; // Whether the bun is included
    private bool lettuce = true; // Whether the lettuce is included
    private bool tomato = true; // Whether tomato is included
    private bool onion = true; // Whether onion is included
    private bool pickle = true; // Whether pickles are included
    private bool ketchup = true; // Whether ketchup is included
    private bool mustard = true; // Whether mustard is included
    private bool mayo = true; // Whether mayo is included

    // A list containing all the ingredients of the T-Rex King Burger
    public List<string> Ingredients
    {
        get
        {
            List<string> ingredients = new List<string>();
            for (int i = 0; i < 3; i++)
                ingredients.Add("Steakburger Pattie");
            if (bun) ingredients.Add("Whole Wheat Bun");
            if (lettuce) ingredients.Add("Lettuce");
            if (tomato) ingredients.Add("Tomato");
            if (onion) ingredients.Add("Onion");
            if (pickle) ingredients.Add("Pickle");
            if (ketchup) ingredients.Add("Ketchup");
            if (mustard) ingredients.Add("Mustard");
            if (mayo) ingredients.Add("Mayo");
            return ingredients;
        }
    }

    /// <summary>
    /// Default constructor which initializes price and calories
    /// </summary>
	public TRexKingBurger()
	{
        Price = 8.45;
        Calories = 728;
	}

    /// <summary>
    /// Remove the bun from the burger
    /// </summary>
    public void HoldBun()
    {
        bun = false;
    }

    /// <summary>
    /// Remove the lettuce from the burger
    /// </summary>
    public void HoldLettuce()
    {
        lettuce = false;
    }

    /// <summary>
    /// Remove the tomatos from the burgers
    /// </summary>
    public void HoldTomato()
    {
        tomato = false;
    }

    /// <summary>
    /// Remove onions from the burger
    /// </summary>
    public void HoldOnion()
    {
        onion = false;
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

    /// <summary>
    /// Remove mayo from the burger
    /// </summary>
    public void HoldMayo()
    {
        mayo = false;
    }
} // end class TRexKingBurger
