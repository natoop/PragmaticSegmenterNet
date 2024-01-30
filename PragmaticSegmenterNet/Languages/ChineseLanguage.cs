namespace PragmaticSegmenterNet.Languages
{
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    internal class ChineseLanguage : LanguageBase
    {
        public override Regex SentenceBoundaryRegex => new Regex(@"\uff08(?:[^\uff09])*\uff09(?=\s?[A-Z])|\u300c(?:[^\u300d])*\u300d(?=\s[A-Z])|\((?:[^\)]){2,}\)(?=\s[A-Z])|'(?:[^'])*[^,]'(?=\s[A-Z])|""(?:[^""])*[^,]""(?=\s[A-Z])|“(?:[^”])*[^,]”(?=\s[A-Z])|\S.*?[。．.！!?？；ȸȹ☉☈☇☄]");
        public override IReadOnlyList<string> SentenceStarters { get; } = Empty;
    }
}
