
namespace StagecoachApp
{
    partial class StagecoachManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.StagecoachList = new System.Windows.Forms.ListBox();
            this.CreateButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.StagecoachNameBox = new System.Windows.Forms.TextBox();
            this.HitpointsLabel = new System.Windows.Forms.Label();
            this.HitpointsBox = new System.Windows.Forms.TextBox();
            this.RationsLabel = new System.Windows.Forms.Label();
            this.RationsBox = new System.Windows.Forms.TextBox();
            this.WaterLabel = new System.Windows.Forms.Label();
            this.WaterBox = new System.Windows.Forms.TextBox();
            this.HorsesLabel = new System.Windows.Forms.Label();
            this.HorsesBox = new System.Windows.Forms.TextBox();
            this.CrewCountLabel = new System.Windows.Forms.Label();
            this.CrewCountBox = new System.Windows.Forms.TextBox();
            this.MaxHitpointsLabel = new System.Windows.Forms.Label();
            this.MaxHitpointsBox = new System.Windows.Forms.TextBox();
            this.StagecoachNamedLabel = new System.Windows.Forms.Label();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StagecoachList
            // 
            this.StagecoachList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StagecoachList.FormattingEnabled = true;
            this.StagecoachList.ItemHeight = 30;
            this.StagecoachList.Location = new System.Drawing.Point(48, 144);
            this.StagecoachList.Name = "StagecoachList";
            this.StagecoachList.Size = new System.Drawing.Size(575, 304);
            this.StagecoachList.TabIndex = 0;
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(683, 344);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(143, 40);
            this.CreateButton.TabIndex = 1;
            this.CreateButton.Text = "Create";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(878, 344);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(143, 40);
            this.UpdateButton.TabIndex = 2;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            // 
            // StagecoachNameBox
            // 
            this.StagecoachNameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StagecoachNameBox.Location = new System.Drawing.Point(48, 84);
            this.StagecoachNameBox.Name = "StagecoachNameBox";
            this.StagecoachNameBox.Size = new System.Drawing.Size(438, 35);
            this.StagecoachNameBox.TabIndex = 3;
            // 
            // HitpointsLabel
            // 
            this.HitpointsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HitpointsLabel.AutoSize = true;
            this.HitpointsLabel.Location = new System.Drawing.Point(683, 50);
            this.HitpointsLabel.Name = "HitpointsLabel";
            this.HitpointsLabel.Size = new System.Drawing.Size(97, 30);
            this.HitpointsLabel.TabIndex = 7;
            this.HitpointsLabel.Text = "Hitpoints";
            this.HitpointsLabel.Click += new System.EventHandler(this.HitpointsLabel_Click);
            // 
            // HitpointsBox
            // 
            this.HitpointsBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HitpointsBox.Location = new System.Drawing.Point(683, 83);
            this.HitpointsBox.Name = "HitpointsBox";
            this.HitpointsBox.Size = new System.Drawing.Size(143, 35);
            this.HitpointsBox.TabIndex = 6;
            this.HitpointsBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // RationsLabel
            // 
            this.RationsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RationsLabel.AutoSize = true;
            this.RationsLabel.Location = new System.Drawing.Point(683, 150);
            this.RationsLabel.Name = "RationsLabel";
            this.RationsLabel.Size = new System.Drawing.Size(82, 30);
            this.RationsLabel.TabIndex = 9;
            this.RationsLabel.Text = "Rations";
            this.RationsLabel.Click += new System.EventHandler(this.RationsLabel_Click);
            // 
            // RationsBox
            // 
            this.RationsBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RationsBox.Location = new System.Drawing.Point(683, 183);
            this.RationsBox.Name = "RationsBox";
            this.RationsBox.Size = new System.Drawing.Size(143, 35);
            this.RationsBox.TabIndex = 8;
            this.RationsBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // WaterLabel
            // 
            this.WaterLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.WaterLabel.AutoSize = true;
            this.WaterLabel.Location = new System.Drawing.Point(878, 150);
            this.WaterLabel.Name = "WaterLabel";
            this.WaterLabel.Size = new System.Drawing.Size(68, 30);
            this.WaterLabel.TabIndex = 11;
            this.WaterLabel.Text = "Water";
            this.WaterLabel.Click += new System.EventHandler(this.WaterLabel_Click);
            // 
            // WaterBox
            // 
            this.WaterBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.WaterBox.Location = new System.Drawing.Point(878, 183);
            this.WaterBox.Name = "WaterBox";
            this.WaterBox.Size = new System.Drawing.Size(143, 35);
            this.WaterBox.TabIndex = 10;
            this.WaterBox.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // HorsesLabel
            // 
            this.HorsesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HorsesLabel.AutoSize = true;
            this.HorsesLabel.Location = new System.Drawing.Point(683, 247);
            this.HorsesLabel.Name = "HorsesLabel";
            this.HorsesLabel.Size = new System.Drawing.Size(76, 30);
            this.HorsesLabel.TabIndex = 13;
            this.HorsesLabel.Text = "Horses";
            this.HorsesLabel.Click += new System.EventHandler(this.HorsesLabel_Click);
            // 
            // HorsesBox
            // 
            this.HorsesBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HorsesBox.Location = new System.Drawing.Point(683, 280);
            this.HorsesBox.Name = "HorsesBox";
            this.HorsesBox.Size = new System.Drawing.Size(143, 35);
            this.HorsesBox.TabIndex = 12;
            this.HorsesBox.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // CrewCountLabel
            // 
            this.CrewCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CrewCountLabel.AutoSize = true;
            this.CrewCountLabel.Location = new System.Drawing.Point(878, 247);
            this.CrewCountLabel.Name = "CrewCountLabel";
            this.CrewCountLabel.Size = new System.Drawing.Size(59, 30);
            this.CrewCountLabel.TabIndex = 21;
            this.CrewCountLabel.Text = "Crew";
            this.CrewCountLabel.Click += new System.EventHandler(this.CrewCountLabel_Click);
            // 
            // CrewCountBox
            // 
            this.CrewCountBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CrewCountBox.Location = new System.Drawing.Point(878, 280);
            this.CrewCountBox.Name = "CrewCountBox";
            this.CrewCountBox.Size = new System.Drawing.Size(143, 35);
            this.CrewCountBox.TabIndex = 20;
            // 
            // MaxHitpointsLabel
            // 
            this.MaxHitpointsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaxHitpointsLabel.AutoSize = true;
            this.MaxHitpointsLabel.Location = new System.Drawing.Point(878, 50);
            this.MaxHitpointsLabel.Name = "MaxHitpointsLabel";
            this.MaxHitpointsLabel.Size = new System.Drawing.Size(143, 30);
            this.MaxHitpointsLabel.TabIndex = 15;
            this.MaxHitpointsLabel.Text = "Max Hitpoints";
            // 
            // MaxHitpointsBox
            // 
            this.MaxHitpointsBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaxHitpointsBox.Location = new System.Drawing.Point(878, 83);
            this.MaxHitpointsBox.Name = "MaxHitpointsBox";
            this.MaxHitpointsBox.Size = new System.Drawing.Size(143, 35);
            this.MaxHitpointsBox.TabIndex = 14;
            // 
            // StagecoachNamedLabel
            // 
            this.StagecoachNamedLabel.AutoSize = true;
            this.StagecoachNamedLabel.Location = new System.Drawing.Point(48, 51);
            this.StagecoachNamedLabel.Name = "StagecoachNamedLabel";
            this.StagecoachNamedLabel.Size = new System.Drawing.Size(181, 30);
            this.StagecoachNamedLabel.TabIndex = 22;
            this.StagecoachNamedLabel.Text = "Stagecoach Name";
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(683, 407);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(143, 40);
            this.RemoveButton.TabIndex = 23;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(878, 407);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(143, 40);
            this.BackButton.TabIndex = 24;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(492, 83);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(131, 36);
            this.RefreshButton.TabIndex = 25;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // StagecoachManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 598);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.StagecoachNamedLabel);
            this.Controls.Add(this.CrewCountLabel);
            this.Controls.Add(this.CrewCountBox);
            this.Controls.Add(this.MaxHitpointsLabel);
            this.Controls.Add(this.MaxHitpointsBox);
            this.Controls.Add(this.HorsesLabel);
            this.Controls.Add(this.HorsesBox);
            this.Controls.Add(this.WaterLabel);
            this.Controls.Add(this.WaterBox);
            this.Controls.Add(this.RationsLabel);
            this.Controls.Add(this.RationsBox);
            this.Controls.Add(this.HitpointsLabel);
            this.Controls.Add(this.HitpointsBox);
            this.Controls.Add(this.StagecoachNameBox);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.StagecoachList);
            this.Name = "StagecoachManager";
            this.Text = "StagecoachManager";
            this.Load += new System.EventHandler(this.StagecoachManager_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox StagecoachList;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.TextBox StagecoachNameBox;
        private System.Windows.Forms.Label HitpointsLabel;
        private System.Windows.Forms.TextBox HitpointsBox;
        private System.Windows.Forms.Label RationsLabel;
        private System.Windows.Forms.TextBox RationsBox;
        private System.Windows.Forms.Label WaterLabel;
        private System.Windows.Forms.TextBox WaterBox;
        private System.Windows.Forms.Label HorsesLabel;
        private System.Windows.Forms.TextBox HorsesBox;
        private System.Windows.Forms.Label CrewCountLabel;
        private System.Windows.Forms.TextBox CrewCountBox;
        private System.Windows.Forms.Label MaxHitpointsLabel;
        private System.Windows.Forms.TextBox MaxHitpointsBox;
        private System.Windows.Forms.Label StagecoachNamedLabel;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button RefreshButton;
    }
}