using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CarRental.clsSettingLoader;

namespace CarRental
{
    public partial class ctrlListShows : UserControl
    {

        private void _ConnectComponentToSetting()
        {
            clsListSetting.dgvList = this.dgvList;
            clsListSetting.pictureBox = this.guna2PictureBox1;
            clsListSetting.txtFilterBy = this.txtFilterBy;
            clsListSetting.cbFilterBy = this.cbFilterBy;
            clsListSetting.cbPageNumber = this.cbPageNumber;

        }
        private void _DisableComponent(ToolStripMenuItem Item)
        {
            Item.Visible = false;
        }
        private void _DisableComponent(Guna2Button Item)
        {
            Item.Visible = false;
        }
        private void _EnableComponent(ToolStripMenuItem Item)
        {
            Item.Visible = true;
        }
        private void _EnableComponent(Guna2Button Item)
        {
            Item.Visible = true;
        }

        /* public  void LoadSetting(EventHandler Loading, EventHandler Addtion, EventHandler Deletetion, EventHandler Updateing, EventHandler ShowDetails)
         {
             _ConnectComponentToSetting();
             btnAdd.Click += Addtion;
             tsmDelete.Click += Deletetion;
             tsmShowDetails.Click += ShowDetails;
             tsmUpdate.Click += Updateing;
             Loading?.Invoke(this, EventArgs.Empty);

         }*/
        /*public void LoadSetting(EventHandler Loading, EventHandler Updateing, EventHandler ShowDetails)
        {
            _ConnectComponentToSetting();
            tsmShowDetails.Click += ShowDetails;
            tsmUpdate.Click += Updateing;
            Loading?.Invoke(this, EventArgs.Empty);


        }*/

        //Show Mode
        public void LoadSetting( EventHandler Loading,EventHandler PageChanging, EventHandler Filtering, EventHandler FilteringMode, EventHandler ShowDetails)
        {
            _ConnectComponentToSetting();
            _DisableComponent(tsmDelete);
            _DisableComponent(btnAdd);
            _DisableComponent(tsmUpdate);


            this.cbPageNumber.SelectedIndexChanged += PageChanging;
            this.txtFilterBy.TextChanged += Filtering;
            this.cbFilterBy.SelectedIndexChanged += FilteringMode;
            tsmShowDetails.Click += ShowDetails;


            Loading?.Invoke(this,  EventArgs.Empty);




        }

        public ctrlListShows()
        {
            InitializeComponent();

            
        }
       
        
       

        
    }
}
