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
    public partial class ctrlUserCardWithFilter : UserControl
    {
        public ctrlUserCardWithFilter()
        {
            InitializeComponent();
        }
       
        private bool _FilterEnabled = true;
        
        public bool FilterEnabled
        {
            get
            {
                return _FilterEnabled;
            }
            set
            {
                _FilterEnabled = value;
                gbFilters.Enabled = _FilterEnabled;
            }
        }

        private int _UserID = -1;

        public int UserID
        {
            get { return ctrlUserCard1.UserID; }
        }

        public clsUser SelectedUserInfo
        {
            get { return ctrlUserCard1.SelectedUserInfo; }
        }
        
        public void LoadUserInfo(int UserID)
        {
            
            txtIDValue.Text = UserID.ToString();
            ctrlUserCard1.LoadUserInfo(UserID);

        }
       
        public void FilterFocus()
        {
            txtIDValue.Focus();
        }

       
        public event EventHandler<clsUser> OnUserSelected;

        protected virtual void RaiseOnUserSelected(clsUser user)
        {
            OnUserSelected?.Invoke(this, user);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddUpdateUsers frm1 = new frmAddUpdateUsers();
            frm1.DataBack += DataBackEvent; // Subscribe to the event
            frm1.ShowDialog();


        }
        
        private void DataBackEvent(object sender, int UserID)
        {
            // Handle the data received

            txtIDValue.Text = UserID.ToString();
            ctrlUserCard1.LoadUserInfo(UserID);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            ctrlUserCard1.LoadUserInfo(int.Parse(txtIDValue.Text));

            if (OnUserSelected != null && FilterEnabled)
                //Raise the event with a parameter
               OnUserSelected(this, SelectedUserInfo);
    }

        private void txtIDValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void txtIDValue_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtIDValue.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtIDValue, "This field is required!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtIDValue, null);
            }
        }
    }
}
