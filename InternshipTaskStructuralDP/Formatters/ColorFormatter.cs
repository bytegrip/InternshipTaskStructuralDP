namespace InternshipTaskStructuralDP.Formatters;

public class ColorFormatter(ITextFormatter? formatter, string foreground, string background = "default")
    : FormatterDecorator(formatter)
{
    public override string? Format(string? text)
    {
        return Formatter?.Format(text);
    }

    public override string GetDescription()
    {
        var colorDesc = $" with {foreground} text";
        if (background != "default")
        {
            colorDesc += $" on {background} background";
        }
        return Formatter?.GetDescription() + colorDesc;
    }
}