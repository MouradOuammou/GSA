﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet
{
     class Functions
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataAdapter sda;
        private DataTable dt;
        private string constr;
        public Functions()
        {
           // constr = @"Data Source=DESKTOP-V96D7TN;Initial Catalog=GestionDR;Integrated Security=True";
            constr = @"Data Source=PCHP;Initial Catalog=GestionDR;Integrated Security=True";
            con = new SqlConnection(constr);
            cmd = new SqlCommand();
            cmd.Connection = con;

        }
        public DataTable GetData(string Query)
        {
            dt = new DataTable();
            sda = new SqlDataAdapter(Query, constr);
            sda.Fill(dt);
            return dt;

        }
        public int SetData(String Query)
        {
            int cnt = 0;
            if (con.State == ConnectionState.Closed)
            {
                con.Open();

            }
            cmd.CommandText = Query;
            cnt = cmd.ExecuteNonQuery();
            con.Close();
            return cnt;
        }
    }
}
