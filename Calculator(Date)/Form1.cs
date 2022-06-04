using System;
using System.Windows.Forms;
namespace Calculator_Date_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Button14_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText(",");
        }
        private void Button13_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox2.Clear();
        }
        private void Button12_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText("9");
        }
        private void Button11_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText("8");
        }
        private void Button10_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText("7");
        }
        private void Button9_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText("6");
        }
        private void Button8_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText("5");
        }
        private void Button7_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText("4");
        }
        private void Button6_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText("3");
        }
        private void Button5_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText("2");
        }
        private void Button4_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText("1");
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            TimeCounting timeCounting = new TimeCounting();
            string rez = timeCounting.Time(richTextBox1.Text);
            richTextBox2.AppendText(rez);
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText("0");
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText("=>"); 
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Доброго времени суток");
            MessageBox.Show("\t\t\tНАПОМИНАНИЕ!!!\n"
                            + "Количество месяцев в году 12\n"
                            + "Количество дней в месяце если это четные месяца кроме Февраля, Августа и Декабря - 30\n"
                            + "Количество дней в месяце если это не четные месяца - 31\n"
                            + "Количество дней в месяце если это Февраль и Год високосный - 29\n"
                            + "Количество дней в месяце если это Февраль и год обычный - 28\n"
                            + "Количество часов в сутках - 24\n"
                            + "Количество минут в часе - 60\n"
                            + "Количество секунд в минуте - 60");
        }
    }
    internal class TimeCounting
    {
        private string FirstDate { get; set; }
        private string LastDate { get; set; }
        public DateTime DateTime1 { get; set; } = new DateTime();
        public DateTime DateTime2 { get; set; } = new DateTime();
        public string Time(string date)
        {
            string[] n = date.Split("=>");
            FirstDate = n[0];
            string[] fdate = FirstDate.Split(",");
            LastDate = n[1];
            string[] ldate = LastDate.Split(",");
            int[] firstdate = new int[fdate.Length];
            for (int i = 0; i < firstdate.Length; i++)
            {
                firstdate[i] = int.Parse(fdate[i]);
            }
            int[] lastdate = new int[ldate.Length];
            for (int i = 0; i < lastdate.Length; i++)
            {
                lastdate[i] = int.Parse(ldate[i]);
            }
            try
            {
                DateTime1 = new DateTime(year: firstdate[0],
                                         month: firstdate[1],
                                         day: firstdate[2],
                                         hour: firstdate[3],
                                         minute: firstdate[4],
                                         second: firstdate[5]);
                DateTime2 = new DateTime(year: lastdate[0],
                                         month: lastdate[1],
                                         day: lastdate[2],
                                         hour: lastdate[3],
                                         minute: lastdate[4],
                                         second: lastdate[5]);
            }
            catch (Exception)
            {
                MessageBox.Show("Такая дата не существует, проверьте вводимые данные еще раз");
            }
            int Year = Math.Abs(DateTime2.Year - DateTime1.Year);
            int Month = Math.Abs(DateTime2.Month - DateTime1.Month);
            int Days = Math.Abs(DateTime2.Day - DateTime1.Day);
            int Houres = Math.Abs(DateTime2.Hour - DateTime1.Hour);
            int Minute = Math.Abs(DateTime2.Minute - DateTime1.Minute);
            int Second = Math.Abs(DateTime2.Second - DateTime1.Second);
            return $"В Российском и Британском формах\n\n"
                   + $"Количество лет {Year}\n"
                   + $"Количество месяцев = {Month}\n"
                   + $"Количество дней {Days}\n"
                   + $"Количество часов {Houres}\n"
                   + $"Количество минут {Minute}\n"
                   + $"Количество секунд {Second}\n\n"
                   + $"В Американсоком формате\n\n"
                   + $"Количество лет {Year}\n"
                   + $"Количество дней {Days}\n"
                   + $"Количество месяцев = {Month}\n"
                   + $"Количество часов {Houres}\n"
                   + $"Количество минут {Minute}\n"
                   + $"Количество секунд {Second}";
        }
    }
}