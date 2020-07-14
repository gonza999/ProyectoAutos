namespace ProyectoAutos.Presentacion
{
    partial class TiposForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.DatosMetroGrid = new MetroFramework.Controls.MetroGrid();
            this.cmnTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnBorrar = new System.Windows.Forms.DataGridViewImageColumn();
            this.cmnEditar = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.ReporteMetroButton = new MetroFramework.Controls.MetroButton();
            this.NuevoMetroButton = new MetroFramework.Controls.MetroButton();
            this.CerrarMetroButton = new MetroFramework.Controls.MetroButton();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatosMetroGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.DatosMetroGrid);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(560, 406);
            this.metroPanel1.TabIndex = 2;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // DatosMetroGrid
            // 
            this.DatosMetroGrid.AllowUserToAddRows = false;
            this.DatosMetroGrid.AllowUserToDeleteRows = false;
            this.DatosMetroGrid.AllowUserToResizeRows = false;
            this.DatosMetroGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DatosMetroGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DatosMetroGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DatosMetroGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DatosMetroGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DatosMetroGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatosMetroGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cmnTipo,
            this.cmnBorrar,
            this.cmnEditar});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DatosMetroGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.DatosMetroGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DatosMetroGrid.EnableHeadersVisualStyles = false;
            this.DatosMetroGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DatosMetroGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DatosMetroGrid.Location = new System.Drawing.Point(0, 0);
            this.DatosMetroGrid.MultiSelect = false;
            this.DatosMetroGrid.Name = "DatosMetroGrid";
            this.DatosMetroGrid.ReadOnly = true;
            this.DatosMetroGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DatosMetroGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DatosMetroGrid.RowHeadersVisible = false;
            this.DatosMetroGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DatosMetroGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DatosMetroGrid.Size = new System.Drawing.Size(560, 406);
            this.DatosMetroGrid.TabIndex = 2;
            this.DatosMetroGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DatosMetroGrid_CellContentClick);
            // 
            // cmnTipo
            // 
            this.cmnTipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmnTipo.HeaderText = "Tipo";
            this.cmnTipo.Name = "cmnTipo";
            this.cmnTipo.ReadOnly = true;
            // 
            // cmnBorrar
            // 
            this.cmnBorrar.HeaderText = "Borrar";
            this.cmnBorrar.Image = global::ProyectoAutos.Presentacion.Properties.Resources.delete_file_28px;
            this.cmnBorrar.Name = "cmnBorrar";
            this.cmnBorrar.ReadOnly = true;
            // 
            // cmnEditar
            // 
            this.cmnEditar.HeaderText = "Editar";
            this.cmnEditar.Image = global::ProyectoAutos.Presentacion.Properties.Resources.edit_file_28px;
            this.cmnEditar.Name = "cmnEditar";
            this.cmnEditar.ReadOnly = true;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Borrar";
            this.dataGridViewImageColumn1.Image = global::ProyectoAutos.Presentacion.Properties.Resources.delete_file_28px;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Editar";
            this.dataGridViewImageColumn2.Image = global::ProyectoAutos.Presentacion.Properties.Resources.edit_file_28px;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            // 
            // ReporteMetroButton
            // 
            this.ReporteMetroButton.BackgroundImage = global::ProyectoAutos.Presentacion.Properties.Resources.print_28px;
            this.ReporteMetroButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ReporteMetroButton.Location = new System.Drawing.Point(464, 20);
            this.ReporteMetroButton.Name = "ReporteMetroButton";
            this.ReporteMetroButton.Size = new System.Drawing.Size(27, 25);
            this.ReporteMetroButton.TabIndex = 4;
            this.ReporteMetroButton.UseSelectable = true;
            this.ReporteMetroButton.Click += new System.EventHandler(this.ReporteMetroButton_Click);
            // 
            // NuevoMetroButton
            // 
            this.NuevoMetroButton.BackgroundImage = global::ProyectoAutos.Presentacion.Properties.Resources.AgregarAE;
            this.NuevoMetroButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NuevoMetroButton.Location = new System.Drawing.Point(509, 20);
            this.NuevoMetroButton.Name = "NuevoMetroButton";
            this.NuevoMetroButton.Size = new System.Drawing.Size(27, 25);
            this.NuevoMetroButton.TabIndex = 4;
            this.NuevoMetroButton.UseSelectable = true;
            this.NuevoMetroButton.Click += new System.EventHandler(this.NuevoMetroButton_Click);
            // 
            // CerrarMetroButton
            // 
            this.CerrarMetroButton.BackColor = System.Drawing.Color.Transparent;
            this.CerrarMetroButton.BackgroundImage = global::ProyectoAutos.Presentacion.Properties.Resources.Cancelar;
            this.CerrarMetroButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CerrarMetroButton.Location = new System.Drawing.Point(553, 20);
            this.CerrarMetroButton.Name = "CerrarMetroButton";
            this.CerrarMetroButton.Size = new System.Drawing.Size(27, 25);
            this.CerrarMetroButton.TabIndex = 3;
            this.CerrarMetroButton.UseSelectable = true;
            this.CerrarMetroButton.Click += new System.EventHandler(this.CerrarMetroButton_Click);
            // 
            // TiposForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 486);
            this.ControlBox = false;
            this.Controls.Add(this.ReporteMetroButton);
            this.Controls.Add(this.NuevoMetroButton);
            this.Controls.Add(this.CerrarMetroButton);
            this.Controls.Add(this.metroPanel1);
            this.Name = "TiposForm";
            this.Text = "TiposForm";
            this.Load += new System.EventHandler(this.TiposForm_Load);
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DatosMetroGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton NuevoMetroButton;
        private MetroFramework.Controls.MetroButton CerrarMetroButton;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroGrid DatosMetroGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnTipo;
        private System.Windows.Forms.DataGridViewImageColumn cmnBorrar;
        private System.Windows.Forms.DataGridViewImageColumn cmnEditar;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private MetroFramework.Controls.MetroButton ReporteMetroButton;
    }
}