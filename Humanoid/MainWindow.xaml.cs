//ROBOT CONTROLLER PROGRAM
//Author: Tuan Anh Le
//Supervisor: Prof. Tan Tien Nguyen
//Mentor: Van Tan Nhat Vo - Huu Thien Nguyen

//Contact: Tuan Anh Le
//VNUHCM - UIT
//Department of Computer Engineering
//Email: anhlt.cse@gmail.com
//Phone: (+84) 944 522 665

using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;

using System.IO.Ports;
using System.Threading;
using System.IO;
using System.Media;
using Microsoft.Win32;
using System.Diagnostics;

namespace Humanoid
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private struct ID
        {
            public int ServoID;
            public int sliposition;
            public int position;
        }

        ID Servo1, Servo2, Servo3, Servo4, Servo5, Servo6, Servo7, Servo8, Servo9, Servo10;
        ID Servo11, Servo12, Servo13, Servo14, Servo15, Servo16, Servo17, Servo18, Servo19, Servo20;

        private const byte HEADER = 0x55;

        private const int Number_of_Servo = 20; 

        //Servo order: Set order for each servo to make writebyte easier.
        private ID[] ServoOrder = new ID[Number_of_Servo]; //Ordering selected servoes in order
        public static int[] GridOrder = new int[Number_of_Servo]; //Store every Grid order

        public static int iServoControlled = 0; //The number of Servoes ar under controlled

        public int ActionGroup = 0;
        public int Index = -1;
        public byte[][] MovingData = new byte[400][]; //Number of Action Index
        public int[] IDS; //

        //CheckBox[] checkboxlist;

        //Serial Port
        public SerialPort serialPort = new SerialPort();
        
        //Display Index, Time, Action on Listview
        public List <ActionIndex> myIndex { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            //Get Port name for Connect Button
            string[] ports = SerialPort.GetPortNames();

            foreach (string port in ports)
            {
                cbbComPort.Items.Add(port);
            }
            if (cbbComPort.Items.Count != 0)
                cbbComPort.SelectedIndex = 0;
            else
            {
                //    SoundPlayer SPlayer = new SoundPlayer(@"D:\Base 1\Summer 2018\Servo Control\01.wav");
                //      SPlayer.Play();
                System.IO.Stream str = Properties.Resources._01;
                SoundPlayer SPlayer = new SoundPlayer(str);
                SPlayer.Play();
                MessageBox.Show("No COM port found!", "Warning", MessageBoxButton.OK);

                // System.Windows.Application.Current.Shutdown();
            }

            //Hide all Grid
            grid1.Visibility = Visibility.Hidden;
            grid2.Visibility = Visibility.Hidden;
            grid3.Visibility = Visibility.Hidden;
            grid4.Visibility = Visibility.Hidden;
            grid5.Visibility = Visibility.Hidden;
            grid6.Visibility = Visibility.Hidden;
            grid7.Visibility = Visibility.Hidden;
            grid8.Visibility = Visibility.Hidden;
            grid9.Visibility = Visibility.Hidden;
            grid10.Visibility = Visibility.Hidden;
            grid11.Visibility = Visibility.Hidden;
            grid12.Visibility = Visibility.Hidden;
            grid13.Visibility = Visibility.Hidden;
            grid14.Visibility = Visibility.Hidden;
            grid15.Visibility = Visibility.Hidden;
            grid16.Visibility = Visibility.Hidden;
            grid17.Visibility = Visibility.Hidden;
            grid18.Visibility = Visibility.Hidden;
            grid19.Visibility = Visibility.Hidden;
            grid20.Visibility = Visibility.Hidden;

            myIndex = new List<ActionIndex>();
        }
        
        private void btnConnect_Click(object sender, RoutedEventArgs e)
        {
            if (!serialPort.IsOpen)
            {
                serialPort.PortName = cbbComPort.SelectedItem.ToString();
                serialPort.BaudRate = 9600;
                serialPort.Parity = Parity.None;
                serialPort.StopBits = StopBits.One;
                serialPort.DataBits = 8;
                serialPort.Handshake = Handshake.None;
                serialPort.RtsEnable = true;
                serialPort.Open();

                serialPort.DiscardInBuffer();
                serialPort.DiscardOutBuffer();
            }

            btnConnect.Background = Brushes.Red;
            btnConnect.Content = "Connected";
        }
        
        private void chbID1_Checked(object sender, RoutedEventArgs e)
        {
            iServoControlled++;
            GridOrder[0] = 1;
            grid1.Visibility = Visibility.Visible;
        }

        private void chbID1_Unchecked(object sender, RoutedEventArgs e)
        {
            iServoControlled--;
            GridOrder[0] = 0;
            grid1.Visibility = Visibility.Hidden;
            chbSelectAll.IsChecked = false;
        }

        private void chbID2_Checked(object sender, RoutedEventArgs e)
        {
            iServoControlled++;
            GridOrder[1] = 2;
            grid2.Visibility = Visibility.Visible;
        }

        private void chbID2_Unchecked(object sender, RoutedEventArgs e)
        {
            iServoControlled--;
            GridOrder[1] = 0;
            grid2.Visibility = Visibility.Hidden;
            chbSelectAll.IsChecked = false;
        }

        private void chbID3_Checked(object sender, RoutedEventArgs e)
        {
            iServoControlled++;
            GridOrder[2] = 3;
            grid3.Visibility = Visibility.Visible;
        }

        private void chbID3_Unchecked(object sender, RoutedEventArgs e)
        {
            iServoControlled--;
            GridOrder[2] = 0;
            grid3.Visibility = Visibility.Hidden;
            chbSelectAll.IsChecked = false;
        }

        private void chbID4_Checked(object sender, RoutedEventArgs e)
        {
            iServoControlled++;
            GridOrder[3] = 4;
            grid4.Visibility = Visibility.Visible;
        }

        private void chbID4_Unchecked(object sender, RoutedEventArgs e)
        {
            iServoControlled--;
            GridOrder[3] = 0;
            grid4.Visibility = Visibility.Hidden;
            chbSelectAll.IsChecked = false;
        }
        private void chbID5_Checked(object sender, RoutedEventArgs e)
        {
            iServoControlled++;
            GridOrder[4] = 5;
            grid5.Visibility = Visibility.Visible;
        }

        private void chbID5_Unchecked(object sender, RoutedEventArgs e)
        {
            iServoControlled--;
            GridOrder[4] = 0;
            grid5.Visibility = Visibility.Hidden;
            chbSelectAll.IsChecked = false;
        }

        private void chbID6_Checked(object sender, RoutedEventArgs e)
        {
            iServoControlled++;
            GridOrder[5] = 6;
            grid6.Visibility = Visibility.Visible;
        }

        private void chbID6_Unchecked(object sender, RoutedEventArgs e)
        {
            iServoControlled--;
            GridOrder[5] = 0;
            grid6.Visibility = Visibility.Hidden;
            chbSelectAll.IsChecked = false;
        }

        private void chbID7_Checked(object sender, RoutedEventArgs e)
        {
            iServoControlled++;
            GridOrder[6] = 7;
            grid7.Visibility = Visibility.Visible;
        }

        private void chbID7_Unchecked(object sender, RoutedEventArgs e)
        {
            iServoControlled--;
            GridOrder[6] = 0;
            grid7.Visibility = Visibility.Hidden;
            chbSelectAll.IsChecked = false;
        }

        private void chbID8_Checked(object sender, RoutedEventArgs e)
        {
            iServoControlled++;
            GridOrder[7] = 8;
            grid8.Visibility = Visibility.Visible;
        }

        private void chbID8_Unchecked(object sender, RoutedEventArgs e)
        {
            iServoControlled--;
            GridOrder[7] = 0;
            grid8.Visibility = Visibility.Hidden;
            chbSelectAll.IsChecked = false;
        }

        private void chbID9_Checked(object sender, RoutedEventArgs e)
        {
            iServoControlled++;
            GridOrder[8] = 9;
            grid9.Visibility = Visibility.Visible;
        }

        private void chbID9_Unchecked(object sender, RoutedEventArgs e)
        {
            iServoControlled--;
            GridOrder[8] = 0;
            grid9.Visibility = Visibility.Hidden;
            chbSelectAll.IsChecked = false;
        }

        private void chbID10_Checked(object sender, RoutedEventArgs e)
        {
            iServoControlled++;
            GridOrder[9] = 10;
            grid10.Visibility = Visibility.Visible;
        }

        private void chbID10_Unchecked(object sender, RoutedEventArgs e)
        {
            iServoControlled--;
            GridOrder[9] = 0;
            grid10.Visibility = Visibility.Hidden;
            chbSelectAll.IsChecked = false;
        }
        private void chbID11_Checked(object sender, RoutedEventArgs e)
        {
            iServoControlled++;
            GridOrder[10] = 11;
            grid11.Visibility = Visibility.Visible;
        }

        private void chbID11_Unchecked(object sender, RoutedEventArgs e)
        {
            iServoControlled--;
            GridOrder[10] = 0;
            grid11.Visibility = Visibility.Hidden;
            chbSelectAll.IsChecked = false;
        }

        private void chbID12_Checked(object sender, RoutedEventArgs e)
        {
            iServoControlled++;
            GridOrder[11] = 12;
            grid12.Visibility = Visibility.Visible;
        }

        private void chbID12_Unchecked(object sender, RoutedEventArgs e)
        {
            iServoControlled--;
            GridOrder[11] = 0;
            grid12.Visibility = Visibility.Hidden;
            chbSelectAll.IsChecked = false;
        }
        private void chbID13_Checked(object sender, RoutedEventArgs e)
        {
            iServoControlled++;
            GridOrder[12] = 13;
            grid13.Visibility = Visibility.Visible;
        }

        private void chbID13_Unchecked(object sender, RoutedEventArgs e)
        {
            iServoControlled--;
            GridOrder[12] = 0;
            grid13.Visibility = Visibility.Hidden;
            chbSelectAll.IsChecked = false;
        }

        private void chbID14_Checked(object sender, RoutedEventArgs e)
        {
            iServoControlled++;
            GridOrder[13] = 14;
            grid14.Visibility = Visibility.Visible;
        }

        private void chbID14_Unchecked(object sender, RoutedEventArgs e)
        {
            iServoControlled--;
            GridOrder[13] = 0;
            grid14.Visibility = Visibility.Hidden;
            chbSelectAll.IsChecked = false;
        }
        private void chbID15_Checked(object sender, RoutedEventArgs e)
        {
            iServoControlled++;
            GridOrder[14] = 15;
            grid15.Visibility = Visibility.Visible;
        }

        private void chbID15_Unchecked(object sender, RoutedEventArgs e)
        {
            iServoControlled--;
            GridOrder[14] = 0;
            grid15.Visibility = Visibility.Hidden;
            chbSelectAll.IsChecked = false;
        }

        private void chbID16_Checked(object sender, RoutedEventArgs e)
        {
            iServoControlled++;
            GridOrder[15] = 16;
            grid16.Visibility = Visibility.Visible;
        }

        private void chbID16_Unchecked(object sender, RoutedEventArgs e)
        {
            iServoControlled--;
            GridOrder[15] = 0;
            grid16.Visibility = Visibility.Hidden;
            chbSelectAll.IsChecked = false;
        }

        private void chbID17_Checked(object sender, RoutedEventArgs e)
        {
            iServoControlled++;
            GridOrder[16] = 17;
            grid17.Visibility = Visibility.Visible;
        }

        private void chbID17_Unchecked(object sender, RoutedEventArgs e)
        {
            iServoControlled--;
            GridOrder[16] = 0;
            grid17.Visibility = Visibility.Hidden;
            chbSelectAll.IsChecked = false;
        }

        private void chbID18_Checked(object sender, RoutedEventArgs e)
        {
            iServoControlled++;
            GridOrder[17] = 18;
            grid18.Visibility = Visibility.Visible;
        }

        private void chbID18_Unchecked(object sender, RoutedEventArgs e)
        {
            iServoControlled--;
            GridOrder[17] = 0;
            grid18.Visibility = Visibility.Hidden;
            chbSelectAll.IsChecked = false;
        }

        private void chbID19_Checked(object sender, RoutedEventArgs e)
        {
            iServoControlled++;
            GridOrder[18] = 19;
            grid19.Visibility = Visibility.Visible;
        }

        private void chbID19_Unchecked(object sender, RoutedEventArgs e)
        {
            iServoControlled--;
            GridOrder[18] = 0;
            grid19.Visibility = Visibility.Hidden;
            chbSelectAll.IsChecked = false;
        }

        private void chbID20_Checked(object sender, RoutedEventArgs e)
        {
            iServoControlled++;
            GridOrder[19] = 20;
            grid20.Visibility = Visibility.Visible;
        }
        private void chbID20_Unchecked(object sender, RoutedEventArgs e)
        {
            iServoControlled--;
            GridOrder[19] = 0;
            grid20.Visibility = Visibility.Hidden;
            chbSelectAll.IsChecked = false;
        }

        private void chbSelectAll_Click(object sender, RoutedEventArgs e)
        {
            IDS = new int [] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20};
            
            if (chbSelectAll.IsChecked == true)
                for (int i = 0; i < 20; i++)
                    ReloadGridID(i, true);
            else
                for (int i = 0; i < 20; i++)
                    ReloadGridID(i, false);
        }

        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (serialPort.IsOpen)
                {
                    CMD_ACTION_STOP();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Serial Port is not opened.", "Warning", MessageBoxButton.OKCancel);
            }
        }

        //return the largest Servo ID.
        public int GetMaxValue()
        {
            int MaxVal = 0;
            for (int i = 0; i < Number_of_Servo; i++)
            {
                if (GridOrder[i] >= 1 && GridOrder[i] <= 20)
                {
                    MaxVal = GridOrder[i];
                }
            }

            return MaxVal;
        }

        //Arrange servoes that were checked.
        public void ArrangeServoOrder(ref int[] ID) //Lưu thông các Servo được chọn ở CheckBox
        {
            ID = new int[iServoControlled];

            int MaxVal = GetMaxValue();
            int i = 0, e = 0;
            while (i < iServoControlled && e < MaxVal)
            {
                if (GridOrder[e] >= 1 && GridOrder[e] <= 20)
                {
                    ID[i] = e + 1;
                    i++;
                }
                e++;
            }
        }

        //pass the reference of Lower and Higher than 8 bits of degree value
        public void ConvertToByte(ref byte Lower8Bits, ref byte Higher8Bits, int Value)
        {
            var temp = Value;
            long iLower = temp % ((long)(Math.Pow(16, 2)));
            long iHigher = (temp - iLower) / (long)(Math.Pow(16, 2));

            Higher8Bits = Convert.ToByte(iHigher);
            Lower8Bits = Convert.ToByte(iLower);
        }

        public int ConvertToInt (byte Lower8Bits, byte Higher8Bits)
        {
            int d2 = (int)Higher8Bits;
            int d1 = Lower8Bits / 16;
            int d0 = Lower8Bits % 16;
            //return (d2 * (int)Math.Pow(16, 2) + d1 * 16 + d0);
            int t = (d2 * (int)Math.Pow(16, 2) + d1 * 16 + d0);
            return t;
        }

        //Convert from hex to decimal to return battery voltage value
        public int ConvertingToGetBattery(byte Higher8Bits, byte Lower8Bits) //pass by preference
        {
            int i5 = Convert.ToInt32(Higher8Bits);
            int i4 = Convert.ToInt32(Lower8Bits);

            return i5 * ((int)Math.Pow(16, 2)) + i4;
        }

        //Read bytes Method.
        //While reading, if "serialPort.Read" command is sent suceessful,
        //inBytesReceived would increase 
        public void ReadBytes(ref byte[] rBytes)
        {
            try
            {
                //int inBytesReceived = 0;
                int byteCount = rBytes.Length;
                if (byteCount > 0)
                {
                    //serialPort.DiscardOutBuffer();

                    serialPort.Read(rBytes, 0, byteCount);

                }
                serialPort.DiscardOutBuffer();
                //serialPort.Dispose();
            }
            catch
            {
                MessageBox.Show("Read bytes error.", "Error", MessageBoxButton.OKCancel);
            }
        }

        //Moving slider when slider value changed
        public void MoveSlider(int ID, int sliValue)
        {
            try
            {
                if (serialPort.IsOpen)
                {
                    byte[] SliderMoving = new byte[10];

                    SliderMoving[0] = SliderMoving[1] = HEADER;
                    SliderMoving[2] = 0x08; //Data length
                    SliderMoving[3] = 0x03; //Command move
                    SliderMoving[4] = 0x01; //Number of servo
                    //SliderMoving[5] = 0x88; //Lower 8 bits of time
                    //SliderMoving[6] = 0x13; //Higher 8 bits of time
                    int ActionTime = Convert.ToInt32(txbActionTime.Text);
                    ConvertToByte(ref SliderMoving[5], ref SliderMoving[6], ActionTime);
                    SliderMoving[7] = Convert.ToByte(ID); //Servo ID

                    ConvertToByte(ref SliderMoving[8], ref SliderMoving[9], sliValue);
                    serialPort.Write(SliderMoving, 0, 10);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Check your connection to the device.", "Error", MessageBoxButton.OKCancel);
            }
        }

        //Using button Save calling this method to put sending data into a jagged array
        public void SAVE_SERVO_MOVE(int[] ID, int ActionTime, int[] ServoAngle) //
        {
            try
            {
                int DataLength = iServoControlled * 3 + 5;
                MovingData[Index] = new byte[DataLength + 2];
                //Header
                MovingData[Index][0] = HEADER;
                MovingData[Index][1] = HEADER;

                MovingData[Index][2] = (byte)DataLength;
                //Command
                MovingData[Index][3] = 0x03;

                //Parameters
                MovingData[Index][4] = (byte)iServoControlled; //Number of servo controlled;

                ConvertToByte(ref MovingData[Index][5], ref MovingData[Index][6], ActionTime);

                int j = 0;
                for (int i = 7; i < DataLength; i = i + 3)
                {
                    //update slider position;
                    MovingData[Index][i] = (byte)ID[j];
                    ConvertToByte(ref MovingData[Index][i + 1], ref MovingData[Index][i + 2], ServoAngle[j]);
                    j++;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Check your connection to the device.", "Error", MessageBoxButton.OKCancel);
            }
        }

        public void UPDATE_SERVO_MOVE(int[] ID, int ActionTime, int[] ServoAngle, int Index) //
        {
            try
            {
                if (serialPort.IsOpen) //
                {
                    int DataLength = iServoControlled * 3 + 5;
                    MovingData[Index] = new byte[DataLength + 2];
                    //Header
                    MovingData[Index][0] = HEADER;
                    MovingData[Index][1] = HEADER;

                    MovingData[Index][2] = (byte)DataLength;
                    //Command
                    MovingData[Index][3] = 0x03;

                    //Parameters
                    MovingData[Index][4] = (byte)iServoControlled; //Number of servo controlled;

                    ConvertToByte(ref MovingData[Index][5], ref MovingData[Index][6], ActionTime);

                    int j = 0;
                    for (int i = 7; i < DataLength; i = i + 3)
                    {
                        //update slider position;
                        MovingData[Index][i] = (byte)ID[j];
                        ConvertToByte(ref MovingData[Index][i + 1], ref MovingData[Index][i + 2], ServoAngle[j]);
                        j++;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Check your connection to the device.", "Error", MessageBoxButton.OKCancel);
            }

        }

        //public void CMD_SERVO_MOVE(int ActionTime, int[] ID, int[] ServoAngle)
        //{
        //    try
        //    {
        //        if (serialPort.IsOpen)
        //        {
        //            int DataLength = iServoControlled * 3 + 5;
        //            byte[] SERVO_MOVE = new byte[DataLength + 2];
        //            //Header
        //            SERVO_MOVE[0] = SERVO_MOVE[1] = HEADER;

        //            //Length
        //            //SERVO_MOVE[2] = (byte)datalength;
        //            SERVO_MOVE[2] = (byte)DataLength;
        //            //Command
        //            SERVO_MOVE[3] = 0x03;

        //            //Parameters
        //            SERVO_MOVE[4] = (byte)iServoControlled; //Number of servo controlled;

        //            ConvertToByte(ref SERVO_MOVE[5], ref SERVO_MOVE[6], ActionTime);

        //            int j = 0;
        //            for (int i = 7; i < DataLength; i = i + 3)
        //            {
        //                //update slider position;
        //                SERVO_MOVE[i] = (byte)ID[j];
        //                ConvertToByte(ref SERVO_MOVE[i + 1], ref SERVO_MOVE[i + 2], ServoAngle[j]);
        //                j++;
        //            }
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        MessageBox.Show("Check your connection to the device.", "Error", MessageBoxButton.OKCancel);
        //    }

        //}

        //Button Get Battery
        public int CMD_GET_BATTERY()
        {
            try
            {
                byte LENGTH = 0x02, COMMAND = 0x0F;
                byte[] sBytes = new byte[4] { HEADER, HEADER, LENGTH, COMMAND };
                byte[] rBytes = new byte[6];

                serialPort.Write(sBytes, 0, 4);
                Thread.Sleep(100); //Pause timeline for 20ms.
                                  //Stopwatch stopwatch = Stopwatch.StartNew();

                ReadBytes(ref rBytes);
                //stopwatch.Stop();
                //MessageBox.Show(stopwatch.ElapsedMilliseconds.ToString(), "Execution time");

                int Battery_Voltage = (ConvertingToGetBattery(rBytes[5], rBytes[4]));

                return Battery_Voltage;
            }
            catch (Exception)
            {
                MessageBox.Show("Check your connection to the device.", "Error", MessageBoxButton.OKCancel);
            }
            return 0;
        }

        //if adjusting all of the action group, ActionGroup is 0xFF.
        public void CMD_ACTION_SPEED(int ActionGroup, int SpeedUpPer)
        {
            try
            {
                if (serialPort.IsOpen)
                {
                    byte[] sBytes = new byte[7];
                    sBytes[0] = sBytes[1] = HEADER;
                    sBytes[2] = 0x05;
                    sBytes[3] = 0x0B;

                    sBytes[4] = (byte)ActionGroup;
                    ConvertToByte(ref sBytes[5], ref sBytes[6], SpeedUpPer);

                    serialPort.Write(sBytes, 0, 7);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Check your connection to the device.", "Error", MessageBoxButton.OKCancel);
            }
        }

        public void CMD_ACTION_STOP() //
        {
            try
            {
                if (serialPort.IsOpen)
                {
                    byte[] sBytes = new byte[4];
                    sBytes[0] = sBytes[1] = HEADER;
                    sBytes[2] = 0x05;
                    sBytes[3] = 0x07;

                    serialPort.Write(sBytes, 0, 4);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Check your connection to the device.", "Error", MessageBoxButton.OKCancel);
            }
        }

        private void sliPosition1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Servo1.ServoID = 1;
            Servo1.sliposition = Servo1.position = (int)sliPosition1.Value;

            ServoOrder[0] = Servo1;

            MoveSlider(1, Servo1.sliposition);
        }

        private void sliPosition2_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Servo2.ServoID = 2;
            Servo2.sliposition = Servo2.position = (int)sliPosition2.Value;
            ServoOrder[1] = Servo2;

            MoveSlider(2, Servo2.sliposition);
        }

        private void sliPosition3_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Servo3.ServoID = 3;
            Servo3.sliposition = Servo3.position = (int)sliPosition3.Value;
            ServoOrder[2] = Servo3;

            MoveSlider(3, Servo3.sliposition);
        }

        private void sliPosition4_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Servo4.ServoID = 4;
            Servo4.sliposition = Servo4.position = (int)sliPosition4.Value;
            ServoOrder[3] = Servo4;

            MoveSlider(4, Servo4.sliposition);
        }

        private void sliPosition5_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Servo5.ServoID = 5;
            Servo5.sliposition = Servo5.position = (int)sliPosition5.Value;
            ServoOrder[4] = Servo5;

            MoveSlider(5, Servo5.sliposition);
        }

        private void sliPosition6_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Servo6.ServoID = 6;
            Servo6.sliposition = Servo6.position = (int)sliPosition6.Value;
            ServoOrder[5] = Servo6;

            MoveSlider(6, Servo6.sliposition);
        }

        private void sliPosition7_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Servo7.ServoID = 7;
            Servo7.sliposition = Servo7.position = (int)sliPosition7.Value;
            ServoOrder[6] = Servo7;

            MoveSlider(7, Servo7.sliposition);
        }

        private void sliPosition8_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Servo8.ServoID = 8;
            Servo8.sliposition = Servo8.position = (int)sliPosition8.Value;
            ServoOrder[7] = Servo8;

            MoveSlider(8, Servo8.sliposition);
        }

        private void sliPosition9_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Servo9.ServoID = 9;
            Servo9.sliposition = Servo9.position = (int)sliPosition9.Value;
            ServoOrder[8] = Servo9;

            MoveSlider(9, Servo9.sliposition);
        }

        private void sliPosition10_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Servo10.ServoID = 10;
            Servo10.sliposition = Servo10.position = (int)sliPosition10.Value;
            ServoOrder[9] = Servo10;

            MoveSlider(10, Servo10.sliposition);
        }

        private void sliPosition11_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Servo11.ServoID = 11;
            Servo11.sliposition = Servo11.position = (int)sliPosition11.Value;
            ServoOrder[10] = Servo11;

            MoveSlider(11, Servo11.sliposition);
        }

        private void sliPosition12_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Servo12.ServoID = 12;
            Servo12.sliposition = Servo12.position = (int)sliPosition12.Value;
            ServoOrder[11] = Servo12;

            MoveSlider(12, Servo12.sliposition);
        }

        private void sliPosition13_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Servo13.ServoID = 13;
            Servo13.sliposition = Servo13.position = (int)sliPosition13.Value;
            ServoOrder[12] = Servo13;

            MoveSlider(13, Servo13.sliposition);
        }

        private void sliPosition14_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Servo14.ServoID = 14;
            Servo14.sliposition = Servo14.position = (int)sliPosition14.Value;
            ServoOrder[13] = Servo14;

            MoveSlider(14, Servo14.sliposition);
        }

        private void sliPosition15_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Servo15.ServoID = 15;
            Servo15.sliposition = Servo15.position = (int)sliPosition15.Value;
            ServoOrder[14] = Servo15;

            MoveSlider(15, Servo15.sliposition);
        }

        private void sliPosition16_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Servo16.ServoID = 16;
            Servo16.sliposition = Servo16.position = (int)sliPosition16.Value;
            ServoOrder[15] = Servo16;

            MoveSlider(16, Servo16.sliposition);
        }

        private void sliPosition17_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Servo17.ServoID = 17;
            Servo17.sliposition = Servo17.position = (int)sliPosition17.Value;
            ServoOrder[16] = Servo17;

            MoveSlider(17, Servo17.sliposition);
        }

        private void sliPosition18_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Servo18.ServoID = 18;
            Servo18.sliposition = Servo18.position = (int)sliPosition18.Value;
            ServoOrder[17] = Servo18;

            MoveSlider(18, Servo18.sliposition);
        }

        private void sliPosition19_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Servo19.ServoID = 19;
            Servo19.sliposition = Servo19.position = (int)sliPosition19.Value;
            ServoOrder[18] = Servo19;

            MoveSlider(19, Servo19.sliposition);
        }

        private void sliPosition20_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Servo20.ServoID = 20;
            Servo20.sliposition = Servo20.position = (int)sliPosition20.Value;
            ServoOrder[19] = Servo20;

            MoveSlider(20, Servo20.sliposition);
        }

        public void Open ()
        {
            int[] Angle;
            for (int i = 0; i < Index + 1; i++)
            {
                ActionIndex A = new ActionIndex();
                A.IndexPro = i + 1;
                A.TimePro = ConvertToInt(MovingData[i][5], MovingData[i][6]);

                Angle = new int[(MovingData[i].Length - 7) / 3];
                IDS = new int[(MovingData[Index].Length - 7) / 3];

                string X = "";
                int e = 0;
                for (int j = 7; j < MovingData[i].Length; j = j + 3)
                {
                    Angle[e] = ConvertToInt(MovingData[i][j + 1], MovingData[i][j + 2]);
                    X = X + "#" + MovingData[i][j] + " P" + Angle[e] + " ";

                    if (i == Index)
                        IDS[e] = MovingData[i][j];
                    e++;
                }
                A.ActionPro = X;
                livAction.Items.Add(A);

            }


            for (int i = 0; i < (MovingData[Index].Length - 7) / 3; i++)
                ReloadGridID(i, true);
        }

        public void MULT_SERVO_UNLOAD()
        {
            if (iServoControlled == 0)
            {
                System.IO.Stream str = Properties.Resources._01;
                SoundPlayer SPlayer = new SoundPlayer(str);
                SPlayer.Play();
                MessageBox.Show("Cann't find servo!", "Error", MessageBoxButton.OK);

                return;
            }
            IDS = new int[iServoControlled]; //Contain Servo ID   
            int datalength = iServoControlled + 3;

            ArrangeServoOrder(ref IDS); //Catagory servos that were choosed

            byte [] sBytes = new byte[datalength + 2]; //sBytes = Sending Bytes
            sBytes[0] = sBytes[1] = HEADER;
            sBytes[2] = (byte)datalength;
            sBytes[3] = 0x14;
            sBytes[4] = (byte)iServoControlled;

            for (int i = 0; i < iServoControlled; i++)
            {
                sBytes[i + 5] = (byte) IDS[i]; //Pass ID number of servo to sByte
            }
            serialPort.Write(sBytes, 0, datalength + 2);
        }

        private void btnOff_Click(object sender, RoutedEventArgs e)
        {
            MULT_SERVO_UNLOAD();
        }

        public void Send()
        {
            int datalength = iServoControlled + 3;
            byte[] sBytes = new byte[datalength + 2];

            sBytes[0] = sBytes[1] = HEADER;
            sBytes[2] = (byte)datalength;
            sBytes[3] = 0x15;
            sBytes[4] = (byte)iServoControlled;

            for (int i = 0; i < iServoControlled; i++)
            {
                sBytes[i + 5] = (byte)IDS[i]; //Pass ID number of servo to sByte
            }
            serialPort.Write(sBytes, 0, datalength + 2);
        }
        public void Read(ref int w, ref int x, ref int [] Angle)
        {
            int datalength = iServoControlled * 3 + 3;
            byte[] rBytes = new byte[datalength + 2];
            
            serialPort.ReadTimeout = 1000;

            ReadBytes(ref rBytes);

            int e = 0;

            //int[] A = new int[iServoControlled];
            //string c = "";
            ////int f = 1;
            //for (int i = 5; i < datalength + 2; i = i + 3)
            //{
            //    int temp = ConvertToInt(rBytes[i + 1], rBytes[i + 2]);
            //    //A[e] = temp;
            //    c = c + "#" + rBytes[i] + " P" + temp + " ";
            //    //f++;
            //}

            for (int i = 5; i < datalength + 2; i = i + 3)
            {

                if (rBytes[i] == 0 || rBytes[i] > 20) //Incase servo IDs are out range of total Servo
                {
                    System.IO.Stream str = Properties.Resources._01;
                    SoundPlayer SPlayer = new SoundPlayer(str);
                    SPlayer.Play();
                    MessageBox.Show("Cann't find servo!", "Error", MessageBoxButton.OK);
                    w = 1;
                    //MessageBox.Show(c, "Action", MessageBoxButton.OK);

                    return;
                }
                int temp = ConvertToInt(rBytes[i + 1], rBytes[i + 2]);
                if (temp > 1002)
                {
                    System.IO.Stream str = Properties.Resources._01;
                    SoundPlayer SPlayer = new SoundPlayer(str);
                    SPlayer.Play();
                    MessageBox.Show("Position Overoad!", "Warning", MessageBoxButton.OK);
                    x = 1;

                    return;
                }
                Angle[e] = temp;
                e++;
            }
        }
        public void MULT_SERVO_POS_READ ()
        {
            try
            {
                if (iServoControlled == 0)
                {
                    System.IO.Stream str = Properties.Resources._01;
                    SoundPlayer SPlayer = new SoundPlayer(str);
                    SPlayer.Play();
                    MessageBox.Show("Cann't find servo!", "Error", MessageBoxButton.OK);
                    Index--;

                    return;
                }
                int datalength = iServoControlled * 3 + 5;

                int ActionTime = Convert.ToInt32(txbActionTime.Text);
                int[] Angle = new int[iServoControlled];

                ArrangeServoOrder(ref IDS); //Catagory servos that were choosed

                //Create new stopwatch
                Send();
                Thread.Sleep(500);

                int x = 0, w = 0;
                Read(ref w,ref x, ref Angle);
                //Stopwatch stopwatch = Stopwatch.StartNew();
                //stopwatch.Start();

                if (x != 0 || w != 0)
                {
                    Index--;
                    return;
                }
                for (int i = 0; i < iServoControlled; i++)
                {
                    Switch(i, Angle[i], true);
                }

                //stopwatch.Stop();
                //MessageBox.Show(stopwatch.ElapsedMilliseconds.ToString(), "Execution Time");
                

                ActionIndex I = new ActionIndex();
                I.IndexPro = Index + 1;
                I.TimePro = Convert.ToInt32(txbActionTime.Text);
                string X = "";

                for (int i = 0; i < iServoControlled; i++)
                {
                    X = X + "#" + IDS[i] + " P" + Angle[i] + " ";
                }
                I.ActionPro = X;
                livAction.Items.Add(I);
                SAVE_SERVO_MOVE(IDS, ActionTime, Angle);
            }
            catch (Exception)
            {
                MessageBox.Show("Check your connection to the device.", "Error", MessageBoxButton.OKCancel);
            }
        }
        public void Switch (int i, int Angle, bool bVar)
        {
            switch (IDS[i])
            {
                case 1:
                    chbID1.IsChecked = bVar;
                    sliPosition1.Value = Angle;
                    break;
                case 2:
                    chbID2.IsChecked = bVar;
                    sliPosition2.Value = Angle;
                    break;
                case 3:
                    chbID3.IsChecked = bVar;
                    sliPosition3.Value = Angle;
                    break;
                case 4:
                    chbID4.IsChecked = bVar;
                    sliPosition4.Value = Angle;
                    break;
                case 5:
                    chbID5.IsChecked = bVar;
                    sliPosition5.Value = Angle;
                    break;
                case 6:
                    chbID6.IsChecked = bVar;
                    sliPosition6.Value = Angle;
                    break;
                case 7:
                    chbID7.IsChecked = bVar;
                    sliPosition7.Value = Angle;
                    break;
                case 8:
                    chbID8.IsChecked = bVar;
                    sliPosition8.Value = Angle;
                    break;
                case 9:
                    chbID9.IsChecked = bVar;
                    sliPosition9.Value = Angle;
                    break;
                case 10:
                    chbID10.IsChecked = bVar;
                    sliPosition10.Value = Angle;
                    break;
                case 11:
                    chbID11.IsChecked = bVar;
                    sliPosition11.Value = Angle;
                    break;
                case 12:
                    chbID12.IsChecked = bVar;
                    sliPosition12.Value = Angle;
                    break;
                case 13:
                    chbID13.IsChecked = bVar;
                    sliPosition13.Value = Angle;
                    break;
                case 14:
                    chbID14.IsChecked = bVar;
                    sliPosition14.Value = Angle;
                    break;
                case 15:
                    chbID15.IsChecked = bVar;
                    sliPosition15.Value = Angle;
                    break;
                case 16:
                    chbID16.IsChecked = bVar;
                    sliPosition16.Value = Angle;
                    break;
                case 17:
                    chbID17.IsChecked = bVar;
                    sliPosition17.Value = Angle;
                    break;
                case 18:
                    chbID18.IsChecked = bVar;
                    sliPosition18.Value = Angle;
                    break;
                case 19:
                    chbID19.IsChecked = bVar;
                    sliPosition19.Value = Angle;
                    break;
                case 20:
                    chbID20.IsChecked = bVar;
                    sliPosition20.Value = Angle;
                    break;
            }
        }

        private void btnRead_Click(object sender, RoutedEventArgs e)
        {
            Index = Index + 1;
            MULT_SERVO_POS_READ();
        }

        public void ReloadGridID (int i, bool bVar)
        {
            switch (IDS[i])
            {
                case 1:
                    chbID1.IsChecked = bVar;
                    break;
                case 2:
                    chbID2.IsChecked = bVar;
                    break;
                case 3:
                    chbID3.IsChecked = bVar;
                    break;
                case 4:
                    chbID4.IsChecked = bVar;
                    break;
                case 5:
                    chbID5.IsChecked = bVar;
                    break;
                case 6:
                    chbID6.IsChecked = bVar;
                    break;
                case 7:
                    chbID7.IsChecked = bVar;
                    break;
                case 8:
                    chbID8.IsChecked = bVar;
                    break;
                case 9:
                    chbID9.IsChecked = bVar;
                    break;
                case 10:
                    chbID10.IsChecked = bVar;
                    break;
                case 11:
                    chbID11.IsChecked = bVar;
                    break;
                case 12:
                    chbID12.IsChecked = bVar;
                    break;
                case 13:
                    chbID13.IsChecked = bVar;
                    break;
                case 14:
                    chbID14.IsChecked = bVar;
                    break;
                case 15:
                    chbID15.IsChecked = bVar;
                    break;
                case 16:
                    chbID16.IsChecked = bVar;
                    break;
                case 17:
                    chbID17.IsChecked = bVar;
                    break;
                case 18:
                    chbID18.IsChecked = bVar;
                    break;
                case 19:
                    chbID19.IsChecked = bVar;
                    break;
                case 20:
                    chbID20.IsChecked = bVar;
                    break;
            }
        }
        private void btnOpen_Click(object sender, RoutedEventArgs e)
        {
            int NoIndex, NoAction;

            for (int i = 0; i < Index; i++)
                MovingData[i] = null;
            Index = -1;

            livAction.Items.Clear();

            string mydocpath = "";

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Text file (*.txt)|*.txt";
            openFileDialog1.InitialDirectory = @"c:\";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;


            if (openFileDialog1.ShowDialog() == true)
            {
                if ((mydocpath = openFileDialog1.FileName) != null)
                {
                    string[] separators = { " " };
                    using (StreamReader inputfile = new StreamReader(Path.Combine(mydocpath), true))
                    {
                        NoIndex = Convert.ToInt32(inputfile.ReadLine()); //Get the number of Index
                        Index = NoIndex - 1;
                        for (int i = 0; i < NoIndex; i++)
                        {
                            NoAction = Convert.ToInt32(inputfile.ReadLine());   //read line by line, string to int
                            MovingData[i] = new byte[NoAction];

                            string split = inputfile.ReadLine();
                            string[] words = split.Split(separators, StringSplitOptions.RemoveEmptyEntries);

                            for (int j = 0; j < NoAction; j++)
                            {
                                MovingData[i][j] = Convert.ToByte(words[j]);
                            }
                        }
                        inputfile.Close();
                    } 
                }
                Open();
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < Index; i++)
            {
                MovingData[Index] = null;
            }
            Index = -1;
            
            livAction.Items.Clear();
        }

        private void btnEditTime_Click(object sender, RoutedEventArgs e)
        {
            int indx = livAction.SelectedIndex;
            if (indx == -1) //if user did not choose any Index, funtion would stop after ruturning.
            {
                System.IO.Stream str = Properties.Resources._01;
                SoundPlayer SPlayer = new SoundPlayer(str);
                SPlayer.Play();
                MessageBox.Show("Have not choosed any Index to Update.", "Warning", MessageBoxButton.OK);

                return;
            }
            ActionIndex I = (ActionIndex)livAction.SelectedItem;
            if (I == null)
                return;
            int ActionTime = Convert.ToInt32(txbActionTime.Text);
            I.TimePro = ActionTime;
            livAction.Items.Refresh();

            ConvertToByte(ref MovingData[indx][5], ref MovingData[indx][6], ActionTime);
        }

        public void UPDATE_ANGLE_READ(int ActionTime, int [] Angle, int indx)
        {
            try
            {
                int DataLength = iServoControlled * 3 + 5;
                MovingData[indx] = new byte[DataLength + 2];

                MovingData[indx][0] = MovingData[indx][1] = HEADER;
                MovingData[indx][2] = (byte)DataLength;

                MovingData[indx][4] = (byte)iServoControlled;
                ConvertToByte(ref MovingData[indx][5], ref MovingData[indx][6], ActionTime);

                int e = 0;
                for (int i = 7; i < DataLength; i = i + 3)
                {
                    //Update position from Read Angle
                    MovingData[indx][i] = (byte)IDS[e];
                    ConvertToByte(ref MovingData[indx][i + 1], ref MovingData[indx][i + 2], Angle[e]);
                    e++;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Check your connection to the device.", "Error", MessageBoxButton.OKCancel);
            }
        }
        public void UpdateAngle()
        {
            if (iServoControlled == 0)
            {
                System.IO.Stream str = Properties.Resources._01;
                SoundPlayer SPlayer = new SoundPlayer(str);
                SPlayer.Play();
                MessageBox.Show("Cann't find servo!", "Error", MessageBoxButton.OK);

                return;
            }

            int indx = livAction.SelectedIndex;
            if (indx == -1) //if user did not choose any Index, funtion would stop after ruturning.
            {
                System.IO.Stream str = Properties.Resources._01;
                SoundPlayer SPlayer = new SoundPlayer(str);
                SPlayer.Play();
                MessageBox.Show("Have not choosed any Index to Update.", "Warning", MessageBoxButton.OK);

                return;
            }

            int datalength = iServoControlled * 3 + 5;

            int ActionTime = Convert.ToInt32(txbActionTime.Text);
            int[] Angle = new int[iServoControlled];

            ArrangeServoOrder(ref IDS); //Catagory servos that were choosed

            //Create new stopwatch
            Send();
            Thread.Sleep(200);

            //Stopwatch stopwatch = Stopwatch.StartNew();
            //stopwatch.Start();
            int x = 0, w = 0;
            Read(ref w, ref x, ref Angle);

            if (x != 0 || w != 0)
            {
                Index--;
                return;
            }

            for (int i = 0; i < iServoControlled; i++)
            {
                Switch(i, Angle[i], true);
            }
            //stopwatch.Stop();

            ActionIndex I = (ActionIndex)livAction.SelectedItem;
            if (I == null)
                return;
            I.TimePro = ActionTime;
            string X = "";
            
            int temp = 0;
            for (int i = 0; i < iServoControlled; i++)
            {
                temp = IDS[i];
                //Angle[i] = ServoOrder[temp - 1].sliposition; //Catagory angle from ServoOrder[] to Angle[]
                X = X + "#" + IDS[i] + " P" + Angle[i] + " ";
            }
            I.ActionPro = X;
            UPDATE_ANGLE_READ(ActionTime, Angle, indx);
            livAction.Items.Refresh();
        }
        private void btnUpdateAngle_Click(object sender, RoutedEventArgs e)
        {
            UpdateAngle();
        }

        public void Add()
        {
            int[] ID = new int[iServoControlled]; //Contain Servo ID   

            int datalength = iServoControlled * 3 + 5;

            int ActionTime = Convert.ToInt32(txbActionTime.Text);
            int[] Angle = new int[iServoControlled];
            ArrangeServoOrder(ref ID); //Catagory servos that were choosed


            ActionIndex I = new ActionIndex();
            I.IndexPro = Index + 1;
            I.TimePro = Convert.ToInt32(txbActionTime.Text);
            int temp = 0;

            string X = "";
            for (int i = 0; i < iServoControlled; i++)
            {
                temp = ID[i];
                Angle[i] = ServoOrder[temp - 1].sliposition; //Catagory angle from ServoOrder[] to Angle[]
                X = X + "#" + ID[i] + " P" + Angle[i] + " ";
            }
            I.ActionPro = X;

            livAction.Items.Add(I);

            SAVE_SERVO_MOVE(ID, ActionTime, Angle);
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text file (*.txt)|*.txt";
            saveFileDialog1.InitialDirectory = @"c:\";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            string mydocpath = "";
            if (saveFileDialog1.ShowDialog() == true)
            {
                if ((mydocpath = saveFileDialog1.FileName) != null)
                    using (StreamWriter outputfile = new StreamWriter(Path.Combine(mydocpath), false))
                    {
                        outputfile.WriteLine(Index + 1);
                        for (int i = 0; i < Index + 1; i++)
                        {
                            outputfile.WriteLine(MovingData[i].Length);
                            for (int j = 0; j < MovingData[i].Length; j++)
                            {
                                outputfile.Write(MovingData[i][j] + " ");
                            }
                            outputfile.WriteLine();
                        }
                        outputfile.Close();
                    }
            }
        }

        public void Series(int NoIndex)
        {
            int[] Angle;
            for (int i =  NoIndex; i < Index + 1; i++)
            {
                ActionIndex A = new ActionIndex();
                A.IndexPro = i + 1;
                A.TimePro = ConvertToInt(MovingData[i][5], MovingData[i][6]);
                Angle = new int[MovingData[i].Length];

                string X = "";
                int e = 0;
                for (int j = 7; j < MovingData[i].Length; j = j + 3)
                {
                    Angle[e] = ConvertToInt(MovingData[i][j + 1], MovingData[i][j + 2]);
                    X = X + "#" + MovingData[i][j] + " P" + Angle[e] + " ";
                    e++;
                }
                A.ActionPro = X;
                livAction.Items.Add(A);
            }
        }

        private void frmMain_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            serialPort.DiscardInBuffer();
            serialPort.DiscardOutBuffer();
            serialPort.Dispose();
        }

        private void btnSeries_Click(object sender, RoutedEventArgs e)
        {
            int NoIndex, NoAction;

            string mydocpath = "";

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Text file (*.txt)|*.txt";
            openFileDialog1.InitialDirectory = @"c:\";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;


            if (openFileDialog1.ShowDialog() == true)
            {
                if ((mydocpath = openFileDialog1.FileName) != null)
                {
                    //if (Index == -1)

                    int preIndex = Index;
                    string[] separators = { " " };
                    using (StreamReader inputfile = new StreamReader(Path.Combine(mydocpath), true))
                    {
                        NoIndex = Convert.ToInt32(inputfile.ReadLine()); //Get the number of Index
                        Index = Index + NoIndex;
                        for (int i = preIndex + 1; i <= Index; i++)
                        {
                            NoAction = Convert.ToInt32(inputfile.ReadLine());   //read line by line, string to int
                            MovingData[i] = new byte[NoAction];

                            string split = inputfile.ReadLine();
                            string[] words = split.Split(separators, StringSplitOptions.RemoveEmptyEntries);

                            for (int j = 0; j < NoAction; j++)
                            {
                                MovingData[i][j] = Convert.ToByte(words[j]);
                            }
                        }
                        inputfile.Close();
                        Series(preIndex + 1);
                    }
                }
            }
        }

        private void btnAddAction_Click(object sender, RoutedEventArgs e)
        {
            Index++;
            Add();
        }

        public void Update(int indx)
        {
            int[] ID = new int[iServoControlled]; //Contain Servo ID   

            int ActionTime = Convert.ToInt32(txbActionTime.Text);
            int[] Angle = new int[iServoControlled];
            ArrangeServoOrder(ref ID); //Catagory servos that were choosed
            ActionIndex I = (ActionIndex)livAction.SelectedItem;

            if (I == null)
                return;
            I.TimePro = Convert.ToInt32(txbActionTime.Text);
            int temp = 0;

            string X = "";
            for (int i = 0; i < iServoControlled; i++)
            {
                temp = ID[i];
                Angle[i] = ServoOrder[temp - 1].sliposition; //Catagory angle from ServoOrder[] to Angle[]
                X = X + "#" + ID[i] + " P" + Angle[i] + " ";
            }
            I.ActionPro = X;
            livAction.Items.Refresh();

            UPDATE_SERVO_MOVE(ID, ActionTime, Angle, indx);
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            int indx = livAction.SelectedIndex;

            if (indx == -1) //if user did not choose any Index, funtion would stop after ruturning.
            {
                System.IO.Stream str = Properties.Resources._01;
                SoundPlayer SPlayer = new SoundPlayer(str);
                SPlayer.Play();
                MessageBox.Show("Have not choosed any Index to Update.", "Warning", MessageBoxButton.OK);

                return;
            }
            Update(indx);
        }
        public void REMOVE_SERVO_MOVE(ref bool selection) 
        {
            try
            {
                int indx = livAction.SelectedIndex;
                if (indx == -1)
                {
                    System.IO.Stream str = Properties.Resources._01;
                    SoundPlayer SPlayer = new SoundPlayer(str);
                    SPlayer.Play();
                    MessageBox.Show("Have not choosed any Index to Update.", "Warning", MessageBoxButton.OK);
                    selection = false;

                    return;
                }
                selection = true;

                for (int i = indx; i < Index; i++)
                {
                    int length = MovingData[i + 1].Length;
                    MovingData[i] = new byte[length];

                    Array.Copy(MovingData[i + 1], MovingData[i], length);
                }
                MovingData[Index] = null;
                Index--;
            }
            catch (Exception)
            {
                MessageBox.Show("No COM Port found.", "Error", MessageBoxButton.OKCancel);
            }
        }
        public void Remove()
        {
            ActionIndex I = (ActionIndex)livAction.SelectedItem;
            livAction.Items.Remove(I);
        }

        public void Arrange()
        {
            ActionIndex A;
            int ID, Angle;
            for (int i = 0; i < Index + 1; i++)
            {
                A = new ActionIndex();

                A.IndexPro = i + 1;
                A.TimePro = ConvertToInt(MovingData[i][5], MovingData[i][6]);

                string X = "";
                for (int j = 7; j < MovingData[i].Length; j = j + 3)
                {
                    ID = MovingData[i][j];
                    Angle = ConvertToInt(MovingData[i][j + 1], MovingData[i][j + 2]);

                    X = X + "#" + ID + " P" + Angle; //Listview Action properties
                }

                A.ActionPro = X;
                livAction.Items[i] = A; //Change directly listview subitems
            }
        }
        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            bool selection = false;
            REMOVE_SERVO_MOVE(ref selection);

            if (selection == false)
                return;
            Remove();

            Arrange(); //Rearrange Index order that was Removed
            
        }
        public void INSERT_SERVO_MOVE(int[] ID, int ActionTime, int[] ServoAngle, int indx) //
        {
            try
            {
                int DataLength = iServoControlled * 3 + 5;
                //int indx = livAction.SelectedIndex;
                MovingData[indx] = new byte[DataLength + 2];
                //Header
                MovingData[indx][0] = HEADER;
                MovingData[indx][1] = HEADER;

                MovingData[indx][2] = (byte)DataLength;
                //Command
                MovingData[indx][3] = 0x03;

                //Parameters
                MovingData[indx][4] = (byte)iServoControlled; //Number of servo controlled;

                ConvertToByte(ref MovingData[indx][5], ref MovingData[indx][6], ActionTime);

                int j = 0;
                for (int i = 7; i < DataLength; i = i + 3)
                {
                    //update slider position;
                    MovingData[indx][i] = (byte)ID[j];
                    ConvertToByte(ref MovingData[indx][i + 1], ref MovingData[indx][i + 2], ServoAngle[j]);
                    j++;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Check your connection to the device.", "Error", MessageBoxButton.OKCancel);
            }

        }
        public void INSERT_LISTVIEW_ITEMS(int[] ID, int[] Angle, int indx)
        {
            ActionIndex I = new ActionIndex();
            I.IndexPro = indx + 1;
            I.TimePro = Convert.ToInt32(txbActionTime.Text);

            string X = "";
            for (int i = 0; i < iServoControlled; i++)
            {
                X = X + "#" + ID[i] + " P" + Angle[i] + " ";
            }
            I.ActionPro = X;

            livAction.Items.Insert(indx, I);

        }
        public void Move_then_Insert(int indx) 
        {
            try
            {
                for (int i = Index; i > indx; i--)
                {
                    int length = MovingData[i - 1].Length;
                    MovingData[i] = new byte[length]; //Relocate new memory

                    Array.Copy(MovingData[i - 1], MovingData[i], length); //Copy data from the next Index
                }
                MovingData[indx] = null; //free choosed Index memory;

                int[] ID = new int[iServoControlled]; //Contain Servo ID   
                int ActionTime = Convert.ToInt32(txbActionTime.Text);
                int[] Angle = new int[iServoControlled];
                ArrangeServoOrder(ref ID); //Catagory servos that were choosed

                int temp = 0;

                for (int i = 0; i < iServoControlled; i++)
                {
                    temp = ID[i];
                    Angle[i] = ServoOrder[temp - 1].sliposition; //Catagory angle from ServoOrder[] to Angle[]
                }

                INSERT_SERVO_MOVE(ID, ActionTime, Angle, indx);
                INSERT_LISTVIEW_ITEMS(ID, Angle, indx); //Moving data in Jagged Array

            }
            catch (Exception)
            {
                MessageBox.Show("Check your connection to the device.", "Error", MessageBoxButton.OKCancel);
            }

        }
        private void btnInsert_Click(object sender, RoutedEventArgs e)
        {
            int indx = livAction.SelectedIndex; //selected Index
            if (indx == -1) //if user did not choose any Index, funtion would stop after ruturning.
            {
                System.IO.Stream str = Properties.Resources._01;
                SoundPlayer SPlayer = new SoundPlayer(str);
                SPlayer.Play();
                MessageBox.Show("Have not choosed any Index to Update.", "Warning", MessageBoxButton.OK);

                return;
            }
            Index++;
            Move_then_Insert(indx); //Moving item in displayment

            Arrange(); //Rearrange Index order that was Inserted
        }

        public void Run()
        {
            try
            {
                if (serialPort.IsOpen)
                {
                    int indx = livAction.SelectedIndex;
                    if (indx == -1) //if user did not choose any Index, funtion would stop after ruturning.
                    {
                        System.IO.Stream str = Properties.Resources._01;
                        SoundPlayer SPlayer = new SoundPlayer(str);
                        SPlayer.Play();
                        MessageBox.Show("Have not choosed any Index to Run.", "Warning", MessageBoxButton.OK);

                        return;
                    }

                    int NoAngle = (MovingData[indx].Length - 7) / 3;
                    int[] Angle = new int[NoAngle];

                    ReorderGridID(ref Angle, indx); //Reorder Grid ID to get each row angles;
                    //ArrangeServoOrder(ref IDS); //Catagory servos that were choosed

                    serialPort.Write(MovingData[indx], 0, MovingData[indx].Length);
                    Thread.Sleep(ConvertToInt(MovingData[indx][5], MovingData[indx][6]));

                    for (int j = 0; j < NoAngle; j++)
                    {
                        Switch(j, Angle[j], true);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please connect serial port.", "Error", MessageBoxButton.OKCancel);
            }
        }

        private void btnRun_Click(object sender, RoutedEventArgs e)
        {
            Run();
        }

        //private void chbLoop_Click(object sender, RoutedEventArgs e)
        //{
        //    try
        //    {
        //        //if (chbLoop.IsChecked == true)
        //        //{
        //        //    for (int i = 0; i < Index + 1; i++)
        //        //    {
        //        //        serialPort.Write(MovingData[i], 0, MovingData[i].Length);

        //        //        serialPort.WriteTimeout = 5000;
        //        //        //Suspends timeline until the previos method done
        //        //        Thread.Sleep(ConvertToInt(MovingData[i][5], MovingData[i][6]));
        //        //    }
        //        //}
        //    }
        //    catch (Exception)
        //    {
        //        MessageBox.Show("Please connect serial port.", "Error", MessageBoxButton.OKCancel);
        //    }
        //}

        public void ReorderGridID(ref int[] Angle, int i, int indx = -1)
        {
            if (indx == -1)
            {
                indx = Index;
            }
            else
            {
                i = indx;
            }
            IDS = new int[(MovingData[i].Length - 7) / 3];

            int e = 0;
            for (int j = 7; j < MovingData[i].Length; j = j + 3)
            {
                IDS[e] = MovingData[i][j];
                Angle[e] = ConvertToInt(MovingData[i][j + 1], MovingData[i][j + 2]);
                e++;
            }
        }

        public void RunSingle ()
        {
            try
            {
                if (serialPort.IsOpen)
                {
                    int NoAngle, NoLoop;
                    int[] Angle;

                    if (chbLoop.IsChecked == true)
                        NoLoop = 6;
                    else
                        NoLoop = 1;
                    for (int loop = 0; loop < NoLoop; loop++)
                    {
                        for (int i = 0; i < Index + 1; i++)
                        {
                            NoAngle = (MovingData[i].Length - 7) / 3;
                            Angle = new int[NoAngle];

                            ReorderGridID(ref Angle, i); //Reorder Grid ID to get each row angles;

                            serialPort.Write(MovingData[i], 0, MovingData[i].Length);
                            Thread.Sleep(ConvertToInt(MovingData[i][5], MovingData[i][6]));
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Running process.", "Error", MessageBoxButton.OKCancel);
            }
        }

        private void btnRunSingle_Click(object sender, RoutedEventArgs e)
        {
            RunSingle();
        }

        

    //private void btnRun_Click_1(object sender, RoutedEventArgs e)
    //{
    //    int[] ID = new int[iServoControlled]; //Contain Servo ID
    //    int datalength = iServoControlled * 3 + 5;

    //    //SERVO_MOVE = new byte[2 + datalength];
    //    int[] Angle = new int[iServoControlled];
    //    if (serialPort.IsOpen)
    //    {
    //        ArrangeServoOrder(ref ID); //Catagory servos that were choosed

    //        int ActionTime = Convert.ToInt32(txbActionTime.Text);

    //        //Get Servo angle
    //        int temp = 0;
    //        for (int i = 0; i < iServoControlled; i++)
    //        {
    //            temp = ID[i];
    //            Angle[i] = ServoOrder[temp - 1].sliposition; //Catagory angle from ServoOrder[] to Angle[]
    //        }
    //        CMD_SERVO_MOVE(ActionTime, ID, Angle);
    //    }
    //    else
    //    {
    //        MessageBox.Show("Please connect to serial port.", "Warning", MessageBoxButton.OKCancel);
    //    }
    //}

    private void btnGetBattery_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (serialPort.IsOpen)
                {
                    //byte[] sBytes = new byte[4];
                    //When application is crashed, Timeout is over.
                    //Program will automatically handle.
                    serialPort.ReadTimeout = 100;

                    //byte[] rBytes = new byte[6];
                    int Battery_Voltage = CMD_GET_BATTERY();
                    txtPinView.Text = Convert.ToString(Battery_Voltage);
                }
                else
                {
                    MessageBox.Show("Please connect to serial port.", "Warning", MessageBoxButton.OKCancel);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please connect to serial port.", "Warning", MessageBoxButton.OKCancel);
            }
        }
    }
}

