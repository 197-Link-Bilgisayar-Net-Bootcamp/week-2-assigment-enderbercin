using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkSolid.CONSOLE.InterfaceSegregationPrinciple
{
    internal interface ILead
    {
        void CreateSubTask();
        void AssginTask();
    }

    internal interface IProgrammer
    {
        void WorkOnTask();
    }

    // Clients
    internal class Manager2 : ILead
    {
        public void CreateSubTask()
        {
            Console.WriteLine("Task created.");
        }

        public void AssginTask()
        {
            Console.WriteLine("Task assigned.");
        }
    }

    internal class TeamLead2 : ILead, IProgrammer
    {
        public void CreateSubTask()
        {
            Console.WriteLine("Task created.");
        }

        public void AssginTask()
        {
            Console.WriteLine("Task assigned.");
        }

        public void WorkOnTask()
        {
            Console.WriteLine("Started working on the task.");
        }
    }

    internal class Programmer2 : IProgrammer
    {
        public void WorkOnTask()
        {
            Console.WriteLine("Started working on the task.");
        }
    }

}
