using System.Windows;
using System.Windows.Documents;

namespace Calculator.Date
{
	public partial class MainWindow : Window
	{
		private readonly ITimeCounting _timeCounting;

		public MainWindow()
		{
			InitializeComponent();

			_timeCounting = new TimeCounting();

			_ = MessageBox.Show("Доброго времени суток\n"
							+ "\t\t\tНАПОМИНАНИЕ!!!\n"
							+ "1) Количество месяцев в году 12\n"
							+ "2) Количество дней в месяце если это четные месяца кроме Февраля, Августа и Декабря - 30\n"
							+ "3) Количество дней в месяце если это нечетные месяца - 31\n"
							+ "4) Количество дней в месяце если это Февраль и Год високосный - 29\n"
							+ "5) Количество дней в месяце если это Февраль и год обычный - 28\n"
							+ "6) Количество часов в сутках - 24\n"
							+ "7) Количество минут в часе - 60\n"
							+ "8) Количество секунд в минуте - 60");
		}

		private void ButtonCalculateClick(object sender, RoutedEventArgs e)
		{
			string rez = _timeCounting.Time(new TextRange(richTextBoxDates.Document.ContentStart, richTextBoxDates.Document.ContentEnd).Text);
			richTextBoxResult.AppendText(rez);
		}

		private void ButtonClearClick(object sender, RoutedEventArgs e)
		{
			richTextBoxDates.Document.Blocks.Clear();
			richTextBoxResult.Document.Blocks.Clear();
		}

		private void ButtonCommaClick(object sender, RoutedEventArgs e)
		{
			richTextBoxDates.AppendText(",");
		}

		private void ButtonArrowClick(object sender, RoutedEventArgs e)
		{
			richTextBoxDates.AppendText("=>");
		}
	}
}