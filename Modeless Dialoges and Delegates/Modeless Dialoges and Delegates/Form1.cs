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
    
    public partial class Form_MainForm : Form
    {

        Form_Secondary _formTwo;// = new Form_Secondary(this);

        public delstringvoid DelBringToForm;
        public delvoidstring DelSendToForm;
        public string MainInBox
        {
            get { return TxtBox_In.Text; }
            set { TxtBox_In.Text = value; }
        }

        public string MainOutBox
        {
            get { return TxtBox_Out.Text; }
            set { TxtBox_Out.Text = value; }
        }
        public Form_MainForm()
        {
            InitializeComponent();
            

            _formTwo = new Form_Secondary(this);
            _formTwo.PassToOutput = new delvoidstring(TestIn);
            _formTwo.BringIn = new delstringvoid(PassAway);

            _formTwo.Show();
        }

        private string PassAway()
        {
            return TxtBox_Out.Text;
        }

        private void TestIn(string s)
        {
            TxtBox_In.Text = s;
        }

        private void Btn_Pull_Click(object sender, EventArgs e)
        {
            //pull data from other form
            //TxtBox_In.Text = _formTwo.BringIn.Invoke();
            TxtBox_In.Text = DelBringToForm.Invoke();
        }

        private void Btn_Send_Click(object sender, EventArgs e)
        {
            //push data to other form
            //_formTwo.PassToOutput(TxtBox_Out.Text);
            DelSendToForm.Invoke(TxtBox_Out.Text);

        }

        private void Btn_SetIn_Click(object sender, EventArgs e)
        {
            //set the inbox with the text from other form
            TxtBox_In.Text = _formTwo.OutBox;
        }

        private void Btn_toGet_Click(object sender, EventArgs e)
        {
            //send text away - need set for other form
            _formTwo.InBox = TxtBox_Out.Text;
        }
    }
}
