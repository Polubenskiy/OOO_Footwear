
using OOO_Footwear.Classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace OOO_Footwear.View
{
    public partial class ProductList : Form
    {
        public UserData userRole;
        private List<string> _categories;

        private string base64;

        // Count product
        private int _countProduct;
        private int _countFilterProduct;

        // Filters
        private int _filterDiscount;
        private int _filterSort;
        private int _filterCategory;

        // 
        private string _searchProduct;

        byte[,] arrayDiscount = { { 0, 100 }, { 0, 9 }, { 10, 14 }, { 15, 100 } };

        public ProductList() => InitializeComponent();

        public ProductList(UserData userRole)
        {
            InitializeComponent();

            this.userRole = userRole;

            labelFIO.Text = userRole.UserSecondName.ToString() + " " 
                + userRole.UserFirstName.ToString();

            if (userRole.UserRole == 1)
            {
                buttonAddNewProduct.Visible = true;
                buttonWorkWithOrder.Visible = true;
            }

            ActiveControl = labelSort;
        }

        public string CodingToBase64(Image product)
        {
            using (var stream = new MemoryStream())
            {
                product.Save(stream, ImageFormat.Jpeg);
                byte[] imageBytes = stream.ToArray();

                string base64 = Convert.ToBase64String(imageBytes);
                return base64;
            }
        }

        public Image DecodingBase64(string base64)
        {
            var imageProduct = Bitmap.FromStream(new MemoryStream(Convert.FromBase64String(base64)));

            imageProduct.Save("new.jpg", ImageFormat.Jpeg);

            return imageProduct;
        }

        private void ProductList_Load(object sender, EventArgs e)
        {
            _categories = new List<string>
            {
                "Все категории"
            };
            _categories.AddRange(SQLDatabaseHelper.DatabaseContext.Category
                .Select(x => x.CategoryName).ToList());

            comboBoxCategory.DataSource = _categories;
            comboBoxCategory.Text = _categories[0].ToString();

            dataGridViewProductList.Rows.Clear();
            dataGridViewProductList.Columns[1].Resizable = DataGridViewTriState.False;

            comboBoxSort.Items.Clear();
            comboBoxSort.Items.Add("По возрастанию");
            comboBoxSort.Items.Add("По убыванию");
            comboBoxSort.Text = comboBoxSort.Items[0].ToString();

            comboBoxDiscount.Items.Add("Все скидки");
            comboBoxDiscount.Items.Add("0-9 %");
            comboBoxDiscount.Items.Add("10-14 %");
            comboBoxDiscount.Items.Add("15 % и более");
            comboBoxDiscount.Text = comboBoxDiscount.Items[0].ToString();

            dataGridViewProductList.VirtualMode = false;
            dataGridViewProductList.Rows[0].Cells[0].Selected = false;


            DisplayInformation();
        }

        public void DisplayInformation()
        {
            _countProduct = SQLDatabaseHelper.DatabaseContext.Product.Count();

            var products = SQLDatabaseHelper.DatabaseContext.Product
                .Select(x => new 
                {
                    x.ProductArticleNumber,
                    x.Classification.ClassificationName, 
                    x.ProductDescription, 
                    x.Category.CategoryName,
                    x.ProductPhoto,
                    x.Manufacturer.ManufacturerName,
                    x.ProductCost,
                    x.ProductDiscountMax,
                    x.ProductDiscountNow,
                    x.ProductQuantityInStock,
                    x.Unit.UnitName,
                    x.Provider.ProviderName,
                    x.ProductClassificationId,
                    x.ProductCategoryId,
                    x.ProductManufacuturerId
                }).ToList();

            var example_1  = SQLDatabaseHelper.DatabaseContext.Product.Join(SQLDatabaseHelper.DatabaseContext.Classification,
                u => u.ProductClassificationId,
                c => c.ClassificationId,
                (u, c) => new
                {
                    ProductArticle = u.ProductArticleNumber,
                    ClassificationName = c.ClassificationName,
                    ProductDescription = u.ProductDescription

                }).ToList();

            var example_2 = (from p in SQLDatabaseHelper.DatabaseContext.Product
                            join c in SQLDatabaseHelper.DatabaseContext.Classification 
                            on p.ProductClassificationId equals c.ClassificationId

                            join provider in SQLDatabaseHelper.DatabaseContext.Provider
                            on p.ProductProviderId equals provider.ProviderId

                            join category in SQLDatabaseHelper.DatabaseContext.Category
                            on p.ProductProviderId equals category.CategoryId

                            join manufacturer in SQLDatabaseHelper.DatabaseContext.Manufacturer
                            on p.ProductProviderId equals manufacturer.ManufacturerId

                            select new
                            {
                                c.ClassificationName

                            }).ToList();

            // Filtering by discount
            products = products.Where(x => x.ProductDiscountMax >= arrayDiscount[_filterDiscount, 0] 
                && x.ProductDiscountMax <= arrayDiscount[_filterDiscount, 1])
                .ToList();

            // Filtering by category
            if (_filterCategory != 0)
            {
                products = products.Where(x => x.ProductCategoryId == _filterCategory).ToList();
            }

            // Searching by name
            if (!String.IsNullOrEmpty(_searchProduct))
            {
                products = products.Where(x => x.ClassificationName.Contains(_searchProduct)).ToList();
            }

            // Filtering by sort
            if (_filterSort == 0)
            {
                products = products.OrderBy(x => x.ProductCost).ToList();
            }
            else
            {
                products = products.OrderByDescending(x => x.ProductCost).ToList();
            }

            _countFilterProduct = products.Count();
            dataGridViewProductList.RowCount = _countFilterProduct;

            labelCountProduct.Text = _countFilterProduct.ToString() + " из " + _countProduct.ToString();

            for (int index = 0; index < products.Count; index++)

            {
                dataGridViewProductList.Rows[index].Cells[0].Value = products[index].ProductArticleNumber;

                // Creating description product
                string description = "Название: " + products[index].ClassificationName + Environment.NewLine;
                description += "Описание товара: " + products[index].ProductDescription + Environment.NewLine;
                description += "Производитель товара: " + products[index].ManufacturerName + Environment.NewLine;

                double costProduct = Convert.ToDouble(products[index].ProductCost);
                description += "Стоимость товара: " + costProduct + " руб. " + Environment.NewLine;

                double discountProduct = Convert.ToDouble(products[index].ProductDiscountMax);
                string discount = "Скидка " + discountProduct + " % " + Environment.NewLine;

                costProduct -= costProduct * discountProduct / 100;
                description += "Стоимость товара со скидкой: " + costProduct + " руб. ";

                // FIlling product's image
                Bitmap image; 
                if (!string.IsNullOrEmpty(products[index].ProductPhoto))
                {
                    image = new Bitmap((Bitmap)DecodingBase64(products[index].ProductPhoto));
                }
                else
                {
                    image = new Bitmap(Properties.Resources.plug);
                }

                // Filling in the Datagridview product data
                dataGridViewProductList.Rows[index].Cells[1].Value = image;	//Загрузить картинку
                dataGridViewProductList.Rows[index].Cells[2].Value = description; // Описание 
                dataGridViewProductList.Rows[index].Cells[3].Value = discount;
                dataGridViewProductList.Rows[index].Height = 200;

                // Setting the color for strings under specified conditions
                if (products[index].ProductDiscountMax > 15)
                    dataGridViewProductList.Rows[_countFilterProduct - 1].DefaultCellStyle.BackColor = Color.FromArgb(204, 102, 0);
                else
                    dataGridViewProductList.Rows[_countFilterProduct - 1].DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
            }
        }

        private void buttonAddNewProduct_Click(object sender, EventArgs e)
        {
            ProductEditor order = new ProductEditor();

            Hide();
            order.ShowDialog();
            Show();
        }

        private void comboBoxDiscount_SelectedIndexChanged(object sender, EventArgs e)
        {
            _filterDiscount = comboBoxDiscount.SelectedIndex;
            DisplayInformation();
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            _filterCategory= comboBoxCategory.SelectedIndex;
            DisplayInformation();
        }

        private void comboBoxSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            _filterSort= comboBoxSort.SelectedIndex;
            DisplayInformation();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            _searchProduct = textBoxSearch.Text;
            DisplayInformation();
        }

        private void contextMenuStripAdmin_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void toolStripMenuItemEdit_Click(object sender, EventArgs e)
        {
            string article = dataGridViewProductList.CurrentRow
                .Cells[0].Value
                .ToString();

            ProductEditor productEditor = new ProductEditor(article);

         
            productEditor.ShowDialog();

            DisplayInformation();
        }
    }
}
