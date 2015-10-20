using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NDFHIERARCHY
{
    public partial class Form3 : Form
    {
        long getValue;
        String conceptGID;
        SqlConnection conn;
        
        TreeNode parentNode = null;
        public Form3(long value)
        {
            //SqlConnection cnn;
            getValue = value;
            InitializeComponent();
        }

        private void PopulateTreeViewRole(long parentId, TreeNode parentNode)
        {



            String Seqchildc = "select DISTINCT [ROLE_GID number ] from [NDFHIERARCHY].[dbo].[DTS_COMPLETE_ROLE_CON_ARCHIVE] where [CONCEPT_GID number ] IN (SELECT [CONCEPT_GID number ] FROM  [NDFHIERARCHY].[dbo].[DTS_CONCEPT_ARCHIVE] WHERE [CONCEPT_GID number ] = " + parentId + " )";
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
                        childNode = treeView1.Nodes.Add(dr["ROLE_GID number "].ToString());
                        conceptGID = (dr["ROLE_GID number "].ToString());
                    }
                    else
                    {
                        childNode = parentNode.Nodes.Add(dr["ROLE_GID number "].ToString());
                        conceptGID = (dr["ROLE_GID number "].ToString());
                    }
                    // PopulateTreeView(Convert.ToInt64(dr["CONCEPT_GID number "].ToString()), childNode);
                }
                catch (Exception ex)
                {
                    //  Message("df");

                    ex.ToString();
                    // MessageBox("error occured");
                }

            }
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
                        childNode = treeView1.Nodes.Add(dr["CONCEPT_GID number "].ToString());
                        conceptGID = (dr["CONCEPT_GID number "].ToString());
                    }
                    else
                    {
                        childNode = parentNode.Nodes.Add(dr["CONCEPT_GID number "].ToString());
                        conceptGID = (dr["CONCEPT_GID number "].ToString());
                    }
                  PopulateTreeViewRole(Convert.ToInt64(dr["CONCEPT_GID number "].ToString()), childNode);
                }
                catch (Exception ex)
                {
                    //  Message("df");

                    ex.ToString();
                    // MessageBox("error occured");
                }

            }
    }

        private void Form3_Load_1(object sender, EventArgs e)
        {
             string connectionString = null;
           // SqlConnection cnn;
            connectionString = "Data Source=PRITHVI\\SQLEXPRESS;Initial Catalog=NDFHIERARCHY;Integrated Security=True";
            
            //connectionString = ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;
            conn = new SqlConnection(connectionString);

            String Sequel = "select distinct [CONCEPT_GID number ] from [NDFHIERARCHY].[dbo].[DTS_CONCEPT_ARCHIVE] where [CONCEPT_GID number ] in (select distinct [CONCEPT_GID number ] from [NDFHIERARCHY].[dbo].[DTS_DIRECT_SUPS_ARCHIVE] where [SUPERCONCEPT_GID number ] = " + getValue + " )";
            SqlDataAdapter da = new SqlDataAdapter(Sequel, conn);
            DataTable dt = new DataTable();
            conn.Open();
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                parentNode = treeView1.Nodes.Add(dr["CONCEPT_GID number "].ToString());
              
              PopulateTreeView(Convert.ToInt64(dr["CONCEPT_GID number "].ToString()), parentNode);
            }
           // treeView1.ExpandAll();
        }
        }

       
}
    