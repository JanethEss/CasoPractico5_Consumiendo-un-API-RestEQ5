namespace API_Simpson
{
    partial class API3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(API3));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAPI_RyM = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnObtener = new System.Windows.Forms.Button();
            this.dgvPersonajes = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Historia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Imagen = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.btnAPI_RyM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonajes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAPI_RyM
            // 
            this.btnAPI_RyM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAPI_RyM.Image = ((System.Drawing.Image)(resources.GetObject("btnAPI_RyM.Image")));
            this.btnAPI_RyM.Location = new System.Drawing.Point(53, 16);
            this.btnAPI_RyM.Name = "btnAPI_RyM";
            this.btnAPI_RyM.Size = new System.Drawing.Size(61, 84);
            this.btnAPI_RyM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAPI_RyM.TabIndex = 13;
            this.btnAPI_RyM.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(786, 39);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 34);
            this.label1.TabIndex = 12;
            this.label1.Text = "The Simpson API";
            // 
            // btnObtener
            // 
            this.btnObtener.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnObtener.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnObtener.Location = new System.Drawing.Point(560, 64);
            this.btnObtener.Name = "btnObtener";
            this.btnObtener.Size = new System.Drawing.Size(158, 23);
            this.btnObtener.TabIndex = 11;
            this.btnObtener.Text = "Obtener personajes";
            this.btnObtener.UseVisualStyleBackColor = false;
            this.btnObtener.Click += new System.EventHandler(this.btnObtener_Click);
            // 
            // dgvPersonajes
            // 
            this.dgvPersonajes.AllowUserToAddRows = false;
            this.dgvPersonajes.AllowUserToDeleteRows = false;
            this.dgvPersonajes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPersonajes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPersonajes.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvPersonajes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPersonajes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPersonajes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPersonajes.ColumnHeadersHeight = 25;
            this.dgvPersonajes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Historia,
            this.Imagen});
            this.dgvPersonajes.Location = new System.Drawing.Point(12, 106);
            this.dgvPersonajes.Name = "dgvPersonajes";
            this.dgvPersonajes.ReadOnly = true;
            this.dgvPersonajes.RowHeadersVisible = false;
            this.dgvPersonajes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersonajes.Size = new System.Drawing.Size(761, 298);
            this.dgvPersonajes.TabIndex = 10;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Historia
            // 
            this.Historia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Historia.HeaderText = "Historia";
            this.Historia.Name = "Historia";
            this.Historia.ReadOnly = true;
            // 
            // Imagen
            // 
            this.Imagen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Imagen.HeaderText = "Imagen";
            this.Imagen.Name = "Imagen";
            this.Imagen.ReadOnly = true;
            this.Imagen.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Imagen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Imagen.Width = 150;
            // 
            // API3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 412);
            this.Controls.Add(this.btnAPI_RyM);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnObtener);
            this.Controls.Add(this.dgvPersonajes);
            this.Name = "API3";
            this.Text = "API3";
            ((System.ComponentModel.ISupportInitialize)(this.btnAPI_RyM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonajes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnAPI_RyM;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnObtener;
        private System.Windows.Forms.DataGridView dgvPersonajes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Historia;
        private System.Windows.Forms.DataGridViewImageColumn Imagen;
    }
}

