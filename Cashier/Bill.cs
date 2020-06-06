using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Threading;

namespace Cashier
{
    public partial class Bill : UserControl
    {
        int count;
        Double netTotal = 0;
        public String serverPassword = "";
        public String serverName = "localhost";
        public String serveruser = "root";
        String max;
        public Bill()
        {
            InitializeComponent();
        }

        private void bunifuCards1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Bill_Load(object sender, EventArgs e)
        {
            String id=getNextTreatmentNo();
            loadItems();
            txtOrderNo.Text = (int.Parse(id) + 1).ToString();
            
        }

        public String getNextTreatmentNo()
        {
            MySqlDataReader rd;
            string sMonth = DateTime.Now.ToString("MM");
            MySqlConnection conn;
            string connetionString = null;
            connetionString = "server='" + serverName + "';database=restauretdb ;uid='" + serveruser + "';pwd='" + serverPassword + "';";
            conn = new MySqlConnection(connetionString);
            String query;


            query = "SELECT MAX(id) FROM orders_tb; ";

            try
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand(query, conn);
                max = command.ExecuteScalar().ToString();

                conn.Close();



            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return max;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadSizes(comboBox1.SelectedItem.ToString());
        }

        public void loadItems()
        {
            MySqlDataReader rd;

            MySqlConnection conn;
            string connetionString = null;
            connetionString = "server='" + serverName + "';database= restauretdb;uid='" + serveruser + "';pwd='" + serverPassword + "';";
            conn = new MySqlConnection(connetionString);
            String query;


            query = "SELECT * FROM  restauretdb.itemlist_tb ";
            try
            {
                comboBox1.Items.Clear();
                conn.Open();
                MySqlCommand command = new MySqlCommand(query, conn);
                rd = command.ExecuteReader();
                //comboBox1.Items.Clear();
                while (rd.Read())
                {
                    comboBox1.Items.Add(rd.GetString("itemCode"));

                    //Console.WriteLine(rd.GetString("sname"));
                }
                //comboBox1.SelectedIndex = 0;

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void loadSizes(String item_code)
        {
            MySqlDataReader rd;

            MySqlConnection conn;
            string connetionString = null;
            connetionString = "server='" + serverName + "';database= restauretdb;uid='" + serveruser + "';pwd='" + serverPassword + "';";
            conn = new MySqlConnection(connetionString);
            String query;


            query = "SELECT * FROM  restauretdb.itemlist_tb where itemCode = '"+ item_code + "' ";
            try
            {
                comboBox2.Items.Clear();
                conn.Open();
                MySqlCommand command = new MySqlCommand(query, conn);
                rd = command.ExecuteReader();
                //comboBox1.Items.Clear();
                while (rd.Read())
                {
                    comboBox2.Items.Add(rd.GetString("size"));
                    txtItemName.Text = rd.GetString("itemName");

                    //Console.WriteLine(rd.GetString("sname"));
                }
                //comboBox1.SelectedIndex = 0;

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void loadPrice(String size)
        {
            MySqlDataReader rd;

            MySqlConnection conn;
            string connetionString = null;
            connetionString = "server='" + serverName + "';database= restauretdb;uid='" + serveruser + "';pwd='" + serverPassword + "';";
            conn = new MySqlConnection(connetionString);
            String query;


            query = "SELECT * FROM  restauretdb.itemlist_tb where size = '" + size + "' ";
            try
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand(query, conn);
                rd = command.ExecuteReader();
                //comboBox1.Items.Clear();
                while (rd.Read())
                {
                    txtEachPrice.Text = rd.GetString("price");

                    //Console.WriteLine(rd.GetString("sname"));
                }
                //comboBox1.SelectedIndex = 0;

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadPrice(comboBox2.SelectedItem.ToString());
        }

        private void txtQty_OnValueChanged(object sender, EventArgs e)
        {
            txtTotal.Text = (Double.Parse(txtQty.Text) * Double.Parse(txtEachPrice.Text)).ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            String order_no = txtOrderNo.Text;
            String item_code = comboBox1.SelectedItem.ToString();
            String item_name = txtItemName.Text;
            String size = comboBox2.SelectedItem.ToString();
            String each_price = txtEachPrice.Text;
            String total = txtTotal.Text;
            String qty = txtQty.Text;

            this.netTotal = netTotal + Double.Parse(total);
            Console.WriteLine(netTotal);
            lblTotal.Text = netTotal.ToString();
       



            dataGridView1.Columns.Add("asd", "order_no");
            dataGridView1.Columns.Add("asd", "item_code");
            dataGridView1.Columns.Add("asd", "item_name");
            dataGridView1.Columns.Add("asd", "size");
            dataGridView1.Columns.Add("asd", "each_price");
            dataGridView1.Columns.Add("asd", "qty");
            dataGridView1.Columns.Add("asd", "qty");
            dataGridView1.Columns[0].Width = 160;
            dataGridView1.Columns[1].Width = 160;
            dataGridView1.Columns[2].Width = 160;
            dataGridView1.Columns[3].Width = 160;
            dataGridView1.Columns[4].Width = 160;
            dataGridView1.Columns[5].Width = 160;
            dataGridView1.Columns[6].Width = 160;


            string[] row = { order_no, item_code, item_name, size, each_price, qty, total };
            count = billItem(order_no, item_code, item_name, size, each_price, qty, total);
            if (count == 1)
            {
                dataGridView1.Rows.Add(row);
            }
        }

        public int billItem(String order_no, String item_code, String item_name, String size, String each_price, String qty, String total)
        {
            String date = DateTime.Now.ToString();
            MySqlDataReader rd;
            int x = 0;
            MySqlConnection conn;
            string connetionString = null;
            connetionString = "server=localhost;database=restauretdb;uid=root;pwd=;";
            conn = new MySqlConnection(connetionString);
            String query;
            query = "insert into restauretdb.orders_tb ( orderNo,itemCode, size, qty, eachPrice, total, date) values" +
                " ('" + order_no + "','" + item_code + "','" + size + "','" + qty + "','" + each_price + "','" + total + "','" + date + "')";

            MySqlCommand command = new MySqlCommand(query, conn);

            try
            {
                conn.Open();
                rd = command.ExecuteReader();
                x = x + 1;
                conn.Close();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                conn.Dispose();
            }
            return x;

        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            lblTotal.Text = "dsadsad";
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
