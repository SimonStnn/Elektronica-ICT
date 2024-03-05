using System;

namespace LightApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the light show ...");


            LightBulb bathroom = new LightBulb();       
            LightBulb living = new LightBulb(20);       

            Console.WriteLine(living);

            living.On();

            Console.WriteLine(living);

            living.Dim(30);

            Console.WriteLine(living);
            living.Off();
            living.On();
            Console.WriteLine(living);

            LightBulb kitchen = new LightBulb(0, "Kitchen");
            Console.WriteLine(kitchen);
            kitchen.On();
            Console.WriteLine(kitchen);
            kitchen.Dim(30);
            Console.WriteLine(kitchen);

            Color blue = new Color(0, 0, 255);
            Color seaBlue = new Color(0, 125, 255);
            Color orange = new Color(255, 150, 0);

            Console.WriteLine(blue);
            Console.WriteLine(seaBlue);
            Console.WriteLine(orange);

            RgbLed alive = new RgbLed();
            Console.WriteLine(alive);
            alive.SetColor(orange);
            Console.WriteLine(alive);
            alive.On();
            Console.WriteLine(alive);

            Color green = new Color(0, 255, 0);
            green.Dim(20);
            Console.WriteLine(green);

            RgbLed fading = new RgbLed();
            fading.On();
            Color white = new Color(255, 255, 255);
            fading.SetColor(white); 
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine(fading);
                white.Dim(i * 10);
            }
        }
    }
}
