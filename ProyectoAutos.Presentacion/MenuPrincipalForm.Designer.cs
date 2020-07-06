namespace ProyectoAutos.Presentacion
{
    partial class MenuPrincipalForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TiposMetroTile = new MetroFramework.Controls.MetroTile();
            this.MarcasMetroTile = new MetroFramework.Controls.MetroTile();
            this.SalirMetroTile = new MetroFramework.Controls.MetroTile();
            this.AutosMetroTile = new MetroFramework.Controls.MetroTile();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivosToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(558, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivosToolStripMenuItem
            // 
            this.archivosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.marcasToolStripMenuItem,
            this.autosToolStripMenuItem});
            this.archivosToolStripMenuItem.Name = "archivosToolStripMenuItem";
            this.archivosToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.archivosToolStripMenuItem.Text = "Archivos";
            // 
            // marcasToolStripMenuItem
            // 
            this.marcasToolStripMenuItem.Name = "marcasToolStripMenuItem";
            this.marcasToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.marcasToolStripMenuItem.Text = "Marcas";
            // 
            // autosToolStripMenuItem
            // 
            this.autosToolStripMenuItem.Name = "autosToolStripMenuItem";
            this.autosToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.autosToolStripMenuItem.Text = "Autos";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // TiposMetroTile
            // 
            this.TiposMetroTile.ActiveControl = null;
            this.TiposMetroTile.BackColor = System.Drawing.Color.Lime;
            this.TiposMetroTile.Location = new System.Drawing.Point(105, 257);
            this.TiposMetroTile.Name = "TiposMetroTile";
            this.TiposMetroTile.Size = new System.Drawing.Size(140, 80);
            this.TiposMetroTile.TabIndex = 4;
            this.TiposMetroTile.Text = "Tipos";
            this.TiposMetroTile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.TiposMetroTile.TileImage = global::ProyectoAutos.Presentacion.Properties.Resources._0;
            this.TiposMetroTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TiposMetroTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.TiposMetroTile.UseCustomBackColor = true;
            this.TiposMetroTile.UseSelectable = true;
            this.TiposMetroTile.UseTileImage = true;
            // 
            // MarcasMetroTile
            // 
            this.MarcasMetroTile.ActiveControl = null;
            this.MarcasMetroTile.BackColor = System.Drawing.Color.Red;
            this.MarcasMetroTile.Location = new System.Drawing.Point(105, 154);
            this.MarcasMetroTile.Name = "MarcasMetroTile";
            this.MarcasMetroTile.Size = new System.Drawing.Size(140, 97);
            this.MarcasMetroTile.TabIndex = 3;
            this.MarcasMetroTile.Text = "Marcas";
            this.MarcasMetroTile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.MarcasMetroTile.TileImage = global::ProyectoAutos.Presentacion.Properties.Resources._9879;
            this.MarcasMetroTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MarcasMetroTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.MarcasMetroTile.UseCustomBackColor = true;
            this.MarcasMetroTile.UseSelectable = true;
            this.MarcasMetroTile.UseTileImage = true;
            this.MarcasMetroTile.Click += new System.EventHandler(this.MarcasMetroTile_Click);
            // 
            // SalirMetroTile
            // 
            this.SalirMetroTile.ActiveControl = null;
            this.SalirMetroTile.BackColor = System.Drawing.Color.Gray;
            this.SalirMetroTile.Location = new System.Drawing.Point(532, 434);
            this.SalirMetroTile.Name = "SalirMetroTile";
            this.SalirMetroTile.Size = new System.Drawing.Size(46, 46);
            this.SalirMetroTile.TabIndex = 3;
            this.SalirMetroTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SalirMetroTile.TileImage = global::ProyectoAutos.Presentacion.Properties.Resources._65465;
            this.SalirMetroTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SalirMetroTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.SalirMetroTile.UseCustomBackColor = true;
            this.SalirMetroTile.UseSelectable = true;
            this.SalirMetroTile.UseTileImage = true;
            this.SalirMetroTile.Click += new System.EventHandler(this.SalirMetroTile_Click);
            // 
            // AutosMetroTile
            // 
            this.AutosMetroTile.ActiveControl = null;
            this.AutosMetroTile.BackColor = System.Drawing.Color.Blue;
            this.AutosMetroTile.Location = new System.Drawing.Point(251, 154);
            this.AutosMetroTile.Name = "AutosMetroTile";
            this.AutosMetroTile.Size = new System.Drawing.Size(161, 183);
            this.AutosMetroTile.TabIndex = 2;
            this.AutosMetroTile.Text = "Autos";
            this.AutosMetroTile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AutosMetroTile.TileImage = global::ProyectoAutos.Presentacion.Properties.Resources._654;
            this.AutosMetroTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AutosMetroTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.AutosMetroTile.UseCustomBackColor = true;
            this.AutosMetroTile.UseSelectable = true;
            this.AutosMetroTile.UseTileImage = true;
            // 
            // MenuPrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 491);
            this.ControlBox = false;
            this.Controls.Add(this.TiposMetroTile);
            this.Controls.Add(this.MarcasMetroTile);
            this.Controls.Add(this.SalirMetroTile);
            this.Controls.Add(this.AutosMetroTile);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuPrincipalForm";
            this.Text = "MenuPrincipal";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autosToolStripMenuItem;
        private MetroFramework.Controls.MetroTile AutosMetroTile;
        private MetroFramework.Controls.MetroTile TiposMetroTile;
        private MetroFramework.Controls.MetroTile SalirMetroTile;
        private MetroFramework.Controls.MetroTile MarcasMetroTile;
    }
}

