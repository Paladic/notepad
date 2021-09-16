using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.Application;

namespace notepad
{
    public partial class Form1 : Form
    {
        public string Filename;
        public bool IsFileChanged;
        public bool CancelFile;
        public string Bufer;
        public string UndoBufer;
        public string Search;
        public fontsSetting fs;
        public int fontSizeR;
        public FontStyle fsR;
        public string FontNameR;
        public string currentDate;

        public Form1()
        {
            InitializeComponent();
            
            Init();
        }

        public void Init()
        {
            Filename = "";
            IsFileChanged = false;
            // pictureBox1.Visible = false;
            UpdateTextWithTitle();
            Search = "https://www.google.com/search?q=";
        }

        public void CreateNewDocument(object sender, EventArgs e) // Создание нового документа
        {
            SaveUnSavedFile();
            if (!IsFileChanged)
            {
                textBox1.Text = "";
                Filename = "";
                UpdateTextWithTitle();
                IsFileChanged = false;
            }
            else MessageBox.Show("Создание нового файла отменено", "Прерывание");
        }

        public void OpenFile(object sender, EventArgs e) // открытие нового документа
        {
            SaveUnSavedFile();
            openFileDialog1.FileName = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamReader sr = new StreamReader(openFileDialog1.FileName);
                    textBox1.Text = sr.ReadToEnd();
                    sr.Close();
                    Filename = openFileDialog1.FileName;
                }
                catch
                {
                    MessageBox.Show("Файл нельзя открыть");
                }
            }
            UpdateTextWithTitle();
        }

        public void SaveFile(string _filename) // Сохранение файла 
        {
            saveFileDialog1.Filter = "Тектовый файл (*.txt)|*.txt|Все файлы (*.*)|*.*";
            if (_filename == "")
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    _filename = saveFileDialog1.FileName;
                }
            }
            try
            {
                StreamWriter sw = new StreamWriter(_filename);
                sw.Write(textBox1.Text);
                sw.Close();
                Filename = _filename;
                IsFileChanged = false;
            }
            catch
            {
                MessageBox.Show("Не сохранили мы файл, габелла");
            }
            UpdateTextWithTitle();
        }

        public void Save(object sender, EventArgs e) // сохранение 
        {
            SaveFile(Filename);
        }
        public void SaveAs(object sender, EventArgs e) // сохранить как
        {
            SaveFile(Filename);
        }

        private void textBox1_TextChanged(object sender, EventArgs e) // звездочка при появлении несохраненных приколов
        {
            if (!IsFileChanged)
            {
                this.Text = this.Text.Replace('*', ' ');
                IsFileChanged = true;
               this.Text = "*" + this.Text;
            }
        }

        public void UpdateTextWithTitle() // обновлять текст при создании нового файла, если у него есть название
        {
            if (Filename != "") this.Text = Filename + " - 18 | Notepad";
            else this.Text = "Новый проект - 18 | Notepad";
        }

        public void Exit(object sender, EventArgs e) // выход
        {
            Application.Exit();
        }
        
        private void Form1_FormClosing(object sender, FormClosingEventArgs e) // закрытие формы
        {
            CancelFile = false;
            if(IsFileChanged) SaveUnSavedFile();
            e.Cancel = CancelFile;
        }
        private void SaveUnSavedFile() // сохранение несхораненого файла
        {
            if (IsFileChanged)
            {
                var exitMessage = MessageBox.Show("Вы хотите сохранить результат?", "Предупреждение",
                    MessageBoxButtons.YesNoCancel);
                switch (exitMessage)
                {
                    case DialogResult.Yes:
                        SaveFile(Filename);
                        IsFileChanged = false;
                        break;
                    case DialogResult.No:
                        IsFileChanged = false;
                        break;
                    case DialogResult.Cancel:
                        CancelFile = true;
                        break;
                }
            }
        }

        public void Print(object sender, EventArgs e)
        {
        }

        public void SettingPage(object sender, EventArgs e)
        {
            
        }

        public void CancelText(object sender, EventArgs e) // отменить результат действия
        {
            textBox1.Clear();
            textBox1.Paste(UndoBufer);
        }
        public void CancelNo(object sender, PaintEventArgs e) // отключении функции, если CancelText нельзя отменить
        {
            отменитьToolStripMenuItem.Enabled = textBox1.CanUndo;
        }

        public void CutText(object sender, EventArgs e) // вырезать текст
        {
            UndoBufer = textBox1.Text;
            textBox1.Cut();
        }

        public void CopyText(object sender, EventArgs e) // скопировать текст
        {
            UndoBufer = textBox1.Text;
            textBox1.Copy();
        }
        public void PasteText(object sender, EventArgs e) // вставить текст
        {
            UndoBufer = textBox1.Text;
            textBox1.Paste();
        }
        
        public void DeleteText(object sender, EventArgs e) // удалить текст
        {
            UndoBufer = textBox1.Text;
            Bufer = "";
            for (int i = 0; i < textBox1.SelectionStart; i++)
            {
                Bufer+=textBox1.Text[i];
            }

            for (int i = textBox1.SelectionStart + textBox1.SelectionLength; i < textBox1.TextLength; i++)
            {
                Bufer+=textBox1.Text[i];
            }
            textBox1.Clear();
            textBox1.Paste(Bufer);
        }

        public void SearchInt(object sender, EventArgs e) // найти текст в интернете
        {
            Search = "";
            Search = "https://www.google.com/search?q=" + textBox1.SelectedText;
            Process.Start(Search);

        }
        
        private void NoHightLightSymbols(object sender, PaintEventArgs e) // если текст не выделен то функции отключены
        {
            вырезатьToolStripMenuItem.Enabled = (textBox1.SelectionLength > 0);
            копироватьToolStripMenuItem.Enabled = (textBox1.SelectionLength > 0);
            удалитьToolStripMenuItem.Enabled = (textBox1.SelectionLength > 0);
            поискВБраузереToolStripMenuItem.Enabled = (textBox1.SelectionLength > 0);
        }


        public void SelectedAll(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }

        public void CurrentDate(object sender, EventArgs e)
        { 
            currentDate = DateTime.Now.ToString();
            textBox1.Paste(currentDate);
        }
        private void FontCreateClick(object sender, EventArgs e)
        {
            fs = new fontsSetting();
            fs.Show();
        }

        private void OnFocus(object sender, EventArgs e)
        {
            if (fs != null)
            {
                fontSizeR = fs.fontSizeR;
                fsR = fs.fsR;
                FontNameR = fs.fontNameR;
                textBox1.Font = new Font(FontNameR, fontSizeR, fsR);
                fs.Close();
            }
        }

        public void About(object sender, EventArgs e)
        {
            Process.Start("https://coub.com/view/2tkl22");
        }

        public void Dance(object sender, EventArgs e)
        {
            // pictureBox1.Visible = !pictureBox1.Visible;
            (new System.Media.SoundPlayer(@"C:\Users\nikit\Downloads\Lucoa dancing (online-audio-converter.com).wav")).PlayLooping();

        }
    }
}