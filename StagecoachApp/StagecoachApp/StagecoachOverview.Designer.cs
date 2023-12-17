
namespace StagecoachApp
{
    partial class StagecoachOverview
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.HitPointsBar = new System.Windows.Forms.ProgressBar();
            this.RationsBar = new System.Windows.Forms.ProgressBar();
            this.WaterBar = new System.Windows.Forms.ProgressBar();
            this.HealthInput = new System.Windows.Forms.TextBox();
            this.RationsInput = new System.Windows.Forms.TextBox();
            this.WaterInput = new System.Windows.Forms.TextBox();
            this.GenerateDbButton = new System.Windows.Forms.Button();
            this.UpdateStatsButton = new System.Windows.Forms.Button();
            this.StagecoachManageButton = new System.Windows.Forms.Button();
            this.InventoryButton = new System.Windows.Forms.Button();
            this.StagecoachNameLabel = new System.Windows.Forms.Label();
            this.RationsLabel = new System.Windows.Forms.Label();
            this.WaterLabel = new System.Windows.Forms.Label();
            this.HitPointsLabel = new System.Windows.Forms.Label();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.InventoryOverviewList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HitPointsBar
            // 
            this.HitPointsBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HitPointsBar.Location = new System.Drawing.Point(929, 125);
            this.HitPointsBar.Name = "HitPointsBar";
            this.HitPointsBar.Size = new System.Drawing.Size(321, 35);
            this.HitPointsBar.TabIndex = 0;
            // 
            // RationsBar
            // 
            this.RationsBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RationsBar.Location = new System.Drawing.Point(929, 213);
            this.RationsBar.Name = "RationsBar";
            this.RationsBar.Size = new System.Drawing.Size(321, 35);
            this.RationsBar.TabIndex = 1;
            // 
            // WaterBar
            // 
            this.WaterBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.WaterBar.Location = new System.Drawing.Point(929, 304);
            this.WaterBar.Name = "WaterBar";
            this.WaterBar.Size = new System.Drawing.Size(321, 35);
            this.WaterBar.TabIndex = 2;
            // 
            // HealthInput
            // 
            this.HealthInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HealthInput.Location = new System.Drawing.Point(831, 125);
            this.HealthInput.Name = "HealthInput";
            this.HealthInput.Size = new System.Drawing.Size(92, 35);
            this.HealthInput.TabIndex = 3;
            // 
            // RationsInput
            // 
            this.RationsInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RationsInput.Location = new System.Drawing.Point(831, 213);
            this.RationsInput.Name = "RationsInput";
            this.RationsInput.Size = new System.Drawing.Size(92, 35);
            this.RationsInput.TabIndex = 4;
            // 
            // WaterInput
            // 
            this.WaterInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.WaterInput.Location = new System.Drawing.Point(831, 304);
            this.WaterInput.Name = "WaterInput";
            this.WaterInput.Size = new System.Drawing.Size(92, 35);
            this.WaterInput.TabIndex = 5;
            // 
            // GenerateDbButton
            // 
            this.GenerateDbButton.Location = new System.Drawing.Point(278, 36);
            this.GenerateDbButton.Name = "GenerateDbButton";
            this.GenerateDbButton.Size = new System.Drawing.Size(157, 40);
            this.GenerateDbButton.TabIndex = 7;
            this.GenerateDbButton.Text = "GenerateDB";
            this.GenerateDbButton.UseVisualStyleBackColor = true;
            this.GenerateDbButton.Click += new System.EventHandler(this.GenerateDbButton_Click);
            // 
            // UpdateStatsButton
            // 
            this.UpdateStatsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdateStatsButton.Location = new System.Drawing.Point(952, 375);
            this.UpdateStatsButton.Name = "UpdateStatsButton";
            this.UpdateStatsButton.Size = new System.Drawing.Size(131, 40);
            this.UpdateStatsButton.TabIndex = 8;
            this.UpdateStatsButton.Text = "Update";
            this.UpdateStatsButton.UseVisualStyleBackColor = true;
            this.UpdateStatsButton.Click += new System.EventHandler(this.UpdateStatsButton_Click);
            // 
            // StagecoachManageButton
            // 
            this.StagecoachManageButton.Location = new System.Drawing.Point(29, 36);
            this.StagecoachManageButton.Name = "StagecoachManageButton";
            this.StagecoachManageButton.Size = new System.Drawing.Size(226, 40);
            this.StagecoachManageButton.TabIndex = 9;
            this.StagecoachManageButton.Text = "Manage Stagecoach";
            this.StagecoachManageButton.UseVisualStyleBackColor = true;
            this.StagecoachManageButton.Click += new System.EventHandler(this.StagecoachManageButton_Click);
            // 
            // InventoryButton
            // 
            this.InventoryButton.Location = new System.Drawing.Point(460, 36);
            this.InventoryButton.Name = "InventoryButton";
            this.InventoryButton.Size = new System.Drawing.Size(131, 40);
            this.InventoryButton.TabIndex = 10;
            this.InventoryButton.Text = "Inventory";
            this.InventoryButton.UseVisualStyleBackColor = true;
            this.InventoryButton.Click += new System.EventHandler(this.InventoryButton_Click);
            // 
            // StagecoachNameLabel
            // 
            this.StagecoachNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StagecoachNameLabel.AutoSize = true;
            this.StagecoachNameLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StagecoachNameLabel.Location = new System.Drawing.Point(929, 29);
            this.StagecoachNameLabel.Name = "StagecoachNameLabel";
            this.StagecoachNameLabel.Size = new System.Drawing.Size(320, 47);
            this.StagecoachNameLabel.TabIndex = 11;
            this.StagecoachNameLabel.Text = "*StagecoachName*";
            // 
            // RationsLabel
            // 
            this.RationsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RationsLabel.AutoSize = true;
            this.RationsLabel.Location = new System.Drawing.Point(929, 180);
            this.RationsLabel.Name = "RationsLabel";
            this.RationsLabel.Size = new System.Drawing.Size(82, 30);
            this.RationsLabel.TabIndex = 13;
            this.RationsLabel.Text = "Rations";
            // 
            // WaterLabel
            // 
            this.WaterLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.WaterLabel.AutoSize = true;
            this.WaterLabel.Location = new System.Drawing.Point(929, 271);
            this.WaterLabel.Name = "WaterLabel";
            this.WaterLabel.Size = new System.Drawing.Size(68, 30);
            this.WaterLabel.TabIndex = 14;
            this.WaterLabel.Text = "Water";
            // 
            // HitPointsLabel
            // 
            this.HitPointsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HitPointsLabel.AutoSize = true;
            this.HitPointsLabel.Location = new System.Drawing.Point(929, 92);
            this.HitPointsLabel.Name = "HitPointsLabel";
            this.HitPointsLabel.Size = new System.Drawing.Size(96, 30);
            this.HitPointsLabel.TabIndex = 15;
            this.HitPointsLabel.Text = "HitPoints";
            // 
            // RefreshButton
            // 
            this.RefreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RefreshButton.Location = new System.Drawing.Point(1119, 375);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(131, 40);
            this.RefreshButton.TabIndex = 16;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // InventoryOverviewList
            // 
            this.InventoryOverviewList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InventoryOverviewList.FormattingEnabled = true;
            this.InventoryOverviewList.ItemHeight = 30;
            this.InventoryOverviewList.Location = new System.Drawing.Point(29, 125);
            this.InventoryOverviewList.Name = "InventoryOverviewList";
            this.InventoryOverviewList.Size = new System.Drawing.Size(736, 394);
            this.InventoryOverviewList.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 30);
            this.label1.TabIndex = 18;
            this.label1.Text = "Inventory";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // StagecoachOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 629);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InventoryOverviewList);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.HitPointsLabel);
            this.Controls.Add(this.WaterLabel);
            this.Controls.Add(this.RationsLabel);
            this.Controls.Add(this.StagecoachNameLabel);
            this.Controls.Add(this.InventoryButton);
            this.Controls.Add(this.StagecoachManageButton);
            this.Controls.Add(this.UpdateStatsButton);
            this.Controls.Add(this.GenerateDbButton);
            this.Controls.Add(this.WaterInput);
            this.Controls.Add(this.RationsInput);
            this.Controls.Add(this.HealthInput);
            this.Controls.Add(this.WaterBar);
            this.Controls.Add(this.RationsBar);
            this.Controls.Add(this.HitPointsBar);
            this.Name = "StagecoachOverview";
            this.Text = "Overview";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar HitPointsBar;
        private System.Windows.Forms.ProgressBar RationsBar;
        private System.Windows.Forms.ProgressBar WaterBar;
        private System.Windows.Forms.TextBox HealthInput;
        private System.Windows.Forms.TextBox RationsInput;
        private System.Windows.Forms.TextBox WaterInput;
        private System.Windows.Forms.Button GenerateDbButton;
        private System.Windows.Forms.Button UpdateStatsButton;
        private System.Windows.Forms.Button StagecoachManageButton;
        private System.Windows.Forms.Button InventoryButton;
        private System.Windows.Forms.Label StagecoachNameLabel;
        private System.Windows.Forms.Label RationsLabel;
        private System.Windows.Forms.Label WaterLabel;
        private System.Windows.Forms.Label HitPointsLabel;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.ListBox InventoryOverviewList;
        private System.Windows.Forms.Label label1;
    }
}

