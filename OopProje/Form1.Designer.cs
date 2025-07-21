namespace projectOOP
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
            center = new Label();
            lenght = new Label();
            colorRed = new Label();
            colorGreen = new Label();
            colorBlue = new Label();
            edge = new Label();
            angle = new Label();
            txtx = new TextBox();
            txtedge = new TextBox();
            txtangle = new TextBox();
            radioButtonClockwise = new CheckBox();
            trackBarRed = new TrackBar();
            trackBarGreen = new TrackBar();
            trackBarBlue = new TrackBar();
            listBoxEdge = new ListBox();
            pictureBox = new PictureBox();
            draw = new Button();
            rotate = new Button();
            reset = new Button();
            label = new Label();
            txty = new TextBox();
            txtlength = new TextBox();
            ((System.ComponentModel.ISupportInitialize)trackBarRed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarGreen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarBlue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // center
            // 
            center.AutoSize = true;
            center.Location = new Point(687, 13);
            center.Name = "center";
            center.Size = new Size(52, 20);
            center.TabIndex = 0;
            center.Text = "Center";
            // 
            // lenght
            // 
            lenght.AutoSize = true;
            lenght.Location = new Point(687, 61);
            lenght.Name = "lenght";
            lenght.Size = new Size(54, 20);
            lenght.TabIndex = 1;
            lenght.Text = "Lenght";
            // 
            // colorRed
            // 
            colorRed.AutoSize = true;
            colorRed.Location = new Point(687, 141);
            colorRed.Name = "colorRed";
            colorRed.Size = new Size(35, 20);
            colorRed.TabIndex = 2;
            colorRed.Text = "Red";
            // 
            // colorGreen
            // 
            colorGreen.AutoSize = true;
            colorGreen.Location = new Point(687, 200);
            colorGreen.Name = "colorGreen";
            colorGreen.Size = new Size(48, 20);
            colorGreen.TabIndex = 3;
            colorGreen.Text = "Green";
            // 
            // colorBlue
            // 
            colorBlue.AutoSize = true;
            colorBlue.Location = new Point(687, 265);
            colorBlue.Name = "colorBlue";
            colorBlue.Size = new Size(38, 20);
            colorBlue.TabIndex = 4;
            colorBlue.Text = "Blue";
            // 
            // edge
            // 
            edge.AutoSize = true;
            edge.Location = new Point(687, 349);
            edge.Name = "edge";
            edge.Size = new Size(43, 20);
            edge.TabIndex = 5;
            edge.Text = "Edge";
            // 
            // angle
            // 
            angle.AutoSize = true;
            angle.Location = new Point(687, 409);
            angle.Name = "angle";
            angle.Size = new Size(48, 20);
            angle.TabIndex = 6;
            angle.Text = "Angle";
            // 
            // txtx
            // 
            txtx.Location = new Point(757, 13);
            txtx.Margin = new Padding(3, 4, 3, 4);
            txtx.Name = "txtx";
            txtx.Size = new Size(80, 27);
            txtx.TabIndex = 9;
            txtx.Text = "0";
            // 
            // txtedge
            // 
            txtedge.Location = new Point(757, 349);
            txtedge.Margin = new Padding(3, 4, 3, 4);
            txtedge.Name = "txtedge";
            txtedge.Size = new Size(100, 27);
            txtedge.TabIndex = 12;
            txtedge.Text = "5";
            // 
            // txtangle
            // 
            txtangle.Location = new Point(757, 409);
            txtangle.Margin = new Padding(3, 4, 3, 4);
            txtangle.Name = "txtangle";
            txtangle.Size = new Size(100, 27);
            txtangle.TabIndex = 13;
            txtangle.Text = "30";
            // 
            // radioButtonClockwise
            // 
            radioButtonClockwise.AutoSize = true;
            radioButtonClockwise.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            radioButtonClockwise.Location = new Point(880, 343);
            radioButtonClockwise.Margin = new Padding(3, 4, 3, 4);
            radioButtonClockwise.Name = "radioButtonClockwise";
            radioButtonClockwise.Size = new Size(84, 29);
            radioButtonClockwise.TabIndex = 15;
            radioButtonClockwise.Text = "CCW";
            radioButtonClockwise.UseVisualStyleBackColor = true;
            // 
            // trackBarRed
            // 
            trackBarRed.Location = new Point(747, 141);
            trackBarRed.Margin = new Padding(3, 4, 3, 4);
            trackBarRed.Maximum = 255;
            trackBarRed.Name = "trackBarRed";
            trackBarRed.Size = new Size(240, 56);
            trackBarRed.TabIndex = 16;
            // 
            // trackBarGreen
            // 
            trackBarGreen.Location = new Point(747, 200);
            trackBarGreen.Margin = new Padding(3, 4, 3, 4);
            trackBarGreen.Maximum = 255;
            trackBarGreen.Name = "trackBarGreen";
            trackBarGreen.Size = new Size(240, 56);
            trackBarGreen.TabIndex = 17;
            // 
            // trackBarBlue
            // 
            trackBarBlue.Location = new Point(747, 255);
            trackBarBlue.Margin = new Padding(3, 4, 3, 4);
            trackBarBlue.Maximum = 255;
            trackBarBlue.Name = "trackBarBlue";
            trackBarBlue.Size = new Size(240, 56);
            trackBarBlue.TabIndex = 18;
            // 
            // listBoxEdge
            // 
            listBoxEdge.FormattingEnabled = true;
            listBoxEdge.Items.AddRange(new object[] { "E1", "E2", "E3", ".", ".", "En" });
            listBoxEdge.Location = new Point(736, 474);
            listBoxEdge.Margin = new Padding(3, 4, 3, 4);
            listBoxEdge.Name = "listBoxEdge";
            listBoxEdge.Size = new Size(224, 124);
            listBoxEdge.TabIndex = 19;
            listBoxEdge.Tag = "";
            // 
            // pictureBox
            // 
            pictureBox.BackColor = SystemColors.Control;
            pictureBox.Location = new Point(20, 20);
            pictureBox.Margin = new Padding(3, 4, 3, 4);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(600, 600);
            pictureBox.TabIndex = 20;
            pictureBox.TabStop = false;
            pictureBox.Paint += pictureBox_Paint;
            // 
            // draw
            // 
            draw.BackColor = SystemColors.AppWorkspace;
            draw.Location = new Point(666, 626);
            draw.Margin = new Padding(3, 4, 3, 4);
            draw.Name = "draw";
            draw.Size = new Size(111, 60);
            draw.TabIndex = 21;
            draw.Text = "DRAW";
            draw.UseVisualStyleBackColor = false;
            draw.Click += button_draw;
            // 
            // rotate
            // 
            rotate.BackColor = SystemColors.AppWorkspace;
            rotate.Location = new Point(780, 626);
            rotate.Margin = new Padding(3, 4, 3, 4);
            rotate.Name = "rotate";
            rotate.Size = new Size(111, 60);
            rotate.TabIndex = 22;
            rotate.Text = "ROTATE";
            rotate.UseVisualStyleBackColor = false;
            rotate.Click += rotate_Click;
            // 
            // reset
            // 
            reset.BackColor = SystemColors.AppWorkspace;
            reset.Location = new Point(897, 626);
            reset.Margin = new Padding(3, 4, 3, 4);
            reset.Name = "reset";
            reset.Size = new Size(111, 60);
            reset.TabIndex = 23;
            reset.Text = "RESET";
            reset.UseVisualStyleBackColor = false;
            reset.Click += reset_Click;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label.Location = new Point(790, 452);
            label.Name = "label";
            label.Size = new Size(127, 18);
            label.TabIndex = 24;
            label.Text = "Edge Coordinates";
            // 
            // txty
            // 
            txty.Location = new Point(880, 13);
            txty.Margin = new Padding(3, 4, 3, 4);
            txty.Name = "txty";
            txty.Size = new Size(80, 27);
            txty.TabIndex = 25;
            txty.Text = "0";
            // 
            // txtlength
            // 
            txtlength.Location = new Point(754, 61);
            txtlength.Margin = new Padding(3, 4, 3, 4);
            txtlength.Name = "txtlength";
            txtlength.Size = new Size(103, 27);
            txtlength.TabIndex = 26;
            txtlength.Text = "4";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1027, 704);
            Controls.Add(txtlength);
            Controls.Add(txty);
            Controls.Add(label);
            Controls.Add(reset);
            Controls.Add(rotate);
            Controls.Add(draw);
            Controls.Add(pictureBox);
            Controls.Add(listBoxEdge);
            Controls.Add(trackBarBlue);
            Controls.Add(trackBarGreen);
            Controls.Add(trackBarRed);
            Controls.Add(radioButtonClockwise);
            Controls.Add(txtangle);
            Controls.Add(txtedge);
            Controls.Add(txtx);
            Controls.Add(angle);
            Controls.Add(edge);
            Controls.Add(colorBlue);
            Controls.Add(colorGreen);
            Controls.Add(colorRed);
            Controls.Add(lenght);
            Controls.Add(center);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)trackBarRed).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarGreen).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarBlue).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label center;
        private System.Windows.Forms.Label lenght;
        private System.Windows.Forms.Label colorRed;
        private System.Windows.Forms.Label colorGreen;
        private System.Windows.Forms.Label colorBlue;
        private System.Windows.Forms.Label edge;
        private System.Windows.Forms.Label angle;
        private System.Windows.Forms.TextBox txtx;
        private System.Windows.Forms.TextBox txtedge;
        private System.Windows.Forms.TextBox txtangle;
        private System.Windows.Forms.CheckBox radioButtonClockwise;
        private System.Windows.Forms.TrackBar trackBarRed;
        private System.Windows.Forms.TrackBar trackBarGreen;
        private System.Windows.Forms.TrackBar trackBarBlue;
        private System.Windows.Forms.ListBox listBoxEdge;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button draw;
        private System.Windows.Forms.Button rotate;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Label label;
        private TextBox txty;
        private TextBox txtlength;
    }
}