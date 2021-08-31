
namespace Consultoria.View.Empresa
{
    partial class Empresa
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabEmpresa = new System.Windows.Forms.TabControl();
            this.Consultar = new System.Windows.Forms.TabPage();
            this.MensajeOpction = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lbRFC = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ListaEmpresas = new System.Windows.Forms.DataGridView();
            this.RFC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearchRFC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Agregar_Actualizar = new System.Windows.Forms.TabPage();
            this.Limpiar = new System.Windows.Forms.Button();
            this.panelMensaje = new System.Windows.Forms.Panel();
            this.lbMensaje = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtRFC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.Watch_Empresa = new System.Windows.Forms.Timer(this.components);
            this.tabEmpresa.SuspendLayout();
            this.Consultar.SuspendLayout();
            this.MensajeOpction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListaEmpresas)).BeginInit();
            this.Agregar_Actualizar.SuspendLayout();
            this.panelMensaje.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabEmpresa
            // 
            this.tabEmpresa.Controls.Add(this.Consultar);
            this.tabEmpresa.Controls.Add(this.Agregar_Actualizar);
            this.tabEmpresa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabEmpresa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabEmpresa.ItemSize = new System.Drawing.Size(56, 30);
            this.tabEmpresa.Location = new System.Drawing.Point(0, 0);
            this.tabEmpresa.Name = "tabEmpresa";
            this.tabEmpresa.SelectedIndex = 0;
            this.tabEmpresa.Size = new System.Drawing.Size(537, 463);
            this.tabEmpresa.TabIndex = 1;
            this.tabEmpresa.SelectedIndexChanged += new System.EventHandler(this.Empresa_Load);
            // 
            // Consultar
            // 
            this.Consultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(123)))));
            this.Consultar.Controls.Add(this.MensajeOpction);
            this.Consultar.Controls.Add(this.ListaEmpresas);
            this.Consultar.Controls.Add(this.txtSearchRFC);
            this.Consultar.Controls.Add(this.label4);
            this.Consultar.Location = new System.Drawing.Point(4, 34);
            this.Consultar.Name = "Consultar";
            this.Consultar.Size = new System.Drawing.Size(529, 425);
            this.Consultar.TabIndex = 0;
            this.Consultar.Text = "Consultar";
            // 
            // MensajeOpction
            // 
            this.MensajeOpction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(165)))), ((int)(((byte)(137)))));
            this.MensajeOpction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MensajeOpction.Controls.Add(this.btnCerrar);
            this.MensajeOpction.Controls.Add(this.btnEditar);
            this.MensajeOpction.Controls.Add(this.btnEliminar);
            this.MensajeOpction.Controls.Add(this.lbRFC);
            this.MensajeOpction.Controls.Add(this.label5);
            this.MensajeOpction.Location = new System.Drawing.Point(121, 167);
            this.MensajeOpction.Name = "MensajeOpction";
            this.MensajeOpction.Size = new System.Drawing.Size(292, 153);
            this.MensajeOpction.TabIndex = 6;
            this.MensajeOpction.Visible = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.btnCerrar.FlatAppearance.BorderSize = 2;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCerrar.Location = new System.Drawing.Point(256, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(31, 33);
            this.btnCerrar.TabIndex = 11;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(208)))), ((int)(((byte)(63)))));
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEditar.Location = new System.Drawing.Point(166, 103);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(87, 31);
            this.btnEditar.TabIndex = 10;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEliminar.Location = new System.Drawing.Point(41, 103);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(87, 31);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lbRFC
            // 
            this.lbRFC.AutoSize = true;
            this.lbRFC.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbRFC.Location = new System.Drawing.Point(37, 24);
            this.lbRFC.Name = "lbRFC";
            this.lbRFC.Size = new System.Drawing.Size(171, 21);
            this.lbRFC.TabIndex = 8;
            this.lbRFC.Text = "RFC: XXXXXXXXXXXXXX";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(70, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "¿Que Desea Realizar?";
            // 
            // ListaEmpresas
            // 
            this.ListaEmpresas.AllowUserToAddRows = false;
            this.ListaEmpresas.AllowUserToDeleteRows = false;
            this.ListaEmpresas.AllowUserToResizeColumns = false;
            this.ListaEmpresas.AllowUserToResizeRows = false;
            this.ListaEmpresas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ListaEmpresas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(123)))));
            this.ListaEmpresas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListaEmpresas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ListaEmpresas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(123)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(123)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListaEmpresas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ListaEmpresas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ListaEmpresas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RFC,
            this.Nombre,
            this.Direccion});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(74)))), ((int)(((byte)(25)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ListaEmpresas.DefaultCellStyle = dataGridViewCellStyle2;
            this.ListaEmpresas.EnableHeadersVisualStyles = false;
            this.ListaEmpresas.GridColor = System.Drawing.Color.WhiteSmoke;
            this.ListaEmpresas.Location = new System.Drawing.Point(3, 93);
            this.ListaEmpresas.Name = "ListaEmpresas";
            this.ListaEmpresas.ReadOnly = true;
            this.ListaEmpresas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(123)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(123)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListaEmpresas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.ListaEmpresas.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(123)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(181)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.ListaEmpresas.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.ListaEmpresas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListaEmpresas.Size = new System.Drawing.Size(523, 329);
            this.ListaEmpresas.TabIndex = 5;
            this.ListaEmpresas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListaEmpresas_CellDoubleClick);
            // 
            // RFC
            // 
            this.RFC.HeaderText = "RFC";
            this.RFC.Name = "RFC";
            this.RFC.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            // 
            // txtSearchRFC
            // 
            this.txtSearchRFC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSearchRFC.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchRFC.Location = new System.Drawing.Point(195, 34);
            this.txtSearchRFC.MaxLength = 20;
            this.txtSearchRFC.Name = "txtSearchRFC";
            this.txtSearchRFC.Size = new System.Drawing.Size(234, 27);
            this.txtSearchRFC.TabIndex = 4;
            this.txtSearchRFC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchRFC_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(71, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Buscar Por RFC:";
            // 
            // Agregar_Actualizar
            // 
            this.Agregar_Actualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(123)))));
            this.Agregar_Actualizar.Controls.Add(this.Limpiar);
            this.Agregar_Actualizar.Controls.Add(this.panelMensaje);
            this.Agregar_Actualizar.Controls.Add(this.txtDireccion);
            this.Agregar_Actualizar.Controls.Add(this.txtNombre);
            this.Agregar_Actualizar.Controls.Add(this.txtRFC);
            this.Agregar_Actualizar.Controls.Add(this.label3);
            this.Agregar_Actualizar.Controls.Add(this.label2);
            this.Agregar_Actualizar.Controls.Add(this.label1);
            this.Agregar_Actualizar.Controls.Add(this.btnGuardar);
            this.Agregar_Actualizar.Location = new System.Drawing.Point(4, 34);
            this.Agregar_Actualizar.Name = "Agregar_Actualizar";
            this.Agregar_Actualizar.Size = new System.Drawing.Size(529, 425);
            this.Agregar_Actualizar.TabIndex = 1;
            this.Agregar_Actualizar.Text = "Empresa";
            // 
            // Limpiar
            // 
            this.Limpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(208)))), ((int)(((byte)(63)))));
            this.Limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Limpiar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Limpiar.Image = global::Consultoria.Properties.Resources.outline_cleaning_services_white_24dp;
            this.Limpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Limpiar.Location = new System.Drawing.Point(157, 280);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(112, 36);
            this.Limpiar.TabIndex = 8;
            this.Limpiar.Text = "Limpiar";
            this.Limpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Limpiar.UseVisualStyleBackColor = false;
            this.Limpiar.Click += new System.EventHandler(this.Limpiar_Click);
            // 
            // panelMensaje
            // 
            this.panelMensaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.panelMensaje.Controls.Add(this.lbMensaje);
            this.panelMensaje.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMensaje.Location = new System.Drawing.Point(0, 0);
            this.panelMensaje.Name = "panelMensaje";
            this.panelMensaje.Size = new System.Drawing.Size(529, 62);
            this.panelMensaje.TabIndex = 7;
            this.panelMensaje.Visible = false;
            // 
            // lbMensaje
            // 
            this.lbMensaje.AutoSize = true;
            this.lbMensaje.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbMensaje.Location = new System.Drawing.Point(134, 22);
            this.lbMensaje.Name = "lbMensaje";
            this.lbMensaje.Size = new System.Drawing.Size(234, 21);
            this.lbMensaje.TabIndex = 8;
            this.lbMensaje.Text = "Datos Guardados correctamente";
            this.lbMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(157, 230);
            this.txtDireccion.MaxLength = 100;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(233, 27);
            this.txtDireccion.TabIndex = 5;
            this.txtDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDireccion_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(157, 171);
            this.txtNombre.MaxLength = 100;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(233, 27);
            this.txtNombre.TabIndex = 4;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtRFC
            // 
            this.txtRFC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRFC.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRFC.Location = new System.Drawing.Point(156, 114);
            this.txtRFC.MaxLength = 20;
            this.txtRFC.Name = "txtRFC";
            this.txtRFC.Size = new System.Drawing.Size(234, 27);
            this.txtRFC.TabIndex = 3;
            this.txtRFC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRFC_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(73, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dirección:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(79, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(109, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "RFC:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGuardar.Image = global::Consultoria.Properties.Resources.outline_save_white_24dp;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(278, 280);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(112, 36);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // Watch_Empresa
            // 
            this.Watch_Empresa.Enabled = true;
            this.Watch_Empresa.Tick += new System.EventHandler(this.Watch_Empresa_Tick);
            // 
            // Empresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabEmpresa);
            this.Name = "Empresa";
            this.Size = new System.Drawing.Size(537, 463);
            this.Load += new System.EventHandler(this.Empresa_Load);
            this.tabEmpresa.ResumeLayout(false);
            this.Consultar.ResumeLayout(false);
            this.Consultar.PerformLayout();
            this.MensajeOpction.ResumeLayout(false);
            this.MensajeOpction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListaEmpresas)).EndInit();
            this.Agregar_Actualizar.ResumeLayout(false);
            this.Agregar_Actualizar.PerformLayout();
            this.panelMensaje.ResumeLayout(false);
            this.panelMensaje.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabEmpresa;
        private System.Windows.Forms.TabPage Consultar;
        private System.Windows.Forms.TabPage Agregar_Actualizar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtRFC;
        private System.Windows.Forms.Panel panelMensaje;
        private System.Windows.Forms.Label lbMensaje;
        private System.Windows.Forms.Timer Watch_Empresa;
        private System.Windows.Forms.TextBox txtSearchRFC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView ListaEmpresas;
        private System.Windows.Forms.DataGridViewTextBoxColumn RFC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.Panel MensajeOpction;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lbRFC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Limpiar;
    }
}
