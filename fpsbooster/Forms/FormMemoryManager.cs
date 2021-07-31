using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Runtime.ConstrainedExecution;
using System.Security;
using System.Management;

namespace fpsbooster.Forms
{
    public partial class FormMemoryManager : Form
    {
        public FormMemoryManager()
        {
            InitializeComponent();
            ManagementObjectSearcher searcherram =
                        new ManagementObjectSearcher("root\\CIMV2",
                        "SELECT * FROM Win32_PhysicalMemory");

            ManagementObjectSearcher searchercpu =
                    new ManagementObjectSearcher("root\\CIMV2",
                    "SELECT * FROM Win32_Processor");

            foreach (ManagementObject queryObj in searchercpu.Get())
            {
                cpuname.Text = string.Format("Name: {0}", queryObj["Name"]);
                l2cachesize.Text = string.Format("L2CacheSize : {0} Bytes", queryObj["L2CacheSize"]);
                maxclock.Text = string.Format("MaxClockSpeed : {0} MHz", queryObj["MaxClockSpeed"]);
            }

            foreach (ManagementObject queryObj in searcherram.Get())
            {
                //Console.WriteLine("Win32_PhysicalMemory instance");
                capacity.Text = string.Format("Capacity : {0} Bytes", queryObj["Capacity"]);
                manufacturer.Text = string.Format("Manufacturer : {0}", queryObj["Manufacturer"]);
                speed.Text = string.Format("Speed : {0} MHz", queryObj["Speed"]);
            }
        }

        private PerformanceCounter perfMemoryCounter = new PerformanceCounter("Memory", "Available MBytes");
        private PerformanceCounter perfSystemCounter = new PerformanceCounter("System", "System Up Time");
        private int warnCount;

        private void FormMemoryManager_Load(object sender, EventArgs e)
        {
            controller.Start();
        }

        private void controller_Tick(object sender, EventArgs e)
        {
            try
            {
                Double CPUtprt = 0;
                System.Management.ManagementObjectSearcher mos = new System.Management.ManagementObjectSearcher(@"root\WMI", "Select * From MSAcpi_ThermalZoneTemperature");
                foreach (System.Management.ManagementObject mo in mos.Get())
                {
                    CPUtprt = Convert.ToDouble(Convert.ToDouble(mo.GetPropertyValue("CurrentTemperature").ToString()) - 2732) / 10;
                    cputemp.Text = "CPU Temperature : " + CPUtprt.ToString() + " °C";
                }
                float cpux = PCPU.NextValue();
                float ramx = PRAM.NextValue();
                cpuStatusBar.Value = (int)cpux;
                ramStatusBar.Value = (int)ramx;
                availableMemory.Text = $"Available Memory : {(int)perfMemoryCounter.NextValue()} MB";
                upTime.Text = $"System Up Time : {(int)perfSystemCounter.NextValue() / 60 / 60 + " Hours"}";

                if ((int)ramx <= 49)
                {
                    ramStatusBar.ProgressColor = Color.Green;
                }
                else if ((int)ramx >= 50 && (int)ramx <= 79)
                {
                    ramStatusBar.ProgressColor = Color.Yellow;
                }
                else
                {
                    ramStatusBar.ProgressColor = Color.Yellow;
                }
            }
            catch (Exception ex)
            {
                cputemp.Text = ex.Message;
            }
        }
    }
}