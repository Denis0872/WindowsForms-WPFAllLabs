using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsLab3Task3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void INN_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                Label lbl = new Label();
                lbl.Location = new System.Drawing.Point(16, 96);
                lbl.Size = new System.Drawing.Size(42, 23);

                lbl.Name = "labelll";
                lbl.TabIndex = 2;
                lbl.Text = "City";
                groupBox1.Controls.Add(lbl);
                TextBox txt = new TextBox();
                txt.Location = new System.Drawing.Point(16, 96);
                txt.Size = new System.Drawing.Size(284, 20);
                txt.Name = "textboxx";
                txt.TabIndex = 1;
                txt.Text = "             Ваш город: ";
                groupBox1.Controls.Add(txt);
                txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkBox1_KeyPress);
            }
            else
            {
                int lcv;
                lcv = groupBox1.Controls.Count;// определяется количество элементов
                while (lcv > 3)
                {
                    groupBox1.Controls.RemoveAt(lcv - 1);
                    lcv -= 1;
                }
            }

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Поле IIN не может содержать буквы");
                errorProvider1.SetError(textBox1, "Напиши цифру, тормоз");
            }
        }

        private void checkBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

                MessageBox.Show("Поле Name не может содержать цифры");
                errorProvider1.SetError(checkBox1, "Напиши букву, тормоз");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormOut fo = new FormOut();
        
         
        }
    }
}
