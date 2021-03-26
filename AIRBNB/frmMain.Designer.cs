namespace AIRBNB
{
    partial class frmMain
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
            this.lstProperties = new System.Windows.Forms.ListBox();
            this.lblProperties = new System.Windows.Forms.Label();
            this.lstNeighbrhd = new System.Windows.Forms.ListBox();
            this.lblNeighbrhd = new System.Windows.Forms.Label();
            this.btnSaveNeighbrhd = new System.Windows.Forms.Button();
            this.btnCancelNeighbrhd = new System.Windows.Forms.Button();
            this.grpBoxNeighbourhd = new System.Windows.Forms.GroupBox();
            this.lblRequired = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNumPropertiesInNeighbrhd = new System.Windows.Forms.TextBox();
            this.txtNeighbourhdName = new System.Windows.Forms.TextBox();
            this.lblNumPropertiesInNeighbrhd = new System.Windows.Forms.Label();
            this.lblNeighbourhdName = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSaveProperty = new System.Windows.Forms.Button();
            this.grpBoxNewProperty = new System.Windows.Forms.GroupBox();
            this.lblRequiredField = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAsterix = new System.Windows.Forms.Label();
            this.lblAvailability = new System.Windows.Forms.Label();
            this.txtAvailability = new System.Windows.Forms.TextBox();
            this.lblMinNumNights = new System.Windows.Forms.Label();
            this.txtMinNumNights = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.txtRoomType = new System.Windows.Forms.TextBox();
            this.txtLongitude = new System.Windows.Forms.TextBox();
            this.lblLongitude = new System.Windows.Forms.Label();
            this.lblLatitude = new System.Windows.Forms.Label();
            this.txtLatitude = new System.Windows.Forms.TextBox();
            this.txtNumOfpropertiesForHost = new System.Windows.Forms.TextBox();
            this.lblNumPropertiesForHost = new System.Windows.Forms.Label();
            this.lblHostName = new System.Windows.Forms.Label();
            this.txtHostName = new System.Windows.Forms.TextBox();
            this.txtHostId = new System.Windows.Forms.TextBox();
            this.lblHostId = new System.Windows.Forms.Label();
            this.lblPropertyName = new System.Windows.Forms.Label();
            this.txtPropertyName = new System.Windows.Forms.TextBox();
            this.lblPropertyId = new System.Windows.Forms.Label();
            this.txtPropertyId = new System.Windows.Forms.TextBox();
            this.lblDistricts = new System.Windows.Forms.Label();
            this.lstDistricts = new System.Windows.Forms.ListBox();
            this.btnSaveDistrict = new System.Windows.Forms.Button();
            this.btnCancelDistric = new System.Windows.Forms.Button();
            this.grpBoxDistric = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.llbAsterix = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtNumNeighbrhdsInDistrict = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDistrictName = new System.Windows.Forms.TextBox();
            this.lblDistrictName = new System.Windows.Forms.Label();
            this.btnAddDistrict = new System.Windows.Forms.Button();
            this.btnAddNeighbrhd = new System.Windows.Forms.Button();
            this.btnAddProperty = new System.Windows.Forms.Button();
            this.btnCancelProperty = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDeleteProperty = new System.Windows.Forms.Button();
            this.grpBoxNeighbourhd.SuspendLayout();
            this.grpBoxNewProperty.SuspendLayout();
            this.grpBoxDistric.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstProperties
            // 
            this.lstProperties.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstProperties.FormattingEnabled = true;
            this.lstProperties.ItemHeight = 15;
            this.lstProperties.Location = new System.Drawing.Point(15, 635);
            this.lstProperties.Name = "lstProperties";
            this.lstProperties.Size = new System.Drawing.Size(1661, 349);
            this.lstProperties.TabIndex = 0;
            this.lstProperties.SelectedIndexChanged += new System.EventHandler(this.lstProperties_SelectedIndexChanged);
            // 
            // lblProperties
            // 
            this.lblProperties.AutoSize = true;
            this.lblProperties.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProperties.Location = new System.Drawing.Point(12, 605);
            this.lblProperties.Name = "lblProperties";
            this.lblProperties.Size = new System.Drawing.Size(85, 20);
            this.lblProperties.TabIndex = 1;
            this.lblProperties.Text = "Properties:";
            // 
            // lstNeighbrhd
            // 
            this.lstNeighbrhd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstNeighbrhd.FormattingEnabled = true;
            this.lstNeighbrhd.ItemHeight = 15;
            this.lstNeighbrhd.Location = new System.Drawing.Point(16, 390);
            this.lstNeighbrhd.Name = "lstNeighbrhd";
            this.lstNeighbrhd.Size = new System.Drawing.Size(378, 184);
            this.lstNeighbrhd.TabIndex = 2;
            this.lstNeighbrhd.SelectedIndexChanged += new System.EventHandler(this.lstNeighbrhd_SelectedIndexChanged);
            // 
            // lblNeighbrhd
            // 
            this.lblNeighbrhd.AutoSize = true;
            this.lblNeighbrhd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNeighbrhd.Location = new System.Drawing.Point(12, 361);
            this.lblNeighbrhd.Name = "lblNeighbrhd";
            this.lblNeighbrhd.Size = new System.Drawing.Size(130, 20);
            this.lblNeighbrhd.TabIndex = 3;
            this.lblNeighbrhd.Text = "Neighbourhoods:";
            // 
            // btnSaveNeighbrhd
            // 
            this.btnSaveNeighbrhd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveNeighbrhd.Location = new System.Drawing.Point(647, 534);
            this.btnSaveNeighbrhd.Name = "btnSaveNeighbrhd";
            this.btnSaveNeighbrhd.Size = new System.Drawing.Size(142, 31);
            this.btnSaveNeighbrhd.TabIndex = 45;
            this.btnSaveNeighbrhd.Text = "Edit Neighbourhood";
            this.btnSaveNeighbrhd.UseVisualStyleBackColor = true;
            this.btnSaveNeighbrhd.Click += new System.EventHandler(this.btnSaveNeighbrhd_Click);
            // 
            // btnCancelNeighbrhd
            // 
            this.btnCancelNeighbrhd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelNeighbrhd.Location = new System.Drawing.Point(795, 534);
            this.btnCancelNeighbrhd.Name = "btnCancelNeighbrhd";
            this.btnCancelNeighbrhd.Size = new System.Drawing.Size(120, 31);
            this.btnCancelNeighbrhd.TabIndex = 44;
            this.btnCancelNeighbrhd.Text = "Cancel / Reset";
            this.btnCancelNeighbrhd.UseVisualStyleBackColor = true;
            this.btnCancelNeighbrhd.Click += new System.EventHandler(this.btnCancelNeighbrhd_Click);
            // 
            // grpBoxNeighbourhd
            // 
            this.grpBoxNeighbourhd.BackColor = System.Drawing.SystemColors.Control;
            this.grpBoxNeighbourhd.Controls.Add(this.lblRequired);
            this.grpBoxNeighbourhd.Controls.Add(this.label12);
            this.grpBoxNeighbourhd.Controls.Add(this.label11);
            this.grpBoxNeighbourhd.Controls.Add(this.txtNumPropertiesInNeighbrhd);
            this.grpBoxNeighbourhd.Controls.Add(this.txtNeighbourhdName);
            this.grpBoxNeighbourhd.Controls.Add(this.lblNumPropertiesInNeighbrhd);
            this.grpBoxNeighbourhd.Controls.Add(this.lblNeighbourhdName);
            this.grpBoxNeighbourhd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxNeighbourhd.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.grpBoxNeighbourhd.Location = new System.Drawing.Point(462, 416);
            this.grpBoxNeighbourhd.Name = "grpBoxNeighbourhd";
            this.grpBoxNeighbourhd.Size = new System.Drawing.Size(453, 112);
            this.grpBoxNeighbourhd.TabIndex = 43;
            this.grpBoxNeighbourhd.TabStop = false;
            this.grpBoxNeighbourhd.Text = "Please enter new NEIGHBOURHOOD details";
            // 
            // lblRequired
            // 
            this.lblRequired.AutoSize = true;
            this.lblRequired.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequired.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRequired.Location = new System.Drawing.Point(351, 94);
            this.lblRequired.Name = "lblRequired";
            this.lblRequired.Size = new System.Drawing.Size(96, 15);
            this.lblRequired.TabIndex = 37;
            this.lblRequired.Text = "* Required Field";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(297, 54);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 17);
            this.label12.TabIndex = 36;
            this.label12.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(426, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 17);
            this.label11.TabIndex = 35;
            this.label11.Text = "*";
            // 
            // txtNumPropertiesInNeighbrhd
            // 
            this.txtNumPropertiesInNeighbrhd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumPropertiesInNeighbrhd.Location = new System.Drawing.Point(249, 54);
            this.txtNumPropertiesInNeighbrhd.Name = "txtNumPropertiesInNeighbrhd";
            this.txtNumPropertiesInNeighbrhd.Size = new System.Drawing.Size(42, 23);
            this.txtNumPropertiesInNeighbrhd.TabIndex = 34;
            // 
            // txtNeighbourhdName
            // 
            this.txtNeighbourhdName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNeighbourhdName.Location = new System.Drawing.Point(249, 24);
            this.txtNeighbourhdName.Name = "txtNeighbourhdName";
            this.txtNeighbourhdName.Size = new System.Drawing.Size(167, 23);
            this.txtNeighbourhdName.TabIndex = 31;
            // 
            // lblNumPropertiesInNeighbrhd
            // 
            this.lblNumPropertiesInNeighbrhd.AutoSize = true;
            this.lblNumPropertiesInNeighbrhd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumPropertiesInNeighbrhd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNumPropertiesInNeighbrhd.Location = new System.Drawing.Point(11, 57);
            this.lblNumPropertiesInNeighbrhd.Name = "lblNumPropertiesInNeighbrhd";
            this.lblNumPropertiesInNeighbrhd.Size = new System.Drawing.Size(236, 17);
            this.lblNumPropertiesInNeighbrhd.TabIndex = 33;
            this.lblNumPropertiesInNeighbrhd.Text = "No. of Properties in Neighbourhood:";
            // 
            // lblNeighbourhdName
            // 
            this.lblNeighbourhdName.AutoSize = true;
            this.lblNeighbourhdName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNeighbourhdName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNeighbourhdName.Location = new System.Drawing.Point(96, 24);
            this.lblNeighbourhdName.Name = "lblNeighbourhdName";
            this.lblNeighbourhdName.Size = new System.Drawing.Size(151, 17);
            this.lblNeighbourhdName.TabIndex = 32;
            this.lblNeighbourhdName.Text = "Neighbourhood Name:";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Black;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExit.Location = new System.Drawing.Point(202, 104);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 34);
            this.btnExit.TabIndex = 47;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSaveProperty
            // 
            this.btnSaveProperty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveProperty.Location = new System.Drawing.Point(1414, 542);
            this.btnSaveProperty.Name = "btnSaveProperty";
            this.btnSaveProperty.Size = new System.Drawing.Size(119, 29);
            this.btnSaveProperty.TabIndex = 50;
            this.btnSaveProperty.Text = "Edit Property";
            this.btnSaveProperty.UseVisualStyleBackColor = true;
            this.btnSaveProperty.Click += new System.EventHandler(this.btnSaveProperty_Click);
            // 
            // grpBoxNewProperty
            // 
            this.grpBoxNewProperty.BackColor = System.Drawing.SystemColors.Control;
            this.grpBoxNewProperty.Controls.Add(this.lblRequiredField);
            this.grpBoxNewProperty.Controls.Add(this.label10);
            this.grpBoxNewProperty.Controls.Add(this.label9);
            this.grpBoxNewProperty.Controls.Add(this.label8);
            this.grpBoxNewProperty.Controls.Add(this.label7);
            this.grpBoxNewProperty.Controls.Add(this.label6);
            this.grpBoxNewProperty.Controls.Add(this.label5);
            this.grpBoxNewProperty.Controls.Add(this.label4);
            this.grpBoxNewProperty.Controls.Add(this.label3);
            this.grpBoxNewProperty.Controls.Add(this.label2);
            this.grpBoxNewProperty.Controls.Add(this.label1);
            this.grpBoxNewProperty.Controls.Add(this.lblAsterix);
            this.grpBoxNewProperty.Controls.Add(this.lblAvailability);
            this.grpBoxNewProperty.Controls.Add(this.txtAvailability);
            this.grpBoxNewProperty.Controls.Add(this.lblMinNumNights);
            this.grpBoxNewProperty.Controls.Add(this.txtMinNumNights);
            this.grpBoxNewProperty.Controls.Add(this.txtPrice);
            this.grpBoxNewProperty.Controls.Add(this.lblPrice);
            this.grpBoxNewProperty.Controls.Add(this.lblRoomType);
            this.grpBoxNewProperty.Controls.Add(this.txtRoomType);
            this.grpBoxNewProperty.Controls.Add(this.txtLongitude);
            this.grpBoxNewProperty.Controls.Add(this.lblLongitude);
            this.grpBoxNewProperty.Controls.Add(this.lblLatitude);
            this.grpBoxNewProperty.Controls.Add(this.txtLatitude);
            this.grpBoxNewProperty.Controls.Add(this.txtNumOfpropertiesForHost);
            this.grpBoxNewProperty.Controls.Add(this.lblNumPropertiesForHost);
            this.grpBoxNewProperty.Controls.Add(this.lblHostName);
            this.grpBoxNewProperty.Controls.Add(this.txtHostName);
            this.grpBoxNewProperty.Controls.Add(this.txtHostId);
            this.grpBoxNewProperty.Controls.Add(this.lblHostId);
            this.grpBoxNewProperty.Controls.Add(this.lblPropertyName);
            this.grpBoxNewProperty.Controls.Add(this.txtPropertyName);
            this.grpBoxNewProperty.Controls.Add(this.lblPropertyId);
            this.grpBoxNewProperty.Controls.Add(this.txtPropertyId);
            this.grpBoxNewProperty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpBoxNewProperty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxNewProperty.ForeColor = System.Drawing.SystemColors.Highlight;
            this.grpBoxNewProperty.Location = new System.Drawing.Point(1260, 203);
            this.grpBoxNewProperty.Name = "grpBoxNewProperty";
            this.grpBoxNewProperty.Size = new System.Drawing.Size(398, 333);
            this.grpBoxNewProperty.TabIndex = 48;
            this.grpBoxNewProperty.TabStop = false;
            this.grpBoxNewProperty.Text = "Please enter new PROPERTY details";
            // 
            // lblRequiredField
            // 
            this.lblRequiredField.AutoSize = true;
            this.lblRequiredField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequiredField.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRequiredField.Location = new System.Drawing.Point(301, 304);
            this.lblRequiredField.Name = "lblRequiredField";
            this.lblRequiredField.Size = new System.Drawing.Size(96, 15);
            this.lblRequiredField.TabIndex = 39;
            this.lblRequiredField.Text = "* Required Field";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(249, 288);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(12, 15);
            this.label10.TabIndex = 38;
            this.label10.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(212, 265);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(12, 15);
            this.label9.TabIndex = 37;
            this.label9.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(248, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(12, 15);
            this.label8.TabIndex = 36;
            this.label8.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(322, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 17);
            this.label7.TabIndex = 35;
            this.label7.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(299, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 17);
            this.label6.TabIndex = 34;
            this.label6.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(299, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 17);
            this.label5.TabIndex = 33;
            this.label5.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(209, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 15);
            this.label4.TabIndex = 32;
            this.label4.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(299, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 17);
            this.label3.TabIndex = 31;
            this.label3.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(245, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 15);
            this.label2.TabIndex = 30;
            this.label2.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(378, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 17);
            this.label1.TabIndex = 29;
            this.label1.Text = "*";
            // 
            // lblAsterix
            // 
            this.lblAsterix.AutoSize = true;
            this.lblAsterix.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsterix.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAsterix.Location = new System.Drawing.Point(245, 22);
            this.lblAsterix.Name = "lblAsterix";
            this.lblAsterix.Size = new System.Drawing.Size(12, 15);
            this.lblAsterix.TabIndex = 28;
            this.lblAsterix.Text = "*";
            // 
            // lblAvailability
            // 
            this.lblAvailability.AutoSize = true;
            this.lblAvailability.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailability.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAvailability.Location = new System.Drawing.Point(31, 288);
            this.lblAvailability.Name = "lblAvailability";
            this.lblAvailability.Size = new System.Drawing.Size(122, 15);
            this.lblAvailability.TabIndex = 27;
            this.lblAvailability.Text = "No. of Available days:";
            // 
            // txtAvailability
            // 
            this.txtAvailability.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAvailability.Location = new System.Drawing.Point(159, 289);
            this.txtAvailability.Name = "txtAvailability";
            this.txtAvailability.Size = new System.Drawing.Size(84, 21);
            this.txtAvailability.TabIndex = 26;
            // 
            // lblMinNumNights
            // 
            this.lblMinNumNights.AutoSize = true;
            this.lblMinNumNights.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinNumNights.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMinNumNights.Location = new System.Drawing.Point(14, 268);
            this.lblMinNumNights.Name = "lblMinNumNights";
            this.lblMinNumNights.Size = new System.Drawing.Size(134, 15);
            this.lblMinNumNights.TabIndex = 25;
            this.lblMinNumNights.Text = "Minimum no. of Nights:";
            // 
            // txtMinNumNights
            // 
            this.txtMinNumNights.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinNumNights.Location = new System.Drawing.Point(159, 265);
            this.txtMinNumNights.Name = "txtMinNumNights";
            this.txtMinNumNights.Size = new System.Drawing.Size(47, 21);
            this.txtMinNumNights.TabIndex = 24;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(158, 240);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(84, 21);
            this.txtPrice.TabIndex = 23;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPrice.Location = new System.Drawing.Point(92, 243);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(56, 15);
            this.lblPrice.TabIndex = 22;
            this.lblPrice.Text = "Price (£):";
            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomType.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRoomType.Location = new System.Drawing.Point(77, 216);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(73, 15);
            this.lblRoomType.TabIndex = 21;
            this.lblRoomType.Text = "Room Type:";
            // 
            // txtRoomType
            // 
            this.txtRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomType.Location = new System.Drawing.Point(158, 213);
            this.txtRoomType.Name = "txtRoomType";
            this.txtRoomType.Size = new System.Drawing.Size(158, 21);
            this.txtRoomType.TabIndex = 20;
            // 
            // txtLongitude
            // 
            this.txtLongitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLongitude.Location = new System.Drawing.Point(158, 186);
            this.txtLongitude.Name = "txtLongitude";
            this.txtLongitude.Size = new System.Drawing.Size(135, 21);
            this.txtLongitude.TabIndex = 19;
            // 
            // lblLongitude
            // 
            this.lblLongitude.AutoSize = true;
            this.lblLongitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLongitude.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLongitude.Location = new System.Drawing.Point(86, 189);
            this.lblLongitude.Name = "lblLongitude";
            this.lblLongitude.Size = new System.Drawing.Size(65, 15);
            this.lblLongitude.TabIndex = 18;
            this.lblLongitude.Text = "Longitude:";
            // 
            // lblLatitude
            // 
            this.lblLatitude.AutoSize = true;
            this.lblLatitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLatitude.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLatitude.Location = new System.Drawing.Point(97, 165);
            this.lblLatitude.Name = "lblLatitude";
            this.lblLatitude.Size = new System.Drawing.Size(54, 15);
            this.lblLatitude.TabIndex = 17;
            this.lblLatitude.Text = "Latitude:";
            // 
            // txtLatitude
            // 
            this.txtLatitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLatitude.Location = new System.Drawing.Point(157, 159);
            this.txtLatitude.Name = "txtLatitude";
            this.txtLatitude.Size = new System.Drawing.Size(136, 21);
            this.txtLatitude.TabIndex = 16;
            // 
            // txtNumOfpropertiesForHost
            // 
            this.txtNumOfpropertiesForHost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumOfpropertiesForHost.Location = new System.Drawing.Point(156, 132);
            this.txtNumOfpropertiesForHost.Name = "txtNumOfpropertiesForHost";
            this.txtNumOfpropertiesForHost.Size = new System.Drawing.Size(47, 21);
            this.txtNumOfpropertiesForHost.TabIndex = 15;
            // 
            // lblNumPropertiesForHost
            // 
            this.lblNumPropertiesForHost.AutoSize = true;
            this.lblNumPropertiesForHost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumPropertiesForHost.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNumPropertiesForHost.Location = new System.Drawing.Point(4, 135);
            this.lblNumPropertiesForHost.Name = "lblNumPropertiesForHost";
            this.lblNumPropertiesForHost.Size = new System.Drawing.Size(146, 15);
            this.lblNumPropertiesForHost.TabIndex = 14;
            this.lblNumPropertiesForHost.Text = "No. of Properties for Host:";
            // 
            // lblHostName
            // 
            this.lblHostName.AutoSize = true;
            this.lblHostName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHostName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblHostName.Location = new System.Drawing.Point(78, 105);
            this.lblHostName.Name = "lblHostName";
            this.lblHostName.Size = new System.Drawing.Size(72, 15);
            this.lblHostName.TabIndex = 13;
            this.lblHostName.Text = "Host Name:";
            // 
            // txtHostName
            // 
            this.txtHostName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHostName.Location = new System.Drawing.Point(156, 105);
            this.txtHostName.Name = "txtHostName";
            this.txtHostName.Size = new System.Drawing.Size(137, 21);
            this.txtHostName.TabIndex = 12;
            // 
            // txtHostId
            // 
            this.txtHostId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHostId.Location = new System.Drawing.Point(156, 78);
            this.txtHostId.Name = "txtHostId";
            this.txtHostId.Size = new System.Drawing.Size(84, 21);
            this.txtHostId.TabIndex = 11;
            // 
            // lblHostId
            // 
            this.lblHostId.AutoSize = true;
            this.lblHostId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHostId.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblHostId.Location = new System.Drawing.Point(97, 84);
            this.lblHostId.Name = "lblHostId";
            this.lblHostId.Size = new System.Drawing.Size(50, 15);
            this.lblHostId.TabIndex = 10;
            this.lblHostId.Text = "Host ID:";
            // 
            // lblPropertyName
            // 
            this.lblPropertyName.AutoSize = true;
            this.lblPropertyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPropertyName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPropertyName.Location = new System.Drawing.Point(58, 57);
            this.lblPropertyName.Name = "lblPropertyName";
            this.lblPropertyName.Size = new System.Drawing.Size(92, 15);
            this.lblPropertyName.TabIndex = 9;
            this.lblPropertyName.Text = "Property Name:";
            // 
            // txtPropertyName
            // 
            this.txtPropertyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPropertyName.Location = new System.Drawing.Point(156, 54);
            this.txtPropertyName.Name = "txtPropertyName";
            this.txtPropertyName.Size = new System.Drawing.Size(216, 21);
            this.txtPropertyName.TabIndex = 8;
            // 
            // lblPropertyId
            // 
            this.lblPropertyId.AutoSize = true;
            this.lblPropertyId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPropertyId.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPropertyId.Location = new System.Drawing.Point(81, 27);
            this.lblPropertyId.Name = "lblPropertyId";
            this.lblPropertyId.Size = new System.Drawing.Size(70, 15);
            this.lblPropertyId.TabIndex = 7;
            this.lblPropertyId.Text = "Property ID:";
            // 
            // txtPropertyId
            // 
            this.txtPropertyId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPropertyId.Location = new System.Drawing.Point(156, 24);
            this.txtPropertyId.Name = "txtPropertyId";
            this.txtPropertyId.Size = new System.Drawing.Size(83, 21);
            this.txtPropertyId.TabIndex = 6;
            // 
            // lblDistricts
            // 
            this.lblDistricts.AutoSize = true;
            this.lblDistricts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistricts.Location = new System.Drawing.Point(11, 153);
            this.lblDistricts.Name = "lblDistricts";
            this.lblDistricts.Size = new System.Drawing.Size(70, 20);
            this.lblDistricts.TabIndex = 51;
            this.lblDistricts.Text = "Districts:";
            // 
            // lstDistricts
            // 
            this.lstDistricts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDistricts.FormattingEnabled = true;
            this.lstDistricts.ItemHeight = 15;
            this.lstDistricts.Location = new System.Drawing.Point(15, 185);
            this.lstDistricts.Name = "lstDistricts";
            this.lstDistricts.Size = new System.Drawing.Size(379, 154);
            this.lstDistricts.TabIndex = 52;
            this.lstDistricts.SelectedIndexChanged += new System.EventHandler(this.lstDistricts_SelectedIndexChanged);
            // 
            // btnSaveDistrict
            // 
            this.btnSaveDistrict.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveDistrict.Location = new System.Drawing.Point(714, 322);
            this.btnSaveDistrict.Name = "btnSaveDistrict";
            this.btnSaveDistrict.Size = new System.Drawing.Size(89, 34);
            this.btnSaveDistrict.TabIndex = 55;
            this.btnSaveDistrict.Text = "Edit District";
            this.btnSaveDistrict.UseVisualStyleBackColor = true;
            this.btnSaveDistrict.Click += new System.EventHandler(this.btnSaveDistrict_Click);
            // 
            // btnCancelDistric
            // 
            this.btnCancelDistric.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelDistric.Location = new System.Drawing.Point(809, 322);
            this.btnCancelDistric.Name = "btnCancelDistric";
            this.btnCancelDistric.Size = new System.Drawing.Size(122, 34);
            this.btnCancelDistric.TabIndex = 54;
            this.btnCancelDistric.Text = "Cancel / Reset";
            this.btnCancelDistric.UseVisualStyleBackColor = true;
            this.btnCancelDistric.Click += new System.EventHandler(this.BtnCancelDistric_Click);
            // 
            // grpBoxDistric
            // 
            this.grpBoxDistric.BackColor = System.Drawing.SystemColors.Control;
            this.grpBoxDistric.Controls.Add(this.label16);
            this.grpBoxDistric.Controls.Add(this.llbAsterix);
            this.grpBoxDistric.Controls.Add(this.label14);
            this.grpBoxDistric.Controls.Add(this.txtNumNeighbrhdsInDistrict);
            this.grpBoxDistric.Controls.Add(this.label13);
            this.grpBoxDistric.Controls.Add(this.txtDistrictName);
            this.grpBoxDistric.Controls.Add(this.lblDistrictName);
            this.grpBoxDistric.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxDistric.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.grpBoxDistric.Location = new System.Drawing.Point(462, 203);
            this.grpBoxDistric.Name = "grpBoxDistric";
            this.grpBoxDistric.Size = new System.Drawing.Size(469, 108);
            this.grpBoxDistric.TabIndex = 53;
            this.grpBoxDistric.TabStop = false;
            this.grpBoxDistric.Text = "Please enter new DISTRICT details";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label16.Location = new System.Drawing.Point(239, 90);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(96, 15);
            this.label16.TabIndex = 42;
            this.label16.Text = "* Required Field";
            // 
            // llbAsterix
            // 
            this.llbAsterix.AutoSize = true;
            this.llbAsterix.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbAsterix.ForeColor = System.Drawing.SystemColors.ControlText;
            this.llbAsterix.Location = new System.Drawing.Point(298, 55);
            this.llbAsterix.Name = "llbAsterix";
            this.llbAsterix.Size = new System.Drawing.Size(13, 17);
            this.llbAsterix.TabIndex = 41;
            this.llbAsterix.Text = "*";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label14.Location = new System.Drawing.Point(450, 30);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(13, 17);
            this.label14.TabIndex = 40;
            this.label14.Text = "*";
            // 
            // txtNumNeighbrhdsInDistrict
            // 
            this.txtNumNeighbrhdsInDistrict.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumNeighbrhdsInDistrict.Location = new System.Drawing.Point(254, 55);
            this.txtNumNeighbrhdsInDistrict.Name = "txtNumNeighbrhdsInDistrict";
            this.txtNumNeighbrhdsInDistrict.Size = new System.Drawing.Size(42, 23);
            this.txtNumNeighbrhdsInDistrict.TabIndex = 39;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label13.Location = new System.Drawing.Point(20, 58);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(228, 17);
            this.label13.TabIndex = 38;
            this.label13.Text = "No. of Neighbourhoods in Disctrict:";
            // 
            // txtDistrictName
            // 
            this.txtDistrictName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDistrictName.Location = new System.Drawing.Point(253, 29);
            this.txtDistrictName.Name = "txtDistrictName";
            this.txtDistrictName.Size = new System.Drawing.Size(193, 23);
            this.txtDistrictName.TabIndex = 37;
            // 
            // lblDistrictName
            // 
            this.lblDistrictName.AutoSize = true;
            this.lblDistrictName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistrictName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDistrictName.Location = new System.Drawing.Point(156, 29);
            this.lblDistrictName.Name = "lblDistrictName";
            this.lblDistrictName.Size = new System.Drawing.Size(92, 17);
            this.lblDistrictName.TabIndex = 36;
            this.lblDistrictName.Text = "Distric Name:";
            // 
            // btnAddDistrict
            // 
            this.btnAddDistrict.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDistrict.Location = new System.Drawing.Point(619, 322);
            this.btnAddDistrict.Name = "btnAddDistrict";
            this.btnAddDistrict.Size = new System.Drawing.Size(89, 34);
            this.btnAddDistrict.TabIndex = 56;
            this.btnAddDistrict.Text = "Add District";
            this.btnAddDistrict.UseVisualStyleBackColor = true;
            this.btnAddDistrict.Click += new System.EventHandler(this.btnAddDistrict_Click);
            // 
            // btnAddNeighbrhd
            // 
            this.btnAddNeighbrhd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNeighbrhd.Location = new System.Drawing.Point(498, 534);
            this.btnAddNeighbrhd.Name = "btnAddNeighbrhd";
            this.btnAddNeighbrhd.Size = new System.Drawing.Size(143, 31);
            this.btnAddNeighbrhd.TabIndex = 57;
            this.btnAddNeighbrhd.Text = "Add Neighbourhood";
            this.btnAddNeighbrhd.UseVisualStyleBackColor = true;
            this.btnAddNeighbrhd.Click += new System.EventHandler(this.btnAddNeighbrhd_Click);
            // 
            // btnAddProperty
            // 
            this.btnAddProperty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProperty.Location = new System.Drawing.Point(1309, 542);
            this.btnAddProperty.Name = "btnAddProperty";
            this.btnAddProperty.Size = new System.Drawing.Size(99, 29);
            this.btnAddProperty.TabIndex = 58;
            this.btnAddProperty.Text = "Add Property";
            this.btnAddProperty.UseVisualStyleBackColor = true;
            this.btnAddProperty.Click += new System.EventHandler(this.btnAddProperty_Click);
            // 
            // btnCancelProperty
            // 
            this.btnCancelProperty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelProperty.Location = new System.Drawing.Point(1535, 541);
            this.btnCancelProperty.Name = "btnCancelProperty";
            this.btnCancelProperty.Size = new System.Drawing.Size(120, 31);
            this.btnCancelProperty.TabIndex = 59;
            this.btnCancelProperty.Text = "Cancel / Reset";
            this.btnCancelProperty.UseVisualStyleBackColor = true;
            this.btnCancelProperty.Click += new System.EventHandler(this.btnCancelProperty_Click_1);
            // 
            // txtSearch
            // 
            this.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(16, 50);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(191, 23);
            this.txtSearch.TabIndex = 60;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(213, 43);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(81, 37);
            this.btnSearch.TabIndex = 61;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDeleteProperty
            // 
            this.btnDeleteProperty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteProperty.Location = new System.Drawing.Point(1181, 542);
            this.btnDeleteProperty.Name = "btnDeleteProperty";
            this.btnDeleteProperty.Size = new System.Drawing.Size(122, 30);
            this.btnDeleteProperty.TabIndex = 62;
            this.btnDeleteProperty.Text = "Delete Property";
            this.btnDeleteProperty.UseVisualStyleBackColor = true;
            this.btnDeleteProperty.Click += new System.EventHandler(this.BtnDeleteProperty_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1701, 1011);
            this.Controls.Add(this.btnDeleteProperty);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnCancelProperty);
            this.Controls.Add(this.btnAddProperty);
            this.Controls.Add(this.btnAddNeighbrhd);
            this.Controls.Add(this.btnAddDistrict);
            this.Controls.Add(this.btnSaveDistrict);
            this.Controls.Add(this.btnCancelDistric);
            this.Controls.Add(this.grpBoxDistric);
            this.Controls.Add(this.lstDistricts);
            this.Controls.Add(this.lblDistricts);
            this.Controls.Add(this.btnSaveProperty);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSaveNeighbrhd);
            this.Controls.Add(this.btnCancelNeighbrhd);
            this.Controls.Add(this.grpBoxNewProperty);
            this.Controls.Add(this.grpBoxNeighbourhd);
            this.Controls.Add(this.lblNeighbrhd);
            this.Controls.Add(this.lstNeighbrhd);
            this.Controls.Add(this.lblProperties);
            this.Controls.Add(this.lstProperties);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grpBoxNeighbourhd.ResumeLayout(false);
            this.grpBoxNeighbourhd.PerformLayout();
            this.grpBoxNewProperty.ResumeLayout(false);
            this.grpBoxNewProperty.PerformLayout();
            this.grpBoxDistric.ResumeLayout(false);
            this.grpBoxDistric.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstProperties;
        private System.Windows.Forms.Label lblProperties;
        private System.Windows.Forms.ListBox lstNeighbrhd;
        private System.Windows.Forms.Label lblNeighbrhd;
        private System.Windows.Forms.Button btnSaveNeighbrhd;
        private System.Windows.Forms.Button btnCancelNeighbrhd;
        private System.Windows.Forms.GroupBox grpBoxNeighbourhd;
        private System.Windows.Forms.Label lblRequired;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNumPropertiesInNeighbrhd;
        private System.Windows.Forms.TextBox txtNeighbourhdName;
        private System.Windows.Forms.Label lblNumPropertiesInNeighbrhd;
        private System.Windows.Forms.Label lblNeighbourhdName;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSaveProperty;
        private System.Windows.Forms.GroupBox grpBoxNewProperty;
        private System.Windows.Forms.Label lblRequiredField;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAsterix;
        private System.Windows.Forms.Label lblAvailability;
        private System.Windows.Forms.TextBox txtAvailability;
        private System.Windows.Forms.Label lblMinNumNights;
        private System.Windows.Forms.TextBox txtMinNumNights;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.TextBox txtRoomType;
        private System.Windows.Forms.TextBox txtLongitude;
        private System.Windows.Forms.Label lblLongitude;
        private System.Windows.Forms.Label lblLatitude;
        private System.Windows.Forms.TextBox txtLatitude;
        private System.Windows.Forms.TextBox txtNumOfpropertiesForHost;
        private System.Windows.Forms.Label lblNumPropertiesForHost;
        private System.Windows.Forms.Label lblHostName;
        private System.Windows.Forms.TextBox txtHostName;
        private System.Windows.Forms.TextBox txtHostId;
        private System.Windows.Forms.Label lblHostId;
        private System.Windows.Forms.Label lblPropertyName;
        private System.Windows.Forms.TextBox txtPropertyName;
        private System.Windows.Forms.Label lblPropertyId;
        private System.Windows.Forms.TextBox txtPropertyId;
        private System.Windows.Forms.Label lblDistricts;
        private System.Windows.Forms.ListBox lstDistricts;
        private System.Windows.Forms.Button btnSaveDistrict;
        private System.Windows.Forms.Button btnCancelDistric;
        private System.Windows.Forms.GroupBox grpBoxDistric;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label llbAsterix;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtNumNeighbrhdsInDistrict;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtDistrictName;
        private System.Windows.Forms.Label lblDistrictName;
        private System.Windows.Forms.Button btnAddDistrict;
        private System.Windows.Forms.Button btnAddNeighbrhd;
        private System.Windows.Forms.Button btnAddProperty;
        private System.Windows.Forms.Button btnCancelProperty;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDeleteProperty;
    }
}

