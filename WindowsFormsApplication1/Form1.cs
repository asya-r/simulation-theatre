using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
	public partial class Form1 : Form
	{
		bool paused = true;

		// every day redemption gets bigger: yesterday sold tickets * coef
		double coef = 1;

		// tickets, sold in first day
		int start = 2;

		int price = 0;

		int allDays = 20;

		public Form1()
		{
			InitializeComponent();
			timer1.Interval = 100;
			days_left.Text = allDays.ToString();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			int day = Convert.ToInt32(days_left.Text) - 1;
			int ticket = Convert.ToInt32(start * coef * (allDays - day));
			if (places.Value - Convert.ToInt32(tickets_sold.Text) - ticket >= 0)
			{
				tickets_sold.Text = (Convert.ToInt32(tickets_sold.Text) + ticket).ToString();
			}
			else
			{
				tickets_sold.Text = places.Value.ToString();
			}
			if (day == -1)
			{
				timer1.Enabled = false;
				label14.Text = "ВЫРУЧКА: " + (price * Convert.ToInt32(tickets_sold.Text)).ToString();

			}
			else
			{
				days_left.Text = day.ToString();
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (paused)
			{
				paused = !paused;
				timer1.Start();
				Console.Write(day_type.SelectedIndex);
				double time_pl = 0;
				if (time.Value < 20 && time.Value > 17)
				{
					time_pl = 5;
				}

				// цена зависит от стоимости аренды, техники, рекламы; зп актеров и обслуживающего персонала. Полная сумма делится на количество мест (делится на половину - если не раскупят) 
				price = Decimal.ToInt32((rent.Value + technics.Value + ad.Value + staff_salary.Value + actors_salary.Value) / (places.Value / 2));
				if (button1.Text == "Начать отсчет")
					// коэффициент скупаемости зависит от известности постановки, рекламы, времени суток, типа дня (будни/выходной/праздник)
					coef += (Convert.ToDouble(fame.Value) + day_type.SelectedIndex + Convert.ToDouble(ad.Value) / 1000 + time_pl) / 10;

				button1.Text = "Остановить";
				label4.Text = "ЦЕНА БИЛЕТА: " + price.ToString();
			}
			else
			{
				paused = !paused;
				button1.Text = "Продолжить";
				timer1.Stop();
			}
		}

		private void tickets_sold_Click(object sender, EventArgs e)
		{

		}
	}
}
