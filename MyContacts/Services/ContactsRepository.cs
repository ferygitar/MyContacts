using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics.Metrics;
using System.Drawing;

namespace MyContacts.Services
{
    internal class ContactsRepository : IContactsRepository
    {
        private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Contact_DB;Integrated Security=True;";
        
        public bool Delete(int contactId)
        {
            SqlConnection connection=new SqlConnection(connectionString);
            try
            {
                string query = "Delete From MyContacts where ContactID=@ID";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@ID", contactId);
                connection.Open();
                cmd.ExecuteNonQuery();
                return true;

            }
            catch (Exception)
            {

                return false;
            }
            finally
            {
                connection.Close();
            }
        }
        public bool Insert(string name, string family, string mobile, string email, int age, string address)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                string query = "Insert Into MyContacts (Name,Family,Mobile,Email,Age,Address) values (@Name,@Family,@Mobile,@Email,@Age,@Address)";
                SqlCommand command=new SqlCommand(query,connection);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Family", family);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Age", age);
                command.Parameters.AddWithValue("@Mobile", mobile);
                command.Parameters.AddWithValue("@Address", address);
                connection.Open();
                command.ExecuteNonQuery();
                
                return true;
            }
            catch
            {

                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        public DataTable SelectAll()
        {
            string query = "Select * From MyContacts";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection); 
            DataTable data=new DataTable();
            adapter.Fill(data); 
            return data;
        }

        public DataTable SelectRow(int contactId)
        {
            string query = "Select * From MyContacts Where ContactID="+contactId;
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }

        public bool Update(int contactId, string name, string family, string mobile, string email, int age, string address)
        {
            throw new NotImplementedException();
        }
    }
}
