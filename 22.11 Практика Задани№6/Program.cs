using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22._11_практика_задание_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string year1;
            year1 = Interaction.InputBox("Введите текущий год",
                "Ввод года");
            string year2;
            year2 = Interaction.InputBox("Введите ваш год рождения",
                "Ввод вашего года рождения");
            int x = Convert.ToInt32(year1);
            int y = Convert.ToInt32(year2);
            int age = x - y;
            string res = age.ToString();


            //string txt = "Имя: " + name1 + ", Фамилия: " + name2;
            MessageBox.Show(res, "Итог.");
        }
    }
}