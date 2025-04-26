using InternshipTaskStructuralDP.Formatters;

namespace InternshipTaskStructuralDP;

public class FormatterProxy(ITextFormatter? formatter) : ITextFormatter
{
    private readonly Dictionary<string, string?> _cache = new();

    public string? Format(string? text)
    {
        var cacheKey = text + "_" + formatter?.GetDescription();

        if (_cache.TryGetValue(cacheKey, out var value)) return value;
        value = formatter?.Format(text);
        _cache[cacheKey] = value;

        return value;
    }

    public string? GetDescription()
    {
        return formatter?.GetDescription();
    }
}