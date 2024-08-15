using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental
{
    public class clsMoveNonBoraderForms
    {
        static int TopMove;
        static int X;
        static int Y;
        public static Form OpenForm;
        
        
        


        public static void Form_MouseUp(object sender, MouseEventArgs e)
        {
            TopMove = 0;
        }

        public static void Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (TopMove == 1)
            {
                OpenForm.SetDesktopLocation(Form.MousePosition.X - X, Form.MousePosition.Y - Y);
            }
           
        }

        public static void Form_MouseDown(object sender, MouseEventArgs e)
        {
            TopMove = 1;
            X = e.X;
            Y = e.Y;

        }
        public static void Form_Close(object sender, EventArgs e)
        {
            OpenForm.Close();

        }
    }
}
