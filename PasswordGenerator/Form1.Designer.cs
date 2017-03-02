namespace PasswordGenerator
{
    partial class PasswordGenerator
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
        	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordGenerator));
        	this.button1 = new System.Windows.Forms.Button();
        	this.textBox1 = new System.Windows.Forms.TextBox();
        	this.button2 = new System.Windows.Forms.Button();
        	this.SuspendLayout();
        	// 
        	// button1
        	// 
        	this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
        	this.button1.Location = new System.Drawing.Point(0, 66);
        	this.button1.Name = "button1";
        	this.button1.Size = new System.Drawing.Size(420, 43);
        	this.button1.TabIndex = 0;
        	this.button1.Text = "Generate and Copy to clipboard";
        	this.button1.UseVisualStyleBackColor = true;
        	this.button1.Click += new System.EventHandler(this.button1_Click);
        	// 
        	// textBox1
        	// 
        	this.textBox1.Dock = System.Windows.Forms.DockStyle.Left;
        	this.textBox1.Enabled = false;
        	this.textBox1.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.textBox1.Location = new System.Drawing.Point(0, 0);
        	this.textBox1.Multiline = true;
        	this.textBox1.Name = "textBox1";
        	this.textBox1.Size = new System.Drawing.Size(366, 66);
        	this.textBox1.TabIndex = 1;
        	this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        	// 
        	// button2
        	// 
        	this.button2.Dock = System.Windows.Forms.DockStyle.Right;
        	this.button2.Location = new System.Drawing.Point(372, 0);
        	this.button2.Name = "button2";
        	this.button2.Size = new System.Drawing.Size(48, 66);
        	this.button2.TabIndex = 2;
        	this.button2.Text = "Copy";
        	this.button2.UseVisualStyleBackColor = true;
        	this.button2.Click += new System.EventHandler(this.Button2Click);
        	// 
        	// PasswordGenerator
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
        	this.ClientSize = new System.Drawing.Size(420, 109);
        	this.Controls.Add(this.button2);
        	this.Controls.Add(this.textBox1);
        	this.Controls.Add(this.button1);
        	this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        	this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        	this.MaximizeBox = false;
        	this.Name = "PasswordGenerator";
        	this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        	this.Text = "AD Password Generator";
        	this.Load += new System.EventHandler(this.PasswordGenerator_Load);
        	this.ResumeLayout(false);
        	this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
    }
}

