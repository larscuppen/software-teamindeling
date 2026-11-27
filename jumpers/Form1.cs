using System.Security.Cryptography.X509Certificates;

namespace jumpers
{
    public partial class Form1 : Form
    {
        private List<Team> teams = new List<Team>();

        public Form1()
        {
            InitializeComponent();

            Team U10 = new Team("U10", 11);
            Team U12 = new Team("U12", 11);
            Team U14 = new Team("U14", 11);
            Team U16 = new Team("U16", 11);
            Team U18 = new Team("U18", 11);

            teams.Add(U10);
            teams.Add(U12);
            teams.Add(U14);
            teams.Add(U16);
            teams.Add(U18);

            foreach (Team team in teams)
            {
                TeamsLB.Items.Add(team);
            }


            U10.LidIndelen(new Speler("Milan", 9));
            U10.LidIndelen(new Speler("Jayden", 10));
            U10.LidIndelen(new Speler("Thijs", 9));
            U10.LidIndelen(new Speler("Mees", 10));
            U10.LidIndelen(new Speler("Bram", 9));


            U12.LidIndelen(new Speler("Daan", 11));
            U12.LidIndelen(new Speler("Finn", 12));
            U12.LidIndelen(new Speler("Noah", 11));
            U12.LidIndelen(new Speler("Sem", 12));
            U12.LidIndelen(new Speler("Luuk", 11));


            U14.LidIndelen(new Speler("Levi", 13));
            U14.LidIndelen(new Speler("Max", 14));
            U14.LidIndelen(new Speler("Timo", 13));
            U14.LidIndelen(new Speler("Jesse", 14));
            U14.LidIndelen(new Speler("Niek", 13));


            U16.LidIndelen(new Speler("Thomas", 15));
            U16.LidIndelen(new Speler("Lucas", 16));
            U16.LidIndelen(new Speler("Ruben", 15));
            U16.LidIndelen(new Speler("Mats", 16));
            U16.LidIndelen(new Speler("Julian", 15));


            U18.LidIndelen(new Speler("LarsBaas", 17));
            U18.LidIndelen(new Speler("Sam", 18));
            U18.LidIndelen(new Speler("Milan", 17));
            U18.LidIndelen(new Speler("Stijn", 18));
            U18.LidIndelen(new Speler("Kevin", 17));
        }

        private void TeamsLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            var GeselecteerdTeam = TeamsLB.SelectedItem as Team;
            SpelersLB.Items.Clear();
            foreach(Speler speler in GeselecteerdTeam.SpelersOphalen())
            {
                SpelersLB.Items.Add(speler);
            }
        }
    }
}