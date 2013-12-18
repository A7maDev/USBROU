using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace USBROU
{
    public partial class MainForm : Form
    {

        private bool isEnabled;
        private bool isAdmin;
        private RegistryKey baseRegistry = Registry.LocalMachine;
        private string keyPath = "SYSTEM\\CurrentControlSet\\Control\\StorageDevicePolicies";
        private string keyName = "WriteProtect";

        public MainForm()
        {
            InitializeComponent();
        }

        private void devLabel_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.anacodist.com");
        }

        private void checkStatus()
        {

            int keyValue;

            // Open as read-only
            RegistryKey subRKey = baseRegistry.OpenSubKey(keyPath);

            //check the key value
            try
            {
                if (subRKey == null)
                {
                    isEnabled = false;
                }
                else
                {

                    if (subRKey.GetValue(keyName) != null)
                    {
                        keyValue = (int)subRKey.GetValue(keyName);
                        if (keyValue == 0)
                        {
                            isEnabled = false;
                        }
                        else if (keyValue == 1)
                        {
                            isEnabled = true;
                        }
                    }
                    else
                    {
                        isEnabled = false;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            changeStatusLabelAndButtons();
        }

        private void changeStatusLabelAndButtons()
        {
            //Change status label and color
            if (isEnabled == true)
            {
                //set label
                statusLabel.Text = "Enabled";
                statusLabel.ForeColor = Color.Green;

                //set buttons
                enableButton.Enabled = false;
                disableButton.Enabled = true;
            }
            else if (isEnabled == false)
            {
                //set label
                statusLabel.Text = "Disabled";
                statusLabel.ForeColor = Color.Red;

                //set buttons
                enableButton.Enabled = true;
                disableButton.Enabled = false;
            }
        }

        private void changeStatus(int value)
        {
            try
            {
                if (value == 0 || value == 1)
                {
                    RegistryKey subRKey = baseRegistry.CreateSubKey(keyPath);
                    subRKey.SetValue(keyName, value);

                    checkStatus();
                    changeStatusLabelAndButtons();
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //check if admin
            isAdmin = new WindowsPrincipal(WindowsIdentity.GetCurrent())
                   .IsInRole(WindowsBuiltInRole.Administrator) ? true : false;

            //Disable buttons if not admin, if admin continue
            if (!isAdmin)
            {
                MessageBox.Show("Administrator privileges are required!", "USB ROU", MessageBoxButtons.OK, MessageBoxIcon.Error);
                enableButton.Enabled = false;
                disableButton.Enabled = false;
            }
            else
            {
                checkStatus();
            }
        }

        private void disableButton_Click(object sender, EventArgs e)
        {
            //disable protection
            changeStatus(0);

            //show message
            MessageBox.Show("Please unplug and replug the USB!", "USB ROU", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void enableButton_Click(object sender, EventArgs e)
        {
            //enable protection
            changeStatus(1);

            //show message
            MessageBox.Show("Please unplug and replug the USB!", "USB ROU", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
