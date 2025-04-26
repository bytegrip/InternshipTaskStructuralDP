namespace InternshipTaskStructuralDP.Formatters;

public class BoldFormatter(ITextFormatter? formatter) : FormatterDecorator(formatter)
{
    public override string? Format(string? text)
    {
        return Formatter?.Format(text);
    }

    public override string GetDescription()
    {
        return Formatter?.GetDescription() + " with bold";
    }
}