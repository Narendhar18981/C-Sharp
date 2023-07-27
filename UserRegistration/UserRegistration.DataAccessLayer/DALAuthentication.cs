using UserRegistration.BusinessModel;
using System.Data.SqlClient;
using System;
using System.Configuration;

namespace UserRegistration.DataAccessLayer
{
    internal class DALAuthentication : IData
    {
        /// <summary>
        /// VAlidates users credentials
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public string Login(User user)
        {
            string constr = ConfigurationManager.ConnectionStrings["DataBase"].ConnectionString;
            try
            {
                using (SqlConnection conn = new SqlConnection(constr))
                {
                    string query = "SELECT name FROM SampleApplication WHERE UserId=@UserName AND Password=@Password";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserName", user.UserName);
                        cmd.Parameters.AddWithValue("@Password", user.Password);

                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                return StringLiterals.loginSuccess;
                            }
                        }
                    }
                }
            }
            catch (SqlException)
            {
                return StringLiterals.sqlException;
                
            }
            catch (InvalidOperationException)
            {
                return StringLiterals.inValidOperationException;
            }
            catch (Exception)
            {
                return StringLiterals.unExpectedException;
            }

            return StringLiterals.loginUnSuccess;
        }




        /// <summary>
        /// Check wheather the username present in the database ,if not present it insert into the database
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public string Register(User user)
        {
            string constr = ConfigurationManager.ConnectionStrings["DataBase"].ConnectionString;

            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    string query = "SELECT EmailId FROM SampleApplication WHERE UserId=@UserName;";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@UserName", user.UserName);

                        using (SqlDataReader rdr = cmd.ExecuteReader())
                        {
                            if (rdr.HasRows)
                            {
                                // Username already exists, return true to indicate registration failure.
                                return StringLiterals.userExist;
                            }
                        }
                    }

                    // If the control reaches this point, the username does not exist, so proceed with registration.
                    query = "INSERT INTO SampleApplication (EmailID, Name, UserId, Password) VALUES (@EmailID, @Name, @UserName, @Password);";
                    using (SqlCommand cmmd = new SqlCommand(query, con))
                    {
                        cmmd.Parameters.AddWithValue("@EmailID", user.EmailID);
                        cmmd.Parameters.AddWithValue("@Name", user.Name);
                        cmmd.Parameters.AddWithValue("@UserName", user.UserName);
                        cmmd.Parameters.AddWithValue("@Password", user.Password);

                        cmmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException)
            {
                return StringLiterals.sqlException;
            }
            catch (InvalidOperationException)
            {
                return StringLiterals.inValidOperationException;
            }
            catch (Exception)
            {
                return StringLiterals.unExpectedException;
            }

            return StringLiterals.successfull;
        }

        /// <summary>
        /// Method used to Update the password
        /// </summary>
        /// <param name="user"></param>
        public string UpdatePassword(User user)
        {
            string constr = ConfigurationManager.ConnectionStrings["DataBase"].ConnectionString;

            try
            {
                using (SqlConnection conn = new SqlConnection(constr))
                {
                    conn.Open();
                    string query = "SELECT * FROM SampleApplication WHERE UserId=@UserName AND EmailId=@EmailID;";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserName", user.UserName);
                        cmd.Parameters.AddWithValue("@EmailID", user.EmailID);

                        using (SqlDataReader rdr = cmd.ExecuteReader())
                        {
                            if (rdr.Read())
                            {
                                rdr.Close();
                                query = "UPDATE SampleApplication SET Password=@Password WHERE UserId=@UserName;";
                                using (SqlCommand cmmd = new SqlCommand(query, conn))
                                {
                                    cmmd.Parameters.AddWithValue("@Password", user.Password);
                                    cmmd.Parameters.AddWithValue("@UserName", user.UserName);

                                    cmmd.ExecuteNonQuery();
                                }
                                return StringLiterals.successfullyUpdated;
                            }
                        }
                    }
                }
            }
            catch (SqlException)
            {
                return StringLiterals.sqlException;
            }
            catch (InvalidOperationException)
            {
                return StringLiterals.inValidOperationException;
            }
            catch (Exception)
            {
                return StringLiterals.unExpectedException;
            }

            return StringLiterals.emailUserNameMisMatch;
        }

    }
}
