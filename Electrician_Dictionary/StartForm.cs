using Electrician_Dictionary.API;
using Electrician_Dictionary.ElecDictionary;
using Electrician_Dictionary.Enum;
using Electrician_Dictionary.Information;
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
            var itemList = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>(PromptEnum.Electrical_Engineering.ToString(), "전기공학 교수"),
                new KeyValuePair<string, string>(PromptEnum.English.ToString(), "영어전공 교수"),
                new KeyValuePair<string, string>(PromptEnum.Computer_Science.ToString(), "컴퓨터공학 교수")
            };

            cmbPrompt.DataSource = itemList;
            cmbPrompt.DisplayMember = "Value";
            cmbPrompt.ValueMember = "Key";
            cmbPrompt.SelectedIndex = 0;

            radioKorean.Checked = true;
            radioTwoForm.Checked = true;
        }

        private string RadioButtonGetValue(Control collection)
        {
            string value = "";
            var controls = collection.Controls;

            foreach (var control in controls)
            {
                var radiobutton = control as RadioButton;
                if (radiobutton != null && radiobutton.Checked)
                {
                    value = radiobutton.Text;
                }
            }

            return value;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            LinkStart();
        }

        private ChatGPT_Info ChatGPT_InsertInfo()
        {
            ChatGPT_Info info = new ChatGPT_Info();
            info.prompt = cmbPrompt.SelectedValue.ToString();
            info.ranguage = RadioButtonGetValue(panelOutPutRanguage);
            info.chatFormSetting = RadioButtonGetValue(panelChatFormSetting);

            return info;
        }

        private void LinkStart()
        {
            ChatGPT_InsertInfo();

            Link_ChatAPI.info = ChatGPT_InsertInfo();
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

        private void StartForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!Link_ChatAPI.ResultYN)
            {
                Application.Exit();
            }
        }
    }
}
