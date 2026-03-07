using System;

public class CsvReport : ReportGenerator
{
    protected override void FormatData()
    {
        LogStep("Formatting data for CSV");
    }

    protected override void CreateHeader()
    {
        LogStep("Creating CSV header");
    }

    protected override void CreateBody()
    {
        LogStep("Creating CSV body");
    }

    protected override void SaveReport()
    {
        LogStep("Saving CSV report as .csv file");
    }
}