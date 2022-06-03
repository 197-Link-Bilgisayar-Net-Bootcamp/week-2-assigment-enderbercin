using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkSolid.CONSOLE.LiskovSubstitutionPrinciple
{
    internal interface IBird2
    {
        void MakeSound();

        void Run();
    }

    internal interface IFlyingBird : IBird
    {
        void Fly();
    }

    public class Duck2 : IFlyingBird
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

    public class Ostrich2 : IBird2
    {
        public void MakeSound()
        {
            Console.WriteLine("Making sound.");
        }

        public void Run()
        {
            Console.WriteLine("Running...");
        }
    }
}
