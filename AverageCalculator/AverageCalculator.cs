namespace lib00;

public class AverageCalculator
{
    public double[] interndoubles = Array.Empty<double>();
    private int interncount = 0;

    public void add(double value)
    {
        interndoubles = interndoubles.Append(value).ToArray();
        interncount++;
    }

    public void add(double[] values)
    {
        for (int i = 0; i < values.Length; i++)
        {
            interndoubles = interndoubles.Append(values[i]).ToArray();
            interncount++;
        }
    }

    public int count()
    {
        return interncount;
    }

    public double[] getElements()
    {
        return interndoubles;
    }

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
