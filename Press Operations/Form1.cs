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
            else if(comboBox1.SelectedIndex == 1)
                {
                    Pressure.Text = @"40,000 PSI";
                }
            else if( comboBox1.SelectedIndex == 2)
                {
                    Pressure.Text = @"58,000 PSI";
                }
                else
                {
                    Pressure.Text = @"64,000 PSI";
                }
        }
    }
}
