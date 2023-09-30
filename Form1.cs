using System.Linq.Expressions;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace cucaho
{
    public partial class Form1 : Form
    {
        private int a = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void INGRESARBUT_Click(object sender, EventArgs e)
        {
            int a = Cucahosdata.Rows.Add();
            Cucahosdata.Rows[a].Cells[0].Value = Marcatxt.Text;
            Cucahosdata.Rows[a].Cells[1].Value = Modelotxt.Text;
            Cucahosdata.Rows[a].Cells[2].Value = Preciotxt.Text;
            Cucahosdata.Rows[a].Cells[3].Value = Stocktxt.Text;

            Marcatxt.Clear();
            Modelotxt.Clear();
            Preciotxt.Clear();
            Stocktxt.Clear();

        }

        private void ELIMINARBUT_Click(object sender, EventArgs e)
        {
            if (a != -1)
            {
                Cucahosdata.Rows.RemoveAt(a);
            }
        }

        private void BUSCARBUT_Click(object sender, EventArgs e)
        {
            string searchValue = buscartxt.Text;
            Cucahosdata.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                bool valueResult = false;
                foreach (DataGridViewRow row in Cucahosdata.Rows)
                {
                    for (int i = 0; i < row.Cells.Count; i++) ;
                    {
                        if (row.Cells[a].Value != null && row.Cells[a].Value.ToString().Equals(searchValue))
                        {
                            int rowIndex = row.Index;
                            Cucahosdata.Rows[rowIndex].Selected = true;
                            valueResult = true;
                            break;
                        }
                    }
                }
;
                if (!valueResult)
                {
                    MessageBox.Show("Dato no encontrado " + buscartxt.Text, "Validar ingreso");

                    return;
                }
            }

            catch (Exception exc)

            {
                MessageBox.Show(exc.Message);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cucahosdata.Sort(Cucahosdata.Columns[2], ListSortDirection.Ascending);
        }

        private void Descebut_Click(object sender, EventArgs e)
        {
            Cucahosdata.Sort(Cucahosdata.Columns[2], ListSortDirection.Descending);
        }

        private void EDITARBUT_Click(object sender, EventArgs e)
        {
            Cucahosdata[0, a].Value = Marcatxt.Text;
            Cucahosdata[1, a].Value = Modelotxt.Text;
            Cucahosdata[2, a].Value = Preciotxt.Text;
            Cucahosdata[3, a].Value = Stocktxt.Text;
        }

        private void Cucahosdata_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            a = Cucahosdata.CurrentRow.Index;

            Marcatxt.Text = Cucahosdata[0, a].Value.ToString();
            Modelotxt.Text = Cucahosdata[1, a].Value.ToString();
            Preciotxt.Text = Cucahosdata[2, a].Value.ToString();
            Stocktxt.Text = Cucahosdata[3, a].Value.ToString();
        }

        private void Marcatxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Marcatxt_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Modelotxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Preciotxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
                if (e.KeyChar == (char)(Keys.Enter))

                {
                    SendKeys.Send("{TAB}");
                    {
                        MessageBox.Show("Ingrese solo numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        e.Handled = true;
                        return;
                    }
                }
        }

        private void Modelotxt_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Stocktxt_KeyPress(object sender, KeyPressEventArgs e)
        {
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

        private void buscartxt_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
