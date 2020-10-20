namespace ViSpelling
{
    public class SpellCheckTextBox : System.Windows.Forms.Control
    {
        System.Windows.Controls.TextBox textBox;
        System.Windows.Forms.Integration.ElementHost elementHost1;
        public SpellCheckTextBox()
        {
            elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            textBox = new System.Windows.Controls.TextBox();
            textBox.Language = System.Windows.Markup.XmlLanguage.GetLanguage("ru-RU");
            textBox.SpellCheck.IsEnabled = true;
            // textBox.SpellCheck.CustomDictionaries.Add(new Uri(@"ru-RU.dic", UriKind.Relative));
            // https://www.karamasoft.com/UltimateSpell/Dictionary.aspx
            elementHost1.Child = textBox;
            elementHost1.Parent = this;
            elementHost1.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        public override string Text
        {
            get
            {
                return textBox.Text;
            }

            set
            {
                textBox.Text = value;
            }
        }
               

    }
}
