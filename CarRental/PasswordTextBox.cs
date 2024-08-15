using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental
{
    public partial class PasswordTextBox : GunaTextBox
    {
        public PasswordTextBox()
        {
            InitializeComponent();
        }

        public bool NumberRequired;
        public bool CaptialRequired;
        public bool LengthCondition;
        
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            this.MaxLength = 32;
        }
        public bool PasswordMode { set; get; }
        public bool IsPasswordValid()
        {
            
            if (!PasswordMode) { return true; }

            else 
            {
                NumberRequired = false;
                CaptialRequired = false;
                LengthCondition = false;
                if (this.Text.Length >= 16 && this.Text.Length <= 32)
                {
                    LengthCondition = true;
                    
                    foreach( char c in this.Text)
                    {
                        if(char.IsDigit(c))
                            NumberRequired = true;
                        if(c>64 && c<91)
                            CaptialRequired = true;
                        if (NumberRequired && CaptialRequired)
                            return true;
                    }
                    return false;
                   
                }
            }
            
               return false;
        }
    }
}
