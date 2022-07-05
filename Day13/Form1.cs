using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            string fullname = "",Details="";
            fullname=TxtFirstName.Text+TxtlastName.Text;
            LblFullName.Text=fullname;
            Details += $"First Name : {TxtFirstName.Text}\nLast Name : {TxtlastName.Text}" +
                $"\nPrefix : {ComboPrefix.SelectedItem.ToString()+TxtFirstName.Text}" +
                $"\nTitle : {TxtTitle.Text}\nCity : {TxtCity.Text}\nState : {ComboState.SelectedItem.ToString()}\nZip Code : {TxtZipCode.Text}\n" +
                $"Home Phone : {TxtHomePhone.Text}\nMobile Phone : {TxtMobilePhone.Text}\nEmail : {TxtEmail.Text}\nSkype : {TxtSkype.Text}" +
                $"\nDepartment : {ComboDepartment.SelectedItem.ToString()}" +
                $"\nStatus : {ComboStatus.SelectedItem.ToString()}" +
                $"\nHire Date : {DtpHireDate.Value.ToShortDateString()}" +
                $"\nDate of Birth : {DtpDateofBirth.Value.ToShortDateString()}";


            MessageBox.Show(Details);
            MessageBox.Show("done");
        }
    }
}
