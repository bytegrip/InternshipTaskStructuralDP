namespace InternshipTaskStructuralDP.Formatters;

public abstract class FormatterDecorator(ITextFormatter? formatter) : ITextFormatter
{
    protected readonly ITextFormatter? Formatter = formatter;

    public virtual string? Format(string? text)
    {
        return Formatter?.Format(text);
    }

    public virtual string? GetDescription()
    {
        return Formatter?.GetDescription();
    }
}