using System; // Namespace import
namespace HelloWorld
{
    class Hello
    {
        public static void Main()
        {
            double x;
            int p = 3;
            x = do_stuff(p); // Impl. Cast int --> double
            p = (int)x; // Expl. Cast double 
                        //          --> next int direction 0
            Console.WriteLine(string.Format(
                    "p is now 4: {0}, x is 4: {1}", p, x));
            Console.ReadKey(); // Sonst ist die Konsole weg!
        }
        public static int do_stuff(int p)
        {
            return ((p * 3 - 2) + 2) / 2;
        }
    }
}