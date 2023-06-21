using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetworkManagement
{
    public delegate void DataGrid(DataGridView view, string msg, int id);
    public delegate void ErrDevice(DataGridView view, string msg, int id, string[] data);
    public delegate void UpdateGrid(DataGridView view1, DataGridView view2);
    public partial class Form1 : Form
    {
        //название устройств
        string nameDevice = "";
        //ip адрес устройств
        string ipAddr = "";
        //тип устройства
        string typeDevice = "";
        //Расположение устройства
        string locationDevice = "";
        FileInfo file;
        Thread thr1;
        DataGrid grid;
        UpdateGrid updateGridErr;
        ErrDevice errDev;

        public Form1()
        {
            InitializeComponent();
            groupBox2.Enabled = false;
            button5.Enabled = false;
            grid = new DataGrid(MonitoringDataGrid);
            updateGridErr = new UpdateGrid(ErrorUpdateGrid);
            errDev = new ErrDevice(ErrorDataGrid);
            ListNetworkDevice();
            ListNetworkMonitoring();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //Добавить устройство
        private void button1_Click(object sender, EventArgs e)
        {
            AddNetworkDevice();
            checkedListBox1.Items.Clear();
            ListNetworkDevice();
            ListNetworkMonitoring();
        }
        //Метод в котором добавляем сетевые устройства
        private void AddNetworkDevice()
        {
            //Указываем название устройства
            nameDevice = textBox1.Text;
            //Указываем ip адрес устройства
            ipAddr = textBox2.Text;
            //Указываем тип устройства
            typeDevice = textBox4.Text;
            //Указываем расположение устройства
            locationDevice = textBox3.Text;

            if (String.IsNullOrEmpty(nameDevice) || String.IsNullOrEmpty(ipAddr) || String.IsNullOrEmpty(typeDevice) || String.IsNullOrEmpty(locationDevice))
            {
                MessageBox.Show("Не все поля заполнены!!!");
            }
            else
            {
                //Проверка на корректность ввода ip адреса
                if (!Regex.IsMatch(ipAddr, @"(\d{1,3}.\d{1,3}.\d{1,3}.\d{1,3})", RegexOptions.CultureInvariant))
                {
                    textBox2.BackColor = Color.Red;
                    MessageBox.Show("Неверный формат ip адреса!!!");
                }
                else
                {
                    dataGridView1.Rows.Add(nameDevice, ipAddr, typeDevice, locationDevice);
                    file = new FileInfo("TableData.txt");
                    //Получим последний индекс строки из таблицы
                    int indexRow = dataGridView1.Rows.GetLastRow(DataGridViewElementStates.None);
                    string data = "";
                    for(int i = 0; i < dataGridView1.ColumnCount; i++)
                    {
                        data += String.Format("{0} ", dataGridView1.Rows[indexRow-1].Cells[i].Value);
                    }
                    //Environment.NewLine -> запись с новой строки
                    data += Environment.NewLine;

                    //Проверяем существует данных файл или нет.
                    if (file.Exists)
                    {
                        //Если файл существует тогда мы открываем, и записываем нужные нам данные в файл.
                        File.AppendAllText(file.FullName, data);
                    }
                    else
                    {
                        //Если файл не существует тогда создаем
                        File.AppendAllText(file.FullName, data);
                    }
                   
                }
            }
        }
        //Список сетевых устройств
        private void ListNetworkDevice()
        {
            file = new FileInfo("TableData.txt");
            //Проверяем существует на файл с данными
            if (file.Exists)
            {
                //Выполняем если существует
                string[] data = File.ReadAllLines(file.FullName);
                for(int i = 0; i < data.Length; i++)
                {
                   checkedListBox1.Items.Add(data[i]);
                }
            }
        }
        //Удаление сетевых устройств
        private void DelNetworkDevice()
        {
            if (file.Exists)
                for (int i = checkedListBox1.Items.Count - 1; i >= 0; i--)
                    if (checkedListBox1.GetItemChecked(i))
                        checkedListBox1.Items.RemoveAt(i);
                   
            string[] data = new string[checkedListBox1.Items.Count];

            for (int i = 0; i < checkedListBox1.Items.Count; i++)
              data[i] = checkedListBox1.Items[i].ToString();

            File.WriteAllLines("TableData.txt", data);
        }
        //Список устройств которые будут отправлять icmp пакеты
        private void ListNetworkMonitoring()
        {
            dataGridView2.Rows.Clear();
            //Запишем все строки из файла
            string[] data = File.ReadAllLines("TableData.txt");
            int number = 0;
            for(int i = 0; i < data.Length; i++) {
                string[] buffer = data[i].Split(' ');
                //Добавляем новую строку
                number = dataGridView2.Rows.Add();

                dataGridView2.Rows[number].Cells["IpAddressDevice"].Value = buffer[1];
                dataGridView2.Rows[number].Cells["nameDeviceForMonitoring"].Value = buffer[0];
                dataGridView2.Rows[number].Cells["TypeDeviceMonitoring"].Value = buffer[2];
                dataGridView2.Rows[number].Cells["LocationDeviceMonitoring"].Value = buffer[3];
                dataGridView2.Rows[number].Cells["StatusDevice"].Style.ForeColor = Color.Blue;
                dataGridView2.Rows[number].Cells["StatusDevice"].Value = "Ожидание...";
            }
        }
        //Удалить устройство
        private void button2_Click(object sender, EventArgs e)
        {
            DelNetworkDevice();
            ListNetworkMonitoring();
        }
        //Статус устройств
        private void MonitoringDataGrid(DataGridView view, string msg, int id)
        {
            if(msg == "SUCCESS")
            {
                view.Rows[id].Cells["StatusDevice"].Style.ForeColor = Color.Green;
            }
            else if (msg == "FAILD")
            {
                view.Rows[id].Cells["StatusDevice"].Style.ForeColor = Color.Red;
            }
            else if(msg == "Ожидание...")
            {
                view.Rows[id].Cells["StatusDevice"].Style.ForeColor = Color.Blue;
            }

            view.Rows[id].Cells["StatusDevice"].Value = msg;
        }
        //Ошибки устройств
        private void ErrorDataGrid(DataGridView view, string msg, int id, string[] data)
        {
            string ip = "";
            string[] result = data[id].Split(' ');
            bool select = true;

            if (view.Rows.Count > 1)
            {
                for (int i = 0; i < view.Rows.Count-1; i++)
                {
                    if ((ip = view.Rows[i].Cells["ErrIpAddress"].Value.ToString()) != null) {
                        if (result[1] == ip)
                        {
                            view.Rows[i].Cells["ErrEndTime"].Value = DateTime.Now;
                            select = false;
                        }
                    }
                }
            }

            if (select)
            {
                int add = view.Rows.Add();
                view.Rows[add].Cells["ErrIpAddress"].Value = result[1];
                view.Rows[add].Cells["ErrStatus"].Style.ForeColor = Color.Red;
                view.Rows[add].Cells["ErrStatus"].Value = msg;
                view.Rows[add].Cells["ErrNameDevice"].Value = result[0];
                view.Rows[add].Cells["ErrLocationDevice"].Value = result[3];
                view.Rows[add].Cells["ErrTimeDevice"].Value = DateTime.Now;
            }
        }
        //Убераем из таблицы исправленые устройства
        private void ErrorUpdateGrid(DataGridView view1, DataGridView view2)
        {
            string r1 = "";
            string r2 = "";
    
            for (int i = 0; i < view2.Rows.Count - 1; i++)
            {
               for (int j = 0; j < view1.Rows.Count - 1; j++)
               {
                  r1 = view1.Rows[j].Cells["IpAddressDevice"].Value.ToString().Trim();
                  if((r2 = view2.Rows[i].Cells["ErrIpAddress"].Value.ToString().Trim()) != null){
                      if (r1 == r2){
                         if (view1.Rows[j].Cells["StatusDevice"].Value.ToString().Trim() == "SUCCESS")
                            view2.Rows.RemoveAt(i);
                            break;
                      }
                  }
 
               }
             
            }
        }
        //Запускаем мониторинг сети
        private void PingNetwork()
        {
            string[] data = File.ReadAllLines("TableData.txt");
            string[] ipAddr = new string[data.Length];
            
            for(int i = 0; i < data.Length; i++)
            {
                string[] ip = data[i].Split(' ');

                ipAddr[i] = ip[1];
            }

            Ping p = new Ping();

            while (true)
            {
                for (int i = 0; i < ipAddr.Length; i++)
                {
                    Thread.Sleep(3000);
                    try
                    {
                        PingReply result = p.Send(ipAddr[i]);

                        if (result.Status == IPStatus.Success)
                        {
                            Invoke(grid, dataGridView2, "SUCCESS", i);
                            Invoke(updateGridErr, dataGridView2, dataGridView3);
                        }
                        else
                        {
                            Invoke(grid, dataGridView2, "FAILD", i);
                            Invoke(errDev, dataGridView3, "FAILD", i, data);
                        }
                    }
                    catch(PingException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                Thread.Sleep(3000);
                for (int i = 0; i < ipAddr.Length; i++)
                {
                    Invoke(grid, dataGridView2, "Ожидание...", i);
                }

            }
        }
        //Запустить пинг
        private void button4_Click(object sender, EventArgs e)
        {
            thr1 = new Thread(new ThreadStart(PingNetwork));
            thr1.Start();
            button4.Enabled = false;
            button5.Enabled = true;
        }
        //Остановить пинг
        private void button5_Click(object sender, EventArgs e)
        {
            thr1.Abort();
            button4.Enabled = true;
            button5.Enabled = false;
        }  
        //Очистить окно с ошибками
        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView3.Rows.Clear();
        }

        private void оПрограммеNetworkManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Version v = new Version();
            v.Show();
        }
    }
}
