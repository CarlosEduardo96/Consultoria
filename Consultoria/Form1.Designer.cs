
namespace Consultoria
{
    partial class Form1
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
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPuesto = new System.Windows.Forms.Button();
            this.btnDepartamento = new System.Windows.Forms.Button();
            this.btnEmpresa = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.imgCompany = new System.Windows.Forms.PictureBox();
            this.Main = new System.Windows.Forms.Panel();
            this.MenuPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCompany)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(97)))), ((int)(((byte)(140)))));
            this.MenuPanel.Controls.Add(this.panel2);
            this.MenuPanel.Controls.Add(this.panel1);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(206, 463);
            this.MenuPanel.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnPuesto);
            this.panel2.Controls.Add(this.btnDepartamento);
            this.panel2.Controls.Add(this.btnEmpresa);
            this.panel2.Location = new System.Drawing.Point(3, 171);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 280);
            this.panel2.TabIndex = 2;
            // 
            // btnPuesto
            // 
            this.btnPuesto.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPuesto.FlatAppearance.BorderSize = 0;
            this.btnPuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPuesto.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPuesto.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPuesto.Image = global::Consultoria.Properties.Resources.outline_badge_white_36dp;
            this.btnPuesto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPuesto.Location = new System.Drawing.Point(0, 104);
            this.btnPuesto.Name = "btnPuesto";
            this.btnPuesto.Size = new System.Drawing.Size(200, 52);
            this.btnPuesto.TabIndex = 3;
            this.btnPuesto.Text = "    Puesto";
            this.btnPuesto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPuesto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPuesto.UseVisualStyleBackColor = true;
            this.btnPuesto.Click += new System.EventHandler(this.btnPuesto_Click);
            // 
            // btnDepartamento
            // 
            this.btnDepartamento.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDepartamento.FlatAppearance.BorderSize = 0;
            this.btnDepartamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepartamento.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepartamento.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDepartamento.Image = global::Consultoria.Properties.Resources.outline_home_work_white_36dp;
            this.btnDepartamento.Location = new System.Drawing.Point(0, 52);
            this.btnDepartamento.Name = "btnDepartamento";
            this.btnDepartamento.Size = new System.Drawing.Size(200, 52);
            this.btnDepartamento.TabIndex = 2;
            this.btnDepartamento.Text = "    Departamento";
            this.btnDepartamento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDepartamento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDepartamento.UseVisualStyleBackColor = true;
            this.btnDepartamento.Click += new System.EventHandler(this.btnDepartamento_Click);
            // 
            // btnEmpresa
            // 
            this.btnEmpresa.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmpresa.FlatAppearance.BorderSize = 0;
            this.btnEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpresa.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpresa.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEmpresa.Image = global::Consultoria.Properties.Resources.outline_business_white_36dp;
            this.btnEmpresa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpresa.Location = new System.Drawing.Point(0, 0);
            this.btnEmpresa.Name = "btnEmpresa";
            this.btnEmpresa.Size = new System.Drawing.Size(200, 52);
            this.btnEmpresa.TabIndex = 0;
            this.btnEmpresa.Text = "    Empresa";
            this.btnEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpresa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmpresa.UseVisualStyleBackColor = true;
            this.btnEmpresa.Click += new System.EventHandler(this.btnEmpresa_Click_1);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.imgCompany);
            this.panel1.Location = new System.Drawing.Point(3, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 123);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.label1.Location = new System.Drawing.Point(6, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gestor de Compañias";
            // 
            // imgCompany
            // 
            this.imgCompany.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imgCompany.Image = global::Consultoria.Properties.Resources.outline_business_white_36dp1;
            this.imgCompany.Location = new System.Drawing.Point(63, 3);
            this.imgCompany.Name = "imgCompany";
            this.imgCompany.Size = new System.Drawing.Size(79, 78);
            this.imgCompany.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imgCompany.TabIndex = 0;
            this.imgCompany.TabStop = false;
            // 
            // Main
            // 
            this.Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main.Location = new System.Drawing.Point(206, 0);
            this.Main.Name = "Main";
            this.Main.Size = new System.Drawing.Size(537, 463);
            this.Main.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 463);
            this.Controls.Add(this.Main);
            this.Controls.Add(this.MenuPanel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(759, 502);
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestor de Compañias";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MenuPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCompany)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.PictureBox imgCompany;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel Main;
        private System.Windows.Forms.Button btnEmpresa;
        private System.Windows.Forms.Button btnPuesto;
        private System.Windows.Forms.Button btnDepartamento;
    }
}

