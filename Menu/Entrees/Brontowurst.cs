using System.Collections.Generic;

public class Brontowurst
{
    private bool bun = true;
    private bool peppers = true;
    private bool onions = true;

    public double Price { get; set; }
    public uint Calories { get; set; }
    public List<string> Ingredients
    {
        get
        {
            List<string> ingredients = new List<string>() { "Brautwurst" };
            if (bun) ingredients.Add("Whole Wheat Bun");
            if (peppers) ingredients.Add("Peppers");
            if (onions) ingredients.Add("Onion");
        }
    }

    public Brontowurst()
    {
        Price = 5.36;
        Calories = 498;         
	}

    public void HoldBun()
    {
        bun = false;
    }

    public void HoldPeppers()
    {
        peppers = false;
    }

    public void HoldOnion()
    {
        onions = false;
    }
}