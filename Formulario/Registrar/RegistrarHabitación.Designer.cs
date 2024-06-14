namespace Las_Amapolas.Formulario.Registrar
{
    partial class RegistrarHabitación
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
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbHoteIdHabitacion = new MaterialSkin.Controls.MaterialComboBox();
            this.cbTipoHabitacion = new MaterialSkin.Controls.MaterialComboBox();
            this.slCapacidadHabitacion = new MaterialSkin.Controls.MaterialSlider();
            this.btnRegistrarHabitacion = new MaterialSkin.Controls.MaterialButton();
            this.txtPrecioHabitacion = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtNumeroHabitacion = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtIdHabitacion = new MaterialSkin.Controls.MaterialTextBox2();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(12, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(171, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Registrar habitación";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.cbHoteIdHabitacion);
            this.panel1.Controls.Add(this.cbTipoHabitacion);
            this.panel1.Controls.Add(this.slCapacidadHabitacion);
            this.panel1.Controls.Add(this.btnRegistrarHabitacion);
            this.panel1.Controls.Add(this.txtPrecioHabitacion);
            this.panel1.Controls.Add(this.txtNumeroHabitacion);
            this.panel1.Controls.Add(this.txtIdHabitacion);
            this.panel1.Location = new System.Drawing.Point(7, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(721, 308);
            this.panel1.TabIndex = 17;
            // 
            // cbHoteIdHabitacion
            // 
            this.cbHoteIdHabitacion.AutoResize = false;
            this.cbHoteIdHabitacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbHoteIdHabitacion.Depth = 0;
            this.cbHoteIdHabitacion.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbHoteIdHabitacion.DropDownHeight = 174;
            this.cbHoteIdHabitacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHoteIdHabitacion.DropDownWidth = 121;
            this.cbHoteIdHabitacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbHoteIdHabitacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbHoteIdHabitacion.FormattingEnabled = true;
            this.cbHoteIdHabitacion.Hint = "HotelId";
            this.cbHoteIdHabitacion.IntegralHeight = false;
            this.cbHoteIdHabitacion.ItemHeight = 43;
            this.cbHoteIdHabitacion.Location = new System.Drawing.Point(395, 182);
            this.cbHoteIdHabitacion.MaxDropDownItems = 4;
            this.cbHoteIdHabitacion.MouseState = MaterialSkin.MouseState.OUT;
            this.cbHoteIdHabitacion.Name = "cbHoteIdHabitacion";
            this.cbHoteIdHabitacion.Size = new System.Drawing.Size(224, 49);
            this.cbHoteIdHabitacion.StartIndex = 0;
            this.cbHoteIdHabitacion.TabIndex = 35;
            // 
            // cbTipoHabitacion
            // 
            this.cbTipoHabitacion.AutoResize = false;
            this.cbTipoHabitacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbTipoHabitacion.Depth = 0;
            this.cbTipoHabitacion.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbTipoHabitacion.DropDownHeight = 174;
            this.cbTipoHabitacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoHabitacion.DropDownWidth = 121;
            this.cbTipoHabitacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbTipoHabitacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbTipoHabitacion.FormattingEnabled = true;
            this.cbTipoHabitacion.Hint = "Tipo";
            this.cbTipoHabitacion.IntegralHeight = false;
            this.cbTipoHabitacion.ItemHeight = 43;
            this.cbTipoHabitacion.Location = new System.Drawing.Point(18, 182);
            this.cbTipoHabitacion.MaxDropDownItems = 4;
            this.cbTipoHabitacion.MouseState = MaterialSkin.MouseState.OUT;
            this.cbTipoHabitacion.Name = "cbTipoHabitacion";
            this.cbTipoHabitacion.Size = new System.Drawing.Size(224, 49);
            this.cbTipoHabitacion.StartIndex = 0;
            this.cbTipoHabitacion.TabIndex = 34;
            this.cbTipoHabitacion.Click += new System.EventHandler(this.cbTipoHabitacion_Click);
            // 
            // slCapacidadHabitacion
            // 
            this.slCapacidadHabitacion.Depth = 0;
            this.slCapacidadHabitacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.slCapacidadHabitacion.Location = new System.Drawing.Point(409, 112);
            this.slCapacidadHabitacion.MouseState = MaterialSkin.MouseState.HOVER;
            this.slCapacidadHabitacion.Name = "slCapacidadHabitacion";
            this.slCapacidadHabitacion.RangeMax = 5;
            this.slCapacidadHabitacion.Size = new System.Drawing.Size(282, 40);
            this.slCapacidadHabitacion.TabIndex = 31;
            this.slCapacidadHabitacion.Text = "Capacidad";
            this.slCapacidadHabitacion.Value = 5;
            this.slCapacidadHabitacion.ValueMax = 5;
            // 
            // btnRegistrarHabitacion
            // 
            this.btnRegistrarHabitacion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRegistrarHabitacion.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRegistrarHabitacion.Depth = 0;
            this.btnRegistrarHabitacion.HighEmphasis = true;
            this.btnRegistrarHabitacion.Icon = null;
            this.btnRegistrarHabitacion.Location = new System.Drawing.Point(510, 255);
            this.btnRegistrarHabitacion.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRegistrarHabitacion.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRegistrarHabitacion.Name = "btnRegistrarHabitacion";
            this.btnRegistrarHabitacion.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRegistrarHabitacion.Size = new System.Drawing.Size(99, 36);
            this.btnRegistrarHabitacion.TabIndex = 29;
            this.btnRegistrarHabitacion.Text = "Registrar";
            this.btnRegistrarHabitacion.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRegistrarHabitacion.UseAccentColor = false;
            this.btnRegistrarHabitacion.UseVisualStyleBackColor = true;
            this.btnRegistrarHabitacion.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // txtPrecioHabitacion
            // 
            this.txtPrecioHabitacion.AnimateReadOnly = false;
            this.txtPrecioHabitacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtPrecioHabitacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPrecioHabitacion.Depth = 0;
            this.txtPrecioHabitacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPrecioHabitacion.HideSelection = true;
            this.txtPrecioHabitacion.Hint = "Precio por noche";
            this.txtPrecioHabitacion.LeadingIcon = null;
            this.txtPrecioHabitacion.Location = new System.Drawing.Point(395, 28);
            this.txtPrecioHabitacion.MaxLength = 32767;
            this.txtPrecioHabitacion.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPrecioHabitacion.Name = "txtPrecioHabitacion";
            this.txtPrecioHabitacion.PasswordChar = '\0';
            this.txtPrecioHabitacion.PrefixSuffixText = null;
            this.txtPrecioHabitacion.ReadOnly = false;
            this.txtPrecioHabitacion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPrecioHabitacion.SelectedText = "";
            this.txtPrecioHabitacion.SelectionLength = 0;
            this.txtPrecioHabitacion.SelectionStart = 0;
            this.txtPrecioHabitacion.ShortcutsEnabled = true;
            this.txtPrecioHabitacion.Size = new System.Drawing.Size(265, 48);
            this.txtPrecioHabitacion.TabIndex = 26;
            this.txtPrecioHabitacion.TabStop = false;
            this.txtPrecioHabitacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPrecioHabitacion.TrailingIcon = null;
            this.txtPrecioHabitacion.UseSystemPasswordChar = false;
            // 
            // txtNumeroHabitacion
            // 
            this.txtNumeroHabitacion.AnimateReadOnly = false;
            this.txtNumeroHabitacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtNumeroHabitacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNumeroHabitacion.Depth = 0;
            this.txtNumeroHabitacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNumeroHabitacion.HideSelection = true;
            this.txtNumeroHabitacion.Hint = "Número";
            this.txtNumeroHabitacion.LeadingIcon = null;
            this.txtNumeroHabitacion.Location = new System.Drawing.Point(18, 104);
            this.txtNumeroHabitacion.MaxLength = 32767;
            this.txtNumeroHabitacion.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNumeroHabitacion.Name = "txtNumeroHabitacion";
            this.txtNumeroHabitacion.PasswordChar = '\0';
            this.txtNumeroHabitacion.PrefixSuffixText = null;
            this.txtNumeroHabitacion.ReadOnly = false;
            this.txtNumeroHabitacion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNumeroHabitacion.SelectedText = "";
            this.txtNumeroHabitacion.SelectionLength = 0;
            this.txtNumeroHabitacion.SelectionStart = 0;
            this.txtNumeroHabitacion.ShortcutsEnabled = true;
            this.txtNumeroHabitacion.Size = new System.Drawing.Size(215, 48);
            this.txtNumeroHabitacion.TabIndex = 23;
            this.txtNumeroHabitacion.TabStop = false;
            this.txtNumeroHabitacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNumeroHabitacion.TrailingIcon = null;
            this.txtNumeroHabitacion.UseSystemPasswordChar = false;
            // 
            // txtIdHabitacion
            // 
            this.txtIdHabitacion.AnimateReadOnly = false;
            this.txtIdHabitacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtIdHabitacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtIdHabitacion.Depth = 0;
            this.txtIdHabitacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtIdHabitacion.HideSelection = true;
            this.txtIdHabitacion.Hint = "ID";
            this.txtIdHabitacion.LeadingIcon = null;
            this.txtIdHabitacion.Location = new System.Drawing.Point(18, 28);
            this.txtIdHabitacion.MaxLength = 32767;
            this.txtIdHabitacion.MouseState = MaterialSkin.MouseState.OUT;
            this.txtIdHabitacion.Name = "txtIdHabitacion";
            this.txtIdHabitacion.PasswordChar = '\0';
            this.txtIdHabitacion.PrefixSuffixText = null;
            this.txtIdHabitacion.ReadOnly = false;
            this.txtIdHabitacion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtIdHabitacion.SelectedText = "";
            this.txtIdHabitacion.SelectionLength = 0;
            this.txtIdHabitacion.SelectionStart = 0;
            this.txtIdHabitacion.ShortcutsEnabled = true;
            this.txtIdHabitacion.Size = new System.Drawing.Size(160, 48);
            this.txtIdHabitacion.TabIndex = 22;
            this.txtIdHabitacion.TabStop = false;
            this.txtIdHabitacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtIdHabitacion.TrailingIcon = null;
            this.txtIdHabitacion.UseSystemPasswordChar = false;
            // 
            // RegistrarHabitación
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 368);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Name = "RegistrarHabitación";
            this.Text = "RegistrarHabitación";
            this.Load += new System.EventHandler(this.RegistrarHabitación_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialSlider slCapacidadHabitacion;
        private MaterialSkin.Controls.MaterialButton btnRegistrarHabitacion;
        private MaterialSkin.Controls.MaterialTextBox2 txtPrecioHabitacion;
        private MaterialSkin.Controls.MaterialTextBox2 txtNumeroHabitacion;
        private MaterialSkin.Controls.MaterialTextBox2 txtIdHabitacion;
        private MaterialSkin.Controls.MaterialComboBox cbTipoHabitacion;
        private MaterialSkin.Controls.MaterialComboBox cbHoteIdHabitacion;
    }
}