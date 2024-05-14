using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miniräknare_upg
{
    public partial class FormMiniräknare : Form
    {
        double enterFirstValue, enterSecondValue;
        String op;
        public FormMiniräknare()
        {
            InitializeComponent(); 
        }

        private void EnterNumber(object sender, EventArgs e)
        {
            Button num = (Button)sender;

            if (txtResult.Text == "0")
                txtResult.Text = "";
            {
                if (num.Text == ",")
                    //Gör så att man inte kan lägga till fler än ett kommatecten.
                {
                    if (!txtResult.Text.Contains(","))
                        txtResult.Text = txtResult.Text + num.Text;
                }  
                else
                {
                    txtResult.Text = txtResult.Text + num.Text;
                }

            }
        }

        private void NumberOper(object sender, EventArgs e)
        {
            Button num = (Button)sender;

            enterFirstValue = Convert.ToDouble(txtResult.Text);
            op = num.Text;
            txtResult.Text = "";
        }

        private void btnLikamed_Click(object sender, EventArgs e)
        {
            enterSecondValue = Convert.ToDouble(txtResult.Text); 
            
            //Alla operatorer i miniräknaren
            switch (op)
            {
                //Addition
                case "+":
                    txtResult.Text = (enterFirstValue + enterSecondValue).ToString();
                break;

                //Subtraktion
                case "-":
                    txtResult.Text = (enterFirstValue - enterSecondValue).ToString();
                    break;

                //Multiplikation
                case "X":
                    txtResult.Text = (enterFirstValue * enterSecondValue).ToString();
                    break;
                case "*":
                    txtResult.Text = (enterFirstValue * enterSecondValue).ToString();
                    break;

                //Division
                case "/":
                    txtResult.Text = (enterFirstValue / enterSecondValue).ToString();
                    break;
                case "÷":
                    txtResult.Text = (enterFirstValue / enterSecondValue).ToString();
                    break;

                    default:
                    break;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //trycker man på clear kommer 0 fram och alla värden försvinner
            txtResult.Text = "0";
        }

        private void btnRadera_Click(object sender, EventArgs e)
        {
            //om talet är större en noll kommer man att kunna radera siffror en siffra i taget
            if (txtResult.Text.Length > 0)
            {
                txtResult.Text = txtResult.Text.Remove(txtResult.Text.Length -  1, 1);
            }

            //om det inte finns inga fler tal i textboxen kommer en nolla att komma fram
            if (txtResult.Text == "")
            {
                txtResult.Text = "0";
            }
         }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
