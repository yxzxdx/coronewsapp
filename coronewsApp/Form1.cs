using System;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coronewsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.Lime;
            this.TransparencyKey = Color.Lime;


            var urlCovid = "https://covid19.mathdro.id/api/countries/ID";
            var hasilCovid = new WebClient().DownloadString(urlCovid);
            dynamic covid = JObject.Parse(hasilCovid);
            var covid_confirmed = covid.confirmed.value;
            var covid_recovered = covid.recovered.value;
            var covid_deaths = covid.deaths.value;
            var update = covid.lastUpdate;
            DateTime aDate = update;


            konfirmasi.Text = covid_confirmed;
            sembuh.Text = covid_recovered;
            meninggal.Text = covid_deaths;

            lastupdate.Text = aDate.ToString("MM/dd/yyyy HH:mm");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
