using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net.NetworkInformation;
using System.Threading;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Collections.Specialized;
using System.Net;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Reflection;
using System.Web;

//Remake by mazk#9154 -- https://github.com/mazk5145
//Remake by mazk#9154 -- https://github.com/mazk5145
//Remake by mazk#9154 -- https://github.com/mazk5145

namespace ambitioneersmhc
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void siticoneControlBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            guna2Button2.Enabled = false;
        }

        public DateTime UnixTimeToDateTime(long unixtime)
        {
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Local);
            dtDateTime = dtDateTime.AddSeconds(unixtime).ToLocalTime();
            return dtDateTime;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            about main = new about();
            main.Show();
        }

        private void connectwithacc_Click(object sender, EventArgs e)
        {
            if (dc.Checked == true) //Discord Click
            {
                MessageBox.Show("You choose Discord login.");
                //Process.Start("https://discord.com/api/oauth2/");
            }
            if (pate.Checked == true) //Patreon Click
            {
                MessageBox.Show("You choose Patreon login.");
                //Process.Start("https://www.patreon.com/login");
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (dc.Checked == true)
            {
                Process.Start("steam://rungameid/271590"); //starttaa gtaan steamista.
            }
            if (pate.Checked == true)
            {
                Process.Start("steam://rungameid/271590"); //starttaa gtaan steamista.
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.com/invite/jxqnNBFFgh");
        }
    }
}

//Remake by mazk#9154 -- https://github.com/mazk5145
//Remake by mazk#9154 -- https://github.com/mazk5145
//Remake by mazk#9154 -- https://github.com/mazk5145