namespace MB01.A2_1
{
    public partial class A2_1_2 : Form
    {
        public A2_1_2()
        {
            InitializeComponent();
        }

        private void CmdEnter_Click(object sender, EventArgs e)
        {
            LblOutput.Text = TxtFirstname.Text + " " + TxtLastname.Text + " " + NumAge.Value;
        }

        private void CmdClear_Click(object sender, EventArgs e)
        {
            LblOutput.Text = "...";
            TxtFirstname.Text = "";
            TxtLastname.Text = "";
            NumAge.Value = 0;
        }
    }
}
