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
            this.pictureBoxDisplay.Location = new System.Drawing.Point(90, 312);
            this.pictureBoxDisplay.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBoxDisplay.Name = "pictureBoxDisplay";
            this.pictureBoxDisplay.Size = new System.Drawing.Size(1899, 1013);
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
            this.radioButtonCamera.Location = new System.Drawing.Point(24, 23);
            this.radioButtonCamera.Margin = new System.Windows.Forms.Padding(6);
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
            this.radioButtonMarkers.Location = new System.Drawing.Point(107, 45);
            this.radioButtonMarkers.Margin = new System.Windows.Forms.Padding(6);
            this.radioButtonMarkers.Name = "radioButtonMarkers";
            this.radioButtonMarkers.Size = new System.Drawing.Size(227, 71);
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
            this.radioButtonDemo.Location = new System.Drawing.Point(107, 43);
            this.radioButtonDemo.Margin = new System.Windows.Forms.Padding(6);
            this.radioButtonDemo.Name = "radioButtonDemo";
            this.radioButtonDemo.Size = new System.Drawing.Size(330, 71);
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
            this.groupBoxDemo.Location = new System.Drawing.Point(313, 128);
            this.groupBoxDemo.Margin = new System.Windows.Forms.Padding(6);
            this.groupBoxDemo.Name = "groupBoxDemo";
            this.groupBoxDemo.Padding = new System.Windows.Forms.Padding(6);
            this.groupBoxDemo.Size = new System.Drawing.Size(640, 750);
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
            this.labelDemoInstructions.Location = new System.Drawing.Point(12, 208);
            this.labelDemoInstructions.Margin = new System.Windows.Forms.Padding(6);
            this.labelDemoInstructions.Name = "labelDemoInstructions";
            this.labelDemoInstructions.ReadOnly = true;
            this.labelDemoInstructions.Size = new System.Drawing.Size(612, 527);
            this.labelDemoInstructions.TabIndex = 24;
            this.labelDemoInstructions.Text = "";
            // 
            // buttonDefendDemo
            // 
            this.buttonDefendDemo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonDefendDemo.Location = new System.Drawing.Point(328, 121);
            this.buttonDefendDemo.Margin = new System.Windows.Forms.Padding(6);
            this.buttonDefendDemo.Name = "buttonDefendDemo";
            this.buttonDefendDemo.Size = new System.Drawing.Size(300, 73);
            this.buttonDefendDemo.TabIndex = 23;
            this.buttonDefendDemo.Text = "Start Defend Demo";
            this.buttonDefendDemo.UseVisualStyleBackColor = true;
            this.buttonDefendDemo.Visible = false;
            this.buttonDefendDemo.Click += new System.EventHandler(this.buttonDefendDemo_Click);
            // 
            // buttonImageDemo
            // 
            this.buttonImageDemo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonImageDemo.Location = new System.Drawing.Point(328, 37);
            this.buttonImageDemo.Margin = new System.Windows.Forms.Padding(6);
            this.buttonImageDemo.Name = "buttonImageDemo";
            this.buttonImageDemo.Size = new System.Drawing.Size(300, 73);
            this.buttonImageDemo.TabIndex = 22;
            this.buttonImageDemo.Text = "Start Image Demo";
            this.buttonImageDemo.UseVisualStyleBackColor = true;
            this.buttonImageDemo.Visible = false;
            this.buttonImageDemo.Click += new System.EventHandler(this.buttonImageDemo_Click);
            // 
            // buttonSnakeDemo
            // 
            this.buttonSnakeDemo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonSnakeDemo.Location = new System.Drawing.Point(12, 121);
            this.buttonSnakeDemo.Margin = new System.Windows.Forms.Padding(6);
            this.buttonSnakeDemo.Name = "buttonSnakeDemo";
            this.buttonSnakeDemo.Size = new System.Drawing.Size(300, 73);
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
            this.buttonDrawDemo.Location = new System.Drawing.Point(370, 43);
            this.buttonDrawDemo.Margin = new System.Windows.Forms.Padding(6);
            this.buttonDrawDemo.Name = "buttonDrawDemo";
            this.buttonDrawDemo.Size = new System.Drawing.Size(300, 71);
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
            this.buttonHelp.Location = new System.Drawing.Point(90, 1337);
            this.buttonHelp.Margin = new System.Windows.Forms.Padding(6);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(294, 61);
            this.buttonHelp.TabIndex = 27;
            this.buttonHelp.Text = "Help!";
            this.buttonHelp.UseVisualStyleBackColor = false;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Enabled = false;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonBack.Location = new System.Drawing.Point(385, 859);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(6);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(150, 71);
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
            this.buttonNext.Location = new System.Drawing.Point(1710, 875);
            this.buttonNext.Margin = new System.Windows.Forms.Padding(6);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(150, 71);
            this.buttonNext.TabIndex = 29;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Visible = false;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // linkLabelHomepage
            // 
            this.linkLabelHomepage.AutoSize = true;
            this.linkLabelHomepage.Location = new System.Drawing.Point(85, 1404);
            this.linkLabelHomepage.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.linkLabelHomepage.Name = "linkLabelHomepage";
            this.linkLabelHomepage.Size = new System.Drawing.Size(294, 25);
            this.linkLabelHomepage.TabIndex = 30;
            this.linkLabelHomepage.TabStop = true;
            this.linkLabelHomepage.Text = "www.codeplex.com/touchless";
            this.linkLabelHomepage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelHomepage_LinkClicked);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1504, 899);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 55);
            this.button1.TabIndex = 31;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxCameras
            // 
            this.comboBoxCameras.FormattingEnabled = true;
            this.comboBoxCameras.Location = new System.Drawing.Point(20, 37);
            this.comboBoxCameras.Margin = new System.Windows.Forms.Padding(6);
            this.comboBoxCameras.Name = "comboBoxCameras";
            this.comboBoxCameras.Size = new System.Drawing.Size(604, 33);
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
            this.groupBoxCameraInfo.Location = new System.Drawing.Point(18, 92);
            this.groupBoxCameraInfo.Margin = new System.Windows.Forms.Padding(6);
            this.groupBoxCameraInfo.Name = "groupBoxCameraInfo";
            this.groupBoxCameraInfo.Padding = new System.Windows.Forms.Padding(6);
            this.groupBoxCameraInfo.Size = new System.Drawing.Size(610, 190);
            this.groupBoxCameraInfo.TabIndex = 20;
            this.groupBoxCameraInfo.TabStop = false;
            this.groupBoxCameraInfo.Text = "No Camera Selected";
            // 
            // checkBoxCameraFPSLimit
            // 
            this.checkBoxCameraFPSLimit.AutoSize = true;
            this.checkBoxCameraFPSLimit.Location = new System.Drawing.Point(18, 135);
            this.checkBoxCameraFPSLimit.Margin = new System.Windows.Forms.Padding(6);
            this.checkBoxCameraFPSLimit.Name = "checkBoxCameraFPSLimit";
            this.checkBoxCameraFPSLimit.Size = new System.Drawing.Size(285, 29);
            this.checkBoxCameraFPSLimit.TabIndex = 21;
            this.checkBoxCameraFPSLimit.Text = "Limit Frames Per Second";
            this.checkBoxCameraFPSLimit.UseVisualStyleBackColor = true;
            this.checkBoxCameraFPSLimit.CheckedChanged += new System.EventHandler(this.checkBoxCameraFPSLimit_CheckedChanged);
            // 
            // labelCameraFPSValue
            // 
            this.labelCameraFPSValue.AutoSize = true;
            this.labelCameraFPSValue.Location = new System.Drawing.Point(306, 94);
            this.labelCameraFPSValue.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelCameraFPSValue.Name = "labelCameraFPSValue";
            this.labelCameraFPSValue.Size = new System.Drawing.Size(54, 25);
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
            this.numericUpDownCameraFPSLimit.Location = new System.Drawing.Point(312, 131);
            this.numericUpDownCameraFPSLimit.Margin = new System.Windows.Forms.Padding(6);
            this.numericUpDownCameraFPSLimit.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDownCameraFPSLimit.Name = "numericUpDownCameraFPSLimit";
            this.numericUpDownCameraFPSLimit.Size = new System.Drawing.Size(100, 31);
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
            this.labelCameraFPS.Location = new System.Drawing.Point(12, 94);
            this.labelCameraFPS.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelCameraFPS.Name = "labelCameraFPS";
            this.labelCameraFPS.Size = new System.Drawing.Size(285, 25);
            this.labelCameraFPS.TabIndex = 0;
            this.labelCameraFPS.Text = "Current Frames Per Second:";
            // 
            // buttonCameraProperties
            // 
            this.buttonCameraProperties.Location = new System.Drawing.Point(18, 37);
            this.buttonCameraProperties.Margin = new System.Windows.Forms.Padding(6);
            this.buttonCameraProperties.Name = "buttonCameraProperties";
            this.buttonCameraProperties.Size = new System.Drawing.Size(274, 44);
            this.buttonCameraProperties.TabIndex = 17;
            this.buttonCameraProperties.Text = "Adjust Camera Properties";
            this.buttonCameraProperties.UseVisualStyleBackColor = true;
            this.buttonCameraProperties.Click += new System.EventHandler(this.buttonCameraProperties_Click);
            // 
            // groupBoxCamera
            // 
            this.groupBoxCamera.Controls.Add(this.groupBoxCameraInfo);
            this.groupBoxCamera.Controls.Add(this.comboBoxCameras);
            this.groupBoxCamera.Location = new System.Drawing.Point(195, 483);
            this.groupBoxCamera.Margin = new System.Windows.Forms.Padding(6);
            this.groupBoxCamera.Name = "groupBoxCamera";
            this.groupBoxCamera.Padding = new System.Windows.Forms.Padding(6);
            this.groupBoxCamera.Size = new System.Drawing.Size(640, 306);
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
            this.buttonMarkerAdd.Location = new System.Drawing.Point(466, 41);
            this.buttonMarkerAdd.Margin = new System.Windows.Forms.Padding(6);
            this.buttonMarkerAdd.Name = "buttonMarkerAdd";
            this.buttonMarkerAdd.Size = new System.Drawing.Size(337, 71);
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
            this.comboBoxMarkers.Location = new System.Drawing.Point(831, 60);
            this.comboBoxMarkers.Margin = new System.Windows.Forms.Padding(6);
            this.comboBoxMarkers.Name = "comboBoxMarkers";
            this.comboBoxMarkers.Size = new System.Drawing.Size(325, 39);
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
            this.groupBoxMarkerControl.Location = new System.Drawing.Point(20, 92);
            this.groupBoxMarkerControl.Margin = new System.Windows.Forms.Padding(6);
            this.groupBoxMarkerControl.Name = "groupBoxMarkerControl";
            this.groupBoxMarkerControl.Padding = new System.Windows.Forms.Padding(6);
            this.groupBoxMarkerControl.Size = new System.Drawing.Size(608, 415);
            this.groupBoxMarkerControl.TabIndex = 25;
            this.groupBoxMarkerControl.TabStop = false;
            this.groupBoxMarkerControl.Text = "No Marker Selected";
            // 
            // numericUpDownMarkerThresh
            // 
            this.numericUpDownMarkerThresh.Location = new System.Drawing.Point(502, 85);
            this.numericUpDownMarkerThresh.Margin = new System.Windows.Forms.Padding(6);
            this.numericUpDownMarkerThresh.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownMarkerThresh.Name = "numericUpDownMarkerThresh";
            this.numericUpDownMarkerThresh.Size = new System.Drawing.Size(94, 31);
            this.numericUpDownMarkerThresh.TabIndex = 5;
            this.numericUpDownMarkerThresh.ValueChanged += new System.EventHandler(this.numericUpDownMarkerThresh_ValueChanged);
            // 
            // labelMarkerThresh
            // 
            this.labelMarkerThresh.AutoSize = true;
            this.labelMarkerThresh.Location = new System.Drawing.Point(304, 88);
            this.labelMarkerThresh.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelMarkerThresh.Name = "labelMarkerThresh";
            this.labelMarkerThresh.Size = new System.Drawing.Size(187, 25);
            this.labelMarkerThresh.TabIndex = 4;
            this.labelMarkerThresh.Text = "Marker Threshold:";
            // 
            // checkBoxMarkerSmoothing
            // 
            this.checkBoxMarkerSmoothing.AutoSize = true;
            this.checkBoxMarkerSmoothing.Checked = true;
            this.checkBoxMarkerSmoothing.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxMarkerSmoothing.Location = new System.Drawing.Point(12, 87);
            this.checkBoxMarkerSmoothing.Margin = new System.Windows.Forms.Padding(6);
            this.checkBoxMarkerSmoothing.Name = "checkBoxMarkerSmoothing";
            this.checkBoxMarkerSmoothing.Size = new System.Drawing.Size(241, 29);
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
            this.checkBoxMarkerHighlight.Location = new System.Drawing.Point(10, 37);
            this.checkBoxMarkerHighlight.Margin = new System.Windows.Forms.Padding(6);
            this.checkBoxMarkerHighlight.Name = "checkBoxMarkerHighlight";
            this.checkBoxMarkerHighlight.Size = new System.Drawing.Size(201, 29);
            this.checkBoxMarkerHighlight.TabIndex = 2;
            this.checkBoxMarkerHighlight.Text = "Highlight Marker";
            this.checkBoxMarkerHighlight.UseVisualStyleBackColor = true;
            this.checkBoxMarkerHighlight.CheckedChanged += new System.EventHandler(this.checkBoxMarkerHighlight_CheckedChanged);
            // 
            // labelMarkerData
            // 
            this.labelMarkerData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMarkerData.Location = new System.Drawing.Point(14, 135);
            this.labelMarkerData.Margin = new System.Windows.Forms.Padding(6);
            this.labelMarkerData.Name = "labelMarkerData";
            this.labelMarkerData.ReadOnly = true;
            this.labelMarkerData.Size = new System.Drawing.Size(578, 266);
            this.labelMarkerData.TabIndex = 1;
            this.labelMarkerData.Text = "";
            // 
            // buttonMarkerRemove
            // 
            this.buttonMarkerRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(232)))), ((int)(((byte)(134)))));
            this.buttonMarkerRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonMarkerRemove.ForeColor = System.Drawing.Color.White;
            this.buttonMarkerRemove.Location = new System.Drawing.Point(1189, 43);
            this.buttonMarkerRemove.Margin = new System.Windows.Forms.Padding(6);
            this.buttonMarkerRemove.Name = "buttonMarkerRemove";
            this.buttonMarkerRemove.Size = new System.Drawing.Size(337, 71);
            this.buttonMarkerRemove.TabIndex = 0;
            this.buttonMarkerRemove.Text = "Remove This Marker";
            this.buttonMarkerRemove.UseVisualStyleBackColor = false;
            this.buttonMarkerRemove.Click += new System.EventHandler(this.buttonMarkerRemove_Click);
            // 
            // groupBoxMarkers
            // 
            this.groupBoxMarkers.Controls.Add(this.groupBoxMarkerControl);
            this.groupBoxMarkers.Location = new System.Drawing.Point(246, 336);
            this.groupBoxMarkers.Margin = new System.Windows.Forms.Padding(6);
            this.groupBoxMarkers.Name = "groupBoxMarkers";
            this.groupBoxMarkers.Padding = new System.Windows.Forms.Padding(6);
            this.groupBoxMarkers.Size = new System.Drawing.Size(640, 503);
            this.groupBoxMarkers.TabIndex = 21;
            this.groupBoxMarkers.TabStop = false;
            this.groupBoxMarkers.Visible = false;
            // 
            // pictureBoxBackground
            // 
            this.pictureBoxBackground.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxBackground.BackgroundImage")));
            this.pictureBoxBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxBackground.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxBackground.InitialImage")));
            this.pictureBoxBackground.Location = new System.Drawing.Point(44, 113);
            this.pictureBoxBackground.Name = "pictureBoxBackground";
            this.pictureBoxBackground.Size = new System.Drawing.Size(1999, 1215);
            this.pictureBoxBackground.TabIndex = 32;
            this.pictureBoxBackground.TabStop = false;
            // 
            // buttonSaveImage
            // 
            this.buttonSaveImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(123)))), ((int)(((byte)(232)))));
            this.buttonSaveImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold);
            this.buttonSaveImage.ForeColor = System.Drawing.Color.White;
            this.buttonSaveImage.Location = new System.Drawing.Point(679, 41);
            this.buttonSaveImage.Name = "buttonSaveImage";
            this.buttonSaveImage.Size = new System.Drawing.Size(167, 71);
            this.buttonSaveImage.TabIndex = 33;
            this.buttonSaveImage.Text = "Save";
            this.buttonSaveImage.UseVisualStyleBackColor = false;
            this.buttonSaveImage.Visible = false;
            this.buttonSaveImage.Click += new System.EventHandler(this.buttonSaveImage_Click);
            // 
            // DrawingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(203)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(2104, 1438);
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
            this.Margin = new System.Windows.Forms.Padding(6);
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
    }
}

