using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        double nr1 = 0;
        double nr2 = 0;
        string operatie = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_click(object sender, EventArgs e)
        {
            
        }

        private void numar_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox1.Text += btn.Text;
        }

        private void OperatieClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            nr1 = Convert.ToDouble(textBox1.Text);
           
            operatie = btn.Text;
            textBox1.Text = "";

        }

        private void rezultat(object sender, EventArgs e)
        {
            double rezultat = 0;
            // Verificam daca textul din textBox1 poate fi convertit intr-un nr
            if (Double.TryParse(textBox1.Text, out nr2))
            {
                switch (operatie)
                {
                    case "+":
                        rezultat = nr1 + nr2;
                        break;
                    case "-":
                        rezultat = nr1 - nr2;
                        break;
                    case "*":
                        rezultat = nr1 * nr2;
                        break;
                    case "/":
                        if (nr2 != 0)
                        {
                            rezultat = nr1 / nr2;
                        }
                        else
                        {
                            MessageBox.Show("Nu se poate împărți la zero!");
                            return;
                        }
                        break;
                    case "sqrt":
                       
                        rezultat = Math.Sqrt(nr1+0 ); // am incercat aici sa adun cu 0 
                        break;
               
                }
                textBox1.Text = rezultat.ToString();
            }
            else
            {
                MessageBox.Show("Valoare introdusă nevalidă!");
            }
        }

        private void ClearClick(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void ExitClick(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
