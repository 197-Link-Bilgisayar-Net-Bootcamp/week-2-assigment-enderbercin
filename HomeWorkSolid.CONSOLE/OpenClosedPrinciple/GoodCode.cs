using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkSolid.CONSOLE.OpenClosedPrinciple
{
    // This is good design example.

    internal interface IReportGeneration
    {
        void GenerateReport();
    }

    // Clients
    internal class PdfReportGeneration : IReportGeneration
    {
        public void GenerateReport()
        {
            Console.WriteLine("Generating pdf report.");
        }
    }

    internal class CsvReportGeneration : IReportGeneration
    {
        public void GenerateReport()
        {
            Console.WriteLine("Generating csv report.");
        }
    }
}
