using System;

namespace Automatikus_szemet
{
    
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Vegtelen v = new Vegtelen();
                
            }
        }
    }
    class Vegtelen
    {
        public static int ObjCounter = 0;
        public Vegtelen()
        {
            ObjCounter++;
            Console.WriteLine("Az objektumok száma: {0}", ObjCounter);
        }
        ~Vegtelen()
        {
            ObjCounter--;
            Console.WriteLine("Az objektumok száma: {0}", ObjCounter);
        }
    }
}
