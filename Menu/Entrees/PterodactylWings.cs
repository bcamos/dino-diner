/**
 * PterodactylWings.cs
 * Author: Ben Amos
 */
using System.Collections.Generic;

/// <summary>
/// Class PterodactylWings represents the menu item Pterodactyl Wings.
/// </summary>
public class PterodactylWings : Entree
{

    // A list containing all the ingredients of the wings
    public override List<string> Ingredients
    {
        get
        {
            List<string> ingredients = new List<string>() { "Chicken", "Wing Sauce" };
            return ingredients;
        }
    }

    /// <summary>
    /// Default constructor which initializes price and calories
    /// </summary>
	public PterodactylWings()
	{
        Price = 7.21;
        Calories = 318;
	}
} // end class PterodactylWings
