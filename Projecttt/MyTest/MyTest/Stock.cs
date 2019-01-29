using System;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTest
{
    class Stock
    {

        // instance variables
        private int stock_No;
        private string description;
        private decimal cost_price;
        private decimal sale_price;
        private int qty;
        private string status;

        //no argument constructors

        public Stock()
        {
            stock_No = 0;
            description = "";
            cost_price = 0;
            sale_price = 0;
            qty = 0;
            status = "";
        }

        public static DataSet getAllStock(DataSet DS)
        {
            //Create an oracleConnection object using the connection string defined
            OracleConnection comn = new OracleConnection(DBConnect.oradb);

            //Define the SQL query to retrieve the data
            String strSQL = "SELECT * FROM Stock";

            //Create an oracleCommand object and instantiate it
            OracleCommand cmd = new OracleCommand(strSQL, comn);

            //Create an oracleAdapter to hold the result of the executed OracleConnection
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            //Fill the DataSet DS with the query result
            da.Fill(DS, "stk");

            //close the DB connection
            comn.Close();

            //return the dataset with the required data to the windows form which
            return DS;
        }

    }
}
