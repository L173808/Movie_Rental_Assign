
namespace Movie_Rental_Assign
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvRecord = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.best_movie = new System.Windows.Forms.Button();
            this.dtpReturn = new System.Windows.Forms.DateTimePicker();
            this.dtpIssue = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.del_button = new System.Windows.Forms.Button();
            this.return_button = new System.Windows.Forms.Button();
            this.issue_button = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.VidID = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.CustID = new System.Windows.Forms.TextBox();
            this.best_customer = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cost_textbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.delete_video_Button = new System.Windows.Forms.Button();
            this.updateMovie = new System.Windows.Forms.Button();
            this.video_detailsAdd = new System.Windows.Forms.Button();
            this.Textbox_genre = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.VideoPlot_textbox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Movie_Copies_textBox = new System.Windows.Forms.TextBox();
            this.movie_add_Textbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.video_ratting = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.video_name = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cust_Email = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.del_cust = new System.Windows.Forms.Button();
            this.update_customer = new System.Windows.Forms.Button();
            this.add_custmer = new System.Windows.Forms.Button();
            this.cust_Mobile = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CustAddress_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CustNametextBox = new System.Windows.Forms.TextBox();
            this.show_customers = new System.Windows.Forms.Button();
            this.show_videos = new System.Windows.Forms.Button();
            this.show_rentals = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecord)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvRecord
            // 
            this.dgvRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecord.Location = new System.Drawing.Point(12, 476);
            this.dgvRecord.Name = "dgvRecord";
            this.dgvRecord.Size = new System.Drawing.Size(1019, 195);
            this.dgvRecord.TabIndex = 14;
            this.dgvRecord.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRecord_CellClick);
            this.dgvRecord.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRecord_CellContentClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.best_movie);
            this.groupBox3.Controls.Add(this.dtpReturn);
            this.groupBox3.Controls.Add(this.dtpIssue);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.del_button);
            this.groupBox3.Controls.Add(this.return_button);
            this.groupBox3.Controls.Add(this.issue_button);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.VidID);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.CustID);
            this.groupBox3.Location = new System.Drawing.Point(25, 293);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1006, 129);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Rental Details";
            // 
            // best_movie
            // 
            this.best_movie.BackColor = System.Drawing.Color.Maroon;
            this.best_movie.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.best_movie.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.best_movie.Location = new System.Drawing.Point(746, 84);
            this.best_movie.Name = "best_movie";
            this.best_movie.Size = new System.Drawing.Size(158, 39);
            this.best_movie.TabIndex = 14;
            this.best_movie.Text = "Ratted Movie";
            this.best_movie.UseVisualStyleBackColor = false;
            this.best_movie.Click += new System.EventHandler(this.best_movie_Click);
            // 
            // dtpReturn
            // 
            this.dtpReturn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReturn.Location = new System.Drawing.Point(656, 58);
            this.dtpReturn.Name = "dtpReturn";
            this.dtpReturn.Size = new System.Drawing.Size(181, 20);
            this.dtpReturn.TabIndex = 12;
            // 
            // dtpIssue
            // 
            this.dtpIssue.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIssue.Location = new System.Drawing.Point(471, 58);
            this.dtpIssue.Name = "dtpIssue";
            this.dtpIssue.Size = new System.Drawing.Size(161, 20);
            this.dtpIssue.TabIndex = 11;
            this.dtpIssue.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label15.Location = new System.Drawing.Point(693, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(106, 21);
            this.label15.TabIndex = 9;
            this.label15.Text = "Return Date";
            // 
            // del_button
            // 
            this.del_button.BackColor = System.Drawing.Color.Maroon;
            this.del_button.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.del_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.del_button.Location = new System.Drawing.Point(308, 81);
            this.del_button.Name = "del_button";
            this.del_button.Size = new System.Drawing.Size(102, 39);
            this.del_button.TabIndex = 8;
            this.del_button.Text = "DELETE";
            this.del_button.UseVisualStyleBackColor = false;
            this.del_button.Click += new System.EventHandler(this.del_button_Click);
            // 
            // return_button
            // 
            this.return_button.BackColor = System.Drawing.Color.Maroon;
            this.return_button.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.return_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.return_button.Location = new System.Drawing.Point(188, 79);
            this.return_button.Name = "return_button";
            this.return_button.Size = new System.Drawing.Size(102, 39);
            this.return_button.TabIndex = 7;
            this.return_button.Text = "RETURN";
            this.return_button.UseVisualStyleBackColor = false;
            this.return_button.Click += new System.EventHandler(this.return_button_Click);
            // 
            // issue_button
            // 
            this.issue_button.BackColor = System.Drawing.Color.Maroon;
            this.issue_button.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issue_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.issue_button.Location = new System.Drawing.Point(68, 79);
            this.issue_button.Name = "issue_button";
            this.issue_button.Size = new System.Drawing.Size(103, 39);
            this.issue_button.TabIndex = 6;
            this.issue_button.Text = "ISSUE";
            this.issue_button.UseVisualStyleBackColor = false;
            this.issue_button.Click += new System.EventHandler(this.issue_button_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(511, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 21);
            this.label12.TabIndex = 4;
            this.label12.Text = "Issue Date";
            // 
            // VidID
            // 
            this.VidID.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VidID.Location = new System.Drawing.Point(328, 29);
            this.VidID.Name = "VidID";
            this.VidID.Size = new System.Drawing.Size(122, 32);
            this.VidID.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(233, 32);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 21);
            this.label13.TabIndex = 2;
            this.label13.Text = "Video ID";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(6, 34);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(108, 21);
            this.label14.TabIndex = 1;
            this.label14.Text = "Customer ID";
            // 
            // CustID
            // 
            this.CustID.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustID.Location = new System.Drawing.Point(113, 32);
            this.CustID.Name = "CustID";
            this.CustID.Size = new System.Drawing.Size(110, 32);
            this.CustID.TabIndex = 0;
            // 
            // best_customer
            // 
            this.best_customer.BackColor = System.Drawing.Color.Maroon;
            this.best_customer.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.best_customer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.best_customer.Location = new System.Drawing.Point(771, 431);
            this.best_customer.Name = "best_customer";
            this.best_customer.Size = new System.Drawing.Size(158, 39);
            this.best_customer.TabIndex = 13;
            this.best_customer.Text = "Valued Customer ";
            this.best_customer.UseVisualStyleBackColor = false;
            this.best_customer.Click += new System.EventHandler(this.best_customer_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cost_textbox);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.delete_video_Button);
            this.groupBox2.Controls.Add(this.updateMovie);
            this.groupBox2.Controls.Add(this.video_detailsAdd);
            this.groupBox2.Controls.Add(this.Textbox_genre);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.VideoPlot_textbox);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.Movie_Copies_textBox);
            this.groupBox2.Controls.Add(this.movie_add_Textbox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.video_ratting);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.video_name);
            this.groupBox2.Location = new System.Drawing.Point(25, 130);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1006, 157);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Enter Video Details";
            // 
            // cost_textbox
            // 
            this.cost_textbox.Enabled = false;
            this.cost_textbox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cost_textbox.Location = new System.Drawing.Point(825, 76);
            this.cost_textbox.Name = "cost_textbox";
            this.cost_textbox.Size = new System.Drawing.Size(124, 32);
            this.cost_textbox.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(723, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 21);
            this.label8.TabIndex = 17;
            this.label8.Text = "Video Cost";
            // 
            // delete_video_Button
            // 
            this.delete_video_Button.BackColor = System.Drawing.Color.Maroon;
            this.delete_video_Button.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_video_Button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.delete_video_Button.Location = new System.Drawing.Point(247, 113);
            this.delete_video_Button.Name = "delete_video_Button";
            this.delete_video_Button.Size = new System.Drawing.Size(87, 39);
            this.delete_video_Button.TabIndex = 8;
            this.delete_video_Button.Text = "DELETE";
            this.delete_video_Button.UseVisualStyleBackColor = false;
            this.delete_video_Button.Click += new System.EventHandler(this.delete_video_Button_Click);
            // 
            // updateMovie
            // 
            this.updateMovie.BackColor = System.Drawing.Color.Maroon;
            this.updateMovie.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateMovie.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.updateMovie.Location = new System.Drawing.Point(155, 112);
            this.updateMovie.Name = "updateMovie";
            this.updateMovie.Size = new System.Drawing.Size(85, 41);
            this.updateMovie.TabIndex = 7;
            this.updateMovie.Text = "UPDATE";
            this.updateMovie.UseVisualStyleBackColor = false;
            this.updateMovie.Click += new System.EventHandler(this.updateMovie_Click);
            // 
            // video_detailsAdd
            // 
            this.video_detailsAdd.BackColor = System.Drawing.Color.Maroon;
            this.video_detailsAdd.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.video_detailsAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.video_detailsAdd.Location = new System.Drawing.Point(68, 112);
            this.video_detailsAdd.Name = "video_detailsAdd";
            this.video_detailsAdd.Size = new System.Drawing.Size(70, 41);
            this.video_detailsAdd.TabIndex = 6;
            this.video_detailsAdd.Text = "ADD";
            this.video_detailsAdd.UseVisualStyleBackColor = false;
            this.video_detailsAdd.Click += new System.EventHandler(this.video_detailsAdd_Click);
            // 
            // Textbox_genre
            // 
            this.Textbox_genre.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox_genre.Location = new System.Drawing.Point(537, 76);
            this.Textbox_genre.Name = "Textbox_genre";
            this.Textbox_genre.Size = new System.Drawing.Size(124, 32);
            this.Textbox_genre.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(456, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 21);
            this.label9.TabIndex = 15;
            this.label9.Text = "Genre";
            // 
            // VideoPlot_textbox
            // 
            this.VideoPlot_textbox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VideoPlot_textbox.Location = new System.Drawing.Point(323, 76);
            this.VideoPlot_textbox.Name = "VideoPlot_textbox";
            this.VideoPlot_textbox.Size = new System.Drawing.Size(127, 32);
            this.VideoPlot_textbox.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(229, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 21);
            this.label10.TabIndex = 13;
            this.label10.Text = "Plot";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(6, 81);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 21);
            this.label11.TabIndex = 12;
            this.label11.Text = "Copies";
            // 
            // Movie_Copies_textBox
            // 
            this.Movie_Copies_textBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Movie_Copies_textBox.Location = new System.Drawing.Point(97, 76);
            this.Movie_Copies_textBox.Name = "Movie_Copies_textBox";
            this.Movie_Copies_textBox.Size = new System.Drawing.Size(126, 32);
            this.Movie_Copies_textBox.TabIndex = 11;
            // 
            // movie_add_Textbox
            // 
            this.movie_add_Textbox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movie_add_Textbox.Location = new System.Drawing.Point(825, 29);
            this.movie_add_Textbox.Name = "movie_add_Textbox";
            this.movie_add_Textbox.Size = new System.Drawing.Size(124, 32);
            this.movie_add_Textbox.TabIndex = 5;
            this.movie_add_Textbox.TextChanged += new System.EventHandler(this.movie_add_Textbox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(641, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Movie Realease year";
            // 
            // video_ratting
            // 
            this.video_ratting.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.video_ratting.Location = new System.Drawing.Point(371, 29);
            this.video_ratting.Name = "video_ratting";
            this.video_ratting.Size = new System.Drawing.Size(127, 32);
            this.video_ratting.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(246, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "Video Ratings";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(6, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 21);
            this.label6.TabIndex = 1;
            this.label6.Text = "Video Name";
            // 
            // video_name
            // 
            this.video_name.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.video_name.Location = new System.Drawing.Point(114, 29);
            this.video_name.Name = "video_name";
            this.video_name.Size = new System.Drawing.Size(126, 32);
            this.video_name.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cust_Email);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.del_cust);
            this.groupBox1.Controls.Add(this.update_customer);
            this.groupBox1.Controls.Add(this.add_custmer);
            this.groupBox1.Controls.Add(this.cust_Mobile);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.CustAddress_textBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CustNametextBox);
            this.groupBox1.Location = new System.Drawing.Point(25, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1006, 112);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter Customer Details";
            // 
            // cust_Email
            // 
            this.cust_Email.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cust_Email.Location = new System.Drawing.Point(129, 71);
            this.cust_Email.Name = "cust_Email";
            this.cust_Email.Size = new System.Drawing.Size(143, 32);
            this.cust_Email.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(6, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 21);
            this.label7.TabIndex = 9;
            this.label7.Text = "Cust Email";
            // 
            // del_cust
            // 
            this.del_cust.BackColor = System.Drawing.Color.Maroon;
            this.del_cust.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.del_cust.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.del_cust.Location = new System.Drawing.Point(886, 70);
            this.del_cust.Name = "del_cust";
            this.del_cust.Size = new System.Drawing.Size(102, 36);
            this.del_cust.TabIndex = 8;
            this.del_cust.Text = "DELETE";
            this.del_cust.UseVisualStyleBackColor = false;
            this.del_cust.Click += new System.EventHandler(this.del_cust_Click);
            // 
            // update_customer
            // 
            this.update_customer.BackColor = System.Drawing.Color.Maroon;
            this.update_customer.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_customer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.update_customer.Location = new System.Drawing.Point(886, 19);
            this.update_customer.Name = "update_customer";
            this.update_customer.Size = new System.Drawing.Size(102, 36);
            this.update_customer.TabIndex = 7;
            this.update_customer.Text = "UPDATE";
            this.update_customer.UseVisualStyleBackColor = false;
            this.update_customer.Click += new System.EventHandler(this.update_customer_Click);
            // 
            // add_custmer
            // 
            this.add_custmer.BackColor = System.Drawing.Color.Maroon;
            this.add_custmer.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_custmer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.add_custmer.Location = new System.Drawing.Point(777, 65);
            this.add_custmer.Name = "add_custmer";
            this.add_custmer.Size = new System.Drawing.Size(103, 41);
            this.add_custmer.TabIndex = 6;
            this.add_custmer.Text = "ADD";
            this.add_custmer.UseVisualStyleBackColor = false;
            this.add_custmer.Click += new System.EventHandler(this.add_custmer_Click);
            // 
            // cust_Mobile
            // 
            this.cust_Mobile.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cust_Mobile.Location = new System.Drawing.Point(656, 27);
            this.cust_Mobile.Name = "cust_Mobile";
            this.cust_Mobile.Size = new System.Drawing.Size(143, 32);
            this.cust_Mobile.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(533, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cust Mobile";
            // 
            // CustAddress_textBox
            // 
            this.CustAddress_textBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustAddress_textBox.Location = new System.Drawing.Point(384, 25);
            this.CustAddress_textBox.Name = "CustAddress_textBox";
            this.CustAddress_textBox.Size = new System.Drawing.Size(143, 32);
            this.CustAddress_textBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(270, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cust Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cust  Name";
            // 
            // CustNametextBox
            // 
            this.CustNametextBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustNametextBox.Location = new System.Drawing.Point(121, 32);
            this.CustNametextBox.Name = "CustNametextBox";
            this.CustNametextBox.Size = new System.Drawing.Size(143, 32);
            this.CustNametextBox.TabIndex = 0;
            // 
            // show_customers
            // 
            this.show_customers.BackColor = System.Drawing.Color.Maroon;
            this.show_customers.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_customers.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.show_customers.Location = new System.Drawing.Point(59, 428);
            this.show_customers.Name = "show_customers";
            this.show_customers.Size = new System.Drawing.Size(158, 39);
            this.show_customers.TabIndex = 15;
            this.show_customers.Text = "Show Customers";
            this.show_customers.UseVisualStyleBackColor = false;
            this.show_customers.Click += new System.EventHandler(this.show_customers_Click);
            // 
            // show_videos
            // 
            this.show_videos.BackColor = System.Drawing.Color.Maroon;
            this.show_videos.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_videos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.show_videos.Location = new System.Drawing.Point(245, 428);
            this.show_videos.Name = "show_videos";
            this.show_videos.Size = new System.Drawing.Size(158, 39);
            this.show_videos.TabIndex = 16;
            this.show_videos.Text = "Show Videos";
            this.show_videos.UseVisualStyleBackColor = false;
            this.show_videos.Click += new System.EventHandler(this.show_videos_Click);
            // 
            // show_rentals
            // 
            this.show_rentals.BackColor = System.Drawing.Color.Maroon;
            this.show_rentals.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_rentals.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.show_rentals.Location = new System.Drawing.Point(425, 428);
            this.show_rentals.Name = "show_rentals";
            this.show_rentals.Size = new System.Drawing.Size(158, 39);
            this.show_rentals.TabIndex = 17;
            this.show_rentals.Text = "Show Rentals";
            this.show_rentals.UseVisualStyleBackColor = false;
            this.show_rentals.Click += new System.EventHandler(this.show_rentals_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(1043, 683);
            this.Controls.Add(this.show_rentals);
            this.Controls.Add(this.show_videos);
            this.Controls.Add(this.show_customers);
            this.Controls.Add(this.dgvRecord);
            this.Controls.Add(this.best_customer);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecord)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRecord;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button best_movie;
        private System.Windows.Forms.Button best_customer;
        private System.Windows.Forms.DateTimePicker dtpReturn;
        private System.Windows.Forms.DateTimePicker dtpIssue;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button del_button;
        private System.Windows.Forms.Button return_button;
        private System.Windows.Forms.Button issue_button;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox VidID;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox CustID;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox cost_textbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button delete_video_Button;
        private System.Windows.Forms.Button updateMovie;
        private System.Windows.Forms.Button video_detailsAdd;
        private System.Windows.Forms.TextBox Textbox_genre;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox VideoPlot_textbox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Movie_Copies_textBox;
        private System.Windows.Forms.TextBox movie_add_Textbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox video_ratting;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox video_name;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button del_cust;
        private System.Windows.Forms.Button update_customer;
        private System.Windows.Forms.Button add_custmer;
        private System.Windows.Forms.TextBox cust_Mobile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CustAddress_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CustNametextBox;
        private System.Windows.Forms.TextBox cust_Email;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button show_customers;
        private System.Windows.Forms.Button show_videos;
        private System.Windows.Forms.Button show_rentals;
    }
}

