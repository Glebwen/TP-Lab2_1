namespace TPLab_2_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ABox.Text = Properties.Settings.Default.ABox.ToString();
            BBox.Text = Properties.Settings.Default.BBox.ToString();
            CBox.Text = Properties.Settings.Default.CBox.ToString();
            ABox.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var A = this.ABox.Text;
            var B = this.BBox.Text;
            var C = this.CBox.Text;

            Properties.Settings.Default.ABox = A;
            Properties.Settings.Default.BBox = B;
            Properties.Settings.Default.CBox = C;
            Properties.Settings.Default.Save();

            if (Logic.IncreaseMonthCount(A, B, C) == "некорректный ввод")
            {
                MessageBox.Show("Некорректный ввод", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (Logic.IncreaseMonthCount(A, B, C) == "числа за пределами ОДЗ")
                {
                    MessageBox.Show("числа за пределами ОДЗ", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("а) Количество месяцев, необходимое для того, чтобы размер увеличения превысил указанное значение: " + Logic.IncreaseMonthCount(A, B, C) + "\n" + "б) Количество месяцев, необходимое для того, чтобы размер вклада превысил указанное значение: " + Logic.DepositMonthCount(A, B, C), "Все норм");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.ABox.Text = "";
            this.BBox.Text = "";
            this.CBox.Text = "";
        }

        void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Console.Beep();
            if (e.KeyCode == Keys.Enter)
            {
                if (ActiveControl == ABox)
                {
                    BBox.Focus();
                }
                else if (ActiveControl == BBox)
                {
                    CBox.Focus();
                }
                else if (ActiveControl == CBox)
                {
                    ABox.Focus();
                }

            }
        }
    }

    public class Logic
    {
        public static string IncreaseMonthCount(string a, string b, string c)
        {
            string aAnswer;
            if (!float.TryParse(a, out float floatA) || !float.TryParse(b, out float floatB) || !float.TryParse(c, out float floatC))
            {
                aAnswer = "некорректный ввод";
            }
            else
            {
                floatA = float.Parse(a);
                floatB = float.Parse(b);
                floatC = float.Parse(c);
                if (!(floatA >= 0 && floatB >= 0 && floatC >= 0))
                {
                    aAnswer = "числа за пределами ОДЗ";
                }
                else
                {
                    float incr = 0;
                    int aMonth = -1;
                    for (int i = 1; incr <= floatB; i++)
                    {
                        incr = floatA / 50;
                        floatA += incr;
                        if (incr > floatB && aMonth == -1)
                        {
                            aMonth = i;
                        }
                    }
                    aAnswer = aMonth.ToString();
                }
            }
            return aAnswer;
        }
        public static string DepositMonthCount(string a, string b, string c)
        {
            string bAnswer;
            if (!float.TryParse(a, out float floatA) || !float.TryParse(b, out float floatB) || !float.TryParse(c, out float floatC))
            {
                bAnswer = "некорректный ввод";
            }
            else
            {
                floatA = float.Parse(a);
                floatB = float.Parse(b);
                floatC = float.Parse(c);
                if (!(floatA >= 0 && floatB >= 0 && floatC >= 0))
                {
                    bAnswer = "числа за пределами ОДЗ";
                }
                else
                {
                    float incr;
                    int bMonth = -1;
                    for (int i = 1; floatA <= floatC; i++)
                    {
                        incr = floatA / 50;
                        floatA += incr;
                        if (floatA > floatC && bMonth == -1)
                        {
                            bMonth = i;
                        }
                    }
                    bAnswer = bMonth.ToString();
                }
            }
            return bAnswer;
        }
    }

}
