using System;

namespace Ball_pit_problem__Subroutines_task_
{
    class Program
    {
        // constants used as these values do not change
        const double pi = 3.142;
        const double packing_density = 0.75;

        // working out volume of the pit
        static double Volume_of_pit(double ball_pit_radius, double ball_pit_height)
        {
            double Vol_of_pit = pi * (ball_pit_radius * ball_pit_height) * ball_pit_height;
            return Vol_of_pit;

        }

        // volume of one ball 
        static double Volume_of_ball(double ball_radius)
        {
            double Vol_of_ball = (4 / 3) * pi * (ball_radius * ball_radius * ball_radius);
            return Vol_of_ball;

        }

        // taking inputs in main
        static void Main(string[] args)
        {

            Console.WriteLine("Enter radius of ball pit in Metres: ");
            double BALL_PIT_RADIUS = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter height of ball pit in metres: ");
            double  BALL_PIT_HEIGHT = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter ball radius in metres: " );
            double  BALL_RADIUS = double.Parse(Console.ReadLine());


            Console.WriteLine("To fill this ball pit you will need {0:00} balls", (Volume_of_pit(BALL_PIT_RADIUS, BALL_PIT_HEIGHT) / Volume_of_ball(BALL_RADIUS)) * packing_density);
            // 0.00 is used to round up the balls as you want an exact value not a decimal number
        }
    }
}
