using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {

        public string _value;
        public string _value1, _totNumber="0";
        double _value3,_value4;
        bool _plus_click, _minus_click, _div_click, _multiple_click;
        bool _sqr_click, _sqrt_click, _sin_click, _cos_click;
        public  string equation;

        
        public Form1()
        {

            
            InitializeComponent();


           
        }      

        private void Button(object sender, EventArgs e)
        {

           //  double value1;

            Button button = (Button)sender;
            if (textBox1.Text == "ZERO")
            {
                textBox1.Clear();
            }
            textBox1.Text = textBox1.Text + button.Text;
            equation = equation + button.Text;

            label1.Text = equation;
           
        }

       

        
      

        private void button16_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void IfZero(double _value4)
        {
            if (_value4 == 0.0)
            {
                throw new NullReferenceException(" value is eq. 0");
            }
        }
        private void solve(object sender, EventArgs e)
        {
          

            if (_plus_click)
            {
              
                _value4 = Convert.ToDouble(textBox1.Text);
                _value4 = _value4  + _value3;
            }

            if (_minus_click)
            {
             
                _value4 = Convert.ToDouble(textBox1.Text);
                _value4 = -_value4 + _value3;
            }

            if (_multiple_click)
            {
              
                _value4 = Convert.ToDouble(textBox1.Text);
                _value4 = _value4 * _value3;
            }

           
            
            if (_div_click)
            {
               
                //exeption
                try
                {
                    IfZero(_value4);
                }
                catch (Exception ex)
                {

                     MessageBox.Show(ex.Message);
                }
              
                _value4 = Convert.ToDouble(textBox1.Text);
                _value4 = _value3/_value4 ;
            }

            if (_sqr_click)
            {
                _value4=_value3*_value3;

              
            }

            if (_sqrt_click)
            {
                _value4 = Math.Sqrt(_value3);

                 
            }

            if (_sin_click)
            {
                _value4 = Math.Sin(_value3);
            }

            if (_cos_click)
            {
                _value4 = Math.Cos(_value3);
            }
            textBox1.Clear();
            equation =equation+button15.Text+_value4.ToString() ;
            label1.Text = equation;
            textBox1.Text = _value4.ToString() ;

            _plus_click = false;
            _minus_click = false;
            _multiple_click = false;
            _div_click = false;
            _sqr_click = false;
            _sqrt_click = false;
            _sin_click = false;
            _cos_click = false;
            _value3 = 0.0;
            _value4 = 0.0;

        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label1.Text = "";
            equation = "";
        }

        private void Add(object sender, EventArgs e)
        {
            _value3 = Convert.ToDouble(textBox1.Text);
            equation = equation+button11.Text;
            label1.Text = equation ;
            textBox1.Clear();
            _plus_click = true;
        }


        private void minus(object sender, EventArgs e)
        {
            _value3 = Convert.ToDouble(textBox1.Text);
            equation =  equation+button12.Text;
            label1.Text = equation;
            textBox1.Clear();
            _minus_click = true;
        }

        private void divide(object sender, EventArgs e)
        {
            _value3 = Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
            equation =  equation+button13.Text ;
            label1.Text = equation;
            _div_click = true;
        }

        private void multiple(object sender, EventArgs e)
        {
            _value3 = Convert.ToDouble(textBox1.Text);
            equation =  equation+button14.Text;
            label1.Text = equation;
            textBox1.Clear();
            _multiple_click = true;
        }

        private void sqr(object sender, EventArgs e)
        {
            _value3 = Convert.ToDouble(textBox1.Text);
            equation = equation + "^2";
            label1.Text = equation;
            textBox1.Clear();
            _sqr_click = true;
        }

        private void sqrt(object sender, EventArgs e)
        {
            _value3 = Convert.ToDouble(textBox1.Text);
            equation = equation + "^0.5";
            label1.Text = equation;
            textBox1.Clear();
            _sqrt_click = true;

        }

        private void sin(object sender, EventArgs e)
        {
            _value3 = Convert.ToDouble(textBox1.Text);
            equation = "SIN( "+equation + ") ";
            label1.Text = equation;
            textBox1.Clear();
            _sin_click = true;
        }

        private void cos(object sender, EventArgs e)
        {
            _value3 = Convert.ToDouble(textBox1.Text);
            equation = "COS( " + equation + ") ";
            label1.Text = equation;
            textBox1.Clear();
            _cos_click = true;

        }

       
        

       
    }

   
}
