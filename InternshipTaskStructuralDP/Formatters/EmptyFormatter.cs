namespace InternshipTaskStructuralDP.Formatters;

public class EmptyFormatter(ITextFormatter? formatter) : FormatterDecorator(formatter)
{
    public override string? Format(string? text)
    {
        return Formatter?.Format(text);
    }

    public override string GetDescription()
    {
        return "";
    }
}