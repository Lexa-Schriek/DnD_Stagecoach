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
    public partial class StagecoachManager : Form
    {
        List<StagecoachModel> stagecoaches = new List<StagecoachModel>();
        public StagecoachManager()
        {
            InitializeComponent();

            LoadStagecoachList();
        }

        public void LoadStagecoachList()
        {
            stagecoaches = SqliteDataAccess.LoadStagecoaches();

            WireUpStagecoachList();
        }

        private void WireUpStagecoachList()
        {
            StagecoachList.DataSource = null;
            StagecoachList.DataSource = stagecoaches;
            StagecoachList.DisplayMember = "DisplayName";
        }

        private void HitpointsLabel_Click(object sender, EventArgs e)
        {

        }

        private void CrewCountLabel_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void RationsLabel_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void WaterLabel_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void HorsesLabel_Click(object sender, EventArgs e)
        {

        }

        private void StagecoachManager_Load(object sender, EventArgs e)
        {

        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            
            //Tryparces to avoid idiots breaking things by entering the wrong datatypes
            bool HPCheck = int.TryParse(HitpointsBox.Text, out int HitPointsInt);
            bool HPCheckMax = int.TryParse(MaxHitpointsBox.Text, out int HitPointsMaxInt);
            bool RationsCheck = int.TryParse(RationsBox.Text, out int RationsInt);
            bool WaterCheck = int.TryParse(WaterBox.Text, out int WaterInt);
            bool HorsesCheck = int.TryParse(HorsesBox.Text, out int HorsesInt);
            bool CrewCheck = int.TryParse(CrewCountBox.Text, out int CrewCountInt);

            //If checks if all inputs are of the proper type before creating a new stagecoach and filling in the data
            if (HPCheck && HPCheckMax && RationsCheck && WaterCheck && HorsesCheck && CrewCheck)
            {
                StagecoachModel stagecoachObject = new StagecoachModel();


                stagecoachObject.Name = StagecoachNameBox.Text;
                stagecoachObject.HitPoints = HitPointsInt;
                stagecoachObject.HitPointsMax = HitPointsMaxInt;
                stagecoachObject.Rations = RationsInt;
                stagecoachObject.Water = WaterInt;
                stagecoachObject.Horses = HorsesInt;
                stagecoachObject.CrewCount = CrewCountInt;

                SqliteDataAccess.CreateStagecoach(stagecoachObject);
            }
            else // Gives an error message if some values have the wrong datatype
            {
                MessageBox.Show("Error: an incorrect value was entered");
            }

            // Refresh list after adding a new stagecoach
            LoadStagecoachList();
            

        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            LoadStagecoachList();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            StagecoachOverview stagecoachOverview = new StagecoachOverview();
            stagecoachOverview.Show();
        }
    }
}
