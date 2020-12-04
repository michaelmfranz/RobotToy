namespace RobotToy
{
    partial class frmControl
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
            this.btnPlace = new System.Windows.Forms.Button();
            this.xLocation = new System.Windows.Forms.TextBox();
            this.yLocation = new System.Windows.Forms.TextBox();
            this.cboOrientation = new System.Windows.Forms.ComboBox();
            this.lblPlace = new System.Windows.Forms.Label();
            this.btnMove = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.bntRestart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPlace
            // 
            this.btnPlace.Location = new System.Drawing.Point(347, 58);
            this.btnPlace.Name = "btnPlace";
            this.btnPlace.Size = new System.Drawing.Size(75, 23);
            this.btnPlace.TabIndex = 0;
            this.btnPlace.Text = "Place";
            this.btnPlace.UseVisualStyleBackColor = true;
            this.btnPlace.Click += new System.EventHandler(this.btnPlace_Click);
            // 
            // xLocation
            // 
            this.xLocation.Location = new System.Drawing.Point(59, 61);
            this.xLocation.Name = "xLocation";
            this.xLocation.Size = new System.Drawing.Size(75, 20);
            this.xLocation.TabIndex = 1;
            // 
            // yLocation
            // 
            this.yLocation.Location = new System.Drawing.Point(154, 61);
            this.yLocation.Name = "yLocation";
            this.yLocation.Size = new System.Drawing.Size(73, 20);
            this.yLocation.TabIndex = 2;
            // 
            // cboOrientation
            // 
            this.cboOrientation.FormattingEnabled = true;
            this.cboOrientation.Location = new System.Drawing.Point(243, 60);
            this.cboOrientation.Name = "cboOrientation";
            this.cboOrientation.Size = new System.Drawing.Size(86, 21);
            this.cboOrientation.TabIndex = 3;
            // 
            // lblPlace
            // 
            this.lblPlace.AutoSize = true;
            this.lblPlace.Location = new System.Drawing.Point(59, 42);
            this.lblPlace.Name = "lblPlace";
            this.lblPlace.Size = new System.Drawing.Size(58, 13);
            this.lblPlace.TabIndex = 4;
            this.lblPlace.Text = "X Location";
            // 
            // btnMove
            // 
            this.btnMove.Location = new System.Drawing.Point(243, 107);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(75, 23);
            this.btnMove.TabIndex = 5;
            this.btnMove.Text = "Move";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(59, 107);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(75, 23);
            this.btnLeft.TabIndex = 6;
            this.btnLeft.Text = "Left";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(152, 107);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(75, 23);
            this.btnRight.TabIndex = 7;
            this.btnRight.Text = "Right";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(59, 164);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(75, 23);
            this.btnReport.TabIndex = 8;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // dgvReport
            // 
            this.dgvReport.AllowUserToAddRows = false;
            this.dgvReport.AllowUserToDeleteRows = false;
            this.dgvReport.AllowUserToResizeColumns = false;
            this.dgvReport.AllowUserToResizeRows = false;
            this.dgvReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.ColumnHeadersVisible = false;
            this.dgvReport.Location = new System.Drawing.Point(62, 208);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.RowHeadersVisible = false;
            this.dgvReport.Size = new System.Drawing.Size(475, 203);
            this.dgvReport.TabIndex = 9;
            // 
            // bntRestart
            // 
            this.bntRestart.Location = new System.Drawing.Point(59, 434);
            this.bntRestart.Name = "bntRestart";
            this.bntRestart.Size = new System.Drawing.Size(75, 23);
            this.bntRestart.TabIndex = 10;
            this.bntRestart.Text = "Restart";
            this.bntRestart.UseVisualStyleBackColor = true;
            this.bntRestart.Click += new System.EventHandler(this.bntRestart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Y Location";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Orientation";
            // 
            // frmControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 509);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bntRestart);
            this.Controls.Add(this.dgvReport);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.lblPlace);
            this.Controls.Add(this.cboOrientation);
            this.Controls.Add(this.yLocation);
            this.Controls.Add(this.xLocation);
            this.Controls.Add(this.btnPlace);
            this.Name = "frmControl";
            this.Text = "Toy Robot";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlace;
        private System.Windows.Forms.TextBox xLocation;
        private System.Windows.Forms.TextBox yLocation;
        private System.Windows.Forms.ComboBox cboOrientation;
        private System.Windows.Forms.Label lblPlace;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.Button bntRestart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

