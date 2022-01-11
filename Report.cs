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

        private void Update_Chart(DataTable dt)
        {
            
            foreach (DataRow row in dt.Rows)
            {
                
            }

        }
        public class Earning
        {
            public int Year { get; set; }
            public int Month { get; set; }

            public int Value { get; set; }
        }

        private void ComboBox_ChartType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Chart_Earning.Series.Clear();
            if (ComboBox_ChartType.Text == "This Year")
            {
                Chart_Earning.AxisX.Add(new LiveCharts.Wpf.Axis
                {
                    Title = "Month",
                    Labels = new[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "July", "Aug", "Sep", "Oct", "Nov", "Dec" }
                }
                    );
                Chart_Earning.AxisY.Add(new LiveCharts.Wpf.Axis
                {

                    LabelFormatter = value => value.ToString("C")
                });
                Chart_Earning.LegendLocation = LiveCharts.LegendLocation.Right;

            }
            SqlConnection connection = new SqlConnection(@"Data Source =.\SQLEXPRESS; Initial Catalog = VideoRentalStore; Integrated Security = True");

            string query = "Select DateRequest, Price from Request";

            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
     
            connection.Close();

            DataTable source = new DataTable();
            
            source.Columns.Add("Year", typeof(int)); // dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Month", typeof(int));
            dt.Columns.Add("Value", typeof(float));
            int i = 0;
            foreach (DataRow row in dt.Rows)
            {

                source.Rows[i]["Year"] =  dt.Rows[i].Field<DateTime>("DateRequest").Year;
                source.Rows[i]["Month"] = dt.Rows[i].Field<DateTime>("DateRequest").Month;
                
                i++;
            }
            SeriesCollection series = new SeriesCollection(); 
            Earning_Source.DataSource = new List<Earning>();
            Earning_Source.DataSource = dt;

            var years = (from o in Earning_Source.DataSource as List<Earning>
                         select new { Year = o.Year }).Distinct();
            foreach(var year in years)
            {
                List<double> values = new List<double>();
                for (int month = 1; month <= 12; month++)
                {
                    double value = 0;
                    var data = from o in Earning_Source.DataSource as List<Earning>
                               where o.Year.Equals(year.Year) && o.Month.Equals(month)
                               orderby o.Month ascending
                               select new { o.Value, o.Month };
                    if (data.SingleOrDefault() != null)
                    {
                        value = data.SingleOrDefault().Value;
                        values.Add(value);
                    }
                    series.Add(new LineSeries() { Title = year.Year.ToString(), Values = new ChartValues<double>(values) });
                }
                Chart_Earning.Series = series;

            }


        }
    }
}
