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
    public uint Calories { get; set; }

    /// <summary>
    /// The ingredients of the entree
    /// </summary>
    protected List<string> Ingredients { get; protected set; }

}
