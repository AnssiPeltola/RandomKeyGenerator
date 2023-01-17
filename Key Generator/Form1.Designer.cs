namespace Key_Generator
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
            this.btnGenerate = new System.Windows.Forms.Button();
            this.labelBox1 = new System.Windows.Forms.Label();
            this.labelBox2 = new System.Windows.Forms.Label();
            this.labelBox3 = new System.Windows.Forms.Label();
            this.labelBox4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCopy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.AutoSize = true;
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(476, 12);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(109, 30);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Generate Key!";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // labelBox1
            // 
            this.labelBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBox1.Location = new System.Drawing.Point(9, 12);
            this.labelBox1.Name = "labelBox1";
            this.labelBox1.Size = new System.Drawing.Size(100, 30);
            this.labelBox1.TabIndex = 1;
            this.labelBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelBox1.Click += new System.EventHandler(this.labelBox1_Click);
            // 
            // labelBox2
            // 
            this.labelBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBox2.Location = new System.Drawing.Point(128, 12);
            this.labelBox2.Name = "labelBox2";
            this.labelBox2.Size = new System.Drawing.Size(100, 30);
            this.labelBox2.TabIndex = 2;
            this.labelBox2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelBox2.Click += new System.EventHandler(this.labelBox2_Click);
            // 
            // labelBox3
            // 
            this.labelBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBox3.Location = new System.Drawing.Point(248, 12);
            this.labelBox3.Name = "labelBox3";
            this.labelBox3.Size = new System.Drawing.Size(100, 30);
            this.labelBox3.TabIndex = 3;
            this.labelBox3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelBox3.Click += new System.EventHandler(this.labelBox3_Click);
            // 
            // labelBox4
            // 
            this.labelBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBox4.Location = new System.Drawing.Point(370, 12);
            this.labelBox4.Name = "labelBox4";
            this.labelBox4.Size = new System.Drawing.Size(100, 30);
            this.labelBox4.TabIndex = 4;
            this.labelBox4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelBox4.Click += new System.EventHandler(this.labelBox4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(354, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "-";
            // 
            // btnCopy
            // 
            this.btnCopy.AutoSize = true;
            this.btnCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopy.Location = new System.Drawing.Point(591, 12);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(64, 30);
            this.btnCopy.TabIndex = 9;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(660, 51);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelBox4);
            this.Controls.Add(this.labelBox3);
            this.Controls.Add(this.labelBox2);
            this.Controls.Add(this.labelBox1);
            this.Controls.Add(this.btnGenerate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Key Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label labelBox1;
        private System.Windows.Forms.Label labelBox2;
        private System.Windows.Forms.Label labelBox3;
        private System.Windows.Forms.Label labelBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCopy;
    }
}

