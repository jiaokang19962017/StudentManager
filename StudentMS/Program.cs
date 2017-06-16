using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using System.Data;
using System.Data.SqlClient;
namespace StudentMS
{
    class Program
    {
        static void Main(string[] args)
        {
          // DataSet ds =   SqlHelper.ExecuteDataSet(CommandType.Text, "select* from students", null);
          string strsql1= "insert into department(deptname) values('众阳')";
            string strsql2 = "insert into department(deptname) values('众阳')";

            try
            {
                SqlHelper.BeginTransaction();
                SqlHelper.ExecuteTransaction(CommandType.Text, strsql1);
                SqlHelper.ExecuteTransaction(CommandType.Text, strsql2);
                SqlHelper.CommitTransaction();

            }
            catch (Exception ex)
            {
                SqlHelper.RollBackTransaction();
                Console.WriteLine(ex.Message);
                throw;
            }



            Console.ReadKey();
        }
    }
}
