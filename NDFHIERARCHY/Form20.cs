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
    public partial class Form20 : Form
    {
        SqlConnection cnn;
        string myValue;
        public Form20(String value)
        {
            myValue = value;
            InitializeComponent();
            this.Text = "Drug Details";
        }

        private void Form20_Load(object sender, EventArgs e)
        {
            string connetionString = null;

            connetionString = "Data Source=PRITHVI\\SQLEXPRESS;Initial Catalog=NDFHIERARCHY;Integrated Security=True";
            cnn = new SqlConnection(connetionString);

            // SqlConnection cn = new SqlConnection(ConfigurationSettings.AppSettings["WindowsFormsApplication1.Properties.Settings.DvsDBConnectionString"]);

            //   cnn.open();
            try
            {
                // FOR DRUG NAME
                cnn.Open();
                SqlCommand cmd = new SqlCommand();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT [CONCEPT_GID number ] , [VALUE_U string ]  FROM [NDFHIERARCHY].[dbo].[DTS_CONCEPT_ARCHIVE] where [CONCEPT_GID number ] = " + myValue, cnn);
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                sda.Fill(dt);
                
                dataGridView1.DataSource = dt;

                
                //FOR Description

                SqlDataAdapter dar = new SqlDataAdapter("select  distinct b.[VALUE_CONCEPT_GID number ] ,  a.[NAME string] from [NDFHIERARCHY].[dbo].[DTS_ROLE_TYPE_ARCHIVE] a ,  [NDFHIERARCHY].[dbo].[DTS_COMPLETE_ROLE_CON_ARCHIVE] b  , [NDFHIERARCHY].[dbo].[DTS_CONCEPT_ARCHIVE] c where c.[CONCEPT_GID number ] = b.[CONCEPT_GID number ] and b.[ROLE_GID number ] = a.[TYPE_GID number ] and c.[CONCEPT_GID number ] = " + myValue, cnn);
                DataSet dsr = new DataSet();
                DataTable dtr = new DataTable();
                dar.Fill(dtr);

                dataGridView2.DataSource = dtr;

                // for Dieases /****** Script for SelectTopNRows command from SSMS  ******/
                /*
SELECT[CONCEPT_GID number ] ,[NAME string ] FROM [NDFHIERARCHY].[dbo].[DTS_CONCEPT_ARCHIVE] where   [CONCEPT_GID number ] in (SELECT distinct [VALUE_CONCEPT_GID number ] FROM [NDFHIERARCHY].[dbo].[DTS_DEFINING_ROLE_ARCHIVE] where [CONCEPT_GID number ] = '165356255321') */

                //SqlDataAdapter dar1 = new SqlDataAdapter("SELECT [NAME string ] FROM [NDFHIERARCHY].[dbo].[DTS_CONCEPT_ARCHIVE] where   [CONCEPT_GID number ] in (SELECT distinct [VALUE_CONCEPT_GID number ] FROM [NDFHIERARCHY].[dbo].[DTS_DEFINING_ROLE_ARCHIVE] where [ROLE_IID number ] = " + myValue + ") ", cnn);
                //DataSet dsr1 = new DataSet();
                //DataTable dtr1 = new DataTable();
                //dar1.Fill(dtr1);

                //dataGridView3.DataSource = dtr1;
                //cnn.Close();

            }
            catch (Exception ex)
            {
                ex.ToString();
            }
 
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            myValue = dataGridView2[e.ColumnIndex, e.RowIndex].Value.ToString();

            SqlDataAdapter dar1 = new SqlDataAdapter("SELECT distinct [NAME string ] FROM [NDFHIERARCHY].[dbo].[DTS_CONCEPT_ARCHIVE] where   [CONCEPT_GID number ] = " + myValue , cnn);
            DataSet dsr1 = new DataSet();
            DataTable dtr1 = new DataTable();
            dar1.Fill(dtr1);

            dataGridView3.DataSource = dtr1;
            cnn.Close();
        }
    }
}
