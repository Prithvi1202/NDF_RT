using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using NDFHIERARCHY;
namespace NDF
{
    public partial class Form4 : Form
    {

     



        //Fine f = new Fine();
        //System.Windows.Forms.TextBox="";


        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

       

       
        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form7 f7 = new Form7(165356240925, 165356240976, 165356240978);
            f7.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form7 f7 = new Form7(165356240917, 165356240976, 165356240979);
            f7.Show();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6(165356240976);
            f6.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8(165356240925, 165356240978);
            f8.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9(165356240917, 165356240925, 165356240978, 165356240979);
            f9.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form10 f10 = new Form10(165356240917, 165356240925, 165356240978, 165356240979, 165356240976);
            f10.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8(165356240917, 165356240979);
            f8.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form10 f10 = new Form10(165356240931, 165356240935, 165356240977, 165356240980, 165356240981);
            f10.Show();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7(165356240931, 165356240977, 165356240980);
            f7.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form12 f12 = new Form12(165356240931, 165356240935, 165356240976, 165356240977, 165356240980, 165356240981);
            f12.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form13 f13 = new Form13(165356240925, 165356240931, 165356240935, 165356240976, 165356240978, 165356240980, 165356240981);
            f13.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form12 f12 = new Form12(165356240925, 165356240931, 165356240935, 165356240978, 165356240980, 165356240981);
            f12.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form13 f13 = new Form13(165356240925, 165356240931, 165356240935, 165356240977, 165356240978, 165356240980, 165356240981);
            f13.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7(165356240925, 165356240977, 165356240978);
            f7.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {

            Form10 f10 = new Form10(165356240917,165356240925,165356240937,165356240978,165356240979);
            f10.Show();

        }

        private void button15_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9(165356240931 ,165356240976 ,165356240977 ,165356240980);
            f9.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Form10 f10 = new Form10(165356240917 , 165356240931 ,165356240977, 165356240979, 165356240980);
            f10.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Form12 f12 = new Form12(165356240917, 165356240931, 165356240976, 165356240977, 165356240980, 165356240979);
            f12.Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6(165356240925);
            f6.Show();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9(165356240925, 165356240976, 165356240977, 165356240978);
            f9.Show();
        }

        private void button20_Click(object sender, EventArgs e)
        {

            Form7 f7 = new Form7(165356240939, 165356240977, 165356240982);
            f7.Show();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Form12 f12 = new Form12(165356240917, 165356240931, 165356240925, 165356240978, 165356240980, 165356240979);
            f12.Show();
        }

        //private void button22_Click(object sender, EventArgs e)
        //{
        //    Form8 f8 = new Form8(165356240978, 165356240988);
        //    f8.Show();
        //}

        private void button22_Click_1(object sender, EventArgs e)
        {
            Form13 f13 = new Form13(165356240917, 165356240931, 165356240935, 165356240977, 165356240979, 165356240980, 165356240981);
            f13.Show(); 
        }

        private void button23_Click(object sender, EventArgs e)
        {

            Form8 f8 = new Form8(165356240978, 165356240988);
            f8.Show();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Form10 f10 = new Form10(165356240917, 165356240939, 165356240976, 165356240979, 165356240982);
            f10.Show();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6(165356240978);
            f6.Show();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7(165356240977, 165356240980, 165356240981);
            f7.Show();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6(165356240979);
            f6.Show();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8(165356240978, 165356240976);
            f8.Show();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9(165356240977, 165356240978, 165356240980, 165356240981);
            f9.Show();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            Form10 f10 = new Form10(165356240976, 165356240977, 165356240978, 165356240980, 165356240981);
            f10.Show();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9(165356240977, 165356240976, 165356240980, 165356240981);
            f9.Show();
        }

        private void button27_Click_1(object sender, EventArgs e)
        {
            Form6 f6 = new Form6(165356240979);
            f6.Show();
        }

      
    }
}
