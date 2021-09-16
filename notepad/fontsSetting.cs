using System;
using System.Drawing;
using System.Windows.Forms;

namespace notepad
{
    public partial class fontsSetting : Form
    {
        public int fontSizeR = 0;
        public FontStyle fsR = System.Drawing.FontStyle.Regular;
        public string fontNameR = "Microsoft Sans Serif";
        public fontsSetting()
        {
            InitializeComponent();
            FontSize.SelectedItem = FontSize.Items[0];
            FontStyle.SelectedItem = FontStyle.Items[0];
            FontName.SelectedItem = FontName.Items[0];
        }

        private void OnFontedChanged(object sender, EventArgs e)
        {
            ExampleFont.Font = new Font(ExampleFont.Font.FontFamily, int.Parse(FontSize.SelectedItem.ToString()),ExampleFont.Font.Style);
            fontSizeR = int.Parse(FontSize.SelectedItem.ToString());
        }
        private void OnStyleChanged(object sender, EventArgs e)
        {
            switch (FontStyle.SelectedItem.ToString())
            {
                case "обычный":
                    ExampleFont.Font = new Font(ExampleFont.Font.FontFamily, int.Parse(FontSize.SelectedItem.ToString()), System.Drawing.FontStyle.Regular);
                    break;
                case "курсив":
                    ExampleFont.Font = new Font(ExampleFont.Font.FontFamily, int.Parse(FontSize.SelectedItem.ToString()), System.Drawing.FontStyle.Italic);
                    break;
                case "полужирный":
                    ExampleFont.Font = new Font(ExampleFont.Font.FontFamily, int.Parse(FontSize.SelectedItem.ToString()), System.Drawing.FontStyle.Bold);
                    break;
                case "Зачеркнутый":
                    ExampleFont.Font = new Font(ExampleFont.Font.FontFamily, int.Parse(FontSize.SelectedItem.ToString()), System.Drawing.FontStyle.Strikeout);
                    break;
                case "Подчеркнутый":
                    ExampleFont.Font = new Font(ExampleFont.Font.FontFamily, int.Parse(FontSize.SelectedItem.ToString()), System.Drawing.FontStyle.Underline);
                    break;
                case "полужирный наклонный":
                    ExampleFont.Font = new Font(ExampleFont.Font.FontFamily, int.Parse(FontSize.SelectedItem.ToString()), System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
                    break;
            }

            fsR = ExampleFont.Font.Style;

        }

        private void OnFontChanged(object sender, EventArgs e)
        {
            switch (FontName.SelectedItem.ToString())
            {
                case "Microsoft Sans Serif":
                    ExampleFont.Font = new Font("Microsoft Sans Serif", int.Parse(FontSize.SelectedItem.ToString()),
                        ExampleFont.Font.Style);
                    break;
                case "Arial":
                    ExampleFont.Font = new Font("Arial", int.Parse(FontSize.SelectedItem.ToString()),
                        ExampleFont.Font.Style);
                    break;
                case "Comic Sans MS":
                ExampleFont.Font = new Font("Comic Sans MS", int.Parse(FontSize.SelectedItem.ToString()),
                    ExampleFont.Font.Style);
                break;
                case "Impact":
                    ExampleFont.Font = new Font("Impact", int.Parse(FontSize.SelectedItem.ToString()),
                        ExampleFont.Font.Style);
                    break;
                case "Sylfaen":
                    ExampleFont.Font = new Font("Sylfaen", int.Parse(FontSize.SelectedItem.ToString()),
                        ExampleFont.Font.Style);
                    break;
                case "Courier New":
                    ExampleFont.Font = new Font("Courier New", int.Parse(FontSize.SelectedItem.ToString()),
                        ExampleFont.Font.Style);
                    break;

            }

            fontNameR = ExampleFont.Font.FontFamily.Name;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}