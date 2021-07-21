namespace FoodCalculator
{
    partial class FoodCalculator
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.listView1 = new System.Windows.Forms.ListView();
            this.mealProductColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.weigthColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.proteinsColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fatColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.carboColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sugarsColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fibersColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.saltsColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.caloriesColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addProduct = new System.Windows.Forms.Button();
            this.removeProduct = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.mealProductColumn,
            this.weigthColumn,
            this.proteinsColumn,
            this.fatColumn,
            this.carboColumn,
            this.sugarsColumn,
            this.fibersColumn,
            this.saltsColumn,
            this.caloriesColumn});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView1.Location = new System.Drawing.Point(12, 34);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(740, 451);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // mealProductColumn
            // 
            this.mealProductColumn.Text = "MEAL/PRODUCT";
            this.mealProductColumn.Width = 173;
            // 
            // weigthColumn
            // 
            this.weigthColumn.Text = "WEIGHT";
            this.weigthColumn.Width = 67;
            // 
            // proteinsColumn
            // 
            this.proteinsColumn.Text = "PROTEINS";
            this.proteinsColumn.Width = 70;
            // 
            // fatColumn
            // 
            this.fatColumn.Text = "FAT";
            this.fatColumn.Width = 68;
            // 
            // carboColumn
            // 
            this.carboColumn.Text = "CARBOHYDRATES";
            this.carboColumn.Width = 110;
            // 
            // sugarsColumn
            // 
            this.sugarsColumn.Text = "SUGARS";
            this.sugarsColumn.Width = 63;
            // 
            // fibersColumn
            // 
            this.fibersColumn.Text = "FIBER";
            this.fibersColumn.Width = 73;
            // 
            // saltsColumn
            // 
            this.saltsColumn.Text = "SALT";
            this.saltsColumn.Width = 48;
            // 
            // caloriesColumn
            // 
            this.caloriesColumn.Text = "CALORIES";
            // 
            // addProduct
            // 
            this.addProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addProduct.Location = new System.Drawing.Point(12, 491);
            this.addProduct.Name = "addProduct";
            this.addProduct.Size = new System.Drawing.Size(739, 39);
            this.addProduct.TabIndex = 1;
            this.addProduct.Text = "Add Product";
            this.addProduct.UseVisualStyleBackColor = true;
            this.addProduct.Click += new System.EventHandler(this.addProduct_Click);
            // 
            // removeProduct
            // 
            this.removeProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.removeProduct.Enabled = false;
            this.removeProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.removeProduct.Location = new System.Drawing.Point(12, 536);
            this.removeProduct.Name = "removeProduct";
            this.removeProduct.Size = new System.Drawing.Size(739, 39);
            this.removeProduct.TabIndex = 2;
            this.removeProduct.Text = "Remove Product";
            this.removeProduct.UseVisualStyleBackColor = true;
            this.removeProduct.Click += new System.EventHandler(this.removeProduct_Click);
            // 
            // FoodCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 581);
            this.Controls.Add(this.removeProduct);
            this.Controls.Add(this.addProduct);
            this.Controls.Add(this.listView1);
            this.MaximumSize = new System.Drawing.Size(1000000, 1000000);
            this.MinimumSize = new System.Drawing.Size(780, 620);
            this.Name = "FoodCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Resize += new System.EventHandler(this.FoodCalculator_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader mealProductColumn;
        private System.Windows.Forms.ColumnHeader weigthColumn;
        private System.Windows.Forms.ColumnHeader proteinsColumn;
        private System.Windows.Forms.ColumnHeader fatColumn;
        private System.Windows.Forms.ColumnHeader carboColumn;
        private System.Windows.Forms.ColumnHeader sugarsColumn;
        private System.Windows.Forms.ColumnHeader fibersColumn;
        private System.Windows.Forms.ColumnHeader saltsColumn;
        private System.Windows.Forms.ColumnHeader caloriesColumn;
        private System.Windows.Forms.Button addProduct;
        private System.Windows.Forms.Button removeProduct;
    }
}