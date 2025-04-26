namespace InternshipTaskStructuralDP.Formatters;

public sealed class BaseTextFormatter : ITextFormatter
{
    public string? Format(string? text)
    {
        return text;
    }

    public string GetDescription()
    {
        return "Plain text";
    }
}