
namespace WindowsFormsApp1
{
    partial class VentanaPrincipal
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
            this.btnRun = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtbxCajaPrincipal = new System.Windows.Forms.TextBox();
            this.txtbxSecundaria = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnRun
            // 
            this.btnRun.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRun.BackColor = System.Drawing.SystemColors.Info;
            this.btnRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRun.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRun.Location = new System.Drawing.Point(12, 101);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(370, 76);
            this.btnRun.TabIndex = 0;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = false;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTitulo.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Red;
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(370, 51);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Primera aplicación :)";
            this.lblTitulo.MouseLeave += new System.EventHandler(this.lblTitulo_MouseLeave);
            this.lblTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblTitulo_MouseMove);
            // 
            // txtbxCajaPrincipal
            // 
            this.txtbxCajaPrincipal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtbxCajaPrincipal.Location = new System.Drawing.Point(12, 75);
            this.txtbxCajaPrincipal.MaxLength = 10;
            this.txtbxCajaPrincipal.Name = "txtbxCajaPrincipal";
            this.txtbxCajaPrincipal.Size = new System.Drawing.Size(370, 20);
            this.txtbxCajaPrincipal.TabIndex = 2;
            this.txtbxCajaPrincipal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxCajaPrincipal_KeyPress);
            // 
            // txtbxSecundaria
            // 
            this.txtbxSecundaria.Location = new System.Drawing.Point(12, 183);
            this.txtbxSecundaria.Multiline = true;
            this.txtbxSecundaria.Name = "txtbxSecundaria";
            this.txtbxSecundaria.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtbxSecundaria.Size = new System.Drawing.Size(370, 106);
            this.txtbxSecundaria.TabIndex = 3;
            this.txtbxSecundaria.Leave += new System.EventHandler(this.txtbxSecundaria_Leave);
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(407, 452);
            this.Controls.Add(this.txtbxSecundaria);
            this.Controls.Add(this.txtbxCajaPrincipal);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnRun);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VentanaPrincipal";
            this.Opacity = 0.5D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VentanaPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.VentanaPrincipal_Load);
            this.Click += new System.EventHandler(this.VentanaPrincipal_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtbxCajaPrincipal;
        private System.Windows.Forms.TextBox txtbxSecundaria;
    }
}

