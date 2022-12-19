namespace OOO_Footwear.View
{
    partial class ProductEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductEditor));
            this.pictureBoxProduct = new System.Windows.Forms.PictureBox();
            this.comboBoxClassification = new System.Windows.Forms.ComboBox();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.comboBoxManufacturer = new System.Windows.Forms.ComboBox();
            this.labelArticle = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelClassification = new System.Windows.Forms.Label();
            this.labelManufacturer = new System.Windows.Forms.Label();
            this.labelCategory = new System.Windows.Forms.Label();
            this.labelCost = new System.Windows.Forms.Label();
            this.labelCount = new System.Windows.Forms.Label();
            this.buttonAddImage = new System.Windows.Forms.Button();
            this.buttonDeleteImage = new System.Windows.Forms.Button();
            this.buttonDeleteProduct = new System.Windows.Forms.Button();
            this.buttonSaveChange = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.textBoxWithPlaceHolderDescription = new OOO_Footwear.Classes.TextBoxWithPlaceHolder();
            this.textBoxWithPlaceHolderCount = new OOO_Footwear.Classes.TextBoxWithPlaceHolder();
            this.textBoxWithPlaceHolderCost = new OOO_Footwear.Classes.TextBoxWithPlaceHolder();
            this.textBoxWithPlaceHolderArticle = new OOO_Footwear.Classes.TextBoxWithPlaceHolder();
            this.labelHeader = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProduct)).BeginInit();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxProduct
            // 
            this.pictureBoxProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBoxProduct.Image = global::OOO_Footwear.Properties.Resources.plug;
            this.pictureBoxProduct.Location = new System.Drawing.Point(12, 85);
            this.pictureBoxProduct.Name = "pictureBoxProduct";
            this.pictureBoxProduct.Size = new System.Drawing.Size(200, 200);
            this.pictureBoxProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProduct.TabIndex = 10;
            this.pictureBoxProduct.TabStop = false;
            // 
            // comboBoxClassification
            // 
            this.comboBoxClassification.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxClassification.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxClassification.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxClassification.Location = new System.Drawing.Point(361, 215);
            this.comboBoxClassification.Name = "comboBoxClassification";
            this.comboBoxClassification.Size = new System.Drawing.Size(241, 27);
            this.comboBoxClassification.TabIndex = 12;
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxCategory.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxCategory.Location = new System.Drawing.Point(361, 282);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(241, 27);
            this.comboBoxCategory.TabIndex = 13;
            // 
            // comboBoxManufacturer
            // 
            this.comboBoxManufacturer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxManufacturer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxManufacturer.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxManufacturer.Location = new System.Drawing.Point(361, 248);
            this.comboBoxManufacturer.Name = "comboBoxManufacturer";
            this.comboBoxManufacturer.Size = new System.Drawing.Size(241, 27);
            this.comboBoxManufacturer.TabIndex = 14;
            // 
            // labelArticle
            // 
            this.labelArticle.AutoSize = true;
            this.labelArticle.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelArticle.Location = new System.Drawing.Point(229, 85);
            this.labelArticle.Name = "labelArticle";
            this.labelArticle.Size = new System.Drawing.Size(66, 19);
            this.labelArticle.TabIndex = 15;
            this.labelArticle.Text = "Артикул";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDescription.Location = new System.Drawing.Point(229, 118);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(75, 19);
            this.labelDescription.TabIndex = 16;
            this.labelDescription.Text = "Описание";
            // 
            // labelClassification
            // 
            this.labelClassification.AutoSize = true;
            this.labelClassification.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelClassification.Location = new System.Drawing.Point(229, 215);
            this.labelClassification.Name = "labelClassification";
            this.labelClassification.Size = new System.Drawing.Size(74, 19);
            this.labelClassification.TabIndex = 17;
            this.labelClassification.Text = "Название";
            // 
            // labelManufacturer
            // 
            this.labelManufacturer.AutoSize = true;
            this.labelManufacturer.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelManufacturer.Location = new System.Drawing.Point(229, 248);
            this.labelManufacturer.Name = "labelManufacturer";
            this.labelManufacturer.Size = new System.Drawing.Size(116, 19);
            this.labelManufacturer.TabIndex = 18;
            this.labelManufacturer.Text = "Производитель";
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCategory.Location = new System.Drawing.Point(229, 285);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(82, 19);
            this.labelCategory.TabIndex = 19;
            this.labelCategory.Text = "Категория";
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCost.Location = new System.Drawing.Point(229, 318);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(83, 19);
            this.labelCost.TabIndex = 20;
            this.labelCost.Text = "Стоимость";
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCount.Location = new System.Drawing.Point(228, 353);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(91, 19);
            this.labelCount.TabIndex = 21;
            this.labelCount.Text = "Количество";
            // 
            // buttonAddImage
            // 
            this.buttonAddImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(244)))), ((int)(((byte)(233)))));
            this.buttonAddImage.FlatAppearance.BorderSize = 0;
            this.buttonAddImage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(232)))), ((int)(((byte)(135)))));
            this.buttonAddImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddImage.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddImage.ForeColor = System.Drawing.Color.White;
            this.buttonAddImage.Location = new System.Drawing.Point(12, 291);
            this.buttonAddImage.Name = "buttonAddImage";
            this.buttonAddImage.Size = new System.Drawing.Size(200, 40);
            this.buttonAddImage.TabIndex = 26;
            this.buttonAddImage.Text = "Добавить изображение";
            this.buttonAddImage.UseVisualStyleBackColor = false;
            this.buttonAddImage.Click += new System.EventHandler(this.buttonAddImage_Click);
            // 
            // buttonDeleteImage
            // 
            this.buttonDeleteImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(244)))), ((int)(((byte)(233)))));
            this.buttonDeleteImage.FlatAppearance.BorderSize = 0;
            this.buttonDeleteImage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(232)))), ((int)(((byte)(135)))));
            this.buttonDeleteImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteImage.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDeleteImage.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteImage.Location = new System.Drawing.Point(13, 337);
            this.buttonDeleteImage.Name = "buttonDeleteImage";
            this.buttonDeleteImage.Size = new System.Drawing.Size(200, 40);
            this.buttonDeleteImage.TabIndex = 27;
            this.buttonDeleteImage.Text = "Удалить изображение";
            this.buttonDeleteImage.UseVisualStyleBackColor = false;
            this.buttonDeleteImage.Click += new System.EventHandler(this.buttonDeleteImage_Click);
            // 
            // buttonDeleteProduct
            // 
            this.buttonDeleteProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(244)))), ((int)(((byte)(233)))));
            this.buttonDeleteProduct.FlatAppearance.BorderSize = 0;
            this.buttonDeleteProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(232)))), ((int)(((byte)(135)))));
            this.buttonDeleteProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteProduct.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDeleteProduct.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteProduct.Location = new System.Drawing.Point(12, 407);
            this.buttonDeleteProduct.Name = "buttonDeleteProduct";
            this.buttonDeleteProduct.Size = new System.Drawing.Size(160, 35);
            this.buttonDeleteProduct.TabIndex = 28;
            this.buttonDeleteProduct.Text = "Удалить товар";
            this.buttonDeleteProduct.UseVisualStyleBackColor = false;
            this.buttonDeleteProduct.Click += new System.EventHandler(this.buttonDeleteProduct_Click);
            // 
            // buttonSaveChange
            // 
            this.buttonSaveChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(244)))), ((int)(((byte)(233)))));
            this.buttonSaveChange.FlatAppearance.BorderSize = 0;
            this.buttonSaveChange.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(232)))), ((int)(((byte)(135)))));
            this.buttonSaveChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveChange.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSaveChange.ForeColor = System.Drawing.Color.White;
            this.buttonSaveChange.Location = new System.Drawing.Point(196, 407);
            this.buttonSaveChange.Name = "buttonSaveChange";
            this.buttonSaveChange.Size = new System.Drawing.Size(220, 35);
            this.buttonSaveChange.TabIndex = 29;
            this.buttonSaveChange.Text = "Сохранить изменения";
            this.buttonSaveChange.UseVisualStyleBackColor = false;
            this.buttonSaveChange.Click += new System.EventHandler(this.buttonSaveChange_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(244)))), ((int)(((byte)(233)))));
            this.buttonCancel.FlatAppearance.BorderSize = 0;
            this.buttonCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(232)))), ((int)(((byte)(135)))));
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.ForeColor = System.Drawing.Color.White;
            this.buttonCancel.Location = new System.Drawing.Point(442, 407);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(160, 35);
            this.buttonCancel.TabIndex = 30;
            this.buttonCancel.Text = "Отменить";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(244)))), ((int)(((byte)(233)))));
            this.panelTop.Controls.Add(this.labelHeader);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(619, 50);
            this.panelTop.TabIndex = 2;
            this.panelTop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTop_Paint);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // textBoxWithPlaceHolderDescription
            // 
            this.textBoxWithPlaceHolderDescription.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxWithPlaceHolderDescription.Location = new System.Drawing.Point(361, 118);
            this.textBoxWithPlaceHolderDescription.Multiline = true;
            this.textBoxWithPlaceHolderDescription.Name = "textBoxWithPlaceHolderDescription";
            this.textBoxWithPlaceHolderDescription.Placeholder = "Описание ";
            this.textBoxWithPlaceHolderDescription.Size = new System.Drawing.Size(241, 91);
            this.textBoxWithPlaceHolderDescription.TabIndex = 11;
            // 
            // textBoxWithPlaceHolderCount
            // 
            this.textBoxWithPlaceHolderCount.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxWithPlaceHolderCount.Location = new System.Drawing.Point(361, 350);
            this.textBoxWithPlaceHolderCount.Name = "textBoxWithPlaceHolderCount";
            this.textBoxWithPlaceHolderCount.Placeholder = "Количество на складе";
            this.textBoxWithPlaceHolderCount.Size = new System.Drawing.Size(241, 27);
            this.textBoxWithPlaceHolderCount.TabIndex = 9;
            // 
            // textBoxWithPlaceHolderCost
            // 
            this.textBoxWithPlaceHolderCost.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxWithPlaceHolderCost.Location = new System.Drawing.Point(361, 315);
            this.textBoxWithPlaceHolderCost.Name = "textBoxWithPlaceHolderCost";
            this.textBoxWithPlaceHolderCost.Placeholder = "Стоимость";
            this.textBoxWithPlaceHolderCost.Size = new System.Drawing.Size(241, 27);
            this.textBoxWithPlaceHolderCost.TabIndex = 8;
            // 
            // textBoxWithPlaceHolderArticle
            // 
            this.textBoxWithPlaceHolderArticle.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxWithPlaceHolderArticle.Location = new System.Drawing.Point(361, 85);
            this.textBoxWithPlaceHolderArticle.Name = "textBoxWithPlaceHolderArticle";
            this.textBoxWithPlaceHolderArticle.Placeholder = "Артикул";
            this.textBoxWithPlaceHolderArticle.Size = new System.Drawing.Size(241, 27);
            this.textBoxWithPlaceHolderArticle.TabIndex = 4;
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(244)))), ((int)(((byte)(233)))));
            this.labelHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelHeader.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHeader.ForeColor = System.Drawing.Color.White;
            this.labelHeader.Location = new System.Drawing.Point(0, 0);
            this.labelHeader.Margin = new System.Windows.Forms.Padding(0);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(208, 26);
            this.labelHeader.TabIndex = 5;
            this.labelHeader.Text = "Редактор продуктов";
            this.labelHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProductEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(619, 456);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSaveChange);
            this.Controls.Add(this.buttonDeleteProduct);
            this.Controls.Add(this.buttonDeleteImage);
            this.Controls.Add(this.buttonAddImage);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.labelCost);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.labelManufacturer);
            this.Controls.Add(this.labelClassification);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelArticle);
            this.Controls.Add(this.comboBoxManufacturer);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.comboBoxClassification);
            this.Controls.Add(this.textBoxWithPlaceHolderDescription);
            this.Controls.Add(this.pictureBoxProduct);
            this.Controls.Add(this.textBoxWithPlaceHolderCount);
            this.Controls.Add(this.textBoxWithPlaceHolderCost);
            this.Controls.Add(this.textBoxWithPlaceHolderArticle);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ProductEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование товара";
            this.Load += new System.EventHandler(this.Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProduct)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Classes.TextBoxWithPlaceHolder textBoxWithPlaceHolderArticle;
        private Classes.TextBoxWithPlaceHolder textBoxWithPlaceHolderCost;
        private Classes.TextBoxWithPlaceHolder textBoxWithPlaceHolderCount;
        private System.Windows.Forms.PictureBox pictureBoxProduct;
        private Classes.TextBoxWithPlaceHolder textBoxWithPlaceHolderDescription;
        private System.Windows.Forms.ComboBox comboBoxClassification;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.ComboBox comboBoxManufacturer;
        private System.Windows.Forms.Label labelArticle;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelClassification;
        private System.Windows.Forms.Label labelManufacturer;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Button buttonAddImage;
        private System.Windows.Forms.Button buttonDeleteImage;
        private System.Windows.Forms.Button buttonDeleteProduct;
        private System.Windows.Forms.Button buttonSaveChange;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label labelHeader;
    }
}