using System.Diagnostics.Eventing.Reader;

namespace Press_Operations
{
    public partial class BlowPressOperations : Form
    {
        public BlowPressOperations()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                Pressure.Text = @"35,000 PSI";
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                Pressure.Text = @"40,000 PSI";
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                Pressure.Text = @"58,000 PSI";
            }
            else
            {
                Pressure.Text = @"64,000 PSI";
            }
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if(e.NewValue == CheckState.Checked)
            {
                for(int i = 0;i < checkedListBox1.Items.Count;i++)
                {
                    if(i != e.Index)
                    {
                        checkedListBox1.SetItemChecked(i, false);
                    }
                }
            }
        }
    }
}
