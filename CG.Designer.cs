namespace ColorColorAgustin
{
    partial class ColorGame
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbfirstcolor = new System.Windows.Forms.TextBox();
            this.tbsecondcolor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelshowMergedColor = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Tan;
            this.label1.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the color you want to mix";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Tan;
            this.label2.Location = new System.Drawing.Point(44, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter First color:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Tan;
            this.label3.Location = new System.Drawing.Point(224, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter Second color:";
            // 
            // tbfirstcolor
            // 
            this.tbfirstcolor.BackColor = System.Drawing.Color.Wheat;
            this.tbfirstcolor.Location = new System.Drawing.Point(34, 108);
            this.tbfirstcolor.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbfirstcolor.Name = "tbfirstcolor";
            this.tbfirstcolor.Size = new System.Drawing.Size(166, 29);
            this.tbfirstcolor.TabIndex = 3;
            this.tbfirstcolor.TextChanged += new System.EventHandler(this.tbfirstcolor_TextChanged);
            // 
            // tbsecondcolor
            // 
            this.tbsecondcolor.BackColor = System.Drawing.Color.Wheat;
            this.tbsecondcolor.Location = new System.Drawing.Point(228, 107);
            this.tbsecondcolor.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbsecondcolor.Name = "tbsecondcolor";
            this.tbsecondcolor.Size = new System.Drawing.Size(156, 29);
            this.tbsecondcolor.TabIndex = 4;
            this.tbsecondcolor.TextChanged += new System.EventHandler(this.tbsecondcolor_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(204, 111);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "+";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(388, 111);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "=";
            // 
            // labelshowMergedColor
            // 
            this.labelshowMergedColor.AutoSize = true;
            this.labelshowMergedColor.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelshowMergedColor.Location = new System.Drawing.Point(412, 111);
            this.labelshowMergedColor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelshowMergedColor.Name = "labelshowMergedColor";
            this.labelshowMergedColor.Size = new System.Drawing.Size(110, 22);
            this.labelshowMergedColor.TabIndex = 9;
            this.labelshowMergedColor.Text = "waiting...";
            this.labelshowMergedColor.Click += new System.EventHandler(this.labelshowMergedColor_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Tan;
            this.label6.Location = new System.Drawing.Point(402, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "Mixed Color";
            // 
            // ColorGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(520, 143);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelshowMergedColor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbsecondcolor);
            this.Controls.Add(this.tbfirstcolor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ColorGame";
            this.Text = "Agustin\'s Mix culur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbfirstcolor;
        private System.Windows.Forms.TextBox tbsecondcolor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelshowMergedColor;
        private System.Windows.Forms.Label label6;
    }
}

