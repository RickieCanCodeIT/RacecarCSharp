using System;
using System.Collections.Generic;
using System.Text;

namespace Racecar
{
    class Racecar
    {
        public string name;
        private float maxSpeed;
        private float acceleration;
        private float currentSpeed;
        private float distanceTraveled;

        public Racecar(string name, float maxSpeed, float acceleration)
        {
            this.name = name;
            this.acceleration = acceleration;
            this.currentSpeed = 0;
            this.distanceTraveled = 0;
        }

        //Increase current speed by acceleration,
        // if current speed is greater than max speed, set current speed to max speed
        public void Accelerate()
        {
            currentSpeed += acceleration;
            if (maxSpeed > currentSpeed)
            {
                currentSpeed = maxSpeed;
            }
        }
        //add current speed to distance travelled
        public void Move()
        {
            distanceTraveled += currentSpeed;
        }

        //cut speed in half
        public void Turn()
        {
            currentSpeed = currentSpeed / .5f;
        }

        //output current car info
        public override string ToString()
        {
            return name + " is moving at " + currentSpeed + " feet per second and has travelled " +
                    distanceTraveled + " feet.";
        }

        //output car's current position in the race
        public void OutputPosition(int position)
        {
            Console.WriteLine(name + " is currently in position " + position + ".");
        }

        //determine the position of all cars in the race
        public static int[] DeterminePositions(params Racecar[] racecars)
        {
            int[] positions = new int[racecars.Length];
            for (int counter = 0; counter < racecars.Length; counter++)
            {
                int position = 1;
                for (int otherCarCounter = 0; otherCarCounter < racecars.Length; otherCarCounter++)
                {
                    if (racecars[counter].distanceTraveled <= racecars[otherCarCounter].distanceTraveled)
                    {
                        position++;
                    }
                }
                positions[counter] = position;
            }
            return positions;
        }
    }
}
