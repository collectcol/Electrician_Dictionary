using Electrician_Dictionary.API;
using Electrician_Dictionary.ElecDictionary;
using Microsoft.VisualBasic.Devices;
using OpenAI_API.Moderation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Electrician_Dictionary
{
    public partial class StartForm : Form
    {
        public bool check = false;
        public StartForm()
        {
            InitializeComponent();
        }
        private void StartForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LinkStart();
        }

        private void LinkStart()
        {
            if (string.IsNullOrWhiteSpace(txtKeyInsert.Text))
            {
                MessageBox.Show("Key값을 입력해주세요");
                return;
            }

            Link_ChatAPI.KeySetting(txtKeyInsert.Text);
            Link_ChatAPI.Link();
            Link_ChatAPI.startForm = this;
        }

        private void txtKeyInsert_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LinkStart();
            }
        }
    }
}
