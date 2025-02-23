using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Grafičko_sučelje_za_klijentsku_aplikaciju
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            DirectoryList(treeView1, Directory.GetCurrentDirectory());
            this.Text = "File TreeView";
        }

        private void DirectoryList(TreeView treeView, string path)
        {
            treeView.Nodes.Clear();
            var rootDirInfo = new DirectoryInfo(path);
            treeView.Nodes.Add(CreateDirectoryNode(rootDirInfo));
        }

        private static TreeNode CreateDirectoryNode(DirectoryInfo dirInfo)
        {
            var dirNode = new TreeNode(dirInfo.FullName);
            foreach (var directory in dirInfo.GetDirectories())
            {
                dirNode.Nodes.Add(CreateDirectoryNode(directory));
            }
            foreach (var file in dirInfo.GetFiles())
            {
                dirNode.Nodes.Add(new TreeNode(file.Name));
            }
            return dirNode;
        }
    }
}
