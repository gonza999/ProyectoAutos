namespace ProyectoAutos.Presentacion
{
    partial class MarcasAEForm
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
            this.components = new System.ComponentModel.Container();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.marcaMetroTextBox = new MetroFramework.Controls.MetroTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.CancelarMetroButton = new MetroFramework.Controls.MetroButton();
            this.OkeyMetroButton = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(34, 85);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(49, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Marca:";
            // 
            // marcaMetroTextBox
            // 
            // 
            // 
            // 
            this.marcaMetroTextBox.CustomButton.Image = null;
            this.marcaMetroTextBox.CustomButton.Location = new System.Drawing.Point(167, 1);
            this.marcaMetroTextBox.CustomButton.Name = "";
            this.marcaMetroTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.marcaMetroTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.marcaMetroTextBox.CustomButton.TabIndex = 1;
            this.marcaMetroTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.marcaMetroTextBox.CustomButton.UseSelectable = true;
            this.marcaMetroTextBox.CustomButton.Visible = false;
            this.marcaMetroTextBox.Lines = new string[0];
            this.marcaMetroTextBox.Location = new System.Drawing.Point(103, 85);
            this.marcaMetroTextBox.MaxLength = 32767;
            this.marcaMetroTextBox.Name = "marcaMetroTextBox";
            this.marcaMetroTextBox.PasswordChar = '\0';
            this.marcaMetroTextBox.PromptText = "Ingresar Marca";
            this.marcaMetroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.marcaMetroTextBox.SelectedText = "";
            this.marcaMetroTextBox.SelectionLength = 0;
            this.marcaMetroTextBox.SelectionStart = 0;
            this.marcaMetroTextBox.ShortcutsEnabled = true;
            this.marcaMetroTextBox.Size = new System.Drawing.Size(189, 23);
            this.marcaMetroTextBox.TabIndex = 1;
            this.marcaMetroTextBox.UseSelectable = true;
            this.marcaMetroTextBox.WaterMark = "Ingresar Marca";
            this.marcaMetroTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.marcaMetroTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // CancelarMetroButton
            // 
            this.CancelarMetroButton.BackgroundImage = global::ProyectoAutos.Presentacion.Properties.Resources.Cancelar1;
            this.CancelarMetroButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CancelarMetroButton.Location = new System.Drawing.Point(263, 130);
            this.CancelarMetroButton.Name = "CancelarMetroButton";
            this.CancelarMetroButton.Size = new System.Drawing.Size(64, 45);
            this.CancelarMetroButton.TabIndex = 2;
            this.CancelarMetroButton.UseSelectable = true;
            this.CancelarMetroButton.Click += new System.EventHandler(this.CancelarMetroButton_Click);
            // 
            // OkeyMetroButton
            // 
            this.OkeyMetroButton.BackgroundImage = global::ProyectoAutos.Presentacion.Properties.Resources.Aceptar;
            this.OkeyMetroButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.OkeyMetroButton.Location = new System.Drawing.Point(52, 130);
            this.OkeyMetroButton.Name = "OkeyMetroButton";
            this.OkeyMetroButton.Size = new System.Drawing.Size(64, 45);
            this.OkeyMetroButton.TabIndex = 2;
            this.OkeyMetroButton.UseSelectable = true;
            this.OkeyMetroButton.Click += new System.EventHandler(this.OkeyMetroButton_Click);
            // 
            // MarcasAEForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 196);
            this.Controls.Add(this.CancelarMetroButton);
            this.Controls.Add(this.OkeyMetroButton);
            this.Controls.Add(this.marcaMetroTextBox);
            this.Controls.Add(this.metroLabel1);
            this.Name = "MarcasAEForm";
            this.Text = "Marcas";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox marcaMetroTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private MetroFramework.Controls.MetroButton CancelarMetroButton;
        private MetroFramework.Controls.MetroButton OkeyMetroButton;
    }
}