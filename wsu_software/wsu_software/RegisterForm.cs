using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wsu_software
{
    public partial class RegisterForm : Form
    {
        RFIDReader rdx;
        bool personExistFlag =false;
        public RegisterForm(RFIDReader rd)
        {
            InitializeComponent();
            rdx = rd;
        }

        private void btnSubmitClick_Click(object sender, EventArgs e)
        {
            // Submit it to the database table
            DataAccess db = new DataAccess();
            if (personExistFlag)
            {
                db.InsertPeople(tboxFirstName.Text, tboxLastName.Text, tboxRole.Text, tboxTitle.Text, tboxSSD.Text, tboxRescueStation.Text, tboxVerificationMuster.Text, tboxEmergency.Text, cmboxAccess.Text, tboxRFIDTagID.Text, Convert.ToBoolean(tboxFR.Text));
                
            }
            else
            {
                db.InsertPeople(tboxFirstName.Text, tboxLastName.Text, tboxRole.Text, tboxTitle.Text, tboxSSD.Text, tboxRescueStation.Text, tboxVerificationMuster.Text, tboxEmergency.Text, cmboxAccess.Text, tboxRFIDTagID.Text, Convert.ToBoolean(tboxFR.Text));
                db.InsertPeopleMain(tboxFirstName.Text, tboxLastName.Text, tboxRole.Text, tboxTitle.Text, tboxSSD.Text, tboxRescueStation.Text, tboxVerificationMuster.Text, tboxEmergency.Text, cmboxAccess.Text, tboxRFIDTagID.Text, Convert.ToBoolean(tboxFR.Text));

            }


            this.Close();

        }


        // Reader will scan the tags and order them based on the distance from the reader.
        private async void btnAutoPopulateClick_Click(object sender, EventArgs e)
        {
            tboxRFIDTagID.Text = "";
            allClear();
            
            await Task.Run(() => rdx.autoPopulate(23.0, -65.0));
            tboxRFIDTagID.Text =  assignRFID();
            rdx.ResetSettings(23.0, -65.0);
            //rdx.stop();
            Person personInfo = new Person();
            DataAccess db = new DataAccess();
            // check if the RFID tag exist in the main table 

            personInfo = db.CheckPeople(tboxRFIDTagID.Text);

            if (personInfo != null)
            {
                tboxFirstName.Text = personInfo.FirstName;
                tboxLastName.Text = personInfo.LastName;
                tboxRole.Text = personInfo.Role;
                tboxRescueStation.Text = personInfo.RescueStation;
                tboxSSD.Text = personInfo.SpecialSeaDuty;

                tboxEmergency.Text = personInfo.Emergency;
                tboxFR.Text = Convert.ToString(personInfo.FacialRecognition);
                tboxTitle.Text = personInfo.Title;
                tboxVerificationMuster.Text = personInfo.VerificationMuster;
                cmboxAccess.Text = personInfo.Access;

                personExistFlag = true;

            }
            else
            {
                personExistFlag = false;
            }
        }
        public string assignRFID()
        {
            while (true)
            {
                if (rdx.tagInfo != null)
                {
                   
                    return rdx.tagInfo;   
                }
            }
        }


        public void allClear()
        {
            tboxFirstName.Text = "";
            tboxLastName.Text = "";
            tboxRole.Text = "";
            tboxRescueStation.Text = "";
            tboxSSD.Text ="";

            tboxEmergency.Text = "";
            tboxFR.Text = "";
            tboxTitle.Text = "";
            tboxVerificationMuster.Text = "";
            cmboxAccess.Text = "";
        }
    }
}
