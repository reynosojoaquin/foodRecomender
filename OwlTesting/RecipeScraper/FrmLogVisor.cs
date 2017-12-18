using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RecipeScraper.Lib;

namespace RecipeScraper
{
    public partial class frmLogVisor : Form
    {
        FileTool Ftool = new FileTool();
        public frmLogVisor()
        {
            InitializeComponent();
        }

        private void FrmLogVisor_Load(object sender, EventArgs e)
        {
            getDataFromLog();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Ftool.ClearFile(Ftool.GetAplicationDirectory() + "errorLog.txt");
            getDataFromLog();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void getDataFromLog()
        {
            txtErrorLog.ScrollBars = ScrollBars.Both;
            txtErrorLog.Text = Ftool.readFile(Ftool.GetAplicationDirectory() + "errorLog.txt");
        }
    }
}
