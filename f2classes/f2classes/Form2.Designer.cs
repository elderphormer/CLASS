namespace f2classes
{
    partial class Form2
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
            this.lbldimensao = new System.Windows.Forms.Label();
            this.btnok = new System.Windows.Forms.Button();
            this.numUDval = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numUDval)).BeginInit();
            this.SuspendLayout();
            // 
            // lbldimensao
            // 
            this.lbldimensao.AutoSize = true;
            this.lbldimensao.Location = new System.Drawing.Point(84, 52);
            this.lbldimensao.Name = "lbldimensao";
            this.lbldimensao.Size = new System.Drawing.Size(69, 16);
            this.lbldimensao.TabIndex = 0;
            this.lbldimensao.Text = "Dimensao";
            // 
            // btnok
            // 
            this.btnok.Location = new System.Drawing.Point(51, 151);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(120, 23);
            this.btnok.TabIndex = 1;
            this.btnok.Text = "btnok";
            this.btnok.UseVisualStyleBackColor = true;
            // 
            // numUDval
            // 
            this.numUDval.Location = new System.Drawing.Point(51, 82);
            this.numUDval.Name = "numUDval";
            this.numUDval.Size = new System.Drawing.Size(120, 22);
            this.numUDval.TabIndex = 2;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 186);
            this.Controls.Add(this.numUDval);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.lbldimensao);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.numUDval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbldimensao;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.NumericUpDown numUDval;
    }
}