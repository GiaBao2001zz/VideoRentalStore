using ClosedXML.Excel;
using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoRentalStore
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e);
            using (Graphics g = e.Graphics)
            {
                var p = new Pen(Color.White, 1);
                var point1 = new Point(5, 5);
                var point2 = new Point(670, 5);
                g.DrawLine(p, point1, point2);
                g.Dispose();
            }
        }

        private void SelectTop5SoldDisc()
        {
            using (var connection = new SqlConnection(@"Data Source =.\SQLEXPRESS; Initial Catalog = VideoRentalStore; Integrated Security = True"))
            {
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT TOP 5 idVideo, SUM(Quantity) as count FROM Request WHERE Status = 'Completed' GROUP BY idvideo ORDER BY count DESC";
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        var indexOfColumn1 = reader.GetOrdinal("idVideo");
                        var indexOfColumn2 = reader.GetOrdinal("count");

                        while (reader.Read())
                        {
                            var value1 = reader.GetValue(indexOfColumn1);
                            var value2 = reader.GetValue(indexOfColumn2);

                            string idVideo = (string)value1;
                            int count = (int)value2;

                            InsertIntoTopProductSold(idVideo, count);
                        }                 
                    }
                }
            }
        }

        private void InsertIntoTopProductSold(string idVideo, int count)
        {
            SqlConnection con = new SqlConnection(@"Data Source =.\SQLEXPRESS; Initial Catalog = VideoRentalStore; Integrated Security = True");
            string query = "INSERT INTO TopProductSold (idVideo, count) VALUES (@idVideo, @count)";
            SqlCommand cmd = new SqlCommand(query, con);
            
            cmd.Parameters.AddWithValue("@idVideo", idVideo);
            cmd.Parameters.AddWithValue("@count", count);

            con.Open();
            int i = cmd.ExecuteNonQuery();

            con.Close();

        }

        private void Report_Load(object sender, EventArgs e)
        {
            UpdateRanking();
            SelectTop5SoldDisc();
            panel3.AutoScroll = true;
            ShowTop5ProductSold();
            Load_Chart();
            Load_Info();
            Load_Accounts();
            Load_TotalSale();
        }
        //Disable horizontal scrollbar
        const int SB_HORZ = 0;

        [DllImport("user32.dll")]

        static extern bool ShowScrollBar(IntPtr hWnd, int wBar, bool bShow);

        protected override void OnShown(EventArgs e)
        {
            ShowScrollBar(this.panel3.Handle, SB_HORZ, false);
            base.OnShown(e);
        }

        private void UpdateRanking()
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source =.\SQLEXPRESS; Initial Catalog = VideoRentalStore; Integrated Security = True"))
            using (SqlCommand command = connection.CreateCommand())
            {
                command.CommandText = "DELETE FROM TopProductSold";
              
                connection.Open();

                command.ExecuteNonQuery();

                connection.Close();
            }
        }

        private void ShowTop5ProductSold()
        {
            using (var connection = new SqlConnection(@"Data Source =.\SQLEXPRESS; Initial Catalog = VideoRentalStore; Integrated Security = True"))
            {
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT Name, Price, Quantity, count FROM Video INNER JOIN TopProductSold ON Video.id = TopProductSold.idVideo";
                    int count = 0;
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        var indexOfColumn1 = reader.GetOrdinal("Name");
                        var indexOfColumn2 = reader.GetOrdinal("Price");
                        var indexOfColumn3 = reader.GetOrdinal("Quantity");
                        var indexOfColumn4 = reader.GetOrdinal("count");
                        while (reader.Read())
                        {
                            var value1 = reader.GetValue(indexOfColumn1);
                            var value2 = reader.GetValue(indexOfColumn2);
                            var value3 = reader.GetValue(indexOfColumn3);
                            var value4 = reader.GetValue(indexOfColumn4);
                            count++;
                        }
                    }

                    using (var reader = command.ExecuteReader())
                    {
                        var indexOfColumn1 = reader.GetOrdinal("Name");
                        var indexOfColumn2 = reader.GetOrdinal("Price");
                        var indexOfColumn3 = reader.GetOrdinal("Quantity");
                        var indexOfColumn4 = reader.GetOrdinal("count");
                        int x = 0;
                        int y = 0;

                        Label[] ranking = new Label[count];
                        Label[] videoName = new Label[count];
                        Label[] quantity = new Label[count];
                        Label[] sold = new Label[count];
                        Label[] price = new Label[count];
                        Panel[] divider = new Panel[count];

                        int index = 0;

                        while (reader.Read())
                        {
                            var value1 = reader.GetValue(indexOfColumn1);
                            var value2 = reader.GetValue(indexOfColumn2);
                            var value3 = reader.GetValue(indexOfColumn3);
                            var value4 = reader.GetValue(indexOfColumn4);
                            if ((x % 1 == 0) && (index != 0))
                            {
                                y = y + 70; 
                                x = 0;
                            }
                            ranking[index] = new Label();
                            videoName[index] = new Label();
                            quantity[index] = new Label();
                            sold[index] = new Label();
                            price[index] = new Label();


                            ranking[index].Text = (index + 1).ToString();
                            ranking[index].Font = new Font("Segoe UI", 13);
                            ranking[index].Size = new Size(175, 70);
                            ranking[index].ForeColor = Color.White;
                            ranking[index].AutoSize = false;
                            ranking[index].TextAlign = ContentAlignment.TopLeft;
                            ranking[index].AutoSize = false;
                            ranking[index].Location = new Point(x * 250 + 3, y + 10);

                            videoName[index].Text = (string)value1;
                            videoName[index].Font = new Font("Segoe UI", 13);
                            videoName[index].Size = new Size(175, 70);
                            videoName[index].ForeColor = Color.White;
                            videoName[index].AutoSize = false;
                            videoName[index].TextAlign = ContentAlignment.TopLeft;
                            videoName[index].AutoSize = false;
                            videoName[index].Location = new Point(x * 250 + 101, y + 10);

                            quantity[index].Text = value3.ToString();
                            quantity[index].Font = new Font("Segoe UI", 13);
                            quantity[index].Size = new Size(175, 70); //175, 70
                            quantity[index].ForeColor = Color.White;
                            quantity[index].AutoSize = false;
                            quantity[index].TextAlign = ContentAlignment.TopLeft;
                            quantity[index].AutoSize = false;
                            quantity[index].Location = new Point(x * 250 + 301, y + 10);

                            price[index].Text = value2.ToString();
                            price[index].Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", float.Parse(price[index].Text));
                            price[index].Font = new Font("Segoe UI", 13);
                            price[index].Size = new Size(175, 70);
                            price[index].ForeColor = Color.White;
                            price[index].AutoSize = false;
                            price[index].TextAlign = ContentAlignment.TopLeft;
                            price[index].AutoSize = false;
                            price[index].Location = new Point(x * 250 + 592, y + 10);

                            sold[index].Text = value4.ToString();
                            sold[index].Font = new Font("Segoe UI", 13);
                            sold[index].Size = new Size(175, 70); //175, 70
                            sold[index].ForeColor = Color.White;
                            sold[index].AutoSize = false;
                            sold[index].TextAlign = ContentAlignment.TopLeft;
                            sold[index].AutoSize = false;
                            sold[index].Location = new Point(x * 250 + 476, y + 10);
                           
                            panel3.Controls.Add(ranking[index]);
                            panel3.Controls.Add(videoName[index]);
                            panel3.Controls.Add(quantity[index]);
                            panel3.Controls.Add(sold[index]);
                            panel3.Controls.Add(price[index]);
                            
                            ranking[index].BringToFront();
                            quantity[index].BringToFront();
                            sold[index].BringToFront();
                            price[index].BringToFront();
                            videoName[index].BringToFront();

                            if (index < count - 1)
                            {
                                divider[index] = new Panel();
                                divider[index].Location = new Point(x * 250, y + 53);
                                divider[index].Size = new Size(712, 14);
                                divider[index].Paint += new System.Windows.Forms.PaintEventHandler(this.divider_Paint);
                                panel3.Controls.Add(divider[index]);
                                divider[index].BringToFront();
                            }

                            index++;
                            x++;
                        }
                    }
                }
            }
        }

        private void divider_Paint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e);
            using (Graphics g = e.Graphics)
            {
                var p = new Pen(Color.White, 1);
                var point1 = new Point(5, 5);
                var point2 = new Point(670, 5);
                g.DrawLine(p, point1, point2);
                g.Dispose();
            }
        }

      
        

        private void Load_Chart()
        {
            SqlConnection connection = new SqlConnection(@"Data Source =.\SQLEXPRESS; Initial Catalog = VideoRentalStore; Integrated Security = True");

            string query = "select datepart(yyyy, [DateRequest]) as [Year], datepart(mm, [DateRequest]) as [Month] ,SUM(Price) as Value from Request group by datepart(yyyy, [DateRequest]), datepart(mm, [DateRequest])";

            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);

            connection.Close();
           

       
            Chart_Earning.DataSource = dt;
            //set the member of the chart data source used to data bind to the X-values of the series  
            Chart_Earning.Series["2021"].XValueMember = "Month";
            //set the member columns of the chart data source used to data bind to the X-values of the series  
            Chart_Earning.Series["2021"].YValueMembers = "Value";
            Chart_Earning.ChartAreas[0].AxisY.LabelStyle.Format = "{0:0,}K";
            Chart_Earning.ChartAreas[0].AxisX.Title = "Month";
            Chart_Earning.Titles.Add("Earning");
            
            

        }

        private void Load_Info()
        {
            SqlConnection connection = new SqlConnection(@"Data Source =.\SQLEXPRESS; Initial Catalog = VideoRentalStore; Integrated Security = True");

            string query = "select datepart(yyyy, [DateRequest]) as [Year], datepart(mm, [DateRequest]) as [Month] ,SUM(Price) as Value from Request group by datepart(yyyy, [DateRequest]), datepart(mm, [DateRequest])";

            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);

            connection.Close();

            string sMonth = DateTime.Now.ToString("MM");
            int convert = Int32.Parse(sMonth);
            sMonth = convert.ToString();
            int j = 0;
            foreach (DataRow row in dt.Rows)
            {
                if (dt.Rows[j]["Month"].ToString() == sMonth) 
                        {
                        Label_Totalprofit_Number.Text =  string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", float.Parse(dt.Rows[j]["Value"].ToString()));
                        }
                    

                j++;

            }

        }
        private void Load_Accounts()
        {

            SqlConnection connection = new SqlConnection(@"Data Source =.\SQLEXPRESS; Initial Catalog = VideoRentalStore; Integrated Security = True");

            string query = "Select COUNT(Username) as Accounts From Account";

            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);

            connection.Close();

            Label_TotalUsers_Number.Text = dt.Rows[0]["Accounts"].ToString();
        }
        private void Load_TotalSale()
        {

            SqlConnection connection = new SqlConnection(@"Data Source =.\SQLEXPRESS; Initial Catalog = VideoRentalStore; Integrated Security = True");

            string query = "Select SUM(Quantity) as Sale from Request where Status = 'Completed'";

            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);

            connection.Close();
            Label_TotalSales_Number.Text = dt.Rows[0]["Sale"].ToString();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source =.\SQLEXPRESS; Initial Catalog = VideoRentalStore; Integrated Security = True");

            string query = "SELECT Request.id AS 'ID', Account.DisplayName AS 'Customer Name' , Request.idVideo AS 'Video ID', Video.Name AS 'Video Name', Request.Price, Request.Quantity, Request.DateDelivered AS 'Transaction date', Request.Type  FROM Request INNER JOIN Video ON Request.idVideo = Video.id INNER JOIN Account On Request.userName = Account.Username Where Request.Status = 'Completed'";

            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);

            connection.Close();

            using (SaveFileDialog openFileDialog = new SaveFileDialog() { Filter = "Excel WorkBook | *.xlsx" })
            {

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (XLWorkbook wb = new XLWorkbook())
                        {
                            wb.Worksheets.Add(dt, "Sale Report");
                            wb.SaveAs(openFileDialog.FileName);
                        }
                        MessageBox.Show("Print Sale report successfully!! ");
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    
                }
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
