using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }

        private void Input567_Click(object sender, EventArgs e)
        {
            sideSquare.Value = 567;
        }
    }
}
