using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("=== REPORT GENERATOR ===");
            Console.WriteLine("1 - PDF Report");
            Console.WriteLine("2 - Excel Report");
            Console.WriteLine("3 - HTML Report");
            Console.WriteLine("4 - CSV Report");
            Console.WriteLine("0 - Exit");
            Console.Write("Choose report type: ");

            string? input = Console.ReadLine();

            if (!int.TryParse(input, out int choice))
            {
                Console.WriteLine("Invalid input.\n");
                continue;
            }

            if (choice == 0)
                break;

            ReportGenerator? report = choice switch
            {
                1 => new PdfReport(),
                2 => new ExcelReport(),
                3 => new HtmlReport(),
                4 => new CsvReport(),
                _ => null
            };

            if (report == null)
            {
                Console.WriteLine("Unknown report type.\n");
                continue;
            }

            Console.WriteLine();
            report.GenerateReport();
        }
    }
}