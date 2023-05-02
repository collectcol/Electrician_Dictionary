using Electrician_Dictionary.API;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Electrician_Dictionary.ElecDictionary
{
    public partial class InformationFind : MaterialForm
    {
        private List<string> requestText = new List<string>();
        public InformationFind()
        {
            InitializeComponent();
        }

        private void InformationFind_Load(object sender, EventArgs e)
        {

        }

        private async void response()
        {
            if (string.IsNullOrWhiteSpace(txtQuestion.Text.ToString())) return;

            string response = await Link_ChatAPI.ApiSetting(txtQuestion.Text.ToString());

            foreach (char c in response)
            {
                StringSetting(c);
                await Task.Delay(50);
            }

            if (Link_ChatAPI.Prompt == 0)
            {
                Link_ChatAPI.Prompt = 1;
            }
        }

        private void StringSetting(char c)
        {
            txtAnswer.Text += c;
            if (c.Equals('.'))
            {
                txtAnswer.Text += Environment.NewLine;
            }
        }


        private void btnRequest_Click(object sender, EventArgs e)
        {
            response();
            txtAnswer.Text += "///" + Environment.NewLine;

        }

        private void txtQuestion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnRequest.PerformClick();
            }
            else if ((e.KeyCode == Keys.Enter) && (e.Control || e.Shift))
            {
                int index = txtQuestion.SelectionStart;
                txtQuestion.Text = txtQuestion.Text.Insert(index, Environment.NewLine);
                txtQuestion.SelectionStart = index + Environment.NewLine.Length;
                e.Handled = true;
            }
        }
    }
}
