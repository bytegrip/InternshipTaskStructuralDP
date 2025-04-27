using InternshipTaskStructuralDP;

var formatter = new TextFormattingFacade();
            
const string? sampleText = "Hello, World!";
            
var boldFormatter = TextFormattingFacade.CreateBoldFormatter();
TextFormattingFacade.ApplyFormat(sampleText, boldFormatter);
            
var italicFormatter = TextFormattingFacade.CreateItalicFormatter();
TextFormattingFacade.ApplyFormat(sampleText, italicFormatter);
            
var underlineFormatter = TextFormattingFacade.CreateUnderlineFormatter();
TextFormattingFacade.ApplyFormat(sampleText, underlineFormatter);
            
var colorFormatter = TextFormattingFacade.CreateColorFormatter("white", "black");
TextFormattingFacade.ApplyFormat(sampleText, colorFormatter);
            
var boldItalic = TextFormattingFacade.CreateBoldFormatter(TextFormattingFacade.CreateItalicFormatter());
TextFormattingFacade.ApplyFormat(sampleText, boldItalic);

var noFormat = TextFormattingFacade.CreateEmptyFormatter();
TextFormattingFacade.ApplyFormat(sampleText, noFormat);
            
var complexFormatter = TextFormattingFacade.CreateBoldFormatter(
    TextFormattingFacade.CreateItalicFormatter(
        TextFormattingFacade.CreateColorFormatter("white", "black")
    )
);

formatter.SaveFormatter("whiteBoldItalic", complexFormatter);
            
TextFormattingFacade.ApplyFormat(sampleText, complexFormatter);
TextFormattingFacade.ApplyFormat("Another text", formatter.GetSavedFormatter("whiteBoldItalic"));