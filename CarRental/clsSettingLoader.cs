using Guna.UI.WinForms;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CarRental.clsSettingLoader;

namespace CarRental
{
    public class clsSettingLoader
    {
        public delegate void Loading(int ProfileID, GunaLabel Title, GunaLabel subTitle, PictureBox ProfilePictureBox);

        //public delegate void Loading(int ProfileID, GunaLabel Title, GunaLabel subTitle, PictureBox ProfilePictureBox);
        public delegate bool Delete(int ProfileID);
        public delegate void Edit(int ProfileID,bool Enable=true);
        public delegate void Add();
        public delegate List<int> ProfileIDList(int PageNumber); 
        public delegate void DetailsCard(int ProfileID);
        public delegate List<int> ProfileIDFilter(string Value);

        private Loading _Loader;
        
        private Add _Adder;

        private Delete _Deletor;
        
        private Edit _Editor;
        private  ProfileIDList _ProfileIDsList;
        private DetailsCard _DetailsCard;
        private ProfileIDFilter _FirstNameFilter;
        private ProfileIDFilter _NationalNoFilter;
        private ProfileIDFilter _PhoneNumberFilter;
        public enum enFilterMode { FirstName = 1, NationalNo = 2, PhoneNumber = 3 };
        private enFilterMode _FilterMode;

        public void SetFilterMode(enFilterMode FilterMode) {_FilterMode = FilterMode; }
        public clsSettingLoader(Loading Loader,Add Adder, Delete Deletor, Edit Editor,ProfileIDList profileIDList,
            DetailsCard DetailsCard, ProfileIDFilter FirstNameFilter, ProfileIDFilter NationalNoFilter, ProfileIDFilter PhoneNumberFilter)
        {
            this._Loader = Loader;
            this._Adder = Adder;
            this._Deletor = Deletor;
            this._Editor = Editor;
            this._ProfileIDsList = profileIDList;
            this._DetailsCard = DetailsCard;
            this._FirstNameFilter = FirstNameFilter;
            this._NationalNoFilter = NationalNoFilter;
            this._PhoneNumberFilter = PhoneNumberFilter;

        }

        public void LoadingSetting(int ProfileID, GunaLabel Title, GunaLabel subTitle, PictureBox ProfilePictureBox)
        {
            _Loader(ProfileID, Title, subTitle, ProfilePictureBox);
        }

        public bool DeleteProfile(int ProfileID)
        {

            return _Deletor(ProfileID);
        }

        public void EditProfile(int ProfileID)
        {
            _Editor(ProfileID);
        }
        public void AddProfile()
        {
            _Adder();
        }

        public List<int> GetProfileIDsList(int PageNumber = 1)
        {
           return _ProfileIDsList(PageNumber);
        }
        
        public void ProfileDetails(int ProfileID)
        {
            _DetailsCard(ProfileID);
        }
        
        public void ChangeProfileIDsList(ProfileIDList List)
        {
            _ProfileIDsList = List;
        }
       
        public List<int> Filter(string FilterBy)
        {
            switch (_FilterMode)
            {
                case enFilterMode.FirstName:
                   return _FirstNameFilter(FilterBy);
                    
                case enFilterMode.NationalNo:
                    return _NationalNoFilter(FilterBy);
                    

                case enFilterMode.PhoneNumber:
                    return _PhoneNumberFilter(FilterBy);
            }
            return null;
        }
      
      //public  ProfileIDList List() {  return _ProfileIDsList;  }
        public void Dispose()
        {
            _Loader = null;
        }
    }
}
