using FileServer.Common.Model;
using FileServer.Infrastructure.Repository;
using FileServer.Infrastructure.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileServer.Presentation.WinSite
{
    public partial class frmAlumno : Form
    {
        IAlumnoRepository iAlumnoRepository;

        public frmAlumno()
        {
            InitializeComponent();
            iAlumnoRepository = new AlumnoRepository();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var alumno = new Alumno();
            iAlumnoRepository.Add(alumno);
        }
    }
}
