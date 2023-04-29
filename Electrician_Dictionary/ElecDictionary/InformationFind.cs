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

namespace Electrician_Dictionary.ElecDictionary
{
    public partial class InformationFind : MaterialForm
    {
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

            string? response = await Link_ChatAPI.ApiSetting(txtQuestion.Text.ToString());

            if (response == null) return;

            string[] paragraphs = response.Split(new string[] { "\n\n" }, StringSplitOptions.RemoveEmptyEntries);
            StringBuilder formattedResponse = new StringBuilder();

            foreach (string paragraph in paragraphs)
            {
                formattedResponse.AppendLine(paragraph);
                formattedResponse.AppendLine(); // 문단 사이에 빈 줄 추가
            }

            txtAnswer.Text = formattedResponse.ToString();
            if (Link_ChatAPI.Prompt == 0)
            {
                Link_ChatAPI.Prompt = 1;
            }
        }


        private void btnRequest_Click(object sender, EventArgs e)
        {
            response();
        }
    }
}
