using System.Drawing.Text;
using System.IO;

namespace Grafičko_sučelje_za_klijentsku_aplikaciju
{
    public partial class Form1 : Form
    {
        private RichTextBox richTextBox1;
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;

        private ToolStripMenuItem toolStripMenuItem1 = new ToolStripMenuItem();
        private ToolStripRadioButtonMenuItem toolStripRadioButtonMenuItem1 = new ToolStripRadioButtonMenuItem();
        private ToolStripRadioButtonMenuItem toolStripRadioButtonMenuItem2 = new ToolStripRadioButtonMenuItem();

        public Form1()
        {
            InitializeComponent();

            richTextBox1 = new RichTextBox();

            toolStripRadioButtonMenuItem1.Text = "Not Finished";
            toolStripRadioButtonMenuItem2.Text = "Finished";
            toolStripRadioButtonMenuItem1.Checked = true;
            finishToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
            toolStripRadioButtonMenuItem1, toolStripRadioButtonMenuItem2});
        }

        public string RichTextBoxText
        {
            get { return richTextBox1.Text; }
            set { richTextBox1.Text = value; }
        }

        public OpenFileDialog OpenFileDialogInstance
        {
            get { return openFileDialog; }
            set { openFileDialog = value; }
        }

        public void NewFile()
        {
            try
            {
                if (this.richTextBox1.Text != string.Empty)
                {
                    DialogResult choice = MessageBox.Show("This file will be lost" +
                        "if it is not saved, do you want to continue?", "Warning",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button2);
                    if (choice == DialogResult.Yes)
                    {
                        this.richTextBox1.Text = string.Empty;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show(("Can't create a new file"));
            }
        }

        public void OpenFile()
        {
            try
            {
                openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    this.richTextBox1.Text = File.ReadAllText(openFileDialog.FileName);
                }
            }
            catch (Exception)
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
            catch (Exception)
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

        private void finishToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
