using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;


internal class Database
{
    private MySqlConnection connection;
    private string server;
    private string database;
    private string uid;
    private string password;

    //Constructor
    public Database()
    {
        Initialize();
    }

    //Initialize values
    private void Initialize()
    {
        server = "localhost";
        database = "sms5";
        uid = "root";
        password = "";
        string connectionString;
        connectionString = "SERVER=" + server + ";" + "DATABASE=" +
        database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

        connection = new MySqlConnection(connectionString);
    }
    /// <summary>
    /// This methood is for opening connection to the database.
    /// </summary>
    /// <returns></returns>
    //open connection to database
    public bool OpenConnection()
    {
        try
        {
            connection.Open();
            return true;
        }
        catch (Exception)
        {

            MessageBox.Show("Cannot connect to server.  Contact administrator");
            return false;

        }
    }

    /// <summary>
    /// This method is for closing connection to the database.
    /// </summary>
    /// <returns></returns>
    //Close connection
    public bool CloseConnection()
    {
        try
        {
            connection.Close();
            return true;
        }
        catch (MySqlException ex)
        {
            MessageBox.Show(ex.Message);
            return false;
        }
    }

    /// <summary>
    /// This method is used for the admin to log into the system.
    /// </summary>
    /// <param name="name"></param>
    /// <param name="pass"></param>

    public bool AdminCheckIn(string name, string pass)
    {

        string query = $"select * from admin where adminName = '{name}' and adminPassword = '{pass}'";
        //Open connection
        if (this.OpenConnection() == true)
        {
            try
            {
                // Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                if (dataReader.Read())
                {
                    MessageBox.Show("Welcome, admin!", "Successfully logged", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Wrong given information! Please, try again!", "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return value
                return true;

            }
            catch (Exception)
            {
                MessageBox.Show("Wrong given information! Please, try again!", "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        else
        {
            MessageBox.Show("Invalid inputs! Please, try again!", "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

    }
    /// <summary>
    ///  This method is used for the login of cashiers
    /// </summary>
    /// <param name="firsName"></param>
    /// <param name="lastName"></param>
    /// <returns></returns>
    public bool CashierCheckIn(string firsName, string lastName)
    {

        string query = $"select * from cashiers where firstName = '{firsName}' and lastName = '{lastName}'";
        //Open connection
        if (this.OpenConnection() == true)
        {
            try
            {
                // Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                if (dataReader.Read())
                {
                    MessageBox.Show("Welcome, cashier!", "Successfully logged", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Wrong given information! Please, try again!", "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return value
                return true;

            }
            catch (Exception)
            {
                MessageBox.Show("Wrong given information! Please, try again!", "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        else
        {
            MessageBox.Show("Invalid inputs! Please, try again!", "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

    }

    /// <summary>
    /// This method is used for running different queries.
    /// </summary>

    public void RunQuery(string query)
    {

        //Open connection
        if (this.OpenConnection() == true)
        {
            try
            {
                // Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();
                //close Data Reader
                dataReader.Close();
                //close Connection
                this.CloseConnection();
            }
            catch (Exception)
            {
                MessageBox.Show("Could not reach server", "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        else
        {
            MessageBox.Show("Could not reach server", "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }



    public DataTable GetTable(string cmd)
    {
        DataTable table = new DataTable();
        //Open connection
        if (this.OpenConnection() == true)
        {
            try
            {
                // Create Command
                MySqlCommand cmd1 = new MySqlCommand(cmd, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd1.ExecuteReader();

                table.Load(dataReader);

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                return table;

            }
            catch (Exception)
            {
                MessageBox.Show("Could not reach server", "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return table;
            }
        }
        else
        {
            MessageBox.Show("Could not reach server", "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return table;
        }

    }
    public Product Product(int id, int quantity)
    {
        Product returnProduct = new Product();
        string query = $"select * from products where id = {id}";
        //Open connection
        if (this.OpenConnection() == true)
        {
            try
            {
                // Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                if (dataReader.Read())
                {
                    returnProduct.Id = int.Parse(dataReader["id"].ToString());
                    returnProduct.Name = dataReader["name"].ToString();
                    returnProduct.Quantity = quantity;
                    returnProduct.Price = decimal.Parse(dataReader["price"].ToString());
                    returnProduct.DeliveryPrice = decimal.Parse(dataReader["deliveryPrice"].ToString());
                    return returnProduct;
                }
                else
                {
                    MessageBox.Show("Something went wrong! Please, try again!", "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return returnProduct;
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                return returnProduct;
            }
            catch (Exception)
            {
                MessageBox.Show("Could not reach server", "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return returnProduct;
            }
        }
        else
        {
            MessageBox.Show("Could not reach server", "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return returnProduct;
        }

    }


    public Product Product(int id)
    {
        Product returnProduct = new Product();
        string query = $"select * from products where id = {id}";
        //Open connection
        if (this.OpenConnection() == true)
        {
            try
            {
                // Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                if (dataReader.Read())
                {
                    returnProduct.Id = int.Parse(dataReader["id"].ToString());
                    returnProduct.Name = dataReader["name"].ToString();
                    returnProduct.Price = decimal.Parse(dataReader["price"].ToString());
                    returnProduct.DeliveryPrice = decimal.Parse(dataReader["deliveryPrice"].ToString());
                    return returnProduct;
                }
                else
                {
                    MessageBox.Show("Something went wrong! Please, try again!", "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return returnProduct;
                }

                //close Data Reader
                dataReader.Close();

                this.CloseConnection();


                return returnProduct;
            }
            catch (Exception)
            {
                MessageBox.Show("Could not reach server", "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return returnProduct;
            }
        }
        else
        {
            MessageBox.Show("Could not reach server", "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return returnProduct;
        }

    }


    public int GetId1(int count)
    {
        int id = 0;
        string query = $"select id from sales where numberOfProducts = {count} order by time desc limit 1";
        //Open connection
        if (this.OpenConnection() == true)
        {
            try
            {
                // Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                if (dataReader.Read())
                {
                    id = dataReader.GetInt32(0);
                }
                else
                {
                    MessageBox.Show("Something went wrong! Please, try again!", "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                return id;

            }
            catch (Exception)
            {
                MessageBox.Show("Could not reach server", "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
        else
        {
            MessageBox.Show("Could not reach server", "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return 0;
        }
    }

    public int GetId(string query)
    {
        int id = 0;
        string querycmd = query;
        //Open connection
        if (this.OpenConnection() == true)
        {
            try
            {
                // Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                if (dataReader.Read())
                {
                    id = dataReader.GetInt32(0);
                }
                else
                {
                    MessageBox.Show("Something went wrong! Please, try again!", "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                return id;

            }
            catch (Exception)
            {
                MessageBox.Show("Could not reach server", "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
        else
        {
            MessageBox.Show("Could not reach server", "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return 0;
        }
    }
    public string GetString(string query)
    {
        string id = "";
        string querycmd = query;
        //Open connection
        if (this.OpenConnection() == true)
        {
            try
            {
                // Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                id = cmd.ExecuteScalar() as string;
                //close Connection
                this.CloseConnection();

                return id;

            }
            catch (Exception)
            {
                MessageBox.Show("Could not reach server", "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return String.Empty;
            }
        }
        else
        {
            MessageBox.Show("Could not reach server", "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return String.Empty;
        }

    }
}





