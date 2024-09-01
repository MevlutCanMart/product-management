namespace ProductManagement
{
    partial class FormProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProducts));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxItemName = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.numericUpDownPrice = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownStockQuantity = new System.Windows.Forms.NumericUpDown();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.colorDialog3 = new System.Windows.Forms.ColorDialog();
            this.textBoxImageUrl = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonLoadImage = new System.Windows.Forms.Button();
            this.comboBoxColor = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_Weight = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxMaterial = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxTaxGroup = new System.Windows.Forms.ComboBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxBarcode = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxBarcodeType = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBoxBrand = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxDiscount = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBoxFeatured = new System.Windows.Forms.CheckBox();
            this.textBoxLocation = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBoxRating = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.textBoxTaxRate = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStockQuantity)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(226)))), ((int)(((byte)(181)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(42, 372);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1216, 289);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(18, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Item Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(321, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Item Description";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(23, 101);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Item Price";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(332, 101);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Stock Quantity";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBoxItemName
            // 
            this.textBoxItemName.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxItemName.Location = new System.Drawing.Point(114, 55);
            this.textBoxItemName.Name = "textBoxItemName";
            this.textBoxItemName.Size = new System.Drawing.Size(174, 25);
            this.textBoxItemName.TabIndex = 7;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxDescription.Location = new System.Drawing.Point(448, 55);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(174, 25);
            this.textBoxDescription.TabIndex = 8;
            // 
            // numericUpDownPrice
            // 
            this.numericUpDownPrice.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericUpDownPrice.Location = new System.Drawing.Point(114, 93);
            this.numericUpDownPrice.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numericUpDownPrice.Name = "numericUpDownPrice";
            this.numericUpDownPrice.Size = new System.Drawing.Size(174, 25);
            this.numericUpDownPrice.TabIndex = 11;
            this.numericUpDownPrice.ValueChanged += new System.EventHandler(this.numericUpDownPrice_ValueChanged);
            // 
            // numericUpDownStockQuantity
            // 
            this.numericUpDownStockQuantity.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericUpDownStockQuantity.Location = new System.Drawing.Point(448, 93);
            this.numericUpDownStockQuantity.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.numericUpDownStockQuantity.Name = "numericUpDownStockQuantity";
            this.numericUpDownStockQuantity.Size = new System.Drawing.Size(174, 25);
            this.numericUpDownStockQuantity.TabIndex = 12;
            // 
            // textBoxImageUrl
            // 
            this.textBoxImageUrl.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxImageUrl.Location = new System.Drawing.Point(1004, 197);
            this.textBoxImageUrl.Name = "textBoxImageUrl";
            this.textBoxImageUrl.Size = new System.Drawing.Size(194, 24);
            this.textBoxImageUrl.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(926, 203);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 18);
            this.label7.TabIndex = 20;
            this.label7.Text = "Image Url";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // buttonLoadImage
            // 
            this.buttonLoadImage.BackColor = System.Drawing.Color.Transparent;
            this.buttonLoadImage.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonLoadImage.ForeColor = System.Drawing.Color.Black;
            this.buttonLoadImage.Location = new System.Drawing.Point(1055, 227);
            this.buttonLoadImage.Name = "buttonLoadImage";
            this.buttonLoadImage.Size = new System.Drawing.Size(89, 27);
            this.buttonLoadImage.TabIndex = 21;
            this.buttonLoadImage.Text = "Upload";
            this.buttonLoadImage.UseVisualStyleBackColor = false;
            this.buttonLoadImage.Click += new System.EventHandler(this.buttonLoadImage_Click);
            // 
            // comboBoxColor
            // 
            this.comboBoxColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxColor.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxColor.FormattingEnabled = true;
            this.comboBoxColor.Location = new System.Drawing.Point(114, 131);
            this.comboBoxColor.Name = "comboBoxColor";
            this.comboBoxColor.Size = new System.Drawing.Size(174, 25);
            this.comboBoxColor.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(54, 139);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 17);
            this.label8.TabIndex = 23;
            this.label8.Text = "Color";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(381, 139);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 17);
            this.label9.TabIndex = 24;
            this.label9.Text = "Weight";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // textBox_Weight
            // 
            this.textBox_Weight.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_Weight.Location = new System.Drawing.Point(448, 131);
            this.textBox_Weight.Name = "textBox_Weight";
            this.textBox_Weight.Size = new System.Drawing.Size(174, 25);
            this.textBox_Weight.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(39, 178);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 17);
            this.label10.TabIndex = 26;
            this.label10.Text = "Material";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // comboBoxMaterial
            // 
            this.comboBoxMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMaterial.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxMaterial.FormattingEnabled = true;
            this.comboBoxMaterial.Location = new System.Drawing.Point(114, 170);
            this.comboBoxMaterial.Name = "comboBoxMaterial";
            this.comboBoxMaterial.Size = new System.Drawing.Size(174, 25);
            this.comboBoxMaterial.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(385, 176);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 17);
            this.label11.TabIndex = 28;
            this.label11.Text = "Status";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStatus.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(448, 170);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(174, 25);
            this.comboBoxStatus.TabIndex = 29;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.textBoxTaxRate);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.comboBoxTaxGroup);
            this.groupBox1.Controls.Add(this.buttonUpdate);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.buttonDelete);
            this.groupBox1.Controls.Add(this.buttonAdd);
            this.groupBox1.Controls.Add(this.textBoxBarcode);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.textBoxBarcodeType);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.comboBoxBrand);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.comboBoxDiscount);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.checkBoxFeatured);
            this.groupBox1.Controls.Add(this.textBoxLocation);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.comboBoxRating);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.textBoxItemName);
            this.groupBox1.Controls.Add(this.pictureBoxImage);
            this.groupBox1.Controls.Add(this.buttonLoadImage);
            this.groupBox1.Controls.Add(this.comboBoxStatus);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.textBoxImageUrl);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBoxMaterial);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox_Weight);
            this.groupBox1.Controls.Add(this.textBoxDescription);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.numericUpDownPrice);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.numericUpDownStockQuantity);
            this.groupBox1.Controls.Add(this.comboBoxColor);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(42, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1216, 345);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product Information";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // comboBoxTaxGroup
            // 
            this.comboBoxTaxGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTaxGroup.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxTaxGroup.FormattingEnabled = true;
            this.comboBoxTaxGroup.Location = new System.Drawing.Point(746, 131);
            this.comboBoxTaxGroup.Name = "comboBoxTaxGroup";
            this.comboBoxTaxGroup.Size = new System.Drawing.Size(174, 25);
            this.comboBoxTaxGroup.TabIndex = 45;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackgroundImage = global::ProductManagement.Properties.Resources.diskette;
            this.buttonUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonUpdate.Location = new System.Drawing.Point(1148, 274);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(50, 50);
            this.buttonUpdate.TabIndex = 17;
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click_1);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(621, 134);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(117, 17);
            this.label16.TabIndex = 44;
            this.label16.Text = "Tax Group Name";
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackgroundImage = global::ProductManagement.Properties.Resources.trash;
            this.buttonDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDelete.Location = new System.Drawing.Point(1077, 274);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(50, 50);
            this.buttonDelete.TabIndex = 16;
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click_1);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackgroundImage = global::ProductManagement.Properties.Resources.add_button;
            this.buttonAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAdd.Location = new System.Drawing.Point(1004, 274);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(50, 50);
            this.buttonAdd.TabIndex = 15;
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click_1);
            // 
            // textBoxBarcode
            // 
            this.textBoxBarcode.BackColor = System.Drawing.Color.White;
            this.textBoxBarcode.Enabled = false;
            this.textBoxBarcode.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxBarcode.Location = new System.Drawing.Point(746, 93);
            this.textBoxBarcode.Name = "textBoxBarcode";
            this.textBoxBarcode.ReadOnly = true;
            this.textBoxBarcode.Size = new System.Drawing.Size(174, 25);
            this.textBoxBarcode.TabIndex = 43;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(674, 96);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 17);
            this.label15.TabIndex = 42;
            this.label15.Text = "Barcode";
            // 
            // textBoxBarcodeType
            // 
            this.textBoxBarcodeType.Enabled = false;
            this.textBoxBarcodeType.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxBarcodeType.Location = new System.Drawing.Point(746, 55);
            this.textBoxBarcodeType.Name = "textBoxBarcodeType";
            this.textBoxBarcodeType.Size = new System.Drawing.Size(174, 25);
            this.textBoxBarcodeType.TabIndex = 41;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(639, 58);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 17);
            this.label14.TabIndex = 40;
            this.label14.Text = "Barcode Type";
            // 
            // comboBoxBrand
            // 
            this.comboBoxBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBrand.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxBrand.FormattingEnabled = true;
            this.comboBoxBrand.Location = new System.Drawing.Point(448, 242);
            this.comboBoxBrand.Name = "comboBoxBrand";
            this.comboBoxBrand.Size = new System.Drawing.Size(174, 25);
            this.comboBoxBrand.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(388, 250);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 37;
            this.label6.Text = "Brand";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // comboBoxDiscount
            // 
            this.comboBoxDiscount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDiscount.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxDiscount.FormattingEnabled = true;
            this.comboBoxDiscount.Location = new System.Drawing.Point(114, 206);
            this.comboBoxDiscount.Name = "comboBoxDiscount";
            this.comboBoxDiscount.Size = new System.Drawing.Size(174, 25);
            this.comboBoxDiscount.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(31, 214);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 17);
            this.label5.TabIndex = 35;
            this.label5.Text = "Discount";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // checkBoxFeatured
            // 
            this.checkBoxFeatured.AutoSize = true;
            this.checkBoxFeatured.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxFeatured.Location = new System.Drawing.Point(835, 318);
            this.checkBoxFeatured.Name = "checkBoxFeatured";
            this.checkBoxFeatured.Size = new System.Drawing.Size(85, 21);
            this.checkBoxFeatured.TabIndex = 34;
            this.checkBoxFeatured.Text = "Featured";
            this.checkBoxFeatured.UseVisualStyleBackColor = true;
            // 
            // textBoxLocation
            // 
            this.textBoxLocation.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxLocation.Location = new System.Drawing.Point(448, 209);
            this.textBoxLocation.Name = "textBoxLocation";
            this.textBoxLocation.Size = new System.Drawing.Size(174, 25);
            this.textBoxLocation.TabIndex = 33;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(372, 217);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 17);
            this.label13.TabIndex = 32;
            this.label13.Text = "Location";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // comboBoxRating
            // 
            this.comboBoxRating.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRating.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxRating.FormattingEnabled = true;
            this.comboBoxRating.Location = new System.Drawing.Point(114, 239);
            this.comboBoxRating.Name = "comboBoxRating";
            this.comboBoxRating.Size = new System.Drawing.Size(174, 25);
            this.comboBoxRating.TabIndex = 31;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(47, 247);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 17);
            this.label12.TabIndex = 30;
            this.label12.Text = "Rating";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.BackColor = System.Drawing.Color.White;
            this.pictureBoxImage.Location = new System.Drawing.Point(1004, 53);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(194, 138);
            this.pictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImage.TabIndex = 19;
            this.pictureBoxImage.TabStop = false;
            // 
            // textBoxTaxRate
            // 
            this.textBoxTaxRate.BackColor = System.Drawing.Color.White;
            this.textBoxTaxRate.Enabled = false;
            this.textBoxTaxRate.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxTaxRate.Location = new System.Drawing.Point(746, 170);
            this.textBoxTaxRate.Name = "textBoxTaxRate";
            this.textBoxTaxRate.ReadOnly = true;
            this.textBoxTaxRate.Size = new System.Drawing.Size(174, 25);
            this.textBoxTaxRate.TabIndex = 47;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.Location = new System.Drawing.Point(674, 176);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 17);
            this.label17.TabIndex = 46;
            this.label17.Text = "Tax Rate";
            // 
            // FormProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1298, 688);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormProducts";
            this.Text = "Product Management";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStockQuantity)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxItemName;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.NumericUpDown numericUpDownPrice;
        private System.Windows.Forms.NumericUpDown numericUpDownStockQuantity;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.ColorDialog colorDialog3;
        private System.Windows.Forms.TextBox textBoxImageUrl;
        private System.Windows.Forms.PictureBox pictureBoxImage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonLoadImage;
        private System.Windows.Forms.ComboBox comboBoxColor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_Weight;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxMaterial;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxRating;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxLocation;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox checkBoxFeatured;
        private System.Windows.Forms.ComboBox comboBoxDiscount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxBrand;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxBarcodeType;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxBarcode;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboBoxTaxGroup;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBoxTaxRate;
        private System.Windows.Forms.Label label17;
    }
}

