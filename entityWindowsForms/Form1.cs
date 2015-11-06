using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace entityWindowsForms
{
    public partial class Form1 : Form
    {
        allisonEntities db = new allisonEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = 1;
            rol user = new rol();
            user = db.rols.FirstOrDefault(u => u.id_rol == id);
            txtNombre.Text = user.rol_nombre;
            txtApellido.Text = user.id_roles_identity;
           
        }
    }
}
