using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;

namespace wsu_software
{
    public class DataAccess
    {
        public void InsertPeople(string FirstName, string LastName, string Role, string Title, string SSD, string RescueStation, string VerificationMuster, string Emergency, string Access, string RFIDTagID, bool FR)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("wsuDB")))
            {
                //Person newPerson = new Person { FirstName = FirstName, LastName = LastName, Role = Role, Title = Title, SpecialSeaDuty = SSD, RescueStation = RescueStation, VerficationMuster = VerificationMuster, Emergency = Emergency, Access = Access, RfidTagId = RFIDTagID, FacialRecognition = FR };
                List<Person> people = new List<Person>();

                people.Add(new Person { FirstName = FirstName, LastName = LastName, Role = Role, Title = Title, SpecialSeaDuty = SSD, RescueStation = RescueStation, VerificationMuster = VerificationMuster, Emergency = Emergency, Access = Access, RfidTagId = RFIDTagID, FacialRecognition = FR });

                connection.Execute("dbo.InsertProcedure @FirstName, @LastName, @Role, @Title, @SpecialSeaDuty, @RescueStation, @VerificationMuster, @Emergency, @Access, @RfidTagId, @FacialRecognition ", people);

                const string message = "Successfully Added to the Ship database";
                const string caption = "Info";
                var result = MessageBox.Show(message, caption);
            }
        }


        public void InsertPeopleMain(string FirstName, string LastName, string Role, string Title, string SSD, string RescueStation, string VerificationMuster, string Emergency, string Access, string RFIDTagID, bool FR)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("wsuDB")))
            {
                //Person newPerson = new Person { FirstName = FirstName, LastName = LastName, Role = Role, Title = Title, SpecialSeaDuty = SSD, RescueStation = RescueStation, VerficationMuster = VerificationMuster, Emergency = Emergency, Access = Access, RfidTagId = RFIDTagID, FacialRecognition = FR };
                List<Person> people = new List<Person>();

                people.Add(new Person { FirstName = FirstName, LastName = LastName, Role = Role, Title = Title, SpecialSeaDuty = SSD, RescueStation = RescueStation, VerificationMuster = VerificationMuster, Emergency = Emergency, Access = Access, RfidTagId = RFIDTagID, FacialRecognition = FR });

                connection.Execute("dbo.InsertProcedureMain @FirstName, @LastName, @Role, @Title, @SpecialSeaDuty, @RescueStation, @VerificationMuster, @Emergency, @Access, @RfidTagId, @FacialRecognition ", people);

                const string message = "Successfully Added to the Main database";
                const string caption = "Info";
                var result = MessageBox.Show(message, caption);
            }
        }


        public void GenerateWSB()
        {
            // get data from DB and put it into a list 
            // put the list into the excel file

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("wsuDB")))
            {
                //Person newPerson = new Person { FirstName = FirstName, LastName = LastName, Role = Role, Title = Title, SpecialSeaDuty = SSD, RescueStation = RescueStation, VerficationMuster = VerificationMuster, Emergency = Emergency, Access = Access, RfidTagId = RFIDTagID, FacialRecognition = FR };
                List<Person> wsb = new List<Person>();
                wsb = connection.Query<Person>("dbo.GenerateWSBProcedure").ToList();

                using (StreamWriter sw = File.CreateText("F:\\xtractai\\wsu\\wsu_software\\wsu_software\\list.csv"))
                {
                    var cols = "FirstName, LastName, Role, Title, Special Sea Duty, Rescue Station, Verification Muster, Emergency, Access";
                    sw.WriteLine(cols);
                    for (int i = 0; i < wsb.Count; i++)
                    {
                        var line = $"{wsb[i].FirstName}, {wsb[i].LastName}, {wsb[i].Role}, {wsb[i].Title},{wsb[i].SpecialSeaDuty},{wsb[i].RescueStation},{wsb[i].VerificationMuster},{wsb[i].Emergency}, {wsb[i].Access}";
                        sw.WriteLine(line);
                       
                    }

                    const string message = "File is created successfully at F:\\xtractai\\wsu\\wsu_software\\wsu_software\\list.csv";
                    const string caption = "Info";
                    var result = MessageBox.Show(message, caption);
                }


            }
        }


   

        public Person CheckPeople(string tagID)
        {
            List<Person> personInfo = new List<Person>();
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("wsuDB")))
            {

                
                personInfo = connection.Query<Person>("dbo.CheckTagProcedure @tagID",new {tagID =tagID}).ToList();


            }
            if (personInfo.Count == 0)
            {
                const string message = "There is no person associated with this tag. Please enter the details manually";
                const string caption = "Info";
                var result = MessageBox.Show(message, caption);
                return null;
            }
            else
            {
                return personInfo[0];
            }
           
        }


        public List<RoomCount> CheckRoomCount()
        {
            List<RoomCount> roomCount = new List<RoomCount>();

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("wsuDB")))
            {
                roomCount = connection.Query<RoomCount>("dbo.RoomCountProcedure").ToList();
            }
            return roomCount;
        }


        public List<Emergency> startEmergencyMonitor()
        {
            List<Emergency> emgergencyInfo = new List<Emergency>();

           /* AI model should be activated. If the alert detected, send the info based on the camera location to the db and show an alert*/
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("wsuDB")))
            {
                emgergencyInfo = connection.Query<Emergency>("dbo.EmergencyProcedure").ToList();
            }
            return emgergencyInfo;
        }

        

        public List<Person> DisplayTrackMonitor()
        {
            List<Person> personnelInfo = new List<Person>();
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("wsuDB")))
            {
                personnelInfo = connection.Query<Person>("dbo.TrackProcedure").ToList();
            }
            return personnelInfo;
        }


        public void updateTagLocation(string tagID, int TagLocation)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("wsuDB")))
            {
              connection.Execute("dbo.UpdateTagProcedure @tagID, @TagLocation", new { tagID = tagID, TagLocation = TagLocation });
            }
        }

     
    }
}
