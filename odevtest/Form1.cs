/****************************************************************************
**					   SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**                     2023-2024 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........:1
**				ÖĞRENCİ ADI............:Osman Can YILDIZ
**				ÖĞRENCİ NUMARASI.......:G231210060
**              DERSİN ALINDIĞI GRUP...:2C
****************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odevtest
{
    public partial class texteditor : Form
    {
        public texteditor()
        {
            InitializeComponent();
        }
        //open txt files
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (richTextBox1.Text != string.Empty)    // check if the editor is empty or not
            {
                // save changes message
                DialogResult result = MessageBox.Show("Would you like to save your changes? Editor is not empty.", "Save Changes?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // save the contents if user selected yes
                    string file;
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        string filename = saveFileDialog1.FileName;
                        // save the contents of the rich text box
                        richTextBox1.SaveFile(filename, RichTextBoxStreamType.PlainText);
                        file = Path.GetFileName(filename); // get name of file
                        MessageBox.Show("File " + file + " was saved successfully.", "Save Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    // finally ask user to choose which file to open
                    openFileDialog1.Filter = "Text Files |*.txt";
                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        richTextBox1.Text = File.ReadAllText(openFileDialog1.FileName);
                    }
                }
                else if (result == DialogResult.No)
                {
                    openFileDialog1.Filter = "Text Files |*.txt";
                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        richTextBox1.Text = File.ReadAllText(openFileDialog1.FileName);
                    }
                }
            }
            else // rich text box has no contents
            {
                openFileDialog1.Filter = "Text Files |*.txt";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.Text = File.ReadAllText(openFileDialog1.FileName);
                }
            }
        }

        // save file as txt
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string file;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)

            {
                string filename = saveFileDialog1.FileName;
                // save the contents of the rich text box
                richTextBox1.SaveFile(filename, RichTextBoxStreamType.PlainText);
                file = Path.GetFileName(filename);    // get name of file
                MessageBox.Show("File " + file + " was saved successfully.", "Save Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //exit the application
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != string.Empty)    // check if the editor is empty or not
            {
                // save changes message
                DialogResult result = MessageBox.Show("Would you like to save your changes? Editor is not empty.", "Save Changes?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // save the contents if user selected yes
                    string file;
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        string filename = saveFileDialog1.FileName;
                        // save the contents of the rich text box
                        richTextBox1.SaveFile(filename, RichTextBoxStreamType.PlainText);
                        file = Path.GetFileName(filename); // get name of file
                        MessageBox.Show("File " + file + " was saved successfully.", "Save Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    // finally exit the application
                    Application.Exit();
                }
                else if (result == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else // rich text box has no contents
            {
                Application.Exit();
            }
        }

        //cut selected text
        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        //copy selected text
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        //paste selected text
        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        //change the font or size of text
        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            richTextBox1.SelectionFont = fontDialog1.Font;
        }

        //change color of text
        private void colorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.SelectionColor = colorDialog1.Color;
        }

        //change the background of selected text
        private void backgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.SelectionBackColor = colorDialog1.Color;
        }

        //cut selected text
        private void cutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        //copy selected text
        private void copyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        //paste selected text
        private void pasteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        //change the color of selected text
        private void changeColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.SelectionColor = colorDialog1.Color;
        }

        //change the background of selected text
        private void changeBackgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.SelectionBackColor = colorDialog1.Color;
        }

        //change the font or size of text
        private void changeFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            richTextBox1.SelectionFont = fontDialog1.Font;
        }

        //save the file
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != string.Empty)    // check if the editor is empty or not
            {
                // save changes message
                DialogResult result = MessageBox.Show("Would you like to save your changes? Editor is not empty.", "Save Changes?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // save the contents if user selected yes
                    string file;
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        string filename = saveFileDialog1.FileName;
                        // save the contents of the rich text box
                        richTextBox1.SaveFile(filename, RichTextBoxStreamType.PlainText);
                        file = Path.GetFileName(filename); // get name of file
                        MessageBox.Show("File " + file + " was saved successfully.", "Save Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    // finally - clear the contents of the rich text box 
                    richTextBox1.ResetText();
                    richTextBox1.Focus();
                }
                else if (result == DialogResult.No)
                {
                    // clear the contents of the rich text box 
                    richTextBox1.ResetText();
                    richTextBox1.Focus();
                }
            }
            else // rich text box has no contents
            {
                // clear the contents of the rich text box 
                richTextBox1.ResetText();
                richTextBox1.Focus();
            }

        }

        //template of c
        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                richTextBox1.Text = "#include <stdio.h>\r\n\r\nint main() {\r\n    " +
                    "printf(\"Hello, World!\\n\");\r\n    return 0;\r\n}\r\n";
            }
        }

        //template of c++
        private void cToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "#include <iostream>\r\n\r\n" +
                "using namespace std;\r\n\r\nint main() {\r\n    " +
                "cout << \"Hello, World!\" << endl;\r\n    return 0;\r\n}\r\n";
        }

        //template of c#
        private void cToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "using System;\r\n\r\nclass Program\r\n{\r\n    static void Main(string[] args)\r\n    {\r\n        " +
                "Console.WriteLine(\"Hello, World!\");\r\n    }\r\n}\r\n";
        }

        //change the background
        private void backColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.BackColor = colorDialog1.Color;
        }

        //change the background of selected text
        private void changeBacgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.BackColor = colorDialog1.Color;
        }

        //about
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Texedor Text Editor 1.0");
        }
    }
}
