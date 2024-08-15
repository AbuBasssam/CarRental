using CarRental_BusinessLayer;
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
    public partial class ctrlSearchBar : UserControl
    {
        public void SearchResult(clsUser User)
        {
            lblTitle.Text = User.FirstName;
            lblSubTitle.Text = User.NationalNo;
            this.Tag = User.UserID;

        }

        public ctrlSearchBar()
        {
            InitializeComponent();
        }
    }
}
