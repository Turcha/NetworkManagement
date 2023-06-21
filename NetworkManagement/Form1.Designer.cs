namespace NetworkManagement
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеNetworkManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnAddNameDevice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIPAddressDevice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLocationDevice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTypeDevice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.ErrIpAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ErrStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ErrNameDevice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ErrLocationDevice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ErrTimeDevice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ErrEndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.IpAddressDevice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusDevice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDeviceForMonitoring = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocationDeviceMonitoring = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeDeviceMonitoring = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1274, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеNetworkManagementToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеNetworkManagementToolStripMenuItem
            // 
            this.оПрограммеNetworkManagementToolStripMenuItem.Name = "оПрограммеNetworkManagementToolStripMenuItem";
            this.оПрограммеNetworkManagementToolStripMenuItem.Size = new System.Drawing.Size(270, 22);
            this.оПрограммеNetworkManagementToolStripMenuItem.Text = "О Программе NetworkManagement";
            this.оПрограммеNetworkManagementToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеNetworkManagementToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1254, 626);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1246, 600);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Настройки";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.checkedListBox1);
            this.groupBox3.Location = new System.Drawing.Point(7, 346);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(455, 248);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Удалить устройство";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(133, 213);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(189, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Удалить устр-во";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(6, 19);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(443, 184);
            this.checkedListBox1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnAddNameDevice,
            this.ColumnIPAddressDevice,
            this.ColumnLocationDevice,
            this.ColumnTypeDevice});
            this.dataGridView1.Location = new System.Drawing.Point(474, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(766, 569);
            this.dataGridView1.TabIndex = 6;
            // 
            // ColumnAddNameDevice
            // 
            this.ColumnAddNameDevice.HeaderText = "Название устройства";
            this.ColumnAddNameDevice.Name = "ColumnAddNameDevice";
            this.ColumnAddNameDevice.ReadOnly = true;
            // 
            // ColumnIPAddressDevice
            // 
            this.ColumnIPAddressDevice.HeaderText = "Ip Адрес";
            this.ColumnIPAddressDevice.Name = "ColumnIPAddressDevice";
            this.ColumnIPAddressDevice.ReadOnly = true;
            // 
            // ColumnLocationDevice
            // 
            this.ColumnLocationDevice.HeaderText = "Расположение устройства";
            this.ColumnLocationDevice.Name = "ColumnLocationDevice";
            this.ColumnLocationDevice.ReadOnly = true;
            // 
            // ColumnTypeDevice
            // 
            this.ColumnTypeDevice.HeaderText = "Тип устройства";
            this.ColumnTypeDevice.Name = "ColumnTypeDevice";
            this.ColumnTypeDevice.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Location = new System.Drawing.Point(243, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(225, 314);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Синхронизация данных с сервером";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(9, 143);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(206, 23);
            this.progressBar1.TabIndex = 3;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(37, 69);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(153, 20);
            this.textBox5.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "IP адрес сервера";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(53, 259);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "Подключиться";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 314);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавить устройство";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(15, 159);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(189, 20);
            this.textBox4.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Тип устройства";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Добавить устр-во";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(15, 213);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(189, 20);
            this.textBox3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Расположение устройства";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(189, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "IP адрес устройства";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(15, 109);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(189, 20);
            this.textBox2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название устройства";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1246, 600);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Мониторинг";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(7, 329);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(126, 23);
            this.button6.TabIndex = 7;
            this.button6.Text = "Очистить ошибки";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView3);
            this.groupBox4.Location = new System.Drawing.Point(139, 310);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1099, 284);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ошибки";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ErrIpAddress,
            this.ErrStatus,
            this.ErrNameDevice,
            this.ErrLocationDevice,
            this.ErrTimeDevice,
            this.ErrEndTime});
            this.dataGridView3.Location = new System.Drawing.Point(7, 19);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(1086, 259);
            this.dataGridView3.TabIndex = 0;
            // 
            // ErrIpAddress
            // 
            this.ErrIpAddress.HeaderText = "IP Адрес";
            this.ErrIpAddress.Name = "ErrIpAddress";
            this.ErrIpAddress.ReadOnly = true;
            // 
            // ErrStatus
            // 
            this.ErrStatus.HeaderText = "Cтатус";
            this.ErrStatus.Name = "ErrStatus";
            this.ErrStatus.ReadOnly = true;
            // 
            // ErrNameDevice
            // 
            this.ErrNameDevice.HeaderText = "Название устройства";
            this.ErrNameDevice.Name = "ErrNameDevice";
            this.ErrNameDevice.ReadOnly = true;
            // 
            // ErrLocationDevice
            // 
            this.ErrLocationDevice.HeaderText = "Расположение устройства";
            this.ErrLocationDevice.Name = "ErrLocationDevice";
            this.ErrLocationDevice.ReadOnly = true;
            // 
            // ErrTimeDevice
            // 
            this.ErrTimeDevice.HeaderText = "Время";
            this.ErrTimeDevice.Name = "ErrTimeDevice";
            this.ErrTimeDevice.ReadOnly = true;
            // 
            // ErrEndTime
            // 
            this.ErrEndTime.HeaderText = "Текущее время";
            this.ErrEndTime.Name = "ErrEndTime";
            this.ErrEndTime.ReadOnly = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(7, 77);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(126, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "Остановить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(7, 34);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(126, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Запустить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataGridView2);
            this.groupBox5.Location = new System.Drawing.Point(139, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1099, 300);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Мониторинг устройств";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IpAddressDevice,
            this.StatusDevice,
            this.nameDeviceForMonitoring,
            this.LocationDeviceMonitoring,
            this.TypeDeviceMonitoring});
            this.dataGridView2.Location = new System.Drawing.Point(6, 19);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(1087, 276);
            this.dataGridView2.TabIndex = 0;
            // 
            // IpAddressDevice
            // 
            this.IpAddressDevice.HeaderText = "IP адрес";
            this.IpAddressDevice.Name = "IpAddressDevice";
            this.IpAddressDevice.ReadOnly = true;
            // 
            // StatusDevice
            // 
            this.StatusDevice.HeaderText = "Статус";
            this.StatusDevice.Name = "StatusDevice";
            this.StatusDevice.ReadOnly = true;
            // 
            // nameDeviceForMonitoring
            // 
            this.nameDeviceForMonitoring.HeaderText = "Название устройства";
            this.nameDeviceForMonitoring.Name = "nameDeviceForMonitoring";
            this.nameDeviceForMonitoring.ReadOnly = true;
            // 
            // LocationDeviceMonitoring
            // 
            this.LocationDeviceMonitoring.HeaderText = "Расположение устройства";
            this.LocationDeviceMonitoring.Name = "LocationDeviceMonitoring";
            this.LocationDeviceMonitoring.ReadOnly = true;
            // 
            // TypeDeviceMonitoring
            // 
            this.TypeDeviceMonitoring.HeaderText = "Тип устройства";
            this.TypeDeviceMonitoring.Name = "TypeDeviceMonitoring";
            this.TypeDeviceMonitoring.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 660);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "NetworkMonitoring";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеNetworkManagementToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAddNameDevice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIPAddressDevice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLocationDevice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTypeDevice;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridViewTextBoxColumn IpAddressDevice;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusDevice;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDeviceForMonitoring;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocationDeviceMonitoring;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeDeviceMonitoring;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ErrIpAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn ErrStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn ErrNameDevice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ErrLocationDevice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ErrTimeDevice;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridViewTextBoxColumn ErrEndTime;
    }
}

