﻿namespace pcapdatacopy
{
	// Token: 0x02000008 RID: 8
	//[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Form1 : global::System.Windows.Forms.Form
	{
		// Token: 0x06000020 RID: 32 RVA: 0x00002944 File Offset: 0x00000D44
		[global::System.Diagnostics.DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				bool flag = disposing && this.components != null;
				if (flag)
				{
					this.components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002994 File Offset: 0x00000D94
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.OpenFileDialog1 = new global::System.Windows.Forms.OpenFileDialog();
			this.selectfile_button = new global::System.Windows.Forms.Button();
			this.file_selected_textbox = new global::System.Windows.Forms.TextBox();
			this.raw_output_file_textbox = new global::System.Windows.Forms.TextBox();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.create_raw_file_button = new global::System.Windows.Forms.Button();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.current_status_label = new global::System.Windows.Forms.Label();
			this.GroupBox2 = new global::System.Windows.Forms.GroupBox();
			this.GroupBox3 = new global::System.Windows.Forms.GroupBox();
			this.dummy_button = new global::System.Windows.Forms.Button();
			this.FolderBrowserDialog1 = new global::System.Windows.Forms.FolderBrowserDialog();
			this.GroupBox4 = new global::System.Windows.Forms.GroupBox();
			this.selectfolder_button = new global::System.Windows.Forms.Button();
			this.folder_selected_textbox = new global::System.Windows.Forms.TextBox();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.GroupBox5 = new global::System.Windows.Forms.GroupBox();
			this.packet_type = new global::System.Windows.Forms.ComboBox();
			this.Label12 = new global::System.Windows.Forms.Label();
			this.GroupBox7 = new global::System.Windows.Forms.GroupBox();
			this.filter2_checkbox = new global::System.Windows.Forms.CheckBox();
			this.destination_ip2 = new global::System.Windows.Forms.ComboBox();
			this.source_ip2 = new global::System.Windows.Forms.ComboBox();
			this.Label11 = new global::System.Windows.Forms.Label();
			this.Label10 = new global::System.Windows.Forms.Label();
			this.analyse_file = new global::System.Windows.Forms.Button();
			this.destination_ip1 = new global::System.Windows.Forms.ComboBox();
			this.source_ip1 = new global::System.Windows.Forms.ComboBox();
			this.Label8 = new global::System.Windows.Forms.Label();
			this.Label6 = new global::System.Windows.Forms.Label();
			this.payload_offset = new global::System.Windows.Forms.NumericUpDown();
			this.Label7 = new global::System.Windows.Forms.Label();
			this.header_length = new global::System.Windows.Forms.NumericUpDown();
			this.Label5 = new global::System.Windows.Forms.Label();
			this.GroupBox6 = new global::System.Windows.Forms.GroupBox();
			this.merged_output_file_textbox = new global::System.Windows.Forms.TextBox();
			this.Label9 = new global::System.Windows.Forms.Label();
			this.create_merged_file_button = new global::System.Windows.Forms.Button();
			this.GroupBox8 = new global::System.Windows.Forms.GroupBox();
			this.create_audio_rtp_files_button = new global::System.Windows.Forms.Button();
			this.rtp_status = new global::System.Windows.Forms.TextBox();
			this.detect_rtp = new global::System.Windows.Forms.Button();
			this.Label14 = new global::System.Windows.Forms.Label();
			this.raw_rtp_output_folder = new global::System.Windows.Forms.TextBox();
			this.Label13 = new global::System.Windows.Forms.Label();
			this.create_raw_rtp_file_button = new global::System.Windows.Forms.Button();
			this.GroupBox1.SuspendLayout();
			this.GroupBox2.SuspendLayout();
			this.GroupBox3.SuspendLayout();
			this.GroupBox4.SuspendLayout();
			this.GroupBox5.SuspendLayout();
			this.GroupBox7.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.payload_offset).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.header_length).BeginInit();
			this.GroupBox6.SuspendLayout();
			this.GroupBox8.SuspendLayout();
			this.SuspendLayout();
			this.OpenFileDialog1.FileName = "OpenFileDialog1";
			this.selectfile_button.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			global::System.Windows.Forms.Control selectfile_button = this.selectfile_button;
			global::System.Drawing.Point location = new global::System.Drawing.Point(642, 19);
			selectfile_button.Location = location;
			this.selectfile_button.Name = "selectfile_button";
			global::System.Windows.Forms.Control selectfile_button2 = this.selectfile_button;
			global::System.Drawing.Size size = new global::System.Drawing.Size(145, 32);
			selectfile_button2.Size = size;
			this.selectfile_button.TabIndex = 0;
			this.selectfile_button.Text = "Select Input File";
			this.selectfile_button.UseVisualStyleBackColor = true;
			global::System.Windows.Forms.Control file_selected_textbox = this.file_selected_textbox;
			location = new global::System.Drawing.Point(134, 23);
			file_selected_textbox.Location = location;
			this.file_selected_textbox.Name = "file_selected_textbox";
			global::System.Windows.Forms.Control file_selected_textbox2 = this.file_selected_textbox;
			size = new global::System.Drawing.Size(488, 20);
			file_selected_textbox2.Size = size;
			this.file_selected_textbox.TabIndex = 1;
			global::System.Windows.Forms.Control raw_output_file_textbox = this.raw_output_file_textbox;
			location = new global::System.Drawing.Point(138, 32);
			raw_output_file_textbox.Location = location;
			this.raw_output_file_textbox.Name = "raw_output_file_textbox";
			global::System.Windows.Forms.Control raw_output_file_textbox2 = this.raw_output_file_textbox;
			size = new global::System.Drawing.Size(485, 20);
			raw_output_file_textbox2.Size = size;
			this.raw_output_file_textbox.TabIndex = 2;
			this.Label1.AutoSize = true;
			this.Label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			global::System.Windows.Forms.Control label = this.Label1;
			location = new global::System.Drawing.Point(19, 27);
			label.Location = location;
			this.Label1.Name = "Label1";
			global::System.Windows.Forms.Control label2 = this.Label1;
			size = new global::System.Drawing.Size(109, 16);
			label2.Size = size;
			this.Label1.TabIndex = 3;
			this.Label1.Text = "Input File (.pcap):";
			this.Label2.AutoSize = true;
			this.Label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			global::System.Windows.Forms.Control label3 = this.Label2;
			location = new global::System.Drawing.Point(28, 33);
			label3.Location = location;
			this.Label2.Name = "Label2";
			global::System.Windows.Forms.Control label4 = this.Label2;
			size = new global::System.Drawing.Size(104, 16);
			label4.Size = size;
			this.Label2.TabIndex = 4;
			this.Label2.Text = "Raw Output File:";
			this.create_raw_file_button.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			global::System.Windows.Forms.Control create_raw_file_button = this.create_raw_file_button;
			location = new global::System.Drawing.Point(643, 19);
			create_raw_file_button.Location = location;
			this.create_raw_file_button.Name = "create_raw_file_button";
			global::System.Windows.Forms.Control create_raw_file_button2 = this.create_raw_file_button;
			size = new global::System.Drawing.Size(142, 44);
			create_raw_file_button2.Size = size;
			this.create_raw_file_button.TabIndex = 5;
			this.create_raw_file_button.Text = "Create Raw Payload File";
			this.create_raw_file_button.UseVisualStyleBackColor = true;
			this.Label3.AutoSize = true;
			this.Label3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			global::System.Windows.Forms.Control label5 = this.Label3;
			location = new global::System.Drawing.Point(17, 16);
			label5.Location = location;
			this.Label3.Name = "Label3";
			global::System.Windows.Forms.Control label6 = this.Label3;
			size = new global::System.Drawing.Size(93, 16);
			label6.Size = size;
			this.Label3.TabIndex = 6;
			this.Label3.Text = "Current Status:";
			this.GroupBox1.Controls.Add(this.current_status_label);
			this.GroupBox1.Controls.Add(this.Label3);
			global::System.Windows.Forms.Control groupBox = this.GroupBox1;
			location = new global::System.Drawing.Point(8, 629);
			groupBox.Location = location;
			this.GroupBox1.Name = "GroupBox1";
			global::System.Windows.Forms.Control groupBox2 = this.GroupBox1;
			size = new global::System.Drawing.Size(794, 55);
			groupBox2.Size = size;
			this.GroupBox1.TabIndex = 7;
			this.GroupBox1.TabStop = false;
			this.current_status_label.AutoSize = true;
			this.current_status_label.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			global::System.Windows.Forms.Control current_status_label = this.current_status_label;
			location = new global::System.Drawing.Point(116, 16);
			current_status_label.Location = location;
			this.current_status_label.Name = "current_status_label";
			global::System.Windows.Forms.Control current_status_label2 = this.current_status_label;
			size = new global::System.Drawing.Size(142, 16);
			current_status_label2.Size = size;
			this.current_status_label.TabIndex = 7;
			this.current_status_label.Text = "Awaiting File Selection";
			this.GroupBox2.Controls.Add(this.selectfile_button);
			this.GroupBox2.Controls.Add(this.file_selected_textbox);
			this.GroupBox2.Controls.Add(this.Label1);
			global::System.Windows.Forms.Control groupBox3 = this.GroupBox2;
			location = new global::System.Drawing.Point(11, 6);
			groupBox3.Location = location;
			this.GroupBox2.Name = "GroupBox2";
			global::System.Windows.Forms.Control groupBox4 = this.GroupBox2;
			size = new global::System.Drawing.Size(793, 66);
			groupBox4.Size = size;
			this.GroupBox2.TabIndex = 12;
			this.GroupBox2.TabStop = false;
			this.GroupBox3.Controls.Add(this.raw_output_file_textbox);
			this.GroupBox3.Controls.Add(this.Label2);
			this.GroupBox3.Controls.Add(this.create_raw_file_button);
			global::System.Windows.Forms.Control groupBox5 = this.GroupBox3;
			location = new global::System.Drawing.Point(9, 420);
			groupBox5.Location = location;
			this.GroupBox3.Name = "GroupBox3";
			global::System.Windows.Forms.Control groupBox6 = this.GroupBox3;
			size = new global::System.Drawing.Size(794, 78);
			groupBox6.Size = size;
			this.GroupBox3.TabIndex = 13;
			this.GroupBox3.TabStop = false;
			this.dummy_button.BackColor = global::System.Drawing.SystemColors.Window;
			global::System.Windows.Forms.Control dummy_button = this.dummy_button;
			location = new global::System.Drawing.Point(688, 490);
			dummy_button.Location = location;
			this.dummy_button.Name = "dummy_button";
			global::System.Windows.Forms.Control dummy_button2 = this.dummy_button;
			size = new global::System.Drawing.Size(2, 2);
			dummy_button2.Size = size;
			this.dummy_button.TabIndex = 12;
			this.dummy_button.UseVisualStyleBackColor = false;
			this.GroupBox4.Controls.Add(this.selectfolder_button);
			this.GroupBox4.Controls.Add(this.folder_selected_textbox);
			this.GroupBox4.Controls.Add(this.Label4);
			global::System.Windows.Forms.Control groupBox7 = this.GroupBox4;
			location = new global::System.Drawing.Point(11, 78);
			groupBox7.Location = location;
			this.GroupBox4.Name = "GroupBox4";
			global::System.Windows.Forms.Control groupBox8 = this.GroupBox4;
			size = new global::System.Drawing.Size(793, 66);
			groupBox8.Size = size;
			this.GroupBox4.TabIndex = 13;
			this.GroupBox4.TabStop = false;
			this.selectfolder_button.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			global::System.Windows.Forms.Control selectfolder_button = this.selectfolder_button;
			location = new global::System.Drawing.Point(642, 19);
			selectfolder_button.Location = location;
			this.selectfolder_button.Name = "selectfolder_button";
			global::System.Windows.Forms.Control selectfolder_button2 = this.selectfolder_button;
			size = new global::System.Drawing.Size(145, 32);
			selectfolder_button2.Size = size;
			this.selectfolder_button.TabIndex = 0;
			this.selectfolder_button.Text = "Select Input Folder";
			this.selectfolder_button.UseVisualStyleBackColor = true;
			global::System.Windows.Forms.Control folder_selected_textbox = this.folder_selected_textbox;
			location = new global::System.Drawing.Point(134, 26);
			folder_selected_textbox.Location = location;
			this.folder_selected_textbox.Name = "folder_selected_textbox";
			global::System.Windows.Forms.Control folder_selected_textbox2 = this.folder_selected_textbox;
			size = new global::System.Drawing.Size(488, 20);
			folder_selected_textbox2.Size = size;
			this.folder_selected_textbox.TabIndex = 1;
			this.Label4.AutoSize = true;
			this.Label4.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			global::System.Windows.Forms.Control label7 = this.Label4;
			location = new global::System.Drawing.Point(47, 27);
			label7.Location = location;
			this.Label4.Name = "Label4";
			global::System.Windows.Forms.Control label8 = this.Label4;
			size = new global::System.Drawing.Size(81, 16);
			label8.Size = size;
			this.Label4.TabIndex = 3;
			this.Label4.Text = "Input Folder:";
			this.GroupBox5.Controls.Add(this.packet_type);
			this.GroupBox5.Controls.Add(this.Label12);
			this.GroupBox5.Controls.Add(this.GroupBox7);
			this.GroupBox5.Controls.Add(this.analyse_file);
			this.GroupBox5.Controls.Add(this.destination_ip1);
			this.GroupBox5.Controls.Add(this.source_ip1);
			this.GroupBox5.Controls.Add(this.Label8);
			this.GroupBox5.Controls.Add(this.Label6);
			this.GroupBox5.Controls.Add(this.payload_offset);
			this.GroupBox5.Controls.Add(this.Label7);
			this.GroupBox5.Controls.Add(this.header_length);
			this.GroupBox5.Controls.Add(this.Label5);
			global::System.Windows.Forms.Control groupBox9 = this.GroupBox5;
			location = new global::System.Drawing.Point(13, 150);
			groupBox9.Location = location;
			this.GroupBox5.Name = "GroupBox5";
			global::System.Windows.Forms.Control groupBox10 = this.GroupBox5;
			size = new global::System.Drawing.Size(791, 154);
			groupBox10.Size = size;
			this.GroupBox5.TabIndex = 14;
			this.GroupBox5.TabStop = false;
			this.packet_type.FormattingEnabled = true;
			this.packet_type.Items.AddRange(new object[]
			{
				"TCP & UDP",
				"TCP",
				"UDP"
			});
			global::System.Windows.Forms.Control packet_type = this.packet_type;
			location = new global::System.Drawing.Point(116, 74);
			packet_type.Location = location;
			this.packet_type.Name = "packet_type";
			global::System.Windows.Forms.Control packet_type2 = this.packet_type;
			size = new global::System.Drawing.Size(114, 21);
			packet_type2.Size = size;
			this.packet_type.TabIndex = 19;
			this.Label12.AutoSize = true;
			this.Label12.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			global::System.Windows.Forms.Control label9 = this.Label12;
			location = new global::System.Drawing.Point(27, 75);
			label9.Location = location;
			this.Label12.Name = "Label12";
			global::System.Windows.Forms.Control label10 = this.Label12;
			size = new global::System.Drawing.Size(88, 16);
			label10.Size = size;
			this.Label12.TabIndex = 18;
			this.Label12.Text = "Packet Type:";
			this.GroupBox7.Controls.Add(this.filter2_checkbox);
			this.GroupBox7.Controls.Add(this.destination_ip2);
			this.GroupBox7.Controls.Add(this.source_ip2);
			this.GroupBox7.Controls.Add(this.Label11);
			this.GroupBox7.Controls.Add(this.Label10);
			global::System.Windows.Forms.Control groupBox11 = this.GroupBox7;
			location = new global::System.Drawing.Point(285, 72);
			groupBox11.Location = location;
			this.GroupBox7.Name = "GroupBox7";
			global::System.Windows.Forms.Control groupBox12 = this.GroupBox7;
			size = new global::System.Drawing.Size(496, 74);
			groupBox12.Size = size;
			this.GroupBox7.TabIndex = 17;
			this.GroupBox7.TabStop = false;
			this.filter2_checkbox.AutoSize = true;
			this.filter2_checkbox.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			global::System.Windows.Forms.Control filter2_checkbox = this.filter2_checkbox;
			location = new global::System.Drawing.Point(365, 28);
			filter2_checkbox.Location = location;
			this.filter2_checkbox.Name = "filter2_checkbox";
			global::System.Windows.Forms.Control filter2_checkbox2 = this.filter2_checkbox;
			size = new global::System.Drawing.Size(112, 20);
			filter2_checkbox2.Size = size;
			this.filter2_checkbox.TabIndex = 22;
			this.filter2_checkbox.Text = "Enable Filter 2";
			this.filter2_checkbox.UseVisualStyleBackColor = true;
			this.destination_ip2.Enabled = false;
			this.destination_ip2.FormattingEnabled = true;
			global::System.Windows.Forms.Control destination_ip = this.destination_ip2;
			location = new global::System.Drawing.Point(191, 42);
			destination_ip.Location = location;
			this.destination_ip2.Name = "destination_ip2";
			global::System.Windows.Forms.Control destination_ip2 = this.destination_ip2;
			size = new global::System.Drawing.Size(145, 21);
			destination_ip2.Size = size;
			this.destination_ip2.TabIndex = 21;
			this.source_ip2.Enabled = false;
			this.source_ip2.FormattingEnabled = true;
			global::System.Windows.Forms.Control source_ip = this.source_ip2;
			location = new global::System.Drawing.Point(191, 15);
			source_ip.Location = location;
			this.source_ip2.Name = "source_ip2";
			global::System.Windows.Forms.Control source_ip2 = this.source_ip2;
			size = new global::System.Drawing.Size(145, 21);
			source_ip2.Size = size;
			this.source_ip2.TabIndex = 20;
			this.Label11.AutoSize = true;
			this.Label11.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			global::System.Windows.Forms.Control label11 = this.Label11;
			location = new global::System.Drawing.Point(35, 16);
			label11.Location = location;
			this.Label11.Name = "Label11";
			global::System.Windows.Forms.Control label12 = this.Label11;
			size = new global::System.Drawing.Size(136, 16);
			label12.Size = size;
			this.Label11.TabIndex = 18;
			this.Label11.Text = "Source IP Address: 2:";
			this.Label10.AutoSize = true;
			this.Label10.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			global::System.Windows.Forms.Control label13 = this.Label10;
			location = new global::System.Drawing.Point(14, 43);
			label13.Location = location;
			this.Label10.Name = "Label10";
			global::System.Windows.Forms.Control label14 = this.Label10;
			size = new global::System.Drawing.Size(157, 16);
			label14.Size = size;
			this.Label10.TabIndex = 19;
			this.Label10.Text = "Destination IP Address 2:";
			this.analyse_file.Enabled = false;
			global::System.Windows.Forms.Control analyse_file = this.analyse_file;
			location = new global::System.Drawing.Point(640, 16);
			analyse_file.Location = location;
			this.analyse_file.Name = "analyse_file";
			global::System.Windows.Forms.Control analyse_file2 = this.analyse_file;
			size = new global::System.Drawing.Size(142, 50);
			analyse_file2.Size = size;
			this.analyse_file.TabIndex = 16;
			this.analyse_file.Text = "Detect IP Addresses Used";
			this.analyse_file.UseVisualStyleBackColor = true;
			this.destination_ip1.Enabled = false;
			this.destination_ip1.FormattingEnabled = true;
			global::System.Windows.Forms.Control destination_ip3 = this.destination_ip1;
			location = new global::System.Drawing.Point(475, 45);
			destination_ip3.Location = location;
			this.destination_ip1.Name = "destination_ip1";
			global::System.Windows.Forms.Control destination_ip4 = this.destination_ip1;
			size = new global::System.Drawing.Size(145, 21);
			destination_ip4.Size = size;
			this.destination_ip1.TabIndex = 15;
			this.source_ip1.Enabled = false;
			this.source_ip1.FormattingEnabled = true;
			global::System.Windows.Forms.Control source_ip3 = this.source_ip1;
			location = new global::System.Drawing.Point(475, 16);
			source_ip3.Location = location;
			this.source_ip1.Name = "source_ip1";
			global::System.Windows.Forms.Control source_ip4 = this.source_ip1;
			size = new global::System.Drawing.Size(145, 21);
			source_ip4.Size = size;
			this.source_ip1.TabIndex = 14;
			this.Label8.AutoSize = true;
			this.Label8.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			global::System.Windows.Forms.Control label15 = this.Label8;
			location = new global::System.Drawing.Point(299, 47);
			label15.Location = location;
			this.Label8.Name = "Label8";
			global::System.Windows.Forms.Control label16 = this.Label8;
			size = new global::System.Drawing.Size(157, 16);
			label16.Size = size;
			this.Label8.TabIndex = 13;
			this.Label8.Text = "Destination IP Address 1:";
			this.Label6.AutoSize = true;
			this.Label6.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			global::System.Windows.Forms.Control label17 = this.Label6;
			location = new global::System.Drawing.Point(323, 21);
			label17.Location = location;
			this.Label6.Name = "Label6";
			global::System.Windows.Forms.Control label18 = this.Label6;
			size = new global::System.Drawing.Size(133, 16);
			label18.Size = size;
			this.Label6.TabIndex = 12;
			this.Label6.Text = "Source IP Address 1:";
			global::System.Windows.Forms.Control payload_offset = this.payload_offset;
			location = new global::System.Drawing.Point(179, 42);
			payload_offset.Location = location;
			global::System.Windows.Forms.NumericUpDown payload_offset2 = this.payload_offset;
			decimal num = new decimal(new int[]
			{
				9000,
				0,
				0,
				0
			});
			payload_offset2.Maximum = num;
			this.payload_offset.Name = "payload_offset";
			global::System.Windows.Forms.Control payload_offset3 = this.payload_offset;
			size = new global::System.Drawing.Size(51, 20);
			payload_offset3.Size = size;
			this.payload_offset.TabIndex = 11;
			this.Label7.AutoSize = true;
			this.Label7.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			global::System.Windows.Forms.Control label19 = this.Label7;
			location = new global::System.Drawing.Point(9, 45);
			label19.Location = location;
			this.Label7.Name = "Label7";
			global::System.Windows.Forms.Control label20 = this.Label7;
			size = new global::System.Drawing.Size(164, 16);
			label20.Size = size;
			this.Label7.TabIndex = 10;
			this.Label7.Text = "Payload Byte Copy Offset:";
			global::System.Windows.Forms.Control header_length = this.header_length;
			location = new global::System.Drawing.Point(179, 16);
			header_length.Location = location;
			this.header_length.Name = "header_length";
			global::System.Windows.Forms.Control header_length2 = this.header_length;
			size = new global::System.Drawing.Size(51, 20);
			header_length2.Size = size;
			this.header_length.TabIndex = 7;
			global::System.Windows.Forms.NumericUpDown header_length3 = this.header_length;
			num = new decimal(new int[]
			{
				42,
				0,
				0,
				0
			});
			header_length3.Value = num;
			this.Label5.AutoSize = true;
			this.Label5.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			global::System.Windows.Forms.Control label21 = this.Label5;
			location = new global::System.Drawing.Point(27, 16);
			label21.Location = location;
			this.Label5.Name = "Label5";
			global::System.Windows.Forms.Control label22 = this.Label5;
			size = new global::System.Drawing.Size(145, 16);
			label22.Size = size;
			this.Label5.TabIndex = 6;
			this.Label5.Text = "Packet Header Length:";
			this.GroupBox6.Controls.Add(this.merged_output_file_textbox);
			this.GroupBox6.Controls.Add(this.Label9);
			this.GroupBox6.Controls.Add(this.create_merged_file_button);
			global::System.Windows.Forms.Control groupBox13 = this.GroupBox6;
			location = new global::System.Drawing.Point(8, 504);
			groupBox13.Location = location;
			this.GroupBox6.Name = "GroupBox6";
			global::System.Windows.Forms.Control groupBox14 = this.GroupBox6;
			size = new global::System.Drawing.Size(795, 119);
			groupBox14.Size = size;
			this.GroupBox6.TabIndex = 14;
			this.GroupBox6.TabStop = false;
			global::System.Windows.Forms.Control merged_output_file_textbox = this.merged_output_file_textbox;
			location = new global::System.Drawing.Point(139, 30);
			merged_output_file_textbox.Location = location;
			this.merged_output_file_textbox.Name = "merged_output_file_textbox";
			global::System.Windows.Forms.Control merged_output_file_textbox2 = this.merged_output_file_textbox;
			size = new global::System.Drawing.Size(485, 20);
			merged_output_file_textbox2.Size = size;
			this.merged_output_file_textbox.TabIndex = 2;
			this.Label9.AutoSize = true;
			this.Label9.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			global::System.Windows.Forms.Control label23 = this.Label9;
			location = new global::System.Drawing.Point(9, 31);
			label23.Location = location;
			this.Label9.Name = "Label9";
			global::System.Windows.Forms.Control label24 = this.Label9;
			size = new global::System.Drawing.Size(124, 16);
			label24.Size = size;
			this.Label9.TabIndex = 4;
			this.Label9.Text = "Merged Output File:";
			this.create_merged_file_button.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			global::System.Windows.Forms.Control create_merged_file_button = this.create_merged_file_button;
			location = new global::System.Drawing.Point(644, 19);
			create_merged_file_button.Location = location;
			this.create_merged_file_button.Name = "create_merged_file_button";
			global::System.Windows.Forms.Control create_merged_file_button2 = this.create_merged_file_button;
			size = new global::System.Drawing.Size(142, 44);
			create_merged_file_button2.Size = size;
			this.create_merged_file_button.TabIndex = 5;
			this.create_merged_file_button.Text = "Create Merged .PCAP File";
			this.create_merged_file_button.UseVisualStyleBackColor = true;
			this.GroupBox8.Controls.Add(this.create_audio_rtp_files_button);
			this.GroupBox8.Controls.Add(this.rtp_status);
			this.GroupBox8.Controls.Add(this.detect_rtp);
			this.GroupBox8.Controls.Add(this.Label14);
			this.GroupBox8.Controls.Add(this.raw_rtp_output_folder);
			this.GroupBox8.Controls.Add(this.Label13);
			this.GroupBox8.Controls.Add(this.create_raw_rtp_file_button);
			global::System.Windows.Forms.Control groupBox15 = this.GroupBox8;
			location = new global::System.Drawing.Point(13, 310);
			groupBox15.Location = location;
			this.GroupBox8.Name = "GroupBox8";
			global::System.Windows.Forms.Control groupBox16 = this.GroupBox8;
			size = new global::System.Drawing.Size(794, 104);
			groupBox16.Size = size;
			this.GroupBox8.TabIndex = 14;
			this.GroupBox8.TabStop = false;
			this.create_audio_rtp_files_button.Enabled = false;
			this.create_audio_rtp_files_button.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			global::System.Windows.Forms.Control create_audio_rtp_files_button = this.create_audio_rtp_files_button;
			location = new global::System.Drawing.Point(633, 62);
			create_audio_rtp_files_button.Location = location;
			this.create_audio_rtp_files_button.Name = "create_audio_rtp_files_button";
			global::System.Windows.Forms.Control create_audio_rtp_files_button2 = this.create_audio_rtp_files_button;
			size = new global::System.Drawing.Size(142, 28);
			create_audio_rtp_files_button2.Size = size;
			this.create_audio_rtp_files_button.TabIndex = 23;
			this.create_audio_rtp_files_button.Text = "Create RTP Audio Files";
			this.create_audio_rtp_files_button.UseVisualStyleBackColor = true;
			global::System.Windows.Forms.Control rtp_status = this.rtp_status;
			location = new global::System.Drawing.Point(139, 23);
			rtp_status.Location = location;
			this.rtp_status.Name = "rtp_status";
			global::System.Windows.Forms.Control rtp_status2 = this.rtp_status;
			size = new global::System.Drawing.Size(317, 20);
			rtp_status2.Size = size;
			this.rtp_status.TabIndex = 22;
			this.detect_rtp.Enabled = false;
			global::System.Windows.Forms.Control detect_rtp = this.detect_rtp;
			location = new global::System.Drawing.Point(479, 19);
			detect_rtp.Location = location;
			this.detect_rtp.Name = "detect_rtp";
			global::System.Windows.Forms.Control detect_rtp2 = this.detect_rtp;
			size = new global::System.Drawing.Size(142, 28);
			detect_rtp2.Size = size;
			this.detect_rtp.TabIndex = 20;
			this.detect_rtp.Text = "Detect RTP Streams";
			this.detect_rtp.UseVisualStyleBackColor = true;
			this.Label14.AutoSize = true;
			this.Label14.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			global::System.Windows.Forms.Control label25 = this.Label14;
			location = new global::System.Drawing.Point(11, 24);
			label25.Location = location;
			this.Label14.Name = "Label14";
			global::System.Windows.Forms.Control label26 = this.Label14;
			size = new global::System.Drawing.Size(125, 16);
			label26.Size = size;
			this.Label14.TabIndex = 21;
			this.Label14.Text = "RTP Stream Status:";
			global::System.Windows.Forms.Control raw_rtp_output_folder = this.raw_rtp_output_folder;
			location = new global::System.Drawing.Point(139, 69);
			raw_rtp_output_folder.Location = location;
			this.raw_rtp_output_folder.Name = "raw_rtp_output_folder";
			global::System.Windows.Forms.Control raw_rtp_output_folder2 = this.raw_rtp_output_folder;
			size = new global::System.Drawing.Size(481, 20);
			raw_rtp_output_folder2.Size = size;
			this.raw_rtp_output_folder.TabIndex = 2;
			this.Label13.AutoSize = true;
			this.Label13.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			global::System.Windows.Forms.Control label27 = this.Label13;
			location = new global::System.Drawing.Point(11, 69);
			label27.Location = location;
			this.Label13.Name = "Label13";
			global::System.Windows.Forms.Control label28 = this.Label13;
			size = new global::System.Drawing.Size(122, 16);
			label28.Size = size;
			this.Label13.TabIndex = 4;
			this.Label13.Text = "RTP Output Folder:";
			this.create_raw_rtp_file_button.Enabled = false;
			this.create_raw_rtp_file_button.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			global::System.Windows.Forms.Control create_raw_rtp_file_button = this.create_raw_rtp_file_button;
			location = new global::System.Drawing.Point(633, 17);
			create_raw_rtp_file_button.Location = location;
			this.create_raw_rtp_file_button.Name = "create_raw_rtp_file_button";
			global::System.Windows.Forms.Control create_raw_rtp_file_button2 = this.create_raw_rtp_file_button;
			size = new global::System.Drawing.Size(142, 28);
			create_raw_rtp_file_button2.Size = size;
			this.create_raw_rtp_file_button.TabIndex = 5;
			this.create_raw_rtp_file_button.Text = "Create Raw RTP Files";
			this.create_raw_rtp_file_button.UseVisualStyleBackColor = true;
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			size = new global::System.Drawing.Size(816, 696);
			this.ClientSize = size;
			this.Controls.Add(this.GroupBox8);
			this.Controls.Add(this.GroupBox6);
			this.Controls.Add(this.GroupBox5);
			this.Controls.Add(this.GroupBox4);
			this.Controls.Add(this.dummy_button);
			this.Controls.Add(this.GroupBox3);
			this.Controls.Add(this.GroupBox2);
			this.Controls.Add(this.GroupBox1);
			this.Name = "Form1";
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Wireshark .pcap Data Copy Application (V1.5)";
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			this.GroupBox2.ResumeLayout(false);
			this.GroupBox2.PerformLayout();
			this.GroupBox3.ResumeLayout(false);
			this.GroupBox3.PerformLayout();
			this.GroupBox4.ResumeLayout(false);
			this.GroupBox4.PerformLayout();
			this.GroupBox5.ResumeLayout(false);
			this.GroupBox5.PerformLayout();
			this.GroupBox7.ResumeLayout(false);
			this.GroupBox7.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.payload_offset).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.header_length).EndInit();
			this.GroupBox6.ResumeLayout(false);
			this.GroupBox6.PerformLayout();
			this.GroupBox8.ResumeLayout(false);
			this.GroupBox8.PerformLayout();
			this.ResumeLayout(false);
		}

		// Token: 0x0400000B RID: 11
		private global::System.ComponentModel.IContainer components;
	}
}