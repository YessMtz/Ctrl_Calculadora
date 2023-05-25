using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_Calculadora
{
    public partial class PlantillaCalculadora : UserControl
    {
        public PlantillaCalculadora()
        {
            InitializeComponent();
        }

        double cifra, cifra2, ans;
        int indice;


        //boton para borrar pantalla
        private void clear_Click(object sender, EventArgs e)
        {
            Pantalla.Clear();
        } 
        
        //tecla para borrar caracter por caracter
        private void backspace_Click(object sender, EventArgs e)
        {
            if (Pantalla.TextLength == 1)
            {
                Pantalla.Text = " ";
            }
            else Pantalla.Text = Pantalla.Text.Substring(0, Pantalla.Text.Length -1);
        }

        //boton para sumar
        private void suma_Click(object sender, EventArgs e)
        {
            indice = 1;
            cifra = double.Parse(Pantalla.Text);
            Pantalla.Clear();
        }

        //boton para restar
        private void resta_Click(object sender, EventArgs e)
        {
            indice = 2;
            cifra = double.Parse(Pantalla.Text);
            Pantalla.Clear();
        }
        
        //boton para multiplicar
        private void multipicar_Click(object sender, EventArgs e)
        {
            indice = 3;
            cifra = double.Parse(Pantalla.Text);
            Pantalla.Clear();

        }

        //botn para dividir
        private void division_Click(object sender, EventArgs e)
        {
            indice = 4;
            cifra = double.Parse(Pantalla.Text);
            Pantalla.Clear();
        }

        //boton para porcentaje
        private void porcentaje_Click(object sender, EventArgs e)
        {
            
        }
        
        //decimal
        private void punto_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + ".";
        }

        //cero
        private void b0_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "0";
        }

        //uno
        private void b1_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "1";
        }

        //dos
        private void b2_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "2";
        }

        //tres
        private void b3_Click(object sender, EventArgs e)
        {
        Pantalla.Text = Pantalla.Text + "3";
        }
        
        //cuatro
        private void b4_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "4";
        }

        //cinco
        private void b5_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "5";
        }

        //seis
        private void b6_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "6";
        }

        //siete
        private void b7_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "7";
        }

        //ocho
        private void b8_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "8";
        }

        //nueve
        private void b9_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "9";
        }

        //boton raiz
        private void button8_Click(object sender, EventArgs e)
        {
            indice = 5;
            cifra = double.Parse(Pantalla.Text);
        }

        //boton resultado
        private void resultado_Click(object sender, EventArgs e)
        {
            //cifra 2 
            cifra2 = double.Parse(Pantalla.Text);
            switch (indice)
            {
                //suma
                case 1:
                    ans = cifra + cifra2;
                    Pantalla.Text = ans.ToString();
                    break;

                //resta
                case 2:
                    ans = cifra - cifra2;
                    Pantalla.Text = ans.ToString();
                    break;

                //multiplicacion
                case 3:
                    ans = cifra * cifra2;
                    Pantalla.Text = ans.ToString();
                    break;
                
                //division
                case 4:
                    ans = cifra / cifra2;
                    Pantalla.Text = ans.ToString();
                    break;

                //raiz
                case 5:
                    ans = Math.Sqrt(cifra);
                    break;

                default:
                    MessageBox.Show("SYNTAX ERROR");

                    break;



            }
        }




        


    }
}
