using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wsu_software
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Role { get; set; }
        public string Title { get; set; }
        public string SpecialSeaDuty { get; set; }
        public string RescueStation { get; set; }
        public string VerificationMuster { get; set; }
        public string Emergency { get; set; }
        public string Access { get; set; }
        public string RfidTagId { get; set; }
        public bool FacialRecognition { get; set; }
        //public int ModelFaceId { get; set; }
        public string CurrentLocation { get; set; }
        public DateTime LastSeenTime { get; set; }
    }
}
