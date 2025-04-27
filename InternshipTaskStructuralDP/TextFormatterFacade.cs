using InternshipTaskStructuralDP.Formatters;

namespace InternshipTaskStructuralDP;

public class TextFormattingFacade
{
    private readonly Dictionary<string, ITextFormatter?> _savedFormatters = new();

    public static void ApplyFormat(string? text, ITextFormatter? formatter)
    {
        var proxy = new FormatterProxy(formatter);
        Console.WriteLine($"Formatted: \"{text}\" - {proxy.GetDescription()}");
        proxy.Format(text);
    }

    public static ITextFormatter CreateBoldFormatter(ITextFormatter? baseFormatter = null)
    {
        baseFormatter ??= new BaseTextFormatter();
        return new BoldFormatter(baseFormatter);
    }

    public static ITextFormatter CreateItalicFormatter(ITextFormatter? baseFormatter = null)
    {
        baseFormatter ??= new BaseTextFormatter();
        return new ItalicFormatter(baseFormatter);
    }

    public static ITextFormatter CreateUnderlineFormatter(ITextFormatter? baseFormatter = null)
    {
        baseFormatter ??= new BaseTextFormatter();
        return new UnderlineFormatter(baseFormatter);
    }
    
    public static ITextFormatter CreateEmptyFormatter(ITextFormatter? baseFormatter = null)
    {
        baseFormatter ??= new BaseTextFormatter();
        return new EmptyFormatter(baseFormatter);
    }

    public static ITextFormatter CreateColorFormatter(string foreground, string background = "default", ITextFormatter? baseFormatter = null)
    {
        baseFormatter ??= new BaseTextFormatter();
        return new ColorFormatter(baseFormatter, foreground, background);
    }

    public void SaveFormatter(string name, ITextFormatter? formatter)
    {
        _savedFormatters[name] = formatter;
    }

    public ITextFormatter? GetSavedFormatter(string name)
    {
        return _savedFormatters.TryGetValue(name, out var value) ? value : new BaseTextFormatter();
    }
}