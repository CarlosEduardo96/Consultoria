
namespace Consultoria.View.Departamento
{
    partial class Departamento
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
            this.tabDepartamento = new System.Windows.Forms.TabControl();
            this.Consultar = new System.Windows.Forms.TabPage();
            this.MensajeOpction = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lbFolio = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ListaDepartamento = new System.Windows.Forms.DataGridView();
            this.FOLIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clave_Empresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearchRFC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Agregar_Actualizar = new System.Windows.Forms.TabPage();
            this.Limpiar = new System.Windows.Forms.Button();
            this.Combo_ClaveE = new System.Windows.Forms.ComboBox();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.Txt_Descripcion = new System.Windows.Forms.TextBox();
            this.Txt_Nombre = new System.Windows.Forms.TextBox();
            this.Lbl_Clave_Empresa = new System.Windows.Forms.Label();
            this.Lbl_Descripcion = new System.Windows.Forms.Label();
            this.Lbl_Nombre = new System.Windows.Forms.Label();
            this.panelMensaje = new System.Windows.Forms.Panel();
            this.lbMensaje = new System.Windows.Forms.Label();
            this.watch_Departamento = new System.Windows.Forms.Timer(this.components);
            this.tabDepartamento.SuspendLayout();
            this.Consultar.SuspendLayout();
            this.MensajeOpction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListaDepartamento)).BeginInit();
            this.Agregar_Actualizar.SuspendLayout();
            this.panelMensaje.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabDepartamento
            // 
            this.tabDepartamento.Controls.Add(this.Consultar);
            this.tabDepartamento.Controls.Add(this.Agregar_Actualizar);
            this.tabDepartamento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabDepartamento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabDepartamento.ItemSize = new System.Drawing.Size(56, 30);
            this.tabDepartamento.Location = new System.Drawing.Point(0, 0);
            this.tabDepartamento.Name = "tabDepartamento";
            this.tabDepartamento.SelectedIndex = 0;
            this.tabDepartamento.Size = new System.Drawing.Size(537, 463);
            this.tabDepartamento.TabIndex = 0;
            // 
            // Consultar
            // 
            this.Consultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(123)))));
            this.Consultar.Controls.Add(this.MensajeOpction);
            this.Consultar.Controls.Add(this.ListaDepartamento);
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
            this.MensajeOpction.Controls.Add(this.lbFolio);
            this.MensajeOpction.Controls.Add(this.label5);
            this.MensajeOpction.Location = new System.Drawing.Point(121, 167);
            this.MensajeOpction.Name = "MensajeOpction";
            this.MensajeOpction.Size = new System.Drawing.Size(292, 153);
            this.MensajeOpction.TabIndex = 10;
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
            // lbFolio
            // 
            this.lbFolio.AutoSize = true;
            this.lbFolio.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbFolio.Location = new System.Drawing.Point(37, 24);
            this.lbFolio.Name = "lbFolio";
            this.lbFolio.Size = new System.Drawing.Size(177, 21);
            this.lbFolio.TabIndex = 8;
            this.lbFolio.Text = "Folio: XXXXXXXXXXXXXX";
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
            // ListaDepartamento
            // 
            this.ListaDepartamento.AllowUserToAddRows = false;
            this.ListaDepartamento.AllowUserToDeleteRows = false;
            this.ListaDepartamento.AllowUserToResizeColumns = false;
            this.ListaDepartamento.AllowUserToResizeRows = false;
            this.ListaDepartamento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ListaDepartamento.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(123)))));
            this.ListaDepartamento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListaDepartamento.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ListaDepartamento.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(123)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(123)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListaDepartamento.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ListaDepartamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ListaDepartamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FOLIO,
            this.Nombre,
            this.Direccion,
            this.Clave_Empresa});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(74)))), ((int)(((byte)(25)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ListaDepartamento.DefaultCellStyle = dataGridViewCellStyle2;
            this.ListaDepartamento.EnableHeadersVisualStyles = false;
            this.ListaDepartamento.GridColor = System.Drawing.Color.WhiteSmoke;
            this.ListaDepartamento.Location = new System.Drawing.Point(3, 93);
            this.ListaDepartamento.Name = "ListaDepartamento";
            this.ListaDepartamento.ReadOnly = true;
            this.ListaDepartamento.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(123)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(123)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListaDepartamento.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.ListaDepartamento.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(123)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(181)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.ListaDepartamento.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.ListaDepartamento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListaDepartamento.Size = new System.Drawing.Size(523, 329);
            this.ListaDepartamento.TabIndex = 9;
            this.ListaDepartamento.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListaDepartamento_CellDoubleClick);
            // 
            // FOLIO
            // 
            this.FOLIO.FillWeight = 50F;
            this.FOLIO.HeaderText = "Folio";
            this.FOLIO.Name = "FOLIO";
            this.FOLIO.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre Departamento";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Descripcion";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            // 
            // Clave_Empresa
            // 
            this.Clave_Empresa.HeaderText = "RFC Empresa";
            this.Clave_Empresa.Name = "Clave_Empresa";
            this.Clave_Empresa.ReadOnly = true;
            // 
            // txtSearchRFC
            // 
            this.txtSearchRFC.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchRFC.Location = new System.Drawing.Point(195, 34);
            this.txtSearchRFC.MaxLength = 20;
            this.txtSearchRFC.Name = "txtSearchRFC";
            this.txtSearchRFC.Size = new System.Drawing.Size(234, 27);
            this.txtSearchRFC.TabIndex = 8;
            this.txtSearchRFC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchRFC_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(65, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Buscar Por Folio:";
            // 
            // Agregar_Actualizar
            // 
            this.Agregar_Actualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(123)))));
            this.Agregar_Actualizar.Controls.Add(this.Limpiar);
            this.Agregar_Actualizar.Controls.Add(this.Combo_ClaveE);
            this.Agregar_Actualizar.Controls.Add(this.Btn_Guardar);
            this.Agregar_Actualizar.Controls.Add(this.Txt_Descripcion);
            this.Agregar_Actualizar.Controls.Add(this.Txt_Nombre);
            this.Agregar_Actualizar.Controls.Add(this.Lbl_Clave_Empresa);
            this.Agregar_Actualizar.Controls.Add(this.Lbl_Descripcion);
            this.Agregar_Actualizar.Controls.Add(this.Lbl_Nombre);
            this.Agregar_Actualizar.Controls.Add(this.panelMensaje);
            this.Agregar_Actualizar.Location = new System.Drawing.Point(4, 34);
            this.Agregar_Actualizar.Name = "Agregar_Actualizar";
            this.Agregar_Actualizar.Size = new System.Drawing.Size(529, 425);
            this.Agregar_Actualizar.TabIndex = 1;
            this.Agregar_Actualizar.Text = "Departamento";
            // 
            // Limpiar
            // 
            this.Limpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(208)))), ((int)(((byte)(63)))));
            this.Limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Limpiar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Limpiar.Image = global::Consultoria.Properties.Resources.outline_cleaning_services_white_24dp;
            this.Limpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Limpiar.Location = new System.Drawing.Point(400, 187);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(112, 36);
            this.Limpiar.TabIndex = 18;
            this.Limpiar.Text = "Limpiar";
            this.Limpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Limpiar.UseVisualStyleBackColor = false;
            this.Limpiar.Click += new System.EventHandler(this.Limpiar_Click);
            // 
            // Combo_ClaveE
            // 
            this.Combo_ClaveE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Combo_ClaveE.FormattingEnabled = true;
            this.Combo_ClaveE.Items.AddRange(new object[] {
            "<Seleccione el RFC de la empresa>"});
            this.Combo_ClaveE.Location = new System.Drawing.Point(31, 122);
            this.Combo_ClaveE.Name = "Combo_ClaveE";
            this.Combo_ClaveE.Size = new System.Drawing.Size(352, 29);
            this.Combo_ClaveE.TabIndex = 17;
            this.Combo_ClaveE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Combo_ClaveE_KeyPress);
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Guardar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Guardar.Image = global::Consultoria.Properties.Resources.outline_save_white_24dp;
            this.Btn_Guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Guardar.Location = new System.Drawing.Point(400, 122);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(112, 36);
            this.Btn_Guardar.TabIndex = 16;
            this.Btn_Guardar.Text = "Guardar";
            this.Btn_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Btn_Guardar.UseVisualStyleBackColor = true;
            this.Btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
            // 
            // Txt_Descripcion
            // 
            this.Txt_Descripcion.Location = new System.Drawing.Point(31, 250);
            this.Txt_Descripcion.Multiline = true;
            this.Txt_Descripcion.Name = "Txt_Descripcion";
            this.Txt_Descripcion.Size = new System.Drawing.Size(352, 114);
            this.Txt_Descripcion.TabIndex = 15;
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.Location = new System.Drawing.Point(31, 187);
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.Size = new System.Drawing.Size(352, 29);
            this.Txt_Nombre.TabIndex = 13;
            // 
            // Lbl_Clave_Empresa
            // 
            this.Lbl_Clave_Empresa.AutoSize = true;
            this.Lbl_Clave_Empresa.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Lbl_Clave_Empresa.Location = new System.Drawing.Point(27, 98);
            this.Lbl_Clave_Empresa.Name = "Lbl_Clave_Empresa";
            this.Lbl_Clave_Empresa.Size = new System.Drawing.Size(119, 21);
            this.Lbl_Clave_Empresa.TabIndex = 12;
            this.Lbl_Clave_Empresa.Text = "Clave Empresa :";
            // 
            // Lbl_Descripcion
            // 
            this.Lbl_Descripcion.AutoSize = true;
            this.Lbl_Descripcion.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Lbl_Descripcion.Location = new System.Drawing.Point(27, 226);
            this.Lbl_Descripcion.Name = "Lbl_Descripcion";
            this.Lbl_Descripcion.Size = new System.Drawing.Size(98, 21);
            this.Lbl_Descripcion.TabIndex = 11;
            this.Lbl_Descripcion.Text = "Descripcion :";
            // 
            // Lbl_Nombre
            // 
            this.Lbl_Nombre.AutoSize = true;
            this.Lbl_Nombre.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Lbl_Nombre.Location = new System.Drawing.Point(27, 163);
            this.Lbl_Nombre.Name = "Lbl_Nombre";
            this.Lbl_Nombre.Size = new System.Drawing.Size(179, 21);
            this.Lbl_Nombre.TabIndex = 10;
            this.Lbl_Nombre.Text = "Nombre  Departamento:";
            // 
            // panelMensaje
            // 
            this.panelMensaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.panelMensaje.Controls.Add(this.lbMensaje);
            this.panelMensaje.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMensaje.Location = new System.Drawing.Point(0, 0);
            this.panelMensaje.Name = "panelMensaje";
            this.panelMensaje.Size = new System.Drawing.Size(529, 62);
            this.panelMensaje.TabIndex = 8;
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
            // watch_Departamento
            // 
            this.watch_Departamento.Enabled = true;
            this.watch_Departamento.Tick += new System.EventHandler(this.watch_Departamento_Tick);
            // 
            // Departamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabDepartamento);
            this.Name = "Departamento";
            this.Size = new System.Drawing.Size(537, 463);
            this.Load += new System.EventHandler(this.Departamento_Load);
            this.tabDepartamento.ResumeLayout(false);
            this.Consultar.ResumeLayout(false);
            this.Consultar.PerformLayout();
            this.MensajeOpction.ResumeLayout(false);
            this.MensajeOpction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListaDepartamento)).EndInit();
            this.Agregar_Actualizar.ResumeLayout(false);
            this.Agregar_Actualizar.PerformLayout();
            this.panelMensaje.ResumeLayout(false);
            this.panelMensaje.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabDepartamento;
        private System.Windows.Forms.TabPage Consultar;
        private System.Windows.Forms.TabPage Agregar_Actualizar;
        private System.Windows.Forms.Panel panelMensaje;
        private System.Windows.Forms.Label lbMensaje;
        private System.Windows.Forms.Label Lbl_Clave_Empresa;
        private System.Windows.Forms.Label Lbl_Descripcion;
        private System.Windows.Forms.Label Lbl_Nombre;
        private System.Windows.Forms.TextBox Txt_Nombre;
        private System.Windows.Forms.TextBox Txt_Descripcion;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.ComboBox Combo_ClaveE;
        private System.Windows.Forms.Timer watch_Departamento;
        private System.Windows.Forms.Button Limpiar;
        private System.Windows.Forms.Panel MensajeOpction;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lbFolio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView ListaDepartamento;
        private System.Windows.Forms.TextBox txtSearchRFC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn FOLIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clave_Empresa;
    }
}
