﻿using System;
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

        private static TreeNode CreateDirectoryNode(DirectoryInfo directoryInfo)
        {
            var directoryNode = new TreeNode(directoryInfo.FullName);
            foreach (var directory in directoryInfo.GetDirectories())
            {
                directoryNode.Nodes.Add(CreateDirectoryNode(directory));
            }
            foreach (var file in directoryInfo.GetFiles())
            {
                directoryNode.Nodes.Add(new TreeNode(file.Name));
            }
            return directoryNode;
        }
    }
}
