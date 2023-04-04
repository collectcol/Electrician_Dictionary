using Electrician_Dictionary.API;
using Electrician_Dictionary.ElecDictionary;
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

            if (this.ShowDialog() == DialogResult.OK)
            {
                this.Close();
                Application.Run(new InformationFind());
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKeyInsert.Text))
            {
                MessageBox.Show("Key값을 입력해주세요");
                return;
            }

            Link_ChatAPI.KeySetting(txtKeyInsert.Text);
            Link_ChatAPI.Link();

            //InformationFind showform = new InformationFind();
            //showform.Show();
            check = true;
            if (check)
            {
                this.DialogResult = DialogResult.OK;
            }
        }

    }
}
