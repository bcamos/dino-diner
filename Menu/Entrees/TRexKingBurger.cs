using System.Collections.Generic;

public class TRexKingBurger
{
    private bool bun = true;
    private bool lettuce = true;
    private bool tomato = true;
    private bool onion = true;
    private bool pickle = true;
    private bool ketchup = true;
    private bool mustard = true;
    private bool mayo = true;

    public double Price { get; set; }
    public uint Calories { get; set; }
    public List<string> Ingredients
    {
        get
        {
            List<string> ingredients = new List<string>() { "Three Steakburger Patties" };
            if (bun) ingredients.Add("Whole Wheat Bun");
            if (lettuce) ingredients.Add("Lettuce");
            if (tomato) ingredients.Add("Tomato");
            if (onion) ingredients.Add("Onion");
            if (pickle) ingredients.Add("Pickle");
            if (ketchup) ingredients.Add("Ketchup");
            if (mustard) ingredients.Add("Mustard");
            if (mayo) ingredients.Add("Mayo");
        }
    }

	public TRexKingBurger()
	{
        Price = 8.45;
        Calories = 728;
	}

    public void HoldBun()
    {
        bun = false;
    }

    public void HoldLettuce()
    {
        lettuce = false;
    }

    public void HoldTomato()
    {
        tomato = false;
    }

    public void HoldOnion()
    {
        onion = false;
    }

    public void HoldPickle()
    {
        pickle = false;
    }

    public void HoldKetchup()
    {
        ketchup = false;
    }

    public void HoldMustard()
    {
        mustard = false;
    }

    public void HoldMayo()
    {
        mayo = false;
    }
}
