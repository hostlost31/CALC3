using System;
using System.Drawing;
using System.Windows.Forms;



namespace CALC3
{
    public partial class Form1 : Form
    {

        public int index;
        public string memory;
        public string unit;


        public Form1()
        {

            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        Form1: this.Width = 281; this.Height = 463;
            index = 0;
            unit = "radian";
        }

        private void butNUMandOPERAND_Click(object sender, EventArgs e)
        {


            Button BUT = (Button)sender;
            if (DECKBOX.Text == "")
            {
                DECKBOX.Text = "0";
            }
            if (DECKBOX.Text == "0")
            {
                DECKBOX.Text = BUT.Text;
                index++;
            }
            else
            {

                DECKBOX.Paste(Convert.ToString(BUT.Text));
                index++;
            }
            DECKBOX.SelectionStart = index;
            DECKBOX.SelectionLength = 0;
            DECKBOX.Focus();

        }
        private void butRESULT_Click(object sender, EventArgs e)
        {

            string res = DECKBOX.Text;

            Parser parser = new Parser();
            try
            {
                double result = parser.Parse(res, unit);

                DECKBOX.Text = result.ToString();
                index = DECKBOX.Text.Length;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
            index = DECKBOX.Text.Length;
            DECKBOX.SelectionStart = index;
            DECKBOX.SelectionLength = 0;
            DECKBOX.Focus();

        }
        private void butZAPAT_Click(object sender, EventArgs e)
        {

            Button BUTcom = (Button)sender;

            DECKBOX.Paste(Convert.ToString(BUTcom.Text));
            index++;


            DECKBOX.SelectionStart = index;
            DECKBOX.SelectionLength = 0;
            DECKBOX.Focus();

        }

        private void M_Plus_Button_Click(object sender, EventArgs e)
        {
            try
            {
                memory += Convert.ToDouble(this.DECKBOX.Text);
                but_MS.BackColor = Color.Aqua;

            }
            catch (System.FormatException)
            {
                MessageBox.Show("Неверный формат строки: " + this.DECKBOX.Text);
                return;
            }
        }
        private void M_Result_Button_Click(object sender, EventArgs e)
        {

            if (DECKBOX.Text == "0")
            {
                DECKBOX.Text = memory;
                index = index + memory.Length;
            }
            else
            {

                DECKBOX.Paste(Convert.ToString(memory));
                index = index + memory.Length;
            }


        }
        private void M_Clear_Button_Click(object sender, EventArgs e)
        {
            try
            {
                memory = "";
                but_MS.BackColor = Color.White;

            }
            catch (System.FormatException)
            {
                MessageBox.Show("Неверный формат строки: " + this.DECKBOX.Text);
                return;
            }
        }

        private void But_BackSpace(object sender, EventArgs e)
        {
            if (DECKBOX.Text.Length > 0)
            {
                string str = DECKBOX.Text;
                if (str.Length > 1)
                {
                    str = str.Remove(index - 1, 1);
                }
                else
                {
                    str = "0";
                }
                DECKBOX.Text = str;
            }
            if (DECKBOX.Text == "")
            {
                DECKBOX.Text = "0";
            }
            index = index - 1;
        }

        private void but_inversia_Click(object sender, EventArgs e)
        {
            Parser parser = new Parser();
            string tmp = DECKBOX.Text;
            double res = Convert.ToDouble(parser.Parse(tmp, unit)) * -1;
            DECKBOX.Text = res.ToString();
            DECKBOX.SelectionStart = DECKBOX.Text.Length;
            DECKBOX.SelectionLength = 0;
            DECKBOX.Focus();
        }

        private void but_ClearFULL_Click(object sender, EventArgs e)
        {
            DECKBOX.Text = "0";
            index = 1;
            DECKBOX.SelectionStart = index;
            DECKBOX.SelectionLength = 0;
            DECKBOX.Focus();
        }

        private void but_Pi_Click(object sender, EventArgs e)
        {
            Button BUTpi = (Button)sender;
            if (DECKBOX.Text == "0")
            {
                DECKBOX.Text = BUTpi.Text;
                index++;
            }
            else
            {

                DECKBOX.Paste(Convert.ToString(BUTpi.Text));
                index++;
            }

            DECKBOX.SelectionStart = index;
            DECKBOX.SelectionLength = 0;
            DECKBOX.Focus();
        }

        private void but_e_Click(object sender, EventArgs e)
        {
            Button BUTE = (Button)sender;
            if (DECKBOX.Text == "0")
            {
                DECKBOX.Text = BUTE.Text;
                index++;
            }
            else
            {

                DECKBOX.Paste(Convert.ToString(BUTE.Text));
                index++;
            }

            DECKBOX.SelectionStart = index;
            DECKBOX.SelectionLength = 0;
            DECKBOX.Focus();
        }
        private void but_TrigonomANDTrigH_Click(object sender, EventArgs e)
        {
            Button BUTTRIG = (Button)sender;
            if (DECKBOX.Text == "0")
            {
                DECKBOX.Text = BUTTRIG.Text + "(";
                index = DECKBOX.Text.Length;
            }
            else
            {
                DECKBOX.Paste(BUTTRIG.Text + '(');
                index = index + 5;
            }
            DECKBOX.SelectionStart = index;
            DECKBOX.SelectionLength = 0;
            DECKBOX.Focus();
        }
        private void but_TrigonomForm_Click(object sender, EventArgs e)
        {
            Button BUTTRIG = (Button)sender;
            if (DECKBOX.Text == "0")
            {
                DECKBOX.Text = BUTTRIG.Text + "(";
                index = DECKBOX.Text.Length;
            }
            else
            {
                DECKBOX.Paste(BUTTRIG.Text + '(');
                index = index + 4;
            }
            DECKBOX.SelectionStart = index;
            DECKBOX.SelectionLength = 0;
            DECKBOX.Focus();
        }
        private void but_QRT_Click(object sender, EventArgs e)
        {
            if (DECKBOX.Text == "0")
            {
                DECKBOX.Text = "0";
            }
            else
            {
                Button ButTmp = (Button)sender;
                string temp = ButTmp.Text;
                temp = temp.Substring(1);
                DECKBOX.Paste(temp);
                DECKBOX.SelectionStart = DECKBOX.Text.Length;
                DECKBOX.SelectionLength = 0;
                DECKBOX.Focus();
            }
        }

        private void but_DAG_Click(object sender, EventArgs e)
        {
            unit = "degree";
            UNITBOX.Text = unit;
        }

        private void but_RAD_Click(object sender, EventArgs e)
        {
            unit = "radian";
            UNITBOX.Text = unit;
        }

        private void StandartToolStripMenuItem_Click(object sender, EventArgs e)
        {
        Form1: Width = 281; Height = 463;

        }

        private void EngineeringToolStripMenuItem_Click(object sender, EventArgs e)
        {
        Form1: Width = 617; Height = 463;

        }

        private void TextBox1_KeyUp(object sender, MouseEventArgs e)
        {
            int cursorPosition = DECKBOX.SelectionStart;
            index = cursorPosition;
        }

        private void TrigFormMinus1(object sender, EventArgs e)
        {
            Button ButTrigMIN = (Button)sender;
            if (DECKBOX.Text == "0")
            {
                string temp = ButTrigMIN.Text;
                temp = temp.Substring(0, 3) + "()^-1";
                DECKBOX.Text = ('(' + temp + ')');
                index = index + 5;
            }
            else
            {
                string temp = ButTrigMIN.Text;
                temp = temp.Substring(0, 3) + "()^-1";
                DECKBOX.Paste('(' + temp + ')');
                index = index + 5;
            }
            DECKBOX.SelectionStart = index;
            DECKBOX.SelectionLength = 0;
            DECKBOX.Focus();
        }
        private void PowX(object sender, EventArgs e)
        {
            if (DECKBOX.Text == "0")
            {
                DECKBOX.Text = "0";
            }
            else
            {
                Button ButPOWX = (Button)sender;
                if (DECKBOX.Text == "0")
                {
                    string temp = ButPOWX.Text;
                    temp = temp.Substring(0, (temp.Length - 1));
                    DECKBOX.Text = ('(' + temp + ')');
                    index = index + 4;
                }
                else
                {
                    string temp = ButPOWX.Text;
                    temp = temp.Substring(0, (temp.Length - 1));
                    DECKBOX.Paste('(' + temp + ')');
                    index = index + 4;
                }
                DECKBOX.SelectionStart = index;
                DECKBOX.SelectionLength = 0;
                DECKBOX.Focus();
            }
        }
        private void PowX2(object sender, EventArgs e)
        {
            if (DECKBOX.Text == "0")
            {
                DECKBOX.Text = "0";
            }
            else
            {
                Button ButPOWX = (Button)sender;
                if (DECKBOX.Text == "0")
                {
                    string temp = ButPOWX.Text;
                    temp = temp.Substring(0, (temp.Length - 1));
                    DECKBOX.Text = ('(' + temp + ')');
                    index = index + 3;
                }
                else
                {
                    string temp = ButPOWX.Text;
                    temp = temp.Substring(0, (temp.Length - 1));
                    DECKBOX.Paste('(' + temp + ')');
                    index = index + 3;
                }
                DECKBOX.SelectionStart = index;
                DECKBOX.SelectionLength = 0;
                DECKBOX.Focus();
            }
        }

        private void but_qrt_Click_1(object sender, EventArgs e)
        {
            if (DECKBOX.Text == "0")
            {
                DECKBOX.Text = "0";
            }
            else
            {
                DECKBOX.Paste("^");
                index++;
                DECKBOX.SelectionStart = index;
                DECKBOX.SelectionLength = 0;
                DECKBOX.Focus();
            }
        }
        private void but_Sqrt1x_Click(object sender, EventArgs e)
        {
            if (DECKBOX.Text == "0")
            {
                Button ButTmp = (Button)sender;
                string temp = ButTmp.Text;
                temp = temp.Substring(1);
                temp = temp.Remove(4);
                DECKBOX.Text = (temp + ')');
                index = index + 4;
                DECKBOX.SelectionStart = index;
                DECKBOX.SelectionLength = 0;
                DECKBOX.Focus();
            }
            else
            {
                Button ButTmp = (Button)sender;
                string temp = ButTmp.Text;
                temp = temp.Substring(1);
                temp = temp.Remove(4);
                DECKBOX.Paste(temp + ')');
                index = index + 4;
                DECKBOX.SelectionStart = index;
                DECKBOX.SelectionLength = 0;
                DECKBOX.Focus();
            }
        }
        private void but_LN_Click(object sender, EventArgs e)
        {

            Button BUTLN = (Button)sender;
            if (DECKBOX.Text == "0")
            {
                DECKBOX.Text = BUTLN.Text + "(";
                index = index + 3;
            }
            else
            {

                DECKBOX.Paste(Convert.ToString(BUTLN.Text + "("));
                index = index + 3;
            }

            DECKBOX.SelectionStart = index;
            DECKBOX.SelectionLength = 0;
            DECKBOX.Focus();
        }
    }
}
