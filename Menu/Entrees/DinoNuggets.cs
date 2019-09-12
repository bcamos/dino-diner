using System.Collection.Generic;

public class DinoNuggets
{
    private int nuggets = 6;

    public uint Calories
    {
        get
        {
            return nuggets * 59;
        }
    }

    public double Price {get; set;}

    public List<string> Ingredients
    {
        get
        {
            List<string> ingredients = new List<string>();
            for(int i = 0; i < nuggets; i++)
            {
                ingredients.Add("Chicken Nugget");
            }
            return ingredients;
        }
    }
    
	public DinoNuggets()
	{       
        Price = 4.25;
    }

    public void AddNugget()
    {
        nuggets++;
        Price += .25;
    }
    
}
