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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "accountDataSet1.Account". При необходимости она может быть перемещена или удалена.
            this.accountTableAdapter.Fill(this.accountDataSet1.Account);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "accountDataSet.Account". При необходимости она может быть перемещена или удалена.
            this.accountTableAdapter.Fill(this.accountDataSet.Account);
            // TODO: This line of code loads data into the 'accountDataSet.Worker' table. You can move, or remove it, as needed.
            this.workerTableAdapter.Fill(this.accountDataSet.Worker);
        }

     
    }
}
