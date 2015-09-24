using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.InteropServices;

namespace csMouseTest
{
    public partial class Form1 : Form
    {
        int x1, y1;
        int delay;
        int dx, dy;

        Point p;


        [DllImport("USER32.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void SetCursorPos(int X, int Y);

        [DllImport("USER32.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);


        public Form1()
        {
            InitializeComponent();

            dx = 0;
            dy = 0;

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            x1 = int.Parse(textBox1.Text);
            y1 = int.Parse(textBox2.Text);
            delay = int.Parse(textBox3.Text);
            dx = int.Parse(textBox5.Text);
            dy = int.Parse(textBox4.Text);

            Cursor.Position = new System.Drawing.Point(x1, y1);
            p = Cursor.Position;

            
            for (int i = 0; i < 100; i++)
            {
                await Task.Delay(delay);
                p.X += dx;
                p.Y += dy;
                SetCursorPos(p.X, p.Y);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            x1 =  int.Parse(textBox1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
