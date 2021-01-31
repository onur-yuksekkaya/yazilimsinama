namespace TodoWork
{
    partial class forummainbase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(forummainbase));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_hareket = new System.Windows.Forms.Button();
            this.grp_seciliProje = new System.Windows.Forms.GroupBox();
            this.btn_gorevEkle = new System.Windows.Forms.Button();
            this.btn_gorevliEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_projeler = new System.Windows.Forms.ComboBox();
            this.lbl_gecen = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_tahmin = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_kullanici = new System.Windows.Forms.Label();
            this.list_todo = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.list_progress = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.list_done = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.grp_seciliProje.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btn_hareket);
            this.panel1.Controls.Add(this.grp_seciliProje);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmb_projeler);
            this.panel1.Location = new System.Drawing.Point(0, 65);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(323, 787);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(15, 60);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(295, 66);
            this.button1.TabIndex = 11;
            this.button1.Text = "       Yeni Proje Oluştur";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_hareket
            // 
            this.btn_hareket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
            this.btn_hareket.Enabled = false;
            this.btn_hareket.Location = new System.Drawing.Point(11, 673);
            this.btn_hareket.Margin = new System.Windows.Forms.Padding(4);
            this.btn_hareket.Name = "btn_hareket";
            this.btn_hareket.Size = new System.Drawing.Size(295, 77);
            this.btn_hareket.TabIndex = 10;
            this.btn_hareket.Text = "Görev Hareketleri";
            this.btn_hareket.UseVisualStyleBackColor = false;
            this.btn_hareket.Click += new System.EventHandler(this.btn_hareket_Click);
            // 
            // grp_seciliProje
            // 
            this.grp_seciliProje.Controls.Add(this.btn_gorevEkle);
            this.grp_seciliProje.Controls.Add(this.btn_gorevliEkle);
            this.grp_seciliProje.Enabled = false;
            this.grp_seciliProje.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.grp_seciliProje.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.grp_seciliProje.Location = new System.Drawing.Point(15, 342);
            this.grp_seciliProje.Margin = new System.Windows.Forms.Padding(4);
            this.grp_seciliProje.Name = "grp_seciliProje";
            this.grp_seciliProje.Padding = new System.Windows.Forms.Padding(4);
            this.grp_seciliProje.Size = new System.Drawing.Size(295, 291);
            this.grp_seciliProje.TabIndex = 8;
            this.grp_seciliProje.TabStop = false;
            this.grp_seciliProje.Text = "Seçili Projeye;";
            // 
            // btn_gorevEkle
            // 
            this.btn_gorevEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
            this.btn_gorevEkle.Location = new System.Drawing.Point(23, 167);
            this.btn_gorevEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btn_gorevEkle.Name = "btn_gorevEkle";
            this.btn_gorevEkle.Size = new System.Drawing.Size(264, 74);
            this.btn_gorevEkle.TabIndex = 4;
            this.btn_gorevEkle.Text = "Görev Ekle";
            this.btn_gorevEkle.UseVisualStyleBackColor = false;
            this.btn_gorevEkle.Click += new System.EventHandler(this.btn_gorevEkle_Click);
            // 
            // btn_gorevliEkle
            // 
            this.btn_gorevliEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
            this.btn_gorevliEkle.Location = new System.Drawing.Point(23, 46);
            this.btn_gorevliEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btn_gorevliEkle.Name = "btn_gorevliEkle";
            this.btn_gorevliEkle.Size = new System.Drawing.Size(264, 78);
            this.btn_gorevliEkle.TabIndex = 6;
            this.btn_gorevliEkle.Text = "Görevli Ekle";
            this.btn_gorevliEkle.UseVisualStyleBackColor = false;
            this.btn_gorevliEkle.Click += new System.EventHandler(this.btn_gorevliEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 183);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Projelerim";
            // 
            // cmb_projeler
            // 
            this.cmb_projeler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_projeler.FormattingEnabled = true;
            this.cmb_projeler.Location = new System.Drawing.Point(15, 247);
            this.cmb_projeler.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_projeler.Name = "cmb_projeler";
            this.cmb_projeler.Size = new System.Drawing.Size(297, 24);
            this.cmb_projeler.TabIndex = 1;
            this.cmb_projeler.SelectedIndexChanged += new System.EventHandler(this.cmb_projeler_SelectedIndexChanged);
            // 
            // lbl_gecen
            // 
            this.lbl_gecen.AutoSize = true;
            this.lbl_gecen.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.lbl_gecen.ForeColor = System.Drawing.Color.White;
            this.lbl_gecen.Location = new System.Drawing.Point(1611, 494);
            this.lbl_gecen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_gecen.Name = "lbl_gecen";
            this.lbl_gecen.Size = new System.Drawing.Size(41, 37);
            this.lbl_gecen.TabIndex = 3;
            this.lbl_gecen.Text = "...";
            this.lbl_gecen.Click += new System.EventHandler(this.lbl_gecen_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1364, 494);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 37);
            this.label4.TabIndex = 2;
            this.label4.Text = "Geçen Süre:";
            // 
            // lbl_tahmin
            // 
            this.lbl_tahmin.AutoSize = true;
            this.lbl_tahmin.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.lbl_tahmin.ForeColor = System.Drawing.Color.White;
            this.lbl_tahmin.Location = new System.Drawing.Point(1611, 558);
            this.lbl_tahmin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_tahmin.Name = "lbl_tahmin";
            this.lbl_tahmin.Size = new System.Drawing.Size(41, 37);
            this.lbl_tahmin.TabIndex = 1;
            this.lbl_tahmin.Text = "...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1364, 556);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 37);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tahmini Süre:";
            // 
            // lbl_kullanici
            // 
            this.lbl_kullanici.AutoSize = true;
            this.lbl_kullanici.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.lbl_kullanici.ForeColor = System.Drawing.Color.White;
            this.lbl_kullanici.Location = new System.Drawing.Point(105, 19);
            this.lbl_kullanici.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_kullanici.Name = "lbl_kullanici";
            this.lbl_kullanici.Size = new System.Drawing.Size(86, 30);
            this.lbl_kullanici.TabIndex = 0;
            this.lbl_kullanici.Text = "label1";
            // 
            // list_todo
            // 
            this.list_todo.BackColor = System.Drawing.SystemColors.Control;
            this.list_todo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.list_todo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_todo.FormattingEnabled = true;
            this.list_todo.ItemHeight = 16;
            this.list_todo.Location = new System.Drawing.Point(4, 19);
            this.list_todo.Margin = new System.Windows.Forms.Padding(4);
            this.list_todo.Name = "list_todo";
            this.list_todo.Size = new System.Drawing.Size(456, 338);
            this.list_todo.TabIndex = 1;
            this.list_todo.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.list_todo_MouseDoubleClick);
            this.list_todo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.list_todo_MouseDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.list_todo);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(351, 73);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(464, 361);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "To Do";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.list_progress);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(355, 442);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(464, 398);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "In Progress";
            // 
            // list_progress
            // 
            this.list_progress.AllowDrop = true;
            this.list_progress.BackColor = System.Drawing.SystemColors.Control;
            this.list_progress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.list_progress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_progress.ForeColor = System.Drawing.Color.Black;
            this.list_progress.FormattingEnabled = true;
            this.list_progress.ItemHeight = 16;
            this.list_progress.Location = new System.Drawing.Point(4, 19);
            this.list_progress.Margin = new System.Windows.Forms.Padding(4);
            this.list_progress.Name = "list_progress";
            this.list_progress.Size = new System.Drawing.Size(456, 375);
            this.list_progress.TabIndex = 1;
            this.list_progress.SelectedIndexChanged += new System.EventHandler(this.list_progress_SelectedIndexChanged);
            this.list_progress.DragDrop += new System.Windows.Forms.DragEventHandler(this.list_progress_DragDrop);
            this.list_progress.DragEnter += new System.Windows.Forms.DragEventHandler(this.list_progress_DragEnter);
            this.list_progress.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.list_progress_MouseDoubleClick);
            this.list_progress.MouseDown += new System.Windows.Forms.MouseEventHandler(this.list_progress_MouseDown);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.list_done);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(843, 73);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(464, 763);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Done";
            // 
            // list_done
            // 
            this.list_done.BackColor = System.Drawing.SystemColors.Control;
            this.list_done.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.list_done.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_done.FormattingEnabled = true;
            this.list_done.ItemHeight = 16;
            this.list_done.Location = new System.Drawing.Point(4, 19);
            this.list_done.Margin = new System.Windows.Forms.Padding(4);
            this.list_done.Name = "list_done";
            this.list_done.Size = new System.Drawing.Size(456, 740);
            this.list_done.TabIndex = 1;
            this.list_done.DragDrop += new System.Windows.Forms.DragEventHandler(this.list_done_DragDrop);
            this.list_done.DragEnter += new System.Windows.Forms.DragEventHandler(this.list_done_DragEnter);
            this.list_done.DoubleClick += new System.EventHandler(this.list_done_DoubleClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(72)))));
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.ExitBtn);
            this.panel2.Controls.Add(this.button10);
            this.panel2.Controls.Add(this.button9);
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.lbl_kullanici);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1743, 65);
            this.panel2.TabIndex = 8;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 5);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(83, 58);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // ExitBtn
            // 
            this.ExitBtn.FlatAppearance.BorderSize = 0;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.ForeColor = System.Drawing.Color.White;
            this.ExitBtn.Image = ((System.Drawing.Image)(resources.GetObject("ExitBtn.Image")));
            this.ExitBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExitBtn.Location = new System.Drawing.Point(1642, 18);
            this.ExitBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(49, 43);
            this.ExitBtn.TabIndex = 12;
            this.ExitBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // button10
            // 
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Image = ((System.Drawing.Image)(resources.GetObject("button10.Image")));
            this.button10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.Location = new System.Drawing.Point(667, 14);
            this.button10.Margin = new System.Windows.Forms.Padding(4);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(48, 42);
            this.button10.TabIndex = 13;
            this.button10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Image = ((System.Drawing.Image)(resources.GetObject("button9.Image")));
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.Location = new System.Drawing.Point(599, 14);
            this.button9.Margin = new System.Windows.Forms.Padding(4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(48, 42);
            this.button9.TabIndex = 14;
            this.button9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(531, 14);
            this.button8.Margin = new System.Windows.Forms.Padding(4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(48, 42);
            this.button8.TabIndex = 15;
            this.button8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1335, 125);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 37);
            this.label3.TabIndex = 9;
            this.label3.Text = "NASIL  ÇALIŞIR ?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(1338, 191);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(364, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Projeye  sol tıklayarak listeye bırakırken sağ ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(1338, 223);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "tıklayarak bırakınız.";
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1743, 852);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_gecen);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lbl_tahmin);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_main";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_main_FormClosed);
            this.Load += new System.EventHandler(this.frm_main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grp_seciliProje.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_kullanici;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_projeler;
        private System.Windows.Forms.ListBox list_todo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox list_progress;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox list_done;
        private System.Windows.Forms.Button btn_gorevEkle;
        private System.Windows.Forms.GroupBox grp_seciliProje;
        private System.Windows.Forms.Button btn_gorevliEkle;
        private System.Windows.Forms.Label lbl_gecen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_tahmin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_hareket;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}