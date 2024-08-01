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
    public partial class MainForm : Form
    {
        RFIDReader rd;
        List<Emergency> emergencyInfo = new List<Emergency>();
        List<Person> personnelInfo = new List<Person>();
        List<RoomCount> roomCountInfo = new List<RoomCount>();
        static System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();
        string drill_type;
        public MainForm()
        {
            InitializeComponent();
            rd = new RFIDReader();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            /*foreach (DataGridViewRow row in dgvTrack.Rows)
            {

               

            }
            myTimer.Stop();
*/
            myTimer.Stop();
            lboxPeopleList.Items.Clear();
            if (radioEmergency.Checked)
            {
                drill_type = "Emergency";
            }
            else if (radioRescueStation.Checked)
            {
                drill_type = "RescueStation";
            }
            else if (radioSSD.Checked)
            {
                drill_type = "SpecialSeaDuty";
            }
            else if (radioVerificationMuster.Checked)
            {
                drill_type = "VerificationMuster";
            }
            else
            {
                MessageBox.Show("Please select any options");
            }

            if (drill_type != null)
            {
                foreach (DataGridViewRow row in dgvTrack.Rows)
                {

                    row.DefaultCellStyle.BackColor = Color.White;
                    if (!Convert.ToString(row.Cells[drill_type].Value).ToLower().Trim().Equals(Convert.ToString(row.Cells["CurrentLocation"].Value).ToLower().Trim()))
                    {
                        row.DefaultCellStyle.BackColor = Color.Red;
                        lboxPeopleList.Items.Add(Convert.ToString(row.Cells["FirstName"].Value).Trim() +" "+ Convert.ToString(row.Cells["LastName"].Value).Trim() + ", " +Convert.ToString(row.Cells["CurrentLocation"].Value).Trim());
                    }


                   /* if (Convert.ToString(row.Cells["CurrentLocation"].Value).Trim() =="Bridge")
                    {
                         bridgeCount += 1;
                    }
                    else if(Convert.ToString(row.Cells["CurrentLocation"].Value).Trim() == "Engine Room")
                    {
                         engRmCount += 1;
                    }
                    else if (Convert.ToString(row.Cells["CurrentLocation"].Value).Trim() == "Ops Room")
                    {
                         opsRmCount += 1;
                    }
                    else if (Convert.ToString(row.Cells["CurrentLocation"].Value).Trim() == "Quarter Deck (QX)")
                    {
                         QXCount += 1;
                    }

                    else if (Convert.ToString(row.Cells["CurrentLocation"].Value).Trim() == "Mess")
                    {
                         messCount += 1;
                    }*/

                }

                roomCountInfo = db.CheckRoomCount();
                lbxRoomCount.DataSource = roomCountInfo;
                lbxRoomCount.DisplayMember = "FullInfo";
            }
        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm(rd);
            await Task.Run(() => registerForm.ShowDialog());

        }

        private void btnPeopleCount_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            tab.SelectedTab = tabPeopleCount;
            roomCountInfo = db.CheckRoomCount();
            lbxRoomCount.DataSource = roomCountInfo;
            lbxRoomCount.DisplayMember = "FullInfo";
        }

        private void btnGenerateWSB_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            db.GenerateWSB();
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
           
            await Task.Run(() => rd.read(Convert.ToDouble(dudPower.Text), Convert.ToDouble(dudSense.Text)));

        }

        private async void btnStop_Click(object sender, EventArgs e)
        {
            await Task.Run(()=>rd.stop());
           
        }

        private void btnStrtMntr_Click(object sender, EventArgs e)
        {
            
            DataAccess db = new DataAccess();
            dgvActivityMonitor.DataSource = emergencyInfo;
            emergencyInfo = db.startEmergencyMonitor();
            dgvActivityMonitor.DataSource = emergencyInfo;
            if (emergencyInfo.Count > 0)
            {
                foreach (DataGridViewRow row in dgvActivityMonitor.Rows)
                {
                   
                    if (Convert.ToDateTime(row.Cells["end_time"].Value) != new DateTime())
                    {
                        row.Cells["Resolved"].Value = true;
                    }
                    if (!Convert.ToBoolean( row.Cells["Resolved"].Value))
                    {
                        row.DefaultCellStyle.BackColor = Color.Red;
                        string message = $"Emergency Alert :{Convert.ToString(row.Cells["Alert"].Value)} at {Convert.ToString(row.Cells["location"].Value)}";
                        const string caption = "Alert";
                        var result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
            }

            dgvActivityMonitor.CellValueChanged += OnCellValueChanged;

        }

        private void OnCellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                if (Convert.ToBoolean(dgvActivityMonitor.Rows[e.RowIndex].Cells["Resolved"].Value))
                {
                    dgvActivityMonitor.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                    dgvActivityMonitor.Rows[e.RowIndex].Cells["end_time"].Value = DateTime.Now;
                    emergencyInfo[e.RowIndex].Resolved = true;
                    emergencyInfo[e.RowIndex].end_time = DateTime.Now;
                }
                else
                {
                    dgvActivityMonitor.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
                    emergencyInfo[e.RowIndex].Resolved = false;
                    emergencyInfo[e.RowIndex].end_time = new DateTime();
                }

            }
         
            dgvActivityMonitor.DataSource = emergencyInfo;
            dgvActivityMonitor.Refresh();
        }

        private  void btnTrack_Click(object sender, EventArgs e)
        {
            tab.SelectedTab = tabTrack;
        
            myTimer.Tick += new EventHandler(TimerEventProcessor);
            myTimer.Interval = 5000;
            myTimer.Start();


        }


        private  void TimerEventProcessor(Object myObject,
                                            EventArgs myEventArgs)
        {
            //myTimer.Stop();

            //// Displays a message box asking whether to continue running the timer.
            //if (MessageBox.Show("Continue running?", "Count is: " + alarmCounter,
            //   MessageBoxButtons.YesNo) == DialogResult.Yes)
            //{
            //    // Restarts the timer and increments the counter.
            //    alarmCounter += 1;
            //    myTimer.Enabled = true;
            //}
            //else
            //{
            //    // Stops the timer.
            //    exitFlag = true;
            //}
            
            dgvTrack.Refresh();
            DataAccess db = new DataAccess();
            //dgvTrack.DataSource = personnelInfo;
            // track();

            personnelInfo = db.DisplayTrackMonitor();
            dgvTrack.DataSource = personnelInfo;
         //   myTimer.Interval = 5000;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
