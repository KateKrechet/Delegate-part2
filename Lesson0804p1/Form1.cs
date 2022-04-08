using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson0804p1
{
    public partial class Form1 : Form
    {
        delegate void myDelegate();
        myDelegate test;

        Action<int, int, double> action;
        Func<int, int, int> func;
        Func<int, double> Half;
        public Form1()
        {
            InitializeComponent();
            test = new myDelegate(Message);
            action = new Action<int, int, double>(Sum);
            //аналог делегата,кот не возвращает значение(только void)
            func = new Func<int, int, int>(Sum);//частный лучай делегата
            Half = new Func<int, double>(x05);
        }
        int Sum(int a, int b)
        {
            return a + b;
        }
        double x05(int a)
        {

            return a * 0.5;
        }
        void Sum(int a, int b, double c)
        {
            MessageBox.Show((a + b + c).ToString());
        }

        void Message()
        {
            MessageBox.Show("Привет мир!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //test();
            //action();
            // action(10, 15, 15);
            // int x = func(10, 15);
            double x = Half(5);
            MessageBox.Show(x.ToString());

        }
    }
}
