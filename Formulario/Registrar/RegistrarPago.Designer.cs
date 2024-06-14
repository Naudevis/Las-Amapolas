namespace Las_Amapolas.Formulario.Registrar
{
    partial class RegistrarPago
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
            this.btnLlamarRegistrarReservación = new System.Windows.Forms.Button();
            this.cbMetodoPago = new MaterialSkin.Controls.MaterialComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.datePago = new System.Windows.Forms.DateTimePicker();
            this.btnRegistrarPago = new MaterialSkin.Controls.MaterialButton();
            this.txtMontoPago = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtReservaIdPago = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtIdPago = new MaterialSkin.Controls.MaterialTextBox2();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(21, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Registrar pago";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnLlamarRegistrarReservación);
            this.panel1.Controls.Add(this.cbMetodoPago);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.datePago);
            this.panel1.Controls.Add(this.btnRegistrarPago);
            this.panel1.Controls.Add(this.txtMontoPago);
            this.panel1.Controls.Add(this.txtReservaIdPago);
            this.panel1.Controls.Add(this.txtIdPago);
            this.panel1.Location = new System.Drawing.Point(16, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(671, 304);
            this.panel1.TabIndex = 17;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnLlamarRegistrarReservación
            // 
            this.btnLlamarRegistrarReservación.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnLlamarRegistrarReservación.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLlamarRegistrarReservación.ForeColor = System.Drawing.Color.White;
            this.btnLlamarRegistrarReservación.Location = new System.Drawing.Point(194, 124);
            this.btnLlamarRegistrarReservación.Name = "btnLlamarRegistrarReservación";
            this.btnLlamarRegistrarReservación.Size = new System.Drawing.Size(43, 40);
            this.btnLlamarRegistrarReservación.TabIndex = 31;
            this.btnLlamarRegistrarReservación.Text = "+";
            this.btnLlamarRegistrarReservación.UseVisualStyleBackColor = false;
            // 
            // cbMetodoPago
            // 
            this.cbMetodoPago.AutoResize = false;
            this.cbMetodoPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbMetodoPago.Depth = 0;
            this.cbMetodoPago.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbMetodoPago.DropDownHeight = 174;
            this.cbMetodoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMetodoPago.DropDownWidth = 121;
            this.cbMetodoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbMetodoPago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbMetodoPago.FormattingEnabled = true;
            this.cbMetodoPago.Hint = "Metodo Pago";
            this.cbMetodoPago.IntegralHeight = false;
            this.cbMetodoPago.ItemHeight = 43;
            this.cbMetodoPago.Location = new System.Drawing.Point(284, 115);
            this.cbMetodoPago.MaxDropDownItems = 4;
            this.cbMetodoPago.MouseState = MaterialSkin.MouseState.OUT;
            this.cbMetodoPago.Name = "cbMetodoPago";
            this.cbMetodoPago.Size = new System.Drawing.Size(261, 49);
            this.cbMetodoPago.StartIndex = 0;
            this.cbMetodoPago.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(279, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 31);
            this.label1.TabIndex = 44;
            this.label1.Text = "Fecha pago";
            // 
            // datePago
            // 
            this.datePago.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePago.Location = new System.Drawing.Point(282, 62);
            this.datePago.Name = "datePago";
            this.datePago.Size = new System.Drawing.Size(376, 23);
            this.datePago.TabIndex = 42;
            // 
            // btnRegistrarPago
            // 
            this.btnRegistrarPago.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRegistrarPago.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRegistrarPago.Depth = 0;
            this.btnRegistrarPago.HighEmphasis = true;
            this.btnRegistrarPago.Icon = null;
            this.btnRegistrarPago.Location = new System.Drawing.Point(305, 193);
            this.btnRegistrarPago.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRegistrarPago.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRegistrarPago.Name = "btnRegistrarPago";
            this.btnRegistrarPago.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRegistrarPago.Size = new System.Drawing.Size(99, 36);
            this.btnRegistrarPago.TabIndex = 29;
            this.btnRegistrarPago.Text = "Registrar";
            this.btnRegistrarPago.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRegistrarPago.UseAccentColor = false;
            this.btnRegistrarPago.UseVisualStyleBackColor = true;
            this.btnRegistrarPago.Click += new System.EventHandler(this.btnRegistrarPago_Click);
            // 
            // txtMontoPago
            // 
            this.txtMontoPago.AnimateReadOnly = false;
            this.txtMontoPago.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtMontoPago.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtMontoPago.Depth = 0;
            this.txtMontoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtMontoPago.HideSelection = true;
            this.txtMontoPago.Hint = "Monto";
            this.txtMontoPago.LeadingIcon = null;
            this.txtMontoPago.Location = new System.Drawing.Point(18, 193);
            this.txtMontoPago.MaxLength = 32767;
            this.txtMontoPago.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMontoPago.Name = "txtMontoPago";
            this.txtMontoPago.PasswordChar = '\0';
            this.txtMontoPago.PrefixSuffixText = null;
            this.txtMontoPago.ReadOnly = false;
            this.txtMontoPago.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMontoPago.SelectedText = "";
            this.txtMontoPago.SelectionLength = 0;
            this.txtMontoPago.SelectionStart = 0;
            this.txtMontoPago.ShortcutsEnabled = true;
            this.txtMontoPago.Size = new System.Drawing.Size(160, 48);
            this.txtMontoPago.TabIndex = 24;
            this.txtMontoPago.TabStop = false;
            this.txtMontoPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMontoPago.TrailingIcon = null;
            this.txtMontoPago.UseSystemPasswordChar = false;
            // 
            // txtReservaIdPago
            // 
            this.txtReservaIdPago.AnimateReadOnly = false;
            this.txtReservaIdPago.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtReservaIdPago.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtReservaIdPago.Depth = 0;
            this.txtReservaIdPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtReservaIdPago.HideSelection = true;
            this.txtReservaIdPago.Hint = "ReservaId";
            this.txtReservaIdPago.LeadingIcon = null;
            this.txtReservaIdPago.Location = new System.Drawing.Point(18, 115);
            this.txtReservaIdPago.MaxLength = 32767;
            this.txtReservaIdPago.MouseState = MaterialSkin.MouseState.OUT;
            this.txtReservaIdPago.Name = "txtReservaIdPago";
            this.txtReservaIdPago.PasswordChar = '\0';
            this.txtReservaIdPago.PrefixSuffixText = null;
            this.txtReservaIdPago.ReadOnly = false;
            this.txtReservaIdPago.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtReservaIdPago.SelectedText = "";
            this.txtReservaIdPago.SelectionLength = 0;
            this.txtReservaIdPago.SelectionStart = 0;
            this.txtReservaIdPago.ShortcutsEnabled = true;
            this.txtReservaIdPago.Size = new System.Drawing.Size(160, 48);
            this.txtReservaIdPago.TabIndex = 23;
            this.txtReservaIdPago.TabStop = false;
            this.txtReservaIdPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtReservaIdPago.TrailingIcon = null;
            this.txtReservaIdPago.UseSystemPasswordChar = false;
            // 
            // txtIdPago
            // 
            this.txtIdPago.AnimateReadOnly = false;
            this.txtIdPago.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtIdPago.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtIdPago.Depth = 0;
            this.txtIdPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtIdPago.HideSelection = true;
            this.txtIdPago.Hint = "ID";
            this.txtIdPago.LeadingIcon = null;
            this.txtIdPago.Location = new System.Drawing.Point(18, 28);
            this.txtIdPago.MaxLength = 32767;
            this.txtIdPago.MouseState = MaterialSkin.MouseState.OUT;
            this.txtIdPago.Name = "txtIdPago";
            this.txtIdPago.PasswordChar = '\0';
            this.txtIdPago.PrefixSuffixText = null;
            this.txtIdPago.ReadOnly = false;
            this.txtIdPago.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtIdPago.SelectedText = "";
            this.txtIdPago.SelectionLength = 0;
            this.txtIdPago.SelectionStart = 0;
            this.txtIdPago.ShortcutsEnabled = true;
            this.txtIdPago.Size = new System.Drawing.Size(160, 48);
            this.txtIdPago.TabIndex = 22;
            this.txtIdPago.TabStop = false;
            this.txtIdPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtIdPago.TrailingIcon = null;
            this.txtIdPago.UseSystemPasswordChar = false;
            // 
            // RegistrarPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Name = "RegistrarPago";
            this.Text = "RegistrarPago";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialButton btnRegistrarPago;
        private MaterialSkin.Controls.MaterialTextBox2 txtMontoPago;
        private MaterialSkin.Controls.MaterialTextBox2 txtReservaIdPago;
        private MaterialSkin.Controls.MaterialTextBox2 txtIdPago;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker datePago;
        private MaterialSkin.Controls.MaterialComboBox cbMetodoPago;
        private System.Windows.Forms.Button btnLlamarRegistrarReservación;
    }
}