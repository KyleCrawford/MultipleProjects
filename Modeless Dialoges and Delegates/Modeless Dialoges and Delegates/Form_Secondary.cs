using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modeless_Dialoges_and_Delegates
{
    
    public delegate void delvoidstring(string s);
    public delegate string delstringvoid();
    public partial class Form_Secondary : Form
    {
        public delvoidstring PassToOutput;
        public delstringvoid BringIn;

        Form_MainForm _mainForm;

        public string InBox
        {
            get { return TxtBox_InB.Text; }
            set { TxtBox_InB.Text = value; }
        }

        public string OutBox
        {
            get { return TxtBox_OutB.Text; }
            set { TxtBox_OutB.Text = value; }
        }

        public Form_Secondary(Form_MainForm mainForm)
        {
            InitializeComponent();

            _mainForm = mainForm;

            _mainForm.DelBringToForm = new delstringvoid(ReturnValue);
            _mainForm.DelSendToForm = new delvoidstring(SendValue);
        }

        private void SendValue(string s)
        {
            TxtBox_InB.Text = s;
        }

        private string ReturnValue()
        {
            return TxtBox_OutB.Text;
        }

        private void Btn_PullB_Click(object sender, EventArgs e)
        {
            //bring info from other form
            TxtBox_InB.Text = BringIn.Invoke();
        }

        private void Btn_SendB_Click(object sender, EventArgs e)
        {
            //send info to other form
            PassToOutput.Invoke(TxtBox_OutB.Text);
        }
    }
}
