namespace lib00;

public class AverageCalculator
{
    public double[] interndoubles = Array.Empty<double>();
    private int interncount = 0;
/// <summary>
/// adds one singel double number
/// </summary>
/// <param name="value">the double value you want to add</param>
    public void add(double value)
    {
        interndoubles = interndoubles.Append(value).ToArray();
        interncount++;
    }
/// <summary>
/// adds an array of double values
/// </summary>
/// <param name="values"> the array you want to add</param>
    public void add(double[] values)
    {
        for (int i = 0; i < values.Length; i++)
        {
            interndoubles = interndoubles.Append(values[i]).ToArray();
            interncount++;
        }
    }
/// <summary>
/// returns the count of how many values where added
/// </summary>
/// <returns>returns the int value</returns>
    public int count()
    {
        return interncount;
    }
/// <summary>
/// Returns the double array full of the values that where added
/// </summary>
/// <returns>returns the array</returns>
    public double[] getElements()
    {
        return interndoubles;
    }
/// <summary>
/// Method that calculates the average of the double Array
/// </summary>
/// <returns>returns the average</returns>
    public double getAverage()
    {
        double sum = 0;
        for (int i = 0; i < interndoubles.Length; i++)
        {
            sum += interndoubles[i];
        }
        return sum / interndoubles.Length;
    }
}
