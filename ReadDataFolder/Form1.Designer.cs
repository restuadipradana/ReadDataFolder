namespace ReadDataFolder
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tblOpen = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btEx1 = new System.Windows.Forms.Button();
            this.btEx2 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(25, 83);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(654, 355);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // tblOpen
            // 
            this.tblOpen.Location = new System.Drawing.Point(25, 54);
            this.tblOpen.Name = "tblOpen";
            this.tblOpen.Size = new System.Drawing.Size(114, 23);
            this.tblOpen.TabIndex = 1;
            this.tblOpen.Text = "Refresh";
            this.tblOpen.UseVisualStyleBackColor = true;
            this.tblOpen.Click += new System.EventHandler(this.Form1_Load);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(145, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(534, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btEx1
            // 
            this.btEx1.Location = new System.Drawing.Point(700, 200);
            this.btEx1.Name = "btEx1";
            this.btEx1.Size = new System.Drawing.Size(85, 29);
            this.btEx1.TabIndex = 3;
            this.btEx1.Text = "Baca Excel 1";
            this.btEx1.UseVisualStyleBackColor = true;
            this.btEx1.Click += new System.EventHandler(this.btEx1_Click);
            // 
            // btEx2
            // 
            this.btEx2.Location = new System.Drawing.Point(700, 235);
            this.btEx2.Name = "btEx2";
            this.btEx2.Size = new System.Drawing.Size(85, 30);
            this.btEx2.TabIndex = 4;
            this.btEx2.Text = "Baca Excel 2";
            this.btEx2.UseVisualStyleBackColor = true;
            this.btEx2.Click += new System.EventHandler(this.btEx2_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(700, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 27);
            this.button1.TabIndex = 5;
            this.button1.Text = "Form 5";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(700, 271);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 30);
            this.button2.TabIndex = 6;
            this.button2.Text = "Baca Excel 3";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btEx2);
            this.Controls.Add(this.btEx1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tblOpen);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Read Excel";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button tblOpen;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btEx1;
        private System.Windows.Forms.Button btEx2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

