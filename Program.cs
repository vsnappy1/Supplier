using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Supplier
{
    //A Class For Checking if id is present in database or not
    class IdPresent
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Supplier\Supplier\Stock_Database.mdf;Integrated Security=True";
        bool present;
        public IdPresent(string name)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            string querycheck = "SELECT * FROM StockTable WHERE[Name]= '" + name + "'";
            conn.Open();
            SqlCommand cmndd = new SqlCommand(querycheck, conn);
            SqlDataReader reader = cmndd.ExecuteReader();
            present = reader.Read();
            conn.Close();
        }
        public bool Idpresent()
        {
            return present;
        }
    }

    //A Class For Adding entities into database
    class Add
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Supplier\Supplier\Stock_Database.mdf;Integrated Security=True";
        bool add;

        double Discount(double number,double percent)
        {
            return (number - ((percent * number) / 100));
        }
        //For Product
        public Add(string name, double TP, int quantity, int discount )
        {
            double finalrate = Discount(TP, discount);

            SqlConnection conn = new SqlConnection(connectionString);
            string query = "INSERT INTO StockTable ([Name], [TP], [Quantity], [Discount], [Final Rate] )" +
                           "VALUES('" + name + "',  '" + TP + "',  '" + quantity + "',  '" + discount + "',  '" + finalrate + "')";
            try
            {
                conn.Open();
                SqlCommand cmnd = new SqlCommand(query, conn);
                cmnd.ExecuteNonQuery();
                add = true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            conn.Close();
        }

        //This Checks if User/Admin/Product Added Or Not and shows message
        public void Check()
        {
            if (add)
                MessageBox.Show("Added", "Info");
            else
                MessageBox.Show("This Id is already taken\nTry different Id", "Error");

        }
    }

    //A Class For Updating entities of database
    class Update
    {
        bool update;
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Supplier\Supplier\Stock_Database.mdf;Integrated Security=True";

        double Discount(double number, double percent)
        {
            return (number - ((percent * number) / 100));
        }
        //For Product
        public Update(string name, double TP, int quantity, int discount)
        {
            double finalrate = Discount(TP, discount);
            SqlConnection conn = new SqlConnection(connectionString);
            string query = "UPDATE StockTable SET [Name]='" + name + "', [TP]='" + TP + "', [Quantity]='" + quantity + "', [Discount]='" + discount + "', [Final Rate]='" + finalrate + "' WHERE[Name]='" + name + "'";
            IdPresent IP = new IdPresent(name);
            if (IP.Idpresent())      //To insure tha entered id exists in data base
            {
                conn.Close();
                try
                {
                    conn.Open();
                    SqlCommand cmnd = new SqlCommand(query, conn);
                    cmnd.ExecuteNonQuery();
                    update = true;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            else
                MessageBox.Show("This Id does not exists");
            conn.Close();
        }

        //This Checks if User/Admin/Product Updated Or Not and shows message
        public void Check()
        {
            if (update)
                MessageBox.Show("Updated", "Info");
        }
    }

    //A Class For Searching entities of database
    class Search
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Supplier\Supplier\Stock_Database.mdf;Integrated Security=True";
        SqlConnection conn;
        bool search;
        SqlDataReader reader;
        public Search(string name)
        {
            conn = new SqlConnection(connectionString);
            string query = "SELECT * FROM  StockTable WHERE[Name]= '" + name + "'";
            conn.Open();
            IdPresent IP = new IdPresent(name);
            if (IP.Idpresent())  //To insure tha entered user id exists in data base
            {
                try
                {
                    SqlCommand cmnd = new SqlCommand(query, conn);
                    reader = cmnd.ExecuteReader();
                    if (reader.Read())
                    {
                        search = true;
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            else
                MessageBox.Show("This Id does not exists");
        }
        public string TP()
        {
            string s = Convert.ToString(reader.GetSqlMoney(1));
            return s;
        }
        public string Quantity()
        {
            string q = Convert.ToString(reader.GetSqlInt32(2));
            return q;
        }
        public string Discount()
        {
            string d = Convert.ToString(reader.GetSqlInt32(3));
            return d;
        }
        public void ComboboxFunction(decimal TP,int Quantity,int Discount)
        {
            TP =(decimal)reader.GetSqlMoney(1);
            Quantity = (Int32)reader.GetSqlInt32(2);
            Discount = (Int32)reader.GetSqlInt32(3);
        }
        //This Checks if User/Admin/Product Searched Or Not and shows message
        public void Check()
        {
            if (search)
            {
                 MessageBox.Show("Name:\t" + reader.GetString(0) + "\n" +
                                 "TP:\t" + reader.GetSqlMoney(1) +"Rs." +"\n" +
                                 "Quantity:\t" + reader.GetSqlInt32(2)+ "\n" +
                                 "Discount:\t" + reader.GetSqlInt32(3) +"%"+ "\n" +
                                 "Final Rate:\t" + reader.GetSqlMoney(4)+ "Rs.", "Result");
               
            }
            conn.Close();

        }
        //This checks if product is present (for Billing)
        public bool Present()
        {
            return search;
        }
    }

    //A Class For Deleting entities of database
    class Delete
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Supplier\Supplier\Stock_Database.mdf;Integrated Security=True";
        bool delete;
        public Delete(string name)
        {

            {
                SqlConnection conn = new SqlConnection(connectionString);
                string query = "DELETE FROM StockTable WHERE[Name]='" + name + "'";
                IdPresent IP = new IdPresent(name);
                if (IP.Idpresent()) //To insure tha entered user id exists in data base
                {
                    DialogResult DR = MessageBox.Show("Are You Sure You Want To Delete", "Warning", MessageBoxButtons.YesNo);
                    if (DR == DialogResult.Yes)
                    {
                        conn.Close();
                        try
                        {
                            conn.Open();
                            SqlCommand cmnd = new SqlCommand(query, conn);
                            cmnd.ExecuteNonQuery();
                            delete = true;
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show(e.Message);
                        }
                        conn.Close();
                    }
                }
                else
                    MessageBox.Show("This Id does not exists");
                conn.Close();
            }
        }
        //This Checks if User/Admin/Product Deleted Or Not and shows message
        public void Check()
        {
            if (delete)
                MessageBox.Show("Deleted", "Info");
        }
    }

    //A Class For ComboBox, Now Items of combo box are a "Name Column" of database
    class Combobox
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Supplier\Supplier\Stock_Database.mdf;Integrated Security=True";
        public Combobox(ComboBox CB)
        {
            string query = "SELECT * FROM StockTable";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmnd = new SqlCommand(query, conn);
            SqlDataReader reader = cmnd.ExecuteReader();
            while (reader.Read())
            {
                string svalues = reader["Name"].ToString();
                CB.Items.Add(svalues);
            }
            // dataGridView1.DataSource = dt;
            conn.Close();
        }

    }

    //A Class That Compute Total Price of available Stock
    class TotalStock
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Supplier\Supplier\Stock_Database.mdf;Integrated Security=True";
        decimal sum = 0;
        public TotalStock()
        {
            string query = "SELECT * FROM StockTable";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmnd = new SqlCommand(query, conn);
            SqlDataReader reader = cmnd.ExecuteReader();
            while (reader.Read())
            {
                sum +=(decimal) reader.GetSqlMoney(4) * (decimal)reader.GetSqlInt32(2);
            }
            // dataGridView1.DataSource = dt;
            conn.Close();
        }
        public decimal Totalstock()
        {
            return sum;
        }
    }

    //This Class Refreshs Table after every action Like Add, Delete and Reset
    class RefreshTable
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Supplier\Supplier\Stock_Database.mdf;Integrated Security=True";
        public RefreshTable(DataGridView grid)
        {
            string query = "SELECT * FROM StockTable";
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
                SqlCommand cmnd = new SqlCommand(query, conn);
                SqlDataAdapter DA = new SqlDataAdapter(cmnd);
                DataTable DT = new DataTable();
                DA.Fill(DT);
                grid.DataSource = DT;
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }
    }

    //This is the Major class responsable for making bills, updating database after bill procced
    class Billingg
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Supplier\Supplier\Stock_Database.mdf;Integrated Security=True";
        double total;
        DataGridView DGV;
        double Discount(double number, double percent)
        {
            return (number - ((percent * number) / 100));
        }

        public Billingg(DataGridView dgv)
        {
            DGV = dgv;
        }

        public void Insert(int Sno,string name, int quantity,int discount)
        {
            try
            {
                string query = "SELECT * FROM StockTable WHERE[Name]='" + name + "'";
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                SqlCommand cmnd = new SqlCommand(query, conn);
                SqlDataReader reader = cmnd.ExecuteReader();
                reader.Read();
                double rate = Discount(reader.GetSqlMoney(1).ToDouble(),discount);
                this.DGV.Rows.Add(Sno, quantity, reader["Name"], reader["TP"], discount, rate, rate * quantity);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Reset()
        {
            DialogResult DR = MessageBox.Show("Are Your Sure", "Warning", MessageBoxButtons.YesNo);
            if (DR == DialogResult.Yes)
            {
                DGV.Rows.Clear();
                DGV.Refresh();
            }
                
        }

        public void Delete()
        {
            foreach(DataGridViewRow Item in DGV.SelectedRows)
            {
                DGV.Rows.RemoveAt(Item.Index);
            }
        }

        public double Total()
        {
            total = 0;
            int rows = DGV.RowCount - 1;
            for (int i = 0; i < rows; i++)
            {
                total += Convert.ToDouble(DGV.Rows[i].Cells[6].Value.ToString());
            }
            return total;
        }

        public void Update()
        {
            SqlConnection conn = new SqlConnection(connectionString);

            for (int i = 0; i < DGV.RowCount - 1; i++)
            {
                 int quantity =(int) DGV.Rows[i].Cells[1].Value;
                 string Name= (string)DGV.Rows[i].Cells[2].Value;
                conn.Open();
                 string query = "SELECT * FROM StockTable WHERE[Name]= '" + Name + "' ";
                 SqlCommand cmnd = new SqlCommand(query, conn);
                 SqlDataReader reader = cmnd.ExecuteReader();
                 reader.Read();
                                                                                               //  reader.GetInt32(2)                                                             
                Update product = new Update(reader.GetString(0), reader.GetSqlMoney(1).ToDouble(), reader.GetInt32(2)-quantity, reader.GetInt32(3));
                 conn.Close();                                                                                                 
            }
        }

        public void PrintBill()
        {

        }
    }

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new mainScreen());
        }
    }
}
