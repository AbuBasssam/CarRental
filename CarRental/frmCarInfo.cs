using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental
{
    public partial class frmCarInfo : Form
    {
         
        public frmCarInfo(int CarID)
        {
            InitializeComponent();
            ctrlCarCard1.LoadCarInfo(CarID);
            clsMoveNonBoraderForms.OpenForm = this;
            ctrlCarCard1.MouseUp += clsMoveNonBoraderForms.Form_MouseUp;
            ctrlCarCard1.MouseDown += clsMoveNonBoraderForms.Form_MouseDown;
            ctrlCarCard1.MouseMove += clsMoveNonBoraderForms.Form_MouseMove;
            this.btnClose.Click += clsMoveNonBoraderForms.Form_Close;
        }
    }
}
