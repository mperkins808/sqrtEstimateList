using System;
using System.Collections.Generic;
using System.Text;

namespace SquareEstimate
{
    class SquareRootEstimate
    {
        private List<double> sqrtList = new List<double>();
        private double interval;
        private double input;
        private double size;

        public SquareRootEstimate()
        {
        }
        public List<double> getSqrtList()
        {
            return this.sqrtList;
        }

        public void setSqrtList(List<double> sqreList)
        {
            this.sqrtList = sqreList;
        }


        public double getSqrt(double input, int round)
        {
            return Math.Round(Math.Sqrt(input), round);
        }

        public double getSqrtEstimate(double input, int round)
        {
            double estimate = sqrtList[getIndex(input)];
            return Math.Round(estimate, round);
        }

        public List<double> generateSqrtList(double input, int roundTo, int size, double interval)
        {
            //Storing for later use
            this.input = Math.Abs(input);
            this.size = size;
            this.interval = interval;
            if (sqrtList != null)
            {
                try
                {
                    for (double i = input; i < size; i += Math.Abs(interval))
                    {
                        sqrtList.Add(Math.Round(Math.Sqrt(input), roundTo));
                        input += interval;
                    }
                }
                catch
                {
                    throw new IndexOutOfRangeException("One of the parameters was out of range or negative");
                }
            }
            else throw new ArgumentNullException("List was Empty");

            return sqrtList;
        }

        //WORKS WITH THE FOMULA || SqrtToFind = Input + (Interval X Series) --> Series = (SqrtToFind-Input) / Interval 
        //For example we want to find the Square Root of 10 without recalculating the value. For this example Input is 2 and Interval is 0.1
        // 10 = Input + (Interval * S) --> 10 = 2 + 0.1S --> S/10 = 8 --> S = 80 --> We then track to the 80th entry to find the Sqrt
        private int getIndex(double sqrtToFind)
        {
            double index = (sqrtToFind - input) / interval;
            int indexRnd = (int)Math.Round(index, 1);
            return indexRnd;
        }
        public void toString(List<double> input)
        {
            int newline = 0;
            const int LINE_GAP = 12;
            for (int i = 0; i < input.Count; i++)
            {
                if (newline == LINE_GAP)
                {
                    newline = 0;
                    Console.WriteLine();
                }
                    newline++;
                    Console.Write("|" + Convert.ToString(input[i]));
            }

        }

    }
}
