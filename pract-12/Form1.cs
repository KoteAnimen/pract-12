using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using solvingPS;

namespace pract_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DateTime t = DateTime.Now;
            currentTime.Text = "Время: " + t.ToString("HH:mm");
            currentData.Text = "Дата: " + t.ToString("dd.MM.yyyy");
            numberTask.Text = "Номер задачи - " + 1;
        }

        private void Input567_Click(object sender, EventArgs e)
        {
            sideSquare.Value = 567;
        }

        private void ChangeNumberTask(object sender, EventArgs e)
        {
            if(tabControl1.SelectedIndex == 0)
            {
                numberTask.Text = "Номер задачи - " + 1;
            }
            else
            {
                numberTask.Text = "Номер задачи - " + 2;
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AboutUs_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Филяк, ИСП-31, вариант 1." + "\n" + "Реализовать расчет задачи:" + "\n" + "1) Дана сторона квадрата a. Найти его площадь и периметр." + "\n" + "2) Дано трехзначное число. Вывести вначале его последнюю цифру (единицы), а затем — его среднюю цифру (десятки). ", "О программе");
        }

        private void GetAnswerPS_Click(object sender, EventArgs e)
        {
            perimeter.Text = Solve.Perimeter((int)sideSquare.Value).ToString();
            area.Text = Solve.Area((int)sideSquare.Value).ToString();
        }

        private void GetAnswerMenu_Click(object sender, EventArgs e)
        {
            perimeter.Text = Solve.Perimeter((int)sideSquare.Value).ToString();
            area.Text = Solve.Area((int)sideSquare.Value).ToString();
        }

        private void Input435_Click(object sender, EventArgs e)
        {
            number.Value = 435;
        }

        private void GetAnswer_Click(object sender, EventArgs e)
        {
            int ten = 0;
            int term = 0;
            Solve.TermsTens((int)number.Value, out ten, out term);
            tens.Text = ten.ToString();
            terms.Text = term.ToString();
        }

        private void GetAnswerNumber_Click(object sender, EventArgs e)
        {
            int ten = 0;
            int term = 0;
            Solve.TermsTens((int)number.Value, out ten, out term);
            tens.Text = ten.ToString();
            terms.Text = term.ToString();
        }
    }
}
