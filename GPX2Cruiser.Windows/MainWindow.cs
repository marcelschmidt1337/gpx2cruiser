using System;
using System.Windows.Forms;

namespace GPX2Cruiser.Windows
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.Label txt_input_file;
            System.Windows.Forms.Label txt_save_file;
            System.Windows.Forms.Label seperator;
            this.open_file = new System.Windows.Forms.Button();
            this.status_route = new System.Windows.Forms.Label();
            this.status_wp = new System.Windows.Forms.Label();
            this.save_file = new System.Windows.Forms.Button();
            this.option_hw = new System.Windows.Forms.CheckBox();
            this.option_tr = new System.Windows.Forms.CheckBox();
            this.option_fr = new System.Windows.Forms.CheckBox();
            txt_input_file = new System.Windows.Forms.Label();
            txt_save_file = new System.Windows.Forms.Label();
            seperator = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_input_file
            // 
            txt_input_file.AutoSize = true;
            txt_input_file.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txt_input_file.Location = new System.Drawing.Point(12, 23);
            txt_input_file.Name = "txt_input_file";
            txt_input_file.Size = new System.Drawing.Size(117, 31);
            txt_input_file.TabIndex = 0;
            txt_input_file.Text = "Input file";
            // 
            // txt_save_file
            // 
            txt_save_file.AutoSize = true;
            txt_save_file.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txt_save_file.Location = new System.Drawing.Point(308, 23);
            txt_save_file.Name = "txt_save_file";
            txt_save_file.Size = new System.Drawing.Size(138, 31);
            txt_save_file.TabIndex = 4;
            txt_save_file.Text = "Output file";
            // 
            // seperator
            // 
            seperator.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            seperator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            seperator.Location = new System.Drawing.Point(229, 9);
            seperator.Name = "seperator";
            seperator.Size = new System.Drawing.Size(2, 243);
            seperator.TabIndex = 9;
            // 
            // open_file
            // 
            this.open_file.Location = new System.Drawing.Point(18, 72);
            this.open_file.Name = "open_file";
            this.open_file.Size = new System.Drawing.Size(98, 23);
            this.open_file.TabIndex = 1;
            this.open_file.Text = "Open GPX file";
            this.open_file.UseVisualStyleBackColor = true;
            this.open_file.Click += new System.EventHandler(this.OpenFile);
            // 
            // status_route
            // 
            this.status_route.AutoSize = true;
            this.status_route.Enabled = false;
            this.status_route.Location = new System.Drawing.Point(15, 122);
            this.status_route.Name = "status_route";
            this.status_route.Size = new System.Drawing.Size(27, 13);
            this.status_route.TabIndex = 2;
            this.status_route.Text = "N/A";
            // 
            // status_wp
            // 
            this.status_wp.AutoSize = true;
            this.status_wp.Enabled = false;
            this.status_wp.Location = new System.Drawing.Point(15, 145);
            this.status_wp.Name = "status_wp";
            this.status_wp.Size = new System.Drawing.Size(69, 13);
            this.status_wp.TabIndex = 3;
            this.status_wp.Text = "Waypoints: 0";
            // 
            // save_file
            // 
            this.save_file.Enabled = false;
            this.save_file.Location = new System.Drawing.Point(314, 72);
            this.save_file.Name = "save_file";
            this.save_file.Size = new System.Drawing.Size(107, 23);
            this.save_file.TabIndex = 5;
            this.save_file.Text = "Save Cruiser File";
            this.save_file.UseVisualStyleBackColor = true;
            this.save_file.Click += new System.EventHandler(this.SaveFile);
            // 
            // option_hw
            // 
            this.option_hw.AutoSize = true;
            this.option_hw.Enabled = false;
            this.option_hw.Location = new System.Drawing.Point(314, 121);
            this.option_hw.Name = "option_hw";
            this.option_hw.Size = new System.Drawing.Size(102, 17);
            this.option_hw.TabIndex = 6;
            this.option_hw.Text = "Forbid highways";
            this.option_hw.UseVisualStyleBackColor = true;
            // 
            // option_tr
            // 
            this.option_tr.AutoSize = true;
            this.option_tr.Location = new System.Drawing.Point(314, 144);
            this.option_tr.Name = "option_tr";
            this.option_tr.Size = new System.Drawing.Size(100, 17);
            this.option_tr.TabIndex = 7;
            this.option_tr.Text = "Forbid toll roads";
            this.option_tr.UseVisualStyleBackColor = true;
            this.option_tr.CheckedChanged += new System.EventHandler(this.SetSettingsValue);
            // 
            // option_fr
            // 
            this.option_fr.AutoSize = true;
            this.option_fr.Location = new System.Drawing.Point(314, 167);
            this.option_fr.Name = "option_fr";
            this.option_fr.Size = new System.Drawing.Size(86, 17);
            this.option_fr.TabIndex = 8;
            this.option_fr.Text = "Forbid ferries";
            this.option_fr.UseVisualStyleBackColor = true;
            this.option_fr.CheckedChanged += new System.EventHandler(this.SetSettingsValue);
            // 
            // MainWindow
            // 
            this.ClientSize = new System.Drawing.Size(458, 261);
            this.Controls.Add(seperator);
            this.Controls.Add(this.option_fr);
            this.Controls.Add(this.option_tr);
            this.Controls.Add(this.option_hw);
            this.Controls.Add(this.save_file);
            this.Controls.Add(txt_save_file);
            this.Controls.Add(this.status_wp);
            this.Controls.Add(this.status_route);
            this.Controls.Add(this.open_file);
            this.Controls.Add(txt_input_file);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "GPX2Cruiser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void SetSettingsValue(object sender, EventArgs e)
        {
            var cb = sender as CheckBox;

            if (cb.Name == "option_hw")
            {
                throw new NotImplementedException();
            }
            else if (cb.Name == "option_tr")
            {
                Program.GPX2Cruiser.Settings.ForbidTollRoads = cb.Checked;
            }
            else if (cb.Name == "option_fr")
            {
                Program.GPX2Cruiser.Settings.ForbidFerries = cb.Checked;
            }
        }

        private void OpenFile(object sender, EventArgs e)
        {
            var path = IO.ShowOpenFileDialogue();
            if (!string.IsNullOrEmpty(path))
            {
                Program.GPX2Cruiser.OpenFile(path);
            }

            save_file.Enabled = Program.GPX2Cruiser.HasLoadedValidRoute;

            status_route.Enabled = true;
            status_route.Text = Program.GPX2Cruiser.HasLoadedValidRoute ? "Route found!" : "Invalid route!";

            status_wp.Enabled = true;
            status_wp.Text = string.Format("Waypoints: {0}", Program.GPX2Cruiser.LoadedWayPoints);
            status_wp.Visible = Program.GPX2Cruiser.HasLoadedValidRoute;
        }

        private void SaveFile(object sender, EventArgs e)
        {
            var path = IO.ShowSaveFileDialogue(Program.GPX2Cruiser.LoadedFileName);
            if (!string.IsNullOrEmpty(path))
            {
                Program.GPX2Cruiser.Export(path);
            }
        }
    }
}
