using Consultoria.DTOs;
using Consultoria.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consultoria.View.Empresa
{
    public partial class Empresa : UserControl
    {

        private bool IsMessageActive = false;
        private int Count = 0;
        private ModelEmpresa empresa = null;


        public Empresa()
        {
            InitializeComponent();
        }
        private void resetLista()
        {
            ListaEmpresas.Rows.Clear();
            EmpresaDTO query = new EmpresaDTO();
            List<ModelEmpresa> datos = query.FindAll();
            if (datos != null)
            {
                foreach (var empresa in datos)
                {
                    ListaEmpresas.Rows.Add(empresa.Rfc, empresa.Nombre, empresa.Direccion);
                }
            }
        }
        private void txtRFC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtNombre.Focus();
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtDireccion.Focus();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (txtRFC.Enabled == true)
            {

                if (txtRFC.Text.Length > 4 && txtNombre.Text.Length > 4 && txtDireccion.Text.Length > 4)
                {

                    EmpresaDTO data = new EmpresaDTO();
                    ModelEmpresa em = new ModelEmpresa(txtRFC.Text, txtNombre.Text, txtDireccion.Text);
                    if (data.Insert(em) == null)
                    {
                        panelMensaje.BackColor = Color.FromArgb(211, 47, 47);
                        panelMensaje.Visible = true;
                        lbMensaje.Text = "¡Error al guardar los datos rfc ya existe!";
                        IsMessageActive = true;
                    }
                    else
                    {
                        panelMensaje.BackColor = Color.FromArgb(67, 160, 71);
                        panelMensaje.Visible = true;
                        lbMensaje.Text = "¡Datos guardados con exito!";
                        IsMessageActive = true;
                    }
                }
                else
                {
                    MessageBox.Show("Rellene los campos minimo 4 caracteres");
                }
            }
            else
            {
                EmpresaDTO query = new EmpresaDTO();
                empresa.Nombre = txtNombre.Text;
                empresa.Direccion = txtDireccion.Text;
                empresa.At_date = DateTime.Now.ToString();
                query.Update(empresa);
                panelMensaje.BackColor = Color.FromArgb(67, 160, 71);
                panelMensaje.Visible = true;
                lbMensaje.Text = "¡Datos guardados con exito!";
                IsMessageActive = true;
            }
        }

        private void Watch_Empresa_Tick(object sender, EventArgs e)
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

        private void Empresa_Load(object sender, EventArgs e)
        {
            this.resetLista();
        }

        private void ListaEmpresas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = ListaEmpresas.Rows[e.RowIndex];
                lbRFC.Text = "RFC: " + row.Cells[0].Value;
                EmpresaDTO data = new EmpresaDTO();
                ModelEmpresa em = data.Find(row.Cells[0].Value.ToString());
                if (em != null)
                {
                    MensajeOpction.Visible = true;
                    empresa = em;
                }

            }
            catch { }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            empresa = null;
            MensajeOpction.Visible = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            MensajeOpction.Visible = false;
            txtRFC.Text = empresa.Rfc;
            txtRFC.Enabled = false;
            txtNombre.Text = empresa.Nombre;
            txtDireccion.Text = empresa.Direccion;
            tabEmpresa.SelectedTab = Agregar_Actualizar;
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            txtRFC.Enabled = true;
            empresa = null;
            txtRFC.Text = "";
            txtNombre.Text = "";
            txtDireccion.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("¿Los datos seran borrados permamente?", "Eliminar", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                EmpresaDTO query = new EmpresaDTO();
                DepartamentoDTO d = new DepartamentoDTO();
                d.CascadeEmpresa(empresa.Id, empresa.Rfc);
                ModelEmpresa em = query.Delete(empresa.Id);
                MensajeOpction.Visible = false;
                empresa = null;
                resetLista();
            }
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnGuardar.Focus();
            }
        }
        private void Buscar()
        {
            ListaEmpresas.Rows.Clear();
            EmpresaDTO query = new EmpresaDTO();
            List<ModelEmpresa> lista = query.Search(txtSearchRFC.Text);
            if (lista != null)
            {
                foreach (var empresa in lista)
                {
                    ListaEmpresas.Rows.Add(empresa.Rfc, empresa.Nombre, empresa.Direccion);
                }
            }
        }
        private void txtSearchRFC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtSearchRFC.Text.Length > 0)
            {
                Buscar();
            }
            else
            {
                resetLista();
            }
        }
    }
}
