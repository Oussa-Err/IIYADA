using System.Data;
using System.Data.SqlClient;


namespace gestionCabinie
{
    public class DatabaseConnection
    {
        public static SqlConnection connection = new SqlConnection("Data Source=MAGIQUE;Initial Catalog=Cabinie;Integrated Security=True;TrustServerCertificate=True");


        //public SqlConnection GetConn()
        //{
        //    if (connection.State == ConnectionState.Closed)
        //    {
        //        connection.Open();
        //    }
        //    return connection;
        //}


        //function ExecNonQuery to perform CRUD ops 
        //public int ExecNonQuery(SqlCommand command)
        //{
        //    command.Connection = GetConn();
        //    int rowsAffected = -1;
        //    rowsAffected = command.ExecuteNonQuery();
        //    connection.Close();
        //    return rowsAffected;
        //}

        //function ExecScalar to retrieve single value from db or query
        //public object ExecScalar(SqlCommand command)
        //{
        //    command.Connection = DatabaseConnection.connection;
        //    connection.Open();
        //    object obj = -1;
            
        //    //obj = command.ExecuteScalar();
        //    //connection.Close();
        //    return obj;
        //}

        ////function ExecReader to perform Select query
        //public SqlDataReader ExecReader(SqlCommand command)
        //{
        //    command.Connection = GetConn();
        //    SqlDataReader reader = command.ExecuteReader();
        //    DataTable dt = new DataTable();
        //    dt.Load(reader);
        //    connection.Close();
        //    return reader;

        //    //command.Connection = GetConn();
        //    ////connection.Close();
        //    //return command.ExecuteReader();

        //    //command.Connection = GetConn();
        //    //SqlDataReader reader = command.ExecuteReader();
        //    //DataTable dt = new();
        //    //dt.Load(reader);
        //    //conn.Close();
        //    //return dt;

        //    //SqlDataReader reader = command.ExecuteReader();
        //    //dt.Load(reader);
        //}
        //public DataTable excut(string command)
        //{

        //    DataTable dt = new DataTable();
        //    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command, DatabaseConnection.connection);
        //    sqlDataAdapter.Fill(dt);
        //    return dt;
        //}


    }
    
}
