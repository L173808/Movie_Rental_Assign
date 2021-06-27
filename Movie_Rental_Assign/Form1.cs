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

namespace Movie_Rental_Assign
{
    public partial class Form1 : Form
    {
        Logic logic = new Logic();
        int BookID = 0,show=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void add_custmer_Click(object sender, EventArgs e)
        {
            //now i am going to insert the record of the customer
            if (!CustNametextBox.Text.Equals("") && !CustAddress_textBox.Text.Equals("") && !cust_Email.Text.Equals("") && !cust_Mobile.Text.Equals(""))
            {
                logic.registerCustomer(CustNametextBox.Text,cust_Email.Text,cust_Mobile.Text,CustAddress_textBox.Text);
                cust_Email.Text = "";
                cust_Mobile.Text = "";
                CustAddress_textBox.Text = "";
                CustNametextBox.Text = "";
            }
            else {
                MessageBox.Show("You need to fill the details ");
            }

        }

        private void update_customer_Click(object sender, EventArgs e)
        {
            if (!CustID.Text.Equals("") && !CustNametextBox.Text.Equals("") && !CustAddress_textBox.Text.Equals("") && !cust_Email.Text.Equals("") && !cust_Mobile.Text.Equals(""))
            {
                logic.editCustomer(Convert.ToInt32(CustID.Text),CustNametextBox.Text, cust_Email.Text, cust_Mobile.Text, CustAddress_textBox.Text);
                cust_Email.Text = "";
                cust_Mobile.Text = "";
                CustAddress_textBox.Text = "";
                CustNametextBox.Text = "";
                CustID.Text = "";
            }
            else
            {
                MessageBox.Show("You need to select and fill the details ");
            }

        }

        private void del_cust_Click(object sender, EventArgs e)
        {
            if (!CustID.Text.Equals("") && !CustNametextBox.Text.Equals("") && !CustAddress_textBox.Text.Equals("") && !cust_Email.Text.Equals("") && !cust_Mobile.Text.Equals(""))
            {
                logic.DelCustomer(Convert.ToInt32(CustID.Text));
                cust_Email.Text = "";
                cust_Mobile.Text = "";
                CustAddress_textBox.Text = "";
                CustNametextBox.Text = "";
                CustID.Text = "";
            }
            else
            {
                MessageBox.Show("You need to select the customer to delete ");
            }


        }

        private void issue_button_Click(object sender, EventArgs e)
        {

            if (!CustID.Text.Equals("") && !VidID.Text.Equals("")) {
                
                logic.registerBooking(CustID.Text,VidID.Text,dtpIssue.Text,"Book");

                video_name.Text = "";
                video_ratting.Text = "";
                movie_add_Textbox.Text = "";
                Movie_Copies_textBox.Text = "";
                VideoPlot_textbox.Text = "";
                cost_textbox.Text = "";
                Textbox_genre.Text = "";
                VidID.Text = "";



                cust_Email.Text = "";
                cust_Mobile.Text = "";
                CustAddress_textBox.Text = "";
                CustNametextBox.Text = "";
                CustID.Text = "";
            }
            else {
                MessageBox.Show("Both must need to select like customer and video ");
            }

        }

        private void return_button_Click(object sender, EventArgs e)
        {

            if (!CustID.Text.Equals("") && !VidID.Text.Equals("") && BookID>0)
            {

                logic.returnBooking(BookID,CustID.Text, VidID.Text, dtpIssue.Text,dtpReturn.Text);

                video_name.Text = "";
                video_ratting.Text = "";
                movie_add_Textbox.Text = "";
                Movie_Copies_textBox.Text = "";
                VideoPlot_textbox.Text = "";
                cost_textbox.Text = "";
                Textbox_genre.Text = "";
                VidID.Text = "";



                cust_Email.Text = "";
                cust_Mobile.Text = "";
                CustAddress_textBox.Text = "";
                CustNametextBox.Text = "";
                CustID.Text = "";
            }
            else
            {
                MessageBox.Show("Both must need to select the Booking to return ");
            }

        }

        private void del_button_Click(object sender, EventArgs e)
        {
            if (!CustID.Text.Equals("") && !VidID.Text.Equals("") && BookID > 0)
            {

                logic.DelIssuedMovie(BookID);

                video_name.Text = "";
                video_ratting.Text = "";
                movie_add_Textbox.Text = "";

                VideoPlot_textbox.Text = "";
                cost_textbox.Text = "";
                Textbox_genre.Text = "";
                VidID.Text = "";
                Movie_Copies_textBox.Text = "";



                cust_Email.Text = "";
                cust_Mobile.Text = "";
                CustAddress_textBox.Text = "";
                CustNametextBox.Text = "";
                CustID.Text = "";
            }
            else
            {
                MessageBox.Show("Both must need to select the Booking to return ");
            }

        }

        private void video_detailsAdd_Click(object sender, EventArgs e)
        {
            if (!video_name.Text.Equals("") && !video_ratting.Text.Equals("") && !video_detailsAdd.Text.Equals("") && !VideoPlot_textbox.Text.Equals("") && !cost_textbox.Text.Equals("") && !Textbox_genre.Text.Equals("") && !Movie_Copies_textBox.Text.Equals("") ) {
                logic.registerMovie(video_name.Text, movie_add_Textbox.Text, video_ratting.Text, Movie_Copies_textBox.Text, cost_textbox.Text, Textbox_genre.Text, VideoPlot_textbox.Text);


                video_name.Text = "";
                video_ratting.Text = "";

                movie_add_Textbox.Text = "";

                VideoPlot_textbox.Text = "";
                cost_textbox.Text = "";
                Textbox_genre.Text = "";
                VidID.Text = "";
                Movie_Copies_textBox.Text = "";


            }
            else {
                MessageBox.Show("Need to enter the details ");
            }
        }

        private void updateMovie_Click(object sender, EventArgs e)
        {
            if (!VidID.Text.Equals("") && !video_name.Text.Equals("") && !video_ratting.Text.Equals("") && !video_detailsAdd.Text.Equals("") && !VideoPlot_textbox.Text.Equals("") && !cost_textbox.Text.Equals("") && !Textbox_genre.Text.Equals("") && !Movie_Copies_textBox.Text.Equals(""))
            {
                logic.editMovie(Convert.ToInt32(VidID.Text),video_name.Text, movie_add_Textbox.Text, video_ratting.Text, Movie_Copies_textBox.Text, cost_textbox.Text, Textbox_genre.Text, VideoPlot_textbox.Text);


                video_name.Text = "";
                video_ratting.Text = "";
                movie_add_Textbox.Text = "";

                VideoPlot_textbox.Text = "";
                cost_textbox.Text = "";
                Textbox_genre.Text = "";
                VidID.Text = "";
                Movie_Copies_textBox.Text = "";


            }
            else
            {
                MessageBox.Show("Need to enter the details ");
            }
        }

        private void delete_video_Button_Click(object sender, EventArgs e)
        {
            if (!VidID.Text.Equals("") && !video_name.Text.Equals("") && !video_ratting.Text.Equals("") && !video_detailsAdd.Text.Equals("") && !VideoPlot_textbox.Text.Equals("") && !cost_textbox.Text.Equals("") && !Textbox_genre.Text.Equals("") && !Movie_Copies_textBox.Text.Equals(""))
            {
                logic.DelMovie(Convert.ToInt32(VidID.Text));


                video_name.Text = "";
                video_ratting.Text = "";
                movie_add_Textbox.Text = "";

                VideoPlot_textbox.Text = "";
                cost_textbox.Text = "";
                Textbox_genre.Text = "";
                VidID.Text = "";
                Movie_Copies_textBox.Text = "";


            }
            else
            {
                MessageBox.Show("Need to select the details ");
            }
        }

        private void show_videos_Click(object sender, EventArgs e)
        {

            show = 2;
            DataTable tbl = new DataTable();

            logic.conn = new SqlConnection(logic.loc);

            logic.conn.Open();

            logic.cmd = new SqlCommand("select * from tblVideo", logic.conn);

            logic.DReader = logic.cmd.ExecuteReader();

            tbl.Load(logic.DReader);

            logic.conn.Close();

            dgvRecord.DataSource = tbl;
        }

        private void show_rentals_Click(object sender, EventArgs e)
        {


            show = 3;
            DataTable tbl = new DataTable();

            logic.conn = new SqlConnection(logic.loc);

            logic.conn.Open();

            logic.cmd = new SqlCommand("select * from tblBooking", logic.conn);

            logic.DReader = logic.cmd.ExecuteReader();

            tbl.Load(logic.DReader);

            logic.conn.Close();

            dgvRecord.DataSource = tbl;
        }

        private void movie_add_Textbox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime dateNow = DateTime.Now;

                int Currentyear = dateNow.Year;

                int diffYear = Currentyear - Convert.ToInt32(movie_add_Textbox.Text);
                int cost = 0;
                // MessageBox.Show(diff.ToString());
                if (diffYear >= 5)
                {
                    cost = 2;
                }
                if (diffYear >= 0 && diffYear < 5)
                {
                    cost = 5;
                }

                cost_textbox.Text = "" + cost;
            }
            catch (Exception ex)
            {

            }
        }

        private void best_movie_Click(object sender, EventArgs e)
        {
            logic.bestVideo();
        }

        private void best_customer_Click(object sender, EventArgs e)
        {
            logic.bestCustomer();
        }

        private void dgvRecord_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void dgvRecord_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (show == 1)
            {
                CustID.Text = dgvRecord.CurrentRow.Cells[0].Value.ToString();
                CustNametextBox.Text = dgvRecord.CurrentRow.Cells[1].Value.ToString();
                cust_Email.Text = dgvRecord.CurrentRow.Cells[2].Value.ToString();
                cust_Mobile.Text = dgvRecord.CurrentRow.Cells[3].Value.ToString();
                CustAddress_textBox.Text = dgvRecord.CurrentRow.Cells[4].Value.ToString();
            }


            else if (show == 2)
            {

                VidID.Text = dgvRecord.CurrentRow.Cells[0].Value.ToString();
                video_name.Text = dgvRecord.CurrentRow.Cells[1].Value.ToString();
                movie_add_Textbox.Text = dgvRecord.CurrentRow.Cells[2].Value.ToString();
                video_ratting.Text = dgvRecord.CurrentRow.Cells[3].Value.ToString();
                Movie_Copies_textBox.Text = dgvRecord.CurrentRow.Cells[4].Value.ToString();
                cost_textbox.Text = dgvRecord.CurrentRow.Cells[5].Value.ToString();
                Textbox_genre.Text = dgvRecord.CurrentRow.Cells[6].Value.ToString();
                VideoPlot_textbox.Text = dgvRecord.CurrentRow.Cells[7].Value.ToString();
            }
            else if (show == 3)
            {
                BookID = Convert.ToInt32(dgvRecord.CurrentRow.Cells[0].Value.ToString());
                VidID.Text = dgvRecord.CurrentRow.Cells[1].Value.ToString();
                CustID.Text = dgvRecord.CurrentRow.Cells[2].Value.ToString();
                dtpIssue.Text = dgvRecord.CurrentRow.Cells[3].Value.ToString();
            }
            show = 0;
        }

        private void show_customers_Click(object sender, EventArgs e)
        {
            show = 1;
            DataTable tbl = new DataTable();

            logic.conn = new SqlConnection(logic.loc);

            logic.conn.Open();

            logic.cmd = new SqlCommand("select * from tblCustomer", logic.conn);

            logic.DReader = logic.cmd.ExecuteReader();

            tbl.Load(logic.DReader);

            logic.conn.Close();

            dgvRecord.DataSource = tbl;
        }
    }
}
