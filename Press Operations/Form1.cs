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
                Pressure.Text = "35,000";
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                Pressure.Text = "40,000";
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                Pressure.Text = "58,000";
            }
            else
            {
                Pressure.Text = "64,000";
            }
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    if (int.TryParse(comboBox1.Text, out int value))
                    {
                        Pressure.Text = value + 750.ToString() + "PSI";
                    }
                    else
                    {

                    }
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    if (int.TryParse(comboBox1.Text, out int value1))
                    {
                        Pressure.Text = (value1 + 250).ToString() + "PSI";
                    }
                }
                if (comboBox1.SelectedIndex == 2)
                {
                    if (int.TryParse(comboBox1.Text, out int value2))
                    {
                        Pressure.Text = (value2 - 500).ToString() + "PSI";
                    }
                }
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    if (i != e.Index)
                    {
                        checkedListBox1.SetItemChecked(i, false);
                    }
                }
            }
        }
    }
}
