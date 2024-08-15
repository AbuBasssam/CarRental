using CarRental_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace CarRental
{
    
    public partial class frmProfiles : Form
    {
        clsSettingLoader _SettingLoader;
        byte NumberOfPage = 1;
     private void _LoadCardSetting()
     {
            ctrlProfileCard1.LoadSetting(_SettingLoader);
            ctrlProfileCard2.LoadSetting(_SettingLoader);
            ctrlProfileCard3.LoadSetting(_SettingLoader);
            ctrlProfileCard4.LoadSetting(_SettingLoader);
            ctrlProfileCard5.LoadSetting(_SettingLoader);
            ctrlProfileCard6.LoadSetting(_SettingLoader);
            ctrlProfileCard7.LoadSetting(_SettingLoader);
            ctrlProfileCard8.LoadSetting(_SettingLoader);
            ctrlProfileCard9.LoadSetting(_SettingLoader);
            ctrlProfileCard10.LoadSetting(_SettingLoader);

            /*foreach (ctrlProfileCard Card in Cardslist)
            {
                Card.LoadSetting(_SettingLoader);
            }*/
        }

        private IReadOnlyList<ctrlProfileCard> Cardslist => new[]
        {
            ctrlProfileCard1,
            ctrlProfileCard2,
            ctrlProfileCard3,
            ctrlProfileCard4,
            ctrlProfileCard5,
            ctrlProfileCard6,
            ctrlProfileCard7,
            ctrlProfileCard8,
            ctrlProfileCard9,
            ctrlProfileCard10
        };
           

        public bool LoadingSetting(int PageNumber)
        {
            if (Cardslist.Any(Card => !Card.Visible))
                Cardslist.Where(CardList => !CardList.Visible).ToList().ForEach(CardList => CardList.Visible = true);


            var profileIDs = _SettingLoader.GetProfileIDsList(PageNumber);
            if (!profileIDs.Any())
            {
                btnNextPage.Visible = false;


                return false;
            }

            _LoadCardSetting();

            for (int i = 0; i < profileIDs.Count; i++)
            {
                 Cardslist[i].LoadProfile(profileIDs[i]);
            }

            if (profileIDs.Count < Cardslist.Count)
            {
                Cardslist.Skip(profileIDs.Count).ToList().ForEach(card => card.Visible = false);
                btnNextPage.Visible = false;
            }

            return true;

            /*if(Cardslist.Any(Card => !Card.Visible))
            Cardslist.Where(CardList => !CardList.Visible).ToList().ForEach(CardList => CardList.Visible = true);


            var profileIDs = _SettingLoader.GetProfileIDsList(PageNumber);
            if (!profileIDs.Any())
            {
                btnNextPage.Visible = false;

              
                return false;
            }

            var cardLoadTasks = Cardslist.Take(profileIDs.Count).Select((card, index) => card.LoadSetting(_SettingLoader)).ToList();
            await Task.WhenAll(cardLoadTasks);

            for (int i = 0; i < profileIDs.Count; i++)
            {
                await Cardslist[i].LoadProfile(profileIDs[i]);
            }

            if (profileIDs.Count < Cardslist.Count)
            {
                Cardslist.Skip(profileIDs.Count).ToList().ForEach(card => card.Visible = false);
                btnNextPage.Visible = false;
            }

            return true;
*/

            /*List<int> ProfilesList = new List<int>(SettingLoader.GetProfileIDsList(NumberOfPage));
            List<ctrlProfileCard> Cardslist = new List<ctrlProfileCard>
            {
              ctrlProfileCard1,
              ctrlProfileCard2,
              ctrlProfileCard3,
              ctrlProfileCard4,
              ctrlProfileCard5,
              ctrlProfileCard6,
              ctrlProfileCard7,
              ctrlProfileCard8,
              ctrlProfileCard9,
              ctrlProfileCard10
            };

            if (ProfilesList.Count == 0)
            {
                btnNextPage.Visible = false;

                return false;
            }
            if (ProfilesList.Count < 10)
            {
                for (int i = ProfilesList.Count; i < Cardslist.Count; i++)
                {
                    Cardslist[i].Visible = false;
                }
                btnNextPage.Visible = false;
            }

            var Tasks = new List<Task>
            {
              ctrlProfileCard1.LoadSetting(SettingLoader),
              ctrlProfileCard2.LoadSetting(SettingLoader),
              ctrlProfileCard3.LoadSetting(SettingLoader),
              ctrlProfileCard4.LoadSetting(SettingLoader),
              ctrlProfileCard5.LoadSetting(SettingLoader),
              ctrlProfileCard6.LoadSetting(SettingLoader),
              ctrlProfileCard7.LoadSetting(SettingLoader),
              ctrlProfileCard8.LoadSetting(SettingLoader),
              ctrlProfileCard9.LoadSetting(SettingLoader),
              ctrlProfileCard10.LoadSetting(SettingLoader)

            };
            await Task.WhenAll(Tasks);

            for (int i = 0; i < ProfilesList.Count; i++)
            {
                await Cardslist[i].LoadProfile(ProfilesList[i]);

            }
            return true;
*/


        }
        
        public  bool Filter(string Value)
        {
            Cardslist.Where(CardList => !CardList.Visible).ToList().ForEach(CardList => CardList.Visible = true);


            

            var profileIDs = _SettingLoader.Filter(Value);
            if (!profileIDs.Any())
            {
                btnNextPage.Visible = false;
                Cardslist.Where(CardList => CardList.Visible).ToList().ForEach(CardList => CardList.Visible = false);


                return false;
            }
           // _LoadCardSetting();


            for (int i = 0; i < profileIDs.Count; i++)
            {
                 Cardslist[i].LoadProfile(profileIDs[i]);
            }

            if (profileIDs.Count < Cardslist.Count)
            {
                Cardslist.Skip(profileIDs.Count).ToList().ForEach(card => card.Visible = false);
                btnNextPage.Visible = false;
            }
            return true;





        }
        /*public async Task<bool> Filter(string Value)
        {
           Cardslist.Where(CardList => !CardList.Visible).ToList().ForEach(CardList => CardList.Visible = true);


*//*            ctrlProfileCard1.Visible = true;
            ctrlProfileCard2.Visible = true;
            ctrlProfileCard3.Visible = true;
            ctrlProfileCard4.Visible = true;
            ctrlProfileCard5.Visible = true;
            ctrlProfileCard6.Visible = true;
            ctrlProfileCard7.Visible = true;
            ctrlProfileCard8.Visible = true;
            ctrlProfileCard9.Visible = true;
            ctrlProfileCard10.Visible = true;*//*

            var profileIDs = _SettingLoader.Filter(Value);
            if (!profileIDs.Any())
            {
                btnNextPage.Visible = false;
                Cardslist.Where(CardList => CardList.Visible).ToList().ForEach(CardList => CardList.Visible = false);


                return false;
            }

            var cardLoadTasks = Cardslist.Take(profileIDs.Count).Select((card, index) => card.LoadSetting(_SettingLoader)).ToList();
            await Task.WhenAll(cardLoadTasks);

            for (int i = 0; i < profileIDs.Count; i++)
            {
                await Cardslist[i].LoadProfile(profileIDs[i]);
            }

            if (profileIDs.Count < Cardslist.Count)
            {
                Cardslist.Skip(profileIDs.Count).ToList().ForEach(card => card.Visible = false);
                btnNextPage.Visible = false;
            }

            return true;


            


        }*/

        public frmProfiles(clsSettingLoader settingLoader)
        {
            InitializeComponent();
            _SettingLoader = settingLoader;

        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
          
            if( LoadingSetting(NumberOfPage+1))
            NumberOfPage++;
        }

        private void frmProfiles_Load(object sender, EventArgs e)
        {
            
            LoadingSetting(NumberOfPage);
            cbFilterBy.SelectedIndex = 0;
            
        }

        private void ctrlProfileCard_DeletionOpreationCompleted(object sender, ctrlProfileCard.DeletionEventArgs e)
        {
             LoadingSetting(NumberOfPage);

        }
        
        private void ctrlProfileCard_EditionOpreationCompleted(object sender, ctrlProfileCard.EditionEventArgs e)
        {

             LoadingSetting(NumberOfPage);
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
           if(txtFilterBy.TextLength>0)
            Filter(txtFilterBy.Text);
            
            else
            LoadingSetting(NumberOfPage);
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbFilterBy.SelectedItem)
            {
                case "First Name":
                    _SettingLoader.SetFilterMode(clsSettingLoader.enFilterMode.FirstName);
                    txtFilterBy.CharacterCasing = CharacterCasing.Normal;

                    break;
                case "Phone Number":
                    _SettingLoader.SetFilterMode(clsSettingLoader.enFilterMode.PhoneNumber);
                    txtFilterBy.CharacterCasing = CharacterCasing.Normal;

                    break;
                case "National No":
                    _SettingLoader.SetFilterMode(clsSettingLoader.enFilterMode.NationalNo);
                    txtFilterBy.CharacterCasing = CharacterCasing.Upper;
                    break;


            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _SettingLoader.AddProfile();
        }
    }
}
