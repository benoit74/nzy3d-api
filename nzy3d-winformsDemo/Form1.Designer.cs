namespace nzy3d_winformsDemo
{
    partial class Form1
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
            this.chkDisplayXTicks = new System.Windows.Forms.CheckBox();
            this.chkDisplayYTicks = new System.Windows.Forms.CheckBox();
            this.chkDisplayZTick = new System.Windows.Forms.CheckBox();
            this.chkDisplayZAxisLabel = new System.Windows.Forms.CheckBox();
            this.chkDisplayYAxisLabel = new System.Windows.Forms.CheckBox();
            this.chkDisplayXAxisLabel = new System.Windows.Forms.CheckBox();
            this.chkDisplayTickLines = new System.Windows.Forms.CheckBox();
            this.myRenderer3D = new nzy3D.Plot3D.Rendering.View.Renderer3D();
            this.txtCheckboxes = new System.Windows.Forms.TextBox();
            this.txtRotateCamera = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // chkDisplayXTicks
            // 
            this.chkDisplayXTicks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkDisplayXTicks.AutoSize = true;
            this.chkDisplayXTicks.Checked = true;
            this.chkDisplayXTicks.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDisplayXTicks.Location = new System.Drawing.Point(553, 12);
            this.chkDisplayXTicks.Name = "chkDisplayXTicks";
            this.chkDisplayXTicks.Size = new System.Drawing.Size(99, 17);
            this.chkDisplayXTicks.TabIndex = 1;
            this.chkDisplayXTicks.Text = "Display X Ticks";
            this.chkDisplayXTicks.UseVisualStyleBackColor = true;
            this.chkDisplayXTicks.CheckedChanged += new System.EventHandler(this.checkBoxes_CheckedChanged);
            // 
            // chkDisplayYTicks
            // 
            this.chkDisplayYTicks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkDisplayYTicks.AutoSize = true;
            this.chkDisplayYTicks.Checked = true;
            this.chkDisplayYTicks.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDisplayYTicks.Location = new System.Drawing.Point(553, 35);
            this.chkDisplayYTicks.Name = "chkDisplayYTicks";
            this.chkDisplayYTicks.Size = new System.Drawing.Size(99, 17);
            this.chkDisplayYTicks.TabIndex = 2;
            this.chkDisplayYTicks.Text = "Display Y Ticks";
            this.chkDisplayYTicks.UseVisualStyleBackColor = true;
            this.chkDisplayYTicks.CheckedChanged += new System.EventHandler(this.checkBoxes_CheckedChanged);
            // 
            // chkDisplayZTick
            // 
            this.chkDisplayZTick.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkDisplayZTick.AutoSize = true;
            this.chkDisplayZTick.Checked = true;
            this.chkDisplayZTick.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDisplayZTick.Location = new System.Drawing.Point(553, 58);
            this.chkDisplayZTick.Name = "chkDisplayZTick";
            this.chkDisplayZTick.Size = new System.Drawing.Size(99, 17);
            this.chkDisplayZTick.TabIndex = 3;
            this.chkDisplayZTick.Text = "Display Z Ticks";
            this.chkDisplayZTick.UseVisualStyleBackColor = true;
            this.chkDisplayZTick.CheckedChanged += new System.EventHandler(this.checkBoxes_CheckedChanged);
            // 
            // chkDisplayZAxisLabel
            // 
            this.chkDisplayZAxisLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkDisplayZAxisLabel.AutoSize = true;
            this.chkDisplayZAxisLabel.Checked = true;
            this.chkDisplayZAxisLabel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDisplayZAxisLabel.Location = new System.Drawing.Point(553, 127);
            this.chkDisplayZAxisLabel.Name = "chkDisplayZAxisLabel";
            this.chkDisplayZAxisLabel.Size = new System.Drawing.Size(116, 17);
            this.chkDisplayZAxisLabel.TabIndex = 6;
            this.chkDisplayZAxisLabel.Text = "Display Z axis label";
            this.chkDisplayZAxisLabel.UseVisualStyleBackColor = true;
            this.chkDisplayZAxisLabel.CheckedChanged += new System.EventHandler(this.checkBoxes_CheckedChanged);
            // 
            // chkDisplayYAxisLabel
            // 
            this.chkDisplayYAxisLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkDisplayYAxisLabel.AutoSize = true;
            this.chkDisplayYAxisLabel.Checked = true;
            this.chkDisplayYAxisLabel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDisplayYAxisLabel.Location = new System.Drawing.Point(553, 104);
            this.chkDisplayYAxisLabel.Name = "chkDisplayYAxisLabel";
            this.chkDisplayYAxisLabel.Size = new System.Drawing.Size(116, 17);
            this.chkDisplayYAxisLabel.TabIndex = 5;
            this.chkDisplayYAxisLabel.Text = "Display Y axis label";
            this.chkDisplayYAxisLabel.UseVisualStyleBackColor = true;
            this.chkDisplayYAxisLabel.CheckedChanged += new System.EventHandler(this.checkBoxes_CheckedChanged);
            // 
            // chkDisplayXAxisLabel
            // 
            this.chkDisplayXAxisLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkDisplayXAxisLabel.AutoSize = true;
            this.chkDisplayXAxisLabel.Checked = true;
            this.chkDisplayXAxisLabel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDisplayXAxisLabel.Location = new System.Drawing.Point(553, 81);
            this.chkDisplayXAxisLabel.Name = "chkDisplayXAxisLabel";
            this.chkDisplayXAxisLabel.Size = new System.Drawing.Size(116, 17);
            this.chkDisplayXAxisLabel.TabIndex = 4;
            this.chkDisplayXAxisLabel.Text = "Display X axis label";
            this.chkDisplayXAxisLabel.UseVisualStyleBackColor = true;
            this.chkDisplayXAxisLabel.CheckedChanged += new System.EventHandler(this.checkBoxes_CheckedChanged);
            // 
            // chkDisplayTickLines
            // 
            this.chkDisplayTickLines.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkDisplayTickLines.AutoSize = true;
            this.chkDisplayTickLines.Checked = true;
            this.chkDisplayTickLines.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDisplayTickLines.Location = new System.Drawing.Point(553, 150);
            this.chkDisplayTickLines.Name = "chkDisplayTickLines";
            this.chkDisplayTickLines.Size = new System.Drawing.Size(104, 17);
            this.chkDisplayTickLines.TabIndex = 7;
            this.chkDisplayTickLines.Text = "Display tick lines";
            this.chkDisplayTickLines.UseVisualStyleBackColor = true;
            this.chkDisplayTickLines.CheckedChanged += new System.EventHandler(this.checkBoxes_CheckedChanged);
            // 
            // myRenderer3D
            // 
            this.myRenderer3D.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myRenderer3D.BackColor = System.Drawing.Color.Black;
            this.myRenderer3D.Location = new System.Drawing.Point(12, 12);
            this.myRenderer3D.Name = "myRenderer3D";
            this.myRenderer3D.Size = new System.Drawing.Size(523, 408);
            this.myRenderer3D.TabIndex = 9;
            this.myRenderer3D.VSync = false;
            // 
            // txtCheckboxes
            // 
            this.txtCheckboxes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCheckboxes.Location = new System.Drawing.Point(553, 173);
            this.txtCheckboxes.Multiline = true;
            this.txtCheckboxes.Name = "txtCheckboxes";
            this.txtCheckboxes.ReadOnly = true;
            this.txtCheckboxes.Size = new System.Drawing.Size(116, 60);
            this.txtCheckboxes.TabIndex = 12;
            this.txtCheckboxes.Text = "(do not uncheck three first options in order to be able to see the effect of the " +
    "four last ones)";
            this.txtCheckboxes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtRotateCamera
            // 
            this.txtRotateCamera.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRotateCamera.Location = new System.Drawing.Point(553, 325);
            this.txtRotateCamera.Multiline = true;
            this.txtRotateCamera.Name = "txtRotateCamera";
            this.txtRotateCamera.ReadOnly = true;
            this.txtRotateCamera.Size = new System.Drawing.Size(116, 49);
            this.txtRotateCamera.TabIndex = 11;
            this.txtRotateCamera.Text = "(toggle camera rotation by double-clicking on the graph)";
            this.txtRotateCamera.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 432);
            this.Controls.Add(this.txtCheckboxes);
            this.Controls.Add(this.txtRotateCamera);
            this.Controls.Add(this.myRenderer3D);
            this.Controls.Add(this.chkDisplayTickLines);
            this.Controls.Add(this.chkDisplayZAxisLabel);
            this.Controls.Add(this.chkDisplayYAxisLabel);
            this.Controls.Add(this.chkDisplayXAxisLabel);
            this.Controls.Add(this.chkDisplayZTick);
            this.Controls.Add(this.chkDisplayYTicks);
            this.Controls.Add(this.chkDisplayXTicks);
            this.Name = "Form1";
            this.Text = "nzy3d - Winforms Sample";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkDisplayXTicks;
        private System.Windows.Forms.CheckBox chkDisplayYTicks;
        private System.Windows.Forms.CheckBox chkDisplayZTick;
        private System.Windows.Forms.CheckBox chkDisplayZAxisLabel;
        private System.Windows.Forms.CheckBox chkDisplayYAxisLabel;
        private System.Windows.Forms.CheckBox chkDisplayXAxisLabel;
        private System.Windows.Forms.CheckBox chkDisplayTickLines;
        private nzy3D.Plot3D.Rendering.View.Renderer3D myRenderer3D;
        private System.Windows.Forms.TextBox txtCheckboxes;
        private System.Windows.Forms.TextBox txtRotateCamera;
    }
}

