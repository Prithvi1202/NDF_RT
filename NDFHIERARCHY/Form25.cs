﻿using System;
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
    public partial class Form25 : Form
    {
        SqlConnection cnn;
        long val1, val2, val3, val4, val5, val6, val7, val8, val9, val10;
        string myValue;
        public Form25(long value1, long value2, long value3, long value4, long value5, long value6, long value7, long value8, long value9, long value10)
        {
            val1 = value1;
            val2 = value2;
            val3 = value3;
            val4 = value4;
            val5 = value5;
            val6 = value6;
            val7 = value7;
            val8 = value8;
            val9 = value9;
            val10 = value10;
            InitializeComponent();
        }
        private void Form25_Load(object sender, EventArgs e)
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
                SqlDataAdapter sda = new SqlDataAdapter("SELECT distinct a.[CONCEPT_GID number ] , a.[NAME string ] FROM [NDFHIERARCHY].[dbo].[DTS_CONCEPT_ARCHIVE] a where a.[CONCEPT_GID number ] in ( SELECT b.[CONCEPT_GID number ] from [NDFHIERARCHY].[dbo].[DTS_COMPLETE_ROLE_CON_ARCHIVE] b join [NDFHIERARCHY].[dbo].[DTS_ROLE_TYPE_ARCHIVE] c ON  a.[CONCEPT_GID number ] = b.[CONCEPT_GID number ]  and b.[ROLE_GID number ] = c.[TYPE_GID number ] WHERE c.[TYPE_GID number ] in ( " + val1 + ", " + val2 + " , " + val3 + ", " + val4 + " , " + val5 + "," + val6 + "," + val7 + ", " + val8 + ", " + val9 + ", " + val10 + ") GROUP BY b.[CONCEPT_GID number ] HAVING COUNT(DISTINCT  c.[TYPE_GID number ] ) = 2 )", cnn);
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                sda.Fill(dt);

                dataGridView1.DataSource = dt;
                //FOR ROLE TYPE

                SqlDataAdapter dar = new SqlDataAdapter("SELECT distinct [TYPE_GID number ],[NAME string ] FROM [NDFHIERARCHY].[dbo].[DTS_ROLE_TYPE_ARCHIVE] WHERE [TYPE_GID number ] IN (" + val1 + ", " + val2 + " , " + val3 + ", " + val4 + " , " + val5 + "," + val6 + "," + val7 + ", " + val8 + ", " + val9 + ", " + val10 + ")", cnn);
                DataSet dsr = new DataSet();
                DataTable dtr = new DataTable();
                dar.Fill(dtr);

                dataGridView2.DataSource = dtr;
                cnn.Close();

            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }



        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            myValue = dataGridView1[e.ColumnIndex, e.RowIndex].Value.ToString();
            Form20 f = new Form20(myValue); //you pass it to Form2
            f.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            myValue = dataGridView1[e.ColumnIndex, e.RowIndex].Value.ToString();
            Form20 f = new Form20(myValue); //you pass it to Form2
            f.Show();
        }

    }
}

