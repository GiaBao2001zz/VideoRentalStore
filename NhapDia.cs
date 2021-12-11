using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace VideoRentalStore
{
    public partial class NhapDia : Form
    {
        public NhapDia()
        {
            InitializeComponent();
        }
        public static string Thumbnail;
        public static string DiskName;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void NhapDia_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void TextBox_TenDia_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void btnImportDisc_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source =.\SQLEXPRESS; Initial Catalog = VideoRentalStore; Integrated Security = True");
            string query = "INSERT INTO Video ( Name , id, Price, Quantity, Provider, Category, Thumbnail) VALUES (@name, @id, @price, @quantity, @provider, @category, @thumbnail )";
            SqlCommand cmd = new SqlCommand(query, con);

            int idDisc = Int32.Parse(TextBox_DiscID.Text);
            float priceDisc = float.Parse(TextBox_Price.Text);
            int quantityDisc = Int32.Parse(TextBox_SL.Text);
            string imgFilePath = TextBox_ImagePath.Text;

            cmd.Parameters.AddWithValue("@name", TextBox_TenDia.Text);
            cmd.Parameters.AddWithValue("@id", idDisc);
            cmd.Parameters.AddWithValue("@price", priceDisc);
            cmd.Parameters.AddWithValue("@quantity", quantityDisc);
            cmd.Parameters.AddWithValue("@provider", TextBox_ProviderID.Text);
            cmd.Parameters.AddWithValue("@category", TextBox_Category.Text);
            cmd.Parameters.AddWithValue("@thumbnail", imgFilePath);

            con.Open();
            int i = cmd.ExecuteNonQuery();

            con.Close();

            if (i != 0)
            {
                MessageBox.Show("Import Successfully");
            }
            Thumbnail = imgFilePath;
            DiskName = TextBox_TenDia.Text;
            NhapDia2 form = new NhapDia2();
            form.Save_Thumbnail();
            this.Hide();
            form.ShowDialog();

            
           
        }

        
        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void TextBox_Category_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBoxDisc_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;...";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pictureBox_Disc.Image = new Bitmap(open.FileName);
                pictureBox_Disc.SizeMode = PictureBoxSizeMode.StretchImage;
                TextBox_ImagePath.Text= open.FileName;
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}