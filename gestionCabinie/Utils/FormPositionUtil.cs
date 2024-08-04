using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestionCabinie.Utils
{
    public class FormPositionUtil
    {
        public static void OpenNewForm(Form currentForm, Form newForm)
        {
            Point currentFormPosition = currentForm.Location;
            Size currentFormSize = currentForm.Size;

            newForm.StartPosition = FormStartPosition.Manual;

            newForm.Location = currentFormPosition;
            newForm.Size = currentFormSize;

            newForm.Show();

            currentForm.Hide();
        }
    }
}
