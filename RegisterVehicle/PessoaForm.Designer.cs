namespace RegisterVehicle
{
    partial class PessoaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PessoaForm));
            this.listVPessoa = new System.Windows.Forms.ListView();
            this.cId = new System.Windows.Forms.ColumnHeader();
            this.cPessoas = new System.Windows.Forms.ColumnHeader();
            this.listVcarros = new System.Windows.Forms.ListView();
            this.cIdcarro = new System.Windows.Forms.ColumnHeader();
            this.cCarros = new System.Windows.Forms.ColumnHeader();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listVPessoa
            // 
            this.listVPessoa.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cId,
            this.cPessoas});
            this.listVPessoa.FullRowSelect = true;
            this.listVPessoa.HideSelection = false;
            this.listVPessoa.Location = new System.Drawing.Point(12, 12);
            this.listVPessoa.Name = "listVPessoa";
            this.listVPessoa.Size = new System.Drawing.Size(152, 426);
            this.listVPessoa.TabIndex = 0;
            this.listVPessoa.UseCompatibleStateImageBehavior = false;
            this.listVPessoa.View = System.Windows.Forms.View.Details;
            this.listVPessoa.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // cId
            // 
            this.cId.Text = "Id";
            // 
            // cPessoas
            // 
            this.cPessoas.Text = "Pessoas";
            this.cPessoas.Width = 150;
            // 
            // listVcarros
            // 
            this.listVcarros.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cIdcarro,
            this.cCarros});
            this.listVcarros.HideSelection = false;
            this.listVcarros.Location = new System.Drawing.Point(276, 12);
            this.listVcarros.Name = "listVcarros";
            this.listVcarros.Size = new System.Drawing.Size(152, 426);
            this.listVcarros.TabIndex = 1;
            this.listVcarros.UseCompatibleStateImageBehavior = false;
            this.listVcarros.View = System.Windows.Forms.View.Details;
            // 
            // cIdcarro
            // 
            this.cIdcarro.Text = "Id";
            // 
            // cCarros
            // 
            this.cCarros.Text = "Carros";
            this.cCarros.Width = 150;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(184, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "List";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(208, 235);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // PessoaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listVcarros);
            this.Controls.Add(this.listVPessoa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PessoaForm";
            this.Text = "PessoaForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listVPessoa;
        private System.Windows.Forms.ColumnHeader cPessoas;
        private System.Windows.Forms.ListView listVcarros;
        private System.Windows.Forms.ColumnHeader cCarros;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ColumnHeader cId;
        private System.Windows.Forms.ColumnHeader cIdcarro;
    }
}