using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace WebApplication1
{
   
    public class db
    {
        static SqlConnection con = null;
        static SqlCommand cmd = null;
        public static int getAppid()
        {
            int c = 0;
            try
            {
                con = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlCon"].ToString());
                con.Open();
                cmd = new SqlCommand("select max(ApplicationId) from Populationcensus",con);
                //if (cmd.ExecuteScalar() != null)
                //    c = (int)cmd.ExecuteScalar();
                string S = cmd.ExecuteScalar().ToString();
                if (S == "")
                    c++;
                else
                    c = int.Parse(S) + 1;
                        }
            catch(SqlException e)
            {
                
            }
            finally
           {
                con.Close();
            }
            return c;
        }
        public string SaveMembers(List<Population1>L)
        {
            string n = null;
            try
            {
                con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["SqlCon"].ToString());
                con.Open();
                cmd = new SqlCommand("pcensus3",con);
                cmd.CommandType = CommandType.StoredProcedure;
                DataTable Db = new DataTable();
                Db.Columns.Add("ApplicationId", typeof(Int32));
                Db.Columns.Add("MemberID", typeof(Int32));
                Db.Columns.Add("Firstname", typeof(string));
                Db.Columns.Add("Middlename", typeof(string));
                Db.Columns.Add("Lastname", typeof(string));
                Db.Columns.Add("Suffix", typeof(string));
                Db.Columns.Add("DOB", typeof(DateTime));
                Db.Columns.Add("Gender", typeof(string));
                
                for(int i=0;i<L.Count;i++)
                {
                    Db.Rows.Add(L[i].ApplicationId, L[i].MemberID, L[i].Firstname, L[i].Middlename, L[i].Lastname, L[i].Suffix, L[i].DOB, L[i].Gender);

                }
                SqlParameter p = new SqlParameter("@pc",Db);
                    p.SqlDbType = SqlDbType.Structured;
                cmd.Parameters.Add(p);
                cmd.ExecuteNonQuery();
              
                n= "Application submitted with" + L.Count + "Member details.Your ApplicationId" + L[0].ApplicationId;
            }
            catch(SqlException E)
            {

            }
            finally
            {
                con.Close();
            }
            return n;
        }
    }
}