using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace HttpRequestTester
{
    using System.IO;
    using System.Net;
    using System.Threading;

    using HttpRequestTester.Model;

    public partial class FormHttpRequestTester : Form
    {
        bool IsStarted { get; set; }

        string RequestUrl { get; set; }
        bool IsResponseSpecific { get; set; }
        string ExpectedResponse { get; set; }
        int DelayInSeconds { get; set; }
        int WaitInSeconds { get; set; }
        bool IsShowResponse { get; set; }
        bool IsSaveToDatabase { get; set; }
        bool IsHideDataGrid { get; set; }

        public FormHttpRequestTester()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            IsStarted = true;

            RequestUrl = textUrl.Text;
            IsResponseSpecific = cbResponseSpecific.Checked;
            ExpectedResponse = tbExpectedResponse.Text;
            DelayInSeconds = (int)this.numDelay.Value;
            WaitInSeconds = (int)this.numWait.Value;
            IsShowResponse = cbShowResponse.Checked;
            IsSaveToDatabase = cbSaveToDatabase.Checked;
            IsHideDataGrid = cbHideDataGrid.Checked;
            
            panelMainStart.Enabled = false;
            btnStart.Enabled = false;
            btnStop.Enabled = true;
            dgvResult.Rows.Clear();

            if (IsSaveToDatabase) DAL.Data.CreateDatabase();
            backgroundWorkerRequest.RunWorkerAsync();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            IsStarted = false;
            backgroundWorkerRequest.CancelAsync();
            panelMainStart.Enabled = true;
            btnStart.Enabled = true;
            btnStop.Enabled = false;
            pbWait.Visible = false;
        }

        private void backgroundWorkerRequest_DoWork(object sender, DoWorkEventArgs e)
        {
            while (IsStarted)
            {
                var httpGet = GetRequest();

                if (!IsHideDataGrid)
                {
                    dgvResult.Invoke(new Action(() =>
                    {
                        dgvResult.Rows.Insert(0, new[]{
                            IsShowResponse ? httpGet.Response : string.Empty,
                            httpGet.RequestDateTime.ToString(),
                            httpGet.ResponseTime.ToString(),
                            httpGet.IsSuccess ? "Yes" : "No"});
                    }));
                }
                
                float maxSteps = 100;
                for (int step = 1; step <= maxSteps; step++)
                {
                    if (!IsStarted) return;
                    pbWait.Invoke(new Action(() => { pbWait.Value = (int)(step *(100/ maxSteps)); pbWait.Visible = true; }));                    
                    Thread.Sleep((int)(DelayInSeconds*1000/maxSteps));
                }

                pbWait.Invoke(new Action(() => {pbWait.Visible = false; }));

                if(IsSaveToDatabase) DAL.Data.SaveToDb(httpGet);
                                
                //backgroundWorkerRequest.ReportProgress(0, httpGet);                
            }
        }

        private void backgroundWorkerRequest_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {   
            var httpGet = (HttpGet)e.UserState;
            dgvResult.Rows.Insert(
                0,
                new[]
                    {
                        IsShowResponse ? httpGet.Response : string.Empty, 
                        httpGet.RequestDateTime.ToString(), 
                        httpGet.ResponseTime.ToString(),
                        httpGet.IsSuccess ? "Yes" : "No"
                    });                       
            
        }

        private void dgvResult_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgvResult.Columns[e.ColumnIndex].Name == "IsSuccess")
            {
                if ((string)e.Value == "No")
                {
                    e.CellStyle.ForeColor = Color.Red;
                    e.CellStyle.Font = new Font(dgvResult.Font, FontStyle.Bold);
                }
            }
        }

        private void cbResponseAny_CheckedChanged(object sender, EventArgs e)
        {
            tbExpectedResponse.Visible = !IsResponseSpecific;
        }
                
        private void cbShowResponse_CheckedChanged(object sender, EventArgs e)
        {
            dgvResult.Rows.Clear();
            dgvResult.Columns[0].Visible = cbShowResponse.Checked;
        }

        private void cbHideDataGrid_CheckedChanged(object sender, EventArgs e)
        {
            cbShowResponse.Checked = false;
            cbShowResponse.Enabled = !cbHideDataGrid.Checked;
            dgvResult.Visible = true;
            if (cbHideDataGrid.Checked == true)
            {
                cbSaveToDatabase.Checked = true;
                dgvResult.Visible = false;
            }
        }

        private void cbSaveToDatabase_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSaveToDatabase.Checked == false) cbHideDataGrid.Checked = false;
        }

        private HttpGet GetRequest()
        {
            var httpGet = new HttpGet { Url = RequestUrl, RequestDateTime = DateTime.Now, IsSuccess = false };
            
            try
            {
                picLoading.Invoke(new Action(() => { picLoading.Visible = true; }));
                var request = (HttpWebRequest)WebRequest.Create(RequestUrl);
                request.Timeout = WaitInSeconds * 1000;
                var response = (HttpWebResponse)request.GetResponse();
                httpGet.Response = new StreamReader(response.GetResponseStream()).ReadToEnd();
                httpGet.ResponseDateTime = DateTime.Now;
                httpGet.ResponseTime = (int)((TimeSpan)(httpGet.ResponseDateTime - httpGet.RequestDateTime)).TotalMilliseconds;
                picLoading.Invoke(new Action(() => { picLoading.Visible = false; }));

                if (IsResponseSpecific && ExpectedResponse == httpGet.Response)
                {
                    httpGet.IsSuccess = true;
                }
                else if (!IsResponseSpecific)
                {
                    httpGet.IsSuccess = true;
                }
            }
            catch
            {
            }
                        
            return httpGet;
        }
        
    }
}
