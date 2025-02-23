using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Forms;
using Grafičko_sučelje_za_klijentsku_aplikaciju;
using System.Reflection;

namespace RadioButton.Tests
{
    [TestClass]
    public class ToolStripRadioButtonMenuItemUnitTests
    {
        [TestMethod]
        public void Set_CheckOnClick_To_True()
        {
            var item = new ToolStripRadioButtonMenuItem();

            Assert.IsTrue(item.CheckOnClick);
        }

        [TestMethod]
        public void Only_One_At_Time()
        {
            var item1 = new ToolStripRadioButtonMenuItem();
            var item2 = new ToolStripRadioButtonMenuItem();
            var item3 = new ToolStripRadioButtonMenuItem();
            var parent = new ToolStripDropDownMenu();
            parent.Items.Add(item1);
            parent.Items.Add(item2);
            parent.Items.Add(item3);
            item1.Checked = true;
            item2.Checked = true;

            Assert.IsFalse(item1.Checked);
            Assert.IsTrue(item2.Checked);
            Assert.IsFalse(item3.Checked);
        }

        [TestMethod]
        public void Can_Not_Uncheck()
        {
            var item = new ToolStripRadioButtonMenuItem();
            var parent = new ToolStripDropDownMenu();
            parent.Items.Add(item);
            item.Checked = true;
            item.PerformClick();

            Assert.IsTrue(item.Checked);
        }
    }
}
namespace Files.Tests
{
    [TestClass]
    public class NewFileTests
    {
        private Form1 form;

        [TestInitialize]
        public void Setup()
        {
            form = new Form1();
        }

        [TestMethod]
        public void Clear_RichTextBox()
        {
            form.RichTextBoxText = "Test text";
            form.NewFile();

            Assert.AreEqual(string.Empty, form.RichTextBoxText);
        }
    }
}


