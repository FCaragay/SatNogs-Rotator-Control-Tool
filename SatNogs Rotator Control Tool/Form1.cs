using Renci.SshNet;
using System;
using System.Windows.Forms;
using System.Threading;
using System.Net.Http;

namespace SatNogsRotatorControlTool
{
    public partial class frmMain : Form
    {

        public frmMain()
        {
            InitializeComponent();
           
        }

        private void trkAZ_Scroll(object sender, EventArgs e)
        {
            //Update Value for TrkBar
            lblAZtrkval.Text = trkAZ.Value.ToString("");
        }

        private void trkEL_Scroll(object sender, EventArgs e)
        {
            //Update Value for TrkBar
            lblELtrkval.Text = trkEL.Value.ToString("");
        }

        private void btnSSHConnect_Click(object sender, EventArgs e)
        {
            //define SSH parameters
            string IP = txtIP.Text;
            string User = txtUser.Text;
            string Pass = txtPass.Text;
            
            //Try connecting
            try
            {
                
                using (var sshclient = new SshClient(IP, User, Pass))
                {
                    //try connecting
                    sshclient.Connect();
                    lblConnectState.Text = "Connected";
                    txtUserNotif.Text = "Connected to " + IP;
                    
                    
                    //Update UI with last known position
                    //send command for AZ getpos
                    string cmd = @"rotctl -m 204 -r /dev/ttyACM0 -s9600  w IP3";
                    string AZ = Connect(IP, User, Pass, cmd);
                    //send command for EL getpos
                    string cmd2 = @"rotctl -m 204 -r /dev/ttyACM0 -s9600  w IP4";
                    string EL = Connect(IP, User, Pass, cmd2);
                    //clean AZ EL strings
                    EL = EL.Replace("IP4,", "");
                    AZ = AZ.Replace("IP3,", "");

                    //Write AZEL to console for debug
                    //Console.WriteLine(AZ);
                    //Console.WriteLine(EL);

                    //Add AZEL to log
                    lstLog.Items.Add("AZ " + AZ);
                    lstLog.Items.Add("EL " + EL);

                    //Parse cleaned strings
                    EL = EL.Remove(EL.LastIndexOf("."));
                    AZ = AZ.Remove(AZ.LastIndexOf("."));


                    //Write AZEL to console for debug
                    //Console.WriteLine(AZ);
                    //Console.WriteLine(EL);


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
            //If connecting throws exception, post Not Connected & Unable to connect...
            catch
            {
                lblConnectState.Text = "Not Connected";
                gbControls.Enabled = false;
                txtUserNotif.Text = "Unable to connect, Please try again." + IP;
            }

        }

        private void btnAZELConf_Click(object sender, EventArgs e)
        {
            //set position

            //Define SSH parameters
            string IP = txtIP.Text;
            string User = txtUser.Text;
            string Pass = txtPass.Text;
            //Connect & execute command
            string cmd = "rotctl -m 204 -r /dev/ttyACM0 -s9600  P "+ trkAZ.Value.ToString("") + " " + trkEL.Value.ToString("");
            string lst = Connect(IP, User, Pass, cmd);
            
            //update "Active Position"
            txtAZposition.Text = trkAZ.Value.ToString("");
            txtELposition.Text = trkEL.Value.ToString("");
            
        }

        private void btnGetPos_Click(object sender, EventArgs e)
        {
            //define SSH parameters
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

            //console output for debug
            //Console.WriteLine(EL);
            //Console.WriteLine(AZ);

            //Add AZEL to log
            lstLog.Items.Add("AZ "+AZ);
            lstLog.Items.Add("EL "+EL);
            
            //Parse cleaned strings
            EL = EL.Remove(EL.LastIndexOf("."));
            AZ = AZ.Remove(AZ.LastIndexOf("."));

            //console output for debug
            //Console.WriteLine(EL);
            //Console.WriteLine(AZ);


            //set trackbar value
            trkAZ.Value = int.Parse(AZ);
            trkEL.Value = int.Parse(EL);

            //set trackbar value textbox 
            lblELtrkval.Text = EL;
            lblAZtrkval.Text = AZ;
            
            

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


        //Connect method
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

        private void btnCmdSend_Click(object sender, EventArgs e)
        {
            string IP = txtIP.Text;
            string User = txtUser.Text;
            string Pass = txtPass.Text;
            string cmd = "rotctl -m 204 -r /dev/ttyACM0 -s9600 w " + txtSendCmd.Text;
            string SendCmdResponse = Connect(IP, User, Pass, cmd);

            if (SendCmdResponse == "")
            {
                txtUserNotif.Text = "Command not recognized...";
            }
            else
            {
                txtUserNotif.Text = SendCmdResponse;
                lstLog.Items.Add(SendCmdResponse);
            }
        }
    }
}
