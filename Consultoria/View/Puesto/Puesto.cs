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

namespace Consultoria.View.Puesto
{
    public partial class Puesto : UserControl
    {
        private bool IsMessageActive = false;
        private int Count = 0;
        private bool IsEditable = false;
        private ModelPuesto puesto = null;
       
        public Puesto()
        {
            InitializeComponent();
        }

        private void resetPuesto() {
            resetTable();
            ComboDepartamento.SelectedIndex = 0;
            ComboEmpresa.SelectedIndex = 0;
            EmpresaDTO em = new EmpresaDTO();
            DepartamentoDTO d = new DepartamentoDTO();
            List<ModelDepartamento> listaDep = d.FindAll();
            List<ModelEmpresa> listaEm = em.FindAll();
            if (listaDep != null && listaDep != null)
            {
                foreach (var empresa in listaEm)
                {
                    string format = empresa.Id + "-" + empresa.Nombre + "-" + empresa.Rfc;
                    ComboEmpresa.Items.Add(format);
                }
                foreach (var departamento in listaDep)
                {
                    string formato = departamento.Folio + "-" + departamento.Nombre + "-" + departamento.Clave_empresa;
                    ComboDepartamento.Items.Add(formato);
                }
            }
        }
        private void resetTable() {
            ListaPuesto.Rows.Clear();
            PuestoDTO query = new PuestoDTO();
            List<ModelPuesto> lista = query.FindAll();
            if (lista!=null) {
                foreach (var p in lista) {                    
                    string folio = p.Clave_Puesto+"P"+p.Id_Empresa+"E"+p.Folio_Departamento+"D";
                    ListaPuesto.Rows.Add(folio, p.Nombre, p.Descipcion);
                }
            }
        }
        private void Puesto_Load(object sender, EventArgs e)
        {
            resetPuesto();
        }

        private void ComboEmpresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void ComboDepartamento_KeyPress(object sender, KeyPressEventArgs e)
        {
           e.Handled = true;
        }
        private void Guardar() {
            string[] id_em = ComboEmpresa.Text.Split('-');
            string[] clave_dep = ComboDepartamento.Text.Split('-');
            PuestoDTO query = new PuestoDTO();
            ModelPuesto p = new ModelPuesto(txtPuesto.Text, txtDescripcion.Text, int.Parse(id_em[0]), int.Parse(clave_dep[0]));
            if (query.Insert(p) != null)
            {
                panelMensaje.BackColor = Color.FromArgb(67, 160, 71);
                panelMensaje.Visible = true;
                lbMensaje.Text = "¡Datos guardados con exito!";
                IsMessageActive = true;                
            }
            else {
                panelMensaje.BackColor = Color.FromArgb(211, 47, 47);
                panelMensaje.Visible = true;
                lbMensaje.Text = "¡Error al guardar los datos!";
                IsMessageActive = true;
            }
        }
        private void Editar() {
            string[] id_empresa = ComboEmpresa.SelectedItem.ToString().Split('-');
            string[] folio_departamento = ComboDepartamento.SelectedItem.ToString().Split('-');
            
            puesto.Id_Empresa = int.Parse(id_empresa[0]);
            puesto.Folio_Departamento = int.Parse(folio_departamento[0]);
            puesto.At_Date = DateTime.Now.ToString();
            puesto.Nombre = txtPuesto.Text;
            puesto.Descipcion = txtDescripcion.Text;

            PuestoDTO query = new PuestoDTO();
            ModelPuesto p = query.Update(puesto);
            if (p != null)
            {
                panelMensaje.BackColor = Color.FromArgb(67, 160, 71);
                panelMensaje.Visible = true;
                lbMensaje.Text = "¡Datos Actualizados con exito!";
                IsMessageActive = true;
                resetTable();
                tabPuesto.SelectedTab = Agregar_Actualizar;
            }
            else {
                panelMensaje.BackColor = Color.FromArgb(211, 47, 47);
                panelMensaje.Visible = true;
                lbMensaje.Text = "¡Error al guardar los datos!";
                IsMessageActive = true;
            }
        }
        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            if (ComboEmpresa.SelectedIndex > 0 && ComboDepartamento.SelectedIndex > 0 && txtPuesto.Text.Length > 3 && txtDescripcion.Text.Length > 3)
            {
                if (IsEditable == false) {
                    Guardar();
                }
                else {
                    Editar();
                }
                resetTable();
            }
            else {
                panelMensaje.BackColor = Color.FromArgb(211, 47, 47);
                panelMensaje.Visible = true;
                lbMensaje.Text = "¡Rellene los campos minimo 4 caracteres!";
                IsMessageActive = true;
            }
        }

        private void Watch_Puesto_Tick(object sender, EventArgs e)
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

        private void txtPuesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==(char)Keys.Enter) {
                txtDescripcion.Focus();
            }
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Btn_Guardar.Focus();
            }
        }

        private void ListaPuesto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
                DataGridViewRow row = ListaPuesto.Rows[e.RowIndex];
                puesto = new ModelPuesto();

                string clave = row.Cells[0].Value.ToString();
                char[] separar = { 'P', 'E', 'D'};
                int count = 3;
                string[] lista = clave.Split(separar,count,StringSplitOptions.None);
                puesto.Clave_Puesto = int.Parse(lista[0]);
                puesto.Id_Empresa = int.Parse(lista[1]);             
                puesto.Folio_Departamento = int.Parse(lista[2].TrimEnd('D'));
                puesto.Nombre = row.Cells[1].Value.ToString();
                puesto.Descipcion = row.Cells[2].Value.ToString();
                MensajeOpction.Visible = true;
                lbFolio.Text = "Folio: " + row.Cells[0].Value;
            
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            puesto = null;
            MensajeOpction.Visible = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("¿Los datos seran borrados permamente?", "Eliminar", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                PuestoDTO query = new PuestoDTO();
                query.Delete(puesto.Clave_Puesto);
                MensajeOpction.Visible = false;
                resetTable();
            }
        }

        private void Buscar() {
            if (txtSearchRFC.Text.Length > 0) {
                ListaPuesto.Rows.Clear();
                PuestoDTO query = new PuestoDTO();
                List<ModelPuesto> lista = query.Search(txtSearchRFC.Text);
                if (lista!=null) {
                    foreach (var p in lista) {
                        string folio = p.Clave_Puesto + "P" + p.Id_Empresa + "E" + p.Folio_Departamento + "D";
                        ListaPuesto.Rows.Add(folio, p.Nombre, p.Descipcion);
                    }
                }
            }
            else {
                resetTable();
            }
        }
        private void txtSearchRFC_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Buscar();
            }
            catch { }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            IsEditable = true;
            MensajeOpction.Visible = false;
            IsEditable = true;
            MensajeOpction.Visible = false;
            DepartamentoDTO dquery = new DepartamentoDTO();
            EmpresaDTO equery = new EmpresaDTO();

            ModelDepartamento d = dquery.Find(puesto.Folio_Departamento);
            ModelEmpresa em = equery.Find(puesto.Id_Empresa);

            if (d!=null && em!=null) {
                ComboEmpresa.SelectedItem = em.Id+"-"+em.Nombre+"-"+em.Rfc;
                ComboDepartamento.SelectedItem = d.Folio + "-"+d.Nombre+"-"+d.Clave_empresa;
            }
            tabPuesto.SelectedTab = Agregar_Actualizar;
            txtPuesto.Text = puesto.Nombre;
            txtDescripcion.Text = puesto.Descipcion;

        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            ComboEmpresa.SelectedIndex = 0;
            ComboDepartamento.SelectedIndex = 0;
            txtPuesto.Clear();
            txtDescripcion.Clear();
            puesto = null;
            IsEditable = false;
        }

    }
}
