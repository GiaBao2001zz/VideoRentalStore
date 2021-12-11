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

namespace VideoRentalStore
{
    public partial class NhapDia2 : Form
    {
        public NhapDia2()
        {
            InitializeComponent();
            LoadData();

        }

        private void Button_Import_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source =.\SQLEXPRESS; Initial Catalog = VideoRentalStore; Integrated Security = True");
            string query = "INSERT INTO Video ( Director, Actor , Decription) VALUES ( @Director, @Actor , @Decription)";
            SqlCommand cmd = new SqlCommand(query, con);

            
            

            cmd.Parameters.AddWithValue("@Director", TextBox_VideoDirector.Text);
            cmd.Parameters.AddWithValue("@Actor", TextBox_Actor.Text);
            cmd.Parameters.AddWithValue("@Decription", TextBox_VideoDirector.Text);
            

            con.Open();
            int i = cmd.ExecuteNonQuery();

            con.Close();

            if (i != 0)
            {
                MessageBox.Show("Import Successfully");
            }


        }
        private void LoadData()
        {
            
        }
        

        public void Save_Thumbnail()
        {
            Label_TenDia.Text = NhapDia.DiskName;
            pictureBox_Disc.Image = Image.FromFile(NhapDia.Thumbnail.ToString());
        }

        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
