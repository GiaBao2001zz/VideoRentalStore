using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoRentalStore
{
    public partial class Video_Info : Form
    {
        public Video_Info(string VideoID)
        {
            InitializeComponent();
            ID = VideoID;
            MessageBox.Show(ID);
            //Check if Description need to have scrollbars or not
            if (TextBox_Description.TextLength > 600)
            {
                TextBox_Description.ScrollBars = ScrollBars.Vertical;
            }
            Load_Info();

        }
        public string ID;

        private void Load_Info()
        {
            string connectionSTR = @"Data Source=.\SQLEXPRESS;Initial Catalog=VideoRentalStore;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionSTR);

            string query = "SELECT * FROM Video WHERE id = '"+ ID+"'" ;


            connection.Open();

            SqlCommand command = new SqlCommand(query, connection);
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);

            connection.Close();
            TextBox_VideoPrice.Text = data.Rows[0]["Price"].ToString();
            TextBox_VideoName.Text = data.Rows[0]["Name"].ToString();
            Textbox_VideoQuantity.Text = data.Rows[0]["Quantity"].ToString();
            TextBox_VideoCategory.Text = data.Rows[0]["Category"].ToString();

            TextBox_VideoDirector.Text = data.Rows[0]["Director"].ToString();
            TextBox_VideoActors.Text = data.Rows[0]["Actor"].ToString();
            TextBox_VideoProvider.Text = data.Rows[0]["Provider"].ToString();
            TextBox_Description.Text = data.Rows[0]["Decription"].ToString();
            pictureBox_Disc.Image = Image.FromFile(data.Rows[0]["Thumbnail"].ToString());

        }
        private void TextBox_Description_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox_VideoProvider_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void Label_Actor_Click(object sender, EventArgs e)
        {

        }

        private void Label_Director_Click(object sender, EventArgs e)
        {

        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            
        }

        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to update this video infomation? ", "Changing video Infomation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection(@"Data Source =.\SQLEXPRESS; Initial Catalog = VideoRentalStore; Integrated Security = True");
                string query = "UPDATE video SET Price = @Price  , Quantity = @Quantity , Director= @Director , Actor=  @Actor, Decription =  @Decription, Provider= @Provider, Category = @Category WHERE id = '" + ID + "'";
                SqlCommand cmd = new SqlCommand(query, con);




                cmd.Parameters.AddWithValue("@Price", TextBox_VideoPrice.Text);
                cmd.Parameters.AddWithValue("@Quantity", Textbox_VideoQuantity.Text);
                cmd.Parameters.AddWithValue("@Director", TextBox_VideoDirector.Text);
                cmd.Parameters.AddWithValue("@Actor", TextBox_VideoActors.Text);
                cmd.Parameters.AddWithValue("@Decription", TextBox_Description.Text);
                cmd.Parameters.AddWithValue("@Provider", TextBox_VideoProvider.Text);
                cmd.Parameters.AddWithValue("@Category", TextBox_VideoCategory.Text);


                con.Open();
                int i = cmd.ExecuteNonQuery();

                if (i != 0)
                {
                    MessageBox.Show("Change Video Infomation Successfully");
                    Load_Info();
                }
                con.Close();
            }
        }
    }
}
