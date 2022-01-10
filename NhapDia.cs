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
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void NhapDia_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            Import_Disk_WithFile form = new Import_Disk_WithFile();

            form.ShowDialog();
        }

        private void TextBox_TenDia_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void btnImportDisc_Click(object sender, EventArgs e)
        {   
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source =.\SQLEXPRESS; Initial Catalog = VideoRentalStore; Integrated Security = True");
                string query = "INSERT INTO Video ( Name , id, Price, Quantity, Provider, Category, Thumbnail, Actor, Director, Decription) VALUES (@name, @id, @price, @quantity, @provider, @category, @thumbnail, @actor, @director, @decription )";
                SqlCommand cmd = new SqlCommand(query, con);

                float priceDisc = float.Parse(TextBox_Price.Text);
                int quantityDisc = Int32.Parse(TextBox_SL.Text);
                string imgFilePath = TextBox_ImagePath.Text;

                cmd.Parameters.AddWithValue("@name", TextBox_TenDia.Text);
                cmd.Parameters.AddWithValue("@id", TextBox_DiscID.Text);
                cmd.Parameters.AddWithValue("@price", priceDisc);
                cmd.Parameters.AddWithValue("@quantity", quantityDisc);
                cmd.Parameters.AddWithValue("@provider", TextBox_ProviderID.Text);
                cmd.Parameters.AddWithValue("@category", TextBox_Category.Text);
                cmd.Parameters.AddWithValue("@thumbnail", imgFilePath);
                cmd.Parameters.AddWithValue("@director", TextBox_Director.Text);
                cmd.Parameters.AddWithValue("@actor", TextBox_Actor.Text);
                cmd.Parameters.AddWithValue("@decription", TextBox_Description.Text);

                con.Open();
                int i = cmd.ExecuteNonQuery();

                con.Close();

                if (i != 0)
                {
                    MessageBox.Show("Import Successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                  
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

        private void TextBoxDirector_OnValueChanged_1(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged_1(object sender, EventArgs e)
        {

        }

        private void TextBox_Price_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void TextBox_Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void TextBox_SL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}