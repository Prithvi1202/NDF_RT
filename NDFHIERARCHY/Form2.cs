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


namespace NDFHIERARCHY
{
    public partial class Form2 : Form
    {
        long getValue;
        String conceptGID;
        SqlConnection conn;
        
        TreeNode parentNode = null;
        public Form2(long value, String fname)
        {
            //SqlConnection cnn;
            getValue = value;
            InitializeComponent();
            this.Text = fname;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
            string connectionString = null;
           // SqlConnection cnn;
            connectionString = "Data Source=PRITHVI\\SQLEXPRESS;Initial Catalog=NDFHIERARCHY;Integrated Security=True";
            
            //connectionString = ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;
            conn = new SqlConnection(connectionString);

            String Sequel = "select [NAME string ] , [CONCEPT_GID number ] from [NDFHIERARCHY].[dbo].[DTS_CONCEPT_ARCHIVE] where [CONCEPT_GID number ] in (select distinct [CONCEPT_GID number ] from [NDFHIERARCHY].[dbo].[DTS_DIRECT_SUPS_ARCHIVE] where [SUPERCONCEPT_GID number ] = " + getValue + " )";
            SqlDataAdapter da = new SqlDataAdapter(Sequel, conn);
            DataTable dt = new DataTable();
            conn.Open();
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                parentNode = treeView1.Nodes.Add(dr["NAME string "].ToString());
               PopulateTreeView(Convert.ToInt64(dr["CONCEPT_GID number "].ToString()), parentNode);
            }
           // treeView1.ExpandAll();
        }
        private void PopulateTreeView(long parentId, TreeNode parentNode)
        {



            String Seqchildc = "select [NAME string ], [CONCEPT_GID number ] from [NDFHIERARCHY].[dbo].[DTS_CONCEPT_ARCHIVE] where [CONCEPT_GID number ] in (select distinct [CONCEPT_GID number ] from [NDFHIERARCHY].[dbo].[DTS_DIRECT_SUPS_ARCHIVE] where [SUPERCONCEPT_GID number ] = " + parentId + " ) ";
                SqlDataAdapter dachildmnuc = new SqlDataAdapter(Seqchildc, conn);
                DataTable dtchildc = new DataTable();
                dachildmnuc.Fill(dtchildc);
                TreeNode childNode;
                foreach (DataRow dr in dtchildc.Rows)
                {

                    try
                    {
                        if (parentNode == null)
                        { 
                            childNode = treeView1.Nodes.Add(dr["NAME string "].ToString());
                            conceptGID = (dr["CONCEPT_GID number "].ToString());
                        }
                        else
                        {
                            childNode = parentNode.Nodes.Add(dr["NAME string "].ToString());
                           conceptGID = (dr["CONCEPT_GID number "].ToString());
                        }
                         PopulateTreeView(Convert.ToInt64(dr["CONCEPT_GID number "].ToString()), childNode);
                    }
                    catch (Exception ex)
                    {
                        //  Message("df");

                        ex.ToString();
                        // MessageBox("error occured");
                    }
                
            }
        }



        //private void treeView1_NodeMouseClick(object sender, TreeViewEventArgs e)
        //{
        //    //MessageBox.Show(e.Node.Text);
        //    //conceptGID = e.Node.Text;
        //    Form3 f3 = new Form3(conceptGID);
        //    f3.Show();
        //}

        //private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        //{

        //   // Convert.ToInt64(conceptGID.ToString);
        //    Form3 f3 = new Form3(Convert.ToInt64(conceptGID));
        //    f3.Show();
        //}

        //private void treeView1_AfterSelect_1(object sender, TreeViewEventArgs e)
        //{
        //    Form3 f3 = new Form3(Convert.ToInt64(conceptGID));
        //    f3.Show();
        //}

      
        
    }
}
