using System;

namespace CSHMWK3
{
    class Program
    {
        static void Main(string[] args)
        {
            Supercar Make = new Supercar("Lotus Elise", "NA", "Black");
                      
        }
    }
    public class Supercar
    {
        public static string _makeModel { set; get; }
        public static string _engine { set; get; }
        public static string _color { set; get; }//can we randomize it?

        public Supercar(string makeModel, string engine, string color)
        {
            _makeModel = makeModel;
            _engine = engine;
            _color = color;

            Console.WriteLine("The car you've ordered has arrived {0}.", makeModel);
            Console.WriteLine("The engine your car has is {0}.", engine);
            Console.WriteLine("The color of you car is {0}.", color);

        }

    }
}
