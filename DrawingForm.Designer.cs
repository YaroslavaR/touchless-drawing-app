namespace TouchlessDemo
{
    partial class DrawingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DrawingForm));
            this.pictureBoxDisplay = new System.Windows.Forms.PictureBox();
            this.radioButtonCamera = new System.Windows.Forms.RadioButton();
            this.radioButtonMarkers = new System.Windows.Forms.RadioButton();
            this.radioButtonDemo = new System.Windows.Forms.RadioButton();
            this.groupBoxDemo = new System.Windows.Forms.GroupBox();
            this.labelDemoInstructions = new System.Windows.Forms.RichTextBox();
            this.buttonDefendDemo = new System.Windows.Forms.Button();
            this.buttonImageDemo = new System.Windows.Forms.Button();
            this.buttonSnakeDemo = new System.Windows.Forms.Button();
            this.buttonDrawDemo = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.linkLabelHomepage = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxCameras = new System.Windows.Forms.ComboBox();
            this.groupBoxCameraInfo = new System.Windows.Forms.GroupBox();
            this.checkBoxCameraFPSLimit = new System.Windows.Forms.CheckBox();
            this.labelCameraFPSValue = new System.Windows.Forms.Label();
            this.numericUpDownCameraFPSLimit = new System.Windows.Forms.NumericUpDown();
            this.labelCameraFPS = new System.Windows.Forms.Label();
            this.buttonCameraProperties = new System.Windows.Forms.Button();
            this.groupBoxCamera = new System.Windows.Forms.GroupBox();
            this.buttonMarkerAdd = new System.Windows.Forms.Button();
            this.comboBoxMarkers = new System.Windows.Forms.ComboBox();
            this.groupBoxMarkerControl = new System.Windows.Forms.GroupBox();
            this.numericUpDownMarkerThresh = new System.Windows.Forms.NumericUpDown();
            this.labelMarkerThresh = new System.Windows.Forms.Label();
            this.checkBoxMarkerSmoothing = new System.Windows.Forms.CheckBox();
            this.checkBoxMarkerHighlight = new System.Windows.Forms.CheckBox();
            this.labelMarkerData = new System.Windows.Forms.RichTextBox();
            this.buttonMarkerRemove = new System.Windows.Forms.Button();
            this.groupBoxMarkers = new System.Windows.Forms.GroupBox();
            this.pictureBoxBackground = new System.Windows.Forms.PictureBox();
            this.buttonSaveImage = new System.Windows.Forms.Button();
            this.checkBoxUseCamera = new System.Windows.Forms.CheckBox();
            this.buttonLoadImage = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.checkBoxUseLoadImage = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDisplay)).BeginInit();
            this.groupBoxDemo.SuspendLayout();
            this.groupBoxCameraInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCameraFPSLimit)).BeginInit();
            this.groupBoxCamera.SuspendLayout();
            this.groupBoxMarkerControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMarkerThresh)).BeginInit();
            this.groupBoxMarkers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxDisplay
            // 
            this.pictureBoxDisplay.BackColor = System.Drawing.Color.DimGray;
            this.pictureBoxDisplay.Location = new System.Drawing.Point(60, 200);
            this.pictureBoxDisplay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxDisplay.Name = "pictureBoxDisplay";
            this.pictureBoxDisplay.Size = new System.Drawing.Size(1266, 648);
            this.pictureBoxDisplay.TabIndex = 19;
            this.pictureBoxDisplay.TabStop = false;
            this.pictureBoxDisplay.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxDisplay_MouseDown);
            this.pictureBoxDisplay.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxDisplay_MouseMove);
            this.pictureBoxDisplay.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxDisplay_MouseUp);
            // 
            // radioButtonCamera
            // 
            this.radioButtonCamera.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonCamera.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonCamera.Location = new System.Drawing.Point(16, 15);
            this.radioButtonCamera.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonCamera.Name = "radioButtonCamera";
            this.radioButtonCamera.Size = new System.Drawing.Size(1, 1);
            this.radioButtonCamera.TabIndex = 21;
            this.radioButtonCamera.TabStop = true;
            this.radioButtonCamera.Text = "Camera";
            this.radioButtonCamera.UseVisualStyleBackColor = true;
            this.radioButtonCamera.Visible = false;
            this.radioButtonCamera.CheckedChanged += new System.EventHandler(this.radioButtonMode_CheckedChanged);
            // 
            // radioButtonMarkers
            // 
            this.radioButtonMarkers.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonMarkers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(129)))), ((int)(((byte)(171)))));
            this.radioButtonMarkers.Enabled = false;
            this.radioButtonMarkers.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMarkers.ForeColor = System.Drawing.Color.White;
            this.radioButtonMarkers.Location = new System.Drawing.Point(71, 29);
            this.radioButtonMarkers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonMarkers.Name = "radioButtonMarkers";
            this.radioButtonMarkers.Size = new System.Drawing.Size(151, 45);
            this.radioButtonMarkers.TabIndex = 22;
            this.radioButtonMarkers.Text = "Markers";
            this.radioButtonMarkers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonMarkers.UseVisualStyleBackColor = false;
            this.radioButtonMarkers.Visible = false;
            this.radioButtonMarkers.CheckedChanged += new System.EventHandler(this.radioButtonMode_CheckedChanged);
            // 
            // radioButtonDemo
            // 
            this.radioButtonDemo.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonDemo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(129)))), ((int)(((byte)(171)))));
            this.radioButtonDemo.Enabled = false;
            this.radioButtonDemo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.radioButtonDemo.ForeColor = System.Drawing.Color.White;
            this.radioButtonDemo.Location = new System.Drawing.Point(71, 28);
            this.radioButtonDemo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonDemo.Name = "radioButtonDemo";
            this.radioButtonDemo.Size = new System.Drawing.Size(220, 45);
            this.radioButtonDemo.TabIndex = 23;
            this.radioButtonDemo.Text = "Show canvas";
            this.radioButtonDemo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonDemo.UseVisualStyleBackColor = false;
            this.radioButtonDemo.Visible = false;
            this.radioButtonDemo.CheckedChanged += new System.EventHandler(this.radioButtonMode_CheckedChanged);
            // 
            // groupBoxDemo
            // 
            this.groupBoxDemo.Controls.Add(this.labelDemoInstructions);
            this.groupBoxDemo.Controls.Add(this.buttonDefendDemo);
            this.groupBoxDemo.Controls.Add(this.buttonImageDemo);
            this.groupBoxDemo.Controls.Add(this.buttonSnakeDemo);
            this.groupBoxDemo.Location = new System.Drawing.Point(209, 82);
            this.groupBoxDemo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxDemo.Name = "groupBoxDemo";
            this.groupBoxDemo.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxDemo.Size = new System.Drawing.Size(427, 480);
            this.groupBoxDemo.TabIndex = 26;
            this.groupBoxDemo.TabStop = false;
            this.groupBoxDemo.Text = "Demo Mode Instructions";
            this.groupBoxDemo.Visible = false;
            // 
            // labelDemoInstructions
            // 
            this.labelDemoInstructions.BackColor = System.Drawing.SystemColors.Control;
            this.labelDemoInstructions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDemoInstructions.Enabled = false;
            this.labelDemoInstructions.Location = new System.Drawing.Point(8, 133);
            this.labelDemoInstructions.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelDemoInstructions.Name = "labelDemoInstructions";
            this.labelDemoInstructions.ReadOnly = true;
            this.labelDemoInstructions.Size = new System.Drawing.Size(409, 339);
            this.labelDemoInstructions.TabIndex = 24;
            this.labelDemoInstructions.Text = "";
            // 
            // buttonDefendDemo
            // 
            this.buttonDefendDemo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonDefendDemo.Location = new System.Drawing.Point(219, 77);
            this.buttonDefendDemo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDefendDemo.Name = "buttonDefendDemo";
            this.buttonDefendDemo.Size = new System.Drawing.Size(200, 47);
            this.buttonDefendDemo.TabIndex = 23;
            this.buttonDefendDemo.Text = "Start Defend Demo";
            this.buttonDefendDemo.UseVisualStyleBackColor = true;
            this.buttonDefendDemo.Visible = false;
            this.buttonDefendDemo.Click += new System.EventHandler(this.buttonDefendDemo_Click);
            // 
            // buttonImageDemo
            // 
            this.buttonImageDemo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonImageDemo.Location = new System.Drawing.Point(219, 24);
            this.buttonImageDemo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonImageDemo.Name = "buttonImageDemo";
            this.buttonImageDemo.Size = new System.Drawing.Size(200, 47);
            this.buttonImageDemo.TabIndex = 22;
            this.buttonImageDemo.Text = "Start Image Demo";
            this.buttonImageDemo.UseVisualStyleBackColor = true;
            this.buttonImageDemo.Visible = false;
            this.buttonImageDemo.Click += new System.EventHandler(this.buttonImageDemo_Click);
            // 
            // buttonSnakeDemo
            // 
            this.buttonSnakeDemo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonSnakeDemo.Location = new System.Drawing.Point(8, 77);
            this.buttonSnakeDemo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSnakeDemo.Name = "buttonSnakeDemo";
            this.buttonSnakeDemo.Size = new System.Drawing.Size(200, 47);
            this.buttonSnakeDemo.TabIndex = 21;
            this.buttonSnakeDemo.Text = "Start Snake Demo";
            this.buttonSnakeDemo.UseVisualStyleBackColor = true;
            this.buttonSnakeDemo.Visible = false;
            this.buttonSnakeDemo.Click += new System.EventHandler(this.buttonSnakeDemo_Click);
            // 
            // buttonDrawDemo
            // 
            this.buttonDrawDemo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(232)))), ((int)(((byte)(134)))));
            this.buttonDrawDemo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDrawDemo.ForeColor = System.Drawing.Color.White;
            this.buttonDrawDemo.Location = new System.Drawing.Point(247, 28);
            this.buttonDrawDemo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDrawDemo.Name = "buttonDrawDemo";
            this.buttonDrawDemo.Size = new System.Drawing.Size(200, 45);
            this.buttonDrawDemo.TabIndex = 21;
            this.buttonDrawDemo.Text = "Start Drawing";
            this.buttonDrawDemo.UseVisualStyleBackColor = false;
            this.buttonDrawDemo.Visible = false;
            this.buttonDrawDemo.Click += new System.EventHandler(this.buttonDrawDemo_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(255)))), ((int)(((byte)(113)))));
            this.buttonHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHelp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(123)))), ((int)(((byte)(232)))));
            this.buttonHelp.Location = new System.Drawing.Point(60, 856);
            this.buttonHelp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(196, 39);
            this.buttonHelp.TabIndex = 27;
            this.buttonHelp.Text = "Help!";
            this.buttonHelp.UseVisualStyleBackColor = false;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Enabled = false;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonBack.Location = new System.Drawing.Point(257, 550);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(100, 45);
            this.buttonBack.TabIndex = 28;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Visible = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Enabled = false;
            this.buttonNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonNext.Location = new System.Drawing.Point(1140, 560);
            this.buttonNext.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(100, 45);
            this.buttonNext.TabIndex = 29;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Visible = false;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // linkLabelHomepage
            // 
            this.linkLabelHomepage.AutoSize = true;
            this.linkLabelHomepage.Location = new System.Drawing.Point(57, 899);
            this.linkLabelHomepage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabelHomepage.Name = "linkLabelHomepage";
            this.linkLabelHomepage.Size = new System.Drawing.Size(189, 17);
            this.linkLabelHomepage.TabIndex = 30;
            this.linkLabelHomepage.TabStop = true;
            this.linkLabelHomepage.Text = "www.codeplex.com/touchless";
            this.linkLabelHomepage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelHomepage_LinkClicked);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1003, 575);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 35);
            this.button1.TabIndex = 31;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxCameras
            // 
            this.comboBoxCameras.FormattingEnabled = true;
            this.comboBoxCameras.Location = new System.Drawing.Point(13, 24);
            this.comboBoxCameras.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxCameras.Name = "comboBoxCameras";
            this.comboBoxCameras.Size = new System.Drawing.Size(404, 24);
            this.comboBoxCameras.TabIndex = 14;
            this.comboBoxCameras.Text = "Select A Camera";
            this.comboBoxCameras.DropDown += new System.EventHandler(this.comboBoxCameras_DropDown);
            this.comboBoxCameras.SelectedIndexChanged += new System.EventHandler(this.comboBoxCameras_SelectedIndexChanged);
            // 
            // groupBoxCameraInfo
            // 
            this.groupBoxCameraInfo.Controls.Add(this.checkBoxCameraFPSLimit);
            this.groupBoxCameraInfo.Controls.Add(this.labelCameraFPSValue);
            this.groupBoxCameraInfo.Controls.Add(this.numericUpDownCameraFPSLimit);
            this.groupBoxCameraInfo.Controls.Add(this.labelCameraFPS);
            this.groupBoxCameraInfo.Controls.Add(this.buttonCameraProperties);
            this.groupBoxCameraInfo.Enabled = false;
            this.groupBoxCameraInfo.Location = new System.Drawing.Point(12, 59);
            this.groupBoxCameraInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxCameraInfo.Name = "groupBoxCameraInfo";
            this.groupBoxCameraInfo.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxCameraInfo.Size = new System.Drawing.Size(407, 122);
            this.groupBoxCameraInfo.TabIndex = 20;
            this.groupBoxCameraInfo.TabStop = false;
            this.groupBoxCameraInfo.Text = "No Camera Selected";
            // 
            // checkBoxCameraFPSLimit
            // 
            this.checkBoxCameraFPSLimit.AutoSize = true;
            this.checkBoxCameraFPSLimit.Location = new System.Drawing.Point(12, 86);
            this.checkBoxCameraFPSLimit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxCameraFPSLimit.Name = "checkBoxCameraFPSLimit";
            this.checkBoxCameraFPSLimit.Size = new System.Drawing.Size(188, 21);
            this.checkBoxCameraFPSLimit.TabIndex = 21;
            this.checkBoxCameraFPSLimit.Text = "Limit Frames Per Second";
            this.checkBoxCameraFPSLimit.UseVisualStyleBackColor = true;
            this.checkBoxCameraFPSLimit.CheckedChanged += new System.EventHandler(this.checkBoxCameraFPSLimit_CheckedChanged);
            // 
            // labelCameraFPSValue
            // 
            this.labelCameraFPSValue.AutoSize = true;
            this.labelCameraFPSValue.Location = new System.Drawing.Point(204, 60);
            this.labelCameraFPSValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCameraFPSValue.Name = "labelCameraFPSValue";
            this.labelCameraFPSValue.Size = new System.Drawing.Size(36, 17);
            this.labelCameraFPSValue.TabIndex = 20;
            this.labelCameraFPSValue.Text = "0.00";
            // 
            // numericUpDownCameraFPSLimit
            // 
            this.numericUpDownCameraFPSLimit.Enabled = false;
            this.numericUpDownCameraFPSLimit.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownCameraFPSLimit.Location = new System.Drawing.Point(208, 84);
            this.numericUpDownCameraFPSLimit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDownCameraFPSLimit.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDownCameraFPSLimit.Name = "numericUpDownCameraFPSLimit";
            this.numericUpDownCameraFPSLimit.Size = new System.Drawing.Size(67, 22);
            this.numericUpDownCameraFPSLimit.TabIndex = 19;
            this.numericUpDownCameraFPSLimit.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDownCameraFPSLimit.Visible = false;
            this.numericUpDownCameraFPSLimit.ValueChanged += new System.EventHandler(this.numericUpDownCameraFPSLimit_ValueChanged);
            // 
            // labelCameraFPS
            // 
            this.labelCameraFPS.AutoSize = true;
            this.labelCameraFPS.Location = new System.Drawing.Point(8, 60);
            this.labelCameraFPS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCameraFPS.Name = "labelCameraFPS";
            this.labelCameraFPS.Size = new System.Drawing.Size(188, 17);
            this.labelCameraFPS.TabIndex = 0;
            this.labelCameraFPS.Text = "Current Frames Per Second:";
            // 
            // buttonCameraProperties
            // 
            this.buttonCameraProperties.Location = new System.Drawing.Point(12, 24);
            this.buttonCameraProperties.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCameraProperties.Name = "buttonCameraProperties";
            this.buttonCameraProperties.Size = new System.Drawing.Size(183, 28);
            this.buttonCameraProperties.TabIndex = 17;
            this.buttonCameraProperties.Text = "Adjust Camera Properties";
            this.buttonCameraProperties.UseVisualStyleBackColor = true;
            this.buttonCameraProperties.Click += new System.EventHandler(this.buttonCameraProperties_Click);
            // 
            // groupBoxCamera
            // 
            this.groupBoxCamera.Controls.Add(this.groupBoxCameraInfo);
            this.groupBoxCamera.Controls.Add(this.comboBoxCameras);
            this.groupBoxCamera.Location = new System.Drawing.Point(130, 309);
            this.groupBoxCamera.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxCamera.Name = "groupBoxCamera";
            this.groupBoxCamera.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxCamera.Size = new System.Drawing.Size(427, 196);
            this.groupBoxCamera.TabIndex = 20;
            this.groupBoxCamera.TabStop = false;
            this.groupBoxCamera.Text = "Camera Settings";
            this.groupBoxCamera.Visible = false;
            // 
            // buttonMarkerAdd
            // 
            this.buttonMarkerAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(232)))), ((int)(((byte)(134)))));
            this.buttonMarkerAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMarkerAdd.ForeColor = System.Drawing.Color.White;
            this.buttonMarkerAdd.Location = new System.Drawing.Point(310, 26);
            this.buttonMarkerAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonMarkerAdd.Name = "buttonMarkerAdd";
            this.buttonMarkerAdd.Size = new System.Drawing.Size(225, 45);
            this.buttonMarkerAdd.TabIndex = 19;
            this.buttonMarkerAdd.Text = "Add A New Marker";
            this.buttonMarkerAdd.UseVisualStyleBackColor = false;
            this.buttonMarkerAdd.Click += new System.EventHandler(this.buttonMarkerAdd_Click);
            // 
            // comboBoxMarkers
            // 
            this.comboBoxMarkers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(123)))), ((int)(((byte)(232)))));
            this.comboBoxMarkers.Enabled = false;
            this.comboBoxMarkers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMarkers.ForeColor = System.Drawing.Color.White;
            this.comboBoxMarkers.FormattingEnabled = true;
            this.comboBoxMarkers.Location = new System.Drawing.Point(554, 38);
            this.comboBoxMarkers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxMarkers.Name = "comboBoxMarkers";
            this.comboBoxMarkers.Size = new System.Drawing.Size(218, 28);
            this.comboBoxMarkers.TabIndex = 22;
            this.comboBoxMarkers.Text = "Edit An Existing Marker";
            this.comboBoxMarkers.DropDown += new System.EventHandler(this.comboBoxMarkers_DropDown);
            this.comboBoxMarkers.SelectedIndexChanged += new System.EventHandler(this.comboBoxMarkers_SelectedIndexChanged);
            // 
            // groupBoxMarkerControl
            // 
            this.groupBoxMarkerControl.Controls.Add(this.numericUpDownMarkerThresh);
            this.groupBoxMarkerControl.Controls.Add(this.labelMarkerThresh);
            this.groupBoxMarkerControl.Controls.Add(this.checkBoxMarkerSmoothing);
            this.groupBoxMarkerControl.Controls.Add(this.checkBoxMarkerHighlight);
            this.groupBoxMarkerControl.Controls.Add(this.labelMarkerData);
            this.groupBoxMarkerControl.Enabled = false;
            this.groupBoxMarkerControl.Location = new System.Drawing.Point(13, 59);
            this.groupBoxMarkerControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxMarkerControl.Name = "groupBoxMarkerControl";
            this.groupBoxMarkerControl.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxMarkerControl.Size = new System.Drawing.Size(405, 266);
            this.groupBoxMarkerControl.TabIndex = 25;
            this.groupBoxMarkerControl.TabStop = false;
            this.groupBoxMarkerControl.Text = "No Marker Selected";
            // 
            // numericUpDownMarkerThresh
            // 
            this.numericUpDownMarkerThresh.Location = new System.Drawing.Point(335, 54);
            this.numericUpDownMarkerThresh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDownMarkerThresh.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownMarkerThresh.Name = "numericUpDownMarkerThresh";
            this.numericUpDownMarkerThresh.Size = new System.Drawing.Size(63, 22);
            this.numericUpDownMarkerThresh.TabIndex = 5;
            this.numericUpDownMarkerThresh.ValueChanged += new System.EventHandler(this.numericUpDownMarkerThresh_ValueChanged);
            // 
            // labelMarkerThresh
            // 
            this.labelMarkerThresh.AutoSize = true;
            this.labelMarkerThresh.Location = new System.Drawing.Point(203, 56);
            this.labelMarkerThresh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMarkerThresh.Name = "labelMarkerThresh";
            this.labelMarkerThresh.Size = new System.Drawing.Size(124, 17);
            this.labelMarkerThresh.TabIndex = 4;
            this.labelMarkerThresh.Text = "Marker Threshold:";
            // 
            // checkBoxMarkerSmoothing
            // 
            this.checkBoxMarkerSmoothing.AutoSize = true;
            this.checkBoxMarkerSmoothing.Checked = true;
            this.checkBoxMarkerSmoothing.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxMarkerSmoothing.Location = new System.Drawing.Point(8, 56);
            this.checkBoxMarkerSmoothing.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxMarkerSmoothing.Name = "checkBoxMarkerSmoothing";
            this.checkBoxMarkerSmoothing.Size = new System.Drawing.Size(160, 21);
            this.checkBoxMarkerSmoothing.TabIndex = 3;
            this.checkBoxMarkerSmoothing.Text = "Smooth Marker Data";
            this.checkBoxMarkerSmoothing.UseVisualStyleBackColor = true;
            this.checkBoxMarkerSmoothing.CheckedChanged += new System.EventHandler(this.checkBoxMarkerSmoothing_CheckedChanged);
            // 
            // checkBoxMarkerHighlight
            // 
            this.checkBoxMarkerHighlight.AutoSize = true;
            this.checkBoxMarkerHighlight.Checked = true;
            this.checkBoxMarkerHighlight.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxMarkerHighlight.Location = new System.Drawing.Point(7, 24);
            this.checkBoxMarkerHighlight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxMarkerHighlight.Name = "checkBoxMarkerHighlight";
            this.checkBoxMarkerHighlight.Size = new System.Drawing.Size(133, 21);
            this.checkBoxMarkerHighlight.TabIndex = 2;
            this.checkBoxMarkerHighlight.Text = "Highlight Marker";
            this.checkBoxMarkerHighlight.UseVisualStyleBackColor = true;
            this.checkBoxMarkerHighlight.CheckedChanged += new System.EventHandler(this.checkBoxMarkerHighlight_CheckedChanged);
            // 
            // labelMarkerData
            // 
            this.labelMarkerData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMarkerData.Location = new System.Drawing.Point(9, 86);
            this.labelMarkerData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelMarkerData.Name = "labelMarkerData";
            this.labelMarkerData.ReadOnly = true;
            this.labelMarkerData.Size = new System.Drawing.Size(387, 172);
            this.labelMarkerData.TabIndex = 1;
            this.labelMarkerData.Text = "";
            // 
            // buttonMarkerRemove
            // 
            this.buttonMarkerRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(232)))), ((int)(((byte)(134)))));
            this.buttonMarkerRemove.Enabled = false;
            this.buttonMarkerRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonMarkerRemove.ForeColor = System.Drawing.Color.White;
            this.buttonMarkerRemove.Location = new System.Drawing.Point(793, 28);
            this.buttonMarkerRemove.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonMarkerRemove.Name = "buttonMarkerRemove";
            this.buttonMarkerRemove.Size = new System.Drawing.Size(225, 45);
            this.buttonMarkerRemove.TabIndex = 0;
            this.buttonMarkerRemove.Text = "Remove This Marker";
            this.buttonMarkerRemove.UseVisualStyleBackColor = false;
            this.buttonMarkerRemove.Click += new System.EventHandler(this.buttonMarkerRemove_Click);
            // 
            // groupBoxMarkers
            // 
            this.groupBoxMarkers.Controls.Add(this.groupBoxMarkerControl);
            this.groupBoxMarkers.Location = new System.Drawing.Point(164, 215);
            this.groupBoxMarkers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxMarkers.Name = "groupBoxMarkers";
            this.groupBoxMarkers.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxMarkers.Size = new System.Drawing.Size(427, 322);
            this.groupBoxMarkers.TabIndex = 21;
            this.groupBoxMarkers.TabStop = false;
            this.groupBoxMarkers.Visible = false;
            // 
            // pictureBoxBackground
            // 
            this.pictureBoxBackground.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxBackground.BackgroundImage")));
            this.pictureBoxBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxBackground.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxBackground.InitialImage")));
            this.pictureBoxBackground.Location = new System.Drawing.Point(29, 72);
            this.pictureBoxBackground.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxBackground.Name = "pictureBoxBackground";
            this.pictureBoxBackground.Size = new System.Drawing.Size(1333, 778);
            this.pictureBoxBackground.TabIndex = 32;
            this.pictureBoxBackground.TabStop = false;
            // 
            // buttonSaveImage
            // 
            this.buttonSaveImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(123)))), ((int)(((byte)(232)))));
            this.buttonSaveImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold);
            this.buttonSaveImage.ForeColor = System.Drawing.Color.White;
            this.buttonSaveImage.Location = new System.Drawing.Point(453, 26);
            this.buttonSaveImage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSaveImage.Name = "buttonSaveImage";
            this.buttonSaveImage.Size = new System.Drawing.Size(111, 45);
            this.buttonSaveImage.TabIndex = 33;
            this.buttonSaveImage.Text = "Save";
            this.buttonSaveImage.UseVisualStyleBackColor = false;
            this.buttonSaveImage.Visible = false;
            this.buttonSaveImage.Click += new System.EventHandler(this.buttonSaveImage_Click);
            // 
            // checkBoxUseCamera
            // 
            this.checkBoxUseCamera.AutoSize = true;
            this.checkBoxUseCamera.Checked = true;
            this.checkBoxUseCamera.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxUseCamera.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.checkBoxUseCamera.ForeColor = System.Drawing.Color.White;
            this.checkBoxUseCamera.Location = new System.Drawing.Point(701, 28);
            this.checkBoxUseCamera.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxUseCamera.Name = "checkBoxUseCamera";
            this.checkBoxUseCamera.Size = new System.Drawing.Size(232, 28);
            this.checkBoxUseCamera.TabIndex = 34;
            this.checkBoxUseCamera.Text = "Use image from camera";
            this.checkBoxUseCamera.UseVisualStyleBackColor = true;
            this.checkBoxUseCamera.Visible = false;
            // 
            // buttonLoadImage
            // 
            this.buttonLoadImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(123)))), ((int)(((byte)(232)))));
            this.buttonLoadImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold);
            this.buttonLoadImage.ForeColor = System.Drawing.Color.White;
            this.buttonLoadImage.Location = new System.Drawing.Point(576, 26);
            this.buttonLoadImage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonLoadImage.Name = "buttonLoadImage";
            this.buttonLoadImage.Size = new System.Drawing.Size(111, 45);
            this.buttonLoadImage.TabIndex = 35;
            this.buttonLoadImage.Text = "Load";
            this.buttonLoadImage.UseVisualStyleBackColor = false;
            this.buttonLoadImage.Visible = false;
            this.buttonLoadImage.Click += new System.EventHandler(this.buttonLoadImage_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // checkBoxUseLoadImage
            // 
            this.checkBoxUseLoadImage.AutoSize = true;
            this.checkBoxUseLoadImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxUseLoadImage.ForeColor = System.Drawing.Color.White;
            this.checkBoxUseLoadImage.Location = new System.Drawing.Point(701, 51);
            this.checkBoxUseLoadImage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxUseLoadImage.Name = "checkBoxUseLoadImage";
            this.checkBoxUseLoadImage.Size = new System.Drawing.Size(185, 28);
            this.checkBoxUseLoadImage.TabIndex = 36;
            this.checkBoxUseLoadImage.Text = "Use loaded image";
            this.checkBoxUseLoadImage.UseVisualStyleBackColor = true;
            this.checkBoxUseLoadImage.Visible = false;
            // 
            // DrawingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(203)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1276, 669);
            this.Controls.Add(this.checkBoxUseLoadImage);
            this.Controls.Add(this.buttonLoadImage);
            this.Controls.Add(this.checkBoxUseCamera);
            this.Controls.Add(this.buttonSaveImage);
            this.Controls.Add(this.pictureBoxDisplay);
            this.Controls.Add(this.pictureBoxBackground);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxMarkers);
            this.Controls.Add(this.linkLabelHomepage);
            this.Controls.Add(this.buttonMarkerAdd);
            this.Controls.Add(this.buttonDrawDemo);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonMarkerRemove);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.radioButtonDemo);
            this.Controls.Add(this.radioButtonCamera);
            this.Controls.Add(this.radioButtonMarkers);
            this.Controls.Add(this.groupBoxMarkers);
            this.Controls.Add(this.groupBoxCamera);
            this.Controls.Add(this.groupBoxDemo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "DrawingForm";
            this.Text = "Touchless Demo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TouchlessDemo_FormClosing);
            this.Load += new System.EventHandler(this.TouchlessDemo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDisplay)).EndInit();
            this.groupBoxDemo.ResumeLayout(false);
            this.groupBoxCameraInfo.ResumeLayout(false);
            this.groupBoxCameraInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCameraFPSLimit)).EndInit();
            this.groupBoxCamera.ResumeLayout(false);
            this.groupBoxMarkerControl.ResumeLayout(false);
            this.groupBoxMarkerControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMarkerThresh)).EndInit();
            this.groupBoxMarkers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxDisplay;
        private System.Windows.Forms.RadioButton radioButtonCamera;
        private System.Windows.Forms.RadioButton radioButtonMarkers;
        private System.Windows.Forms.RadioButton radioButtonDemo;
        private System.Windows.Forms.GroupBox groupBoxDemo;
        private System.Windows.Forms.Button buttonDrawDemo;
        private System.Windows.Forms.Button buttonSnakeDemo;
        private System.Windows.Forms.Button buttonImageDemo;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonDefendDemo;
        private System.Windows.Forms.RichTextBox labelDemoInstructions;
        private System.Windows.Forms.LinkLabel linkLabelHomepage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxCameras;
        private System.Windows.Forms.GroupBox groupBoxCameraInfo;
        private System.Windows.Forms.CheckBox checkBoxCameraFPSLimit;
        private System.Windows.Forms.Label labelCameraFPSValue;
        private System.Windows.Forms.NumericUpDown numericUpDownCameraFPSLimit;
        private System.Windows.Forms.Label labelCameraFPS;
        private System.Windows.Forms.Button buttonCameraProperties;
        private System.Windows.Forms.GroupBox groupBoxCamera;
        private System.Windows.Forms.Button buttonMarkerAdd;
        private System.Windows.Forms.ComboBox comboBoxMarkers;
        private System.Windows.Forms.GroupBox groupBoxMarkerControl;
        private System.Windows.Forms.NumericUpDown numericUpDownMarkerThresh;
        private System.Windows.Forms.Label labelMarkerThresh;
        private System.Windows.Forms.CheckBox checkBoxMarkerSmoothing;
        private System.Windows.Forms.CheckBox checkBoxMarkerHighlight;
        private System.Windows.Forms.RichTextBox labelMarkerData;
        private System.Windows.Forms.Button buttonMarkerRemove;
        private System.Windows.Forms.GroupBox groupBoxMarkers;
        private System.Windows.Forms.PictureBox pictureBoxBackground;
        private System.Windows.Forms.Button buttonSaveImage;
        private System.Windows.Forms.CheckBox checkBoxUseCamera;
        private System.Windows.Forms.Button buttonLoadImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.CheckBox checkBoxUseLoadImage;
    }
}

