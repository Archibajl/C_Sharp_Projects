using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorPracticeForm_Archibald
{
    public partial class Form1 : Form
    {
        string leftSide = "";
        string rightSide = "";
        string operation = "";
        public Form1()
        {
            

            InitializeComponent();
            List<Button> buttons = new List<Button>()
                {

                button1, button2, button3, button4, button5, button6, button7, button8, button9, button10
            };

            foreach(Button b in buttons)
            {
                b.Click += (o, e) => OnValueClick(b.Text);
            }
            

        }

        private void OnValueClick(string value)
        {
            if (operation == "")
            {
                leftSide += value;
                DisplayBox.Lines = new string[] { ""+ leftSide +};
            }else
            {
                rightSide += value;
                DisplayBox.Lines = new string[] { "", leftSide };
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
