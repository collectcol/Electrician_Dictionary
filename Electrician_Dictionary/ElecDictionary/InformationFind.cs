using Electrician_Dictionary.API;
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
    public partial class InformationFind : Form
    {
        public InformationFind()
        {
            InitializeComponent();
        }

        private void InformationFind_Load(object sender, EventArgs e)
        {

        }

        private void response()
        {
            if (string.IsNullOrWhiteSpace(txtQuestion.Text.ToString())) return;

            string? response = Link_ChatAPI.ApiSetting(txtQuestion.Text.ToString()).ToString();

            if (response == null) return;

            txtAnswer.Text = response;
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            response();
        }
    }
}
