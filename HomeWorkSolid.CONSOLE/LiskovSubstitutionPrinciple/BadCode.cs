using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkSolid.CONSOLE.LiskovSubstitutionPrinciple
{
    internal interface IBird
    {
        void MakeSound();

        void Fly();

        void Run();
    }

    public class Duck : IBird
    {
        public void MakeSound()
        {
            Console.WriteLine("Making sound.");
        }

        public void Fly()
        {
            Console.WriteLine("Flying...");
        }

        public void Run()
        {
            Console.WriteLine("Running...");
        }
    }

    /* This breaks the Liskov substituion principle because if we follow polymorphism and call the Run() method from IBird reference variable
   then it will throw NotImplementedException.
    // Bu Liskov  ilkesini bozar, çünkü polimorfizmi izlersek ve Bird referans değişkeninden Run() metodu çağırırsak 
     o zaman NotImplementedException'ı atar.
     */

    public class Ostrich : IBird
    {
        public void MakeSound()
        {
            Console.WriteLine("Making sound.");
        }

        // Cannot fly.
        public void Fly()
        {
            throw new NotImplementedException();
        }

        public void Run()
        {
            Console.WriteLine("Running...");
        }
    }
}