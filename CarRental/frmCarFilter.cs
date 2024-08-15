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
    public partial class frmCarFilter : Form
    {
       
       
        
        public delegate void DataBackEventHandler(object sender, List<clsCar> Result);

        public frmCarFilter()
        {
            InitializeComponent();
            clsMoveNonBoraderForms.OpenForm = this;
            this.MouseUp += clsMoveNonBoraderForms.Form_MouseUp;
            this.MouseDown += clsMoveNonBoraderForms.Form_MouseDown;
            this.MouseMove += clsMoveNonBoraderForms.Form_MouseMove;
            this.btnClose.Click += clsMoveNonBoraderForms.Form_Close;
        }
        public event DataBackEventHandler DataBack;

        

        private void btnOK_Click(object sender, EventArgs e)
        {
            clsCar.stFilterValues FilterValues;
            FilterValues.Make=(cbMake.SelectedIndex==-1)? "": cbMake.SelectedItem.ToString();
            FilterValues.Model= (cbModel.SelectedIndex == -1) ? "" : cbModel.SelectedItem.ToString();
            FilterValues.Year =(cbYear.SelectedIndex==-1)?0: Convert.ToInt32(cbYear.SelectedItem);
            FilterValues.Mileage = (txtMileage.Text == "")?0: Convert.ToInt32(txtMileage.Text.Trim());
            FilterValues.CarCategory= (cbCategory.SelectedIndex == -1)? 0 :(cbCategory.SelectedIndex+1);
            FilterValues.FuleType= (cbFuleType.SelectedIndex == -1)   ? 0 :(cbFuleType.SelectedIndex+1);
            FilterValues.MinumRentalDailyPrice =(txtMinumRentalDailyPrice.Text=="")? 0:Convert.ToSingle(txtMinumRentalDailyPrice.Text.Trim());
            FilterValues.MaxumRentalDailyPrice =(txtMaxumRentalDailyPrice.Text=="")? 0:Convert.ToSingle(txtMaxumRentalDailyPrice.Text.Trim());
            FilterValues.Transmission= Convert.ToInt16((cbTransmission.SelectedIndex == -1) ? -1 : (cbTransmission.SelectedIndex));
            FilterValues.Status= (cbStatus.SelectedIndex == -1) ? 0 : (cbStatus.SelectedIndex + 1);
            List<clsCar> Result=clsCar.CarFilter(FilterValues);
            DataBack?.Invoke(this, Result);



        }

        private void frmCarFilter_Load(object sender, EventArgs e)
        {
            var FuleTypeTask = Task.Run(() => clsFuleType.GetAllFuleTypes());
            var CarCategoriesTask = Task.Run(() => clsCarCategory.GetAllCategories());
           
            int startYear = 2017;
            int endYear = DateTime.Now.Year;
            var years = Enumerable.Range(startYear, endYear - startYear + 1).ToList();
            cbYear.DataSource = years;
            cbYear.SelectedIndex = -1;

            Task.WaitAll(FuleTypeTask, CarCategoriesTask);
            clsUtil.FillComboBox(FuleTypeTask.Result, cbFuleType, "FuleType", false);
            clsUtil.FillComboBox(CarCategoriesTask.Result, cbCategory, "CategoryName",false);
        }

        private void cbMake_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMake.SelectedIndex != -1)
            {
                cbModel.Items.Clear();

                clsUtil.FillComboBox(clsCar.GetMakeModels(cbMake.SelectedItem.ToString()), cbModel, "ModelName",false);
            }
        }
    }
}
