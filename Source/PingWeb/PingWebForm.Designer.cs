namespace HttpRequestTester
{
    partial class FormHttpRequestTester
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHttpRequestTester));
            this.panelMainStart = new System.Windows.Forms.Panel();
            this.cbSaveToDatabase = new System.Windows.Forms.CheckBox();
            this.cbHideDataGrid = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numWait = new System.Windows.Forms.NumericUpDown();
            this.cbShowResponse = new System.Windows.Forms.CheckBox();
            this.cbResponseSpecific = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbExpectedResponse = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numDelay = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.textUrl = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.dgvResult = new System.Windows.Forms.DataGridView();
            this.Response = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateRequest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateResponse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsSuccess = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pbWait = new System.Windows.Forms.ProgressBar();
            this.picLoading = new System.Windows.Forms.PictureBox();
            this.backgroundWorkerRequest = new System.ComponentModel.BackgroundWorker();
            this.panelMainStart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWait)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMainStart
            // 
            this.panelMainStart.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelMainStart.Controls.Add(this.cbSaveToDatabase);
            this.panelMainStart.Controls.Add(this.cbHideDataGrid);
            this.panelMainStart.Controls.Add(this.label6);
            this.panelMainStart.Controls.Add(this.label7);
            this.panelMainStart.Controls.Add(this.numWait);
            this.panelMainStart.Controls.Add(this.cbShowResponse);
            this.panelMainStart.Controls.Add(this.cbResponseSpecific);
            this.panelMainStart.Controls.Add(this.label2);
            this.panelMainStart.Controls.Add(this.tbExpectedResponse);
            this.panelMainStart.Controls.Add(this.label4);
            this.panelMainStart.Controls.Add(this.label3);
            this.panelMainStart.Controls.Add(this.numDelay);
            this.panelMainStart.Controls.Add(this.label1);
            this.panelMainStart.Controls.Add(this.textUrl);
            this.panelMainStart.Location = new System.Drawing.Point(5, 3);
            this.panelMainStart.Name = "panelMainStart";
            this.panelMainStart.Size = new System.Drawing.Size(809, 136);
            this.panelMainStart.TabIndex = 0;
            // 
            // cbSaveToDatabase
            // 
            this.cbSaveToDatabase.AutoSize = true;
            this.cbSaveToDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSaveToDatabase.Location = new System.Drawing.Point(636, 6);
            this.cbSaveToDatabase.Name = "cbSaveToDatabase";
            this.cbSaveToDatabase.Size = new System.Drawing.Size(170, 17);
            this.cbSaveToDatabase.TabIndex = 16;
            this.cbSaveToDatabase.Text = "Save to datbase (SqlLite)";
            this.cbSaveToDatabase.UseVisualStyleBackColor = true;
            this.cbSaveToDatabase.CheckedChanged += new System.EventHandler(this.cbSaveToDatabase_CheckedChanged);
            // 
            // cbHideDataGrid
            // 
            this.cbHideDataGrid.AutoSize = true;
            this.cbHideDataGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHideDataGrid.Location = new System.Drawing.Point(636, 36);
            this.cbHideDataGrid.Name = "cbHideDataGrid";
            this.cbHideDataGrid.Size = new System.Drawing.Size(110, 17);
            this.cbHideDataGrid.TabIndex = 15;
            this.cbHideDataGrid.Text = "Hide Data Grid";
            this.cbHideDataGrid.UseVisualStyleBackColor = true;
            this.cbHideDataGrid.CheckedChanged += new System.EventHandler(this.cbHideDataGrid_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(199, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "(seconds)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(5, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Time out";
            // 
            // numWait
            // 
            this.numWait.Location = new System.Drawing.Point(110, 99);
            this.numWait.Name = "numWait";
            this.numWait.Size = new System.Drawing.Size(83, 20);
            this.numWait.TabIndex = 12;
            this.numWait.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            // 
            // cbShowResponse
            // 
            this.cbShowResponse.AutoSize = true;
            this.cbShowResponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbShowResponse.Location = new System.Drawing.Point(636, 68);
            this.cbShowResponse.Name = "cbShowResponse";
            this.cbShowResponse.Size = new System.Drawing.Size(117, 17);
            this.cbShowResponse.TabIndex = 10;
            this.cbShowResponse.Text = "Show Response";
            this.cbShowResponse.UseVisualStyleBackColor = true;
            this.cbShowResponse.CheckedChanged += new System.EventHandler(this.cbShowResponse_CheckedChanged);
            // 
            // cbResponseSpecific
            // 
            this.cbResponseSpecific.AutoSize = true;
            this.cbResponseSpecific.Location = new System.Drawing.Point(110, 37);
            this.cbResponseSpecific.Name = "cbResponseSpecific";
            this.cbResponseSpecific.Size = new System.Drawing.Size(64, 17);
            this.cbResponseSpecific.TabIndex = 9;
            this.cbResponseSpecific.Text = "Specific";
            this.cbResponseSpecific.UseVisualStyleBackColor = true;
            this.cbResponseSpecific.CheckedChanged += new System.EventHandler(this.cbResponseAny_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Response";
            // 
            // tbExpectedResponse
            // 
            this.tbExpectedResponse.Location = new System.Drawing.Point(180, 34);
            this.tbExpectedResponse.Name = "tbExpectedResponse";
            this.tbExpectedResponse.Size = new System.Drawing.Size(315, 20);
            this.tbExpectedResponse.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(199, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "(seconds)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Delay";
            // 
            // numDelay
            // 
            this.numDelay.Location = new System.Drawing.Point(110, 70);
            this.numDelay.Name = "numDelay";
            this.numDelay.Size = new System.Drawing.Size(83, 20);
            this.numDelay.TabIndex = 4;
            this.numDelay.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Request URL";
            // 
            // textUrl
            // 
            this.textUrl.Location = new System.Drawing.Point(110, 7);
            this.textUrl.Name = "textUrl";
            this.textUrl.Size = new System.Drawing.Size(385, 20);
            this.textUrl.TabIndex = 1;
            this.textUrl.Text = "https://www.google.com";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStart.Location = new System.Drawing.Point(5, 143);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnStop.Enabled = false;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ForeColor = System.Drawing.Color.White;
            this.btnStop.Location = new System.Drawing.Point(90, 143);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // dgvResult
            // 
            this.dgvResult.AllowUserToAddRows = false;
            this.dgvResult.AllowUserToDeleteRows = false;
            this.dgvResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResult.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvResult.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Response,
            this.DateRequest,
            this.DateResponse,
            this.IsSuccess});
            this.dgvResult.EnableHeadersVisualStyles = false;
            this.dgvResult.Location = new System.Drawing.Point(5, 175);
            this.dgvResult.MultiSelect = false;
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.ReadOnly = true;
            this.dgvResult.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvResult.RowHeadersVisible = false;
            this.dgvResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvResult.ShowEditingIcon = false;
            this.dgvResult.Size = new System.Drawing.Size(809, 238);
            this.dgvResult.TabIndex = 3;
            this.dgvResult.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvResult_CellFormatting);
            // 
            // Response
            // 
            this.Response.HeaderText = "Response";
            this.Response.Name = "Response";
            this.Response.ReadOnly = true;
            this.Response.Visible = false;
            // 
            // DateRequest
            // 
            this.DateRequest.HeaderText = "Date Request";
            this.DateRequest.Name = "DateRequest";
            this.DateRequest.ReadOnly = true;
            // 
            // DateResponse
            // 
            this.DateResponse.HeaderText = "Response Time (ms)";
            this.DateResponse.Name = "DateResponse";
            this.DateResponse.ReadOnly = true;
            // 
            // IsSuccess
            // 
            this.IsSuccess.HeaderText = "Is Success";
            this.IsSuccess.Name = "IsSuccess";
            this.IsSuccess.ReadOnly = true;
            // 
            // pbWait
            // 
            this.pbWait.BackColor = System.Drawing.Color.White;
            this.pbWait.Location = new System.Drawing.Point(193, 146);
            this.pbWait.Name = "pbWait";
            this.pbWait.Size = new System.Drawing.Size(175, 20);
            this.pbWait.TabIndex = 5;
            this.pbWait.Visible = false;
            // 
            // picLoading
            // 
            this.picLoading.Image = global::PingWeb.Properties.Resources.progress;
            this.picLoading.Location = new System.Drawing.Point(374, 146);
            this.picLoading.Name = "picLoading";
            this.picLoading.Size = new System.Drawing.Size(34, 20);
            this.picLoading.TabIndex = 6;
            this.picLoading.TabStop = false;
            this.picLoading.Visible = false;
            // 
            // backgroundWorkerRequest
            // 
            this.backgroundWorkerRequest.WorkerReportsProgress = true;
            this.backgroundWorkerRequest.WorkerSupportsCancellation = true;
            this.backgroundWorkerRequest.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerRequest_DoWork);
            this.backgroundWorkerRequest.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerRequest_ProgressChanged);
            // 
            // FormHttpRequestTester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(826, 416);
            this.Controls.Add(this.picLoading);
            this.Controls.Add(this.pbWait);
            this.Controls.Add(this.dgvResult);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.panelMainStart);
            this.Controls.Add(this.btnStart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormHttpRequestTester";
            this.Text = "Ping Web";
            this.panelMainStart.ResumeLayout(false);
            this.panelMainStart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWait)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLoading)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMainStart;
        private System.Windows.Forms.TextBox textUrl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numDelay;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.DataGridView dgvResult;
        private System.Windows.Forms.CheckBox cbShowResponse;
        private System.Windows.Forms.DataGridViewTextBoxColumn Response;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateRequest;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateResponse;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsSuccess;
        private System.Windows.Forms.ProgressBar pbWait;
        private System.Windows.Forms.PictureBox picLoading;
        private System.Windows.Forms.CheckBox cbResponseSpecific;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbExpectedResponse;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numWait;
        private System.ComponentModel.BackgroundWorker backgroundWorkerRequest;
        private System.Windows.Forms.CheckBox cbSaveToDatabase;
        private System.Windows.Forms.CheckBox cbHideDataGrid;
    }
}

