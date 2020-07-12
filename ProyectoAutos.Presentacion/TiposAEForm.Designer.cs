namespace ProyectoAutos.Presentacion
{
    partial class TiposAEForm
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
            this.CancelarMetroButton = new MetroFramework.Controls.MetroButton();
            this.OkeyMetroButton = new MetroFramework.Controls.MetroButton();
            this.tipoMetroTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // CancelarMetroButton
            // 
            this.CancelarMetroButton.BackgroundImage = global::ProyectoAutos.Presentacion.Properties.Resources.Cancelar1;
            this.CancelarMetroButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CancelarMetroButton.Location = new System.Drawing.Point(280, 124);
            this.CancelarMetroButton.Name = "CancelarMetroButton";
            this.CancelarMetroButton.Size = new System.Drawing.Size(64, 45);
            this.CancelarMetroButton.TabIndex = 5;
            this.CancelarMetroButton.UseSelectable = true;
            this.CancelarMetroButton.Click += new System.EventHandler(this.CancelarMetroButton_Click);
            // 
            // OkeyMetroButton
            // 
            this.OkeyMetroButton.BackgroundImage = global::ProyectoAutos.Presentacion.Properties.Resources.Aceptar;
            this.OkeyMetroButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.OkeyMetroButton.Location = new System.Drawing.Point(69, 124);
            this.OkeyMetroButton.Name = "OkeyMetroButton";
            this.OkeyMetroButton.Size = new System.Drawing.Size(64, 45);
            this.OkeyMetroButton.TabIndex = 6;
            this.OkeyMetroButton.UseSelectable = true;
            this.OkeyMetroButton.Click += new System.EventHandler(this.OkeyMetroButton_Click);
            // 
            // tipoMetroTextBox
            // 
            // 
            // 
            // 
            this.tipoMetroTextBox.CustomButton.Image = null;
            this.tipoMetroTextBox.CustomButton.Location = new System.Drawing.Point(167, 1);
            this.tipoMetroTextBox.CustomButton.Name = "";
            this.tipoMetroTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tipoMetroTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tipoMetroTextBox.CustomButton.TabIndex = 1;
            this.tipoMetroTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tipoMetroTextBox.CustomButton.UseSelectable = true;
            this.tipoMetroTextBox.CustomButton.Visible = false;
            this.tipoMetroTextBox.Lines = new string[0];
            this.tipoMetroTextBox.Location = new System.Drawing.Point(120, 79);
            this.tipoMetroTextBox.MaxLength = 50;
            this.tipoMetroTextBox.Name = "tipoMetroTextBox";
            this.tipoMetroTextBox.PasswordChar = '\0';
            this.tipoMetroTextBox.PromptText = "Ingresar Tipo";
            this.tipoMetroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tipoMetroTextBox.SelectedText = "";
            this.tipoMetroTextBox.SelectionLength = 0;
            this.tipoMetroTextBox.SelectionStart = 0;
            this.tipoMetroTextBox.ShortcutsEnabled = true;
            this.tipoMetroTextBox.Size = new System.Drawing.Size(189, 23);
            this.tipoMetroTextBox.TabIndex = 4;
            this.tipoMetroTextBox.UseSelectable = true;
            this.tipoMetroTextBox.WaterMark = "Ingresar Tipo";
            this.tipoMetroTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tipoMetroTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(51, 79);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(38, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Tipo:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // TiposAEForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 213);
            this.ControlBox = false;
            this.Controls.Add(this.CancelarMetroButton);
            this.Controls.Add(this.OkeyMetroButton);
            this.Controls.Add(this.tipoMetroTextBox);
            this.Controls.Add(this.metroLabel1);
            this.Name = "TiposAEForm";
            this.Text = "TiposAEForm";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton CancelarMetroButton;
        private MetroFramework.Controls.MetroButton OkeyMetroButton;
        private MetroFramework.Controls.MetroTextBox tipoMetroTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}