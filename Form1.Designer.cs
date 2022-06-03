
namespace Background_Color
{
    partial class BackgroundColor
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.yellow_rb = new System.Windows.Forms.RadioButton();
            this.red_rb = new System.Windows.Forms.RadioButton();
            this.white_rb = new System.Windows.Forms.RadioButton();
            this.btn_rb = new System.Windows.Forms.RadioButton();
            this.exit_btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_rb);
            this.groupBox1.Controls.Add(this.white_rb);
            this.groupBox1.Controls.Add(this.red_rb);
            this.groupBox1.Controls.Add(this.yellow_rb);
            this.groupBox1.Location = new System.Drawing.Point(47, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 141);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select a Background Color";
            // 
            // yellow_rb
            // 
            this.yellow_rb.AutoSize = true;
            this.yellow_rb.Location = new System.Drawing.Point(33, 33);
            this.yellow_rb.Name = "yellow_rb";
            this.yellow_rb.Size = new System.Drawing.Size(56, 17);
            this.yellow_rb.TabIndex = 0;
            this.yellow_rb.TabStop = true;
            this.yellow_rb.Text = "Yellow";
            this.yellow_rb.UseVisualStyleBackColor = true;
            this.yellow_rb.CheckedChanged += new System.EventHandler(this.yellow_rb_CheckedChanged);
            // 
            // red_rb
            // 
            this.red_rb.AutoSize = true;
            this.red_rb.Location = new System.Drawing.Point(33, 56);
            this.red_rb.Name = "red_rb";
            this.red_rb.Size = new System.Drawing.Size(45, 17);
            this.red_rb.TabIndex = 1;
            this.red_rb.TabStop = true;
            this.red_rb.Text = "Red";
            this.red_rb.UseVisualStyleBackColor = true;
            this.red_rb.CheckedChanged += new System.EventHandler(this.red_rb_CheckedChanged);
            // 
            // white_rb
            // 
            this.white_rb.AutoSize = true;
            this.white_rb.Location = new System.Drawing.Point(33, 79);
            this.white_rb.Name = "white_rb";
            this.white_rb.Size = new System.Drawing.Size(53, 17);
            this.white_rb.TabIndex = 2;
            this.white_rb.TabStop = true;
            this.white_rb.Text = "White";
            this.white_rb.UseVisualStyleBackColor = true;
            this.white_rb.CheckedChanged += new System.EventHandler(this.white_rb_CheckedChanged);
            // 
            // btn_rb
            // 
            this.btn_rb.AutoSize = true;
            this.btn_rb.Location = new System.Drawing.Point(33, 102);
            this.btn_rb.Name = "btn_rb";
            this.btn_rb.Size = new System.Drawing.Size(98, 17);
            this.btn_rb.TabIndex = 3;
            this.btn_rb.TabStop = true;
            this.btn_rb.Text = "Back to Normal";
            this.btn_rb.UseVisualStyleBackColor = true;
            this.btn_rb.CheckedChanged += new System.EventHandler(this.btn_rb_CheckedChanged);
            // 
            // exit_btn
            // 
            this.exit_btn.Location = new System.Drawing.Point(113, 209);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(75, 23);
            this.exit_btn.TabIndex = 1;
            this.exit_btn.Text = "Exit";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // BackgroundColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 276);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.groupBox1);
            this.Name = "BackgroundColor";
            this.Text = "Background Color";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton btn_rb;
        private System.Windows.Forms.RadioButton white_rb;
        private System.Windows.Forms.RadioButton red_rb;
        private System.Windows.Forms.RadioButton yellow_rb;
        private System.Windows.Forms.Button exit_btn;
    }
}

