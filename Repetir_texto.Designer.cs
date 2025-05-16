
namespace A3_menu_while_JR
{
    partial class Repetir_texto
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
            this.txtola = new System.Windows.Forms.TextBox();
            this.btnrepetir = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtola
            // 
            this.txtola.Location = new System.Drawing.Point(12, 12);
            this.txtola.Name = "txtola";
            this.txtola.Size = new System.Drawing.Size(250, 29);
            this.txtola.TabIndex = 0;
            this.txtola.TextChanged += new System.EventHandler(this.txtola_TextChanged);
            // 
            // btnrepetir
            // 
            this.btnrepetir.Location = new System.Drawing.Point(17, 69);
            this.btnrepetir.Name = "btnrepetir";
            this.btnrepetir.Size = new System.Drawing.Size(244, 51);
            this.btnrepetir.TabIndex = 1;
            this.btnrepetir.Text = "Repetir";
            this.btnrepetir.UseVisualStyleBackColor = true;
            this.btnrepetir.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Location = new System.Drawing.Point(20, 147);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(240, 148);
            this.listBox1.TabIndex = 2;
            // 
            // Repetir_texto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 393);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnrepetir);
            this.Controls.Add(this.txtola);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Repetir_texto";
            this.Text = "Repetir_texto";
            this.Load += new System.EventHandler(this.Repetir_texto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtola;
        private System.Windows.Forms.Button btnrepetir;
        private System.Windows.Forms.ListBox listBox1;
    }
}