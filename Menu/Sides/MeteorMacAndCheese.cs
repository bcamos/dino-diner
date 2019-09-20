/** MeteorMacAndCheese.cs
 * Author: Ben Amos
 */
using System.Collections.Generic;

/// <summary>
/// Class MeteorMacAndCheese represents the side and menu item Meteor Mac And Cheese
/// </summary>
public class MeteorMacAndCheese : Side
{
    private Size size;

    /// <summary>
    /// The size that was ordered
    /// </summary>
    public override Size Size
    {
        set
        {
            size = value;
            switch(size)
            {
                case Size.Small:
                    Price = 0.99;
                    Calories = 420;
                    break;
                case Size.Medium:
                    Price = 1.45;
                    Calories = 490;
                    break;
                case Size.Large:
                    Price = 1.95;
                    Calories = 520;
                    break;
            }
        }
        get
        {
            return size;
        }
    }

    /// <summary>
    /// Default constructor initializes price, calories, and ingredients
    /// </summary>
	public MeteorMacAndCheese()
	{
        Price = 0.99;
        Calories = 420;
        Ingredients = new List<string>() { "Macaroni Noodles", "Cheese Product", "Pork Sausage" };
    }
}
