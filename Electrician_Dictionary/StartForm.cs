using Electrician_Dictionary.API;
using Electrician_Dictionary.ElecDictionary;
using MaterialSkin;
using MaterialSkin.Controls;
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
    public partial class StartForm : MaterialForm
    {
        public bool check = false;
        public StartForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE);
        }
        private void StartForm_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void Init()
        {
            cmbPrompt.Items.Add(new string[] { "1", "전기공학 대학교수" });
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            LinkStart();
        }

        private void LinkStart()
        {
            if (string.IsNullOrWhiteSpace(txtKeyInsert.Text.ToString()))
            {
                MessageBox.Show("Key값을 입력해주세요");
                return;
            }

            Link_ChatAPI.KeySetting(txtKeyInsert.Text);

            //if (Link_ChatAPI.API == null)
            //{
            //    MessageBox.Show("연결되지 않았습니다.");
            //    return;
            //}

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
