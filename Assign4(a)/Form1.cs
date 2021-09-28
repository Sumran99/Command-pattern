using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assign4_a_
{
    public partial class Form1 : Form
    {
        
        RemoteControl remoteControl;

        Light light;
        LightOffCommand lightOffCommand;
        LightOnCommand lightOnCommand;

        CeilingFan ceilingFan;
        CeilingFanHighCommand ceilingFanHigh;
        CeilingFanOnCommand ceilingFanOn;
        CeilingFanOffCommand ceilingFanOff;

        TV tv;
        NextChannelCommand nextChannel;
        PreviousChannelCommand previousChannel;
        HighVolumeCommand highVolume;
        LowVolumeCommand lowVolume;
        TvOnCommand tvOn;
        TvOffCommand tvOff;

        Sprinkler sprinkler;
        SprinklerOnCommand sprinklerOn;
        SprinklerOffCommand sprinklerOff;


        Hottub hottub;
        HottubOnCommand hottubOn;
        HottubOffCommand hottubOff;
        HottubHighTemperature hottubHighTemperature;

        Security_Control security_Control;
        SecurityArmedCommand SecurityArmed;
        Security_disarm_Command security_Disarm;


        Thermostat thermostat;
        ThermostatOffCommand thermostatOff;
        ThermoTemperature thermoTemperature;

        Outdoor_Light outdoor_Light;
        OutdoorOnLight outdoorOn;
        OutdoorOffLight outdoorOff;

        GarageDoor garageDoor;
        GateOpenCommand gateOpen;
        GateCloseCommand gateClose;

        int[] slots;
        public Form1()
        {
            InitializeComponent();

            remoteControl = new RemoteControl();

            ceilingFan = new CeilingFan();
            ceilingFanHigh = new CeilingFanHighCommand(ceilingFan);
            ceilingFanOff = new CeilingFanOffCommand(ceilingFan);
            ceilingFanOn = new CeilingFanOnCommand(ceilingFan);

            light = new Light();
            lightOffCommand = new LightOffCommand(light);
            lightOnCommand = new LightOnCommand(light);

            tv = new TV();
            tvOn = new TvOnCommand(tv);
            tvOff = new TvOffCommand(tv);
            highVolume = new HighVolumeCommand(tv);
            lowVolume = new LowVolumeCommand(tv);
            nextChannel = new NextChannelCommand(tv);
            previousChannel = new PreviousChannelCommand(tv);

            sprinkler = new Sprinkler();
            sprinklerOn = new SprinklerOnCommand(sprinkler);
            sprinklerOff = new SprinklerOffCommand(sprinkler);

            hottub = new Hottub();
            hottubOn = new HottubOnCommand(hottub);
            hottubOff = new HottubOffCommand(hottub);
            hottubHighTemperature = new HottubHighTemperature(hottub);


            security_Control = new Security_Control();
            SecurityArmed = new SecurityArmedCommand(security_Control);
            security_Disarm = new Security_disarm_Command(security_Control);

            thermostat = new Thermostat();
            thermostatOff = new ThermostatOffCommand(thermostat);
            thermoTemperature = new ThermoTemperature(thermostat);


            outdoor_Light = new Outdoor_Light();
            outdoorOn = new OutdoorOnLight(outdoor_Light);
            outdoorOff = new OutdoorOffLight(outdoor_Light);

            garageDoor = new GarageDoor();
            gateClose = new GateCloseCommand(garageDoor);
            gateOpen = new GateOpenCommand(garageDoor);

            slots = new int[7];
            for(int i=0; i<7; i++)
            {
                slots[i] = 0;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (cb_addDevice.Text == "TV")
            {
                for (int i = 0; i < 7; i++)
                {
                    if (slots[i] == 0)
                    {
                        slots[i] = 1;
                        remoteControl.setCommand(i, tvOn, tvOff);
                        cb_addDevice.Items.Remove("TV");
                        foreach (PictureBox pb in flowLayoutPanel1.Controls.OfType<PictureBox>())
                        {
                            if (pb.Name.ToString() == "pictureBox" + (i + 1).ToString())
                            {
                                pb.Name = "TV";
                                pb.BackgroundImage = Properties.Resources.tv;
                                pb.BackgroundImageLayout = ImageLayout.Stretch;
                            }

                        }
                        Button ch_n = new Button();
                        Button ch_p = new Button();
                        Button v_up = new Button();
                        Button v_low = new Button();
                        ch_n.Text = "CH+";
                        ch_p.Text = "CH-";
                        v_up.Text = "V+";
                        v_low.Text = "V-";
                        flowLayoutPanel1.Controls.Add(ch_n);
                        flowLayoutPanel1.Controls.Add(ch_p);
                        flowLayoutPanel1.Controls.Add(v_up);
                        flowLayoutPanel1.Controls.Add(v_low);
                        ch_n.Click += new EventHandler(ch_n_Click);
                        ch_p.Click += new EventHandler(ch_p_Click);
                        v_up.Click += new EventHandler(v_up_Click);
                        v_low.Click += new EventHandler(v_low_Click);
                        break;
                    }
                }

            }
            else if (cb_addDevice.Text == "Light")
            {
                for (int i = 0; i < 7; i++)
                {
                    if (slots[i] == 0)
                    {
                        slots[i] = 2;
                        remoteControl.setCommand(i, lightOnCommand, lightOffCommand);
                        cb_addDevice.Items.Remove("Light");
                        foreach (PictureBox pb in flowLayoutPanel1.Controls.OfType<PictureBox>())
                        {
                            if (pb.Name.ToString() == "pictureBox" + (i + 1).ToString())
                            {
                                pb.Name = "Light";
                                pb.BackgroundImage = Properties.Resources.light_logo;
                                pb.BackgroundImageLayout = ImageLayout.Stretch;
                            }

                        }

                        break;
                    }
                }


            }
            else if (cb_addDevice.Text == "Security Control")
            {
                for (int i = 0; i < 7; i++)
                {
                    if (slots[i] == 0)
                    {
                        slots[i] = 3;
                        remoteControl.setCommand(i, SecurityArmed, security_Disarm);
                        cb_addDevice.Items.Remove("SecurityControl");
                        foreach (PictureBox pb in flowLayoutPanel1.Controls.OfType<PictureBox>())
                        {
                            if (pb.Name.ToString() == "pictureBox" + (i + 1).ToString())
                            {
                                pb.Name = "Sprinkler";
                                pb.BackgroundImage = Properties.Resources.SecurityControl;
                                pb.BackgroundImageLayout = ImageLayout.Stretch;
                            }

                        }
                        break;
                    }
                }
            }
            else if (cb_addDevice.Text == "Hottub")
            {
                for (int i = 0; i < 7; i++)
                {
                    if (slots[i] == 0)
                    {
                        slots[i] = 4;
                        remoteControl.setCommand(i, hottubOn, hottubOff);
                        cb_addDevice.Items.Remove("Hottub");
                        foreach (PictureBox pb in flowLayoutPanel1.Controls.OfType<PictureBox>())
                        {
                            if (pb.Name.ToString() == "pictureBox" + (i + 1).ToString())
                            {
                                pb.Name = "Hottub";
                                pb.BackgroundImage = Properties.Resources.Hottub;
                                pb.BackgroundImageLayout = ImageLayout.Stretch;
                            }

                        }
                        Button tub_temp = new Button();
                        tub_temp.Text = "tub Temp";
                        flowLayoutPanel1.Controls.Add(tub_temp);

                        tub_temp.Click += new EventHandler(tubTemp_Click);

                        break;
                    }
                }
            }
            else if (cb_addDevice.Text == "Sprinkler")
            {
                for (int i = 0; i < 7; i++)
                {
                    if (slots[i] == 0)
                    {
                        slots[i] = 5;
                        remoteControl.setCommand(i, sprinklerOn, sprinklerOff);
                        cb_addDevice.Items.Remove("Sprinkler");
                        foreach (PictureBox pb in flowLayoutPanel1.Controls.OfType<PictureBox>())
                        {
                            if (pb.Name.ToString() == "pictureBox" + (i + 1).ToString())
                            {
                                pb.Name = "Sprinkler";
                                pb.BackgroundImage = Properties.Resources.Sprinkler;
                                pb.BackgroundImageLayout = ImageLayout.Stretch;
                            }

                        }
                        break;
                    }
                }
            }
            else if (cb_addDevice.Text == "Ceiling Fan")
            {

                for (int i = 0; i < 7; i++)
                {
                    if (slots[i] == 0)
                    {
                        slots[i] = 6;
                        remoteControl.setCommand(i, ceilingFanOn, ceilingFanOff);
                        cb_addDevice.Items.Remove("Ceiling Fan");
                        foreach (PictureBox pb in flowLayoutPanel1.Controls.OfType<PictureBox>())
                        {
                            if (pb.Name.ToString() == "pictureBox" + (i + 1).ToString())
                            {
                                pb.Name = "ceilingFan";
                                pb.BackgroundImage = Properties.Resources.fan;
                                pb.BackgroundImageLayout = ImageLayout.Stretch;
                            }

                        }
                        Button fan_speed = new Button();
                        fan_speed.Text = "Fan Speed";
                        flowLayoutPanel1.Controls.Add(fan_speed);

                        fan_speed.Click += new EventHandler(fanSpeed_Click);

                        break;
                    }
                }



            }

            else if (cb_addDevice.Text == "Thermostat")
            {
                for (int i = 0; i < 7; i++)
                {
                    if (slots[i] == 0)
                    {
                        slots[i] = 7;
                        remoteControl.setCommand(i, thermoTemperature, thermostatOff);
                        cb_addDevice.Items.Remove("Thermostat");
                        foreach (PictureBox pb in flowLayoutPanel1.Controls.OfType<PictureBox>())
                        {
                            if (pb.Name.ToString() == "pictureBox" + (i + 1).ToString())
                            {
                                pb.Name = "Thermostat";
                                pb.BackgroundImage = Properties.Resources.Thermostat;
                                pb.BackgroundImageLayout = ImageLayout.Stretch;
                            }

                        }
                        break;
                    }
                }
            }
            else if (cb_addDevice.Text == "Garage Door")
            {
                for (int i = 0; i < 7; i++)
                {
                    if (slots[i] == 0)
                    {
                        slots[i] = 8;
                        remoteControl.setCommand(i, gateOpen, gateClose);
                        cb_addDevice.Items.Remove("Garage Door");
                        foreach (PictureBox pb in flowLayoutPanel1.Controls.OfType<PictureBox>())
                        {
                            if (pb.Name.ToString() == "pictureBox" + (i + 1).ToString())
                            {
                                pb.Name = "Door";
                                pb.BackgroundImage = Properties.Resources.Gate;
                                pb.BackgroundImageLayout = ImageLayout.Stretch;
                            }

                        }

                        break;
                    }
                }
            }
            else if (cb_addDevice.Text == "Ceiling Light")
            {

            }
            else if (cb_addDevice.Text == "Outdoor Light")
            {
                for (int i = 0; i < 7; i++)
                {
                    if (slots[i] == 0)
                    {
                        slots[i] = 9;
                        remoteControl.setCommand(i, outdoorOn, outdoorOff);
                        cb_addDevice.Items.Remove("Light");
                        foreach (PictureBox pb in flowLayoutPanel1.Controls.OfType<PictureBox>())
                        {
                            if (pb.Name.ToString() == "pictureBox" + (i + 1).ToString())
                            {
                                pb.Name = "OutdoorLight";
                                pb.BackgroundImage = Properties.Resources.Light;
                                pb.BackgroundImageLayout = ImageLayout.Stretch;
                            }

                        }

                        break;
                    }
                }

            }
        }

        protected void ch_n_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            for(int i=0; i<7; i++)
            {
                if (slots[i] == 1)
                { 
                    remoteControl.setCommand(i, nextChannel, tvOff);
                    remoteControl.onButtonWasPushed(i);
                    lbl_tvChannel.Text = "TV Channel# "+tv.getChannel.ToString();
                }

            }
            

        }
        protected void ch_p_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            for(int i=0; i<7; i++)
            {
                if (slots[i] == 1)
                { 
                    remoteControl.setCommand(i, tvOn, previousChannel);
                    remoteControl.offButtonWasPushed(i);
                    lbl_tvChannel.Text = "TV Channel # " + tv.getChannel.ToString();
                }
            } 

        }
        protected void v_low_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            for(int i=0; i<7; i++)
            {
                if (slots[i] == 1)
                {
                    remoteControl.setCommand(i, tvOn, lowVolume);
                    remoteControl.offButtonWasPushed(i);
                    lbl_tvVolume.Text = "TV volume level: "+tv.getVolume.ToString();
                }
            } 

        }
        protected void v_up_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            for(int i=0; i<7; i++)
            {
                if (slots[i] == 1)
                { 
                    remoteControl.setCommand(i, highVolume, tvOff);
                    remoteControl.onButtonWasPushed(i);
                    lbl_tvVolume.Text = "TV volume level: "+tv.getVolume.ToString();
                }
            } 

        }

        
        protected void tubTemp_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            for (int i = 0; i < 7; i++)
            {
                if (slots[i] == 4)
                {
                    remoteControl.setCommand(i, hottubHighTemperature, hottubOff);
                    remoteControl.onButtonWasPushed(i);
                    lbl_hottubTemp.Text = "Hottub temperature level: " + hottub.getTemperature().ToString();
                }
            }

        }
        protected void fanSpeed_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            for (int i = 0; i < 7; i++)
            {
                if (slots[i] == 6)
                {
                    remoteControl.setCommand(i, ceilingFanHigh, ceilingFanOff);
                    remoteControl.onButtonWasPushed(i);
                    lbl_ceilingFan.Text = "Ceiling fan Speed: " + ceilingFan.getSpeed().ToString();
                }
            }

        }

        

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void device1_on_Click(object sender, EventArgs e)
        {
            remoteControl.onButtonWasPushed(0);
        }

        private void device2_on_Click(object sender, EventArgs e)
        {
            remoteControl.onButtonWasPushed(1);
        }

        private void device3_on_Click(object sender, EventArgs e)
        {
            remoteControl.onButtonWasPushed(2);
        }

        private void device4_on_Click(object sender, EventArgs e)
        {
            remoteControl.onButtonWasPushed(3);
        }

        private void device5_on_Click(object sender, EventArgs e)
        {
            remoteControl.onButtonWasPushed(4);
        }

        private void device6_on_Click(object sender, EventArgs e)
        {
            remoteControl.onButtonWasPushed(5);
        }

        private void device7_on_Click(object sender, EventArgs e)
        {
            remoteControl.onButtonWasPushed(6);
        }

        private void device8_on_Click(object sender, EventArgs e)
        {
            remoteControl.onButtonWasPushed(7);
        }

        private void device9_on_Click(object sender, EventArgs e)
        {
            remoteControl.onButtonWasPushed(8);
        }

        private void device10_on_Click(object sender, EventArgs e)
        {
            remoteControl.onButtonWasPushed(9);
        }

        private void device1_off_Click(object sender, EventArgs e)
        {
            remoteControl.offButtonWasPushed(0);
        }

        private void device2_off_Click(object sender, EventArgs e)
        {
            remoteControl.offButtonWasPushed(1);
        }

        private void device3_off_Click(object sender, EventArgs e)
        {
            remoteControl.offButtonWasPushed(2);
        }

        private void device4_off_Click(object sender, EventArgs e)
        {
            remoteControl.offButtonWasPushed(3);
        }

        private void device5_off_Click(object sender, EventArgs e)
        {
            remoteControl.offButtonWasPushed(4);
        }

        private void device6_off_Click(object sender, EventArgs e)
        {
            remoteControl.offButtonWasPushed(5);
        }

        private void device7_off_Click(object sender, EventArgs e)
        {
            remoteControl.offButtonWasPushed(6);
        }

        private void device8_off_Click(object sender, EventArgs e)
        {
            remoteControl.offButtonWasPushed(7);
        }

        private void device9_off_Click(object sender, EventArgs e)
        {
            remoteControl.offButtonWasPushed(8);
        }

        private void device10_off_Click(object sender, EventArgs e)
        {
            remoteControl.offButtonWasPushed(9);
        }

        private void btn_undo_Click(object sender, EventArgs e)
        {
            remoteControl.undoButtonWasPushed();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void lbl_securityControl_Click(object sender, EventArgs e)
        {

        }
    }
}
