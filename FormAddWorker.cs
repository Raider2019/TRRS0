using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPKR01
{
    public partial class FormAddWorker : Form
    {
        public FormAddWorker()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FormAddWorker_Load(object sender, EventArgs e)
        {
            
            
                textBox1.Text = "";
                textBox2.Text = "";
                comboBox1.SelectedIndex = 1;
                textBox1.Focus(); // при відкритті вікна, textBox1 отримує фокус
            
        }
    }
}
