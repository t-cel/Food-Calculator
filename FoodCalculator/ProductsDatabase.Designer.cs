namespace FoodCalculator
{
    partial class ProductsDatabase
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
            this.label1 = new System.Windows.Forms.Label();
            this.productName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.modifyButton = new System.Windows.Forms.Button();
            this.saltsBox = new System.Windows.Forms.TextBox();
            this.fibersBox = new System.Windows.Forms.TextBox();
            this.sugarsBox = new System.Windows.Forms.TextBox();
            this.carboBox = new System.Windows.Forms.TextBox();
            this.fatsBox = new System.Windows.Forms.TextBox();
            this.proteinsBox = new System.Windows.Forms.TextBox();
            this.energyBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.measureBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.productsList = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(53, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Products List";
            // 
            // productName
            // 
            this.productName.AutoSize = true;
            this.productName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.productName.Location = new System.Drawing.Point(317, 13);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(64, 20);
            this.productName.TabIndex = 3;
            this.productName.Text = "Product";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(25, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Energy:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.modifyButton);
            this.panel1.Controls.Add(this.saltsBox);
            this.panel1.Controls.Add(this.fibersBox);
            this.panel1.Controls.Add(this.sugarsBox);
            this.panel1.Controls.Add(this.carboBox);
            this.panel1.Controls.Add(this.fatsBox);
            this.panel1.Controls.Add(this.proteinsBox);
            this.panel1.Controls.Add(this.energyBox);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.measureBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(222, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 458);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(24, 284);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(207, 96);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button5.Location = new System.Drawing.Point(21, 418);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(210, 26);
            this.button5.TabIndex = 21;
            this.button5.Text = "Remove";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // modifyButton
            // 
            this.modifyButton.Enabled = false;
            this.modifyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.modifyButton.Location = new System.Drawing.Point(21, 386);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(210, 26);
            this.modifyButton.TabIndex = 7;
            this.modifyButton.Text = "Modify";
            this.modifyButton.UseVisualStyleBackColor = true;
            this.modifyButton.Click += new System.EventHandler(this.modifyButton_Click);
            // 
            // saltsBox
            // 
            this.saltsBox.Enabled = false;
            this.saltsBox.Location = new System.Drawing.Point(109, 254);
            this.saltsBox.Name = "saltsBox";
            this.saltsBox.Size = new System.Drawing.Size(122, 20);
            this.saltsBox.TabIndex = 20;
            // 
            // fibersBox
            // 
            this.fibersBox.Enabled = false;
            this.fibersBox.Location = new System.Drawing.Point(109, 222);
            this.fibersBox.Name = "fibersBox";
            this.fibersBox.Size = new System.Drawing.Size(122, 20);
            this.fibersBox.TabIndex = 19;
            // 
            // sugarsBox
            // 
            this.sugarsBox.Enabled = false;
            this.sugarsBox.Location = new System.Drawing.Point(109, 193);
            this.sugarsBox.Name = "sugarsBox";
            this.sugarsBox.Size = new System.Drawing.Size(122, 20);
            this.sugarsBox.TabIndex = 18;
            // 
            // carboBox
            // 
            this.carboBox.Enabled = false;
            this.carboBox.Location = new System.Drawing.Point(109, 162);
            this.carboBox.Name = "carboBox";
            this.carboBox.Size = new System.Drawing.Size(122, 20);
            this.carboBox.TabIndex = 17;
            // 
            // fatsBox
            // 
            this.fatsBox.Enabled = false;
            this.fatsBox.Location = new System.Drawing.Point(109, 132);
            this.fatsBox.Name = "fatsBox";
            this.fatsBox.Size = new System.Drawing.Size(122, 20);
            this.fatsBox.TabIndex = 16;
            // 
            // proteinsBox
            // 
            this.proteinsBox.Enabled = false;
            this.proteinsBox.Location = new System.Drawing.Point(109, 99);
            this.proteinsBox.Name = "proteinsBox";
            this.proteinsBox.Size = new System.Drawing.Size(122, 20);
            this.proteinsBox.TabIndex = 15;
            // 
            // energyBox
            // 
            this.energyBox.Enabled = false;
            this.energyBox.Location = new System.Drawing.Point(109, 69);
            this.energyBox.Name = "energyBox";
            this.energyBox.Size = new System.Drawing.Size(122, 20);
            this.energyBox.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(36, 257);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 17);
            this.label10.TabIndex = 13;
            this.label10.Text = "Salt:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(25, 225);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 17);
            this.label9.TabIndex = 12;
            this.label9.Text = "Fibers:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(28, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Sugars:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(7, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Carbohydrates:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(26, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Fat:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(30, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Proteins:";
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "1";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "g",
            "inne"});
            this.comboBox1.Location = new System.Drawing.Point(179, 18);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(66, 21);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.ValueMember = "1";
            // 
            // measureBox
            // 
            this.measureBox.Enabled = false;
            this.measureBox.Location = new System.Drawing.Point(114, 19);
            this.measureBox.Name = "measureBox";
            this.measureBox.Size = new System.Drawing.Size(57, 20);
            this.measureBox.TabIndex = 6;
            this.measureBox.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(28, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Data For:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(12, 500);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(459, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add New Product";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // productsList
            // 
            this.productsList.FormattingEnabled = true;
            this.productsList.Location = new System.Drawing.Point(13, 37);
            this.productsList.Name = "productsList";
            this.productsList.Size = new System.Drawing.Size(203, 459);
            this.productsList.TabIndex = 10;
            this.productsList.SelectedIndexChanged += new System.EventHandler(this.productsList_SelectedIndexChanged_1);
            // 
            // ProductsDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 536);
            this.Controls.Add(this.productsList);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.productName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ProductsDatabase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Products";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label productName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox measureBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox saltsBox;
        private System.Windows.Forms.TextBox fibersBox;
        private System.Windows.Forms.TextBox sugarsBox;
        private System.Windows.Forms.TextBox carboBox;
        private System.Windows.Forms.TextBox fatsBox;
        private System.Windows.Forms.TextBox proteinsBox;
        private System.Windows.Forms.TextBox energyBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button modifyButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ListBox productsList;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}