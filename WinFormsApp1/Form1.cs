namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public string D, N1;
        public bool N2;
        public Form1()
        {
            InitializeComponent();
        }

        private void button22_Click(object sender, EventArgs e) // 1234567890
        {
            if (N2 == true)
            {
                N2 = false;
                textBox1.Text = "0";
            }
            Button B = (Button)sender;
            if (textBox1.Text == "0") textBox1.Text = B.Text;
            else textBox1.Text = textBox1.Text + B.Text;
        }

        private void button3_Click(object sender, EventArgs e) // C CE
        {
            textBox1.Text = "0";
        }

        private void button20_Click(object sender, EventArgs e) // +-*/
        {
            Button B = (Button)sender;
            D = B.Text;
            N1 = textBox1.Text;
            N2 = true;
        }

        private void button24_Click(object sender, EventArgs e) // =
        {
            double x1, x2, res = 0;
            x1 = Convert.ToDouble(N1);
            x2 = Convert.ToDouble(textBox1.Text);
            if (D == "+") res = x1 + x2;
            if (D == "-") res = x1 - x2;
            if (D == "*") res = x1 * x2;
            if (D == "/") res = x1 / x2;
            if (D == "%") res = x1 * x2 / 100;
            D = "=";
            N2 = true;
            textBox1.Text = res.ToString();
        }

        private void button5_Click(object sender, EventArgs e) // 1/x
        {
            double dn, res;
            dn = Convert.ToDouble(textBox1.Text);
            res = 1 / dn;
            textBox1.Text = res.ToString();
        }

        private void button6_Click(object sender, EventArgs e) // sqr
        {
            double dn, res;
            dn = Convert.ToDouble(textBox1.Text);
            res = Math.Pow(dn, 2);
            textBox1.Text = res.ToString();
        }

        private void button7_Click(object sender, EventArgs e) // sqrt
        {
            double dn, res;
            dn = Convert.ToDouble(textBox1.Text);
            res = Math.Sqrt(dn);
            textBox1.Text = res.ToString();
        }

        private void button21_Click(object sender, EventArgs e) // +/-
        {
            double dn, res;
            dn = Convert.ToDouble(textBox1.Text);
            res = -dn;
            textBox1.Text = res.ToString();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains(",")) textBox1.Text = textBox1.Text + ",";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            if (textBox1.Text == "") textBox1.Text = "0";
        }
    }
}