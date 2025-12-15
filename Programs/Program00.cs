using lib00;

namespace Program00
{
    public class Program00
    {
        public static int Main()
        {
            double[] startarray= {3.6,3.7};
            var Calculator1 = new AverageCalculator();
            Calculator1.add(2.3);
            Calculator1.add(3.5);
            Calculator1.add(startarray);
            Calculator1.add(5.5);
            int count = Calculator1.count();
            System.Console.WriteLine(count);
            double[] array = Calculator1.getElements();

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            return 0;
        }
    }
}
