
namespace A3_menu_while_JR
{
    partial class Menu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnop1 = new System.Windows.Forms.Button();
            this.btnop2 = new System.Windows.Forms.Button();
            this.btnop3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnop1
            // 
            this.btnop1.Location = new System.Drawing.Point(28, 93);
            this.btnop1.Name = "btnop1";
            this.btnop1.Size = new System.Drawing.Size(244, 90);
            this.btnop1.TabIndex = 0;
            this.btnop1.Text = "Repetir texto";
            this.btnop1.UseVisualStyleBackColor = true;
            this.btnop1.Click += new System.EventHandler(this.btnop1_Click);
            // 
            // btnop2
            // 
            this.btnop2.Location = new System.Drawing.Point(28, 225);
            this.btnop2.Name = "btnop2";
            this.btnop2.Size = new System.Drawing.Size(244, 90);
            this.btnop2.TabIndex = 1;
            this.btnop2.Text = "Pares e impares";
            this.btnop2.UseVisualStyleBackColor = true;
            this.btnop2.Click += new System.EventHandler(this.btnop2_Click);
            // 
            // btnop3
            // 
            this.btnop3.Location = new System.Drawing.Point(28, 355);
            this.btnop3.Name = "btnop3";
            this.btnop3.Size = new System.Drawing.Size(244, 90);
            this.btnop3.TabIndex = 2;
            this.btnop3.Text = "Sumatoria";
            this.btnop3.UseVisualStyleBackColor = true;
            this.btnop3.Click += new System.EventHandler(this.btnop3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Elija una opción";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 487);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnop3);
            this.Controls.Add(this.btnop2);
            this.Controls.Add(this.btnop1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnop1;
        private System.Windows.Forms.Button btnop2;
        private System.Windows.Forms.Button btnop3;
        private System.Windows.Forms.Label label1;
    }
}

