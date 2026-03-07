using System;

public class PdfReport : ReportGenerator
{
    protected override void FormatData()
    {
        LogStep("Formatting data for PDF");
    }

    protected override void CreateHeader()
    {
        LogStep("Creating PDF header");
    }

    protected override void CreateBody()
    {
        LogStep("Creating PDF body");
    }

    protected override void SaveReport()
    {
        LogStep("Saving PDF report as .pdf file");
    }
}