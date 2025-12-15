namespace lib00;

public class AverageCalculator
{
    public static double[] interndoubles = { };
    private int interncount = 0;
   private double sum = 0;

    public void add(double value)
    {
        interndoubles = interndoubles.Append(value).ToArray();
        interncount = interncount + 1;
    }
    public void add(double[] values)
    {
        for (int i = 0; i < values.Length; i++)
        {
            interndoubles = interndoubles.Append(values[i]).ToArray();
            interncount = interncount + 1;
        }

    }
    public int count()
    {
        return  interncount;
    }
    public double[] getElements()
    {
        return interndoubles;
    }
    public double getAverage()
    {
        for (int i = 0; i < interndoubles.Length; i++)
        {
            sum = sum + interndoubles[i];
            
        }
        return  sum/interndoubles.Length;
        
    }
    public string

}
