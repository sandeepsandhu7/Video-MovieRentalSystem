using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Video_MovieRentalSystem
{
    public class DatabaseQueries
    {
        private string ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["RentedMoviesConnection"].ToString();
        private SqlConnection connection=null;
        private SqlCommand command;
        private SqlDataAdapter adapter;


        public DatabaseQueries()
        {
            connection = new SqlConnection(ConnectionString);
        }
        public bool CheckConnection()
        {
            bool Result = false;
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
            Result = true;
            connection.Close();
            return Result;
        }

        public void addnewcustomer(string firstname, string lastname, string address, string phoneno)
        {
            string Query = "INSERT INTO [Customer] VALUES (@FirstName, @LastName, @Address, @Phone)";
            command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@FirstName", firstname);
            command.Parameters.AddWithValue("@LastName", lastname);
            command.Parameters.AddWithValue("@Address", address);
            command.Parameters.AddWithValue("@Phone", phoneno);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }


        public void editcustomer(string firstname, string lastname, string address, string phoneno, string customerid)
        {
            string Query = "UPDATE [Customer] SET [FirstName] = @FirstName, [LastName] = @LastName, [Address] = @Address, [Phone] = @Phone WHERE [CustID] = @CustID";
            command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@FirstName", firstname);
            command.Parameters.AddWithValue("@LastName", lastname);
            command.Parameters.AddWithValue("@Address", address);
            command.Parameters.AddWithValue("@Phone", phoneno);
            command.Parameters.AddWithValue("@CustID", customerid);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void deletecustomer(string customerid)
        {
            string Query = "DELETE FROM [Customer] WHERE [CustID] = @CustID";
            command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@CustID", customerid);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public DataTable findallcustomers()
        {
            string Query = "SELECT * FROM [Customer]";
            command = new SqlCommand(Query, connection);
            DataTable table = new DataTable();
            adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            return table;
        }

        public DataTable findcustomerbyid(string customerid)
        {
            string Query = "SELECT * FROM [Customer] WHERE [CustID] = @CustID";
            command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@CustID", customerid);
            DataTable table = new DataTable();
            adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            return table;
        }

        public DataTable findbestcsutomers()
        {
            string Query = "SELECT *, ISNULL((SELECT COUNT(RMID) FROM RentedMovie WHERE CustIDFK = CustID), 0) AS RentedMovie FROM Customer ORDER BY RentedMovie DESC";
            command = new SqlCommand(Query, connection);
            DataTable table = new DataTable();
            adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            return table;
        }

        public void addnewmovie(string rating, string title, string year, string rentalcost, string copies, string plot, string genre)
        {
            string Query = "INSERT INTO [Movies] VALUES (@Rating, @Title, @Year, @Rental_Cost, @Copies, @Plot, @Genre)";
            command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@Rating", rating);
            command.Parameters.AddWithValue("@Title", title);
            command.Parameters.AddWithValue("@Year", year);
            command.Parameters.AddWithValue("@Rental_Cost", rentalcost);
            command.Parameters.AddWithValue("@Copies", copies);
            command.Parameters.AddWithValue("@Plot", plot);
            command.Parameters.AddWithValue("@Genre", genre);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void editmovie(string rating, string title, string year, string rentalcost, string copies, string plot, string genre, string movieid)
        {
            string Query = "UPDATE [Movies] SET [Rating] = @Rating, [Title] = @Title, [Year] = @Year, [Rental_Cost] = @Rental_Cost, [Copies] = @Copies, [Plot] =  @Plot, [Genre] = @Genre WHERE [MovieID] = @MovieID";
            command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@Rating", rating);
            command.Parameters.AddWithValue("@Title", title);
            command.Parameters.AddWithValue("@Year", year);
            command.Parameters.AddWithValue("@Rental_Cost", rentalcost);
            command.Parameters.AddWithValue("@Copies", copies);
            command.Parameters.AddWithValue("@Plot", plot);
            command.Parameters.AddWithValue("@Genre", genre);
            command.Parameters.AddWithValue("@MovieID", movieid);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void deletemovie(string movieid)
        {
            string Query = "DELETE FROM [Movies] WHERE [MovieID] = @MovieID";
            command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@MovieID", movieid);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public DataTable findallmovies()
        {
            string Query = "SELECT * FROM [Movies]";
            command = new SqlCommand(Query, connection);
            DataTable table = new DataTable();
            adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            return table;
        }

        public DataTable findmoviebyid(string movieid)
        {
            string Query = "SELECT * FROM [Movies] WHERE [MovieID] = @MovieID";
            command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@MovieID", movieid);
            DataTable table = new DataTable();
            adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            return table;
        }

        public DataTable getbestsellingmovies()
        {
            string Query = "SELECT *, ISNULL((SELECT COUNT (RMID) FROM RentedMovie WHERE MovieIDFK = MovieID), 0) AS TimesRented FROM Movies ORDER BY TimesRented DESC";
            command = new SqlCommand(Query, connection);
            DataTable table = new DataTable();
            adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            return table;
        }

        public void addrentalrecord(int movieid, int customerid, Nullable<System.DateTime> rentaldate)
        {
            string Query = "INSERT INTO [RentedMovie] (MovieIDFK, CustIDFK, DateRented) VALUES (@MovieIDFK, @CustIDFK, @DateRented)";
            command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@MovieIDFK", movieid);
            command.Parameters.AddWithValue("@CustIDFK", customerid);
            command.Parameters.AddWithValue("@DateRented", rentaldate);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void updatereturnrecord(Nullable<System.DateTime> returndate, string rmid)
        {
            string Query = "UPDATE [RentedMovie] SET [DateReturned] = @DateReturned WHERE [RMID] = @RMID";
            command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@DateReturned", returndate);
            command.Parameters.AddWithValue("@RMID", rmid);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public int getavailablecopies(int movieid)
        {
            string Query = "SELECT (SELECT Copies FROM Movies WHERE MovieID = @MovieID) - (SELECT ISNULL(COUNT(MovieIDFK), 0) FROM RentedMovie WHERE MovieIDFK = @MovieID AND DateReturned IS NULL)";
            command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@MovieID", movieid);
            DataTable table = new DataTable();
            adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            return Convert.ToInt32(table.Rows[0][0]);
        }

        public DataTable getpendingrentals()
        {
            string Query = "SELECT RMID, Customer.FirstName, Customer.LastName, Customer.[Address], Movies.Title, Movies.Rental_Cost, RentedMovie.DateRented, RentedMovie.DateReturned FROM RentedMovie INNER JOIN Movies ON RentedMovie.MovieIDFK = Movies.MovieID INNER JOIN Customer ON RentedMovie.CustIDFK = Customer.CustID WHERE RentedMovie.DateReturned IS NULL";
            command = new SqlCommand(Query, connection);
            DataTable table = new DataTable();
            adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            return table;
        }

    }
}
