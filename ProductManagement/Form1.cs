using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using System.Collections.Generic;
using System.Collections;

namespace ProductManagement
{
    public partial class FormProducts : Form
    {
        private const string connectionString = "server=localhost\\SQLEXPRESS;Initial Catalog=Product;Integrated Security=True";
        private SqlCommand command;
        private SqlDataAdapter adapter;

        public FormProducts()
        {
            InitializeComponent();
            comboBoxColor.DrawItem += comboBoxColor_DrawItem;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            this.MaximizeBox = false;
            comboBoxTaxGroup.SelectedIndexChanged += ComboBoxTaxGroup_SelectedIndexChanged;
        }


        private void LoadData()
        {
            try
            {
                DataTable dataTable = GetData();
                BindDataToGrid(dataTable);
            }
            catch (Exception ex)
            {
                throw new Exception($"Veri yüklenirken hata oluştu :  {ex.Message}");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            LoadData();
            LoadTaxGroups();
            LoadUnitOfMeasure();
            InitializeFormSettings();
            InitializeComboBoxItems();
            
            this.MaximizeBox = false;

        }


        private void InitializeFormSettings()
        {
            this.MaximizeBox = false;

            dataGridView1.Columns["Price"].DefaultCellStyle.Format = "C2";
            dataGridView1.Columns["Weight"].DefaultCellStyle.Format = "0.## 'g'";
            textBoxBarcodeType.Text = "Ean13";
            
        }

        private void LoadTaxGroups()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // Vergi gruplarını almak için SQL sorgusu
                string query = "SELECT TaxGroupID, TaxGroupName FROM TaxGroup";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // ComboBox'ta görünen isim ve arka planda tutulan ID'yi ayarla
                comboBoxTaxGroup.DisplayMember = "TaxGroupName";
                comboBoxTaxGroup.ValueMember = "TaxGroupID";
                comboBoxTaxGroup.DataSource = dataTable;
            }
        }

        // Kullanıcı bir vergi grubu seçtiğinde tetiklenen olay
        private void ComboBoxTaxGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Seçilen vergi grubunun ID'sini kontrol et
            if (comboBoxTaxGroup.SelectedValue != null)
            {
                int selectedTaxGroupId = (int)comboBoxTaxGroup.SelectedValue;
                LoadTaxRate(selectedTaxGroupId); // Seçilen ID'ye göre vergi oranını yükle
            }
        }

        // Seçilen vergi grubuna ait vergi oranını alıp TextBox'ta gösterir
        private void LoadTaxRate(int taxGroupId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // Vergi oranını almak için SQL sorgusu
                string query = "SELECT TaxRate FROM TaxGroup WHERE TaxGroupID = @TaxGroupID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TaxGroupID", taxGroupId); // Sorgu parametresini ayarla
                conn.Open();
                object taxRate = cmd.ExecuteScalar(); // Vergi oranını al
                                                      // Vergi oranını TextBox'ta göster (Varsayılan değer: 0.00)
                textBoxTaxRate.Text = taxRate != null ? taxRate.ToString() : "0.00";
            }
        }


        private void LoadUnitOfMeasure()
        {
            string query = "SELECT UnitOfMeasureID, UnitOfMeasureName FROM UnitOfMeasure";

            using (SqlConnection con = new SqlConnection("Server=localhost\\SQLEXPRESS;Initial Catalog=Product;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                Dictionary<int, string> unitOfMeasures = new Dictionary<int, string>();

                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string name = reader.GetString(1);
                    unitOfMeasures.Add(id, name);
                }

                comboBoxUnitOfMeasureName.DataSource = new BindingSource(unitOfMeasures, null);
                comboBoxUnitOfMeasureName.DisplayMember = "Value";
                comboBoxUnitOfMeasureName.ValueMember = "Key";

                con.Close();
            }
        }

        



        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            // Eğer düzenlenmek istenen hücre CheckBox hücresiyse, düzenlemeyi iptal et
            if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn)
            {
                e.Cancel = true; // Düzenlemeyi iptal et
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var value = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                if (value == DBNull.Value || value == null)
                {
                    // Değer boş, bu nedenle işlem yapma
                    return;
                }

                // Değer boş değil, güvenle dönüştürme işlemi yapabilirsin
                int intValue = Convert.ToInt32(value); // Örnek dönüşüm
            }
        }


        private void InitializeComboBoxItems()
        {
            PopulateComboBox(comboBoxColor, new string[] { "Red", "Green", "Blue", "Yellow" });

            PopulateComboBox(comboBoxMaterial, new string[]
            {
                "Cotton - Pamuk", "Wool - Yün", "Satin - Saten", "Linen - Keten", "Velvet - Kadife",
                "Feather - Tüy", "Nylon - Naylon", "Microfiber - Microfiber", "Organic Cotton - Organik Pamuk",
                "Faux Leather - Yapay Deri"
            });

            PopulateComboBox(comboBoxStatus, new string[]
            {
                "In Production - Üretimde", "In Stock - Stokta", "Out of Stock - Stokta Yok",
                "Discontinued - Üretimi Durduruldu", "On Hold - Beklemede", "Shipped - Gönderildi",
                "Delivered - Teslim Edildi", "Returned - İade Edildi", "Pending - Beklemede",
                "Approved - Onaylandı", "Rejected - Reddedildi"
            });

            PopulateComboBox(comboBoxRating, new string[] { "1", "2", "3", "4", "5" });

            PopulateComboBox(comboBoxDiscount, new string[] { "10%", "25%", "50%", "60%", "75%" });

            PopulateComboBox(comboBoxBrand, new string[]
            {
                "Nike", "Adidas", "Puma", "Reebok", "Under Armour",
                "Levi's", "H&M", "Zara"
            });


        

        }

        private DataTable GetData()
        {
            const string query = @"
                SELECT 
                    i.ItemID, 
                    i.ItemName, 
                    i.Description, 
                    i.Price, 
                    i.StockQuantity, 
                    i.ImageURL, 
                    i.Color, 
                    i.Weight, 
                    i.Material, 
                    i.Status, 
                    i.Rating, 
                    i.Location, 
                    i.Featured, 
                    i.Discount, 
                    i.Brand,
                    i.TaxGroupID,
                    i.UnitOfMeasureID,
                    p.Barcode
                FROM 
                    Item i
                LEFT JOIN 
                    prItemBarcode p 
                ON 
                    i.ItemID = p.ItemID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }

        private void BindDataToGrid(DataTable dataTable)
        {
            dataGridView1.DataSource = dataTable;
        }
        private void PopulateComboBox(ComboBox comboBox, string[] items)
        {
            comboBox.Items.AddRange(items);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                textBoxItemName.Text = selectedRow.Cells["ItemName"].Value.ToString();
                textBoxDescription.Text = selectedRow.Cells["Description"].Value.ToString();
                numericUpDownPrice.Value = Convert.ToDecimal(selectedRow.Cells["Price"].Value);
                numericUpDownStockQuantity.Value = Convert.ToDecimal(selectedRow.Cells["StockQuantity"].Value);
                textBoxImageUrl.Text = selectedRow.Cells["ImageURL"].Value.ToString();
                comboBoxColor.SelectedItem = selectedRow.Cells["Color"].Value.ToString();
                textBox_Weight.Text = selectedRow.Cells["Weight"].Value.ToString();
                comboBoxMaterial.SelectedItem = selectedRow.Cells["Material"].Value.ToString();
                comboBoxStatus.SelectedItem = selectedRow.Cells["Status"].Value.ToString();
                comboBoxRating.SelectedItem = selectedRow.Cells["Rating"].Value.ToString();
                textBoxLocation.Text = selectedRow.Cells["Location"].Value.ToString();
                comboBoxDiscount.SelectedItem = selectedRow.Cells["Discount"].Value.ToString();
                comboBoxBrand.SelectedItem = selectedRow.Cells["Brand"].Value.ToString();
                comboBoxTaxGroup.SelectedValue = selectedRow.Cells["TaxGroupID"].Value;
                comboBoxUnitOfMeasureName.SelectedValue = selectedRow.Cells["UnitOfMeasureID"].Value;

                checkBoxFeatured.Checked = Convert.ToBoolean(selectedRow.Cells["Featured"].Value);

                // Barcode bilgilerini ekleyin
                textBoxBarcode.Text = selectedRow.Cells["Barcode"].Value?.ToString() ?? "Barkod bilgisi yok";
            }
        }


        // Yeni veri ekleme metodu
        private void AddItem()
        {
            if (string.IsNullOrEmpty(textBoxItemName.Text) || string.IsNullOrEmpty(textBoxDescription.Text))
            {
                MessageBox.Show("Eksik alanlar var.");
                return;
            }

            // Yeni barkodu al
            string newBarcode = GetNextBarcode();
            textBoxBarcode.Text = newBarcode; // Barkodu textbox'a da yazabiliriz

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Item tablosuna veri ekleme
                    string itemQuery = "INSERT INTO Item (ItemName, Description, Price, StockQuantity, ImageURL, Color, Weight, Material, Status, Rating, Location, Featured, Discount, Brand, TaxGroupID, UnitOfMeasureID) " +
                                       "VALUES (@ItemName, @Description, @Price, @StockQuantity, @ImageURL, @Color, @Weight, @Material, @Status, @Rating, @Location, @Featured, @Discount, @Brand, @TaxGroupID, @UnitOfMeasureID); " +
                                       "SELECT SCOPE_IDENTITY();";
                    using (SqlCommand itemCommand = new SqlCommand(itemQuery, connection))
                    {
                        itemCommand.Parameters.Add("@ItemName", SqlDbType.VarChar, 100).Value = textBoxItemName.Text;
                        itemCommand.Parameters.Add("@Description", SqlDbType.Text).Value = textBoxDescription.Text;
                        itemCommand.Parameters.Add("@Price", SqlDbType.Decimal).Value = numericUpDownPrice.Value;
                        itemCommand.Parameters.Add("@StockQuantity", SqlDbType.Int).Value = numericUpDownStockQuantity.Value;
                        itemCommand.Parameters.Add("@ImageURL", SqlDbType.VarChar, 255).Value = textBoxImageUrl.Text;
                        itemCommand.Parameters.Add("@Color", SqlDbType.VarChar, 50).Value = comboBoxColor.SelectedItem?.ToString() ?? (object)DBNull.Value;
                        itemCommand.Parameters.Add("@Weight", SqlDbType.Decimal).Value = !string.IsNullOrEmpty(textBox_Weight.Text) ? Convert.ToDecimal(textBox_Weight.Text) : (object)DBNull.Value;
                        itemCommand.Parameters.Add("@Material", SqlDbType.VarChar, 100).Value = comboBoxMaterial.SelectedItem?.ToString() ?? (object)DBNull.Value;
                        itemCommand.Parameters.Add("@Status", SqlDbType.VarChar, -1).Value = comboBoxStatus.SelectedItem?.ToString() ?? (object)DBNull.Value;
                        itemCommand.Parameters.Add("@Rating", SqlDbType.NVarChar, -1).Value = comboBoxRating.SelectedItem?.ToString() ?? (object)DBNull.Value;
                        itemCommand.Parameters.Add("@Location", SqlDbType.VarChar, 100).Value = textBoxLocation.Text;
                        itemCommand.Parameters.Add("@Featured", SqlDbType.Bit).Value = checkBoxFeatured.Checked;
                        itemCommand.Parameters.Add("@Discount", SqlDbType.NVarChar, -1).Value = comboBoxDiscount.SelectedItem?.ToString() ?? (object)DBNull.Value;
                        itemCommand.Parameters.Add("@Brand", SqlDbType.VarChar, 50).Value = comboBoxBrand.SelectedItem?.ToString() ?? (object)DBNull.Value;
                        itemCommand.Parameters.Add("@TaxGroupID", SqlDbType.Int, 100).Value = comboBoxTaxGroup.SelectedValue;
                        itemCommand.Parameters.Add("@UnitOfMeasureID", SqlDbType.Int, 100).Value = comboBoxUnitOfMeasureName.SelectedValue;

                        int itemId = Convert.ToInt32(itemCommand.ExecuteScalar());
                        

                        // prItemBarcode tablosuna veri ekleme
                        string barcodeQuery = "INSERT INTO prItemBarcode (BarcodeType, ItemID, Barcode) VALUES (@BarcodeType, @ItemID, @Barcode)";
                        using (SqlCommand barcodeCommand = new SqlCommand(barcodeQuery, connection))
                        {
                            barcodeCommand.Parameters.Add("@BarcodeType", SqlDbType.VarChar, 50).Value = "Ean13";
                            barcodeCommand.Parameters.Add("@ItemID", SqlDbType.Int).Value = itemId;
                            barcodeCommand.Parameters.Add("@Barcode", SqlDbType.VarChar, 13).Value = newBarcode; // Barkodu buradan al
                            barcodeCommand.ExecuteNonQuery();
                        }
                    }

                    LoadData(); // Veriyi yeniden yükle
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri eklenirken bir hata oluştu: " + ex.Message);
            }
        }

        private void buttonAdd_Click_1(object sender, EventArgs e)
        {
            AddItem();
        }

        // Ekleme butonuna tıklanma olayı


        // Veri silme metodu
        private void DeleteItem(int itemId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // prItemBarcode tablosundan silme
                    string barcodeQuery = "DELETE FROM prItemBarcode WHERE ItemID = @ItemID";
                    using (SqlCommand barcodeCommand = new SqlCommand(barcodeQuery, connection))
                    {
                        barcodeCommand.Parameters.AddWithValue("@ItemID", itemId);
                        barcodeCommand.ExecuteNonQuery();
                    }

                    // Item tablosundan silme
                    string itemQuery = "DELETE FROM Item WHERE ItemID = @ItemID";
                    using (SqlCommand itemCommand = new SqlCommand(itemQuery, connection))
                    {
                        itemCommand.Parameters.AddWithValue("@ItemID", itemId);
                        itemCommand.ExecuteNonQuery();
                    }
                }

                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri silinirken bir hata oluştu: " + ex.Message);
            }
        }


        // Silme butonuna tıklanma olayı

        private void buttonDelete_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedItemId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ItemID"].Value);
                DeleteItem(selectedItemId);
            }
        }


        private void UpdateItem(int itemId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Item tablosunda güncelleme
                    string itemQuery = "UPDATE Item SET ItemName = @ItemName, Description = @Description, Price = @Price, StockQuantity = @StockQuantity, ImageURL = @ImageURL, Color = @Color, Weight = @Weight, Material = @Material, Status = @Status, Rating = @Rating, Location = @Location, Featured = @Featured, Discount = @Discount, Brand = @Brand, TaxGroupID = @TaxGroupID, UnitOfMeasureID = @UnitOfMeasureID WHERE ItemID = @ItemID";
                    using (SqlCommand itemCommand = new SqlCommand(itemQuery, connection))
                    {
                        itemCommand.Parameters.Add("@ItemName", SqlDbType.VarChar, 100).Value = textBoxItemName.Text;
                        itemCommand.Parameters.Add("@Description", SqlDbType.Text).Value = textBoxDescription.Text;
                        itemCommand.Parameters.Add("@Price", SqlDbType.Decimal).Value = numericUpDownPrice.Value;
                        itemCommand.Parameters.Add("@StockQuantity", SqlDbType.Int).Value = numericUpDownStockQuantity.Value;
                        itemCommand.Parameters.Add("@ImageURL", SqlDbType.VarChar, 255).Value = textBoxImageUrl.Text;
                        itemCommand.Parameters.Add("@Color", SqlDbType.VarChar, 50).Value = comboBoxColor.SelectedItem?.ToString() ?? (object)DBNull.Value;
                        itemCommand.Parameters.Add("@Weight", SqlDbType.Decimal).Value = !string.IsNullOrEmpty(textBox_Weight.Text) ? Convert.ToDecimal(textBox_Weight.Text) : (object)DBNull.Value;
                        itemCommand.Parameters.Add("@Material", SqlDbType.VarChar, 100).Value = comboBoxMaterial.SelectedItem?.ToString() ?? (object)DBNull.Value;
                        itemCommand.Parameters.Add("@Status", SqlDbType.VarChar, -1).Value = comboBoxStatus.SelectedItem?.ToString() ?? (object)DBNull.Value;
                        itemCommand.Parameters.Add("@Rating", SqlDbType.NVarChar, -1).Value = comboBoxRating.SelectedItem?.ToString() ?? (object)DBNull.Value;
                        itemCommand.Parameters.Add("@Location", SqlDbType.VarChar, 100).Value = textBoxLocation.Text;
                        itemCommand.Parameters.Add("@Featured", SqlDbType.Bit).Value = checkBoxFeatured.Checked;
                        itemCommand.Parameters.Add("@Discount", SqlDbType.NVarChar, -1).Value = comboBoxDiscount.SelectedItem?.ToString() ?? (object)DBNull.Value;
                        itemCommand.Parameters.Add("@Brand", SqlDbType.VarChar, 50).Value = comboBoxBrand.SelectedItem?.ToString() ?? (object)DBNull.Value;
                        itemCommand.Parameters.Add("@TaxGroupID", SqlDbType.Int).Value = (int)comboBoxTaxGroup.SelectedValue;
                        itemCommand.Parameters.Add("@UnitOfMeasureID", SqlDbType.Int).Value = (int)comboBoxUnitOfMeasureName.SelectedValue;
                        
                        itemCommand.Parameters.Add("@ItemID", SqlDbType.Int).Value = itemId;

                        int rowsAffected = itemCommand.ExecuteNonQuery();

                        // prItemBarcode tablosunda güncelleme
                        string barcodeQuery = "UPDATE prItemBarcode SET Barcode = @Barcode WHERE ItemID = @ItemID";
                        using (SqlCommand barcodeCommand = new SqlCommand(barcodeQuery, connection))
                        {
                            barcodeCommand.Parameters.Add("@Barcode", SqlDbType.VarChar, 13).Value = textBoxBarcode.Text; // Barkodu buradan al
                            barcodeCommand.Parameters.Add("@ItemID", SqlDbType.Int).Value = itemId;
                            barcodeCommand.ExecuteNonQuery();
                        }

                        if (rowsAffected == 0)
                        {
                            MessageBox.Show("Güncellenen veri bulunamadı. Lütfen kontrol edin.");
                        }
                        else
                        {
                            MessageBox.Show("Veri başarıyla güncellendi.");
                        }
                    }
                }

                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri güncellenirken bir hata oluştu: " + ex.Message);
            }
        }


        private void buttonUpdate_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedItemId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ItemID"].Value);
                UpdateItem(selectedItemId);
            }
        }

        private async Task LoadImageFromUrlAsync(string imageUrl)
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    var imageBytes = await httpClient.GetByteArrayAsync(imageUrl);

                    using (var stream = new System.IO.MemoryStream(imageBytes))
                    {
                        pictureBoxImage.Image = Image.FromStream(stream);
                    }
                }
            }
            catch (HttpRequestException httpEx)
            {
                MessageBox.Show("HTTP isteği sırasında bir hata oluştu: " + httpEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Resim yüklenirken bir hata oluştu: " + ex.Message);
            }
        }

        private void buttonLoadImage_Click(object sender, EventArgs e)
        {
            string imageUrl = textBoxImageUrl.Text.Trim();

            if (!string.IsNullOrEmpty(imageUrl))
            {
                LoadImageFromUrlAsync(imageUrl);
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir URL girin.");
            }
        }

        private void comboBoxColor_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            ComboBox comboBox = sender as ComboBox;
            string colorName = comboBox.Items[e.Index].ToString();
            Color color;


            try
            {
                color = Color.FromName(colorName);
            }
            catch
            {
                color = Color.Transparent;
            }


            e.DrawBackground();
            using (SolidBrush brush = new SolidBrush(color))
            {
                e.Graphics.FillRectangle(brush, e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height);
            }
            e.Graphics.DrawString(colorName, e.Font, Brushes.Black, e.Bounds.X + 5, e.Bounds.Y + 5);
            e.DrawFocusRectangle();
        }



        private string GetNextBarcode()
        {
            string lastBarcode = string.Empty;

            using (SqlConnection connection = new SqlConnection("server=localhost\\SQLEXPRESS;Initial Catalog=Product;Integrated Security=True"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT TOP 1 Barcode FROM prItemBarcode ORDER BY Barcode DESC", connection);
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    lastBarcode = result.ToString();
                }
            }

            if (!string.IsNullOrEmpty(lastBarcode))
            {
                long lastBarcodeNumber = long.Parse(lastBarcode);
                long nextBarcodeNumber = lastBarcodeNumber + 1;
                return nextBarcodeNumber.ToString().PadLeft(13, '0');
            }

            // İlk kayıt için başlangıç değerini döndür
            return "8697770000001";
        }






        private void label7_Click(object sender, EventArgs e)
        {
            textBoxImageUrl.Focus();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            comboBoxRating.DroppedDown = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            textBoxItemName.Focus();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            numericUpDownPrice.Focus();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            comboBoxColor.DroppedDown = true;

        }

        private void label2_Click(object sender, EventArgs e)
        {
            textBoxDescription.Focus();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            numericUpDownStockQuantity.Focus();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            textBox_Weight.Focus();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            comboBoxStatus.DroppedDown = true;
        }

        private void label13_Click(object sender, EventArgs e)
        {
            textBoxLocation.Focus();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            comboBoxBrand.DroppedDown = true;
        }

        private void label10_Click(object sender, EventArgs e)
        {
            comboBoxMaterial.DroppedDown = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            comboBoxDiscount.DroppedDown = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void numericUpDownPrice_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
