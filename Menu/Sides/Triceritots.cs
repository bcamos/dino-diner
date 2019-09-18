using System;

public class Triceritots : Side
{
    private Size size;

    public override Size Size {
        set{
            size = value;
            switch(size)
            {
                case Size.Small:
                    Price = .99;
                    Calories = 352;
                    break;
                case Size.Medium:
                    Price = 1.45;
                    Calories = 410;
                    break;
                case Size.Large:
                    Price = 1.95;
                    Calories = 590;
            }
        }
        get
        {
            return size;
        }
    }

	public Triceritots(Size size)
	{
        Price = .99;
        Calories = 352;
        Ingredients.Add("Potato");
        Ingredients.Add("Breading");
        Ingredients.Add("Vegetable Oil");
	}
}
