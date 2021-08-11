using System;

namespace LineCopmOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comaprison Computation");
            Program lengthOfLine = new Program();
            //call function to set value
            lengthOfLine.LengthOfLine(5, 6, 7, 5);
            double line1 = lengthOfLine.LengthOfLine(5, 6, 7, 5);
            double line2 = lengthOfLine.LengthOfLine(2, 8, 1, 12);

            //Display Length of Lines
            Console.WriteLine(" Length of Line 1 : " + line1 + " \n");
            Console.WriteLine(" Length of Line 2 : " + line2 + " \n");

            //Check Equality
            Console.WriteLine("Length of Lines are Equal : " + line1.Equals(line2));
            lengthOfLine.Compare(line1, line2);
        }
        public double LengthOfLine(int x1, int y1, int x2, int y2)
        {
            //Operation
            double point1 = (x2 - x1);
            double point2 = (y2 - y1);
            double lengthOfLine = Math.Sqrt(Math.Pow(point1, 2) + Math.Pow(point2, 2));
            return lengthOfLine;

            //Display
            Console.WriteLine(" Line Point 1 : " + point1 + " \n");
            Console.WriteLine(" Line Point 2 : " + point2 + " \n");
            Console.WriteLine(" Length of Line : " + lengthOfLine + " \n");
        }
        public void Compare(double line1, double line2)
        {
            //Comaprison assign to Variable
            int linesCompare = (line1.CompareTo(line2));

            //Condition to Check Comparison
            if (linesCompare.Equals(0))
                Console.WriteLine(" Result : Both the lines are having same length or both lines are equal.");
            else if (linesCompare.Equals(-1))
                Console.WriteLine(" Result : Length of FirstLine Is lesser Than secondLine");
            else
                Console.WriteLine(" Result : Length of FirstLine Is Greater Than secondLine");

        }
    }
}
