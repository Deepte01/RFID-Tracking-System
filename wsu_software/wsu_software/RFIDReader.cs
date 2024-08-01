using Impinj.OctaneSdk;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wsu_software
{
    public class RFIDReader
    {
        static ImpinjReader reader = new ImpinjReader();

        //static ImpinjTimestamp timestamp = new ImpinjTimestamp(DateTime.Now);
        static List<string> tagsList = new List<string>();

        static Dictionary<string, int> TagsLocation = new Dictionary<string, int>();
        public string tagInfo
        {
            get {

                try
                {
                 
                    return tagsList[0];
                }
               
                catch (Exception e)
                {
                    // Handle other .NET errors.
                    Console.WriteLine("Exception : {0}", e.Message);
                    return null;
                }
            }
        }




       // After scaning the RFID from antenna 1, enabling all the other antennas.
        public void ResetSettings(double powerDbm, double senseDbm)
        {
            Settings settings = reader.QueryDefaultSettings();
            settings.Report.IncludeAntennaPortNumber = true;
            settings.Report.IncludeFirstSeenTime = true;
            settings.Report.IncludeLastSeenTime = true;
            settings.Antennas.DisableAll();
            settings.Antennas.EnableById(new ushort[] { 1, 2 });
            settings.Antennas.TxPowerInDbm = powerDbm;
            settings.Antennas.RxSensitivityInDbm = senseDbm;
            reader.ApplySettings(settings);
            reader.Start();
        }

        public void read(double powerDbm, double senseDbm)
        {
            var hostname = Helper.ReaderCnnVal("reader");
            try
            {
                reader.Connect(hostname);
                reader.TagsReported += OnTagsReported;

                // Apply the default settings.
                //reader.ApplyDefaultSettings();

                Settings settings = reader.QueryDefaultSettings();
                settings.Report.IncludeAntennaPortNumber = true;
                settings.Report.IncludeFirstSeenTime = true;
                settings.Report.IncludeLastSeenTime = true;
                settings.Antennas.DisableAll();
                settings.Antennas.EnableById(new ushort[] { 1, 2 });

                //settings.Antennas.GetAntenna(1).IsEnabled = true;
                //settings.Antennas.GetAntenna(2).IsEnabled = true;


                // Set all the antennas to the max transmit power and receive sensitivity
               // settings.Antennas.TxPowerMax = true;
                // settings.Antennas.RxSensitivityMax = true;


                // Or set all antennas to a specific value in dBm
                settings.Antennas.TxPowerInDbm = powerDbm;
                settings.Antennas.RxSensitivityInDbm = senseDbm;
                // Or set each antenna individually
                //settings.Antennas.GetAntenna(1).MaxTxPower = true;
                //settings.Antennas.GetAntenna(1).MaxRxSensitivity = true;
                //settings.Antennas.GetAntenna(2).TxPowerInDbm = 30.0;
                //settings.Antennas.GetAntenna(2).RxSensitivityInDbm = -70.0;
                // ...

                reader.ApplySettings(settings);
                // Start reading.
                reader.Start();

                
            }
            catch (OctaneSdkException e)
            {
                // Handle Octane SDK errors.
                Console.WriteLine("Octane SDK exception: {0}", e.Message);
            }
            catch (Exception e)
            {
                // Handle other .NET errors.
                Console.WriteLine("Exception : {0}", e.Message);
            }


        }

        public void stop()
        {
            // Stop reading.
            reader.Stop();

            // Disconnect from the reader.
            reader.Disconnect();

            
        }

        public  void autoPopulate(double powerDbm, double senseDbm)
        {
            var hostname = Helper.ReaderCnnVal("reader");
            try
            {
                tagsList.Clear();
                reader.Connect(hostname);
                reader.TagsReported +=  OnTagsDetected;

                // Apply the default settings.
                //reader.ApplyDefaultSettings();

                Settings settings = reader.QueryDefaultSettings();
                settings.Report.IncludeAntennaPortNumber = true;
                settings.Report.IncludeFirstSeenTime = true;
                settings.Report.IncludeLastSeenTime = true;
                settings.Antennas.DisableAll();
                settings.Antennas.EnableById(new ushort[] {1});

                settings.Antennas.TxPowerInDbm = powerDbm;
                settings.Antennas.RxSensitivityInDbm = senseDbm;


                reader.ApplySettings(settings);
                // Start reading.
                reader.Start();
               
             

                //reader.Stop();

                // Disconnect from the reader.
                // reader.Disconnect();

            }
            catch (OctaneSdkException e)
            {
                // Handle Octane SDK errors.
                Console.WriteLine("Octane SDK exception: {0}", e.Message);
            }
            catch (Exception e)
            {
                // Handle other .NET errors.
                Console.WriteLine("Exception : {0}", e.Message);
            }

        }

        static void OnTagsReported(ImpinjReader sender, TagReport report)
        {
            // This event handler is called asynchronously 
            // when tag reports are available.
            // Loop through each tag in the report 
            // and print the data.
            foreach (Tag tag in report)
            {
                
                string tagID = Convert.ToString(tag.Epc).Replace(" ", "");
                int tagLocation = Convert.ToInt16(tag.AntennaPortNumber);
                DataAccess db = new DataAccess();
                if (!TagsLocation.ContainsKey(tagID))
                {
                    TagsLocation.Add(tagID, tagLocation);
                    db.updateTagLocation(tagID, tagLocation);
                }
                else if (TagsLocation[tagID]!= tagLocation)
                {
                    TagsLocation[tagID] = tagLocation;
                    db.updateTagLocation(tagID, tagLocation);
                    
                }

                Console.WriteLine("EPC : {0} , Antenna : {1}, Last Seen Time : {2}", tag.Epc, tag.AntennaPortNumber,(tag.LastSeenTime));
               
            }
        }

        static void OnTagsDetected(ImpinjReader sender, TagReport report)
        {
            // This event handler is called asynchronously 
            // when tag reports are available.
            // Loop through each tag in the report 
            // and print the data.
            
            foreach (Tag tag in report)
            {
                if (tag.AntennaPortNumber == 1)
                {
                    if (tagsList.Count == 0)
                    {
                        tagsList.Add(Convert.ToString(tag.Epc).Replace(" ", ""));
                    }
                   
                }
            }
        
        
        }
    }
}
