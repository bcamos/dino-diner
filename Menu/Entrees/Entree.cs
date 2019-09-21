/** Entree.cs
 * Author: Ben Amos
 */
using System.Collections.Generic;

/// <summary>
/// Abstract class to represent an entree
/// </summary>
public abstract class Entree
{
    /// <summary>
    /// The price of the entree
    /// </summary>
    public double Price { get; set; }

    /// <summary>
    /// The calories of the entree
    /// </summary>
    public virtual uint Calories { get; set; }

    /// <summary>
    /// The ingredients of the entree
    /// </summary>
    public abstract List<string> Ingredients { get; }

}
