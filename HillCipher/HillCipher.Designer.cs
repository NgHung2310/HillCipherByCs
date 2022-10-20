namespace HillCipher
{
    partial class HillCipher
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
            this.tbxPlainText = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtnEncipher = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbxCiphetText = new System.Windows.Forms.TextBox();
            this.rbtnDecipher = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbMatrix = new System.Windows.Forms.Label();
            this.lbReverseMatrix = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxPlainText
            // 
            this.tbxPlainText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPlainText.Location = new System.Drawing.Point(172, 17);
            this.tbxPlainText.Name = "tbxPlainText";
            this.tbxPlainText.Size = new System.Drawing.Size(391, 30);
            this.tbxPlainText.TabIndex = 0;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Location = new System.Drawing.Point(13, 192);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(157, 35);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse key...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Plaint text";
            // 
            // rbtnEncipher
            // 
            this.rbtnEncipher.AutoSize = true;
            this.rbtnEncipher.Location = new System.Drawing.Point(604, 39);
            this.rbtnEncipher.Name = "rbtnEncipher";
            this.rbtnEncipher.Size = new System.Drawing.Size(110, 29);
            this.rbtnEncipher.TabIndex = 3;
            this.rbtnEncipher.TabStop = true;
            this.rbtnEncipher.Text = "Encipher";
            this.rbtnEncipher.UseVisualStyleBackColor = true;
            this.rbtnEncipher.CheckedChanged += new System.EventHandler(this.rbtnEncipher_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.tbxCiphetText);
            this.groupBox1.Controls.Add(this.rbtnDecipher);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbxPlainText);
            this.groupBox1.Controls.Add(this.rbtnEncipher);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 153);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(319, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 32);
            this.button1.TabIndex = 7;
            this.button1.Text = "CACULATE";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tbxCiphetText
            // 
            this.tbxCiphetText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCiphetText.Location = new System.Drawing.Point(172, 52);
            this.tbxCiphetText.Name = "tbxCiphetText";
            this.tbxCiphetText.Size = new System.Drawing.Size(391, 30);
            this.tbxCiphetText.TabIndex = 4;
            // 
            // rbtnDecipher
            // 
            this.rbtnDecipher.AutoSize = true;
            this.rbtnDecipher.Location = new System.Drawing.Point(604, 74);
            this.rbtnDecipher.Name = "rbtnDecipher";
            this.rbtnDecipher.Size = new System.Drawing.Size(111, 29);
            this.rbtnDecipher.TabIndex = 6;
            this.rbtnDecipher.TabStop = true;
            this.rbtnDecipher.Text = "Decipher";
            this.rbtnDecipher.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enchipher text";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbMatrix);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 246);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(633, 475);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Matrix";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbReverseMatrix);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(661, 246);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(633, 475);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ReverseMatrix";
            // 
            // lbMatrix
            // 
            this.lbMatrix.AutoSize = true;
            this.lbMatrix.ForeColor = System.Drawing.Color.Red;
            this.lbMatrix.Location = new System.Drawing.Point(12, 42);
            this.lbMatrix.Name = "lbMatrix";
            this.lbMatrix.Size = new System.Drawing.Size(64, 25);
            this.lbMatrix.TabIndex = 0;
            this.lbMatrix.Text = "label3";
            // 
            // lbReverseMatrix
            // 
            this.lbReverseMatrix.AutoSize = true;
            this.lbReverseMatrix.ForeColor = System.Drawing.Color.Maroon;
            this.lbReverseMatrix.Location = new System.Drawing.Point(21, 42);
            this.lbReverseMatrix.Name = "lbReverseMatrix";
            this.lbReverseMatrix.Size = new System.Drawing.Size(64, 25);
            this.lbReverseMatrix.TabIndex = 1;
            this.lbReverseMatrix.Text = "label3";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // HillCipher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 726);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBrowse);
            this.Name = "HillCipher";
            this.Text = "Hill cipher";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbxPlainText;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtnEncipher;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbxCiphetText;
        private System.Windows.Forms.RadioButton rbtnDecipher;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbMatrix;
        private System.Windows.Forms.Label lbReverseMatrix;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

