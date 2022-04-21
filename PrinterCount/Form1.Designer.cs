
namespace PrinterCount
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panMain = new System.Windows.Forms.Panel();
            this.lblErorrCount = new System.Windows.Forms.Label();
            this.txtPageCount = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.lblPageCount = new System.Windows.Forms.Label();
            this.lblPrinterID = new System.Windows.Forms.Label();
            this.lblRoomNumber = new System.Windows.Forms.Label();
            this.txtScan = new System.Windows.Forms.TextBox();
            this.tmrFocus = new System.Windows.Forms.Timer(this.components);
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnView = new System.Windows.Forms.Button();
            this.panFile = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSaveEdit = new System.Windows.Forms.Button();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.lblDGVError = new System.Windows.Forms.Label();
            this.txtEditPageCount = new System.Windows.Forms.TextBox();
            this.txtEditPrinterID = new System.Windows.Forms.TextBox();
            this.txtEditRoomNumber = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDeleteRow = new System.Windows.Forms.Button();
            this.btnEditView = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtViewingFile = new System.Windows.Forms.TextBox();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.panMain.SuspendLayout();
            this.panFile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // panMain
            // 
            this.panMain.Controls.Add(this.lblErorrCount);
            this.panMain.Controls.Add(this.txtPageCount);
            this.panMain.Controls.Add(this.btnEnter);
            this.panMain.Controls.Add(this.lblPageCount);
            this.panMain.Controls.Add(this.lblPrinterID);
            this.panMain.Controls.Add(this.lblRoomNumber);
            this.panMain.Location = new System.Drawing.Point(513, 359);
            this.panMain.Name = "panMain";
            this.panMain.Size = new System.Drawing.Size(415, 320);
            this.panMain.TabIndex = 0;
            // 
            // lblErorrCount
            // 
            this.lblErorrCount.AutoSize = true;
            this.lblErorrCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErorrCount.ForeColor = System.Drawing.Color.Red;
            this.lblErorrCount.Location = new System.Drawing.Point(130, 172);
            this.lblErorrCount.Name = "lblErorrCount";
            this.lblErorrCount.Size = new System.Drawing.Size(130, 13);
            this.lblErorrCount.TabIndex = 7;
            this.lblErorrCount.Text = "Please enter a valid count";
            this.lblErorrCount.Visible = false;
            // 
            // txtPageCount
            // 
            this.txtPageCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPageCount.Location = new System.Drawing.Point(162, 147);
            this.txtPageCount.Name = "txtPageCount";
            this.txtPageCount.Size = new System.Drawing.Size(134, 22);
            this.txtPageCount.TabIndex = 6;
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(145, 219);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(81, 28);
            this.btnEnter.TabIndex = 3;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // lblPageCount
            // 
            this.lblPageCount.AutoSize = true;
            this.lblPageCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageCount.Location = new System.Drawing.Point(80, 150);
            this.lblPageCount.Name = "lblPageCount";
            this.lblPageCount.Size = new System.Drawing.Size(75, 16);
            this.lblPageCount.TabIndex = 5;
            this.lblPageCount.Text = "PageCount";
            // 
            // lblPrinterID
            // 
            this.lblPrinterID.AutoSize = true;
            this.lblPrinterID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrinterID.Location = new System.Drawing.Point(158, 81);
            this.lblPrinterID.Name = "lblPrinterID";
            this.lblPrinterID.Size = new System.Drawing.Size(51, 20);
            this.lblPrinterID.TabIndex = 4;
            this.lblPrinterID.Text = "label1";
            // 
            // lblRoomNumber
            // 
            this.lblRoomNumber.AutoSize = true;
            this.lblRoomNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomNumber.Location = new System.Drawing.Point(158, 44);
            this.lblRoomNumber.Name = "lblRoomNumber";
            this.lblRoomNumber.Size = new System.Drawing.Size(51, 20);
            this.lblRoomNumber.TabIndex = 3;
            this.lblRoomNumber.Text = "label1";
            // 
            // txtScan
            // 
            this.txtScan.Location = new System.Drawing.Point(141, 153);
            this.txtScan.Name = "txtScan";
            this.txtScan.Size = new System.Drawing.Size(100, 20);
            this.txtScan.TabIndex = 0;
            this.txtScan.TextChanged += new System.EventHandler(this.txtScan_TextChanged);
            // 
            // tmrFocus
            // 
            this.tmrFocus.Interval = 50;
            this.tmrFocus.Tick += new System.EventHandler(this.tmrFocus_Tick);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(105, 60);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(193, 37);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Scan Printer";
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(319, 266);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(83, 43);
            this.btnView.TabIndex = 3;
            this.btnView.Text = "View Data";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // panFile
            // 
            this.panFile.Controls.Add(this.btnClose);
            this.panFile.Controls.Add(this.btnSaveEdit);
            this.panFile.Controls.Add(this.btnSaveFile);
            this.panFile.Controls.Add(this.lblDGVError);
            this.panFile.Controls.Add(this.txtEditPageCount);
            this.panFile.Controls.Add(this.txtEditPrinterID);
            this.panFile.Controls.Add(this.txtEditRoomNumber);
            this.panFile.Controls.Add(this.btnEdit);
            this.panFile.Controls.Add(this.btnDeleteRow);
            this.panFile.Controls.Add(this.btnEditView);
            this.panFile.Controls.Add(this.label1);
            this.panFile.Controls.Add(this.txtViewingFile);
            this.panFile.Controls.Add(this.dgvData);
            this.panFile.Location = new System.Drawing.Point(493, 23);
            this.panFile.Name = "panFile";
            this.panFile.Size = new System.Drawing.Size(415, 320);
            this.panFile.TabIndex = 8;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(324, 233);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 20;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSaveEdit
            // 
            this.btnSaveEdit.Location = new System.Drawing.Point(324, 175);
            this.btnSaveEdit.Name = "btnSaveEdit";
            this.btnSaveEdit.Size = new System.Drawing.Size(75, 23);
            this.btnSaveEdit.TabIndex = 19;
            this.btnSaveEdit.Text = "Save Edit";
            this.btnSaveEdit.UseVisualStyleBackColor = true;
            this.btnSaveEdit.Click += new System.EventHandler(this.btnSaveEdit_Click);
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Location = new System.Drawing.Point(324, 204);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(75, 23);
            this.btnSaveFile.TabIndex = 18;
            this.btnSaveFile.Text = "Save File";
            this.btnSaveFile.UseVisualStyleBackColor = true;
            this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
            // 
            // lblDGVError
            // 
            this.lblDGVError.AutoSize = true;
            this.lblDGVError.ForeColor = System.Drawing.Color.Red;
            this.lblDGVError.Location = new System.Drawing.Point(275, 16);
            this.lblDGVError.Name = "lblDGVError";
            this.lblDGVError.Size = new System.Drawing.Size(96, 13);
            this.lblDGVError.TabIndex = 17;
            this.lblDGVError.Text = "Could Not Find File";
            this.lblDGVError.Visible = false;
            // 
            // txtEditPageCount
            // 
            this.txtEditPageCount.Location = new System.Drawing.Point(318, 148);
            this.txtEditPageCount.Name = "txtEditPageCount";
            this.txtEditPageCount.Size = new System.Drawing.Size(87, 20);
            this.txtEditPageCount.TabIndex = 16;
            // 
            // txtEditPrinterID
            // 
            this.txtEditPrinterID.Location = new System.Drawing.Point(318, 122);
            this.txtEditPrinterID.Name = "txtEditPrinterID";
            this.txtEditPrinterID.Size = new System.Drawing.Size(87, 20);
            this.txtEditPrinterID.TabIndex = 15;
            // 
            // txtEditRoomNumber
            // 
            this.txtEditRoomNumber.Location = new System.Drawing.Point(318, 96);
            this.txtEditRoomNumber.Name = "txtEditRoomNumber";
            this.txtEditRoomNumber.Size = new System.Drawing.Size(87, 20);
            this.txtEditRoomNumber.TabIndex = 14;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(324, 68);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 13;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDeleteRow
            // 
            this.btnDeleteRow.Location = new System.Drawing.Point(324, 39);
            this.btnDeleteRow.Name = "btnDeleteRow";
            this.btnDeleteRow.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteRow.TabIndex = 12;
            this.btnDeleteRow.Text = "Delete";
            this.btnDeleteRow.UseVisualStyleBackColor = true;
            this.btnDeleteRow.Click += new System.EventHandler(this.btnDeleteRow_Click);
            // 
            // btnEditView
            // 
            this.btnEditView.Location = new System.Drawing.Point(161, 11);
            this.btnEditView.Name = "btnEditView";
            this.btnEditView.Size = new System.Drawing.Size(64, 23);
            this.btnEditView.TabIndex = 11;
            this.btnEditView.Text = "View";
            this.btnEditView.UseVisualStyleBackColor = true;
            this.btnEditView.Click += new System.EventHandler(this.btnEditView_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "File:";
            // 
            // txtViewingFile
            // 
            this.txtViewingFile.Location = new System.Drawing.Point(55, 13);
            this.txtViewingFile.Name = "txtViewingFile";
            this.txtViewingFile.Size = new System.Drawing.Size(100, 20);
            this.txtViewingFile.TabIndex = 9;
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(3, 39);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.Size = new System.Drawing.Size(309, 278);
            this.dgvData.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 566);
            this.Controls.Add(this.panFile);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtScan);
            this.Controls.Add(this.panMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Printer Count";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.panMain.ResumeLayout(false);
            this.panMain.PerformLayout();
            this.panFile.ResumeLayout(false);
            this.panFile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panMain;
        private System.Windows.Forms.TextBox txtScan;
        private System.Windows.Forms.Label lblPrinterID;
        private System.Windows.Forms.Label lblRoomNumber;
        private System.Windows.Forms.Label lblPageCount;
        private System.Windows.Forms.Timer tmrFocus;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.TextBox txtPageCount;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblErorrCount;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Panel panFile;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtViewingFile;
        private System.Windows.Forms.Button btnEditView;
        private System.Windows.Forms.TextBox txtEditPageCount;
        private System.Windows.Forms.TextBox txtEditPrinterID;
        private System.Windows.Forms.TextBox txtEditRoomNumber;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDeleteRow;
        private System.Windows.Forms.Label lblDGVError;
        private System.Windows.Forms.Button btnSaveFile;
        private System.Windows.Forms.Button btnSaveEdit;
        private System.Windows.Forms.Button btnClose;
    }
}

