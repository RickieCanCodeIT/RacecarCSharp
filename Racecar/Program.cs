using System;

namespace Racecar
{
    class Program
    {
        private static Racecar redCar;
        private static Racecar blueCar;
        private static Racecar greenCar;
        private static Racecar yellowCar;
        /*The results of this race are incorrect, the correct result is:
            Red Car in 1st with 2272.5 feet travelled
            Blue Car in 4th with 1890 feet travelled
            Green Car in 2nd with 2191.5 feet travelled
            Yellow Car in 3rd with 2163 feet travelled
         */
        static void Main(String[] args)
        {
            redCar = new Racecar("Red Car", 60f, 5f);
            blueCar = new Racecar("Blue Car", 40f, 10f);
            greenCar = new Racecar("Green Car", 70f, 4f);
            yellowCar = new Racecar("Yellow Car", 50f, 7f);
            for (int counter = 0; counter < 50; counter++)
            {
                if (counter % 10 == 5)
                {
                    Console.WriteLine("The cars hit a turn!");
                    redCar.Turn();
                    blueCar.Turn();
                    greenCar.Turn();
                    yellowCar.Turn();
                }
                redCar.Accelerate();
                redCar.Move();
                Console.WriteLine(redCar.ToString());
                blueCar.Accelerate();
                blueCar.Move();
                Console.WriteLine(blueCar.ToString());
                greenCar.Accelerate();
                greenCar.Move();
                Console.WriteLine(greenCar.ToString());
                yellowCar.Accelerate();
                yellowCar.Move();
                Console.WriteLine(yellowCar.ToString());
                analyzeLeader();
            }
        }

        public static void analyzeLeader()
        {
            int[] currentPositions = Racecar.DeterminePositions(redCar, blueCar, greenCar, yellowCar);
            redCar.OutputPosition(currentPositions[0]);
            blueCar.OutputPosition(currentPositions[1]);
            greenCar.OutputPosition(currentPositions[2]);
            yellowCar.OutputPosition(currentPositions[3]);
            Console.WriteLine();
        }
    }
}
