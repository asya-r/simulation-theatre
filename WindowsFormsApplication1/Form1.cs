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
        // every day redeption gets bigger: yesterday sold tickets * coef
        double coef = 2;

        // tickets, sold in first day
        int start = 2;

        int price = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int day = Convert.ToInt32(days_left.Text) - 1;
            int ticket = Convert.ToInt32(start * coef * (20 - day));
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
            timer1.Enabled = true;
            days_left.Text = (Convert.ToInt32(days_left.Text) - 1).ToString();
            tickets_sold.Text = "0";
            Console.Write(day_type.SelectedIndex);
            double time_pl = 0;
            if (time.Value < 20 && time.Value > 17)
            {
                time_pl = 5;
            }

            // цена зависит от стоимости аренды, техники, рекламы; зп актеров и обслуживающего персонала. Полная сумма делится на количество мест (делится на половину - если не раскупят) 
            price = Decimal.ToInt32((rent.Value + technics.Value + ad.Value + staff_salary.Value + actors_salary.Value) / (places.Value / 2));

            // коэффициент скупаемости зависит от известности постановки, рекламы, времени суток, типа дня (будни/выходной/праздник)
            coef = coef + (Convert.ToDouble(fame.Value) + day_type.SelectedIndex + Convert.ToDouble(ad.Value) / 1000 + time_pl) / 10 ;
            label4.Text = "ЦЕНА БИЛЕТА: " + price.ToString();
        }





    }
}
