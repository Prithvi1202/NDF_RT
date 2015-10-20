using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NDFHIERARCHY
{
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6(165356240976);
            f6.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form7 f7 = new Form7(165356240925, 165356240976, 165356240978);
            f7.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7(165356240917, 165356240976, 165356240979);
            f7.Show();
        }
    }
}
