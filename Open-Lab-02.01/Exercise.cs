using System;

namespace Open_Lab_02._01
{
    public class Exercise
    {

        public double[] Create5Numbers()
        {
            Random rnd = new Random();
            double[] Create5Numbers = new double[5];
            Create5Numbers[0] = rnd.Next();
            Create5Numbers[1] = rnd.Next();
            Create5Numbers[2] = rnd.Next();
            Create5Numbers[3] = rnd.Next();
            Create5Numbers[4] = rnd.Next();

            return Create5Numbers;
        }

        public double GetSecond(double[] numbers)
        {
            return numbers[1];
        }
    }
}