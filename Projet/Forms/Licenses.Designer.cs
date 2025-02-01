namespace Projet.Forms
{
    partial class Licenses
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
            this.label7 = new System.Windows.Forms.Label();
            this.TxtObser = new Guna.UI2.WinForms.Guna2TextBox();
            this.TxtCombo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtApartir = new Guna.UI2.WinForms.Guna2TextBox();
            this.TxtDate = new Guna.UI2.WinForms.Guna2TextBox();
            this.TxtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtN = new Guna.UI2.WinForms.Guna2TextBox();
            this.BtnImp = new System.Windows.Forms.Button();
            this.BtnSupp = new System.Windows.Forms.Button();
            this.BtnVider = new System.Windows.Forms.Button();
            this.BtnMod = new System.Windows.Forms.Button();
            this.BtnAjouter = new System.Windows.Forms.Button();
            this.BtnRecherche = new System.Windows.Forms.Button();
            this.TxtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.DGVLic = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGVLic)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(135, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 18);
            this.label7.TabIndex = 82;
            this.label7.Text = "ملاحظات ";
            // 
            // TxtObser
            // 
            this.TxtObser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtObser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtObser.DefaultText = "";
            this.TxtObser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtObser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtObser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtObser.DisabledState.Parent = this.TxtObser;
            this.TxtObser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtObser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtObser.FocusedState.Parent = this.TxtObser;
            this.TxtObser.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtObser.HoverState.Parent = this.TxtObser;
            this.TxtObser.Location = new System.Drawing.Point(67, 125);
            this.TxtObser.Name = "TxtObser";
            this.TxtObser.PasswordChar = '\0';
            this.TxtObser.PlaceholderText = "";
            this.TxtObser.SelectedText = "";
            this.TxtObser.ShadowDecoration.Parent = this.TxtObser;
            this.TxtObser.Size = new System.Drawing.Size(219, 42);
            this.TxtObser.TabIndex = 81;
            // 
            // TxtCombo
            // 
            this.TxtCombo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtCombo.BackColor = System.Drawing.Color.Transparent;
            this.TxtCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.TxtCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TxtCombo.FocusedColor = System.Drawing.Color.Empty;
            this.TxtCombo.FocusedState.Parent = this.TxtCombo;
            this.TxtCombo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TxtCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.TxtCombo.FormattingEnabled = true;
            this.TxtCombo.HoverState.Parent = this.TxtCombo;
            this.TxtCombo.ItemHeight = 30;
            this.TxtCombo.Items.AddRange(new object[] {
            "أستاذ(ة) مبرز(ة)",
            "أ. ت. ثا. التأهيلي",
            "أ. ت. الثانوي",
            "أ. ت. ثا. الإعدادي",
            "اس ت ابتدائي",
            "متصرف  تربوي",
            "أستاذ  مبرز للتعليم  الثانوي التأهيلي",
            "أستاذ التعليم الابتدائي"});
            this.TxtCombo.ItemsAppearance.Parent = this.TxtCombo;
            this.TxtCombo.Location = new System.Drawing.Point(67, 34);
            this.TxtCombo.Name = "TxtCombo";
            this.TxtCombo.ShadowDecoration.Parent = this.TxtCombo;
            this.TxtCombo.Size = new System.Drawing.Size(219, 36);
            this.TxtCombo.TabIndex = 80;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(149, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 18);
            this.label2.TabIndex = 76;
            this.label2.Text = "الاطار";
            // 
            // TxtApartir
            // 
            this.TxtApartir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtApartir.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtApartir.DefaultText = "";
            this.TxtApartir.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtApartir.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtApartir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtApartir.DisabledState.Parent = this.TxtApartir;
            this.TxtApartir.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtApartir.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtApartir.FocusedState.Parent = this.TxtApartir;
            this.TxtApartir.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtApartir.HoverState.Parent = this.TxtApartir;
            this.TxtApartir.Location = new System.Drawing.Point(680, 125);
            this.TxtApartir.Name = "TxtApartir";
            this.TxtApartir.PasswordChar = '\0';
            this.TxtApartir.PlaceholderText = "";
            this.TxtApartir.SelectedText = "";
            this.TxtApartir.ShadowDecoration.Parent = this.TxtApartir;
            this.TxtApartir.Size = new System.Drawing.Size(219, 42);
            this.TxtApartir.TabIndex = 74;
            // 
            // TxtDate
            // 
            this.TxtDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtDate.DefaultText = "";
            this.TxtDate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtDate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtDate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtDate.DisabledState.Parent = this.TxtDate;
            this.TxtDate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtDate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtDate.FocusedState.Parent = this.TxtDate;
            this.TxtDate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtDate.HoverState.Parent = this.TxtDate;
            this.TxtDate.Location = new System.Drawing.Point(363, 125);
            this.TxtDate.Name = "TxtDate";
            this.TxtDate.PasswordChar = '\0';
            this.TxtDate.PlaceholderText = "";
            this.TxtDate.SelectedText = "";
            this.TxtDate.ShadowDecoration.Parent = this.TxtDate;
            this.TxtDate.Size = new System.Drawing.Size(219, 42);
            this.TxtDate.TabIndex = 73;
            // 
            // TxtName
            // 
            this.TxtName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtName.DefaultText = "";
            this.TxtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtName.DisabledState.Parent = this.TxtName;
            this.TxtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtName.FocusedState.Parent = this.TxtName;
            this.TxtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtName.HoverState.Parent = this.TxtName;
            this.TxtName.Location = new System.Drawing.Point(680, 41);
            this.TxtName.Name = "TxtName";
            this.TxtName.PasswordChar = '\0';
            this.TxtName.PlaceholderText = "";
            this.TxtName.SelectedText = "";
            this.TxtName.ShadowDecoration.Parent = this.TxtName;
            this.TxtName.Size = new System.Drawing.Size(219, 38);
            this.TxtName.TabIndex = 71;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(724, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 18);
            this.label4.TabIndex = 79;
            this.label4.Text = " طبيعة الرخصة ";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(422, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 18);
            this.label6.TabIndex = 78;
            this.label6.Text = "رقم التأجير";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(436, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 18);
            this.label3.TabIndex = 77;
            this.label3.Text = "مدتها ";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(762, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 18);
            this.label1.TabIndex = 75;
            this.label1.Text = "الاسم";
            // 
            // TxtN
            // 
            this.TxtN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtN.DefaultText = "";
            this.TxtN.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtN.DisabledState.Parent = this.TxtN;
            this.TxtN.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtN.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtN.FocusedState.Parent = this.TxtN;
            this.TxtN.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtN.HoverState.Parent = this.TxtN;
            this.TxtN.Location = new System.Drawing.Point(363, 41);
            this.TxtN.Name = "TxtN";
            this.TxtN.PasswordChar = '\0';
            this.TxtN.PlaceholderText = "";
            this.TxtN.SelectedText = "";
            this.TxtN.ShadowDecoration.Parent = this.TxtN;
            this.TxtN.Size = new System.Drawing.Size(219, 38);
            this.TxtN.TabIndex = 72;
            // 
            // BtnImp
            // 
            this.BtnImp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnImp.BackColor = System.Drawing.Color.White;
            this.BtnImp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnImp.FlatAppearance.BorderSize = 0;
            this.BtnImp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnImp.Location = new System.Drawing.Point(824, 190);
            this.BtnImp.Name = "BtnImp";
            this.BtnImp.Size = new System.Drawing.Size(174, 44);
            this.BtnImp.TabIndex = 87;
            this.BtnImp.Text = "Imprimer";
            this.BtnImp.UseVisualStyleBackColor = false;
            this.BtnImp.Click += new System.EventHandler(this.BtnImp_Click);
            // 
            // BtnSupp
            // 
            this.BtnSupp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnSupp.BackColor = System.Drawing.Color.White;
            this.BtnSupp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSupp.FlatAppearance.BorderSize = 0;
            this.BtnSupp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSupp.Location = new System.Drawing.Point(629, 190);
            this.BtnSupp.Name = "BtnSupp";
            this.BtnSupp.Size = new System.Drawing.Size(174, 44);
            this.BtnSupp.TabIndex = 86;
            this.BtnSupp.Text = "Supprimer";
            this.BtnSupp.UseVisualStyleBackColor = false;
            this.BtnSupp.Click += new System.EventHandler(this.BtnSupp_Click);
            // 
            // BtnVider
            // 
            this.BtnVider.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnVider.BackColor = System.Drawing.Color.White;
            this.BtnVider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnVider.FlatAppearance.BorderSize = 0;
            this.BtnVider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVider.Location = new System.Drawing.Point(409, 190);
            this.BtnVider.Name = "BtnVider";
            this.BtnVider.Size = new System.Drawing.Size(174, 44);
            this.BtnVider.TabIndex = 85;
            this.BtnVider.Text = "Vider";
            this.BtnVider.UseVisualStyleBackColor = false;
            this.BtnVider.Click += new System.EventHandler(this.BtnVider_Click);
            // 
            // BtnMod
            // 
            this.BtnMod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnMod.BackColor = System.Drawing.Color.White;
            this.BtnMod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMod.FlatAppearance.BorderSize = 0;
            this.BtnMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMod.Location = new System.Drawing.Point(212, 190);
            this.BtnMod.Name = "BtnMod";
            this.BtnMod.Size = new System.Drawing.Size(174, 44);
            this.BtnMod.TabIndex = 84;
            this.BtnMod.Text = "Modifier";
            this.BtnMod.UseVisualStyleBackColor = false;
            this.BtnMod.Click += new System.EventHandler(this.BtnMod_Click);
            // 
            // BtnAjouter
            // 
            this.BtnAjouter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnAjouter.BackColor = System.Drawing.Color.White;
            this.BtnAjouter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAjouter.FlatAppearance.BorderSize = 0;
            this.BtnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAjouter.Location = new System.Drawing.Point(23, 190);
            this.BtnAjouter.Name = "BtnAjouter";
            this.BtnAjouter.Size = new System.Drawing.Size(174, 44);
            this.BtnAjouter.TabIndex = 83;
            this.BtnAjouter.Text = "Ajouter";
            this.BtnAjouter.UseVisualStyleBackColor = false;
            this.BtnAjouter.Click += new System.EventHandler(this.BtnAjouter_Click);
            // 
            // BtnRecherche
            // 
            this.BtnRecherche.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRecherche.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRecherche.FlatAppearance.BorderSize = 0;
            this.BtnRecherche.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRecherche.Location = new System.Drawing.Point(309, 262);
            this.BtnRecherche.Name = "BtnRecherche";
            this.BtnRecherche.Size = new System.Drawing.Size(141, 39);
            this.BtnRecherche.TabIndex = 89;
            this.BtnRecherche.Text = "Recherche";
            this.BtnRecherche.UseVisualStyleBackColor = true;
            this.BtnRecherche.Click += new System.EventHandler(this.BtnRecherche_Click);
            // 
            // TxtSearch
            // 
            this.TxtSearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TxtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtSearch.DefaultText = "";
            this.TxtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtSearch.DisabledState.Parent = this.TxtSearch;
            this.TxtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtSearch.FocusedState.Parent = this.TxtSearch;
            this.TxtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtSearch.HoverState.Parent = this.TxtSearch;
            this.TxtSearch.Location = new System.Drawing.Point(489, 262);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.PasswordChar = '\0';
            this.TxtSearch.PlaceholderText = "";
            this.TxtSearch.SelectedText = "";
            this.TxtSearch.ShadowDecoration.Parent = this.TxtSearch;
            this.TxtSearch.Size = new System.Drawing.Size(200, 39);
            this.TxtSearch.TabIndex = 88;
            this.TxtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // DGVLic
            // 
            this.DGVLic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVLic.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVLic.BackgroundColor = System.Drawing.Color.White;
            this.DGVLic.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVLic.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVLic.ColumnHeadersHeight = 32;
            this.DGVLic.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.DGVLic.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVLic.Location = new System.Drawing.Point(12, 350);
            this.DGVLic.Name = "DGVLic";
            this.DGVLic.ReadOnly = true;
            this.DGVLic.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DGVLic.RowHeadersVisible = false;
            this.DGVLic.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVLic.Size = new System.Drawing.Size(991, 218);
            this.DGVLic.TabIndex = 90;
            this.DGVLic.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVLic_CellContentClick);
            // 
            // Licenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1010, 580);
            this.Controls.Add(this.DGVLic);
            this.Controls.Add(this.BtnRecherche);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.BtnImp);
            this.Controls.Add(this.BtnSupp);
            this.Controls.Add(this.BtnVider);
            this.Controls.Add(this.BtnMod);
            this.Controls.Add(this.BtnAjouter);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtObser);
            this.Controls.Add(this.TxtCombo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtApartir);
            this.Controls.Add(this.TxtDate);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Licenses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الرخص";
            this.Load += new System.EventHandler(this.Licenses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVLic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox TxtObser;
        private Guna.UI2.WinForms.Guna2ComboBox TxtCombo;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox TxtApartir;
        private Guna.UI2.WinForms.Guna2TextBox TxtDate;
        private Guna.UI2.WinForms.Guna2TextBox TxtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox TxtN;
        private System.Windows.Forms.Button BtnImp;
        private System.Windows.Forms.Button BtnSupp;
        private System.Windows.Forms.Button BtnVider;
        private System.Windows.Forms.Button BtnMod;
        private System.Windows.Forms.Button BtnAjouter;
        private System.Windows.Forms.Button BtnRecherche;
        private Guna.UI2.WinForms.Guna2TextBox TxtSearch;
        private System.Windows.Forms.DataGridView DGVLic;
    }
}