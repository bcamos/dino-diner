using System;
using System.Collections.Generic;

public class Fryceritops : Side
{
    private Size size; 

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
                    Calories = 365;
                    break;
                case Size.Large:
                    Price = 1.95;
                    Calories = 480;
            }
        }
        get
        {
            return size;
        }
    }

	public Fryceritops() 
	{
        Price = 0.99;
        Calories = 420;
        Ingredients = new List<string>() { "potatoes", "salt", "vegtable oil" };
	}
}
