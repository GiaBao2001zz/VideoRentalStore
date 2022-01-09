using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Z.Dapper.Plus;

namespace VideoRentalStore
{
    public partial class Import_Disk_WithFile : Form
    {
        public Import_Disk_WithFile()
        {
            InitializeComponent();
        }

        private void Label_FileName_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox_Sheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataGridView_Import.Visible = true;
            DataTable dt = TableCollection[ComboBox_Sheet.SelectedItem.ToString()];
            DataGridView_Import.DataSource = dt;

            DataGridView_Import.Columns[0].HeaderText = "ID";
            DataGridView_Import.Columns[1].HeaderText = "Name";
            DataGridView_Import.Columns[2].HeaderText = "Price";
            DataGridView_Import.Columns[3].HeaderText = "Quantity";
            
            if (dt!= null)
            {
                List<Video> videos = new List<Video>();
                 for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Video video = new Video();
                    video.id = dt.Rows[i]["id"].ToString();
                    video.Name = dt.Rows[i]["Name"].ToString();
                    video.Price = float.Parse(dt.Rows[i]["Price"].ToString());
                    video.Quantity = int.Parse(dt.Rows[i]["Quantity"].ToString());
                    video.Director = dt.Rows[i]["Director"].ToString();
                    video.Actor = dt.Rows[i]["Actor"].ToString();
                    video.Decription = dt.Rows[i]["Decription"].ToString();
                    video.Thumbnail = dt.Rows[i]["Thumbnail"].ToString();
                    video.Provider = dt.Rows[i]["Provider"].ToString();
                    video.Category = dt.Rows[i]["Category"].ToString();
                    videos.Add(video);
                }
                videoBindingSource.DataSource = videos;
            }    
            

        }
        DataTableCollection TableCollection;
        private void Button_ImportFile_Click(object sender, EventArgs e)
        {
            
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "*.xls| *.xlsx" })
            {

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    TextBox_FilePath.Text = openFileDialog.FileName;
                    using (var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using(IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream) )
                        {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                            });
                            TableCollection = result.Tables;
                            ComboBox_Sheet.Items.Clear();
                            foreach (DataTable table in TableCollection)
                                ComboBox_Sheet.Items.Add(table.TableName); 

                        }    
                    }    
                }
            }
        }

        private void Button_Import_Click(object sender, EventArgs e)
        {
           
            string connectionSTR = @"Data Source=.\SQLEXPRESS;Initial Catalog=VideoRentalStore;Integrated Security=True";
            DapperPlusManager.Entity<Video>().Table("Video");
                List<Video> videos = videoBindingSource.DataSource as List<Video>;
                if (videos !=null ) 
                {
                    using (IDbConnection db = new SqlConnection(connectionSTR))
                    {
                        db.BulkInsert(videos);
                    }
                    MessageBox.Show("Import Successfully");
                }
            
        }

        private void DataGridView_Import_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Import_Disk_WithFile_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'videoRentalStoreDataSet.Video' table. You can move, or remove it, as needed.
            this.videoTableAdapter.Fill(this.videoRentalStoreDataSet.Video);
            DataGridView_Import.Visible = false;
        }
    }
}
