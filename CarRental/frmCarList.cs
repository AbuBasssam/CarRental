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
    public partial class frmCarList : Form
    {
       private List<clsCar> _CarList = new List<clsCar>();
        byte NumberOfPages = 0;
        byte FilterPages = 0;
        
        private IReadOnlyList<ctrlCarProfile> Cardslist => new[]
        {
            ctrlCarProfile1,
            ctrlCarProfile2,
            ctrlCarProfile3,
            ctrlCarProfile4,
            ctrlCarProfile5,
            ctrlCarProfile6,
            ctrlCarProfile7,
            ctrlCarProfile8,
            ctrlCarProfile9,
            ctrlCarProfile10,
            ctrlCarProfile11,
            ctrlCarProfile12
    
        };

        public frmCarList()
        {
            InitializeComponent();
        }
        private void _AddcbPageNumberItems()
        {
            if (cbPageNumber.Items.Count > 0) { cbPageNumber.Items.Clear(); }
            for (int i = 1; i <= NumberOfPages; i++)
            {
               
                cbPageNumber.Items.Add(i.ToString());
            }
        }
        
        private void _AddFiltercbPageNumberItems()
        {
            if (cbPageNumber.Items.Count > 0) { cbPageNumber.Items.Clear(); }
            for (int i = 1; i <= FilterPages; i++)
            {

                cbPageNumber.Items.Add(i.ToString());
            }
        }

        private bool _PlateNumberCheck(string PlateNumber)
        {

            bool NumberRequired = false;
            bool LetterRequired = false;
            PlateNumber = PlateNumber.Replace(" ", "");

            if (PlateNumber.Length > 6)
            {
                return false;

            }

            for (int i = 0; i < 3; i++)
            {
                if (char.IsDigit(PlateNumber[i]))
                {
                    NumberRequired = true;
                    break;
                }
            }

            for (int i = PlateNumber.Length / 2; i <= PlateNumber.Length - 1; i++)
            {
                if (char.IsLetter(PlateNumber[i]))
                {
                    LetterRequired = true;
                    break;
                }


            }
            if (!NumberRequired)
            {
                return false;
            }
            if (!LetterRequired)
            {
                return false;
            }
            return true;
        }

        private bool _VINCheck(string VIN)
        {

            if (VIN.Length != 17)
            {
                return false;

            }

            for (int i = 11; i <= 16; i++)
            {
                if (!char.IsDigit(VIN[i]))
                {
                    return false;
                }
            }


            return true;
        }

        private void _LoadFilterData(object sender ,List<clsCar> CarList)
        {

            /*Cardslist.Where(Cardslist => !Cardslist.Visible).ToList().ForEach(Cardslist => Cardslist.Visible = true);

            if (!CarList.Any())
            {
                Cardslist.Where(CardList => CardList.Visible).ToList().ForEach(CardList => CardList.Visible = false);
                return;
            }
            if (CarList.Count < Cardslist.Count)
            {
                Cardslist.Skip(CarList.Count).ToList().ForEach(card => card.Visible = false);
               
            }
         
            for (int i = 0; i<12; i++)
            {
                Cardslist[i].LoadCarInfo(CarList[i]);

            }*/

            this._CarList = CarList;
            if (_CarList.Count > 12)
            {
                cbPageNumber.Items.Clear();
                FilterPages = (byte)Math.Ceiling((float)_CarList.Count / (float)12);

                _AddFiltercbPageNumberItems();
            }
            else
            {
                cbPageNumber.Items.Clear();
                cbPageNumber.Items.Add(1.ToString());

            }
            cbPageNumber.SelectedIndex = 0;





        }

        private void _FilterMode()
        {
            if (Cardslist.Any(CarCard => !CarCard.Visible))
            {
                Cardslist.Where(Cardslist => !Cardslist.Visible).ToList().ForEach(Cardslist => Cardslist.Visible = true);

            }

            
            int i = (Convert.ToInt32(cbPageNumber.SelectedItem) - 1)*12;
            int Counter = 0;
            
            while(i< _CarList.Count && Counter<12)
            {
                Cardslist[Counter].LoadCarInfo(_CarList[i]);
                i ++;
                Counter++;

            }
            if (Counter < 12)
            {
                Cardslist.Skip(Counter).ToList().ForEach(card => card.Visible = false);

            }

          

            
        }

        private void _PageMode()
        {
            
            this._CarList = clsCar.GetCarPage(cbPageNumber.SelectedIndex + 1);
            if (Cardslist.Any(CarCard => !CarCard.Visible))
            {
                Cardslist.Where(Cardslist => !Cardslist.Visible).ToList().ForEach(Cardslist => Cardslist.Visible = true);

            }
            if (_CarList.Count < 12)
            {
                Cardslist.Skip(_CarList.Count).ToList().ForEach(card => card.Visible = false);

            }
            for (int i = 0; i < _CarList.Count; i++)
            {
                Cardslist[i].LoadCarInfo(_CarList[i]);
            }
        }
        
        private void frmCarList_Load(object sender, EventArgs e)
        {
            this._CarList = clsCar.GetCarPage(1);
            NumberOfPages = (byte)clsCar.NumberOfPages();
            cbPageNumber.Items.Clear();
            _AddcbPageNumberItems();
            cbPageNumber.SelectedIndex = 0;
            

        }

        private void cbPageNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (btnFilter.Tag.ToString() == "ON")
            {
                _FilterMode();
            }
            else
            {

                _PageMode();

            }


        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {



            if (btnFilter.Tag.ToString() == "ON")
            {
                btnFilter.Tag = "OFF";
                _AddcbPageNumberItems();
                cbPageNumber.SelectedIndex = 0;
                btnFilter.Checked = false;

                _PageMode();


            }
            else
            {
                btnFilter.Tag = "ON";
                frmCarFilter frm1 = new frmCarFilter();
                frm1.DataBack += _LoadFilterData;
                frm1.ShowDialog();
                btnFilter.Checked = true;
            }



        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtFindBy.Text == "") { return; }
            switch (cbFindBy.SelectedItem)
            {
                case "ID":
                    ctrlCarProfile1.LoadCarInfo(clsCar.Find(Convert.ToInt32(txtFindBy.Text)));
                    Cardslist.Skip(1).ToList().ForEach(card => card.Visible = false);
                    break;
                case "Plate Number":
                    if (!_PlateNumberCheck(txtFindBy.Text))
                    {
                        MessageBox.Show("Wrong Format the Plate number should have at most 6 characters Contain at least 1 digit and 1 letter", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    ctrlCarProfile1.LoadCarInfo(clsCar.Find(txtFindBy.Text));
                    Cardslist.Skip(1).ToList().ForEach(card => card.Visible = false);
                    break;
                default:
                    if (!_VINCheck(txtFindBy.Text))
                    {
                        MessageBox.Show("Wrong Format the VIN should have at most 17 characters Last 6 must be digits", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    ctrlCarProfile1.LoadCarInfo(clsCar.FindByVIN(txtFindBy.Text));
                    Cardslist.Skip(1).ToList().ForEach(card => card.Visible = false);

                    break;
            }
        }
        
        private void txtFindBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFindBy.SelectedIndex == 0)
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);


            }
        }

        
    }
}
