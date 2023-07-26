using System.Windows;

namespace Calculator.Date
{
	internal class TimeCounting : ITimeCounting
	{
		private string _firstDate = null!;
		private string _lastDate = null!;

		public DateTime FirstDateTime { get; set; } = new DateTime();

		public DateTime SecondDateTime { get; set; } = new DateTime();

		public string Time(string date)
		{
			string[] n = date.Split("=>");

			_firstDate = n[0];

			string[] fdate = _firstDate.Split(",");

			_lastDate = n[1];

			string[] ldate = _lastDate.Split(",");

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
				FirstDateTime = new DateTime(year: firstdate[0],
										 month: firstdate[1],
										 day: firstdate[2],
										 hour: firstdate[3],
										 minute: firstdate[4],
										 second: firstdate[5]);
				SecondDateTime = new DateTime(year: lastdate[0],
										 month: lastdate[1],
										 day: lastdate[2],
										 hour: lastdate[3],
										 minute: lastdate[4],
										 second: lastdate[5]);
			}
			catch (Exception)
			{
				_ = MessageBox.Show("Такая дата не существует, проверьте вводимые данные еще раз");
			}

			int year = Math.Abs(SecondDateTime.Year - FirstDateTime.Year);
			int month = Math.Abs(SecondDateTime.Month - FirstDateTime.Month);
			int days = Math.Abs(SecondDateTime.Day - FirstDateTime.Day);
			int houres = Math.Abs(SecondDateTime.Hour - FirstDateTime.Hour);
			int minute = Math.Abs(SecondDateTime.Minute - FirstDateTime.Minute);
			int second = Math.Abs(SecondDateTime.Second - FirstDateTime.Second);

			return $"В Российском и Британском формах\n\n"
				   + $"Количество лет {year}\n"
				   + $"Количество месяцев = {month}\n"
				   + $"Количество дней {days}\n"
				   + $"Количество часов {houres}\n"
				   + $"Количество минут {minute}\n"
				   + $"Количество секунд {second}\n\n"
				   + $"В Американском формате\n\n"
				   + $"Количество лет {year}\n"
				   + $"Количество дней {days}\n"
				   + $"Количество месяцев = {month}\n"
				   + $"Количество часов {houres}\n"
				   + $"Количество минут {minute}\n"
				   + $"Количество секунд {second}";
		}
	}
}