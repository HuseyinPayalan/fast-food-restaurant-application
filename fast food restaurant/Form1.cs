using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fast_food_restaurant
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void facebookButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("www.facebook.com");
        }

        private void twitterButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("www.twitter.com");
        }

        private void instagramButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("www.instagram.com");
        }

        private void anasayfaButton_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = anasayfaButton.Checked;

            SidePanel.Height = anasayfaButton.Height;
            SidePanel.Top = anasayfaButton.Top;
            if (isChecked)
            {
                anasayfaButton.Font = new Font(anasayfaButton.Font.FontFamily, 12, FontStyle.Bold);
            }
            else
            {
                anasayfaButton.Font = new Font(anasayfaButton.Font.FontFamily, 12, FontStyle.Regular);
            }

            anasayfa1.BringToFront();
        }

        private void burgerlerButton_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = burgerlerButton.Checked;

            SidePanel.Height = burgerlerButton.Height;
            SidePanel.Top = burgerlerButton.Top;
            if (isChecked)
            {
                burgerlerButton.Font = new Font(burgerlerButton.Font.FontFamily, 12, FontStyle.Bold);
            }
            else
            {
                burgerlerButton.Font = new Font(burgerlerButton.Font.FontFamily, 12, FontStyle.Regular);
            }

            burgerler1.BringToFront();
        }

        private void iceceklerButton_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = iceceklerButton.Checked;

            SidePanel.Height = iceceklerButton.Height;
            SidePanel.Top = iceceklerButton.Top;
            if (isChecked)
            {
                iceceklerButton.Font = new Font(iceceklerButton.Font.FontFamily, 12, FontStyle.Bold);
            }
            else
            {
                iceceklerButton.Font = new Font(iceceklerButton.Font.FontFamily, 12, FontStyle.Regular);
            }

            ıcecekler1.BringToFront();
        }

        private void tatlilarButton_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = tatlilarButton.Checked;

            SidePanel.Height = tatlilarButton.Height;
            SidePanel.Top = tatlilarButton.Top;
            if (isChecked)
            {
                tatlilarButton.Font = new Font(tatlilarButton.Font.FontFamily, 12, FontStyle.Bold);
            }
            else
            {
                tatlilarButton.Font = new Font(tatlilarButton.Font.FontFamily, 12, FontStyle.Regular);
            }

            tatlilar1.BringToFront();
        }

        private void menulerButton_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = menulerButton.Checked;

            SidePanel.Height = menulerButton.Height;
            SidePanel.Top = menulerButton.Top;
            if (isChecked)
            {
                menulerButton.Font = new Font(menulerButton.Font.FontFamily, 12, FontStyle.Bold);
            }
            else
            {
                menulerButton.Font = new Font(menulerButton.Font.FontFamily, 12, FontStyle.Regular);
            }

            menuler1.BringToFront();
        }

        private void iletisimButton_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = iletisimButton.Checked;

            SidePanel.Height = iletisimButton.Height;
            SidePanel.Top = iletisimButton.Top;
            if (isChecked)
            {
                iletisimButton.Font = new Font(iletisimButton.Font.FontFamily, 12, FontStyle.Bold);
            }
            else
            {
                iletisimButton.Font = new Font(iletisimButton.Font.FontFamily, 12, FontStyle.Regular);
            }
            
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {

        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void tema_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tema_comboBox.Text == "Açık")
            {
                panel1.BackColor = Color.Silver;
                this.BackColor = SystemColors.Control;
                
                anasayfaButton.Image = Properties.Resources.home;
                burgerlerButton.Image = Properties.Resources.hamburger;
                iceceklerButton.Image = Properties.Resources.drinking;
                tatlilarButton.Image = Properties.Resources.dessert;
                menulerButton.Image = Properties.Resources.menu;
                iletisimButton.Image = Properties.Resources.phone;

                facebookButton.Image = Properties.Resources.facebook;
                twitterButton.Image = Properties.Resources.twitter;
                instagramButton.Image = Properties.Resources.instagram;

                minimizeButton.Image = Properties.Resources.minimize;
                settingsButton.Image = Properties.Resources.settings;
                closeButton.Image = Properties.Resources.power_off_button;
            }
            else if(tema_comboBox.Text == "Koyu")
            {
                panel1.BackColor = SystemColors.ControlDarkDark; ;
                
                this.BackColor = SystemColors.ControlDark;
                anasayfaButton.Image = Properties.Resources.home_white;
                burgerlerButton.Image = Properties.Resources.hamburger_white;
                iceceklerButton.Image = Properties.Resources.drinking_white;
                tatlilarButton.Image = Properties.Resources.dessert_white;
                menulerButton.Image = Properties.Resources.menu_white;
                iletisimButton.Image = Properties.Resources.phone_white;

                facebookButton.Image = Properties.Resources.facebook_white;
                twitterButton.Image = Properties.Resources.twitter_white;
                instagramButton.Image = Properties.Resources.instagram_white;

                minimizeButton.Image = Properties.Resources.minimize_white;
                settingsButton.Image = Properties.Resources.settings_white;
                closeButton.Image = Properties.Resources.power_off_button_white;
            }
        }

        private bool mouseDown;
        private Point last_location;
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            last_location = e.Location;
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point((this.Location.X - last_location.X) + e.X, (this.Location.Y - last_location.Y) + e.Y);
                this.Update();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            anasayfa1.BringToFront();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
