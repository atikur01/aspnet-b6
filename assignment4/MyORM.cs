using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace assignment4
{
    public class MyORM<T> where T : class
    {
        private string str = $"Server=.\\SQLEXPRESS;Database=Sample;User Id=atik;Password=12345";
        public void Insert(T item)
        {
            var keyValues =  Program.GetKeyValues(item);

            var colNames = "";
            var colvalues = "";

            int i = 1;

            foreach (var x in keyValues)
            {
                colNames += "[" + x.Key + "]" ;     
                if (i < keyValues.Count)
                {
                    colNames += ", ";
                }
                i++;
            }

            i = 1;

            foreach (var x in keyValues)
            {
                colvalues += "' " + x.Value + " '";
                if (i < keyValues.Count)
                {
                    colvalues += ", ";
                }
                i++;
            }

            var fullCommand = @"insert into students (" + colNames + ") values( "+ colvalues + " )";

            SqlConnection conn = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand(fullCommand, conn);

            if (cmd.Connection.State != System.Data.ConnectionState.Open)
                cmd.Connection.Open();

            cmd.ExecuteNonQuery();
            conn.Close();

        }

        public void Update(T item)
        {
            var keyValues = Program.GetKeyValues(item);

            var setStr = "";

            int i = 1;

            foreach (var x in keyValues)
            {
                setStr += "[" + x.Key + "]" + "="+ "'" + keyValues[x.Key] + "'" ;
                if (i < keyValues.Count)
                {
                    setStr += ", ";
                }
                i++;
            }

          var fullCommand = @"UPDATE students SET "+setStr+ " WHERE [id] =  '"+keyValues["id"]+"'";

            SqlConnection conn = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand(fullCommand, conn);

            if (cmd.Connection.State != System.Data.ConnectionState.Open)
                cmd.Connection.Open();

            cmd.ExecuteNonQuery();
            conn.Close();

        }

        public void Delete(T item)
        {
            var keyValues = Program.GetKeyValues(item);

            var fullCommand = @"DELETE FROM students WHERE [ID] = '" +keyValues["id"] + "'";

            SqlConnection conn = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand(fullCommand, conn);

            if (cmd.Connection.State != System.Data.ConnectionState.Open)
                cmd.Connection.Open();

            cmd.ExecuteNonQuery();
            conn.Close();

        }

        public void Delete(int id)
        {
            var fullCommand = @"DELETE FROM students WHERE [ID] = '" + id + "'";

            SqlConnection conn = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand(fullCommand, conn);

            if (cmd.Connection.State != System.Data.ConnectionState.Open)
                cmd.Connection.Open();

            cmd.ExecuteNonQuery();
            conn.Close();

        }

        public List<IDictionary<string, object>> GetById(int id)
        {
            SqlConnection conn = new SqlConnection(str);
            SqlCommand command = new SqlCommand("Select * from students WHERE id = '"+id+"' ", conn);

            if (command.Connection.State != System.Data.ConnectionState.Open)
                command.Connection.Open();

            using SqlDataReader reader = command.ExecuteReader();

            List<IDictionary<string, object>> data = new List<IDictionary<string, object>>();

            while (reader.Read())
            {
                Dictionary<string, object> row = new Dictionary<string, object>();
                foreach (var col in reader.GetColumnSchema())
                {
                    row.Add(col.ColumnName, reader[col.ColumnName]);
                }
                data.Add(row);
            }
            conn.Close();

            return data;
        }


        public List<IDictionary<string, object>> GetAll()
        {
            SqlConnection conn = new SqlConnection(str);
            SqlCommand command = new SqlCommand("Select * from students ORDER BY ID",conn);
         
            if (command.Connection.State != System.Data.ConnectionState.Open)
                command.Connection.Open();

            using SqlDataReader reader = command.ExecuteReader();

            List<IDictionary<string, object>> data = new List<IDictionary<string, object>>();

            while (reader.Read())
            {
                Dictionary<string, object> row = new Dictionary<string, object>();
                foreach (var col in reader.GetColumnSchema())
                {
                    row.Add(col.ColumnName, reader[col.ColumnName]);
                }
                data.Add(row);
            }
            conn.Close();

            return data;
        }

    }
}
