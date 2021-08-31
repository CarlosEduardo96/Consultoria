using Consultoria.ConfAndData;
using Consultoria.View;
using Consultoria.View.Departamento;
using Consultoria.View.Empresa;
using Consultoria.View.Puesto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consultoria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEmpresa_Click(object sender, EventArgs e)
        {
            Departamento d = new Departamento();
            Main.Controls.Add(d);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Main.Controls.Clear();
            Empresa em = new Empresa();
            Main.Controls.Add(em);
        }

        private void btnEmpresa_Click_1(object sender, EventArgs e)
        {
            Main.Controls.Clear();
            Empresa em = new Empresa();
            Main.Controls.Add(em);
        }

        private void btnDepartamento_Click(object sender, EventArgs e)
        {
            Main.Controls.Clear();
            Departamento d = new Departamento();
            Main.Controls.Add(d);
        }

        private void btnPuesto_Click(object sender, EventArgs e)
        {
            Main.Controls.Clear();        
            Puesto p = new Puesto();
            Main.Controls.Add(p);
        }
    }
}
