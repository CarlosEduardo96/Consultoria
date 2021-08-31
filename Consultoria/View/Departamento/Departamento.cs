using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Consultoria.DTOs;
using Consultoria.Models;

namespace Consultoria.View.Departamento
{
    public partial class Departamento : UserControl
    {

        private bool IsMessageActive = false;
        private int Count = 0;
        private ModelDepartamento departamento = null;
        private bool IsEditar = false;

        public Departamento()
        {
            InitializeComponent();
        }
        private void ResetDep() {
            Combo_ClaveE.SelectedIndex = 0;
            Txt_Nombre.Text = "";
            Txt_Descripcion.Text = "";
            IsEditar = false;
        }
        public void ResetTabla() {
            ListaDepartamento.Rows.Clear();
            EmpresaDTO dato = new EmpresaDTO();
            DepartamentoDTO query = new DepartamentoDTO();
            List<ModelDepartamento> data = query.FindAll();
            List<ModelEmpresa> lista = dato.FindAll();          
            if (lista != null)
            {
                foreach (var empresa in dato.FindAll())
                {
                    Combo_ClaveE.Items.Add(empresa.Rfc);
                }
            }
            if (data != null)
            {
                foreach (var dep in data)
                {

                    ListaDepartamento.Rows.Add(dep.Folio, dep.Nombre, dep.Descripcion, dep.Clave_empresa);
                }
            }
        }
        private void CargarDep() {
            EmpresaDTO dato = new EmpresaDTO();
            DepartamentoDTO query = new DepartamentoDTO();
            List<ModelDepartamento> data = query.FindAll();
            List<ModelEmpresa> lista = dato.FindAll();
            Combo_ClaveE.SelectedIndex = 0;
            if (lista != null)
            {
                foreach (var empresa in dato.FindAll())
                {
                    Combo_ClaveE.Items.Add(empresa.Rfc);
                }
            }
            if (data != null) { 
                foreach (var dep in data) {
                    
                    ListaDepartamento.Rows.Add(dep.Folio,dep.Nombre,dep.Descripcion,dep.Clave_empresa);
                }            
            }
        }
        private void Txt_Folio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
               Txt_Nombre.Focus();
            }
        }
        private void Txt_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Txt_Descripcion.Focus();
            }
        }

        private void Txt_Descripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Combo_ClaveE.Focus();
            }
        }

      

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            if (Txt_Nombre.Text.Length > 3 && Txt_Descripcion.Text.Length > 3 && Combo_ClaveE.SelectedIndex>0)
            {
                if (IsEditar==false)
                {
                    DepartamentoDTO data = new DepartamentoDTO();
                    ModelDepartamento de = new ModelDepartamento(Txt_Nombre.Text, Txt_Descripcion.Text, Combo_ClaveE.Text);
                    if (data.Insert(de) != null)
                    {
                        panelMensaje.BackColor = Color.FromArgb(67, 160, 71);
                        panelMensaje.Visible = true;
                        lbMensaje.Text = "¡Datos guardados con exito!";
                        IsMessageActive = true;                        
                    }
                    else
                    {
                        panelMensaje.BackColor = Color.FromArgb(211, 47, 47);
                        panelMensaje.Visible = true;
                        lbMensaje.Text = "¡Error al guardar los datos!";
                        IsMessageActive = true;
                    }
                    ResetTabla();
                }
                else {
                    DepartamentoDTO data = new DepartamentoDTO();
                    ModelDepartamento de = new ModelDepartamento();
                    de.Clave_empresa = Combo_ClaveE.SelectedItem.ToString();
                    de.Nombre = Txt_Nombre.Text;
                    de.Descripcion = Txt_Descripcion.Text;
                    de.At_Date = DateTime.Now.ToString();
                    de.Folio = departamento.Folio;

                    if (data.Update(de) != null)
                    {
                        panelMensaje.BackColor = Color.FromArgb(67, 160, 71);
                        panelMensaje.Visible = true;
                        lbMensaje.Text = "¡Datos actualizados con exito!";
                        IsMessageActive = true;
                        IsEditar = false;
                    }
                    else
                    {
                        panelMensaje.BackColor = Color.FromArgb(211, 47, 47);
                        panelMensaje.Visible = true;
                        lbMensaje.Text = "¡Error al guardar los datos!";
                        IsMessageActive = true;
                    }
                    ResetTabla();
                }
                
            }
            else
            {
                panelMensaje.BackColor = Color.FromArgb(211, 47, 47);
                panelMensaje.Visible = true;
                lbMensaje.Text = "¡Rellene los campos minimo 4 caracteres!";
                IsMessageActive = true;
            }            
        }

        private void watch_Departamento_Tick(object sender, EventArgs e)
        {

            if (IsMessageActive && Count < 10)
            {
                Count++;
            }
            else
            {
                Count = 0;
                IsMessageActive = false;
                panelMensaje.Visible = false;
            }
        }

        private void Departamento_Load(object sender, EventArgs e)
        {
            CargarDep();
        }

        private void Combo_ClaveE_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            ResetDep();
        }

        private void ListaDepartamento_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = ListaDepartamento.Rows[e.RowIndex];
                departamento = new ModelDepartamento();
                departamento.Folio = Convert.ToInt32(row.Cells[0].Value);
                departamento.Nombre = row.Cells[1].Value.ToString();
                departamento.Descripcion = row.Cells[2].Value.ToString();
                departamento.Clave_empresa = row.Cells[3].Value.ToString();
                MensajeOpction.Visible = true;
                lbFolio.Text = "Folio: " + row.Cells[0].Value;
                
            }
            catch { }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            departamento = null;
            MensajeOpction.Visible = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            MensajeOpction.Visible = false;
            Combo_ClaveE.SelectedItem = departamento.Clave_empresa;
            Txt_Nombre.Text = departamento.Nombre;
            Txt_Descripcion.Text = departamento.Descripcion;
            IsEditar = true;
            tabDepartamento.SelectedTab = Agregar_Actualizar;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("¿Los datos seran borrados permamente?", "Eliminar", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                DepartamentoDTO query = new DepartamentoDTO();
                PuestoDTO p = new PuestoDTO();
                p.DeleteCascadeDepartamento(departamento.Folio);
                query.Delete(departamento.Folio);
                MensajeOpction.Visible = false;
                departamento = null;
                ResetTabla();

            }
        }

        private void Buscar() {
            ListaDepartamento.Rows.Clear();
            DepartamentoDTO data = new DepartamentoDTO();
            List<ModelDepartamento> lista = data.Search(txtSearchRFC.Text);
            if (lista!=null) {
                foreach (var dep in lista) {
                    ListaDepartamento.Rows.Add(dep.Folio, dep.Nombre, dep.Descripcion, dep.Clave_empresa);
                }
            }
        }
        private void txtSearchRFC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtSearchRFC.Text.Length > 0)
            {
                Buscar();
            }
            else {
                ResetTabla();
            }
        }
    }
}
