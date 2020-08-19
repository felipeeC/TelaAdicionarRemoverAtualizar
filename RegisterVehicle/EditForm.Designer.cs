namespace RegisterVehicle {
    partial class EditForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.textId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textModel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBrand = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textYear = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbCarType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbCor = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.listViewPessoa = new System.Windows.Forms.ListView();
            this.cPessoa = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // textId
            // 
            this.textId.Enabled = false;
            this.textId.Location = new System.Drawing.Point(12, 12);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(100, 23);
            this.textId.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Id";
            // 
            // textModel
            // 
            this.textModel.Location = new System.Drawing.Point(12, 41);
            this.textModel.Name = "textModel";
            this.textModel.Size = new System.Drawing.Size(100, 23);
            this.textModel.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Model";
            // 
            // textBrand
            // 
            this.textBrand.Location = new System.Drawing.Point(12, 70);
            this.textBrand.Name = "textBrand";
            this.textBrand.Size = new System.Drawing.Size(100, 23);
            this.textBrand.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Brand";
            // 
            // textYear
            // 
            this.textYear.Location = new System.Drawing.Point(12, 99);
            this.textYear.Name = "textYear";
            this.textYear.Size = new System.Drawing.Size(100, 23);
            this.textYear.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Year";
            // 
            // cbCarType
            // 
            this.cbCarType.FormattingEnabled = true;
            this.cbCarType.Items.AddRange(new object[] {
            "Pickup",
            "Coupe",
            "Car"});
            this.cbCarType.Location = new System.Drawing.Point(12, 128);
            this.cbCarType.Name = "cbCarType";
            this.cbCarType.Size = new System.Drawing.Size(100, 23);
            this.cbCarType.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(118, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Car Type";
            // 
            // cbCor
            // 
            this.cbCor.FormattingEnabled = true;
            this.cbCor.Location = new System.Drawing.Point(12, 161);
            this.cbCor.Name = "cbCor";
            this.cbCor.Size = new System.Drawing.Size(100, 23);
            this.cbCor.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(118, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Cor";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(243, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(218, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Pessoa";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // listViewPessoa
            // 
            this.listViewPessoa.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cPessoa});
            this.listViewPessoa.HideSelection = false;
            this.listViewPessoa.Location = new System.Drawing.Point(218, 33);
            this.listViewPessoa.Name = "listViewPessoa";
            this.listViewPessoa.Size = new System.Drawing.Size(100, 146);
            this.listViewPessoa.TabIndex = 13;
            this.listViewPessoa.UseCompatibleStateImageBehavior = false;
            this.listViewPessoa.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // cPessoa
            // 
            this.cPessoa.Text = "Pessoas";
            // 
            // EditForm
            // 
            this.ClientSize = new System.Drawing.Size(329, 268);
            this.Controls.Add(this.listViewPessoa);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbCor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbCarType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textYear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBrand);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textModel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textId);
            this.Name = "EditForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textModel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBrand;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textYear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbCarType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbCor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView listViewPessoa;
        private System.Windows.Forms.ColumnHeader cPessoa;
    }
}