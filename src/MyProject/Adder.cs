namespace MyProject;

/// <summary>
/// Adder holds an additive number and can add it to other numbers.
/// </summary>
public class Adder
{
    /// <summary>
    /// The additive number.
    /// </summary>
    private int _additiveNumber;

    /// <summary>
    /// Creates a new Adder with the given additive number.
    /// </summary>
    /// <param name="additiveNumber"></param>
    public Adder(int additiveNumber)
    {
        _additiveNumber = additiveNumber;
    }

    /// <summary>
    /// Adds the additive number to the given number.
    /// </summary>
    /// <param name="number">The number to add to.</param>
    /// <returns>The sum of the additive number and the given number.</returns>
    public int Add(int number)
    {
        return number + _additiveNumber;
    }
}
