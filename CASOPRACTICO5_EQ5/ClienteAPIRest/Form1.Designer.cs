namespace ClienteAPIRest
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAPI_RyM = new System.Windows.Forms.PictureBox();
            this.btnAPI_GobMX = new System.Windows.Forms.PictureBox();
            this.btnAPI_Simpson = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAPI_RyM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAPI_GobMX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAPI_Simpson)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(125, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente servicios API REST ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(580, 39);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnAPI_RyM
            // 
            this.btnAPI_RyM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAPI_RyM.Image = ((System.Drawing.Image)(resources.GetObject("btnAPI_RyM.Image")));
            this.btnAPI_RyM.Location = new System.Drawing.Point(59, 109);
            this.btnAPI_RyM.Name = "btnAPI_RyM";
            this.btnAPI_RyM.Size = new System.Drawing.Size(112, 137);
            this.btnAPI_RyM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAPI_RyM.TabIndex = 2;
            this.btnAPI_RyM.TabStop = false;
            this.btnAPI_RyM.Click += new System.EventHandler(this.btnAPI_RyM_Click);
            // 
            // btnAPI_GobMX
            // 
            this.btnAPI_GobMX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAPI_GobMX.Image = ((System.Drawing.Image)(resources.GetObject("btnAPI_GobMX.Image")));
            this.btnAPI_GobMX.Location = new System.Drawing.Point(228, 109);
            this.btnAPI_GobMX.Name = "btnAPI_GobMX";
            this.btnAPI_GobMX.Size = new System.Drawing.Size(112, 119);
            this.btnAPI_GobMX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAPI_GobMX.TabIndex = 3;
            this.btnAPI_GobMX.TabStop = false;
            this.btnAPI_GobMX.Click += new System.EventHandler(this.btnAPI_GobMX_Click);
            // 
            // btnAPI_Simpson
            // 
            this.btnAPI_Simpson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAPI_Simpson.Image = ((System.Drawing.Image)(resources.GetObject("btnAPI_Simpson.Image")));
            this.btnAPI_Simpson.Location = new System.Drawing.Point(405, 109);
            this.btnAPI_Simpson.Name = "btnAPI_Simpson";
            this.btnAPI_Simpson.Size = new System.Drawing.Size(112, 137);
            this.btnAPI_Simpson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAPI_Simpson.TabIndex = 4;
            this.btnAPI_Simpson.TabStop = false;
            this.btnAPI_Simpson.Click += new System.EventHandler(this.btnAPI_Simpson_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "API REST Rick y Morty";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(402, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "API REST The Simpson";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(209, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "API REST Gobierno de México";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 305);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAPI_Simpson);
            this.Controls.Add(this.btnAPI_GobMX);
            this.Controls.Add(this.btnAPI_RyM);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "Inicio";
            this.Text = "Caso Practico 5";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAPI_RyM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAPI_GobMX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAPI_Simpson)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btnAPI_RyM;
        private System.Windows.Forms.PictureBox btnAPI_GobMX;
        private System.Windows.Forms.PictureBox btnAPI_Simpson;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

