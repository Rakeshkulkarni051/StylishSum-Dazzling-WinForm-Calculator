using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClaculatorUI
{
    public partial class Calculator : Form
    {
        Double num1, num2, result;
        String operation;
        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
           if(numin.Text=="0")
                numin.Clear();
            if (operation == null)
                numin.Text = numin.Text + "1";
            else
                numin2.Text = numin2.Text + "1";
        }

        private void roundButton2_Click(object sender, EventArgs e)
        {
            if (numin.Text == "0")
                numin.Clear();
            if (operation == null)
                numin.Text = numin.Text + "2";
            else
                numin2.Text = numin2.Text + "2";
        }

        private void roundButton8_Click(object sender, EventArgs e)
        {
            if (numin.Text == "0")
                numin.Clear();
            if (operation == null)
                numin.Text = numin.Text + "8";
            else
                numin2.Text = numin2.Text + "8";
        }

        private void num1_TextChanged(object sender, EventArgs e)
        {
        
           
        }

        private void roundButton9_Click(object sender, EventArgs e)
        {
            if (numin.Text == "0")
                numin.Clear();
            if (operation == null)
                numin.Text = numin.Text + "9";
            else
                numin2.Text = numin2.Text + "9";
        }

        private void roundButton13_Click(object sender, EventArgs e)
        {
            num1 = Double.Parse(numin.Text);
            operation = "-";
            oprsign.Text = "-";
            oprsign.Visible = true;
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                num1 = Double.Parse(numin.Text);
                operation = "+";
                oprsign.Text = "+";
                oprsign.Visible = true;
            }
            catch(Exception u)
            {

            }
           
        }

        private void roundButton11_Click(object sender, EventArgs e)
        {
           numin.Clear();
            numin2.Clear();
            Res.Clear();
            oprsign.Visible = false;
            num1 = 0;
            num2 = 0;
            result = 0;
        }

        private void roundButton17_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);

        }

        private void roundButton3_Click(object sender, EventArgs e)
        {
            if (numin.Text == "0")
                numin.Clear();
            if (operation == null)
                numin.Text = numin.Text + "3";
            else
                numin2.Text = numin2.Text + "3";
        }

        private void roundButton6_Click(object sender, EventArgs e)
        {
            if (numin.Text == "0")
                numin.Clear();
            if (operation == null)
                numin.Text = numin.Text + "6";
            else
                numin2.Text = numin2.Text + "6";
        }

        private void roundButton5_Click(object sender, EventArgs e)
        {
            if (numin.Text == "0")
                numin.Clear();
            if (operation == null)
                numin.Text = numin.Text + "5";
            else
                numin2.Text = numin2.Text + "5";
        }

        private void roundButton4_Click(object sender, EventArgs e)
        {
            if (numin.Text == "0")
                numin.Clear();
            if (operation == null)
                numin.Text = numin.Text + "4";
            else
                numin2.Text = numin2.Text + "4";
        }

        private void roundButton7_Click(object sender, EventArgs e)
        {
            if (numin.Text == "0")
                numin.Clear();
            if (operation == null)
                numin.Text = numin.Text + "7";
            else
                numin2.Text = numin2.Text + "7";
        }

        private void roundButton10_Click(object sender, EventArgs e)
        {
            if (numin.Text == "0")
                numin.Clear();
            if (operation == null)
                numin.Text = numin.Text + "0";
            else
                numin2.Text = numin2.Text + "0";
        }

        private void Multipication_Click(object sender, EventArgs e)
        {
            num1 = Double.Parse(numin.Text);
            operation = "*";
            oprsign.Text = "x";
            oprsign.Visible = true;
         
        }

        private void Division_Click(object sender, EventArgs e)
        {
            num1 = Double.Parse(numin.Text);
            operation = "/";
            oprsign.Text = "/";
            oprsign.Visible = true;
        }

        private void Modu_Click(object sender, EventArgs e)
        {
            num1 = Double.Parse(numin.Text);
            operation = "%";
            oprsign.Text = "%";
            oprsign.Visible = true;
        }

        private void roundButtonRes_Click(object sender, EventArgs e)
        {
            
            num2 = Double.Parse(numin2.Text);
            switch (operation)
            {
                case "+":
                    {
                        result=num1 + num2;
                       
                        Res.Text = "= "+ result.ToString();
                       
                    }
                    break;
                case "-":
                    {
                        result = num1-num2;
                       
                        Res.Text = result.ToString();
                    }
                    break;
                case "*":
                    {
                        result = num1 * num2;
                       
                        Res.Text = result.ToString();


                    }
                    break;
                    case "/":
                    {
                        if (numin.Text == "0")
                            MessageBox.Show("can't Devide Number by Zero !");
                        else
                            result = num1 / num2;
                           
                        Res.Text = result.ToString();

                    }
                    break;
                case "%":
                    {
                        result = num1 % num2;
                       
                        Res.Text = result.ToString();

                    }
                    break;
                   
            }






        }

        private void oprsign_Click(object sender, EventArgs e)
        {
            oprsign.Visible = false;
        }

        private void roundButton18_Click(object sender, EventArgs e)
        {
            if (operation == null)
                numin.Text = numin.Text + ".";
            else
                numin2.Text = numin2.Text + ".";
        }

        private void Res_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
