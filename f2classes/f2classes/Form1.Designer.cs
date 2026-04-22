namespace f2classes
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.Distancia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Duraçao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TipoTreino = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Distancia,
            this.Duraçao,
            this.TipoTreino});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(104, 44);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(592, 371);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Distancia
            // 
            this.Distancia.Text = "Distancia";
            this.Distancia.Width = 189;
            // 
            // Duraçao
            // 
            this.Duraçao.Text = "Duraçao";
            this.Duraçao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Duraçao.Width = 189;
            // 
            // TipoTreino
            // 
            this.TipoTreino.Text = "TipoTreino";
            this.TipoTreino.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TipoTreino.Width = 165;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Distancia;
        private System.Windows.Forms.ColumnHeader Duraçao;
        private System.Windows.Forms.ColumnHeader TipoTreino;
    }
}

