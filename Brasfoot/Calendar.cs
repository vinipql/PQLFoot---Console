using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Brasfoot
{
    public class Calendar
    {
        static int year = new int();
        static int month = new int();
        static int[,] calendar = new int[6, 7];
        private static DateTime date;

        

        public void StartCalendar()
        {
            Console.Clear();
            year = DateTime.Now.Year;
            month = Convert.ToInt32(DateTime.Now.ToString("MM"));
            Convert.ToInt32(month);

            date = new DateTime(year, month, 1);//gives you a datetime object for the first day of the month  
            Console.WriteLine($"Hoje é {DateTime.Today}{Environment.NewLine}");
            DrawHeader();
            FillCalendar();
            DrawCalendar();
        }

        public void DrawHeader()
        {
            Console.Write("\n\n");
            //gives you the month and year at the top of the calendar  
            Console.WriteLine(CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(month) + " " + year);
            Console.WriteLine("S  T  Q  Q  S  S  D ");
        }

        public void FillCalendar()
        {
            int days = DateTime.DaysInMonth(year, month);
            int currentDay = 1;
            var dayOfWeek = (int)date.DayOfWeek;
            for (int i = 0; i < calendar.GetLength(0); i++)
            {
                for (int j = 0; j < calendar.GetLength(1) && currentDay - dayOfWeek + 1 <= days; j++)
                {
                    if (i == 0 && month > j)
                    {
                        calendar[i, j] = 0;
                    }
                    else
                    {
                        calendar[i, j] = currentDay - dayOfWeek + 1;
                        currentDay++;
                    }
                }
            }
        }

        public void DrawCalendar()
        {
            for (int i = 0; i < calendar.GetLength(0); i++)
            {
                for (int j = 0; j < calendar.GetLength(1); j++)
                {
                    if (calendar[i, j] > 0)
                    {
                        if (calendar[i, j] < 10)
                        {
                            Console.Write(" " + calendar[i, j] + " ");
                        }
                        else
                        {
                            Console.Write(calendar[i, j] + " ");
                        }
                    }
                    else
                    {
                        Console.Write("   ");
                    }
                }
                Console.WriteLine("");
            }
        }


        public void setCalendar(string name, List<string> adversario)
        {
            string[] data = DateTime.Now.ToString().Split('/');
            int dataAtual = Convert.ToInt32(data[0]);
            int x = 0;

            Console.WriteLine($"{Environment.NewLine}");
            for(int i = 5; i>0; i--)
            {
                
                dataAtual += 3;
                if(dataAtual > 31)
                {
                    dataAtual -= 31;
                    Math.Abs(dataAtual);
                    Console.WriteLine($"No dia {dataAtual} do próximo mês, teremos {name} x {adversario[x]}{Environment.NewLine}");
                }
                Console.WriteLine($"No dia {dataAtual}, teremos {name} x {adversario[x]}{Environment.NewLine}");
                x += 12;
            }
        }











    }
}