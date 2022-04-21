using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PrinterCount
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int barCodeLength = 8;
        bool keepScanFocus = false;
        int roomNumber = 0;
        string printerID = "";
        DataGridViewRow selectedRow = null;
        DataTable table = new DataTable();

        private void Form1_Load(object sender, EventArgs e)
        {
            // address: wcscprintercount@gmail.com
            // pw: 777NotAdmin
            this.Size = new Size(430, 360);
            txtScan.Focus();
        }

        private void txtScan_TextChanged(object sender, EventArgs e)
        {
            if (txtScan.Text.Length >= barCodeLength)
            {
                keepScanFocus = false;

                var scanedChars = txtScan.Text.ToCharArray();

                lblRoomNumber.Text = "Room Number ";
                string o = "";
                for (int i = 0; i < 3; i++)
                {
                    o += scanedChars[i];
                }
                lblRoomNumber.Text += o;
                roomNumber = Convert.ToInt32(o);

                lblPrinterID.Text = "Printer ID ";
                o = "";
                for (int i = 3; i < txtScan.Text.Length; i++)
                {
                    o += scanedChars[i];
                }
                lblPrinterID.Text += o;
                printerID = o;

                panFile.Location = new Point(2000, 2000);
                panMain.Location = new Point(0, 0);
                txtScan.Text = "";
                txtPageCount.Text = "";
                lblErorrCount.Visible = false;
                txtScan.SendToBack();
                lblTitle.SendToBack();
                btnView.SendToBack();
                txtPageCount.Focus();
            }
        }

        private void tmrFocus_Tick(object sender, EventArgs e)
        {
            if (!txtScan.Focused && keepScanFocus)
            {
                txtScan.Focus();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtPageCount.Focused && e.KeyCode == Keys.Enter && txtPageCount.Text != "")
            {
                try
                {
                    AppendCSV(GetCurrentCSVFile(), roomNumber, printerID, Convert.ToInt32(txtPageCount.Text));
                    panMain.Location = new Point(1000, 1000);
                    lblErorrCount.Visible = false;
                    keepScanFocus = false;
                    txtScan.Focus();
                }
                catch
                {
                    lblErorrCount.Visible = true;
                    txtPageCount.Focus();
                    txtPageCount.Text = "";
                }
            }
        }

        private Dictionary<string, List<string>> ReadCSV(string csvName)
        {
            string path = string.Format("{0}Resources\\" + csvName + ".csv", Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\")));
            
            List<string> roomNumberList = new List<string>();
            List<string> printerIDList = new List<string>();
            List<string> pageCountList = new List<string>();
            
            using (var sr = new StreamReader(path))
            {
                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine();
                    var values = line.Split(',');

                    roomNumberList.Add(values[0]);
                    printerIDList.Add(values[1]);
                    pageCountList.Add(values[2]);

                }
            }

            return new Dictionary<string, List<string>>() 
            {
                { "roomnumber", roomNumberList},
                { "printerid", printerIDList},
                { "pagecount", pageCountList},
            };
        }

        private string GetCurrentCSVFile()
        {
            int month = DateTime.Now.Month;
            int year = DateTime.Now.Year;
            string path = "";

            if (month <= 6)
            {
                path += "Spring";
            }
            else
            {
                path += "Fall";
            }
            path += year.ToString();

            return path;
        }

        private void AppendCSV(string csvName, int roomNumber, string printerID, int pageCount)
        {
            string path = string.Format("{0}Resources\\" + csvName + ".csv", Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\")));

            if (!File.Exists(path))
            {
                File.Create(path).Close();
            }

            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine($"{roomNumber},{printerID},{pageCount}");
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (txtPageCount.Text != "")
            {
                try
                {
                    AppendCSV(GetCurrentCSVFile(), roomNumber, printerID, Convert.ToInt32(txtPageCount.Text));
                    panMain.Location = new Point(1000, 1000);
                    lblErorrCount.Visible = false;
                    keepScanFocus = false;
                    txtScan.Focus();
                }
                catch
                {
                    lblErorrCount.Visible = true;
                    txtPageCount.Focus();
                    txtPageCount.Text = "";
                }
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            panMain.Location = new Point(1000, 1000);
            panFile.Location = new Point(0, 0);
            
            try
            {
                lblDGVError.Visible = false;

                table = new DataTable();
                table.Columns.Add("Room Number", typeof(string));
                table.Columns.Add("Printer ID", typeof(string));
                table.Columns.Add("Page Count", typeof(string));

                txtViewingFile.Text = GetCurrentCSVFile();
                var data = ReadCSV(txtViewingFile.Text);

                for (int i = 0; i < data["roomnumber"].Count(); i++)
                {
                    table.Rows.Add(data["roomnumber"].ElementAt(i), data["printerid"].ElementAt(i), data["pagecount"].ElementAt(i));
                }

                dgvData.DataSource = table;
            }
            catch
            {
                lblDGVError.Visible = true;
                lblDGVError.Text = "Could Not Find File";
            }
        }

        private void btnEditView_Click(object sender, EventArgs e)
        {

            try
            {
                lblDGVError.Visible = false;

                table = new DataTable();
                table.Columns.Add("Room Number", typeof(string));
                table.Columns.Add("Printer ID", typeof(string));
                table.Columns.Add("Page Count", typeof(string));
               
                var data = ReadCSV(txtViewingFile.Text);

                for (int i = 0; i < data["roomnumber"].Count(); i++)
                {
                    table.Rows.Add(data["roomnumber"].ElementAt(i), data["printerid"].ElementAt(i), data["pagecount"].ElementAt(i));
                }

                dgvData.DataSource = table;
            }
            catch
            {
                lblDGVError.Visible = true;
                lblDGVError.Text = "Could Not Find File";
            }
        }

        private void btnDeleteRow_Click(object sender, EventArgs e)
        {
            lblDGVError.Visible = false;

            foreach (DataGridViewRow row in dgvData.SelectedRows)
            {
                dgvData.Rows.RemoveAt(row.Index);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            lblDGVError.Visible = false;
            selectedRow = dgvData.SelectedRows[0];

            txtEditRoomNumber.Text = selectedRow.Cells[0].Value.ToString();
            txtEditPrinterID.Text = selectedRow.Cells[1].Value.ToString();
            txtEditPageCount.Text = selectedRow.Cells[2].Value.ToString();
        }

        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
            try
            {
                lblDGVError.Visible = false;
                selectedRow.Cells[0].Value = Convert.ToInt32(txtEditRoomNumber.Text).ToString();
                selectedRow.Cells[1].Value = Convert.ToInt32(txtEditPrinterID.Text).ToString();
                selectedRow.Cells[2].Value = Convert.ToInt32(txtEditPageCount.Text).ToString();
            }
            catch
            {
                lblDGVError.Visible = true;
                lblDGVError.Text = "Invalid Edit";
            }
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            string data = "";
            int currentIndex = 0;
            foreach (DataRow row in table.Rows)
            {
                var itemarray = row.ItemArray;
                data += $"{itemarray[0]},{itemarray[1]},{itemarray[2]}";
                
                currentIndex++;
                if (currentIndex < table.Rows.Count)
                {
                    data += "\n";
                }
            }

            string path = string.Format("{0}Resources\\" + txtViewingFile.Text + ".csv", Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\")));
            File.WriteAllText(path, data);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            dgvData.DataSource = null;
            panFile.Location = new Point(2000, 2000);
            panMain.Location = new Point(1000, 1000);
        }
    }
}
