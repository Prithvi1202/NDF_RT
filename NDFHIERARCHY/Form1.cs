


using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using NDF;

namespace NDFHIERARCHY
{
   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
    {
        
            try
            {
        
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                
            }
        
    }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
         // PopulateTreeView(string parentid,TreeNode parentNode);
            //PopulateTreeView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 op = new Form2(165356270867, "Physiological Effect Class Hierarchy");
            op.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 op = new Form2(165356241521, "Mechanism Of Action Class Hierarchy");
            op.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 op = new Form2(165356241077, "Pharmacokinetics Class Hierarchy");
            op.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form5 op = new Form5(165356241075, "Chemical Ingredients");
            op.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form5 op = new Form5(165356241079, "Diseases, Manifestations or Physiologic States Class Hierarchy");
            op.Show();
        }


        private void button9_Click(object sender, EventArgs e)
        {
            Form4 op5 = new Form4();
            op5.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form2 op1 = new Form2(165356521968, "Drug Products by VA Class Hierarchy");
            op1.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form5 op5 = new Form5(165356529522, "Drug Products by Generic Ingredient Combinations");

            op5.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form5 op5 = new Form5(165356875690, "External Pharmacologic Classes");
            op5.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form21 f = new Form21();
            f.Show();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            Form2 op1 = new Form2(165356271425, "Dose Form Hierarchy");
            op1.Show();
            	
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 op1 = new Form2(165356878643, "Therapeutic Intent Hierarchy");
            op1.Show();	
        }

        //private void button4_Click(object sender, EventArgs e)
        //{
        //    Form5 op5 = new Form5();

        //    op5.Show();
        //}




        //private void button4_Click(object sender, EventArgs e)
        //{
        //    Form2 op = new Form2(165356241073);
        //    op.Show();
        //}

        
       
}


        }
