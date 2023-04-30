﻿namespace Electrician_Dictionary
{
    partial class StartForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            label1 = new Label();
            cmbPrompt = new MaterialSkin.Controls.MaterialComboBox();
            panel2 = new Panel();
            radioEnglish = new MaterialSkin.Controls.MaterialRadioButton();
            radioKorean = new MaterialSkin.Controls.MaterialRadioButton();
            label2 = new Label();
            panel3 = new Panel();
            radioTwoForm = new MaterialSkin.Controls.MaterialRadioButton();
            radioOneForm = new MaterialSkin.Controls.MaterialRadioButton();
            label3 = new Label();
            listCurrnetFile = new MaterialSkin.Controls.MaterialListView();
            flowLayoutPanel2 = new FlowLayoutPanel();
            panel4 = new Panel();
            label4 = new Label();
            txtKeyInsert = new MaterialSkin.Controls.MaterialTextBox2();
            btnLogin = new MaterialSkin.Controls.MaterialButton();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(panel3);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(3, 88);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(704, 296);
            flowLayoutPanel1.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cmbPrompt);
            panel1.Location = new Point(15, 15);
            panel1.Margin = new Padding(15);
            panel1.Name = "panel1";
            panel1.Size = new Size(399, 118);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 0);
            label1.Name = "label1";
            label1.Size = new Size(135, 25);
            label1.TabIndex = 1;
            label1.Text = "Prompt_Choice";
            // 
            // cmbPrompt
            // 
            cmbPrompt.AutoResize = false;
            cmbPrompt.BackColor = Color.FromArgb(255, 255, 255);
            cmbPrompt.Depth = 0;
            cmbPrompt.DrawMode = DrawMode.OwnerDrawVariable;
            cmbPrompt.DropDownHeight = 174;
            cmbPrompt.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPrompt.DropDownWidth = 121;
            cmbPrompt.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmbPrompt.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbPrompt.FormattingEnabled = true;
            cmbPrompt.IntegralHeight = false;
            cmbPrompt.ItemHeight = 43;
            cmbPrompt.Location = new Point(24, 46);
            cmbPrompt.MaxDropDownItems = 4;
            cmbPrompt.MouseState = MaterialSkin.MouseState.OUT;
            cmbPrompt.Name = "cmbPrompt";
            cmbPrompt.Size = new Size(355, 49);
            cmbPrompt.StartIndex = 0;
            cmbPrompt.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(radioEnglish);
            panel2.Controls.Add(radioKorean);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(444, 15);
            panel2.Margin = new Padding(15);
            panel2.Name = "panel2";
            panel2.Size = new Size(237, 118);
            panel2.TabIndex = 1;
            // 
            // radioEnglish
            // 
            radioEnglish.AutoSize = true;
            radioEnglish.Depth = 0;
            radioEnglish.Location = new Point(127, 58);
            radioEnglish.Margin = new Padding(0);
            radioEnglish.MouseLocation = new Point(-1, -1);
            radioEnglish.MouseState = MaterialSkin.MouseState.HOVER;
            radioEnglish.Name = "radioEnglish";
            radioEnglish.Ripple = true;
            radioEnglish.Size = new Size(87, 37);
            radioEnglish.TabIndex = 3;
            radioEnglish.TabStop = true;
            radioEnglish.Text = "English";
            radioEnglish.UseVisualStyleBackColor = true;
            // 
            // radioKorean
            // 
            radioKorean.AutoSize = true;
            radioKorean.Depth = 0;
            radioKorean.Location = new Point(13, 58);
            radioKorean.Margin = new Padding(0);
            radioKorean.MouseLocation = new Point(-1, -1);
            radioKorean.MouseState = MaterialSkin.MouseState.HOVER;
            radioKorean.Name = "radioKorean";
            radioKorean.Ripple = true;
            radioKorean.Size = new Size(85, 37);
            radioKorean.TabIndex = 2;
            radioKorean.TabStop = true;
            radioKorean.Text = "Korean";
            radioKorean.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 0);
            label2.Name = "label2";
            label2.Size = new Size(157, 25);
            label2.TabIndex = 1;
            label2.Text = "OutPut_Ranguage";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(radioTwoForm);
            panel3.Controls.Add(radioOneForm);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(15, 163);
            panel3.Margin = new Padding(15);
            panel3.Name = "panel3";
            panel3.Size = new Size(305, 118);
            panel3.TabIndex = 2;
            // 
            // radioTwoForm
            // 
            radioTwoForm.AutoSize = true;
            radioTwoForm.Depth = 0;
            radioTwoForm.Location = new Point(166, 53);
            radioTwoForm.Margin = new Padding(0);
            radioTwoForm.MouseLocation = new Point(-1, -1);
            radioTwoForm.MouseState = MaterialSkin.MouseState.HOVER;
            radioTwoForm.Name = "radioTwoForm";
            radioTwoForm.Ripple = true;
            radioTwoForm.Size = new Size(107, 37);
            radioTwoForm.TabIndex = 4;
            radioTwoForm.TabStop = true;
            radioTwoForm.Text = "Two Form";
            radioTwoForm.UseVisualStyleBackColor = true;
            // 
            // radioOneForm
            // 
            radioOneForm.AutoSize = true;
            radioOneForm.Depth = 0;
            radioOneForm.Location = new Point(24, 53);
            radioOneForm.Margin = new Padding(0);
            radioOneForm.MouseLocation = new Point(-1, -1);
            radioOneForm.MouseState = MaterialSkin.MouseState.HOVER;
            radioOneForm.Name = "radioOneForm";
            radioOneForm.Ripple = true;
            radioOneForm.Size = new Size(104, 37);
            radioOneForm.TabIndex = 3;
            radioOneForm.TabStop = true;
            radioOneForm.Text = "One Form";
            radioOneForm.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 0);
            label3.Name = "label3";
            label3.Size = new Size(147, 25);
            label3.TabIndex = 1;
            label3.Text = "ChatFormSetting";
            // 
            // listCurrnetFile
            // 
            listCurrnetFile.AutoSizeTable = false;
            listCurrnetFile.BackColor = Color.FromArgb(255, 255, 255);
            listCurrnetFile.BorderStyle = BorderStyle.None;
            listCurrnetFile.Depth = 0;
            listCurrnetFile.FullRowSelect = true;
            listCurrnetFile.Location = new Point(24, 35);
            listCurrnetFile.MinimumSize = new Size(200, 100);
            listCurrnetFile.MouseLocation = new Point(-1, -1);
            listCurrnetFile.MouseState = MaterialSkin.MouseState.OUT;
            listCurrnetFile.Name = "listCurrnetFile";
            listCurrnetFile.OwnerDraw = true;
            listCurrnetFile.Size = new Size(234, 321);
            listCurrnetFile.TabIndex = 6;
            listCurrnetFile.UseCompatibleStateImageBehavior = false;
            listCurrnetFile.View = View.Details;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.Controls.Add(panel4);
            flowLayoutPanel2.Dock = DockStyle.Top;
            flowLayoutPanel2.Location = new Point(3, 384);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(704, 393);
            flowLayoutPanel2.TabIndex = 7;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(listCurrnetFile);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(15, 15);
            panel4.Margin = new Padding(15);
            panel4.Name = "panel4";
            panel4.Size = new Size(288, 363);
            panel4.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 0);
            label4.Name = "label4";
            label4.Size = new Size(125, 25);
            label4.TabIndex = 1;
            label4.Text = "CurrentFileList";
            // 
            // txtKeyInsert
            // 
            txtKeyInsert.AnimateReadOnly = false;
            txtKeyInsert.BackgroundImageLayout = ImageLayout.None;
            txtKeyInsert.CharacterCasing = CharacterCasing.Normal;
            txtKeyInsert.Depth = 0;
            txtKeyInsert.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtKeyInsert.HideSelection = true;
            txtKeyInsert.Hint = "Insert API key here";
            txtKeyInsert.LeadingIcon = null;
            txtKeyInsert.LeaveOnEnterKey = true;
            txtKeyInsert.Location = new Point(18, 780);
            txtKeyInsert.MaxLength = 32767;
            txtKeyInsert.MouseState = MaterialSkin.MouseState.OUT;
            txtKeyInsert.Name = "txtKeyInsert";
            txtKeyInsert.PasswordChar = '●';
            txtKeyInsert.PrefixSuffixText = null;
            txtKeyInsert.ReadOnly = false;
            txtKeyInsert.RightToLeft = RightToLeft.No;
            txtKeyInsert.SelectedText = "";
            txtKeyInsert.SelectionLength = 0;
            txtKeyInsert.SelectionStart = 0;
            txtKeyInsert.ShortcutsEnabled = true;
            txtKeyInsert.Size = new Size(677, 48);
            txtKeyInsert.TabIndex = 8;
            txtKeyInsert.TabStop = false;
            txtKeyInsert.TextAlign = HorizontalAlignment.Left;
            txtKeyInsert.TrailingIcon = null;
            txtKeyInsert.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.AutoSize = false;
            btnLogin.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLogin.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnLogin.Depth = 0;
            btnLogin.Font = new Font("맑은 고딕", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.HighEmphasis = true;
            btnLogin.Icon = null;
            btnLogin.Location = new Point(175, 853);
            btnLogin.Margin = new Padding(4, 6, 4, 6);
            btnLogin.MouseState = MaterialSkin.MouseState.HOVER;
            btnLogin.Name = "btnLogin";
            btnLogin.NoAccentTextColor = Color.Empty;
            btnLogin.Size = new Size(359, 87);
            btnLogin.TabIndex = 8;
            btnLogin.Text = "Login";
            btnLogin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnLogin.UseAccentColor = false;
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // StartForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(711, 1000);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(txtKeyInsert);
            Controls.Add(btnLogin);
            Controls.Add(flowLayoutPanel1);
            FormStyle = FormStyles.ActionBar_64;
            Margin = new Padding(4, 5, 4, 5);
            Name = "StartForm";
            Padding = new Padding(3, 88, 4, 5);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Electrician_Dictionary";
            Load += StartForm_Load;
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Label label1;
        private MaterialSkin.Controls.MaterialComboBox cmbPrompt;
        private Panel panel2;
        private Label label2;
        private MaterialSkin.Controls.MaterialRadioButton radioEnglish;
        private MaterialSkin.Controls.MaterialRadioButton radioKorean;
        private Panel panel3;
        private MaterialSkin.Controls.MaterialRadioButton radioTwoForm;
        private MaterialSkin.Controls.MaterialRadioButton radioOneForm;
        private Label label3;
        private MaterialSkin.Controls.MaterialListView listCurrnetFile;
        private FlowLayoutPanel flowLayoutPanel2;
        private Panel panel4;
        private Label label4;
        private MaterialSkin.Controls.MaterialTextBox2 txtKeyInsert;
        private MaterialSkin.Controls.MaterialButton btnLogin;
    }
}