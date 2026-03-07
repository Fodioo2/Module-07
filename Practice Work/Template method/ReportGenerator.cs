using System;

public abstract class ReportGenerator
{
    public void GenerateReport()
    {
        LogStep("Report generation started");
        LoadData();
        FormatData();
        CreateHeader();
        CreateBody();

        if (CustomerWantsSave())
        {
            SaveReport();
        }
        else
        {
            SendByEmail();
        }

        LogStep("Report generation finished");
        Console.WriteLine();
    }

    protected virtual void LoadData()
    {
        LogStep("Loading data");
    }

    protected abstract void FormatData();
    protected abstract void CreateHeader();
    protected abstract void CreateBody();

    protected virtual void SaveReport()
    {
        LogStep("Saving report to file");
    }

    protected virtual void SendByEmail()
    {
        LogStep("Sending report by email");
    }

    protected virtual bool CustomerWantsSave()
    {
        while (true)
        {
            Console.Write("Save report to file? (yes/no): ");
            string? answer = Console.ReadLine()?.Trim().ToLower();

            if (answer == "yes" || answer == "y")
                return true;

            if (answer == "no" || answer == "n")
                return false;

            Console.WriteLine("Incorrect input. Please enter yes or no.");
        }
    }

    protected void LogStep(string message)
    {
        Console.WriteLine($"[LOG] {message}");
    }
}