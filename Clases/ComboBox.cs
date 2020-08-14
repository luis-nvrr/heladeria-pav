using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practico.Clases
{
    class ComboBox : System.Windows.Forms.ComboBox
    {
        public string ppTabla { get; set; }
        public string ppDisplay { get; set; }
        public string ppValue { get; set; }

        public bool ppValidable { get; set; }
        public string ppNombreCampo { get; set; }
        public string ppNombreTabla { get; set; }


        public void Cargar()  //cargar con consulta SELECT *
        {
            BaseDatos baseDatos = new BaseDatos();
            string sql = "SELECT * FROM " + ppTabla;
            this.DisplayMember = ppDisplay;
            this.ValueMember = ppValue;
            this.DataSource = baseDatos.Consulta(sql);
        }

        public void Cargar(string tabla, string display, string value)
        {
            ;
        }

        public void Cargar(DataTable tabla, string display, string value)
        {
            this.DisplayMember = display;
            this.ValueMember = value;
            this.DataSource = tabla;

        }

    }
}
