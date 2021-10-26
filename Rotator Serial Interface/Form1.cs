using Renci.SshNet;
using System;
using System.Windows.Forms;
using System.Threading;
using System.Net.Http;

namespace Rotator_Serial_Interface
{
    public partial class frmMain : Form
    {

        public frmMain()
        {
            InitializeComponent();
           
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void trkAZ_Scroll(object sender, EventArgs e)
        {
            lblAZtrkval.Text = trkAZ.Value.ToString("");
        }

        private void trkEL_Scroll(object sender, EventArgs e)
        {
            lblELtrkval.Text = trkEL.Value.ToString("");
        }

        private void btnSSHConnect_Click(object sender, EventArgs e)
        {
            string IP = txtIP.Text;
            string User = txtUser.Text;
            string Pass = txtPass.Text;
            try
            {
                
                using (var sshclient = new SshClient(IP, User, Pass))
                {
                    sshclient.Connect();
                    lblConnectState.Text = "Connected";
                    txtUserNotif.Text = "Connected to " + IP;
                    //send command for AZ getpos
                    string cmd = @"rotctl -m 204 -r /dev/ttyACM0 -s9600  w IP3";
                    string AZ = Connect(IP, User, Pass, cmd);
                    //send command for EL getpos
                    string cmd2 = @"rotctl -m 204 -r /dev/ttyACM0 -s9600  w IP4";
                    string EL = Connect(IP, User, Pass, cmd2);
                    //clean AZ EL strings
                    EL = EL.Replace("IP4,", "");
                    AZ = AZ.Replace("IP3,", "");

                    //Write AZEL to console
                    Console.WriteLine(AZ);
                    Console.WriteLine(EL);

                    //Add AZEL to log
                    lstLog.Items.Add("AZ " + AZ);
                    lstLog.Items.Add("EL " + EL);

                    //Parse cleaned strings
                    EL = EL.Remove(EL.LastIndexOf("."));
                    AZ = AZ.Remove(AZ.LastIndexOf("."));

                    //console output
                    Console.WriteLine(EL);
                    Console.WriteLine(AZ);


                    //set trackbar value
                    trkAZ.Value = int.Parse(AZ);
                    trkEL.Value = int.Parse(EL);

                    //set trackbar value textbox and active position textbox
                    lblELtrkval.Text = EL;
                    lblAZtrkval.Text = AZ;

                    txtAZposition.Text = AZ;
                    txtELposition.Text = EL;

                }
            }
            catch
            {
                lblConnectState.Text = "Not Connected";
                gbControls.Enabled = false;
                txtUserNotif.Text = "Unable to connect, Please try again." + IP;
            }

        }

        private void btnAZELConf_Click(object sender, EventArgs e)
        {
            string IP = txtIP.Text;
            string User = txtUser.Text;
            string Pass = txtPass.Text;
            string cmd = "rotctl -m 204 -r /dev/ttyACM0 -s9600  P "+ trkAZ.Value.ToString("") + " " + trkEL.Value.ToString("");
            string lst = Connect(IP, User, Pass, cmd);
            

            txtAZposition.Text = trkAZ.Value.ToString("");
            txtELposition.Text = trkEL.Value.ToString("");
            
        }

        private void btnGetPos_Click(object sender, EventArgs e)
        {
            string IP = txtIP.Text;
            string User = txtUser.Text;
            string Pass = txtPass.Text;
            //send command for AZ getpos
            string cmd = @"rotctl -m 204 -r /dev/ttyACM0 -s9600  w IP3";
            string AZ = Connect(IP, User, Pass, cmd);
            //send command for EL getpos
            string cmd2 = @"rotctl -m 204 -r /dev/ttyACM0 -s9600  w IP4";
            string EL = Connect(IP, User, Pass, cmd2);
            //clean AZ EL strings
            EL = EL.Replace("IP4,", "");
            AZ = AZ.Replace("IP3,", "");
            
            //Write AZEL to console
            Console.WriteLine(AZ);
            Console.WriteLine(EL);
            
            //Add AZEL to log
            lstLog.Items.Add("AZ "+AZ);
            lstLog.Items.Add("EL "+EL);
            
            //Parse cleaned strings
            EL = EL.Remove(EL.LastIndexOf("."));
            AZ = AZ.Remove(AZ.LastIndexOf("."));

            //console output
            Console.WriteLine(EL);
            Console.WriteLine(AZ);


            //set trackbar value
            trkAZ.Value = int.Parse(AZ);
            trkEL.Value = int.Parse(EL);

            //set trackbar value textbox and active position textbox
            lblELtrkval.Text = EL;
            lblAZtrkval.Text = AZ;
            
            txtAZposition.Text = AZ;
            txtELposition.Text = EL;

        }

        public string Connect(string IP, string User, string Pass, string cmd)
        {
            string out1 = ""; 

            //Establish connection or post error
            try
            {
                using (var sshclient = new SshClient(IP, User, Pass))
                {
                    //Connect to ssh client/update pb/update usernotif/execute command.
                    
                    pbUser.Value = 30;
                    
                    sshclient.Connect();
                    
                    pbUser.Value = 60;
                    
                    lblConnectState.Text = "Connected";
                    Console.WriteLine("Connected to " + IP);
                    
                    pbUser.Value = 90;
                    var cmd1 = sshclient.RunCommand(cmd);
                    out1 = cmd1.Result;
                    pbUser.Value = 100;
                    txtUserNotif.Text = "Command Executed";
                    gbControls.Enabled = true;
                    
                }
            }
            catch
            {
                //unable to connect procedure
                pbUser.Value = 50;
                Console.WriteLine("Connection ERROR 2");
                lblConnectState.Text = "Not Connected";
                pbUser.Value = 100;
                pbUser.Value = 0;
                gbControls.Enabled = false;
                txtUserNotif.Text = "Connection Error" + IP;
                
            }
            //return command output for parsing/data updating
            return (out1);
        }

        public string statuscheck(string IP, string User, string Pass)
        {

            string cmd = "rotctl -m 204 -r /dev/ttyACM0 -s9600  w GS";
            string status = Connect(IP, User, Pass, cmd);
            if (status == "GS1")
            {
                
            }
            else if (status == "GS2")
            {
               
            }
            return (status);
        }
            

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
            if(lblConnectStatus.Text == "Connected")
            {
                string IP = txtIP.Text;
                string User = txtUser.Text;
                string Pass = txtPass.Text;
                string cmd = @"rotctl -m 204 -r /dev/ttyACM0 -s9600  w IP3";
                string AZ = Connect(IP, User, Pass, cmd);
                string cmd2 = @"rotctl -m 204 -r /dev/ttyACM0 -s9600  w IP4";
                string EL = Connect(IP, User, Pass, cmd2);
                EL = EL.Replace("IP4,", "");
                AZ = AZ.Replace("IP3,", "");
                Console.WriteLine(AZ);
                Console.WriteLine(EL);



                double AZd = double.Parse(AZ);
                double ELd = double.Parse(EL);
                EL = EL.Replace(".00", "");
                AZ = AZ.Replace(".00", "");
                Console.WriteLine(EL);
                Console.WriteLine(AZ);


                try
                {


                    int ELi = int.Parse(EL);
                    int AZi = int.Parse(AZ);
                    trkAZ.Value = AZi;
                    trkEL.Value = ELi;
                }
                catch
                {

                }

                lblELtrkval.Text = trkEL.Value.ToString("");
                lblAZtrkval.Text = trkAZ.Value.ToString("");
                txtAZposition.Text = AZ;
                txtELposition.Text = EL;
            }
            */
            
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            string IP = txtIP.Text;
            string User = txtUser.Text;
            string Pass = txtPass.Text;
            using (var sshclient = new SshClient(IP, User, Pass))
            {
                //Connect to ssh client/update pb/update usernotif/execute command.

                

                sshclient.Disconnect();

                

                lblConnectState.Text = "Not Connected";
               

            
                
                txtUserNotif.Text = "Disconnected";
                gbControls.Enabled = false;

            }
        }

        private void btnRotatorStatus_Click(object sender, EventArgs e)
        {
            string IP = txtIP.Text;
            string User = txtUser.Text;
            string Pass = txtPass.Text;
            string cmd = "rotctl -m 204 -r /dev/ttyACM0 -s9600 w GS";
            string rotatorstatus = Connect(IP, User, Pass, cmd);
            bool gs4 = rotatorstatus.Contains("GS4");
            bool gs1 = rotatorstatus.Contains("GS1");
            if (gs4 == true)
            {
                txtUserNotif.Text = "Status: Active";
                lstLog.Items.Add("Status: Active");
            }
            else if (gs1 == true)
            {
                txtUserNotif.Text = "Status: Parked";
                lstLog.Items.Add("Status: Parked");
            }
           string test = apiget(User);
        }

        private void btnFMVer_Click(object sender, EventArgs e)
        {
            string IP = txtIP.Text;
            string User = txtUser.Text;
            string Pass = txtPass.Text;
            string cmd = "rotctl -m 204 -r /dev/ttyACM0 -s9600 w VER";
            string VER = Connect(IP, User, Pass, cmd);
            txtUserNotif.Text = VER;
            lstLog.Items.Add(VER);
        }

        private void btnSTOP_MouseHover(object sender, EventArgs e)
        {
            tooltipESTOP.Show("Pressing E-STOP resets rotator \n and sets AZ 0.00 EL 0.00",btnSTOP);
        }

        private void btnSTOP_Click(object sender, EventArgs e)
        {
            string IP = txtIP.Text;
            string User = txtUser.Text;
            string Pass = txtPass.Text;
            string cmdrb = "rotctl -m 204 -r /dev/ttyACM0 -s9600 w RB";
            string result = Connect(IP, User, Pass, cmdrb);
            gbControls.Enabled = false;
            Thread.Sleep(5000);
            //send command for AZ getpos
            string cmd = @"rotctl -m 204 -r /dev/ttyACM0 -s9600  w IP3";
            string AZ = Connect(IP, User, Pass, cmd);
            //send command for EL getpos
            string cmd2 = @"rotctl -m 204 -r /dev/ttyACM0 -s9600  w IP4";
            string EL = Connect(IP, User, Pass, cmd2);
            //clean AZ EL strings
            EL = EL.Replace("IP4,", "");
            AZ = AZ.Replace("IP3,", "");

            //Write AZEL to console
            Console.WriteLine(AZ);
            Console.WriteLine(EL);

            //Add AZEL to log
            lstLog.Items.Add("AZ " + AZ);
            lstLog.Items.Add("EL " + EL);

            //Parse cleaned strings
            EL = EL.Remove(EL.LastIndexOf("."));
            AZ = AZ.Remove(AZ.LastIndexOf("."));

            //console output
            Console.WriteLine(EL);
            Console.WriteLine(AZ);


            //set trackbar value
            trkAZ.Value = int.Parse(AZ);
            trkEL.Value = int.Parse(EL);

            //set trackbar value textbox and active position textbox
            lblELtrkval.Text = EL;
            lblAZtrkval.Text = AZ;

            txtAZposition.Text = AZ;
            txtELposition.Text = EL;
            gbControls.Enabled = true;
        }

        public string apiget(string get)
        {
            var client = new HttpClient();
            var apiresult = client.GetStringAsync("https://api.n2yo.com/rest/v1/satellite/tle/25544&apiKey=RLD2F7-3M5J5L-UAKJVG-4SO7");



            Console.WriteLine(apiresult);





            string strapi = "test";



            return (strapi);

        }
    }
}
