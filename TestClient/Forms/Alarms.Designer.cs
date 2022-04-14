﻿
namespace MetasysServices_TestClient.Forms
{
    partial class Alarms
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
            this.TabMain = new System.Windows.Forms.TabControl();
            this.TpgGet = new System.Windows.Forms.TabPage();
            this.TlpGet = new System.Windows.Forms.TableLayoutPanel();
            this.LblGet_Filters = new System.Windows.Forms.Label();
            this.TlpGet_Filters = new System.Windows.Forms.TableLayoutPanel();
            this.LblGet_StartTime = new System.Windows.Forms.Label();
            this.DtpGet_StartTime = new System.Windows.Forms.DateTimePicker();
            this.LblGet_EndTime = new System.Windows.Forms.Label();
            this.DtpGet_EndTime = new System.Windows.Forms.DateTimePicker();
            this.ChkGet_ExcludeAcknowledged = new System.Windows.Forms.CheckBox();
            this.ChkGet_ExcludeDiscarded = new System.Windows.Forms.CheckBox();
            this.ChkGet_NoFilters = new System.Windows.Forms.CheckBox();
            this.BtnGet = new System.Windows.Forms.Button();
            this.DgvGet = new System.Windows.Forms.DataGridView();
            this.LblGet_Title = new System.Windows.Forms.Label();
            this.TpgFindById = new System.Windows.Forms.TabPage();
            this.TlpFindById = new System.Windows.Forms.TableLayoutPanel();
            this.LblFindById_AlarmId = new System.Windows.Forms.Label();
            this.TxtFindById_AlarmId = new System.Windows.Forms.TextBox();
            this.BtnFindById = new System.Windows.Forms.Button();
            this.PrgFindById = new System.Windows.Forms.PropertyGrid();
            this.LblFindById_Title = new System.Windows.Forms.Label();
            this.TpgGetForNetworkDevice = new System.Windows.Forms.TabPage();
            this.TlpGetForNetworkDevice = new System.Windows.Forms.TableLayoutPanel();
            this.LblGetForNetworkDevice_DeviceId = new System.Windows.Forms.Label();
            this.TxtGetForNetworkDevice_DeviceId = new System.Windows.Forms.TextBox();
            this.LblGetForNetworkDevice_Filters = new System.Windows.Forms.Label();
            this.TlpGetForNetworkDevice_Filters = new System.Windows.Forms.TableLayoutPanel();
            this.LblGetForNetworkDevice_StartTime = new System.Windows.Forms.Label();
            this.LblGetForNetworkDevice_EndTime = new System.Windows.Forms.Label();
            this.DtpGetForNetworkDevice_StartTime = new System.Windows.Forms.DateTimePicker();
            this.DtpGetForNetworkDevice_EndTime = new System.Windows.Forms.DateTimePicker();
            this.ChkGetForNetworkDevice_ExcludeAcknowledged = new System.Windows.Forms.CheckBox();
            this.ChkGetForNetworkDevice_ExcludeDiscarded = new System.Windows.Forms.CheckBox();
            this.ChkGetForNetworkDevice_NoFilters = new System.Windows.Forms.CheckBox();
            this.BtnGetForNetworkDevice = new System.Windows.Forms.Button();
            this.DgvGetForNetworkDevice = new System.Windows.Forms.DataGridView();
            this.LblGetForNetworkDevice_Title = new System.Windows.Forms.Label();
            this.TpgGetForObject = new System.Windows.Forms.TabPage();
            this.TlpGetForObject = new System.Windows.Forms.TableLayoutPanel();
            this.LblGetForObject_ObjectId = new System.Windows.Forms.Label();
            this.TxtGetForObject_ObjectId = new System.Windows.Forms.TextBox();
            this.LblGetForObject_Filters = new System.Windows.Forms.Label();
            this.TlpGetForObject_Filters = new System.Windows.Forms.TableLayoutPanel();
            this.LblGetForObject_StartTime = new System.Windows.Forms.Label();
            this.LblGetForObject_EndTime = new System.Windows.Forms.Label();
            this.DtpGetForObject_StartTime = new System.Windows.Forms.DateTimePicker();
            this.DtpGetForObject_EndTime = new System.Windows.Forms.DateTimePicker();
            this.ChkGetForObject_ExcludeAcknowledged = new System.Windows.Forms.CheckBox();
            this.ChkGetForObject_ExcludeDiscarded = new System.Windows.Forms.CheckBox();
            this.ChkGetForObject_NoFilters = new System.Windows.Forms.CheckBox();
            this.BtnGetForObject = new System.Windows.Forms.Button();
            this.DgvGetForObject = new System.Windows.Forms.DataGridView();
            this.LblGetForObject_Title = new System.Windows.Forms.Label();
            this.TpgGetAnnotations = new System.Windows.Forms.TabPage();
            this.TlpGetAnnotations = new System.Windows.Forms.TableLayoutPanel();
            this.LblGetAnnotations_AlarmId = new System.Windows.Forms.Label();
            this.TxtGetAnnotations_AlarmId = new System.Windows.Forms.TextBox();
            this.BtnGetAnnotations = new System.Windows.Forms.Button();
            this.TxtGetAnnotations_Result = new System.Windows.Forms.TextBox();
            this.GetAnnotations_Title = new System.Windows.Forms.Label();
            this.TpgAcknowledge = new System.Windows.Forms.TabPage();
            this.TlpAckAlarm = new System.Windows.Forms.TableLayoutPanel();
            this.LblAckAlarm_AlarmId = new System.Windows.Forms.Label();
            this.TxtAckAlarm_AlarmId = new System.Windows.Forms.TextBox();
            this.LblAckAlarm_AnnotationText = new System.Windows.Forms.Label();
            this.TxtAckAlarm_AnnotationText = new System.Windows.Forms.TextBox();
            this.BtnAcknowledgeAlarm = new System.Windows.Forms.Button();
            this.TxtAckAlarm_Result = new System.Windows.Forms.TextBox();
            this.LblAckAlarm_Result = new System.Windows.Forms.Label();
            this.LblAck_Title = new System.Windows.Forms.Label();
            this.TpgDiscardAlarm = new System.Windows.Forms.TabPage();
            this.TlpDiscardAlarm = new System.Windows.Forms.TableLayoutPanel();
            this.LblDiscardAlarm_AlarmId = new System.Windows.Forms.Label();
            this.TxtDiscardAlarm_AlarmId = new System.Windows.Forms.TextBox();
            this.LblDiscardAlarm_AnnotationText = new System.Windows.Forms.Label();
            this.TxtDiscardAlarm_AnnotationText = new System.Windows.Forms.TextBox();
            this.BtnDiscardAlarm = new System.Windows.Forms.Button();
            this.TxtDiscardAlarm_Result = new System.Windows.Forms.TextBox();
            this.LblDiscardAlarm_Result = new System.Windows.Forms.Label();
            this.LblDiscard_Title = new System.Windows.Forms.Label();
            this.TabMain.SuspendLayout();
            this.TpgGet.SuspendLayout();
            this.TlpGet.SuspendLayout();
            this.TlpGet_Filters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvGet)).BeginInit();
            this.TpgFindById.SuspendLayout();
            this.TlpFindById.SuspendLayout();
            this.TpgGetForNetworkDevice.SuspendLayout();
            this.TlpGetForNetworkDevice.SuspendLayout();
            this.TlpGetForNetworkDevice_Filters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvGetForNetworkDevice)).BeginInit();
            this.TpgGetForObject.SuspendLayout();
            this.TlpGetForObject.SuspendLayout();
            this.TlpGetForObject_Filters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvGetForObject)).BeginInit();
            this.TpgGetAnnotations.SuspendLayout();
            this.TlpGetAnnotations.SuspendLayout();
            this.TpgAcknowledge.SuspendLayout();
            this.TlpAckAlarm.SuspendLayout();
            this.TpgDiscardAlarm.SuspendLayout();
            this.TlpDiscardAlarm.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabMain
            // 
            this.TabMain.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.TabMain.Controls.Add(this.TpgGet);
            this.TabMain.Controls.Add(this.TpgFindById);
            this.TabMain.Controls.Add(this.TpgGetForNetworkDevice);
            this.TabMain.Controls.Add(this.TpgGetForObject);
            this.TabMain.Controls.Add(this.TpgGetAnnotations);
            this.TabMain.Controls.Add(this.TpgAcknowledge);
            this.TabMain.Controls.Add(this.TpgDiscardAlarm);
            this.TabMain.ItemSize = new System.Drawing.Size(58, 25);
            this.TabMain.Location = new System.Drawing.Point(12, 12);
            this.TabMain.Name = "TabMain";
            this.TabMain.SelectedIndex = 0;
            this.TabMain.Size = new System.Drawing.Size(892, 633);
            this.TabMain.TabIndex = 0;
            // 
            // TpgGet
            // 
            this.TpgGet.Controls.Add(this.TlpGet);
            this.TpgGet.Location = new System.Drawing.Point(4, 29);
            this.TpgGet.Name = "TpgGet";
            this.TpgGet.Padding = new System.Windows.Forms.Padding(3);
            this.TpgGet.Size = new System.Drawing.Size(884, 600);
            this.TpgGet.TabIndex = 5;
            this.TpgGet.Text = "Get";
            this.TpgGet.UseVisualStyleBackColor = true;
            // 
            // TlpGet
            // 
            this.TlpGet.ColumnCount = 5;
            this.TlpGet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TlpGet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TlpGet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpGet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TlpGet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TlpGet.Controls.Add(this.LblGet_Filters, 1, 1);
            this.TlpGet.Controls.Add(this.TlpGet_Filters, 2, 1);
            this.TlpGet.Controls.Add(this.ChkGet_NoFilters, 3, 1);
            this.TlpGet.Controls.Add(this.BtnGet, 2, 2);
            this.TlpGet.Controls.Add(this.DgvGet, 2, 3);
            this.TlpGet.Controls.Add(this.LblGet_Title, 0, 0);
            this.TlpGet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpGet.Location = new System.Drawing.Point(3, 3);
            this.TlpGet.Name = "TlpGet";
            this.TlpGet.RowCount = 4;
            this.TlpGet.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TlpGet.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TlpGet.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TlpGet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpGet.Size = new System.Drawing.Size(878, 594);
            this.TlpGet.TabIndex = 0;
            // 
            // LblGet_Filters
            // 
            this.LblGet_Filters.AutoSize = true;
            this.LblGet_Filters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblGet_Filters.Location = new System.Drawing.Point(23, 25);
            this.LblGet_Filters.Margin = new System.Windows.Forms.Padding(3);
            this.LblGet_Filters.MinimumSize = new System.Drawing.Size(140, 0);
            this.LblGet_Filters.Name = "LblGet_Filters";
            this.LblGet_Filters.Size = new System.Drawing.Size(140, 52);
            this.LblGet_Filters.TabIndex = 0;
            this.LblGet_Filters.Text = "Filters:";
            this.LblGet_Filters.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TlpGet_Filters
            // 
            this.TlpGet_Filters.AutoSize = true;
            this.TlpGet_Filters.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TlpGet_Filters.ColumnCount = 4;
            this.TlpGet_Filters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TlpGet_Filters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpGet_Filters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TlpGet_Filters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpGet_Filters.Controls.Add(this.LblGet_StartTime, 0, 0);
            this.TlpGet_Filters.Controls.Add(this.DtpGet_StartTime, 1, 0);
            this.TlpGet_Filters.Controls.Add(this.LblGet_EndTime, 2, 0);
            this.TlpGet_Filters.Controls.Add(this.DtpGet_EndTime, 3, 0);
            this.TlpGet_Filters.Controls.Add(this.ChkGet_ExcludeAcknowledged, 1, 1);
            this.TlpGet_Filters.Controls.Add(this.ChkGet_ExcludeDiscarded, 3, 1);
            this.TlpGet_Filters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpGet_Filters.Location = new System.Drawing.Point(169, 25);
            this.TlpGet_Filters.Name = "TlpGet_Filters";
            this.TlpGet_Filters.RowCount = 2;
            this.TlpGet_Filters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpGet_Filters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpGet_Filters.Size = new System.Drawing.Size(615, 52);
            this.TlpGet_Filters.TabIndex = 1;
            // 
            // LblGet_StartTime
            // 
            this.LblGet_StartTime.AutoSize = true;
            this.LblGet_StartTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblGet_StartTime.Location = new System.Drawing.Point(3, 3);
            this.LblGet_StartTime.Margin = new System.Windows.Forms.Padding(3);
            this.LblGet_StartTime.Name = "LblGet_StartTime";
            this.LblGet_StartTime.Size = new System.Drawing.Size(55, 20);
            this.LblGet_StartTime.TabIndex = 0;
            this.LblGet_StartTime.Text = "Start Time";
            this.LblGet_StartTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DtpGet_StartTime
            // 
            this.DtpGet_StartTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DtpGet_StartTime.Location = new System.Drawing.Point(64, 3);
            this.DtpGet_StartTime.Name = "DtpGet_StartTime";
            this.DtpGet_StartTime.Size = new System.Drawing.Size(242, 20);
            this.DtpGet_StartTime.TabIndex = 1;
            // 
            // LblGet_EndTime
            // 
            this.LblGet_EndTime.AutoSize = true;
            this.LblGet_EndTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblGet_EndTime.Location = new System.Drawing.Point(312, 3);
            this.LblGet_EndTime.Margin = new System.Windows.Forms.Padding(3);
            this.LblGet_EndTime.Name = "LblGet_EndTime";
            this.LblGet_EndTime.Size = new System.Drawing.Size(52, 20);
            this.LblGet_EndTime.TabIndex = 2;
            this.LblGet_EndTime.Text = "End Time";
            this.LblGet_EndTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DtpGet_EndTime
            // 
            this.DtpGet_EndTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DtpGet_EndTime.Location = new System.Drawing.Point(370, 3);
            this.DtpGet_EndTime.Name = "DtpGet_EndTime";
            this.DtpGet_EndTime.Size = new System.Drawing.Size(242, 20);
            this.DtpGet_EndTime.TabIndex = 3;
            // 
            // ChkGet_ExcludeAcknowledged
            // 
            this.ChkGet_ExcludeAcknowledged.AutoSize = true;
            this.ChkGet_ExcludeAcknowledged.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChkGet_ExcludeAcknowledged.Location = new System.Drawing.Point(64, 29);
            this.ChkGet_ExcludeAcknowledged.Name = "ChkGet_ExcludeAcknowledged";
            this.ChkGet_ExcludeAcknowledged.Size = new System.Drawing.Size(242, 20);
            this.ChkGet_ExcludeAcknowledged.TabIndex = 4;
            this.ChkGet_ExcludeAcknowledged.Text = "Exclude Acknowledged";
            this.ChkGet_ExcludeAcknowledged.UseVisualStyleBackColor = true;
            // 
            // ChkGet_ExcludeDiscarded
            // 
            this.ChkGet_ExcludeDiscarded.AutoSize = true;
            this.ChkGet_ExcludeDiscarded.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChkGet_ExcludeDiscarded.Location = new System.Drawing.Point(370, 29);
            this.ChkGet_ExcludeDiscarded.Name = "ChkGet_ExcludeDiscarded";
            this.ChkGet_ExcludeDiscarded.Size = new System.Drawing.Size(242, 20);
            this.ChkGet_ExcludeDiscarded.TabIndex = 5;
            this.ChkGet_ExcludeDiscarded.Text = "Exclude Discarded";
            this.ChkGet_ExcludeDiscarded.UseVisualStyleBackColor = true;
            // 
            // ChkGet_NoFilters
            // 
            this.ChkGet_NoFilters.AutoSize = true;
            this.ChkGet_NoFilters.Dock = System.Windows.Forms.DockStyle.Left;
            this.ChkGet_NoFilters.Location = new System.Drawing.Point(790, 25);
            this.ChkGet_NoFilters.Name = "ChkGet_NoFilters";
            this.ChkGet_NoFilters.Size = new System.Drawing.Size(65, 52);
            this.ChkGet_NoFilters.TabIndex = 2;
            this.ChkGet_NoFilters.Text = "No Filter";
            this.ChkGet_NoFilters.UseVisualStyleBackColor = true;
            this.ChkGet_NoFilters.CheckedChanged += new System.EventHandler(this.ChkGet_NoFilters_CheckedChanged);
            // 
            // BtnGet
            // 
            this.TlpGet.SetColumnSpan(this.BtnGet, 2);
            this.BtnGet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnGet.Location = new System.Drawing.Point(169, 83);
            this.BtnGet.MinimumSize = new System.Drawing.Size(130, 0);
            this.BtnGet.Name = "BtnGet";
            this.BtnGet.Size = new System.Drawing.Size(686, 23);
            this.BtnGet.TabIndex = 3;
            this.BtnGet.Text = "Alarms.Get";
            this.BtnGet.UseVisualStyleBackColor = true;
            this.BtnGet.Click += new System.EventHandler(this.BtnGet_Click);
            // 
            // DgvGet
            // 
            this.DgvGet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TlpGet.SetColumnSpan(this.DgvGet, 2);
            this.DgvGet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvGet.Location = new System.Drawing.Point(169, 112);
            this.DgvGet.Name = "DgvGet";
            this.DgvGet.Size = new System.Drawing.Size(686, 479);
            this.DgvGet.TabIndex = 4;
            // 
            // LblGet_Title
            // 
            this.LblGet_Title.AutoSize = true;
            this.TlpGet.SetColumnSpan(this.LblGet_Title, 4);
            this.LblGet_Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblGet_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGet_Title.ForeColor = System.Drawing.Color.RoyalBlue;
            this.LblGet_Title.Location = new System.Drawing.Point(3, 3);
            this.LblGet_Title.Margin = new System.Windows.Forms.Padding(3);
            this.LblGet_Title.Name = "LblGet_Title";
            this.LblGet_Title.Size = new System.Drawing.Size(852, 16);
            this.LblGet_Title.TabIndex = 5;
            this.LblGet_Title.Text = "Retrieves a collection of alarms.";
            this.LblGet_Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TpgFindById
            // 
            this.TpgFindById.Controls.Add(this.TlpFindById);
            this.TpgFindById.Location = new System.Drawing.Point(4, 29);
            this.TpgFindById.Name = "TpgFindById";
            this.TpgFindById.Padding = new System.Windows.Forms.Padding(3);
            this.TpgFindById.Size = new System.Drawing.Size(884, 600);
            this.TpgFindById.TabIndex = 1;
            this.TpgFindById.Text = "FindById";
            this.TpgFindById.UseVisualStyleBackColor = true;
            // 
            // TlpFindById
            // 
            this.TlpFindById.ColumnCount = 4;
            this.TlpFindById.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TlpFindById.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TlpFindById.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpFindById.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TlpFindById.Controls.Add(this.LblFindById_AlarmId, 1, 1);
            this.TlpFindById.Controls.Add(this.TxtFindById_AlarmId, 2, 1);
            this.TlpFindById.Controls.Add(this.BtnFindById, 2, 2);
            this.TlpFindById.Controls.Add(this.PrgFindById, 2, 3);
            this.TlpFindById.Controls.Add(this.LblFindById_Title, 0, 0);
            this.TlpFindById.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpFindById.Location = new System.Drawing.Point(3, 3);
            this.TlpFindById.Name = "TlpFindById";
            this.TlpFindById.RowCount = 4;
            this.TlpFindById.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TlpFindById.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TlpFindById.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TlpFindById.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpFindById.Size = new System.Drawing.Size(878, 594);
            this.TlpFindById.TabIndex = 0;
            // 
            // LblFindById_AlarmId
            // 
            this.LblFindById_AlarmId.AutoSize = true;
            this.LblFindById_AlarmId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblFindById_AlarmId.Location = new System.Drawing.Point(23, 25);
            this.LblFindById_AlarmId.Margin = new System.Windows.Forms.Padding(3);
            this.LblFindById_AlarmId.MinimumSize = new System.Drawing.Size(140, 0);
            this.LblFindById_AlarmId.Name = "LblFindById_AlarmId";
            this.LblFindById_AlarmId.Size = new System.Drawing.Size(140, 20);
            this.LblFindById_AlarmId.TabIndex = 0;
            this.LblFindById_AlarmId.Text = "Alarm ID (GUID):";
            this.LblFindById_AlarmId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtFindById_AlarmId
            // 
            this.TxtFindById_AlarmId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtFindById_AlarmId.Location = new System.Drawing.Point(169, 25);
            this.TxtFindById_AlarmId.Name = "TxtFindById_AlarmId";
            this.TxtFindById_AlarmId.Size = new System.Drawing.Size(686, 20);
            this.TxtFindById_AlarmId.TabIndex = 1;
            // 
            // BtnFindById
            // 
            this.BtnFindById.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnFindById.Location = new System.Drawing.Point(169, 51);
            this.BtnFindById.MinimumSize = new System.Drawing.Size(130, 0);
            this.BtnFindById.Name = "BtnFindById";
            this.BtnFindById.Size = new System.Drawing.Size(686, 23);
            this.BtnFindById.TabIndex = 2;
            this.BtnFindById.Text = "Alarms.FindById";
            this.BtnFindById.UseVisualStyleBackColor = true;
            this.BtnFindById.Click += new System.EventHandler(this.BtnFindById_Click);
            // 
            // PrgFindById
            // 
            this.PrgFindById.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PrgFindById.HelpVisible = false;
            this.PrgFindById.Location = new System.Drawing.Point(169, 80);
            this.PrgFindById.Name = "PrgFindById";
            this.PrgFindById.Size = new System.Drawing.Size(686, 511);
            this.PrgFindById.TabIndex = 3;
            // 
            // LblFindById_Title
            // 
            this.LblFindById_Title.AutoSize = true;
            this.TlpFindById.SetColumnSpan(this.LblFindById_Title, 4);
            this.LblFindById_Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblFindById_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFindById_Title.ForeColor = System.Drawing.Color.RoyalBlue;
            this.LblFindById_Title.Location = new System.Drawing.Point(3, 3);
            this.LblFindById_Title.Margin = new System.Windows.Forms.Padding(3);
            this.LblFindById_Title.Name = "LblFindById_Title";
            this.LblFindById_Title.Size = new System.Drawing.Size(872, 16);
            this.LblFindById_Title.TabIndex = 4;
            this.LblFindById_Title.Text = "Retrieves the specified alarm.";
            this.LblFindById_Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TpgGetForNetworkDevice
            // 
            this.TpgGetForNetworkDevice.Controls.Add(this.TlpGetForNetworkDevice);
            this.TpgGetForNetworkDevice.Location = new System.Drawing.Point(4, 29);
            this.TpgGetForNetworkDevice.Name = "TpgGetForNetworkDevice";
            this.TpgGetForNetworkDevice.Padding = new System.Windows.Forms.Padding(3);
            this.TpgGetForNetworkDevice.Size = new System.Drawing.Size(884, 600);
            this.TpgGetForNetworkDevice.TabIndex = 2;
            this.TpgGetForNetworkDevice.Text = "GetForNetworkDevice";
            this.TpgGetForNetworkDevice.UseVisualStyleBackColor = true;
            // 
            // TlpGetForNetworkDevice
            // 
            this.TlpGetForNetworkDevice.ColumnCount = 5;
            this.TlpGetForNetworkDevice.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TlpGetForNetworkDevice.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TlpGetForNetworkDevice.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpGetForNetworkDevice.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TlpGetForNetworkDevice.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TlpGetForNetworkDevice.Controls.Add(this.LblGetForNetworkDevice_DeviceId, 1, 1);
            this.TlpGetForNetworkDevice.Controls.Add(this.TxtGetForNetworkDevice_DeviceId, 2, 1);
            this.TlpGetForNetworkDevice.Controls.Add(this.LblGetForNetworkDevice_Filters, 1, 2);
            this.TlpGetForNetworkDevice.Controls.Add(this.TlpGetForNetworkDevice_Filters, 2, 2);
            this.TlpGetForNetworkDevice.Controls.Add(this.ChkGetForNetworkDevice_NoFilters, 3, 2);
            this.TlpGetForNetworkDevice.Controls.Add(this.BtnGetForNetworkDevice, 2, 3);
            this.TlpGetForNetworkDevice.Controls.Add(this.DgvGetForNetworkDevice, 2, 4);
            this.TlpGetForNetworkDevice.Controls.Add(this.LblGetForNetworkDevice_Title, 0, 0);
            this.TlpGetForNetworkDevice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpGetForNetworkDevice.Location = new System.Drawing.Point(3, 3);
            this.TlpGetForNetworkDevice.Name = "TlpGetForNetworkDevice";
            this.TlpGetForNetworkDevice.RowCount = 5;
            this.TlpGetForNetworkDevice.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TlpGetForNetworkDevice.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TlpGetForNetworkDevice.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TlpGetForNetworkDevice.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TlpGetForNetworkDevice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpGetForNetworkDevice.Size = new System.Drawing.Size(878, 594);
            this.TlpGetForNetworkDevice.TabIndex = 0;
            // 
            // LblGetForNetworkDevice_DeviceId
            // 
            this.LblGetForNetworkDevice_DeviceId.AutoSize = true;
            this.LblGetForNetworkDevice_DeviceId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblGetForNetworkDevice_DeviceId.Location = new System.Drawing.Point(23, 25);
            this.LblGetForNetworkDevice_DeviceId.Margin = new System.Windows.Forms.Padding(3);
            this.LblGetForNetworkDevice_DeviceId.MinimumSize = new System.Drawing.Size(140, 0);
            this.LblGetForNetworkDevice_DeviceId.Name = "LblGetForNetworkDevice_DeviceId";
            this.LblGetForNetworkDevice_DeviceId.Size = new System.Drawing.Size(140, 20);
            this.LblGetForNetworkDevice_DeviceId.TabIndex = 0;
            this.LblGetForNetworkDevice_DeviceId.Text = "Device ID (GUID):";
            this.LblGetForNetworkDevice_DeviceId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtGetForNetworkDevice_DeviceId
            // 
            this.TlpGetForNetworkDevice.SetColumnSpan(this.TxtGetForNetworkDevice_DeviceId, 2);
            this.TxtGetForNetworkDevice_DeviceId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtGetForNetworkDevice_DeviceId.Location = new System.Drawing.Point(169, 25);
            this.TxtGetForNetworkDevice_DeviceId.Name = "TxtGetForNetworkDevice_DeviceId";
            this.TxtGetForNetworkDevice_DeviceId.Size = new System.Drawing.Size(686, 20);
            this.TxtGetForNetworkDevice_DeviceId.TabIndex = 1;
            // 
            // LblGetForNetworkDevice_Filters
            // 
            this.LblGetForNetworkDevice_Filters.AutoSize = true;
            this.LblGetForNetworkDevice_Filters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblGetForNetworkDevice_Filters.Location = new System.Drawing.Point(23, 51);
            this.LblGetForNetworkDevice_Filters.Margin = new System.Windows.Forms.Padding(3);
            this.LblGetForNetworkDevice_Filters.Name = "LblGetForNetworkDevice_Filters";
            this.LblGetForNetworkDevice_Filters.Size = new System.Drawing.Size(140, 49);
            this.LblGetForNetworkDevice_Filters.TabIndex = 2;
            this.LblGetForNetworkDevice_Filters.Text = "Filters:";
            this.LblGetForNetworkDevice_Filters.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TlpGetForNetworkDevice_Filters
            // 
            this.TlpGetForNetworkDevice_Filters.AutoSize = true;
            this.TlpGetForNetworkDevice_Filters.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TlpGetForNetworkDevice_Filters.ColumnCount = 4;
            this.TlpGetForNetworkDevice_Filters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TlpGetForNetworkDevice_Filters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpGetForNetworkDevice_Filters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TlpGetForNetworkDevice_Filters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpGetForNetworkDevice_Filters.Controls.Add(this.LblGetForNetworkDevice_StartTime, 0, 0);
            this.TlpGetForNetworkDevice_Filters.Controls.Add(this.LblGetForNetworkDevice_EndTime, 2, 0);
            this.TlpGetForNetworkDevice_Filters.Controls.Add(this.DtpGetForNetworkDevice_StartTime, 1, 0);
            this.TlpGetForNetworkDevice_Filters.Controls.Add(this.DtpGetForNetworkDevice_EndTime, 3, 0);
            this.TlpGetForNetworkDevice_Filters.Controls.Add(this.ChkGetForNetworkDevice_ExcludeAcknowledged, 1, 1);
            this.TlpGetForNetworkDevice_Filters.Controls.Add(this.ChkGetForNetworkDevice_ExcludeDiscarded, 3, 1);
            this.TlpGetForNetworkDevice_Filters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpGetForNetworkDevice_Filters.Location = new System.Drawing.Point(169, 51);
            this.TlpGetForNetworkDevice_Filters.Name = "TlpGetForNetworkDevice_Filters";
            this.TlpGetForNetworkDevice_Filters.RowCount = 2;
            this.TlpGetForNetworkDevice_Filters.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TlpGetForNetworkDevice_Filters.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TlpGetForNetworkDevice_Filters.Size = new System.Drawing.Size(610, 49);
            this.TlpGetForNetworkDevice_Filters.TabIndex = 3;
            // 
            // LblGetForNetworkDevice_StartTime
            // 
            this.LblGetForNetworkDevice_StartTime.AutoSize = true;
            this.LblGetForNetworkDevice_StartTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblGetForNetworkDevice_StartTime.Location = new System.Drawing.Point(3, 3);
            this.LblGetForNetworkDevice_StartTime.Margin = new System.Windows.Forms.Padding(3);
            this.LblGetForNetworkDevice_StartTime.Name = "LblGetForNetworkDevice_StartTime";
            this.LblGetForNetworkDevice_StartTime.Size = new System.Drawing.Size(55, 20);
            this.LblGetForNetworkDevice_StartTime.TabIndex = 0;
            this.LblGetForNetworkDevice_StartTime.Text = "Start Time";
            this.LblGetForNetworkDevice_StartTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblGetForNetworkDevice_EndTime
            // 
            this.LblGetForNetworkDevice_EndTime.AutoSize = true;
            this.LblGetForNetworkDevice_EndTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblGetForNetworkDevice_EndTime.Location = new System.Drawing.Point(309, 3);
            this.LblGetForNetworkDevice_EndTime.Margin = new System.Windows.Forms.Padding(3);
            this.LblGetForNetworkDevice_EndTime.Name = "LblGetForNetworkDevice_EndTime";
            this.LblGetForNetworkDevice_EndTime.Size = new System.Drawing.Size(52, 20);
            this.LblGetForNetworkDevice_EndTime.TabIndex = 1;
            this.LblGetForNetworkDevice_EndTime.Text = "End Time";
            this.LblGetForNetworkDevice_EndTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DtpGetForNetworkDevice_StartTime
            // 
            this.DtpGetForNetworkDevice_StartTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DtpGetForNetworkDevice_StartTime.Location = new System.Drawing.Point(64, 3);
            this.DtpGetForNetworkDevice_StartTime.Name = "DtpGetForNetworkDevice_StartTime";
            this.DtpGetForNetworkDevice_StartTime.Size = new System.Drawing.Size(239, 20);
            this.DtpGetForNetworkDevice_StartTime.TabIndex = 2;
            // 
            // DtpGetForNetworkDevice_EndTime
            // 
            this.DtpGetForNetworkDevice_EndTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DtpGetForNetworkDevice_EndTime.Location = new System.Drawing.Point(367, 3);
            this.DtpGetForNetworkDevice_EndTime.Name = "DtpGetForNetworkDevice_EndTime";
            this.DtpGetForNetworkDevice_EndTime.Size = new System.Drawing.Size(240, 20);
            this.DtpGetForNetworkDevice_EndTime.TabIndex = 3;
            // 
            // ChkGetForNetworkDevice_ExcludeAcknowledged
            // 
            this.ChkGetForNetworkDevice_ExcludeAcknowledged.AutoSize = true;
            this.ChkGetForNetworkDevice_ExcludeAcknowledged.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChkGetForNetworkDevice_ExcludeAcknowledged.Location = new System.Drawing.Point(64, 29);
            this.ChkGetForNetworkDevice_ExcludeAcknowledged.Name = "ChkGetForNetworkDevice_ExcludeAcknowledged";
            this.ChkGetForNetworkDevice_ExcludeAcknowledged.Size = new System.Drawing.Size(239, 17);
            this.ChkGetForNetworkDevice_ExcludeAcknowledged.TabIndex = 4;
            this.ChkGetForNetworkDevice_ExcludeAcknowledged.Text = "Exclude Acknowledged";
            this.ChkGetForNetworkDevice_ExcludeAcknowledged.UseVisualStyleBackColor = true;
            // 
            // ChkGetForNetworkDevice_ExcludeDiscarded
            // 
            this.ChkGetForNetworkDevice_ExcludeDiscarded.AutoSize = true;
            this.ChkGetForNetworkDevice_ExcludeDiscarded.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChkGetForNetworkDevice_ExcludeDiscarded.Location = new System.Drawing.Point(367, 29);
            this.ChkGetForNetworkDevice_ExcludeDiscarded.Name = "ChkGetForNetworkDevice_ExcludeDiscarded";
            this.ChkGetForNetworkDevice_ExcludeDiscarded.Size = new System.Drawing.Size(240, 17);
            this.ChkGetForNetworkDevice_ExcludeDiscarded.TabIndex = 5;
            this.ChkGetForNetworkDevice_ExcludeDiscarded.Text = "Exclude Discarded";
            this.ChkGetForNetworkDevice_ExcludeDiscarded.UseVisualStyleBackColor = true;
            // 
            // ChkGetForNetworkDevice_NoFilters
            // 
            this.ChkGetForNetworkDevice_NoFilters.AutoSize = true;
            this.ChkGetForNetworkDevice_NoFilters.Dock = System.Windows.Forms.DockStyle.Left;
            this.ChkGetForNetworkDevice_NoFilters.Location = new System.Drawing.Point(785, 51);
            this.ChkGetForNetworkDevice_NoFilters.Name = "ChkGetForNetworkDevice_NoFilters";
            this.ChkGetForNetworkDevice_NoFilters.Size = new System.Drawing.Size(70, 49);
            this.ChkGetForNetworkDevice_NoFilters.TabIndex = 4;
            this.ChkGetForNetworkDevice_NoFilters.Text = "No Filters";
            this.ChkGetForNetworkDevice_NoFilters.UseVisualStyleBackColor = true;
            // 
            // BtnGetForNetworkDevice
            // 
            this.TlpGetForNetworkDevice.SetColumnSpan(this.BtnGetForNetworkDevice, 2);
            this.BtnGetForNetworkDevice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnGetForNetworkDevice.Location = new System.Drawing.Point(169, 106);
            this.BtnGetForNetworkDevice.MinimumSize = new System.Drawing.Size(260, 0);
            this.BtnGetForNetworkDevice.Name = "BtnGetForNetworkDevice";
            this.BtnGetForNetworkDevice.Size = new System.Drawing.Size(686, 23);
            this.BtnGetForNetworkDevice.TabIndex = 5;
            this.BtnGetForNetworkDevice.Text = "Alarms.GetForNetworkDevice";
            this.BtnGetForNetworkDevice.UseVisualStyleBackColor = true;
            this.BtnGetForNetworkDevice.Click += new System.EventHandler(this.BtnGetForNetworkDevice_Click);
            // 
            // DgvGetForNetworkDevice
            // 
            this.DgvGetForNetworkDevice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TlpGetForNetworkDevice.SetColumnSpan(this.DgvGetForNetworkDevice, 2);
            this.DgvGetForNetworkDevice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvGetForNetworkDevice.Location = new System.Drawing.Point(169, 135);
            this.DgvGetForNetworkDevice.Name = "DgvGetForNetworkDevice";
            this.DgvGetForNetworkDevice.Size = new System.Drawing.Size(686, 456);
            this.DgvGetForNetworkDevice.TabIndex = 6;
            // 
            // LblGetForNetworkDevice_Title
            // 
            this.LblGetForNetworkDevice_Title.AutoSize = true;
            this.TlpGetForNetworkDevice.SetColumnSpan(this.LblGetForNetworkDevice_Title, 4);
            this.LblGetForNetworkDevice_Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblGetForNetworkDevice_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGetForNetworkDevice_Title.ForeColor = System.Drawing.Color.RoyalBlue;
            this.LblGetForNetworkDevice_Title.Location = new System.Drawing.Point(3, 3);
            this.LblGetForNetworkDevice_Title.Margin = new System.Windows.Forms.Padding(3);
            this.LblGetForNetworkDevice_Title.Name = "LblGetForNetworkDevice_Title";
            this.LblGetForNetworkDevice_Title.Size = new System.Drawing.Size(852, 16);
            this.LblGetForNetworkDevice_Title.TabIndex = 7;
            this.LblGetForNetworkDevice_Title.Text = "Retrieves a collection of alarms for the specified network device.";
            // 
            // TpgGetForObject
            // 
            this.TpgGetForObject.Controls.Add(this.TlpGetForObject);
            this.TpgGetForObject.Location = new System.Drawing.Point(4, 29);
            this.TpgGetForObject.Name = "TpgGetForObject";
            this.TpgGetForObject.Padding = new System.Windows.Forms.Padding(3);
            this.TpgGetForObject.Size = new System.Drawing.Size(884, 600);
            this.TpgGetForObject.TabIndex = 3;
            this.TpgGetForObject.Text = "GetForObject";
            this.TpgGetForObject.UseVisualStyleBackColor = true;
            // 
            // TlpGetForObject
            // 
            this.TlpGetForObject.ColumnCount = 5;
            this.TlpGetForObject.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TlpGetForObject.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TlpGetForObject.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpGetForObject.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TlpGetForObject.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TlpGetForObject.Controls.Add(this.LblGetForObject_ObjectId, 1, 1);
            this.TlpGetForObject.Controls.Add(this.TxtGetForObject_ObjectId, 2, 1);
            this.TlpGetForObject.Controls.Add(this.LblGetForObject_Filters, 1, 2);
            this.TlpGetForObject.Controls.Add(this.TlpGetForObject_Filters, 2, 2);
            this.TlpGetForObject.Controls.Add(this.ChkGetForObject_NoFilters, 3, 2);
            this.TlpGetForObject.Controls.Add(this.BtnGetForObject, 2, 3);
            this.TlpGetForObject.Controls.Add(this.DgvGetForObject, 2, 4);
            this.TlpGetForObject.Controls.Add(this.LblGetForObject_Title, 0, 0);
            this.TlpGetForObject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpGetForObject.Location = new System.Drawing.Point(3, 3);
            this.TlpGetForObject.Name = "TlpGetForObject";
            this.TlpGetForObject.RowCount = 5;
            this.TlpGetForObject.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TlpGetForObject.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TlpGetForObject.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TlpGetForObject.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TlpGetForObject.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpGetForObject.Size = new System.Drawing.Size(878, 594);
            this.TlpGetForObject.TabIndex = 0;
            // 
            // LblGetForObject_ObjectId
            // 
            this.LblGetForObject_ObjectId.AutoSize = true;
            this.LblGetForObject_ObjectId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblGetForObject_ObjectId.Location = new System.Drawing.Point(23, 25);
            this.LblGetForObject_ObjectId.Margin = new System.Windows.Forms.Padding(3);
            this.LblGetForObject_ObjectId.MinimumSize = new System.Drawing.Size(140, 0);
            this.LblGetForObject_ObjectId.Name = "LblGetForObject_ObjectId";
            this.LblGetForObject_ObjectId.Size = new System.Drawing.Size(140, 20);
            this.LblGetForObject_ObjectId.TabIndex = 0;
            this.LblGetForObject_ObjectId.Text = "Object ID (GUID):";
            this.LblGetForObject_ObjectId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtGetForObject_ObjectId
            // 
            this.TlpGetForObject.SetColumnSpan(this.TxtGetForObject_ObjectId, 2);
            this.TxtGetForObject_ObjectId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtGetForObject_ObjectId.Location = new System.Drawing.Point(169, 25);
            this.TxtGetForObject_ObjectId.Name = "TxtGetForObject_ObjectId";
            this.TxtGetForObject_ObjectId.Size = new System.Drawing.Size(686, 20);
            this.TxtGetForObject_ObjectId.TabIndex = 1;
            // 
            // LblGetForObject_Filters
            // 
            this.LblGetForObject_Filters.AutoSize = true;
            this.LblGetForObject_Filters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblGetForObject_Filters.Location = new System.Drawing.Point(23, 51);
            this.LblGetForObject_Filters.Margin = new System.Windows.Forms.Padding(3);
            this.LblGetForObject_Filters.Name = "LblGetForObject_Filters";
            this.LblGetForObject_Filters.Size = new System.Drawing.Size(140, 49);
            this.LblGetForObject_Filters.TabIndex = 2;
            this.LblGetForObject_Filters.Text = "Filters:";
            this.LblGetForObject_Filters.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TlpGetForObject_Filters
            // 
            this.TlpGetForObject_Filters.AutoSize = true;
            this.TlpGetForObject_Filters.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TlpGetForObject_Filters.ColumnCount = 4;
            this.TlpGetForObject_Filters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TlpGetForObject_Filters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpGetForObject_Filters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TlpGetForObject_Filters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpGetForObject_Filters.Controls.Add(this.LblGetForObject_StartTime, 0, 0);
            this.TlpGetForObject_Filters.Controls.Add(this.LblGetForObject_EndTime, 2, 0);
            this.TlpGetForObject_Filters.Controls.Add(this.DtpGetForObject_StartTime, 1, 0);
            this.TlpGetForObject_Filters.Controls.Add(this.DtpGetForObject_EndTime, 3, 0);
            this.TlpGetForObject_Filters.Controls.Add(this.ChkGetForObject_ExcludeAcknowledged, 1, 1);
            this.TlpGetForObject_Filters.Controls.Add(this.ChkGetForObject_ExcludeDiscarded, 3, 1);
            this.TlpGetForObject_Filters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpGetForObject_Filters.Location = new System.Drawing.Point(169, 51);
            this.TlpGetForObject_Filters.Name = "TlpGetForObject_Filters";
            this.TlpGetForObject_Filters.RowCount = 2;
            this.TlpGetForObject_Filters.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TlpGetForObject_Filters.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TlpGetForObject_Filters.Size = new System.Drawing.Size(610, 49);
            this.TlpGetForObject_Filters.TabIndex = 3;
            // 
            // LblGetForObject_StartTime
            // 
            this.LblGetForObject_StartTime.AutoSize = true;
            this.LblGetForObject_StartTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblGetForObject_StartTime.Location = new System.Drawing.Point(3, 3);
            this.LblGetForObject_StartTime.Margin = new System.Windows.Forms.Padding(3);
            this.LblGetForObject_StartTime.Name = "LblGetForObject_StartTime";
            this.LblGetForObject_StartTime.Size = new System.Drawing.Size(55, 20);
            this.LblGetForObject_StartTime.TabIndex = 0;
            this.LblGetForObject_StartTime.Text = "Start Time";
            this.LblGetForObject_StartTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblGetForObject_EndTime
            // 
            this.LblGetForObject_EndTime.AutoSize = true;
            this.LblGetForObject_EndTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblGetForObject_EndTime.Location = new System.Drawing.Point(309, 3);
            this.LblGetForObject_EndTime.Margin = new System.Windows.Forms.Padding(3);
            this.LblGetForObject_EndTime.Name = "LblGetForObject_EndTime";
            this.LblGetForObject_EndTime.Size = new System.Drawing.Size(52, 20);
            this.LblGetForObject_EndTime.TabIndex = 1;
            this.LblGetForObject_EndTime.Text = "End Time";
            this.LblGetForObject_EndTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DtpGetForObject_StartTime
            // 
            this.DtpGetForObject_StartTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DtpGetForObject_StartTime.Location = new System.Drawing.Point(64, 3);
            this.DtpGetForObject_StartTime.Name = "DtpGetForObject_StartTime";
            this.DtpGetForObject_StartTime.Size = new System.Drawing.Size(239, 20);
            this.DtpGetForObject_StartTime.TabIndex = 2;
            // 
            // DtpGetForObject_EndTime
            // 
            this.DtpGetForObject_EndTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DtpGetForObject_EndTime.Location = new System.Drawing.Point(367, 3);
            this.DtpGetForObject_EndTime.Name = "DtpGetForObject_EndTime";
            this.DtpGetForObject_EndTime.Size = new System.Drawing.Size(240, 20);
            this.DtpGetForObject_EndTime.TabIndex = 3;
            // 
            // ChkGetForObject_ExcludeAcknowledged
            // 
            this.ChkGetForObject_ExcludeAcknowledged.AutoSize = true;
            this.ChkGetForObject_ExcludeAcknowledged.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChkGetForObject_ExcludeAcknowledged.Location = new System.Drawing.Point(64, 29);
            this.ChkGetForObject_ExcludeAcknowledged.Name = "ChkGetForObject_ExcludeAcknowledged";
            this.ChkGetForObject_ExcludeAcknowledged.Size = new System.Drawing.Size(239, 17);
            this.ChkGetForObject_ExcludeAcknowledged.TabIndex = 4;
            this.ChkGetForObject_ExcludeAcknowledged.Text = "Exclude Acknowledged";
            this.ChkGetForObject_ExcludeAcknowledged.UseVisualStyleBackColor = true;
            // 
            // ChkGetForObject_ExcludeDiscarded
            // 
            this.ChkGetForObject_ExcludeDiscarded.AutoSize = true;
            this.ChkGetForObject_ExcludeDiscarded.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChkGetForObject_ExcludeDiscarded.Location = new System.Drawing.Point(367, 29);
            this.ChkGetForObject_ExcludeDiscarded.Name = "ChkGetForObject_ExcludeDiscarded";
            this.ChkGetForObject_ExcludeDiscarded.Size = new System.Drawing.Size(240, 17);
            this.ChkGetForObject_ExcludeDiscarded.TabIndex = 5;
            this.ChkGetForObject_ExcludeDiscarded.Text = "Exclude Discarded";
            this.ChkGetForObject_ExcludeDiscarded.UseVisualStyleBackColor = true;
            // 
            // ChkGetForObject_NoFilters
            // 
            this.ChkGetForObject_NoFilters.AutoSize = true;
            this.ChkGetForObject_NoFilters.Dock = System.Windows.Forms.DockStyle.Left;
            this.ChkGetForObject_NoFilters.Location = new System.Drawing.Point(785, 51);
            this.ChkGetForObject_NoFilters.Name = "ChkGetForObject_NoFilters";
            this.ChkGetForObject_NoFilters.Size = new System.Drawing.Size(70, 49);
            this.ChkGetForObject_NoFilters.TabIndex = 4;
            this.ChkGetForObject_NoFilters.Text = "No Filters";
            this.ChkGetForObject_NoFilters.UseVisualStyleBackColor = true;
            // 
            // BtnGetForObject
            // 
            this.TlpGetForObject.SetColumnSpan(this.BtnGetForObject, 2);
            this.BtnGetForObject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnGetForObject.Location = new System.Drawing.Point(169, 106);
            this.BtnGetForObject.MinimumSize = new System.Drawing.Size(260, 0);
            this.BtnGetForObject.Name = "BtnGetForObject";
            this.BtnGetForObject.Size = new System.Drawing.Size(686, 23);
            this.BtnGetForObject.TabIndex = 5;
            this.BtnGetForObject.Text = "Alarms.GetForObject";
            this.BtnGetForObject.UseVisualStyleBackColor = true;
            this.BtnGetForObject.Click += new System.EventHandler(this.BtnGetForObject_Click);
            // 
            // DgvGetForObject
            // 
            this.DgvGetForObject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TlpGetForObject.SetColumnSpan(this.DgvGetForObject, 2);
            this.DgvGetForObject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvGetForObject.Location = new System.Drawing.Point(169, 135);
            this.DgvGetForObject.Name = "DgvGetForObject";
            this.DgvGetForObject.Size = new System.Drawing.Size(686, 456);
            this.DgvGetForObject.TabIndex = 6;
            // 
            // LblGetForObject_Title
            // 
            this.LblGetForObject_Title.AutoSize = true;
            this.TlpGetForObject.SetColumnSpan(this.LblGetForObject_Title, 4);
            this.LblGetForObject_Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblGetForObject_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGetForObject_Title.ForeColor = System.Drawing.Color.RoyalBlue;
            this.LblGetForObject_Title.Location = new System.Drawing.Point(3, 3);
            this.LblGetForObject_Title.Margin = new System.Windows.Forms.Padding(3);
            this.LblGetForObject_Title.Name = "LblGetForObject_Title";
            this.LblGetForObject_Title.Size = new System.Drawing.Size(852, 16);
            this.LblGetForObject_Title.TabIndex = 7;
            this.LblGetForObject_Title.Text = "Retrieves a collection of alarms for the specified object.";
            this.LblGetForObject_Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TpgGetAnnotations
            // 
            this.TpgGetAnnotations.Controls.Add(this.TlpGetAnnotations);
            this.TpgGetAnnotations.Location = new System.Drawing.Point(4, 29);
            this.TpgGetAnnotations.Name = "TpgGetAnnotations";
            this.TpgGetAnnotations.Padding = new System.Windows.Forms.Padding(3);
            this.TpgGetAnnotations.Size = new System.Drawing.Size(884, 600);
            this.TpgGetAnnotations.TabIndex = 4;
            this.TpgGetAnnotations.Text = "GetAnnotations";
            this.TpgGetAnnotations.UseVisualStyleBackColor = true;
            // 
            // TlpGetAnnotations
            // 
            this.TlpGetAnnotations.ColumnCount = 4;
            this.TlpGetAnnotations.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TlpGetAnnotations.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TlpGetAnnotations.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpGetAnnotations.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TlpGetAnnotations.Controls.Add(this.LblGetAnnotations_AlarmId, 1, 1);
            this.TlpGetAnnotations.Controls.Add(this.TxtGetAnnotations_AlarmId, 2, 1);
            this.TlpGetAnnotations.Controls.Add(this.BtnGetAnnotations, 2, 2);
            this.TlpGetAnnotations.Controls.Add(this.TxtGetAnnotations_Result, 2, 3);
            this.TlpGetAnnotations.Controls.Add(this.GetAnnotations_Title, 0, 0);
            this.TlpGetAnnotations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpGetAnnotations.Location = new System.Drawing.Point(3, 3);
            this.TlpGetAnnotations.Name = "TlpGetAnnotations";
            this.TlpGetAnnotations.RowCount = 4;
            this.TlpGetAnnotations.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TlpGetAnnotations.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TlpGetAnnotations.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TlpGetAnnotations.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpGetAnnotations.Size = new System.Drawing.Size(878, 594);
            this.TlpGetAnnotations.TabIndex = 0;
            // 
            // LblGetAnnotations_AlarmId
            // 
            this.LblGetAnnotations_AlarmId.AutoSize = true;
            this.LblGetAnnotations_AlarmId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblGetAnnotations_AlarmId.Location = new System.Drawing.Point(23, 25);
            this.LblGetAnnotations_AlarmId.Margin = new System.Windows.Forms.Padding(3);
            this.LblGetAnnotations_AlarmId.MinimumSize = new System.Drawing.Size(140, 0);
            this.LblGetAnnotations_AlarmId.Name = "LblGetAnnotations_AlarmId";
            this.LblGetAnnotations_AlarmId.Size = new System.Drawing.Size(140, 20);
            this.LblGetAnnotations_AlarmId.TabIndex = 0;
            this.LblGetAnnotations_AlarmId.Text = "Alarm ID (GUID):";
            this.LblGetAnnotations_AlarmId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtGetAnnotations_AlarmId
            // 
            this.TxtGetAnnotations_AlarmId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtGetAnnotations_AlarmId.Location = new System.Drawing.Point(169, 25);
            this.TxtGetAnnotations_AlarmId.Name = "TxtGetAnnotations_AlarmId";
            this.TxtGetAnnotations_AlarmId.Size = new System.Drawing.Size(686, 20);
            this.TxtGetAnnotations_AlarmId.TabIndex = 1;
            // 
            // BtnGetAnnotations
            // 
            this.BtnGetAnnotations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnGetAnnotations.Location = new System.Drawing.Point(169, 51);
            this.BtnGetAnnotations.MinimumSize = new System.Drawing.Size(260, 0);
            this.BtnGetAnnotations.Name = "BtnGetAnnotations";
            this.BtnGetAnnotations.Size = new System.Drawing.Size(686, 23);
            this.BtnGetAnnotations.TabIndex = 2;
            this.BtnGetAnnotations.Text = "Alarms.GetAnnotations";
            this.BtnGetAnnotations.UseVisualStyleBackColor = true;
            this.BtnGetAnnotations.Click += new System.EventHandler(this.BtnGetAnnotations_Click);
            // 
            // TxtGetAnnotations_Result
            // 
            this.TxtGetAnnotations_Result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtGetAnnotations_Result.Location = new System.Drawing.Point(169, 80);
            this.TxtGetAnnotations_Result.Multiline = true;
            this.TxtGetAnnotations_Result.Name = "TxtGetAnnotations_Result";
            this.TxtGetAnnotations_Result.Size = new System.Drawing.Size(686, 511);
            this.TxtGetAnnotations_Result.TabIndex = 3;
            // 
            // GetAnnotations_Title
            // 
            this.GetAnnotations_Title.AutoSize = true;
            this.TlpGetAnnotations.SetColumnSpan(this.GetAnnotations_Title, 4);
            this.GetAnnotations_Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GetAnnotations_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetAnnotations_Title.ForeColor = System.Drawing.Color.RoyalBlue;
            this.GetAnnotations_Title.Location = new System.Drawing.Point(3, 3);
            this.GetAnnotations_Title.Margin = new System.Windows.Forms.Padding(3);
            this.GetAnnotations_Title.Name = "GetAnnotations_Title";
            this.GetAnnotations_Title.Size = new System.Drawing.Size(872, 16);
            this.GetAnnotations_Title.TabIndex = 4;
            this.GetAnnotations_Title.Text = "Retrieves the collection of annotations available for the specified alarm.";
            this.GetAnnotations_Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TpgAcknowledge
            // 
            this.TpgAcknowledge.Controls.Add(this.TlpAckAlarm);
            this.TpgAcknowledge.Location = new System.Drawing.Point(4, 29);
            this.TpgAcknowledge.Name = "TpgAcknowledge";
            this.TpgAcknowledge.Padding = new System.Windows.Forms.Padding(3);
            this.TpgAcknowledge.Size = new System.Drawing.Size(884, 600);
            this.TpgAcknowledge.TabIndex = 0;
            this.TpgAcknowledge.Text = "Acknowledge";
            this.TpgAcknowledge.UseVisualStyleBackColor = true;
            // 
            // TlpAckAlarm
            // 
            this.TlpAckAlarm.ColumnCount = 4;
            this.TlpAckAlarm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TlpAckAlarm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TlpAckAlarm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpAckAlarm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TlpAckAlarm.Controls.Add(this.LblAckAlarm_AlarmId, 1, 1);
            this.TlpAckAlarm.Controls.Add(this.TxtAckAlarm_AlarmId, 2, 1);
            this.TlpAckAlarm.Controls.Add(this.LblAckAlarm_AnnotationText, 1, 2);
            this.TlpAckAlarm.Controls.Add(this.TxtAckAlarm_AnnotationText, 2, 2);
            this.TlpAckAlarm.Controls.Add(this.BtnAcknowledgeAlarm, 2, 3);
            this.TlpAckAlarm.Controls.Add(this.TxtAckAlarm_Result, 2, 4);
            this.TlpAckAlarm.Controls.Add(this.LblAckAlarm_Result, 1, 4);
            this.TlpAckAlarm.Controls.Add(this.LblAck_Title, 0, 0);
            this.TlpAckAlarm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpAckAlarm.Location = new System.Drawing.Point(3, 3);
            this.TlpAckAlarm.Name = "TlpAckAlarm";
            this.TlpAckAlarm.RowCount = 6;
            this.TlpAckAlarm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TlpAckAlarm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TlpAckAlarm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TlpAckAlarm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TlpAckAlarm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TlpAckAlarm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpAckAlarm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TlpAckAlarm.Size = new System.Drawing.Size(878, 594);
            this.TlpAckAlarm.TabIndex = 0;
            // 
            // LblAckAlarm_AlarmId
            // 
            this.LblAckAlarm_AlarmId.AutoSize = true;
            this.LblAckAlarm_AlarmId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblAckAlarm_AlarmId.Location = new System.Drawing.Point(23, 25);
            this.LblAckAlarm_AlarmId.Margin = new System.Windows.Forms.Padding(3);
            this.LblAckAlarm_AlarmId.MinimumSize = new System.Drawing.Size(140, 0);
            this.LblAckAlarm_AlarmId.Name = "LblAckAlarm_AlarmId";
            this.LblAckAlarm_AlarmId.Size = new System.Drawing.Size(140, 20);
            this.LblAckAlarm_AlarmId.TabIndex = 0;
            this.LblAckAlarm_AlarmId.Text = "Alarm ID (GUID):";
            this.LblAckAlarm_AlarmId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtAckAlarm_AlarmId
            // 
            this.TxtAckAlarm_AlarmId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtAckAlarm_AlarmId.Location = new System.Drawing.Point(169, 25);
            this.TxtAckAlarm_AlarmId.Name = "TxtAckAlarm_AlarmId";
            this.TxtAckAlarm_AlarmId.Size = new System.Drawing.Size(686, 20);
            this.TxtAckAlarm_AlarmId.TabIndex = 1;
            // 
            // LblAckAlarm_AnnotationText
            // 
            this.LblAckAlarm_AnnotationText.AutoSize = true;
            this.LblAckAlarm_AnnotationText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblAckAlarm_AnnotationText.Location = new System.Drawing.Point(23, 51);
            this.LblAckAlarm_AnnotationText.Margin = new System.Windows.Forms.Padding(3);
            this.LblAckAlarm_AnnotationText.Name = "LblAckAlarm_AnnotationText";
            this.LblAckAlarm_AnnotationText.Size = new System.Drawing.Size(140, 20);
            this.LblAckAlarm_AnnotationText.TabIndex = 4;
            this.LblAckAlarm_AnnotationText.Text = "Annotation Text:";
            this.LblAckAlarm_AnnotationText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtAckAlarm_AnnotationText
            // 
            this.TxtAckAlarm_AnnotationText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtAckAlarm_AnnotationText.Location = new System.Drawing.Point(169, 51);
            this.TxtAckAlarm_AnnotationText.Name = "TxtAckAlarm_AnnotationText";
            this.TxtAckAlarm_AnnotationText.Size = new System.Drawing.Size(686, 20);
            this.TxtAckAlarm_AnnotationText.TabIndex = 5;
            // 
            // BtnAcknowledgeAlarm
            // 
            this.BtnAcknowledgeAlarm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnAcknowledgeAlarm.Location = new System.Drawing.Point(169, 77);
            this.BtnAcknowledgeAlarm.MinimumSize = new System.Drawing.Size(260, 0);
            this.BtnAcknowledgeAlarm.Name = "BtnAcknowledgeAlarm";
            this.BtnAcknowledgeAlarm.Size = new System.Drawing.Size(686, 23);
            this.BtnAcknowledgeAlarm.TabIndex = 6;
            this.BtnAcknowledgeAlarm.Text = "Alarms.Acknowledge";
            this.BtnAcknowledgeAlarm.UseVisualStyleBackColor = true;
            this.BtnAcknowledgeAlarm.Click += new System.EventHandler(this.BtnEditAlarm_Click);
            // 
            // TxtAckAlarm_Result
            // 
            this.TxtAckAlarm_Result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtAckAlarm_Result.Location = new System.Drawing.Point(169, 106);
            this.TxtAckAlarm_Result.Name = "TxtAckAlarm_Result";
            this.TxtAckAlarm_Result.ReadOnly = true;
            this.TxtAckAlarm_Result.Size = new System.Drawing.Size(686, 20);
            this.TxtAckAlarm_Result.TabIndex = 7;
            // 
            // LblAckAlarm_Result
            // 
            this.LblAckAlarm_Result.AutoSize = true;
            this.LblAckAlarm_Result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblAckAlarm_Result.Location = new System.Drawing.Point(23, 106);
            this.LblAckAlarm_Result.Margin = new System.Windows.Forms.Padding(3);
            this.LblAckAlarm_Result.Name = "LblAckAlarm_Result";
            this.LblAckAlarm_Result.Size = new System.Drawing.Size(140, 20);
            this.LblAckAlarm_Result.TabIndex = 8;
            this.LblAckAlarm_Result.Text = "Result:";
            this.LblAckAlarm_Result.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblAck_Title
            // 
            this.LblAck_Title.AutoSize = true;
            this.TlpAckAlarm.SetColumnSpan(this.LblAck_Title, 4);
            this.LblAck_Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblAck_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAck_Title.ForeColor = System.Drawing.Color.RoyalBlue;
            this.LblAck_Title.Location = new System.Drawing.Point(3, 3);
            this.LblAck_Title.Margin = new System.Windows.Forms.Padding(3);
            this.LblAck_Title.Name = "LblAck_Title";
            this.LblAck_Title.Size = new System.Drawing.Size(872, 16);
            this.LblAck_Title.TabIndex = 9;
            this.LblAck_Title.Text = "Allows for acknowledging an alarm.";
            this.LblAck_Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TpgDiscardAlarm
            // 
            this.TpgDiscardAlarm.Controls.Add(this.TlpDiscardAlarm);
            this.TpgDiscardAlarm.Location = new System.Drawing.Point(4, 29);
            this.TpgDiscardAlarm.Name = "TpgDiscardAlarm";
            this.TpgDiscardAlarm.Padding = new System.Windows.Forms.Padding(3);
            this.TpgDiscardAlarm.Size = new System.Drawing.Size(884, 600);
            this.TpgDiscardAlarm.TabIndex = 6;
            this.TpgDiscardAlarm.Text = "Discard";
            this.TpgDiscardAlarm.UseVisualStyleBackColor = true;
            // 
            // TlpDiscardAlarm
            // 
            this.TlpDiscardAlarm.ColumnCount = 4;
            this.TlpDiscardAlarm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TlpDiscardAlarm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TlpDiscardAlarm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpDiscardAlarm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TlpDiscardAlarm.Controls.Add(this.LblDiscardAlarm_AlarmId, 1, 1);
            this.TlpDiscardAlarm.Controls.Add(this.TxtDiscardAlarm_AlarmId, 2, 1);
            this.TlpDiscardAlarm.Controls.Add(this.LblDiscardAlarm_AnnotationText, 1, 2);
            this.TlpDiscardAlarm.Controls.Add(this.TxtDiscardAlarm_AnnotationText, 2, 2);
            this.TlpDiscardAlarm.Controls.Add(this.BtnDiscardAlarm, 2, 3);
            this.TlpDiscardAlarm.Controls.Add(this.TxtDiscardAlarm_Result, 2, 4);
            this.TlpDiscardAlarm.Controls.Add(this.LblDiscardAlarm_Result, 1, 4);
            this.TlpDiscardAlarm.Controls.Add(this.LblDiscard_Title, 0, 0);
            this.TlpDiscardAlarm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpDiscardAlarm.Location = new System.Drawing.Point(3, 3);
            this.TlpDiscardAlarm.Name = "TlpDiscardAlarm";
            this.TlpDiscardAlarm.RowCount = 6;
            this.TlpDiscardAlarm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TlpDiscardAlarm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TlpDiscardAlarm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TlpDiscardAlarm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TlpDiscardAlarm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TlpDiscardAlarm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpDiscardAlarm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TlpDiscardAlarm.Size = new System.Drawing.Size(878, 594);
            this.TlpDiscardAlarm.TabIndex = 1;
            // 
            // LblDiscardAlarm_AlarmId
            // 
            this.LblDiscardAlarm_AlarmId.AutoSize = true;
            this.LblDiscardAlarm_AlarmId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblDiscardAlarm_AlarmId.Location = new System.Drawing.Point(23, 25);
            this.LblDiscardAlarm_AlarmId.Margin = new System.Windows.Forms.Padding(3);
            this.LblDiscardAlarm_AlarmId.MinimumSize = new System.Drawing.Size(140, 0);
            this.LblDiscardAlarm_AlarmId.Name = "LblDiscardAlarm_AlarmId";
            this.LblDiscardAlarm_AlarmId.Size = new System.Drawing.Size(140, 20);
            this.LblDiscardAlarm_AlarmId.TabIndex = 0;
            this.LblDiscardAlarm_AlarmId.Text = "Alarm ID (GUID):";
            this.LblDiscardAlarm_AlarmId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtDiscardAlarm_AlarmId
            // 
            this.TxtDiscardAlarm_AlarmId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtDiscardAlarm_AlarmId.Location = new System.Drawing.Point(169, 25);
            this.TxtDiscardAlarm_AlarmId.Name = "TxtDiscardAlarm_AlarmId";
            this.TxtDiscardAlarm_AlarmId.Size = new System.Drawing.Size(686, 20);
            this.TxtDiscardAlarm_AlarmId.TabIndex = 1;
            // 
            // LblDiscardAlarm_AnnotationText
            // 
            this.LblDiscardAlarm_AnnotationText.AutoSize = true;
            this.LblDiscardAlarm_AnnotationText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblDiscardAlarm_AnnotationText.Location = new System.Drawing.Point(23, 51);
            this.LblDiscardAlarm_AnnotationText.Margin = new System.Windows.Forms.Padding(3);
            this.LblDiscardAlarm_AnnotationText.Name = "LblDiscardAlarm_AnnotationText";
            this.LblDiscardAlarm_AnnotationText.Size = new System.Drawing.Size(140, 20);
            this.LblDiscardAlarm_AnnotationText.TabIndex = 4;
            this.LblDiscardAlarm_AnnotationText.Text = "Annotation Text:";
            this.LblDiscardAlarm_AnnotationText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtDiscardAlarm_AnnotationText
            // 
            this.TxtDiscardAlarm_AnnotationText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtDiscardAlarm_AnnotationText.Location = new System.Drawing.Point(169, 51);
            this.TxtDiscardAlarm_AnnotationText.Name = "TxtDiscardAlarm_AnnotationText";
            this.TxtDiscardAlarm_AnnotationText.Size = new System.Drawing.Size(686, 20);
            this.TxtDiscardAlarm_AnnotationText.TabIndex = 5;
            // 
            // BtnDiscardAlarm
            // 
            this.BtnDiscardAlarm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnDiscardAlarm.Location = new System.Drawing.Point(169, 77);
            this.BtnDiscardAlarm.MinimumSize = new System.Drawing.Size(260, 0);
            this.BtnDiscardAlarm.Name = "BtnDiscardAlarm";
            this.BtnDiscardAlarm.Size = new System.Drawing.Size(686, 23);
            this.BtnDiscardAlarm.TabIndex = 6;
            this.BtnDiscardAlarm.Text = "Alarms.Discard";
            this.BtnDiscardAlarm.UseVisualStyleBackColor = true;
            this.BtnDiscardAlarm.Click += new System.EventHandler(this.BtnDiscardAlarm_Click);
            // 
            // TxtDiscardAlarm_Result
            // 
            this.TxtDiscardAlarm_Result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtDiscardAlarm_Result.Location = new System.Drawing.Point(169, 106);
            this.TxtDiscardAlarm_Result.Name = "TxtDiscardAlarm_Result";
            this.TxtDiscardAlarm_Result.ReadOnly = true;
            this.TxtDiscardAlarm_Result.Size = new System.Drawing.Size(686, 20);
            this.TxtDiscardAlarm_Result.TabIndex = 7;
            // 
            // LblDiscardAlarm_Result
            // 
            this.LblDiscardAlarm_Result.AutoSize = true;
            this.LblDiscardAlarm_Result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblDiscardAlarm_Result.Location = new System.Drawing.Point(23, 106);
            this.LblDiscardAlarm_Result.Margin = new System.Windows.Forms.Padding(3);
            this.LblDiscardAlarm_Result.Name = "LblDiscardAlarm_Result";
            this.LblDiscardAlarm_Result.Size = new System.Drawing.Size(140, 20);
            this.LblDiscardAlarm_Result.TabIndex = 8;
            this.LblDiscardAlarm_Result.Text = "Result:";
            this.LblDiscardAlarm_Result.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblDiscard_Title
            // 
            this.LblDiscard_Title.AutoSize = true;
            this.TlpDiscardAlarm.SetColumnSpan(this.LblDiscard_Title, 4);
            this.LblDiscard_Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblDiscard_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDiscard_Title.ForeColor = System.Drawing.Color.RoyalBlue;
            this.LblDiscard_Title.Location = new System.Drawing.Point(3, 3);
            this.LblDiscard_Title.Margin = new System.Windows.Forms.Padding(3);
            this.LblDiscard_Title.Name = "LblDiscard_Title";
            this.LblDiscard_Title.Size = new System.Drawing.Size(872, 16);
            this.LblDiscard_Title.TabIndex = 9;
            this.LblDiscard_Title.Text = "Allows for discarding an alarm.";
            this.LblDiscard_Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Alarms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 657);
            this.Controls.Add(this.TabMain);
            this.Name = "Alarms";
            this.Text = "Alarms";
            this.TabMain.ResumeLayout(false);
            this.TpgGet.ResumeLayout(false);
            this.TlpGet.ResumeLayout(false);
            this.TlpGet.PerformLayout();
            this.TlpGet_Filters.ResumeLayout(false);
            this.TlpGet_Filters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvGet)).EndInit();
            this.TpgFindById.ResumeLayout(false);
            this.TlpFindById.ResumeLayout(false);
            this.TlpFindById.PerformLayout();
            this.TpgGetForNetworkDevice.ResumeLayout(false);
            this.TlpGetForNetworkDevice.ResumeLayout(false);
            this.TlpGetForNetworkDevice.PerformLayout();
            this.TlpGetForNetworkDevice_Filters.ResumeLayout(false);
            this.TlpGetForNetworkDevice_Filters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvGetForNetworkDevice)).EndInit();
            this.TpgGetForObject.ResumeLayout(false);
            this.TlpGetForObject.ResumeLayout(false);
            this.TlpGetForObject.PerformLayout();
            this.TlpGetForObject_Filters.ResumeLayout(false);
            this.TlpGetForObject_Filters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvGetForObject)).EndInit();
            this.TpgGetAnnotations.ResumeLayout(false);
            this.TlpGetAnnotations.ResumeLayout(false);
            this.TlpGetAnnotations.PerformLayout();
            this.TpgAcknowledge.ResumeLayout(false);
            this.TlpAckAlarm.ResumeLayout(false);
            this.TlpAckAlarm.PerformLayout();
            this.TpgDiscardAlarm.ResumeLayout(false);
            this.TlpDiscardAlarm.ResumeLayout(false);
            this.TlpDiscardAlarm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabMain;
        private System.Windows.Forms.TabPage TpgAcknowledge;
        private System.Windows.Forms.TabPage TpgFindById;
        private System.Windows.Forms.TableLayoutPanel TlpAckAlarm;
        private System.Windows.Forms.TabPage TpgGetForNetworkDevice;
        private System.Windows.Forms.TabPage TpgGetForObject;
        private System.Windows.Forms.TabPage TpgGetAnnotations;
        private System.Windows.Forms.TabPage TpgGet;
        private System.Windows.Forms.TableLayoutPanel TlpFindById;
        private System.Windows.Forms.TableLayoutPanel TlpGetForNetworkDevice;
        private System.Windows.Forms.TableLayoutPanel TlpGetForObject;
        private System.Windows.Forms.TableLayoutPanel TlpGetAnnotations;
        private System.Windows.Forms.TableLayoutPanel TlpGet;
        private System.Windows.Forms.Label LblGet_Filters;
        private System.Windows.Forms.TableLayoutPanel TlpGet_Filters;
        private System.Windows.Forms.Label LblGet_StartTime;
        private System.Windows.Forms.DateTimePicker DtpGet_StartTime;
        private System.Windows.Forms.Label LblGet_EndTime;
        private System.Windows.Forms.DateTimePicker DtpGet_EndTime;
        private System.Windows.Forms.CheckBox ChkGet_NoFilters;
        private System.Windows.Forms.CheckBox ChkGet_ExcludeAcknowledged;
        private System.Windows.Forms.CheckBox ChkGet_ExcludeDiscarded;
        private System.Windows.Forms.Button BtnGet;
        private System.Windows.Forms.DataGridView DgvGet;
        private System.Windows.Forms.Label LblFindById_AlarmId;
        private System.Windows.Forms.TextBox TxtFindById_AlarmId;
        private System.Windows.Forms.Button BtnFindById;
        private System.Windows.Forms.PropertyGrid PrgFindById;
        private System.Windows.Forms.Label LblGetForNetworkDevice_DeviceId;
        private System.Windows.Forms.TextBox TxtGetForNetworkDevice_DeviceId;
        private System.Windows.Forms.Label LblGetForNetworkDevice_Filters;
        private System.Windows.Forms.TableLayoutPanel TlpGetForNetworkDevice_Filters;
        private System.Windows.Forms.CheckBox ChkGetForNetworkDevice_NoFilters;
        private System.Windows.Forms.Label LblGetForNetworkDevice_StartTime;
        private System.Windows.Forms.Label LblGetForNetworkDevice_EndTime;
        private System.Windows.Forms.DateTimePicker DtpGetForNetworkDevice_StartTime;
        private System.Windows.Forms.DateTimePicker DtpGetForNetworkDevice_EndTime;
        private System.Windows.Forms.CheckBox ChkGetForNetworkDevice_ExcludeAcknowledged;
        private System.Windows.Forms.CheckBox ChkGetForNetworkDevice_ExcludeDiscarded;
        private System.Windows.Forms.Button BtnGetForNetworkDevice;
        private System.Windows.Forms.DataGridView DgvGetForNetworkDevice;
        private System.Windows.Forms.Label LblGetForObject_ObjectId;
        private System.Windows.Forms.TextBox TxtGetForObject_ObjectId;
        private System.Windows.Forms.Label LblGetForObject_Filters;
        private System.Windows.Forms.TableLayoutPanel TlpGetForObject_Filters;
        private System.Windows.Forms.Label LblGetForObject_StartTime;
        private System.Windows.Forms.Label LblGetForObject_EndTime;
        private System.Windows.Forms.CheckBox ChkGetForObject_NoFilters;
        private System.Windows.Forms.DateTimePicker DtpGetForObject_StartTime;
        private System.Windows.Forms.DateTimePicker DtpGetForObject_EndTime;
        private System.Windows.Forms.CheckBox ChkGetForObject_ExcludeAcknowledged;
        private System.Windows.Forms.Button BtnGetForObject;
        private System.Windows.Forms.CheckBox ChkGetForObject_ExcludeDiscarded;
        private System.Windows.Forms.DataGridView DgvGetForObject;
        private System.Windows.Forms.Label LblGetAnnotations_AlarmId;
        private System.Windows.Forms.TextBox TxtGetAnnotations_AlarmId;
        private System.Windows.Forms.Button BtnGetAnnotations;
        private System.Windows.Forms.TextBox TxtGetAnnotations_Result;
        private System.Windows.Forms.Label LblAckAlarm_AlarmId;
        private System.Windows.Forms.TextBox TxtAckAlarm_AlarmId;
        private System.Windows.Forms.Label LblAckAlarm_AnnotationText;
        private System.Windows.Forms.TextBox TxtAckAlarm_AnnotationText;
        private System.Windows.Forms.Button BtnAcknowledgeAlarm;
        private System.Windows.Forms.TextBox TxtAckAlarm_Result;
        private System.Windows.Forms.Label LblAckAlarm_Result;
        private System.Windows.Forms.Label LblFindById_Title;
        private System.Windows.Forms.Label LblAck_Title;
        private System.Windows.Forms.Label LblGet_Title;
        private System.Windows.Forms.Label LblGetForNetworkDevice_Title;
        private System.Windows.Forms.Label LblGetForObject_Title;
        private System.Windows.Forms.Label GetAnnotations_Title;
        private System.Windows.Forms.TabPage TpgDiscardAlarm;
        private System.Windows.Forms.TableLayoutPanel TlpDiscardAlarm;
        private System.Windows.Forms.Label LblDiscardAlarm_AlarmId;
        private System.Windows.Forms.TextBox TxtDiscardAlarm_AlarmId;
        private System.Windows.Forms.Label LblDiscardAlarm_AnnotationText;
        private System.Windows.Forms.TextBox TxtDiscardAlarm_AnnotationText;
        private System.Windows.Forms.Button BtnDiscardAlarm;
        private System.Windows.Forms.TextBox TxtDiscardAlarm_Result;
        private System.Windows.Forms.Label LblDiscardAlarm_Result;
        private System.Windows.Forms.Label LblDiscard_Title;
    }
}