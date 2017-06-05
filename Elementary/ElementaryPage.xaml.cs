using Xamarin.Forms;
using System;
using System.Collections.Generic;

namespace Elementary
{
    public partial class ElementaryPage : Pages.BasePage
    {
        int CurrentQuote { get; set; }
        List<string> _quotes;
        List<string> Quotes
        {
            get
            {
                if (_quotes == null)
                {
                    _quotes = new List<string>() { "Hey you rock!", "Let it be", "Don't worry be happy", "Living in a fish bowl" };
                }
                return _quotes;
            }
        }
        public ElementaryPage()
        {
            InitializeComponent();
            LabelSlider.Value = 0.14;
            CurrentQuote = 0;
            QuoteLabel.Text = Quotes[CurrentQuote];
            QuoteLabel.FontSize = LabelSlider.Value * 100;
		}

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            if (CurrentQuote == Quotes.Count - 1) { CurrentQuote = 0; }
            else CurrentQuote++;
            QuoteLabel.Text = Quotes[CurrentQuote];
        }

        void Handle_ValueChanged(object sender, Xamarin.Forms.ValueChangedEventArgs e)
        {
			QuoteLabel.FontSize = LabelSlider.Value * 100;
		}
    }
}
