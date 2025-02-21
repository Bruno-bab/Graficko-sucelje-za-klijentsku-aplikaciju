namespace Grafičko_sučelje_za_klijentsku_aplikaciju
{
    public class ToolStripRadioButtonMenuItem : ToolStripMenuItem
    {
        public ToolStripRadioButtonMenuItem() : base()
        {
            Initialize();
        }      

        private void Initialize()
        {
            CheckOnClick = true;
        }

        protected override void OnCheckedChanged(EventArgs e)
        {
            base.OnCheckedChanged(e);
            if (!Checked || this.Parent == null) return;
            foreach (ToolStripItem item in Parent.Items)
            {
                ToolStripRadioButtonMenuItem radioItem = item as ToolStripRadioButtonMenuItem;
                if (radioItem != null && radioItem != this && radioItem.Checked)
                {
                    radioItem.Checked = false;
                    return;
                }
            }
        }

        protected override void OnClick(EventArgs e)
        {
            if (Checked) return;
            base.OnClick(e);
        }
    }
}
