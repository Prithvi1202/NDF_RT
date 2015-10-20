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
    public partial class Form22 : Form
    {
        String values;
      
        public Form22(String fname)
        {
           
            InitializeComponent();
            values = fname;
        }

        private void Form22_Load(object sender, EventArgs e)
        {
            //String[] RoleGIDList = values.trim().split("\\s*,\\s*");
            String [] results = values.Split(',');
            if (results.Length == 1)
            {
                Form6 f6 = new Form6(Convert.ToInt64(results[0]));
                f6.Show();
            }
            else if (results.Length == 2)
            {
                Form8 f8 = new Form8(Convert.ToInt64(results[0]), Convert.ToInt64(results[1]));
                f8.Show();
            }

            else if (results.Length == 3)
            {
                Form7 f7 = new Form7(Convert.ToInt64(results[0]), Convert.ToInt64(results[1]), Convert.ToInt64(results[2]));
                f7.Show();
            }


            else if (results.Length == 4)
            {
                Form9 f9 = new Form9(Convert.ToInt64(results[0]), Convert.ToInt64(results[1]), Convert.ToInt64(results[2]), Convert.ToInt64(results[3]));
                f9.Show();
            }
            else if (results.Length == 5)
            {
                Form10 f10 = new Form10(Convert.ToInt64(results[0]), Convert.ToInt64(results[1]), Convert.ToInt64(results[2]), Convert.ToInt64(results[3]), Convert.ToInt64(results[4]));
                f10.Show();
            }

           else if(results.Length == 6)
           {
               Form12 f12 = new Form12(Convert.ToInt64(results[0]), Convert.ToInt64(results[1]), Convert.ToInt64(results[2]), Convert.ToInt64(results[3]), Convert.ToInt64(results[4]), Convert.ToInt64(results[5]));
               f12.Show();
            }
           else if (results.Length == 7)
           {
               Form13 f13 = new Form13(Convert.ToInt64(results[0]), Convert.ToInt64(results[1]), Convert.ToInt64(results[2]), Convert.ToInt64(results[3]), Convert.ToInt64(results[4]), Convert.ToInt64(results[5]), Convert.ToInt64(results[6]));
               f13.Show();
           }
           
           
            //ArrayList<String> RoleGID = Arrays.asList(values.split(","));
        }
    }
}
