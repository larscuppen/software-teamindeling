
using BussinessLayer;
using BussinessLayer.model;
using BussinessLayer.service;

namespace jumpers
{
    public partial class Form1 : Form
    {
        ledenService ledenService = new ledenService();

        public Form1()
        {
            InitializeComponent();

            ledenService.addTeams();

            foreach (Team team in ledenService.showTeams())
            {
                TeamsLB.Items.Add(team);
            }
        }

        private void clearAddLB()
        {
            var geselecteerdTeam = TeamsLB.SelectedItem as Team;

            SpelersLB.Items.Clear();

            if (geselecteerdTeam != null)
            {
                foreach (Speler speler in geselecteerdTeam.SpelersOphalen())
                {
                    SpelersLB.Items.Add(speler);
                }
            }
        }

        private void TeamsLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.clearAddLB();
        }


        private void toevoegenBTN_Click(object sender, EventArgs e)
        {
            Team team = TeamsLB.SelectedItem as Team;

            int leeftijd = int.Parse(LeeftijdTB.Text);

            ledenService.addSpeler(team, NaamTB.Text, leeftijd);

            this.clearAddLB();
        }
    }
}