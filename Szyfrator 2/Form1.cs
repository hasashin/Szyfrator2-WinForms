using System;
using System.Collections;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Szyfrator_2
{
    public partial class Form1 : Form
    {
        private readonly ArrayList keyCharsTable = new ArrayList
        {
            'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I',
            'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R',
            'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'
        };

        private readonly ArrayList messageCharsTable = new ArrayList
        {
            'a','b','c','d','e','f','g','h','i','j','k',
            'l','m','n','o','p','q','r','s','t','u','v',
            'w','x','y','z','A','B','C','D','E','F','G',
            'H','I','J','K','L','M','N','O','P','Q','R',
            'S','T','U','V','W','X','Y','Z','.',' ',',','-',':'
        };

        private readonly Przekatnokolumnowy szyfr;

        private void ShowErrorAlert(string text)
        {
            MessageBox.Show(text,"",MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool ShowTrimWarning()
        {
            return DialogResult.Yes == MessageBox.Show("W tekście znaleziono nieprawidłowe znaki. Wiadomość zostanie zaszyfrowana bez nich.\nCzy chcesz kontynuować?","", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
        }

        private bool TrimWrongChars(RichTextBox textField, bool isCipher)
        {
            try
            {
                foreach (char letter in textField.Text)
                {
                    if (isCipher)
                    {
                        if (messageCharsTable.Contains(letter) || letter == '#')
                            continue;
                    }
                    else
                    {
                        if (messageCharsTable.Contains(letter))
                            continue;
                    }
                    textField.Text = textField.Text.Replace(letter.ToString(), "");
                }
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        private bool ValidateText(RichTextBox textField, bool isCipher)
        {
            bool warningResponse = true;
            foreach (char letter in textField.Text)
            {
                if (messageCharsTable.Contains(letter)) continue;
                if (isCipher && letter == '#') continue;
                warningResponse = ShowTrimWarning();
                break;
            }
            if (warningResponse)
            {
                return TrimWrongChars(textField, isCipher);
            }
            return false;
        }

        private SaveFileDialog NewSaveFileDialog(string title, string filter)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Filter = filter;
            fileDialog.Title = title;
            fileDialog.FileName = filter.Contains("cip") ? "szyfr" : "";
            return fileDialog;
        }

        private OpenFileDialog NewOpenFileDialog(string title, string filter)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Title = title;
            fileDialog.Filter = filter;
            return fileDialog;
        }

        public Form1()
        {
            InitializeComponent();
            szyfr = new Przekatnokolumnowy();
        }

        private void UpdateButtonEnableState(TextBox keyTextField)
        {
            if (keyTextField.Name == "CipherKeyTextBox")
            {
                CipherButton.Enabled = keyTextField.Text != "";
            }
            else if (keyTextField.Name == "DecipherKeyTextBox")
            {
                DecipherButton.Enabled = keyTextField.Text != "";
            }
        }

        private void CipherButton_Click(object sender, EventArgs e)
        {
            szyfr.Key = CipherKeyTextBox.Text;
            bool response = false;
            try
            {
                response = ValidateText(RawInputTextBox, false);
            }
            catch (Exception ex)
            {
                ShowErrorAlert(ex.Message);
            }
            if (response) CipheredOutputTextBox.Text = szyfr.Encrypt(RawInputTextBox.Text);
        }

        private void DecipherButton_Click(object sender, EventArgs e)
        {
            szyfr.Key = DecipherKeyTextBox.Text;
            bool response = false;
            try
            {
                response = ValidateText(CipheredInputTextBox, true);
            }
            catch (Exception ex)
            {
                ShowErrorAlert(ex.Message);
            }
            if (response) RawOutputTextBox.Text = szyfr.Decrypt(CipheredInputTextBox.Text);
        }

        private void szyfrogramToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (CipheredOutputTextBox.Text == "")
            {
                ShowErrorAlert("Pole wynikowe jest puste.\nWygeneruj nową wiadomość aby móc ją zapisać.");
                return;
            }

            var fileDialog = NewSaveFileDialog("Zapisz plik", "Pliki szyfrogramu|*.cip");
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter cipherFile = new StreamWriter(fileDialog.FileName);
                Task dataTask = cipherFile.WriteAsync(CipheredOutputTextBox.Text);
                dataTask.Wait();
                cipherFile.Close();
            }
            fileDialog.Dispose();
        }

        private void tekstToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (RawOutputTextBox.Text == "")
            {
                ShowErrorAlert("Pole wynikowe jest puste.\nOdkoduj kolejną wiadomość aby móc ją zapisać.");
                return;
            }

            var fileDialog = NewSaveFileDialog("Zapisz plik", "Pliki tekstowe|*.txt");
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter textFile = new StreamWriter(fileDialog.FileName);
                Task dataTask = textFile.WriteAsync(RawOutputTextBox.Text);
                dataTask.Wait();
                textFile.Close();
            }
            fileDialog.Dispose();
        }

        private void szyfrogramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = NewOpenFileDialog("Wybierz plik do odszyfrowania", "Pliki szyfrogramu|*.cip|Wszystkie pliki|*.*");
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader dataFile = File.OpenText(fileDialog.FileName);
                Task<string> dataTask = dataFile.ReadToEndAsync();
                dataTask.Wait();
                CipheredInputTextBox.Text = dataTask.Result;
                MainTabControl.SelectedIndex = 1;
                dataFile.Close();
            }
        }

        private void tekstToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = NewOpenFileDialog("Wybierz plik do zaszyfrowania", "Pliki tekstowe|*.txt|Wszystkie pliki|*.*");
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader dataFile = File.OpenText(fileDialog.FileName);
                Task<string> dataTask = dataFile.ReadToEndAsync();
                dataTask.Wait();
                RawInputTextBox.Text = dataTask.Result;
                MainTabControl.SelectedIndex = 0;
                dataFile.Close();
            }
        }

        private void nowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("Wszystkie niezapisane dane zostaną usunięte!\nCzy chcesz kontynuować?","", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resp == DialogResult.Yes)
                CleanAll();
        }
        private void CleanAll()
        {
            RawInputTextBox.Text = "";
            CipheredInputTextBox.Text = "";
            CipherKeyTextBox.Text = "";
            DecipherKeyTextBox.Text = "";
            CipheredOutputTextBox.Text = "";
            RawOutputTextBox.Text = "";
            MainTabControl.SelectedIndex = 0;
        }

        private void zakończToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CipherKeyTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox keyTextField = sender as TextBox;
            UpdateButtonEnableState(keyTextField);
            keyTextField.Text = keyTextField.Text.ToUpper();
            foreach (char letter in keyTextField.Text)
            {
                if (!keyCharsTable.Contains(letter))
                {
                    keyTextField.Text = keyTextField.Text.Replace(letter.ToString(), "");
                }
            }
            keyTextField.SelectionStart = keyTextField.Text.Length;
            keyTextField.SelectionLength = 0;
        }
    }
}
