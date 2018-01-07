using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IngredientMinery
{
    public partial class frmVisualizarOwlFile : Form
    {
        public string OwlFileStr = string.Empty;
        public frmVisualizarOwlFile()
        {
            InitializeComponent();
        }

        private void frmVisualizarOwlFile_Load(object sender, EventArgs e)
        {
            txtOwlFileData.Text = OwlFileStr;
            txtOwlFileData.ScrollBars = ScrollBars.Both;
        }
    }
}
