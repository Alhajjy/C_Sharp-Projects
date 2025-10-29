namespace Pizza_Project
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyIcon2 = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyIcon3 = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyIcon4 = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyIcon5 = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyIcon6 = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_large = new System.Windows.Forms.RadioButton();
            this.rb_medium = new System.Windows.Forms.RadioButton();
            this.rb_small = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_thick = new System.Windows.Forms.RadioButton();
            this.rb_thin = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rb_take_out = new System.Windows.Forms.RadioButton();
            this.rb_eat_in = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chk_green_peppers = new System.Windows.Forms.CheckBox();
            this.chk_olives = new System.Windows.Forms.CheckBox();
            this.chk_onion = new System.Windows.Forms.CheckBox();
            this.chk_tomatos = new System.Windows.Forms.CheckBox();
            this.chk_mashrooms = new System.Windows.Forms.CheckBox();
            this.chk_extra_cheese = new System.Windows.Forms.CheckBox();
            this.btn_order = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.result_price = new System.Windows.Forms.Label();
            this.result_eating_area = new System.Windows.Forms.Label();
            this.result_crust = new System.Windows.Forms.Label();
            this.result_toppings = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.result_size = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(89, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Elites Pizza";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // notifyIcon2
            // 
            this.notifyIcon2.Text = "notifyIcon2";
            this.notifyIcon2.Visible = true;
            // 
            // notifyIcon3
            // 
            this.notifyIcon3.Text = "notifyIcon3";
            this.notifyIcon3.Visible = true;
            // 
            // notifyIcon4
            // 
            this.notifyIcon4.Text = "notifyIcon4";
            this.notifyIcon4.Visible = true;
            // 
            // notifyIcon5
            // 
            this.notifyIcon5.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon5.Text = "notifyIcon5";
            this.notifyIcon5.Visible = true;
            // 
            // notifyIcon6
            // 
            this.notifyIcon6.Text = "notifyIcon6";
            this.notifyIcon6.Visible = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gold;
            this.groupBox1.Controls.Add(this.rb_large);
            this.groupBox1.Controls.Add(this.rb_medium);
            this.groupBox1.Controls.Add(this.rb_small);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(96, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 201);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Size:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rb_large
            // 
            this.rb_large.AutoSize = true;
            this.rb_large.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_large.Location = new System.Drawing.Point(21, 150);
            this.rb_large.Name = "rb_large";
            this.rb_large.Size = new System.Drawing.Size(66, 23);
            this.rb_large.TabIndex = 3;
            this.rb_large.TabStop = true;
            this.rb_large.Tag = "40";
            this.rb_large.Text = "Large";
            this.rb_large.UseVisualStyleBackColor = true;
            this.rb_large.CheckedChanged += new System.EventHandler(this.rb_large_CheckedChanged);
            // 
            // rb_medium
            // 
            this.rb_medium.AutoSize = true;
            this.rb_medium.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_medium.Location = new System.Drawing.Point(21, 106);
            this.rb_medium.Name = "rb_medium";
            this.rb_medium.Size = new System.Drawing.Size(83, 23);
            this.rb_medium.TabIndex = 2;
            this.rb_medium.TabStop = true;
            this.rb_medium.Tag = "30";
            this.rb_medium.Text = "Medium";
            this.rb_medium.UseVisualStyleBackColor = true;
            this.rb_medium.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rb_small
            // 
            this.rb_small.AutoSize = true;
            this.rb_small.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_small.Location = new System.Drawing.Point(21, 62);
            this.rb_small.Name = "rb_small";
            this.rb_small.Size = new System.Drawing.Size(66, 23);
            this.rb_small.TabIndex = 1;
            this.rb_small.TabStop = true;
            this.rb_small.Tag = "20";
            this.rb_small.Text = "Small";
            this.rb_small.UseVisualStyleBackColor = true;
            this.rb_small.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Gold;
            this.groupBox2.Controls.Add(this.rb_thick);
            this.groupBox2.Controls.Add(this.rb_thin);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(96, 341);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 149);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Crust:";
            // 
            // rb_thick
            // 
            this.rb_thick.AutoSize = true;
            this.rb_thick.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_thick.Location = new System.Drawing.Point(21, 91);
            this.rb_thick.Name = "rb_thick";
            this.rb_thick.Size = new System.Drawing.Size(65, 23);
            this.rb_thick.TabIndex = 2;
            this.rb_thick.TabStop = true;
            this.rb_thick.Tag = "5";
            this.rb_thick.Text = "Thick";
            this.rb_thick.UseVisualStyleBackColor = true;
            this.rb_thick.CheckedChanged += new System.EventHandler(this.rb_thick_CheckedChanged);
            // 
            // rb_thin
            // 
            this.rb_thin.AutoSize = true;
            this.rb_thin.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_thin.Location = new System.Drawing.Point(21, 47);
            this.rb_thin.Name = "rb_thin";
            this.rb_thin.Size = new System.Drawing.Size(59, 23);
            this.rb_thin.TabIndex = 1;
            this.rb_thin.TabStop = true;
            this.rb_thin.Tag = "0";
            this.rb_thin.Text = "Thin";
            this.rb_thin.UseVisualStyleBackColor = true;
            this.rb_thin.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Gold;
            this.groupBox3.Controls.Add(this.rb_take_out);
            this.groupBox3.Controls.Add(this.rb_eat_in);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(381, 341);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(371, 149);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Where to eat:";
            // 
            // rb_take_out
            // 
            this.rb_take_out.AutoSize = true;
            this.rb_take_out.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_take_out.Location = new System.Drawing.Point(198, 47);
            this.rb_take_out.Name = "rb_take_out";
            this.rb_take_out.Size = new System.Drawing.Size(84, 23);
            this.rb_take_out.TabIndex = 2;
            this.rb_take_out.TabStop = true;
            this.rb_take_out.Text = "take out";
            this.rb_take_out.UseVisualStyleBackColor = true;
            this.rb_take_out.CheckedChanged += new System.EventHandler(this.rb_take_out_CheckedChanged);
            // 
            // rb_eat_in
            // 
            this.rb_eat_in.AutoSize = true;
            this.rb_eat_in.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_eat_in.Location = new System.Drawing.Point(17, 47);
            this.rb_eat_in.Name = "rb_eat_in";
            this.rb_eat_in.Size = new System.Drawing.Size(66, 23);
            this.rb_eat_in.TabIndex = 1;
            this.rb_eat_in.TabStop = true;
            this.rb_eat_in.Text = "eat in";
            this.rb_eat_in.UseVisualStyleBackColor = true;
            this.rb_eat_in.CheckedChanged += new System.EventHandler(this.rb_eat_in_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Gold;
            this.groupBox4.Controls.Add(this.chk_green_peppers);
            this.groupBox4.Controls.Add(this.chk_olives);
            this.groupBox4.Controls.Add(this.chk_onion);
            this.groupBox4.Controls.Add(this.chk_tomatos);
            this.groupBox4.Controls.Add(this.chk_mashrooms);
            this.groupBox4.Controls.Add(this.chk_extra_cheese);
            this.groupBox4.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.Black;
            this.groupBox4.Location = new System.Drawing.Point(381, 91);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(371, 201);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Toppings:";
            this.groupBox4.UseWaitCursor = true;
            // 
            // chk_green_peppers
            // 
            this.chk_green_peppers.AutoSize = true;
            this.chk_green_peppers.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_green_peppers.Location = new System.Drawing.Point(198, 146);
            this.chk_green_peppers.Name = "chk_green_peppers";
            this.chk_green_peppers.Size = new System.Drawing.Size(131, 23);
            this.chk_green_peppers.TabIndex = 5;
            this.chk_green_peppers.Tag = "5";
            this.chk_green_peppers.Text = "Green Peppers";
            this.chk_green_peppers.UseVisualStyleBackColor = true;
            this.chk_green_peppers.UseWaitCursor = true;
            this.chk_green_peppers.CheckedChanged += new System.EventHandler(this.chk_green_peppers_CheckedChanged);
            // 
            // chk_olives
            // 
            this.chk_olives.AutoSize = true;
            this.chk_olives.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_olives.Location = new System.Drawing.Point(198, 102);
            this.chk_olives.Name = "chk_olives";
            this.chk_olives.Size = new System.Drawing.Size(71, 23);
            this.chk_olives.TabIndex = 4;
            this.chk_olives.Tag = "5";
            this.chk_olives.Text = "Olives";
            this.chk_olives.UseVisualStyleBackColor = true;
            this.chk_olives.UseWaitCursor = true;
            this.chk_olives.CheckedChanged += new System.EventHandler(this.chk_olives_CheckedChanged);
            // 
            // chk_onion
            // 
            this.chk_onion.AutoSize = true;
            this.chk_onion.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_onion.Location = new System.Drawing.Point(198, 58);
            this.chk_onion.Name = "chk_onion";
            this.chk_onion.Size = new System.Drawing.Size(71, 23);
            this.chk_onion.TabIndex = 3;
            this.chk_onion.Tag = "5";
            this.chk_onion.Text = "Onion";
            this.chk_onion.UseVisualStyleBackColor = true;
            this.chk_onion.UseWaitCursor = true;
            this.chk_onion.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // chk_tomatos
            // 
            this.chk_tomatos.AutoSize = true;
            this.chk_tomatos.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_tomatos.Location = new System.Drawing.Point(17, 146);
            this.chk_tomatos.Name = "chk_tomatos";
            this.chk_tomatos.Size = new System.Drawing.Size(90, 23);
            this.chk_tomatos.TabIndex = 2;
            this.chk_tomatos.Tag = "5";
            this.chk_tomatos.Text = "Tomatos";
            this.chk_tomatos.UseVisualStyleBackColor = true;
            this.chk_tomatos.UseWaitCursor = true;
            this.chk_tomatos.CheckedChanged += new System.EventHandler(this.chk_tomatos_CheckedChanged);
            // 
            // chk_mashrooms
            // 
            this.chk_mashrooms.AutoSize = true;
            this.chk_mashrooms.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_mashrooms.Location = new System.Drawing.Point(17, 102);
            this.chk_mashrooms.Name = "chk_mashrooms";
            this.chk_mashrooms.Size = new System.Drawing.Size(109, 23);
            this.chk_mashrooms.TabIndex = 1;
            this.chk_mashrooms.Tag = "5";
            this.chk_mashrooms.Text = "Mashrooms";
            this.chk_mashrooms.UseVisualStyleBackColor = true;
            this.chk_mashrooms.UseWaitCursor = true;
            this.chk_mashrooms.CheckedChanged += new System.EventHandler(this.chk_mashrooms_CheckedChanged);
            // 
            // chk_extra_cheese
            // 
            this.chk_extra_cheese.AutoSize = true;
            this.chk_extra_cheese.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_extra_cheese.Location = new System.Drawing.Point(17, 56);
            this.chk_extra_cheese.Name = "chk_extra_cheese";
            this.chk_extra_cheese.Size = new System.Drawing.Size(119, 23);
            this.chk_extra_cheese.TabIndex = 0;
            this.chk_extra_cheese.Tag = "5";
            this.chk_extra_cheese.Text = "Extra Cheese";
            this.chk_extra_cheese.UseVisualStyleBackColor = true;
            this.chk_extra_cheese.UseWaitCursor = true;
            this.chk_extra_cheese.CheckedChanged += new System.EventHandler(this.chk_extra_cheese_CheckedChanged);
            // 
            // btn_order
            // 
            this.btn_order.BackColor = System.Drawing.Color.Navy;
            this.btn_order.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_order.ForeColor = System.Drawing.Color.Transparent;
            this.btn_order.Location = new System.Drawing.Point(381, 549);
            this.btn_order.Name = "btn_order";
            this.btn_order.Size = new System.Drawing.Size(144, 45);
            this.btn_order.TabIndex = 6;
            this.btn_order.Text = "Order Pizza";
            this.btn_order.UseVisualStyleBackColor = false;
            this.btn_order.Click += new System.EventHandler(this.btn_order_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.Silver;
            this.btn_reset.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.ForeColor = System.Drawing.Color.Black;
            this.btn_reset.Location = new System.Drawing.Point(608, 549);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(144, 45);
            this.btn_reset.TabIndex = 7;
            this.btn_reset.Text = "Reset Form";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Gold;
            this.groupBox5.Controls.Add(this.result_size);
            this.groupBox5.Controls.Add(this.result_price);
            this.groupBox5.Controls.Add(this.result_eating_area);
            this.groupBox5.Controls.Add(this.result_crust);
            this.groupBox5.Controls.Add(this.result_toppings);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.Black;
            this.groupBox5.Location = new System.Drawing.Point(836, 91);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(371, 503);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Order Summary:";
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // result_price
            // 
            this.result_price.AutoSize = true;
            this.result_price.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result_price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.result_price.Location = new System.Drawing.Point(222, 369);
            this.result_price.Name = "result_price";
            this.result_price.Size = new System.Drawing.Size(51, 60);
            this.result_price.TabIndex = 9;
            this.result_price.Text = "?";
            // 
            // result_eating_area
            // 
            this.result_eating_area.AutoSize = true;
            this.result_eating_area.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result_eating_area.Location = new System.Drawing.Point(198, 271);
            this.result_eating_area.Name = "result_eating_area";
            this.result_eating_area.Size = new System.Drawing.Size(17, 19);
            this.result_eating_area.TabIndex = 8;
            this.result_eating_area.Text = "?";
            this.result_eating_area.Click += new System.EventHandler(this.result_eating_area_Click);
            // 
            // result_crust
            // 
            this.result_crust.AutoSize = true;
            this.result_crust.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result_crust.Location = new System.Drawing.Point(174, 216);
            this.result_crust.Name = "result_crust";
            this.result_crust.Size = new System.Drawing.Size(17, 19);
            this.result_crust.TabIndex = 7;
            this.result_crust.Text = "?";
            this.result_crust.Click += new System.EventHandler(this.result_crust_Click);
            // 
            // result_toppings
            // 
            this.result_toppings.AutoSize = true;
            this.result_toppings.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result_toppings.Location = new System.Drawing.Point(30, 135);
            this.result_toppings.MaximumSize = new System.Drawing.Size(320, 75);
            this.result_toppings.Name = "result_toppings";
            this.result_toppings.Size = new System.Drawing.Size(100, 19);
            this.result_toppings.TabIndex = 6;
            this.result_toppings.Text = "No Toppings";
            this.result_toppings.Click += new System.EventHandler(this.result_toppings_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Gold;
            this.label6.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Total Price:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Gold;
            this.label5.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Where to eat:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Gold;
            this.label4.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Crust Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gold;
            this.label3.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Toppings:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gold;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Size:";
            // 
            // result_size
            // 
            this.result_size.AutoSize = true;
            this.result_size.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result_size.Location = new System.Drawing.Point(140, 60);
            this.result_size.Name = "result_size";
            this.result_size.Size = new System.Drawing.Size(17, 19);
            this.result_size.TabIndex = 10;
            this.result_size.Text = "?";
            this.result_size.Click += new System.EventHandler(this.reslut_size_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1302, 667);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_order);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.Text = "Elites Pizza";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.NotifyIcon notifyIcon2;
        private System.Windows.Forms.NotifyIcon notifyIcon3;
        private System.Windows.Forms.NotifyIcon notifyIcon4;
        private System.Windows.Forms.NotifyIcon notifyIcon5;
        private System.Windows.Forms.NotifyIcon notifyIcon6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_large;
        private System.Windows.Forms.RadioButton rb_medium;
        private System.Windows.Forms.RadioButton rb_small;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb_thick;
        private System.Windows.Forms.RadioButton rb_thin;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rb_take_out;
        private System.Windows.Forms.RadioButton rb_eat_in;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox chk_green_peppers;
        private System.Windows.Forms.CheckBox chk_olives;
        private System.Windows.Forms.CheckBox chk_onion;
        private System.Windows.Forms.CheckBox chk_tomatos;
        private System.Windows.Forms.CheckBox chk_mashrooms;
        private System.Windows.Forms.CheckBox chk_extra_cheese;
        private System.Windows.Forms.Button btn_order;
        private System.Windows.Forms.Button btn_reset;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label result_price;
        private System.Windows.Forms.Label result_eating_area;
        private System.Windows.Forms.Label result_crust;
        private System.Windows.Forms.Label result_toppings;
        private System.Windows.Forms.Label result_size;
    }
}

