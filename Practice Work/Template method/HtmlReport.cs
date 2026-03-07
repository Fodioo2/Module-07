using System;

public class HtmlReport : ReportGenerator
{
    protected override void FormatData()
    {
        LogStep("Formatting data for HTML");
    }

    protected override void CreateHeader()
    {
        LogStep("Creating HTML header");
    }

    protected override void CreateBody()
    {
        LogStep("Creating HTML body");
    }

    protected override void SaveReport()
    {
        LogStep("Saving HTML report as .html file");
    }
}