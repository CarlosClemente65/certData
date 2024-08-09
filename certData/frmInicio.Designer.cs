namespace certData
{
    partial class frmInicio
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            this.ofdSeleccion = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSeleccion = new MaterialSkin.Controls.MaterialTextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtPassword1 = new MaterialSkin.Controls.MaterialTextBox();
            this.txtPassword2 = new MaterialSkin.Controls.MaterialTextBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnSeleccion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ofdSeleccion
            // 
            this.ofdSeleccion.Filter = "(fichero.pfx)|*.pfx|(fichero.p12)|*.p12";
            this.ofdSeleccion.Title = "Seleccionar fichero a importar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "Clave del certificado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(201, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Repetir clave";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 14);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nombre certificado";
            // 
            // txtSeleccion
            // 
            this.txtSeleccion.AnimateReadOnly = true;
            this.txtSeleccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSeleccion.Depth = 0;
            this.txtSeleccion.DetectUrls = false;
            this.txtSeleccion.Enabled = false;
            this.txtSeleccion.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSeleccion.LeadingIcon = null;
            this.txtSeleccion.Location = new System.Drawing.Point(14, 101);
            this.txtSeleccion.MaxLength = 50;
            this.txtSeleccion.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSeleccion.Multiline = false;
            this.txtSeleccion.Name = "txtSeleccion";
            this.txtSeleccion.ReadOnly = true;
            this.txtSeleccion.Size = new System.Drawing.Size(582, 36);
            this.txtSeleccion.TabIndex = 8;
            this.txtSeleccion.Text = "";
            this.txtSeleccion.TrailingIcon = null;
            this.txtSeleccion.UseAccent = false;
            this.txtSeleccion.UseTallSize = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "buscar.png");
            this.imageList1.Images.SetKeyName(1, "cargar.png");
            // 
            // txtPassword1
            // 
            this.txtPassword1.AnimateReadOnly = false;
            this.txtPassword1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword1.Depth = 0;
            this.txtPassword1.DetectUrls = false;
            this.txtPassword1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPassword1.LeadingIcon = null;
            this.txtPassword1.Location = new System.Drawing.Point(14, 164);
            this.txtPassword1.MaxLength = 50;
            this.txtPassword1.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPassword1.Multiline = false;
            this.txtPassword1.Name = "txtPassword1";
            this.txtPassword1.Password = true;
            this.txtPassword1.Size = new System.Drawing.Size(139, 36);
            this.txtPassword1.TabIndex = 2;
            this.txtPassword1.Text = "";
            this.txtPassword1.TrailingIcon = null;
            this.txtPassword1.UseAccent = false;
            this.txtPassword1.UseTallSize = false;
            // 
            // txtPassword2
            // 
            this.txtPassword2.AnimateReadOnly = false;
            this.txtPassword2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword2.Depth = 0;
            this.txtPassword2.DetectUrls = false;
            this.txtPassword2.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPassword2.LeadingIcon = null;
            this.txtPassword2.Location = new System.Drawing.Point(204, 164);
            this.txtPassword2.MaxLength = 50;
            this.txtPassword2.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPassword2.Multiline = false;
            this.txtPassword2.Name = "txtPassword2";
            this.txtPassword2.Password = true;
            this.txtPassword2.Size = new System.Drawing.Size(139, 36);
            this.txtPassword2.TabIndex = 3;
            this.txtPassword2.Text = "";
            this.txtPassword2.TrailingIcon = null;
            this.txtPassword2.UseAccent = false;
            this.txtPassword2.UseTallSize = false;
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCargar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCargar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnCargar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnCargar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCargar.ImageIndex = 1;
            this.btnCargar.ImageList = this.imageList1;
            this.btnCargar.Location = new System.Drawing.Point(469, 153);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Padding = new System.Windows.Forms.Padding(5);
            this.btnCargar.Size = new System.Drawing.Size(127, 47);
            this.btnCargar.TabIndex = 4;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCargar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnSeleccion
            // 
            this.btnSeleccion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSeleccion.BackColor = System.Drawing.Color.Transparent;
            this.btnSeleccion.BackgroundImage = global::certData.Properties.Resources.buscar;
            this.btnSeleccion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSeleccion.FlatAppearance.BorderSize = 0;
            this.btnSeleccion.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSeleccion.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSeleccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccion.Location = new System.Drawing.Point(565, 105);
            this.btnSeleccion.Margin = new System.Windows.Forms.Padding(0);
            this.btnSeleccion.Name = "btnSeleccion";
            this.btnSeleccion.Size = new System.Drawing.Size(25, 25);
            this.btnSeleccion.TabIndex = 1;
            this.btnSeleccion.UseVisualStyleBackColor = false;
            this.btnSeleccion.Click += new System.EventHandler(this.btnSeleccion_Click);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(610, 220);
            this.Controls.Add(this.txtPassword2);
            this.Controls.Add(this.txtPassword1);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSeleccion);
            this.Controls.Add(this.txtSeleccion);
            this.DrawerBackgroundWithAccent = true;
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerUseColors = true;
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(610, 220);
            this.MinimumSize = new System.Drawing.Size(610, 220);
            this.Name = "frmInicio";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "Diagram softrware";
            this.Text = "Seleccion certificado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog ofdSeleccion;
        private System.Windows.Forms.Button btnSeleccion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCargar;
        private MaterialSkin.Controls.MaterialTextBox txtSeleccion;
        private System.Windows.Forms.ImageList imageList1;
        private MaterialSkin.Controls.MaterialTextBox txtPassword1;
        private MaterialSkin.Controls.MaterialTextBox txtPassword2;
    }
}

