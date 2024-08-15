using CarRental.Properties;
using CarRental_BusinessLayer;
using Guna.UI.WinForms;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental
{
    
    public partial class ctrlProfileCard : UserControl
    {

        
         private clsSettingLoader _ScreenLoader;

        public class EditionEventArgs : EventArgs
        {
            public int ProfileID { get; }

            public EditionEventArgs(int ProfileID)
            {
                this.ProfileID = ProfileID;
            }
        }
        public void RaiseEditionOpreation(int ProfileID)
        {
            RaiseEdition(new EditionEventArgs(ProfileID));
        }
        protected virtual void RaiseEdition(EditionEventArgs e)
        {
            EditionOpreationCompleted?.Invoke(this, e);
        }

        public event EventHandler<EditionEventArgs> EditionOpreationCompleted;

       
        
        
        
        public class DeletionEventArgs : EventArgs
        {
            public int ProfileID { get; }

            public DeletionEventArgs(int ProfileID)
            {
                this.ProfileID = ProfileID;
            }
        }
        public void RaiseDeletionOpreation(int ProfileID)
        {
            RaiseDeletion(new DeletionEventArgs(ProfileID));
        }
        protected virtual void RaiseDeletion(DeletionEventArgs e)
        {
            DeletionOpreationCompleted?.Invoke(this, e);
        }

        public event EventHandler<DeletionEventArgs> DeletionOpreationCompleted;

        public ctrlProfileCard()
        {
            InitializeComponent();
            
        }

        public void LoadSetting(clsSettingLoader Setting)
        {
            _ScreenLoader = Setting;
        }
        public void LoadProfile(int ProfileID)
        {
           _ScreenLoader.LoadingSetting(ProfileID, lblName, lblNatoinality, pbProfileImage);
           
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            _ScreenLoader.ProfileDetails((int)pbProfileImage.Tag);

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            if (_ScreenLoader == null) { return; }
            
            _ScreenLoader.EditProfile((int)pbProfileImage.Tag);
           
            if(EditionOpreationCompleted != null)
                RaiseEditionOpreation((int)pbProfileImage.Tag);
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_ScreenLoader == null) { return; }
            
            if (MessageBox.Show("Are you sure you want delete this profile", "Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (_ScreenLoader.DeleteProfile((int)pbProfileImage.Tag))
                {
                    MessageBox.Show("Deleting successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);


                    if (DeletionOpreationCompleted != null)
                    {
                        RaiseDeletionOpreation((int)pbProfileImage.Tag);
                    }
                }
                else
                {
                    MessageBox.Show("this  profile have data connected with it ", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        
    }
}
