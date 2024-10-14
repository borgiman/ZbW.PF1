namespace MB01.A2_1
{
    public partial class A2_1_3 : Form
    {
        public A2_1_3()
        {
            InitializeComponent();
        }

        private void CmdAdd_Click(object sender, EventArgs e)
        {
            int zahl1 = Convert.ToInt32(TxtValue1.Text);
            int zahl2 = Convert.ToInt32(TxtValue2.Text);

            int result = zahl1 + zahl2;
            TxtResult.Text = Convert.ToString(result);
        }

        private void CmdSub_Click(object sender, EventArgs e)
        {
            int zahl1 = Convert.ToInt32(TxtValue1.Text);
            int zahl2 = Convert.ToInt32(TxtValue2.Text);

            int result = zahl1 - zahl2;
            TxtResult.Text = Convert.ToString(result);
        }

        private void CmdMult_Click(object sender, EventArgs e)
        {
            int zahl1 = Convert.ToInt32(TxtValue1.Text);
            int zahl2 = Convert.ToInt32(TxtValue2.Text);

            int result = zahl1 * zahl2;
            TxtResult.Text = Convert.ToString(result);
        }

        private void CmdDiv_Click(object sender, EventArgs e)
        {
            int zahl1 = Convert.ToInt32(TxtValue1.Text);
            int zahl2 = Convert.ToInt32(TxtValue2.Text);

            double result = zahl1 / (double)zahl2;
            TxtResult.Text = Convert.ToString(result);
        }
    }
}
