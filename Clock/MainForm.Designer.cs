namespace Clock
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.labelTime = new System.Windows.Forms.Label();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmTopmost = new System.Windows.Forms.ToolStripMenuItem();
            this.cmShowControls = new System.Windows.Forms.ToolStripMenuItem();
            this.cmShowDate = new System.Windows.Forms.ToolStripMenuItem();
            this.cmShowWeekday = new System.Windows.Forms.ToolStripMenuItem();
            this.cmChooseFont = new System.Windows.Forms.ToolStripMenuItem();
            this.cmColors = new System.Windows.Forms.ToolStripMenuItem();
            this.cmBackColor = new System.Windows.Forms.ToolStripMenuItem();
            this.cmForeColor = new System.Windows.Forms.ToolStripMenuItem();
            this.cmExit = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.CBShowDate = new System.Windows.Forms.CheckBox();
            this.btnHideControls = new System.Windows.Forms.Button();
            this.cbShowWeekDay = new System.Windows.Forms.CheckBox();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.ContextMenuStrip = this.contextMenu;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.Location = new System.Drawing.Point(27, 9);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(231, 55);
            this.labelTime.TabIndex = 0;
            this.labelTime.Text = "labelTime";
            this.labelTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTime.Click += new System.EventHandler(this.labelTime_Click);
            this.labelTime.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.labelTime_MouseDoubleClick);
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmTopmost,
            this.cmShowControls,
            this.cmShowDate,
            this.cmShowWeekday,
            this.cmChooseFont,
            this.cmColors,
            this.cmExit});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(153, 158);
            this.contextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenu_Opening);
            // 
            // cmTopmost
            // 
            this.cmTopmost.CheckOnClick = true;
            this.cmTopmost.Name = "cmTopmost";
            this.cmTopmost.Size = new System.Drawing.Size(152, 22);
            this.cmTopmost.Text = "Topmost";
            this.cmTopmost.CheckedChanged += new System.EventHandler(this.cmTopmost_CheckedChanged);
            this.cmTopmost.Click += new System.EventHandler(this.cmTopmost_Click);
            // 
            // cmShowControls
            // 
            this.cmShowControls.CheckOnClick = true;
            this.cmShowControls.Name = "cmShowControls";
            this.cmShowControls.Size = new System.Drawing.Size(152, 22);
            this.cmShowControls.Text = "Show controls";
            this.cmShowControls.CheckedChanged += new System.EventHandler(this.cmShowControls_CheckedChanged);
            // 
            // cmShowDate
            // 
            this.cmShowDate.CheckOnClick = true;
            this.cmShowDate.Name = "cmShowDate";
            this.cmShowDate.Size = new System.Drawing.Size(152, 22);
            this.cmShowDate.Text = "Show date";
            this.cmShowDate.CheckedChanged += new System.EventHandler(this.cmShowDate_CheckedChanged);
            // 
            // cmShowWeekday
            // 
            this.cmShowWeekday.CheckOnClick = true;
            this.cmShowWeekday.Name = "cmShowWeekday";
            this.cmShowWeekday.Size = new System.Drawing.Size(152, 22);
            this.cmShowWeekday.Text = "Show weekday";
            this.cmShowWeekday.CheckedChanged += new System.EventHandler(this.cmShowWeekday_CheckedChanged);
            // 
            // cmChooseFont
            // 
            this.cmChooseFont.Name = "cmChooseFont";
            this.cmChooseFont.Size = new System.Drawing.Size(152, 22);
            this.cmChooseFont.Text = "Choose font";
            // 
            // cmColors
            // 
            this.cmColors.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmBackColor,
            this.cmForeColor});
            this.cmColors.Name = "cmColors";
            this.cmColors.Size = new System.Drawing.Size(152, 22);
            this.cmColors.Text = "Colors";
            // 
            // cmBackColor
            // 
            this.cmBackColor.Name = "cmBackColor";
            this.cmBackColor.Size = new System.Drawing.Size(168, 22);
            this.cmBackColor.Text = "Background color";
            this.cmBackColor.Click += new System.EventHandler(this.SetColor);
            // 
            // cmForeColor
            // 
            this.cmForeColor.Name = "cmForeColor";
            this.cmForeColor.Size = new System.Drawing.Size(168, 22);
            this.cmForeColor.Text = "Foreground color";
            this.cmForeColor.Click += new System.EventHandler(this.SetColor);
            // 
            // cmExit
            // 
            this.cmExit.Name = "cmExit";
            this.cmExit.Size = new System.Drawing.Size(152, 22);
            this.cmExit.Text = "Exit";
            this.cmExit.Click += new System.EventHandler(this.cmExit_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CBShowDate
            // 
            this.CBShowDate.AutoSize = true;
            this.CBShowDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CBShowDate.Location = new System.Drawing.Point(78, 188);
            this.CBShowDate.Name = "CBShowDate";
            this.CBShowDate.Size = new System.Drawing.Size(176, 29);
            this.CBShowDate.TabIndex = 1;
            this.CBShowDate.Text = "Показать дату";
            this.CBShowDate.UseVisualStyleBackColor = true;
            this.CBShowDate.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnHideControls
            // 
            this.btnHideControls.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnHideControls.Location = new System.Drawing.Point(99, 303);
            this.btnHideControls.Name = "btnHideControls";
            this.btnHideControls.Size = new System.Drawing.Size(155, 30);
            this.btnHideControls.TabIndex = 2;
            this.btnHideControls.Text = "Hide controls";
            this.btnHideControls.UseVisualStyleBackColor = true;
            this.btnHideControls.Click += new System.EventHandler(this.btnHideControls_Click);
            // 
            // cbShowWeekDay
            // 
            this.cbShowWeekDay.AutoSize = true;
            this.cbShowWeekDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbShowWeekDay.Location = new System.Drawing.Point(37, 232);
            this.cbShowWeekDay.Name = "cbShowWeekDay";
            this.cbShowWeekDay.Size = new System.Drawing.Size(256, 29);
            this.cbShowWeekDay.TabIndex = 3;
            this.cbShowWeekDay.Text = "Показать день недели";
            this.cbShowWeekDay.UseVisualStyleBackColor = true;
            this.cbShowWeekDay.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenu;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "ClockPV_319";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 406);
            this.Controls.Add(this.cbShowWeekDay);
            this.Controls.Add(this.btnHideControls);
            this.Controls.Add(this.CBShowDate);
            this.Controls.Add(this.labelTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Clock PV_319";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox CBShowDate;
        private System.Windows.Forms.Button btnHideControls;
        private System.Windows.Forms.CheckBox cbShowWeekDay;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem cmTopmost;
        private System.Windows.Forms.ToolStripMenuItem cmShowDate;
        private System.Windows.Forms.ToolStripMenuItem cmShowWeekday;
        private System.Windows.Forms.ToolStripMenuItem cmExit;
        private System.Windows.Forms.ToolStripMenuItem cmColors;
        private System.Windows.Forms.ToolStripMenuItem cmBackColor;
        private System.Windows.Forms.ToolStripMenuItem cmForeColor;
        private System.Windows.Forms.ToolStripMenuItem cmShowControls;
        private System.Windows.Forms.ToolStripMenuItem cmChooseFont;
    }
}

