namespace InternshipTaskStructuralDP.Formatters;

public class ItalicFormatter(ITextFormatter? formatter) : FormatterDecorator(formatter)
{
    public override string? Format(string? text)
    {
        return Formatter?.Format(text);
    }

    public override string GetDescription()
    {
        return Formatter?.GetDescription() + " with italic";
    }
}