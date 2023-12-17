using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StagecoachApp
{
    public partial class StagecoachOverview : Form
    {
        public StagecoachOverview()
        {
            InitializeComponent();
        }

        private void GenerateDbButton_Click(object sender, EventArgs e)
        {
            SqliteDataAccess.GenerateDatabase();
            MessageBox.Show("Database Generated");
        }

        private void UpdateStatsButton_Click(object sender, EventArgs e)
        {
            //Updates the most used stats on the 
            bool ResHP = int.TryParse(HealthInput.Text, out int Hitpoints);
            bool ResRation = int.TryParse(HealthInput.Text, out int Rations);
            bool ResWater = int.TryParse(HealthInput.Text, out int Water);


            MessageBox.Show("Hitpoints: " + Hitpoints.ToString() + " Rations: " + Rations.ToString() + " Water: " + Water.ToString());

        }

        private void StagecoachManageButton_Click(object sender, EventArgs e)
        {
            StagecoachManager stagecoachmanager = new StagecoachManager();
            stagecoachmanager.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            this.Refresh();
            StagecoachModel stagecoach = SqliteDataAccess.GetStagecoach(SelectedStagecoach.StagecoachId);
            StagecoachNameLabel.Text = stagecoach.Name;
        }
    }
}
