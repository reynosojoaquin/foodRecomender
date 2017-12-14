using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace RecipeScraper.Lib
{
    class FileTool
    {
        public string GetAplicationDirectory()
        {
            return Application.StartupPath;
        }
        public void WriteLogFile(string data)
        {
            using (StreamWriter File = new StreamWriter(GetAplicationDirectory() + "errorLog.txt", true))
            {
                File.WriteLine(data);
            }
        }
        public string readFile(string route)
        {
            string retorno = string.Empty;
            if (File.Exists(route))
            {
                retorno = File.ReadAllText(route);
            }
            return retorno; 
        }
        public void ClearFile(string route)
        {
            if( MessageBox.Show("Desea Eliminar datos del log","Atension",  MessageBoxButtons.OKCancel,MessageBoxIcon.Question)== DialogResult.OK)
            { 
                if (File.Exists(route))
                 {
                    using (var fs = new FileStream(route, FileMode.Open))
                    {
                        fs.SetLength(0);
                        fs.Close();
                        MessageBox.Show("Datos eliminados correctamente");
                    }
                 }
            }
        }
    }
}
