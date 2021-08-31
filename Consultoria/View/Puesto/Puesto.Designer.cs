
namespace Consultoria.View.Puesto
{
    partial class Puesto
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
            this.tabPuesto = new System.Windows.Forms.TabControl();
            this.Consultar = new System.Windows.Forms.TabPage();
            this.MensajeOpction = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lbFolio = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ListaPuesto = new System.Windows.Forms.DataGridView();
            this.Folio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearchRFC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Agregar_Actualizar = new System.Windows.Forms.TabPage();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Limpiar = new System.Windows.Forms.Button();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.ComboDepartamento = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ComboEmpresa = new System.Windows.Forms.ComboBox();
            this.txtPuesto = new System.Windows.Forms.TextBox();
            this.Lbl_Clave_Empresa = new System.Windows.Forms.Label();
            this.Lbl_Nombre = new System.Windows.Forms.Label();
            this.panelMensaje = new System.Windows.Forms.Panel();
            this.lbMensaje = new System.Windows.Forms.Label();
            this.Watch_Puesto = new System.Windows.Forms.Timer(this.components);
            this.tabPuesto.SuspendLayout();
            this.Consultar.SuspendLayout();
            this.MensajeOpction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListaPuesto)).BeginInit();
            this.Agregar_Actualizar.SuspendLayout();
            this.panelMensaje.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPuesto
            // 
            this.tabPuesto.Controls.Add(this.Consultar);
            this.tabPuesto.Controls.Add(this.Agregar_Actualizar);
            this.tabPuesto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPuesto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPuesto.ItemSize = new System.Drawing.Size(56, 30);
            this.tabPuesto.Location = new System.Drawing.Point(0, 0);
            this.tabPuesto.Name = "tabPuesto";
            this.tabPuesto.SelectedIndex = 0;
            this.tabPuesto.Size = new System.Drawing.Size(537, 463);
            this.tabPuesto.TabIndex = 1;
            // 
            // Consultar
            // 
            this.Consultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(123)))));
            this.Consultar.Controls.Add(this.MensajeOpction);
            this.Consultar.Controls.Add(this.ListaPuesto);
            this.Consultar.Controls.Add(this.txtSearchRFC);
            this.Consultar.Controls.Add(this.label4);
            this.Consultar.Location = new System.Drawing.Point(4, 34);
            this.Consultar.Name = "Consultar";
            this.Consultar.Size = new System.Drawing.Size(529, 425);
            this.Consultar.TabIndex = 2;
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
            // ListaPuesto
            // 
            this.ListaPuesto.AllowUserToAddRows = false;
            this.ListaPuesto.AllowUserToDeleteRows = false;
            this.ListaPuesto.AllowUserToResizeColumns = false;
            this.ListaPuesto.AllowUserToResizeRows = false;
            this.ListaPuesto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ListaPuesto.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(123)))));
            this.ListaPuesto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListaPuesto.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ListaPuesto.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(123)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(123)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListaPuesto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ListaPuesto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ListaPuesto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Folio,
            this.Nombre,
            this.Descripcion});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(74)))), ((int)(((byte)(25)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ListaPuesto.DefaultCellStyle = dataGridViewCellStyle2;
            this.ListaPuesto.EnableHeadersVisualStyles = false;
            this.ListaPuesto.GridColor = System.Drawing.Color.WhiteSmoke;
            this.ListaPuesto.Location = new System.Drawing.Point(3, 93);
            this.ListaPuesto.Name = "ListaPuesto";
            this.ListaPuesto.ReadOnly = true;
            this.ListaPuesto.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(123)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(123)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListaPuesto.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.ListaPuesto.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(123)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(181)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.ListaPuesto.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.ListaPuesto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListaPuesto.Size = new System.Drawing.Size(523, 329);
            this.ListaPuesto.TabIndex = 9;
            this.ListaPuesto.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListaPuesto_CellDoubleClick);
            // 
            // Folio
            // 
            this.Folio.HeaderText = "Folio";
            this.Folio.Name = "Folio";
            this.Folio.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // txtSearchRFC
            // 
            this.txtSearchRFC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
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
            this.label4.Location = new System.Drawing.Point(41, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Buscar Por Nombre:";
            // 
            // Agregar_Actualizar
            // 
            this.Agregar_Actualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(123)))));
            this.Agregar_Actualizar.Controls.Add(this.txtDescripcion);
            this.Agregar_Actualizar.Controls.Add(this.label2);
            this.Agregar_Actualizar.Controls.Add(this.Limpiar);
            this.Agregar_Actualizar.Controls.Add(this.Btn_Guardar);
            this.Agregar_Actualizar.Controls.Add(this.ComboDepartamento);
            this.Agregar_Actualizar.Controls.Add(this.label1);
            this.Agregar_Actualizar.Controls.Add(this.ComboEmpresa);
            this.Agregar_Actualizar.Controls.Add(this.txtPuesto);
            this.Agregar_Actualizar.Controls.Add(this.Lbl_Clave_Empresa);
            this.Agregar_Actualizar.Controls.Add(this.Lbl_Nombre);
            this.Agregar_Actualizar.Controls.Add(this.panelMensaje);
            this.Agregar_Actualizar.Location = new System.Drawing.Point(4, 34);
            this.Agregar_Actualizar.Name = "Agregar_Actualizar";
            this.Agregar_Actualizar.Size = new System.Drawing.Size(529, 425);
            this.Agregar_Actualizar.TabIndex = 3;
            this.Agregar_Actualizar.Text = "Puesto";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(34, 277);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(352, 108);
            this.txtDescripcion.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(30, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 21);
            this.label2.TabIndex = 37;
            this.label2.Text = "Descripcion:";
            // 
            // Limpiar
            // 
            this.Limpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(208)))), ((int)(((byte)(63)))));
            this.Limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Limpiar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Limpiar.Image = global::Consultoria.Properties.Resources.outline_cleaning_services_white_24dp;
            this.Limpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Limpiar.Location = new System.Drawing.Point(405, 174);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(112, 36);
            this.Limpiar.TabIndex = 36;
            this.Limpiar.Text = "Limpiar";
            this.Limpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Limpiar.UseVisualStyleBackColor = false;
            this.Limpiar.Click += new System.EventHandler(this.Limpiar_Click);
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Guardar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Guardar.Image = global::Consultoria.Properties.Resources.outline_save_white_24dp;
            this.Btn_Guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Guardar.Location = new System.Drawing.Point(405, 108);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(112, 36);
            this.Btn_Guardar.TabIndex = 35;
            this.Btn_Guardar.Text = "Guardar";
            this.Btn_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Btn_Guardar.UseVisualStyleBackColor = true;
            this.Btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
            // 
            // ComboDepartamento
            // 
            this.ComboDepartamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboDepartamento.FormattingEnabled = true;
            this.ComboDepartamento.Items.AddRange(new object[] {
            "<Seleccione el RFC de la empresa>"});
            this.ComboDepartamento.Location = new System.Drawing.Point(34, 164);
            this.ComboDepartamento.Name = "ComboDepartamento";
            this.ComboDepartamento.Size = new System.Drawing.Size(352, 29);
            this.ComboDepartamento.TabIndex = 34;
            this.ComboDepartamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComboDepartamento_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(30, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 21);
            this.label1.TabIndex = 33;
            this.label1.Text = "Departamento";
            // 
            // ComboEmpresa
            // 
            this.ComboEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboEmpresa.FormattingEnabled = true;
            this.ComboEmpresa.Items.AddRange(new object[] {
            "<Seleccione el RFC de la empresa>"});
            this.ComboEmpresa.Location = new System.Drawing.Point(34, 108);
            this.ComboEmpresa.Name = "ComboEmpresa";
            this.ComboEmpresa.Size = new System.Drawing.Size(352, 29);
            this.ComboEmpresa.TabIndex = 32;
            this.ComboEmpresa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComboEmpresa_KeyPress);
            // 
            // txtPuesto
            // 
            this.txtPuesto.Location = new System.Drawing.Point(34, 221);
            this.txtPuesto.Name = "txtPuesto";
            this.txtPuesto.Size = new System.Drawing.Size(352, 29);
            this.txtPuesto.TabIndex = 31;
            // 
            // Lbl_Clave_Empresa
            // 
            this.Lbl_Clave_Empresa.AutoSize = true;
            this.Lbl_Clave_Empresa.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Lbl_Clave_Empresa.Location = new System.Drawing.Point(30, 84);
            this.Lbl_Clave_Empresa.Name = "Lbl_Clave_Empresa";
            this.Lbl_Clave_Empresa.Size = new System.Drawing.Size(73, 21);
            this.Lbl_Clave_Empresa.TabIndex = 30;
            this.Lbl_Clave_Empresa.Text = "Empresa:";
            // 
            // Lbl_Nombre
            // 
            this.Lbl_Nombre.AutoSize = true;
            this.Lbl_Nombre.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Lbl_Nombre.Location = new System.Drawing.Point(30, 197);
            this.Lbl_Nombre.Name = "Lbl_Nombre";
            this.Lbl_Nombre.Size = new System.Drawing.Size(60, 21);
            this.Lbl_Nombre.TabIndex = 29;
            this.Lbl_Nombre.Text = "Puesto:";
            // 
            // panelMensaje
            // 
            this.panelMensaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.panelMensaje.Controls.Add(this.lbMensaje);
            this.panelMensaje.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMensaje.Location = new System.Drawing.Point(0, 0);
            this.panelMensaje.Name = "panelMensaje";
            this.panelMensaje.Size = new System.Drawing.Size(529, 62);
            this.panelMensaje.TabIndex = 28;
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
            // Watch_Puesto
            // 
            this.Watch_Puesto.Enabled = true;
            this.Watch_Puesto.Tick += new System.EventHandler(this.Watch_Puesto_Tick);
            // 
            // Puesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabPuesto);
            this.Name = "Puesto";
            this.Size = new System.Drawing.Size(537, 463);
            this.Load += new System.EventHandler(this.Puesto_Load);
            this.tabPuesto.ResumeLayout(false);
            this.Consultar.ResumeLayout(false);
            this.Consultar.PerformLayout();
            this.MensajeOpction.ResumeLayout(false);
            this.MensajeOpction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListaPuesto)).EndInit();
            this.Agregar_Actualizar.ResumeLayout(false);
            this.Agregar_Actualizar.PerformLayout();
            this.panelMensaje.ResumeLayout(false);
            this.panelMensaje.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabPuesto;
        private System.Windows.Forms.TabPage Consultar;
        private System.Windows.Forms.Panel MensajeOpction;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lbFolio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView ListaPuesto;
        private System.Windows.Forms.TextBox txtSearchRFC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Folio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.Timer Watch_Puesto;
        private System.Windows.Forms.TabPage Agregar_Actualizar;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Limpiar;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.ComboBox ComboDepartamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboEmpresa;
        private System.Windows.Forms.TextBox txtPuesto;
        private System.Windows.Forms.Label Lbl_Clave_Empresa;
        private System.Windows.Forms.Label Lbl_Nombre;
        private System.Windows.Forms.Panel panelMensaje;
        private System.Windows.Forms.Label lbMensaje;
    }
}
