using System.IO;

namespace Grafičko_sučelje_za_klijentsku_aplikaciju
{
    public partial class Form1 : Form
    {
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;

        public Form1()
        {
            InitializeComponent();
        }

        private void NewFile()
        {
            try
            {
                this.richTextBox1.Text = string.Empty;
                this.Text = "Untitled";
            }
            catch (Exception ex)
            {
                MessageBox.Show(("Can't create a new file"));
            }
        }

        private void OpenFile()
        {
            try
            {
                openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    this.richTextBox1.Text = File.ReadAllText(openFileDialog.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(("Can't open the file"));
            }
            finally
            {
                openFileDialog = null;
            }
        }

        private void SaveFile()
        {
            try
            {
                if (!string.IsNullOrEmpty(this.richTextBox1.Text))
                {
                    saveFileDialog = new SaveFileDialog();
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllText(saveFileDialog.FileName, this.richTextBox1.Text);
                    }
                }
                else
                {
                    MessageBox.Show(("File is empty"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(("Can't save the file"));
            }
        }

        private void fileToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewFile();

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void fileViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.ShowDialog();
        }

        private void finishedToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

      
    }
}
