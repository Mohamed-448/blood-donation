using blood_donation.BLL;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace blood_donation.DAL
{
    class userDAL
    {
        //Create a Static String to Connect Database
        static string myconnsrtng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        #region SELECT data from database
        public DataTable Select()
        {
            //Create on Object to connect database
            SqlConnection conn = new SqlConnection(myconnsrtng);

            //Create on DataTable to hold the Data from Database
            DataTable dt = new DataTable();

            try
            {
                //Writte SQL Qery to Get Data from Database
                String sql = "SELECT * FROM tbl_users";

                //Creat SQL Command to Execute Query
                SqlCommand cmd = new SqlCommand(sql, conn);

                //create sql Data Adapter to hold the data from database temporarily
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //Open Database Connection
                conn.Open();

                //Tranfer Data from SqlData Adapter to DataTable
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                //Display Error Message if there's any exceptional errors
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Close Database Connection 
                conn.Close();
            }

            return dt;
        }
        #endregion

        #region Insert Data into Database for User Moudle
        public bool Insert(userBLL u)
        {
            //Create a boolean variable and set its default value to false
            bool isSuccess = false;

            //Create Object of sqlConnection to connect Database
            SqlConnection conn = new SqlConnection(myconnsrtng);

            try
            {
                //Create a string variable to store the INSERT Query
                string sql = "INSERT INTO tbl_users(username, email, password, full_name, contact, address, added_date, image_name) values (@username, @email, @password, @full_name, @contact, @address, @added_date, @image_name)";

                //Create a SQL Command to pass the value in our query
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Create the parameter to pass get the value from UI and pass it on SQL Query above
                cmd.Parameters.AddWithValue("@username", u.username);
                cmd.Parameters.AddWithValue("@email", u.email);
                cmd.Parameters.AddWithValue("@password", u.password);
                cmd.Parameters.AddWithValue("@full_name", u.full_name);
                cmd.Parameters.AddWithValue("@contact", u.contact);
                cmd.Parameters.AddWithValue("@addrss", u.address);
                cmd.Parameters.AddWithValue("@added_date", u.added_date);
                cmd.Parameters.AddWithValue("@image_name", u.image_name);

                //Open Database Connection
                conn.Open();

                //Create an Integer VAriable to hold the value after the query is executed
                int rows = cmd.ExecuteNonQuery();

                //The value of rows will be greater than 0 if th query is executed successfully
                //Else it,ll be 0

                if (rows > 0)
                {
                    //Query Executed Successfully
                    isSuccess = true;
                }
                else
                {
                    //FAiled to Execute Qurey
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                //Display Error Message if thete's any exceptional errors
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Close Database Connection
                conn.Close();
            }

            return isSuccess;
        }
        #endregion

        #region UPDATE data in database (User Module)
        public bool Update(userBLL u)
        {
            //Create a boolean variable and set its defaulet value to false
            bool isSuccess = false;

            //Create on Onject for Dataabase Connection
            SqlConnection conn = new SqlConnection(myconnsrtng);

            try
            {
                //Create a string variable to hold the sql query
                string sql = "UPDATE tbl_useres SET username=@username, email=@email, password=@password, full_name=@full_name, contact=@contact, address=@address, added_data=@added_data, image_name=@image_name WHERE user_id=@user_id";

                //Create a SQL Command to pass the value in our query
                SqlCommand cmd = new SqlCommand(sql, conn);

                //How pass the values to SQL Query
                cmd.Parameters.AddWithValue("@username", u.username);
                cmd.Parameters.AddWithValue("@email", u.email);
                cmd.Parameters.AddWithValue("@password", u.password);
                cmd.Parameters.AddWithValue("@full_name", u.full_name);
                cmd.Parameters.AddWithValue("@contact", u.contact);
                cmd.Parameters.AddWithValue("@addrss", u.address);
                cmd.Parameters.AddWithValue("@added_date", u.added_date);
                cmd.Parameters.AddWithValue("@image_name", u.image_name);
                cmd.Parameters.AddWithValue("@user_id", u.user_id);

                //open Database Connection
                conn.Open();

                //Create an iteger variable to hold the value after the query is executed
                int rows = cmd.ExecuteNonQuery();

                //If the query is executed Successfullyy than the value of rows will be greater than 0
                //else it'll be 0

                if (rows > 0)
                {
                    //Query Executed Successfully
                    isSuccess = true;

                }
                else
                {
                    //Failed to Execute Query
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                //Display Error Message if thete's any exceptional errors
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Close Database Connection
                conn.Close();
            }

            return isSuccess;
        }
        #endregion

        #region Delete Data from Database (User Moudle)
        public bool Delete(userBLL u)
        {
            //Create a boolean variable and set its default value to false
            bool isSuccess = false;

            //Create on Onject for Dataabase Connection
            SqlConnection conn = new SqlConnection(myconnsrtng);

            try
            {
                //Create a string variable to hold the sql query to delete data
                string sql = "DELETE FROM tbl_users WHERE user_id=@user_id";

                //Create a SQL Command to pass the value in our query
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Pass the value thorugh parameters
                cmd.Parameters.AddWithValue("@user_id", u.user_id);

                //Open the DAtabase Connection
                conn.Open();

                //Create an iteger variable to hold the value after the query is executed
                int rows = cmd.ExecuteNonQuery();

                //If the query is executed Successfullyy than the value of rows will be greater than zero(0)
                //else it'll be zero(0)

                if (rows > 0)
                {
                    //Query Executed Successfully
                    isSuccess = true;
                }
                else
                {
                    //Failed to Execute Query
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                //Display Error Message if thete's any exceptional errors
                MessageBox.Show(ex.Message);
            }
            finally
            {

                //Close Database Connection
                conn.Close();
            }

            return isSuccess;
        }
        #endregion
       
        #region SEARCH
        public DataTable Search(string keywords)
        {
            //1. Create on SQL Connection to Connect database
            SqlConnection conn = new SqlConnection(myconnsrtng);

            //2. Create Data Taple to Hold the data from database temporarily
            DataTable dt = new DataTable();

            //Write the Code to SEarch the Users
            try
            {
                //Write the SQL Query to SEarch the User from Database
                string sql = "SELECT * FROM tbl_users WHERE user_id LIKE '%" + keywords + "%' OR full_name LIKE '%" + "%' OR address LIKE'%" + keywords + "%'";

                //Create SQL Command to Execute the Query
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Create SQL DAta Adaptor to Get the Data from Database
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //open Database Connection
                conn.Open();
                //Pass the data from adaptor to database
                adapter.Fill(dt);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Close the DAtabase Connection
                conn.Close();
            }

            return dt;
        }

        #endregion
    }
}
