using System.Drawing;
using Xceed.Document.NET;

namespace BetterRead.Shared.Helpers
{
    internal static class ParagraphHelpers
    {
        public static void AddLinkToParagraph(this Paragraph source, Hyperlink hyperLink, double fontSize) =>
            source.AppendHyperlink(hyperLink)
                  .Font("Italic")
                  .FontSize(fontSize)
                  .Color(Color.Blue)
                  .UnderlineStyle(UnderlineStyle.singleLine);
    }
}