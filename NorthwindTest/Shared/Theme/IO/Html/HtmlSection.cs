namespace NorthwindTest.Shared.Theme.IO.Html
{
    public class HtmlSection : ENV.IO.Html.HtmlSection 
    {
        /// <summary>HtmlSection</summary>
        public HtmlSection()
        {
            InitializeComponent();
        }
        void InitializeComponent()
        {
            ColorScheme = new NorthwindTest.Shared.Theme.Colors.Window_sDefault();
            DefaultFontScheme = new NorthwindTest.Shared.Theme.Fonts.HTML_Default();
            H1FontScheme = new NorthwindTest.Shared.Theme.Fonts.Header1();
            H1FontScheme = new NorthwindTest.Shared.Theme.Fonts.Header2();
            H1FontScheme = new NorthwindTest.Shared.Theme.Fonts.Header3();
            H1FontScheme = new NorthwindTest.Shared.Theme.Fonts.Header4();
            H1FontScheme = new NorthwindTest.Shared.Theme.Fonts.Header5();
            H1FontScheme = new NorthwindTest.Shared.Theme.Fonts.Header6();
            BoldFontScheme = new NorthwindTest.Shared.Theme.Fonts.HTML_DefaultBold();
            H1BoldFontScheme = new NorthwindTest.Shared.Theme.Fonts.Header1Bold();
            H2BoldFontScheme = new NorthwindTest.Shared.Theme.Fonts.Header2Bold();
            H3BoldFontScheme = new NorthwindTest.Shared.Theme.Fonts.Header3Bold();
            H4BoldFontScheme = new NorthwindTest.Shared.Theme.Fonts.Header4Bold();
            H5BoldFontScheme = new NorthwindTest.Shared.Theme.Fonts.Header5Bold();
            H6BoldFontScheme = new NorthwindTest.Shared.Theme.Fonts.Header6Bold();
            ItalicFontScheme = new NorthwindTest.Shared.Theme.Fonts.HTML_DefaultItalic();
            H1ItalicFontScheme = new NorthwindTest.Shared.Theme.Fonts.Header1Italic();
            H2ItalicFontScheme = new NorthwindTest.Shared.Theme.Fonts.Header2Italic();
            H3ItalicFontScheme = new NorthwindTest.Shared.Theme.Fonts.Header3Italic();
            H4ItalicFontScheme = new NorthwindTest.Shared.Theme.Fonts.Header4Italic();
            H5ItalicFontScheme = new NorthwindTest.Shared.Theme.Fonts.Header5Italic();
            H6ItalicFontScheme = new NorthwindTest.Shared.Theme.Fonts.Header6Italic();
            BoldItalicFontScheme = new NorthwindTest.Shared.Theme.Fonts.HTML_DefaultBoldItalic();
            H1BoldItalicFontScheme = new NorthwindTest.Shared.Theme.Fonts.Header1BoldItalic();
            H2BoldItalicFontScheme = new NorthwindTest.Shared.Theme.Fonts.Header2BoldItalic();
            H3BoldItalicFontScheme = new NorthwindTest.Shared.Theme.Fonts.Header3BoldItalic();
            H4BoldItalicFontScheme = new NorthwindTest.Shared.Theme.Fonts.Header4BoldItalic();
            H5BoldItalicFontScheme = new NorthwindTest.Shared.Theme.Fonts.Header5BoldItalic();
            H6BoldItalicFontScheme = new NorthwindTest.Shared.Theme.Fonts.Header6BoldItalic();
        }
        public HtmlSection(ENV.BusinessProcessBase controller) : base(controller)
        {
            InitializeComponent();
        }
        public HtmlSection(ENV.AbstractUIController controller) : base(controller)
        {
            InitializeComponent();
        }
        public HtmlSection(ENV.ApplicationControllerBase controller) : base(controller)
        {
            InitializeComponent();
        }
    }
}
