using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxCal
{
    public partial class Form1 : Form
    {
        //                              a%20s%20ssd%20s
        public string s { get; set; } = "a s ssd s";
        public Form1()
        {
            InitializeComponent();

            textBox1.Size = new Size(400, 100);
            textBox1.Name = "PriceBox";

            textBox2.Size = new Size(400, 80);
            textBox2.Name = "taxPriceBox";
            textBox2.Enabled= false;

            button1.Name = "calcButton";
            button1.Text = "計算する";

            label1.Text = "税込価格";
            label2.Text = "税抜価格";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = AR.Emp2(textBox1.Text,2);
            decimal price;
            var success=decimal.TryParse(textBox1.Text, out price);

            if (success)
            {
                decimal tax = price * (decimal)1.1;
                textBox2.Text=tax.ToString();
            }
        }
        
    }
    class AR
    {
        public static string Emp(string text, int count) => text.Replace(" ", "%20");


        public static string AddEmp(string str, int cou)
        {
            for (int i = 0; i < cou; i++)
            {
                str += " ";
            }
            return str;
        }
        public static string Emp2(string text, int count)
        {
            string str = null;
            foreach (var c in text)
            {
                if (c == ' ')
                {
                    str += "%20";
                }
                else
                {
                    str += c;
                }

            }

            return AddEmp(str, count);
        }
        public static int EmpCount(string text, int cou)
        {
            int count = 0;

            foreach (var c in Emp2(text, cou))
            {
                if (char.IsWhiteSpace(c)) count++;
            }
            return Emp2(text, cou).Length - count;
        }
    }
}
