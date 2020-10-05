using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CricketGame
{
    public class ParallelProgramming
    {
        private ArrayList rowList = new ArrayList();
        public IEnumerable GetDataFromDB()
        {
            SqlDataReader rdr = null;
            SqlConnection con = null;
            SqlCommand cmd = null;
           
            try
            {
                string ConnectionString = "Server=VDL75\\SQLEXPRESS; Database=AdventureWorks2017;Trusted_Connection=True;";
                con = new SqlConnection(ConnectionString);
                con.Open();

                string CommandText = " SELECT [Description]" +
                " FROM " +
                "[AdventureWorks2017].[Production].[ProductDescription]";

                cmd = new SqlCommand(CommandText);
                cmd.Connection = con;

                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    object[] values = new object[rdr.FieldCount];
                    rdr.GetValues(values);
                    rowList.Add(values); 
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException);
            }

            return rowList.ToArray();
        }

        public void InsertIntoDBValues(IEnumerable productDesc)
        {
            SqlConnection con = null;  

            try
            {
                string ConnectionString = "Server=VDL75\\SQLEXPRESS; Database=AdventureWorks2017;Trusted_Connection=True;";
                con = new SqlConnection(ConnectionString);
                con.Open();

               // IEnumerable result = (from productDes in productDesc select productDes).
                      
                foreach(string name in productDesc)
                {

                }

                //for (int i=0; i > productDesc; i++)
                //{
                //  //  string enu =(string)productDesc[i];

                //    SqlCommand cmdInsert = new SqlCommand("Insert into [AdventureWorks2017].[Production].[ProductDescription_Temp]  values( ' " + productDesc + "' )", con);

                //    cmdInsert.CommandType = CommandType.Text;
                //    cmdInsert.ExecuteNonQuery();
                //}
            }

            catch(Exception ex)
            {
                Console.WriteLine("Exception",ex.InnerException);
            }
           
        }
    }
}
