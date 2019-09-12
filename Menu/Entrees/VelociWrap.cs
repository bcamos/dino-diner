using System.Collections.Generic;

public class VelociWrap
{
    private bool dressing = true;
    private bool lettuce = true;
    private bool cheese = true;

    public double Price { get; set; }
    public uint Calories { get; set; }
    public List<string> Ingredients
    {
        get
        {
            List<string> ingredients = new List<string>() { "Flour Tortilla", "Chicken Breast" };
            if (dressing) ingredients.Add("Ceasar Dressing");
            if (lettuce) ingredients.Add("Lettuce");
            if (cheese) ingredients.Add("Parmesan Cheese");
            return ingredients;
        }
    }
       
	public VelociWrap()
	{
        Price = 6.86;
        Calories = 356;
	}

    public void HoldDressing()
    {
        dressing = false;
    }

    public void HoldLettuce()
    {
        lettuce = false;
    }

    public void HoldCheese()
    {
        cheese = false;
    }
}
