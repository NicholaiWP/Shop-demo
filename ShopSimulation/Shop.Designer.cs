namespace ShopSimulation
{
    partial class Shop
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
            this.shopTitle = new System.Windows.Forms.Label();
            this.itemLabel = new System.Windows.Forms.Label();
            this.add_to_cart = new System.Windows.Forms.Button();
            this.CartLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.StoreList = new System.Windows.Forms.ListBox();
            this.CartList = new System.Windows.Forms.ListBox();
            this.VendorList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.StoreProfit = new System.Windows.Forms.Label();
            this.Profit_text = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // shopTitle
            // 
            this.shopTitle.AutoSize = true;
            this.shopTitle.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shopTitle.Location = new System.Drawing.Point(44, 33);
            this.shopTitle.Name = "shopTitle";
            this.shopTitle.Size = new System.Drawing.Size(530, 59);
            this.shopTitle.TabIndex = 0;
            this.shopTitle.Text = "Consignment Shop Demo";
            // 
            // itemLabel
            // 
            this.itemLabel.AutoSize = true;
            this.itemLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemLabel.Location = new System.Drawing.Point(50, 115);
            this.itemLabel.Name = "itemLabel";
            this.itemLabel.Size = new System.Drawing.Size(87, 19);
            this.itemLabel.TabIndex = 2;
            this.itemLabel.Text = "Store Items";
            // 
            // add_to_cart
            // 
            this.add_to_cart.Location = new System.Drawing.Point(316, 218);
            this.add_to_cart.Name = "add_to_cart";
            this.add_to_cart.Size = new System.Drawing.Size(116, 32);
            this.add_to_cart.TabIndex = 3;
            this.add_to_cart.Text = "Add to Cart ->";
            this.add_to_cart.UseVisualStyleBackColor = true;
            this.add_to_cart.Click += new System.EventHandler(this.Add_to_cart_click_event);
            // 
            // CartLabel
            // 
            this.CartLabel.AutoSize = true;
            this.CartLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CartLabel.Location = new System.Drawing.Point(491, 115);
            this.CartLabel.Name = "CartLabel";
            this.CartLabel.Size = new System.Drawing.Size(105, 19);
            this.CartLabel.TabIndex = 5;
            this.CartLabel.Text = "Shopping cart";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(598, 314);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Purchase";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.MakePurchase_click);
            // 
            // StoreList
            // 
            this.StoreList.FormattingEnabled = true;
            this.StoreList.ItemHeight = 19;
            this.StoreList.Location = new System.Drawing.Point(54, 160);
            this.StoreList.Name = "StoreList";
            this.StoreList.Size = new System.Drawing.Size(189, 137);
            this.StoreList.TabIndex = 7;
            // 
            // CartList
            // 
            this.CartList.FormattingEnabled = true;
            this.CartList.ItemHeight = 19;
            this.CartList.Location = new System.Drawing.Point(495, 160);
            this.CartList.Name = "CartList";
            this.CartList.Size = new System.Drawing.Size(189, 137);
            this.CartList.TabIndex = 8;
            // 
            // VendorList
            // 
            this.VendorList.FormattingEnabled = true;
            this.VendorList.ItemHeight = 19;
            this.VendorList.Location = new System.Drawing.Point(54, 376);
            this.VendorList.Name = "VendorList";
            this.VendorList.Size = new System.Drawing.Size(189, 137);
            this.VendorList.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 343);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Vendors";
            // 
            // StoreProfit
            // 
            this.StoreProfit.AutoSize = true;
            this.StoreProfit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StoreProfit.Location = new System.Drawing.Point(491, 360);
            this.StoreProfit.Name = "StoreProfit";
            this.StoreProfit.Size = new System.Drawing.Size(89, 19);
            this.StoreProfit.TabIndex = 12;
            this.StoreProfit.Text = "Store Profit";
            // 
            // Profit_text
            // 
            this.Profit_text.AutoSize = true;
            this.Profit_text.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Profit_text.Location = new System.Drawing.Point(595, 360);
            this.Profit_text.Name = "Profit_text";
            this.Profit_text.Size = new System.Drawing.Size(45, 19);
            this.Profit_text.TabIndex = 13;
            this.Profit_text.Text = "$0.00";
            // 
            // Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 658);
            this.Controls.Add(this.Profit_text);
            this.Controls.Add(this.StoreProfit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VendorList);
            this.Controls.Add(this.CartList);
            this.Controls.Add(this.StoreList);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.CartLabel);
            this.Controls.Add(this.add_to_cart);
            this.Controls.Add(this.itemLabel);
            this.Controls.Add(this.shopTitle);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Shop";
            this.Text = "Shop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label shopTitle;
        private System.Windows.Forms.Label itemLabel;
        private System.Windows.Forms.Button add_to_cart;
        private System.Windows.Forms.Label CartLabel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox StoreList;
        private System.Windows.Forms.ListBox CartList;
        private System.Windows.Forms.ListBox VendorList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label StoreProfit;
        private System.Windows.Forms.Label Profit_text;
    }
}

