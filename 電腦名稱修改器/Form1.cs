using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;


namespace 電腦名稱修改器
{
    public partial class Form1 : Form
    {
        string _computerName = System.Windows.Forms.SystemInformation.ComputerName;
        //變更電腦名稱
        [DllImport("kernel32.dll")]
        static extern bool SetComputerName(string lpComputerName);
        [DllImport("kernel32.dll")]
        static extern bool SetComputerNameEx(_COMPUTER_NAME_FORMAT iType, string lpComputerName);
        enum _COMPUTER_NAME_FORMAT
        {
            ComputerNameNetBIOS,
            ComputerNameDnsHostname,
            ComputerNameDnsDomain,
            ComputerNameDnsFullyQualified,
            ComputerNamePhysicalNetBIOS,
            ComputerNamePhysicalDnsHostname,
            ComputerNamePhysicalDnsDomain,
            ComputerNamePhysicalDnsFullyQualified,
            ComputerNameMax
        };
        public Form1()
        {
            InitializeComponent();
            lb_OriginalName.Text = $"舊電腦名稱：   {_computerName}";
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            tb_NewName.Text = string.Empty;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                string MachineName = tb_NewName.Text.Trim();
                if (MachineName == "")
                {
                    MessageBox.Show("請輸入新電腦名稱。");
                    return;
                }
                bool succeeded = SetComputerName(MachineName);
                bool succeeded2 = SetComputerNameEx(_COMPUTER_NAME_FORMAT.ComputerNamePhysicalDnsHostname, MachineName);
                if (succeeded && succeeded2)
                {
                    tb_NewName.Enabled = false;
                    btn_Save.Visible = false;
                    btn_Clear.Enabled = false;
                    btn_Restart.Visible = true;
                }
                else
                {
                    MessageBox.Show("修改失敗請使用系統管理員權限執行。");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"系統發生錯誤，資訊如下：{ex.Message}");
            }
        }

        private void btn_Restart_Click(object sender, EventArgs e)
        {
            try
            {
                ManagementClass mmc = new ManagementClass("Win32_OperatingSystem");
                mmc.Scope.Options.EnablePrivileges = true;
                foreach (ManagementObject mo in mmc.GetInstances())
                {
                    mo.InvokeMethod("Reboot", null, null);
                }
                mmc.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"系統發生錯誤，資訊如下：{ex.Message}");
            }
        }
    }
}
