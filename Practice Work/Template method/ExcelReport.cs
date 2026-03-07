using System;

public class ExcelReport : ReportGenerator
{
    protected override void FormatData()
    {
        LogStep("Formatting data for Excel");
    }

    protected override void CreateHeader()
    {
        LogStep("Creating Excel header");
    }

    protected override void CreateBody()
    {
        LogStep("Creating Excel body");
    }

    protected override void SaveReport()
    {
        LogStep("Saving Excel report as .xlsx file");
    }
}