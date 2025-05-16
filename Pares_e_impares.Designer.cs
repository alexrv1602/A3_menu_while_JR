
namespace A3_menu_while_JR
{
    partial class Pares_e_impares
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
            this.btnop6 = new System.Windows.Forms.Button();
            this.btnop5 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnop6
            // 
            this.btnop6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnop6.Location = new System.Drawing.Point(35, 115);
            this.btnop6.Name = "btnop6";
            this.btnop6.Size = new System.Drawing.Size(267, 85);
            this.btnop6.TabIndex = 1;
            this.btnop6.Text = "Impares";
            this.btnop6.UseVisualStyleBackColor = true;
            this.btnop6.Click += new System.EventHandler(this.btnop6_Click);
            // 
            // btnop5
            // 
            this.btnop5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnop5.Location = new System.Drawing.Point(35, 24);
            this.btnop5.Name = "btnop5";
            this.btnop5.Size = new System.Drawing.Size(267, 85);
            this.btnop5.TabIndex = 0;
            this.btnop5.Text = "Pares";
            this.btnop5.UseVisualStyleBackColor = true;
            this.btnop5.Click += new System.EventHandler(this.btnop5_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(42, 233);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(259, 160);
            this.listBox1.TabIndex = 2;
            // 
            // Pares_e_impares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 421);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnop6);
            this.Controls.Add(this.btnop5);
            this.Name = "Pares_e_impares";
            this.Text = "Pares_e_impares";
            this.Load += new System.EventHandler(this.Pares_e_impares_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnop6;
        private System.Windows.Forms.Button btnop5;
        private System.Windows.Forms.ListBox listBox1;
    }
}