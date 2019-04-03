using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZodiacKillerRust
{
    public partial class Main : Form
    {
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);
        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        public static bool CheatEnabled = false;
        public static List<Weapon> WeaponList = new List<Weapon>();
        public static Weapon CurrentWeapon;

        enum KeyModifier
        {
            None = 0,
            Alt = 1,
            Control = 2,
            Shift = 4,
            WinKey = 8
        }

        public Main()
        {
            InitializeComponent();

            RegisterHotKeys();
        }

        #region Events

        private void Main_Load(object sender, EventArgs e)
        {
            //Initialize weapons

            #region Weapon Initializations

            //Needs work
            Weapon AssaultRifle = new Weapon();
            AssaultRifle.Name = "Assault Rifle";
            AssaultRifle.Mode = FiringMode.Automatic;
            AssaultRifle.MovementMultiplier = 1;
            AssaultRifle.RecoilTable = new[] { new[] { -50, 65 }, new[] { 17, 65 }, new[] { -90, 65 }, new[] { -55, 65 }, new[] { 30, 20 }, new[] { 20, 40 }, new[] { 50, 40 }, new[] { 70, 10 }, new[] { 60, 10 }, new[] { 50, 25 }, new[] { 50, 40 }, new[] { 0, 35 }, new[] { -25, 50 }, new[] { -40, 50 }, new[] { -45, 40 }, new[] { -60, 30 }, new[] { -60, 25 }, new[] { -60, 45 }, new[] { -60, 25 }, new[] { -50, 25 }, new[] { -20, 30 }, new[] { 20, 40 }, new[] { 60, 40 }, new[] { 75, 40 }, new[] { 75, 45 }, new[] { 55, 35 } };
            AssaultRifle.FireRate = 133;
            AssaultRifle.SmoothValue = 10;
            WeaponList.Add(AssaultRifle);

            //Tighter than my ass
            Weapon LR300 = new Weapon();
            LR300.Name = "LR-300";
            LR300.Mode = FiringMode.Automatic;
            LR300.MovementMultiplier = 1;
            LR300.RecoilTable = new[] { new[] { -4, 28 }, new[] { -10, 38 }, new[] { -14, 38 }, new[] { -18, 24 }, new[] { -18, 20 }, new[] { -20, 20 }, new[] { -2, 20 }, new[] { 16, 20 }, new[] { 22, 20 }, new[] { 22, 20 }, new[] { 8, 18 }, new[] { 20, 18 }, new[] { 0, 4 }, new[] { -16, 4 }, new[] { -14, 4 }, new[] { -14, 4 }, new[] { -22, 4 }, new[] { -22, 4 }, new[] { -22, 4 }, new[] { -22, 4 }, new[] { 0, 4 }, new[] { 0, 4 }, new[] { 0, 4 }, new[] { 40, 4 }, new[] { 40, 4 }, new[] { 40, 4 }, new[] { 40, 4 }, new[] { 40, 4 } };
            LR300.FireRate = 110;
            LR300.SmoothValue = 5;
            WeaponList.Add(LR300);

            Weapon M249 = new Weapon();
            M249.Name = "M249";
            M249.Mode = FiringMode.Automatic;
            M249.MovementMultiplier = 1;
            M249.RecoilTable = new[] { new[] { 0, 45 }, new[] { 0, 45 }, new[] { 0, 45 }, new[] { 0, 45 }, new[] { 0, 45 }, new[] { 0, 45 }, new[] { 0, 45 }, new[] { 0, 45 }, new[] { 0, 45 }, new[] { 0, 45 }, new[] { 0, 45 }, new[] { 0, 45 }, new[] { 0, 45 }, new[] { 0, 45 }, new[] { 0, 45 }, new[] { 0, 45 }, new[] { 0, 45 }, new[] { 0, 45 }, new[] { 0, 45 }, new[] { 0, 45 }, new[] { 0, 45 }, new[] { 0, 45 }, new[] { 0, 45 }, new[] { 0, 45 }, new[] { 0, 45 }, new[] { 0, 45 }, new[] { 0, 45 }, new[] { 0, 45 }, new[] { 0, 45 }, new[] { 0, 45 }, new[] { 0, 45 }, new[] { 0, 45 }, new[] { 0, 45 }, new[] { 0, 45 }, new[] { 0, 45 }, new[] { 0, 45 }, new[] { 0, 45 }, new[] { 0, 45 }, new[] { 0, 45 }, new[] { 0, 45 }, new[] { 0, 45 }, new[] { 0, 45 }, new[] { 0, 45 }, new[] { 0, 45 }, new[] { 0, 45 }, new[] { 0, 45 }, new[] { 0, 45 }, new[] { 0, 45 }, new[] { 0, 45 }, new[] { 0, 45 }, new[] { 0, 45 }, new[] { 0, 45 }, new[] { 0, 45 }, new[] { 0, 45 }, new[] { 0, 45 }, new[] { 0, 45 }, new[] { 0, 45 }, new[] { 0, 45 }, new[] { 0, 45 }, new[] { 0, 45 }, new[] { 0, 45 }, new[] { 0, 45 }, new[] { 0, 45 }, new[] { 0, 45 }, new[] { 0, 45 }, new[] { 0, 45 }, new[] { 0, 45 }, new[] { 0, 45 }, new[] { 0, 45 }, new[] { 0, 45 }, new[] { 0, 45 }, new[] { 0, 45 }, new[] { 0, 45 }, new[] { 0, 45 }, new[] { 0, 45 }, new[] { 0, 45 }, new[] { 0, 45 }, new[] { 0, 45 }, new[] { 0, 45 }, new[] { 0, 45 }, new[] { 0, 45 }, new[] { 0, 45 }, new[] { 0, 45 }, new[] { 0, 45 }, new[] { 0, 45 }, new[] { 0, 45 }, new[] { 0, 45 }, new[] { 0, 45 }, new[] { 0, 45 }, new[] { 0, 45 }, new[] { 0, 45 }, new[] { 0, 45 }, new[] { 0, 45 }, new[] { 0, 45 }, new[] { 0, 45 }, new[] { 0, 45 }, new[] { 0, 45 }, new[] { 0, 45 } };
            M249.FireRate = 120;
            M249.SmoothValue = 5;
            WeaponList.Add(M249);

            Weapon Thomson = new Weapon();
            Thomson.Name = "Thomson";
            Thomson.Mode = FiringMode.Automatic;
            Thomson.MovementMultiplier = 0.7;
            Thomson.RecoilTable = new[] { new[] { -25, 50 }, new[] { 0, 45 }, new[] { 0, 50 }, new[] { 0, 50 }, new[] { 30, 45 }, new[] { 0, 40 }, new[] { 0, 40 }, new[] { 0, 40 }, new[] { 0, 20 }, new[] { -20, 20 }, new[] { 0, 20 }, new[] { -30, 20 }, new[] { 0, 20 }, new[] { 0, 20 }, new[] { 50, 20 }, new[] { 20, 10 }, new[] { 10, 10 }, new[] { 10, 15 } };
            Thomson.FireRate = 130;
            Thomson.SmoothValue = 5;
            WeaponList.Add(Thomson);

            Weapon MP5 = new Weapon();
            MP5.Name = "MP5";
            MP5.Mode = FiringMode.Automatic;
            MP5.MovementMultiplier = 2.25;
            MP5.RecoilTable = new[] { new[] { 0, 14 }, new[] { 0, 18 }, new[] { 3, 17 }, new[] { 15, 18 }, new[] { 15, 14 }, new[] { 15, 13 }, new[] { 10, 10 }, new[] { -6, 6 }, new[] { -11, 5 }, new[] { -11, 6 }, new[] { -5, 6 }, new[] { 0, 4 }, new[] { 0, 4 }, new[] { 8, 4 }, new[] { 10, 2 }, new[] { 10, 2 }, new[] { 8, 0 }, new[] { -3, 0 }, new[] { -3, 0 }, new[] { -6, 0 }, new[] { -6, 0 }, new[] { -8, 0 }, new[] { -8, 0 }, new[] { -6, 0 }, new[] { -6, 0 }, new[] { -5, 0 }, new[] { -6, 0 }, new[] { -4, 0 }, new[] { -4, 0 }, new[] { -4, 0 } };
            MP5.FireRate = 100;
            MP5.SmoothValue = 5;
            WeaponList.Add(MP5);

            Weapon CustomSMG = new Weapon();
            CustomSMG.Name = "Custom SMG";
            CustomSMG.Mode = FiringMode.Automatic;
            CustomSMG.MovementMultiplier = 0.7;
            CustomSMG.RecoilTable = new[] { new[] { -25, 50 }, new[] { 0, 45 }, new[] { 0, 50 }, new[] { 0, 50 }, new[] { 30, 45 }, new[] { 0, 40 }, new[] { 0, 40 }, new[] { 0, 40 }, new[] { 0, 20 }, new[] { -20, 20 }, new[] { 0, 20 }, new[] { -30, 20 }, new[] { 0, 20 }, new[] { 0, 20 }, new[] { 50, 20 }, new[] { 20, 10 }, new[] { 10, 10 }, new[] { 10, 15 }, new[] { 10, 10 }, new[] { 10, 10 }, new[] { 10, 10 }, new[] { 10, 10 }, new[] { 10, 10 } };
            CustomSMG.FireRate = 100;
            CustomSMG.SmoothValue = 5;
            WeaponList.Add(CustomSMG);

            Weapon SAR = new Weapon();
            SAR.Name = "Semi Automatic Rifle";
            SAR.Mode = FiringMode.SemiAutomatic;
            SAR.MovementMultiplier = 1;
            SAR.FireRate = 100;
            SAR.SmoothValue = 1;
            WeaponList.Add(SAR);

            Weapon M92 = new Weapon();
            M92.Name = "M92";
            M92.Mode = FiringMode.SemiAutomatic;
            M92.MovementMultiplier = 0.2;
            M92.FireRate = 10;
            M92.SmoothValue = 1;
            WeaponList.Add(M92);

            Weapon Python = new Weapon();
            Python.Name = "Python";
            Python.Mode = FiringMode.SemiAutomatic;
            Python.MovementMultiplier = 1;
            Python.FireRate = 150;
            Python.SmoothValue = 1;
            WeaponList.Add(Python);

            Weapon M39 = new Weapon();
            M39.Name = "M39";
            M39.Mode = FiringMode.SemiAutomatic;
            M39.MovementMultiplier = 1;
            M39.FireRate = 100;
            M39.SmoothValue = 1;
            WeaponList.Add(M39);

            #endregion

            //Create our AntiRecoil thread
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                AntiRecoil.Run();
            }).Start();
        }

        private void WeaponSelectCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Set our selected weapon to active weapon
            CurrentWeapon = WeaponList[WeaponSelectCombo.SelectedIndex];
        }

        private void ToggleButton_Click(object sender, EventArgs e)
        {
            //Toggle cheat
            ToggleCheat();
        }

        private void Main_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Main_Paint(object sender, PaintEventArgs e)
        {
            LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, Color.Red, Color.Orange, LinearGradientMode.ForwardDiagonal);
            e.Graphics.DrawRectangle(new Pen(brush, 10), this.ClientRectangle);
            brush.Dispose();
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region Functions

        public void ToggleCheat()
        {
            CheatEnabled = !CheatEnabled;
            if (CheatEnabled)
            {
                ToggleButton.Text = "Enabled";
            }
            else if (!CheatEnabled)
            {
                ToggleButton.Text = "Disabled";
            }
        }

        public void RegisterHotKeys()
        {
            int id = 0;

            RegisterHotKey(this.Handle, id, (int)KeyModifier.None, Keys.NumPad0.GetHashCode());
            id++;
            RegisterHotKey(this.Handle, id, (int)KeyModifier.None, Keys.NumPad1.GetHashCode());
            id++;
            RegisterHotKey(this.Handle, id, (int)KeyModifier.None, Keys.NumPad2.GetHashCode());
            id++;
            RegisterHotKey(this.Handle, id, (int)KeyModifier.None, Keys.NumPad3.GetHashCode());
            id++;
            RegisterHotKey(this.Handle, id, (int)KeyModifier.None, Keys.NumPad4.GetHashCode());
            id++;
            RegisterHotKey(this.Handle, id, (int)KeyModifier.None, Keys.NumPad5.GetHashCode());
            id++;
            RegisterHotKey(this.Handle, id, (int)KeyModifier.None, Keys.NumPad6.GetHashCode());
            id++;
            RegisterHotKey(this.Handle, id, (int)KeyModifier.None, Keys.NumPad7.GetHashCode());
            id++;
            RegisterHotKey(this.Handle, id, (int)KeyModifier.None, Keys.NumPad8.GetHashCode());
            id++;
            RegisterHotKey(this.Handle, id, (int)KeyModifier.None, Keys.NumPad9.GetHashCode());
            id++;
            RegisterHotKey(this.Handle, id, (int)KeyModifier.None, Keys.Insert.GetHashCode());
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == 0x0312)
            {
                Keys key = (Keys)(((int)m.LParam >> 16) & 0xFFFF);
                KeyModifier modifier = (KeyModifier)((int)m.LParam & 0xFFFF);
                int id = m.WParam.ToInt32();

                if (id == 1)
                {
                    //Set current weapon to assault rifle
                    CurrentWeapon = WeaponList[0];
                    WeaponSelectCombo.SelectedIndex = 0;
                }
                else if (id == 2)
                {
                    //Set current weapon to lr
                    CurrentWeapon = WeaponList[1];
                    WeaponSelectCombo.SelectedIndex = 1;
                }
                else if (id == 3)
                {
                    //Set current weapon to m249
                    CurrentWeapon = WeaponList[2];
                    WeaponSelectCombo.SelectedIndex = 2;
                }
                else if (id == 4)
                {
                    //Set current weapon to thomson
                    CurrentWeapon = WeaponList[3];
                    WeaponSelectCombo.SelectedIndex = 3;
                }
                else if (id == 5)
                {
                    //Set current weapon to mp5
                    CurrentWeapon = WeaponList[4];
                    WeaponSelectCombo.SelectedIndex = 4;
                }
                else if (id == 6)
                {
                    //Set current weapon to custom
                    CurrentWeapon = WeaponList[5];
                    WeaponSelectCombo.SelectedIndex = 5;
                }
                else if (id == 7)
                {
                    //Set current weapon to sar
                    CurrentWeapon = WeaponList[6];
                    WeaponSelectCombo.SelectedIndex = 6;
                }
                else if (id == 8)
                {
                    //Set current weapon to m92
                    CurrentWeapon = WeaponList[7];
                    WeaponSelectCombo.SelectedIndex = 7;
                }
                else if (id == 9)
                {
                    //Set current weapon to python
                    CurrentWeapon = WeaponList[8];
                    WeaponSelectCombo.SelectedIndex = 8;
                }
                else if (id == 0)
                {
                    //Set surrent weapon to m39
                    CurrentWeapon = WeaponList[9];
                    WeaponSelectCombo.SelectedIndex = 9;
                }
                else if (id == 10)
                {
                    ToggleCheat();
                }
            }
        }

        #endregion
    }
}
