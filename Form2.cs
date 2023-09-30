using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace cucaho
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
                if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))

                    if (e.KeyChar == (char)(Keys.Enter))
                    {
                        SendKeys.Send("{TAB}");

                        {
                            MessageBox.Show("Ingrese solo numeros y letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            e.Handled = true;
                            return;
                        }


                    }

        }

        private void Contratxt_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
                if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))


                {
                    MessageBox.Show("Ingrese solo numeros y letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    e.Handled = true;
                    return;
                }

            Contratxt.Text = new string('*', Contratxt.Text.Length);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }

}


