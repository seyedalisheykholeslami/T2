namespace T2
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtchar = new System.Windows.Forms.TextBox();
            this.txtstring = new System.Windows.Forms.TextBox();
            this.btnlistofword = new System.Windows.Forms.Button();
            this.btnchar = new System.Windows.Forms.Button();
            this.btnnumberofword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(497, 166);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "حرف را وراد کنید";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(497, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "متن را وارد کنید";
            // 
            // txtchar
            // 
            this.txtchar.Location = new System.Drawing.Point(15, 146);
            this.txtchar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtchar.MaxLength = 1;
            this.txtchar.Multiline = true;
            this.txtchar.Name = "txtchar";
            this.txtchar.Size = new System.Drawing.Size(456, 57);
            this.txtchar.TabIndex = 14;
            this.txtchar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtstring
            // 
            this.txtstring.Location = new System.Drawing.Point(15, 28);
            this.txtstring.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtstring.Multiline = true;
            this.txtstring.Name = "txtstring";
            this.txtstring.Size = new System.Drawing.Size(456, 57);
            this.txtstring.TabIndex = 13;
            this.txtstring.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnlistofword
            // 
            this.btnlistofword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlistofword.Location = new System.Drawing.Point(15, 234);
            this.btnlistofword.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnlistofword.Name = "btnlistofword";
            this.btnlistofword.Size = new System.Drawing.Size(117, 45);
            this.btnlistofword.TabIndex = 12;
            this.btnlistofword.Text = "لیست کلمات";
            this.btnlistofword.UseVisualStyleBackColor = true;
            this.btnlistofword.Click += new System.EventHandler(this.btnlistofword_Click);
            // 
            // btnchar
            // 
            this.btnchar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnchar.Location = new System.Drawing.Point(181, 234);
            this.btnchar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnchar.Name = "btnchar";
            this.btnchar.Size = new System.Drawing.Size(117, 45);
            this.btnchar.TabIndex = 11;
            this.btnchar.Text = "تعداد حرف";
            this.btnchar.UseVisualStyleBackColor = true;
            this.btnchar.Click += new System.EventHandler(this.btnchar_Click);
            // 
            // btnnumberofword
            // 
            this.btnnumberofword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnumberofword.Location = new System.Drawing.Point(354, 234);
            this.btnnumberofword.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnnumberofword.Name = "btnnumberofword";
            this.btnnumberofword.Size = new System.Drawing.Size(117, 45);
            this.btnnumberofword.TabIndex = 10;
            this.btnnumberofword.Text = "تعداد کلمه";
            this.btnnumberofword.UseVisualStyleBackColor = true;
            this.btnnumberofword.Click += new System.EventHandler(this.btnnumberofword_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 314);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtchar);
            this.Controls.Add(this.txtstring);
            this.Controls.Add(this.btnlistofword);
            this.Controls.Add(this.btnchar);
            this.Controls.Add(this.btnnumberofword);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtchar;
        private System.Windows.Forms.TextBox txtstring;
        private System.Windows.Forms.Button btnlistofword;
        private System.Windows.Forms.Button btnchar;
        private System.Windows.Forms.Button btnnumberofword;
    }
}

