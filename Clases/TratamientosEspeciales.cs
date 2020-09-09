using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practico.Clases
{
    class TratamientosEspeciales  //cuarta capa
    {
        public enum Validacion { correcta, incorrecta }

        public Validacion Validar(Control.ControlCollection controles) // valida que un objeto textbox01 tenga datos
        {
            foreach (var item in controles)
            {
                if (item.GetType().Name == "TextBox01")
                {
                    if (((TextBox01)item).PpValidable == true)
                    {
                        if (((TextBox01)item).Text == "")
                        {
                            MessageBox.Show(((TextBox01)item).PpMensajeError, caption:"Atención",
                                icon:MessageBoxIcon.Exclamation, buttons:MessageBoxButtons.OK);
                            ((TextBox01)item).Focus();
                            return Validacion.incorrecta;
                        }
                    }
                }
            }

            return Validacion.correcta;
        }


        public Validacion ValidarAlMenosUno(Control.ControlCollection controles) // valida que un objeto textbox01 tenga datos
        {
            foreach (var item in controles)
            {
                if (item.GetType().Name == "TextBox01")
                {
                    if (((TextBox01)item).PpValidable == true)
                    {
                        if (((TextBox01)item).Text != "")
                        {
                            return Validacion.correcta;
                        }
                    }
                }
                if (item.GetType().Name == "ComboBox01")
                {
                    if (((ComboBox01)item).PpValidable == true)
                    {
                        if (((ComboBox01)item).Text != "")
                        {
                            return Validacion.correcta;
                        }
                    }
                }
            }
            MessageBox.Show("Ingrese un parametro de busqueda!", caption: "Atención",
                icon: MessageBoxIcon.Exclamation, buttons: MessageBoxButtons.OK);
            return Validacion.incorrecta;
        }

    }
}
