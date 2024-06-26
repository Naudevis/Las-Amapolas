﻿namespace Las_Amapolas.Formulario.Registrar
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
            this.btnAgregar = new MaterialSkin.Controls.MaterialButton();
            this.txtTipoDeHabitacion = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnLlamarRegistrarHabitacion = new System.Windows.Forms.Button();
            this.txtHotelIdHabitacion = new MaterialSkin.Controls.MaterialTextBox2();
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
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.txtTipoDeHabitacion);
            this.panel1.Controls.Add(this.btnLlamarRegistrarHabitacion);
            this.panel1.Controls.Add(this.txtHotelIdHabitacion);
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
            // btnAgregar
            // 
            this.btnAgregar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAgregar.Depth = 0;
            this.btnAgregar.HighEmphasis = true;
            this.btnAgregar.Icon = null;
            this.btnAgregar.Location = new System.Drawing.Point(335, 255);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAgregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAgregar.Size = new System.Drawing.Size(88, 36);
            this.btnAgregar.TabIndex = 40;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAgregar.UseAccentColor = false;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtTipoDeHabitacion
            // 
            this.txtTipoDeHabitacion.AnimateReadOnly = false;
            this.txtTipoDeHabitacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtTipoDeHabitacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTipoDeHabitacion.Depth = 0;
            this.txtTipoDeHabitacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTipoDeHabitacion.HideSelection = true;
            this.txtTipoDeHabitacion.Hint = "Tipo de habitación";
            this.txtTipoDeHabitacion.LeadingIcon = null;
            this.txtTipoDeHabitacion.Location = new System.Drawing.Point(18, 255);
            this.txtTipoDeHabitacion.MaxLength = 32767;
            this.txtTipoDeHabitacion.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTipoDeHabitacion.Name = "txtTipoDeHabitacion";
            this.txtTipoDeHabitacion.PasswordChar = '\0';
            this.txtTipoDeHabitacion.PrefixSuffixText = null;
            this.txtTipoDeHabitacion.ReadOnly = false;
            this.txtTipoDeHabitacion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTipoDeHabitacion.SelectedText = "";
            this.txtTipoDeHabitacion.SelectionLength = 0;
            this.txtTipoDeHabitacion.SelectionStart = 0;
            this.txtTipoDeHabitacion.ShortcutsEnabled = true;
            this.txtTipoDeHabitacion.Size = new System.Drawing.Size(310, 48);
            this.txtTipoDeHabitacion.TabIndex = 38;
            this.txtTipoDeHabitacion.TabStop = false;
            this.txtTipoDeHabitacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTipoDeHabitacion.TrailingIcon = null;
            this.txtTipoDeHabitacion.UseSystemPasswordChar = false;
            // 
            // btnLlamarRegistrarHabitacion
            // 
            this.btnLlamarRegistrarHabitacion.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnLlamarRegistrarHabitacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLlamarRegistrarHabitacion.ForeColor = System.Drawing.Color.White;
            this.btnLlamarRegistrarHabitacion.Location = new System.Drawing.Point(323, 191);
            this.btnLlamarRegistrarHabitacion.Name = "btnLlamarRegistrarHabitacion";
            this.btnLlamarRegistrarHabitacion.Size = new System.Drawing.Size(43, 40);
            this.btnLlamarRegistrarHabitacion.TabIndex = 37;
            this.btnLlamarRegistrarHabitacion.Text = "+";
            this.btnLlamarRegistrarHabitacion.UseVisualStyleBackColor = false;
            this.btnLlamarRegistrarHabitacion.Click += new System.EventHandler(this.btnLlamarRegistrarHabitacion_Click);
            // 
            // txtHotelIdHabitacion
            // 
            this.txtHotelIdHabitacion.AnimateReadOnly = false;
            this.txtHotelIdHabitacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtHotelIdHabitacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtHotelIdHabitacion.Depth = 0;
            this.txtHotelIdHabitacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtHotelIdHabitacion.HideSelection = true;
            this.txtHotelIdHabitacion.Hint = "HotelId";
            this.txtHotelIdHabitacion.LeadingIcon = null;
            this.txtHotelIdHabitacion.Location = new System.Drawing.Point(395, 183);
            this.txtHotelIdHabitacion.MaxLength = 32767;
            this.txtHotelIdHabitacion.MouseState = MaterialSkin.MouseState.OUT;
            this.txtHotelIdHabitacion.Name = "txtHotelIdHabitacion";
            this.txtHotelIdHabitacion.PasswordChar = '\0';
            this.txtHotelIdHabitacion.PrefixSuffixText = null;
            this.txtHotelIdHabitacion.ReadOnly = true;
            this.txtHotelIdHabitacion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtHotelIdHabitacion.SelectedText = "";
            this.txtHotelIdHabitacion.SelectionLength = 0;
            this.txtHotelIdHabitacion.SelectionStart = 0;
            this.txtHotelIdHabitacion.ShortcutsEnabled = true;
            this.txtHotelIdHabitacion.Size = new System.Drawing.Size(250, 48);
            this.txtHotelIdHabitacion.TabIndex = 36;
            this.txtHotelIdHabitacion.TabStop = false;
            this.txtHotelIdHabitacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtHotelIdHabitacion.TrailingIcon = null;
            this.txtHotelIdHabitacion.UseSystemPasswordChar = false;
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
            this.cbTipoHabitacion.Size = new System.Drawing.Size(299, 49);
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
            this.txtIdHabitacion.ReadOnly = true;
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
        private MaterialSkin.Controls.MaterialTextBox2 txtHotelIdHabitacion;
        private System.Windows.Forms.Button btnLlamarRegistrarHabitacion;
        private MaterialSkin.Controls.MaterialTextBox2 txtTipoDeHabitacion;
        private MaterialSkin.Controls.MaterialButton btnAgregar;
    }
}