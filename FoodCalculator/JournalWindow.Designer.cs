namespace FoodCalculator
{
    partial class JournalWindow
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
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.productsListview = new System.Windows.Forms.ListView();
            this.mealProductColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.weigthColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.proteinsColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fatColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.carboColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sugarsColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fibersColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.saltsColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.caloriesColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.removeProduct = new System.Windows.Forms.Button();
            this.addProduct = new System.Windows.Forms.Button();
            this.moveData = new System.Windows.Forms.Button();
            this.option1comboBox = new System.Windows.Forms.ComboBox();
            this.option2comboBox = new System.Windows.Forms.ComboBox();
            this.option3comboBox = new System.Windows.Forms.ComboBox();
            this.option4comboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(743, 20);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // productsListview
            // 
            this.productsListview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productsListview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.mealProductColumn,
            this.weigthColumn,
            this.proteinsColumn,
            this.fatColumn,
            this.carboColumn,
            this.sugarsColumn,
            this.fibersColumn,
            this.saltsColumn,
            this.caloriesColumn});
            this.productsListview.FullRowSelect = true;
            this.productsListview.GridLines = true;
            this.productsListview.HideSelection = false;
            this.productsListview.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.productsListview.Location = new System.Drawing.Point(14, 38);
            this.productsListview.MultiSelect = false;
            this.productsListview.Name = "productsListview";
            this.productsListview.Size = new System.Drawing.Size(737, 376);
            this.productsListview.TabIndex = 2;
            this.productsListview.UseCompatibleStateImageBehavior = false;
            this.productsListview.View = System.Windows.Forms.View.Details;
            this.productsListview.SelectedIndexChanged += new System.EventHandler(this.productsListview_SelectedIndexChanged);
            // 
            // mealProductColumn
            // 
            this.mealProductColumn.Text = "MEAL/PRODUCT";
            this.mealProductColumn.Width = 177;
            // 
            // weigthColumn
            // 
            this.weigthColumn.Text = "WEIGHT";
            this.weigthColumn.Width = 77;
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
            this.fibersColumn.Width = 64;
            // 
            // saltsColumn
            // 
            this.saltsColumn.Text = "SALT";
            this.saltsColumn.Width = 44;
            // 
            // caloriesColumn
            // 
            this.caloriesColumn.Text = "CALORIES";
            // 
            // removeProduct
            // 
            this.removeProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.removeProduct.Enabled = false;
            this.removeProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.removeProduct.Location = new System.Drawing.Point(14, 463);
            this.removeProduct.Name = "removeProduct";
            this.removeProduct.Size = new System.Drawing.Size(739, 35);
            this.removeProduct.TabIndex = 4;
            this.removeProduct.Text = "Remove Product";
            this.removeProduct.UseVisualStyleBackColor = true;
            this.removeProduct.Click += new System.EventHandler(this.removeProduct_Click);
            // 
            // addProduct
            // 
            this.addProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addProduct.Location = new System.Drawing.Point(14, 420);
            this.addProduct.Name = "addProduct";
            this.addProduct.Size = new System.Drawing.Size(739, 35);
            this.addProduct.TabIndex = 3;
            this.addProduct.Text = "Add Product";
            this.addProduct.UseVisualStyleBackColor = true;
            this.addProduct.Click += new System.EventHandler(this.addProduct_Click);
            // 
            // moveData
            // 
            this.moveData.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.moveData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.moveData.Location = new System.Drawing.Point(608, 533);
            this.moveData.Name = "moveData";
            this.moveData.Size = new System.Drawing.Size(144, 27);
            this.moveData.TabIndex = 5;
            this.moveData.Text = "Execute";
            this.moveData.UseVisualStyleBackColor = true;
            this.moveData.Click += new System.EventHandler(this.moveData_Click);
            // 
            // option1comboBox
            // 
            this.option1comboBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.option1comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.option1comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.option1comboBox.FormattingEnabled = true;
            this.option1comboBox.Items.AddRange(new object[] {
            "Move",
            "Copy"});
            this.option1comboBox.Location = new System.Drawing.Point(14, 537);
            this.option1comboBox.Name = "option1comboBox";
            this.option1comboBox.Size = new System.Drawing.Size(121, 23);
            this.option1comboBox.TabIndex = 6;
            // 
            // option2comboBox
            // 
            this.option2comboBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.option2comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.option2comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.option2comboBox.FormattingEnabled = true;
            this.option2comboBox.Items.AddRange(new object[] {
            "All meals",
            "First Breakfast",
            "Second Breakfast",
            "Snack",
            "Lunch",
            "Evening Snack",
            "Dinner"});
            this.option2comboBox.Location = new System.Drawing.Point(141, 537);
            this.option2comboBox.Name = "option2comboBox";
            this.option2comboBox.Size = new System.Drawing.Size(131, 23);
            this.option2comboBox.TabIndex = 7;
            // 
            // option3comboBox
            // 
            this.option3comboBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.option3comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.option3comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.option3comboBox.FormattingEnabled = true;
            this.option3comboBox.Items.AddRange(new object[] {
            "From calculator to journal",
            "From journal to calculator"});
            this.option3comboBox.Location = new System.Drawing.Point(278, 537);
            this.option3comboBox.Name = "option3comboBox";
            this.option3comboBox.Size = new System.Drawing.Size(171, 23);
            this.option3comboBox.TabIndex = 8;
            // 
            // option4comboBox
            // 
            this.option4comboBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.option4comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.option4comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.option4comboBox.FormattingEnabled = true;
            this.option4comboBox.Items.AddRange(new object[] {
            "Replacing existing",
            "Adding to existing"});
            this.option4comboBox.Location = new System.Drawing.Point(455, 537);
            this.option4comboBox.Name = "option4comboBox";
            this.option4comboBox.Size = new System.Drawing.Size(148, 23);
            this.option4comboBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(350, 511);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Query:";
            // 
            // JournalWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 581);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.option4comboBox);
            this.Controls.Add(this.option3comboBox);
            this.Controls.Add(this.option2comboBox);
            this.Controls.Add(this.option1comboBox);
            this.Controls.Add(this.moveData);
            this.Controls.Add(this.removeProduct);
            this.Controls.Add(this.addProduct);
            this.Controls.Add(this.productsListview);
            this.Controls.Add(this.dateTimePicker1);
            this.MaximumSize = new System.Drawing.Size(1000000, 1000000);
            this.MinimumSize = new System.Drawing.Size(780, 620);
            this.Name = "JournalWindow";
            this.Text = "Journal";
            this.Resize += new System.EventHandler(this.JournalWindow_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ListView productsListview;
        private System.Windows.Forms.ColumnHeader mealProductColumn;
        private System.Windows.Forms.ColumnHeader weigthColumn;
        private System.Windows.Forms.ColumnHeader proteinsColumn;
        private System.Windows.Forms.ColumnHeader fatColumn;
        private System.Windows.Forms.ColumnHeader carboColumn;
        private System.Windows.Forms.ColumnHeader sugarsColumn;
        private System.Windows.Forms.ColumnHeader fibersColumn;
        private System.Windows.Forms.ColumnHeader saltsColumn;
        private System.Windows.Forms.ColumnHeader caloriesColumn;
        private System.Windows.Forms.Button removeProduct;
        private System.Windows.Forms.Button addProduct;
        private System.Windows.Forms.Button moveData;
        private System.Windows.Forms.ComboBox option1comboBox;
        private System.Windows.Forms.ComboBox option2comboBox;
        private System.Windows.Forms.ComboBox option3comboBox;
        private System.Windows.Forms.ComboBox option4comboBox;
        private System.Windows.Forms.Label label1;
    }
}