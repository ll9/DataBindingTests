namespace DataBindingTests
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label ageLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label ageLabel1;
            System.Windows.Forms.Label nameLabel1;
            System.Windows.Forms.Label ageLabel2;
            System.Windows.Forms.Label nameLabel2;
            System.Windows.Forms.Label ageLabel3;
            System.Windows.Forms.Label nameLabel3;
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.ageTextBox1 = new System.Windows.Forms.TextBox();
            this.nameTextBox1 = new System.Windows.Forms.TextBox();
            this.ageTextBox2 = new System.Windows.Forms.TextBox();
            this.nameTextBox2 = new System.Windows.Forms.TextBox();
            this.ageTextBox3 = new System.Windows.Forms.TextBox();
            this.nameTextBox3 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ageLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            ageLabel1 = new System.Windows.Forms.Label();
            nameLabel1 = new System.Windows.Forms.Label();
            ageLabel2 = new System.Windows.Forms.Label();
            nameLabel2 = new System.Windows.Forms.Label();
            ageLabel3 = new System.Windows.Forms.Label();
            nameLabel3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.Location = new System.Drawing.Point(17, 51);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new System.Drawing.Size(29, 13);
            ageLabel.TabIndex = 1;
            ageLabel.Text = "Age:";
            // 
            // ageTextBox
            // 
            this.ageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "Age", true));
            this.ageTextBox.Location = new System.Drawing.Point(61, 48);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(100, 20);
            this.ageTextBox.TabIndex = 2;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(17, 77);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(61, 74);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 4;
            // 
            // ageLabel1
            // 
            ageLabel1.AutoSize = true;
            ageLabel1.Location = new System.Drawing.Point(201, 48);
            ageLabel1.Name = "ageLabel1";
            ageLabel1.Size = new System.Drawing.Size(29, 13);
            ageLabel1.TabIndex = 5;
            ageLabel1.Text = "Age:";
            // 
            // ageTextBox1
            // 
            this.ageTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "Age", true));
            this.ageTextBox1.Location = new System.Drawing.Point(245, 45);
            this.ageTextBox1.Name = "ageTextBox1";
            this.ageTextBox1.Size = new System.Drawing.Size(100, 20);
            this.ageTextBox1.TabIndex = 6;
            // 
            // nameLabel1
            // 
            nameLabel1.AutoSize = true;
            nameLabel1.Location = new System.Drawing.Point(201, 74);
            nameLabel1.Name = "nameLabel1";
            nameLabel1.Size = new System.Drawing.Size(38, 13);
            nameLabel1.TabIndex = 7;
            nameLabel1.Text = "Name:";
            // 
            // nameTextBox1
            // 
            this.nameTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "Name", true));
            this.nameTextBox1.Location = new System.Drawing.Point(245, 71);
            this.nameTextBox1.Name = "nameTextBox1";
            this.nameTextBox1.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox1.TabIndex = 8;
            // 
            // ageLabel2
            // 
            ageLabel2.AutoSize = true;
            ageLabel2.Location = new System.Drawing.Point(17, 37);
            ageLabel2.Name = "ageLabel2";
            ageLabel2.Size = new System.Drawing.Size(29, 13);
            ageLabel2.TabIndex = 9;
            ageLabel2.Text = "Age:";
            // 
            // ageTextBox2
            // 
            this.ageTextBox2.Location = new System.Drawing.Point(61, 34);
            this.ageTextBox2.Name = "ageTextBox2";
            this.ageTextBox2.Size = new System.Drawing.Size(100, 20);
            this.ageTextBox2.TabIndex = 10;
            // 
            // nameLabel2
            // 
            nameLabel2.AutoSize = true;
            nameLabel2.Location = new System.Drawing.Point(17, 63);
            nameLabel2.Name = "nameLabel2";
            nameLabel2.Size = new System.Drawing.Size(38, 13);
            nameLabel2.TabIndex = 11;
            nameLabel2.Text = "Name:";
            // 
            // nameTextBox2
            // 
            this.nameTextBox2.Location = new System.Drawing.Point(61, 60);
            this.nameTextBox2.Name = "nameTextBox2";
            this.nameTextBox2.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox2.TabIndex = 12;
            // 
            // ageLabel3
            // 
            ageLabel3.AutoSize = true;
            ageLabel3.Location = new System.Drawing.Point(201, 37);
            ageLabel3.Name = "ageLabel3";
            ageLabel3.Size = new System.Drawing.Size(29, 13);
            ageLabel3.TabIndex = 13;
            ageLabel3.Text = "Age:";
            // 
            // ageTextBox3
            // 
            this.ageTextBox3.Location = new System.Drawing.Point(245, 34);
            this.ageTextBox3.Name = "ageTextBox3";
            this.ageTextBox3.Size = new System.Drawing.Size(100, 20);
            this.ageTextBox3.TabIndex = 14;
            // 
            // nameLabel3
            // 
            nameLabel3.AutoSize = true;
            nameLabel3.Location = new System.Drawing.Point(201, 63);
            nameLabel3.Name = "nameLabel3";
            nameLabel3.Size = new System.Drawing.Size(38, 13);
            nameLabel3.TabIndex = 15;
            nameLabel3.Text = "Name:";
            // 
            // nameTextBox3
            // 
            this.nameTextBox3.Location = new System.Drawing.Point(245, 60);
            this.nameTextBox3.Name = "nameTextBox3";
            this.nameTextBox3.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox3.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(ageLabel);
            this.groupBox1.Controls.Add(this.nameTextBox);
            this.groupBox1.Controls.Add(nameLabel);
            this.groupBox1.Controls.Add(this.ageTextBox);
            this.groupBox1.Controls.Add(this.nameTextBox1);
            this.groupBox1.Controls.Add(nameLabel1);
            this.groupBox1.Controls.Add(this.ageTextBox1);
            this.groupBox1.Controls.Add(ageLabel1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 194);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Visual Studio Databinding";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(nameLabel2);
            this.groupBox2.Controls.Add(this.nameTextBox2);
            this.groupBox2.Controls.Add(ageLabel3);
            this.groupBox2.Controls.Add(this.ageTextBox2);
            this.groupBox2.Controls.Add(this.ageTextBox3);
            this.groupBox2.Controls.Add(ageLabel2);
            this.groupBox2.Controls.Add(nameLabel3);
            this.groupBox2.Controls.Add(this.nameTextBox3);
            this.groupBox2.Location = new System.Drawing.Point(13, 214);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(364, 200);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Manual Databinding";
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataSource = typeof(DataBindingTests.Models.Person);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource personBindingSource;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox ageTextBox1;
        private System.Windows.Forms.TextBox nameTextBox1;
        private System.Windows.Forms.TextBox ageTextBox2;
        private System.Windows.Forms.TextBox nameTextBox2;
        private System.Windows.Forms.TextBox ageTextBox3;
        private System.Windows.Forms.TextBox nameTextBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

