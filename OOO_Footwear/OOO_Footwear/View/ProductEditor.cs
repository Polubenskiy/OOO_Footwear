
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core.Mapping;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace OOO_Footwear.View
{
    public partial class ProductEditor : Form
    {

        private List<Entities.Classification> _classification;
        private List<Entities.Category> _category;
        private List<Entities.Manufacturer> _manufacturer;

        private string _productArticle;
        private string _image;

        public ProductEditor() => InitializeComponent();

        public ProductEditor(string productArticle)
        {
            InitializeComponent();

            _productArticle = productArticle;
        }

        private void Order_Load(object sender, EventArgs e)
        {
            // add product's classification
            _classification = SQLDatabaseHelper.DatabaseContext.Classification.ToList();
            comboBoxClassification.DataSource = _classification;
            comboBoxClassification.Text = comboBoxClassification.Items[0].ToString();

            comboBoxClassification.ValueMember = "ClassificationId";
            comboBoxClassification.DisplayMember = "ClassificationName";

            // add product's category
            _category = SQLDatabaseHelper.DatabaseContext.Category.ToList();
            comboBoxCategory.DataSource = _category;
            comboBoxCategory.Text = comboBoxCategory.Items[0].ToString();

            comboBoxCategory.ValueMember = "CategoryId";
            comboBoxCategory.DisplayMember = "CategoryName";

            // add product's manufacturer
            _manufacturer = SQLDatabaseHelper.DatabaseContext.Manufacturer.ToList();
            comboBoxManufacturer.DataSource = _manufacturer;
            comboBoxManufacturer.Text = comboBoxManufacturer.Items[0].ToString();

            comboBoxManufacturer.ValueMember = "ManufacturerId";
            comboBoxManufacturer.DisplayMember = "ManufacturerName";

            openFileDialog.Filter = "Image files (*.png;*.jpeg;*.jpg)|*.png;*.jpeg;*.jpg|All files (*.*)|*.*";

            if (!string.IsNullOrEmpty(_productArticle))
            {
                // get data from database
                Entities.Product product = SQLDatabaseHelper.DatabaseContext.Product
                    .Where(x => x.ProductArticleNumber == _productArticle).FirstOrDefault();

                // article
                textBoxWithPlaceHolderArticle.Text = product.ProductArticleNumber;
                textBoxWithPlaceHolderArticle.Enabled = false;

                // description
                textBoxWithPlaceHolderDescription.Text = product.ProductDescription;

                // classifaction
                comboBoxClassification.SelectedValue = product.ProductClassificationId;

                // manufacturer
                comboBoxManufacturer.SelectedValue = product.ProductManufacuturerId;

                // category
                comboBoxCategory.SelectedValue = product.ProductCategoryId;

                // cost
                textBoxWithPlaceHolderCost.Text = product.ProductCost.ToString();

                // product's count
                textBoxWithPlaceHolderCount.Text = product.ProductQuantityInStock.ToString();

                // product's image
                Bitmap bitmapImage;

                if (!String.IsNullOrEmpty(product.ProductPhoto))
                {
                    bitmapImage = new Bitmap(DecodingBase64(product.ProductPhoto));
                }
                else
                {
                    bitmapImage = Properties.Resources.plug;
                }

                pictureBoxProduct.Image = bitmapImage;
            }
        }

        private void buttonAddImage_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;
                pictureBoxProduct.Load(fileName);
            }
        }

        private void buttonDeleteImage_Click(object sender, EventArgs e)
        {
            pictureBoxProduct.Image = Properties.Resources.plug;
        }

        private void buttonDeleteProduct_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить этот товар", "Удалить товар?", MessageBoxButtons.OKCancel) ==  DialogResult.OK)
            {
                // search for the need product
                Entities.Product productDelete = SQLDatabaseHelper.DatabaseContext.Product.Find(_productArticle);

                // delete find product
                SQLDatabaseHelper.DatabaseContext.Product.Remove(productDelete);

                try
                {
                    SQLDatabaseHelper.DatabaseContext.SaveChanges();
                    MessageBox.Show("Товар успено удален", "Удаление товара");
                }
                catch(Exception )
                {
                    MessageBox.Show("Товар нельзя удалить, т.к. он есть в заказах");
                    return;
                }

            }
        }

        private void buttonSaveChange_Click(object sender, EventArgs e)
        {

            // get new product's cost value
            double productCost;
            try
            {
                productCost = Convert.ToDouble(textBoxWithPlaceHolderCost.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("В качестве стоимости введно нечисловое значение");
                textBoxWithPlaceHolderCost.Clear();
                return;
            }

            if (productCost < 0)
            {
                MessageBox.Show("Стоимость продукта не может быть отрицательной.");
                return;
            }

            // get new product's count value
            int productCount;
            try
            {
                productCount = Convert.ToInt32(textBoxWithPlaceHolderCount.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("В качестве количества введено нечислове значение.");
                return;
            }

            if (productCount < 0)
            {
                MessageBox.Show("Количество продукта не может быть отрицательной.");
                return;
            }

            // get new Image
            string productImage = string.Empty;
            if (pictureBoxProduct.Image != null)
            {
                Image image = pictureBoxProduct.Image;
                productImage = CodingToBase64(image);
            }


            Entities.Product product = null;

            if (string.IsNullOrEmpty(_productArticle))
            {
                Entities.Product checkProduct = SQLDatabaseHelper.DatabaseContext.Product.Find(_productArticle);
                if (checkProduct != null)
                {
                    MessageBox.Show("Такой артикул есть в БД");
                    return;
                }

                product = new Entities.Product();
            }
            else
            {
                product = SQLDatabaseHelper.DatabaseContext.Product.Find(_productArticle);
            }


            product.ProductArticleNumber = textBoxWithPlaceHolderArticle.Text;
            product.ProductDescription = textBoxWithPlaceHolderDescription.Text;
            product.ProductManufacuturerId = Convert.ToInt32(comboBoxManufacturer.SelectedIndex + 1);
            product.ProductCategoryId = Convert.ToInt32(comboBoxCategory.SelectedIndex + 1);
            product.ProductClassificationId = Convert.ToInt32(comboBoxClassification.SelectedIndex + 1);
            product.ProductCost = (decimal)productCost;
            product.ProductQuantityInStock = productCount;
            product.ProductPhoto = productImage;
            product.ProductProviderId = 1;
            product.ProductUnitId = 1;


            if (String.IsNullOrEmpty(_productArticle))		//Добавление нового товара
            {
                SQLDatabaseHelper.DatabaseContext.Product.Add(product);
            }


            // save data
            try
            {
                SQLDatabaseHelper.DatabaseContext.SaveChanges();
                MessageBox.Show("Информация в БД успешно обновлена");
            }
            catch
            {
                MessageBox.Show("При обновлении данных в БД возникла ошибка");
                return;
            }
            this.Close();

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private Image DecodingBase64(string base64)
        {
            var productImage = Bitmap.FromStream(new MemoryStream(Convert.FromBase64String(base64)));

            productImage.Save("new.jpg", ImageFormat.Jpeg);


            return productImage;
        }

        private string CodingToBase64(Image image)
        {
            using (var stream = new MemoryStream())
            {
                image.Save(stream, ImageFormat.Jpeg);

                byte[] base64 = stream.ToArray();

                string base64String = Convert.ToBase64String(base64);

                return base64String;
            }
        }      
    }
}
