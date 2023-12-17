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
            
            //Tryparces to avoid breaking things by entering the wrong datatypes
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
            StagecoachList.SelectedIndex = SelectedStagecoach.StagecoachId;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            // Might update this function to automatically refresh the overview page but for now it's fine
            this.Close();
        }

        private void StagecoachList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Selection = 1;
            if (StagecoachList.SelectedIndex == -1)
            {
                Selection = SelectedStagecoach.StagecoachId;
            }
            else
            {
                int stagecoachSelected = StagecoachList.SelectedIndex + 1;
                SelectedStagecoach.StagecoachId = stagecoachSelected;
                Selection = SelectedStagecoach.StagecoachId;
            }
            

            //MessageBox.Show(Selection.ToString()); //debug

            StagecoachModel stagecoach = SqliteDataAccess.GetStagecoach(Selection);

            // This was written for testing purposes only to ensure the proper parameters were selected
            //stagecoach.Id = stagecoachSelected;
            //string message = "id: "+stagecoach.Id+" hp: "+stagecoach.HitPoints+ " name: " + stagecoach.Name;
            //MessageBox.Show(message);

            StagecoachNameBox.Text = stagecoach.Name;
            HitpointsBox.Text = stagecoach.HitPoints.ToString();
            MaxHitpointsBox.Text = stagecoach.HitPointsMax.ToString();
            RationsBox.Text = stagecoach.Rations.ToString();
            WaterBox.Text = stagecoach.Water.ToString();
            HorsesBox.Text = stagecoach.Horses.ToString();
            CrewCountBox.Text = stagecoach.CrewCount.ToString();

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {

            //string message = "updating selected stagecoach id = " + SelectedStagecoach.StagecoachId;
            //MessageBox.Show(message);

            //Tryparces to avoid breaking things by entering the wrong datatypes
            bool HPCheck = int.TryParse(HitpointsBox.Text, out int HitPointsInt);
            bool HPCheckMax = int.TryParse(MaxHitpointsBox.Text, out int HitPointsMaxInt);
            bool RationsCheck = int.TryParse(RationsBox.Text, out int RationsInt);
            bool WaterCheck = int.TryParse(WaterBox.Text, out int WaterInt);
            bool HorsesCheck = int.TryParse(HorsesBox.Text, out int HorsesInt);
            bool CrewCheck = int.TryParse(CrewCountBox.Text, out int CrewCountInt);

            //If checks if all inputs are of the proper type before updating the stagecoach
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

                SqliteDataAccess.UpdateStagecoach(stagecoachObject);
            }
            else // Gives an error message if some values have the wrong datatype
            {
                MessageBox.Show("Error: an incorrect value was entered");
            }

            // Refresh list after updating the stagecoach
            LoadStagecoachList();
            
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        { // current way of retrieving and updating data in the database is less than ideal and would break with deleting records.
            MessageBox.Show("Not yet implemented"); 
        }
    }
}
