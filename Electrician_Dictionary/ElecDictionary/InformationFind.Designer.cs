namespace Electrician_Dictionary.ElecDictionary
{
    partial class InformationFind
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
            btnRequest = new Button();
            txtQuestion = new TextBox();
            txtAnswer = new TextBox();
            SuspendLayout();
            // 
            // btnRequest
            // 
            btnRequest.Location = new Point(416, 650);
            btnRequest.Margin = new Padding(4, 5, 4, 5);
            btnRequest.Name = "btnRequest";
            btnRequest.Size = new Size(293, 45);
            btnRequest.TabIndex = 5;
            btnRequest.Text = "질문하기";
            btnRequest.UseVisualStyleBackColor = true;
            btnRequest.Click += btnRequest_Click;
            // 
            // txtQuestion
            // 
            txtQuestion.Location = new Point(17, 20);
            txtQuestion.Margin = new Padding(4, 5, 4, 5);
            txtQuestion.Multiline = true;
            txtQuestion.Name = "txtQuestion";
            txtQuestion.Size = new Size(494, 574);
            txtQuestion.TabIndex = 3;
            txtQuestion.WordWrap = false;
            txtQuestion.KeyDown += txtQuestion_KeyDown;
            // 
            // txtAnswer
            // 
            txtAnswer.Location = new Point(630, 20);
            txtAnswer.Margin = new Padding(4, 5, 4, 5);
            txtAnswer.Multiline = true;
            txtAnswer.Name = "txtAnswer";
            txtAnswer.Size = new Size(494, 574);
            txtAnswer.TabIndex = 4;
            // 
            // InformationFind
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(btnRequest);
            Controls.Add(txtQuestion);
            Controls.Add(txtAnswer);
            Margin = new Padding(4, 5, 4, 5);
            Name = "InformationFind";
            Padding = new Padding(4, 107, 4, 5);
            StartPosition = FormStartPosition.CenterScreen;
            Load += InformationFind_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtQuestion;
        private Button btnRequest;
        private TextBox txtAnswer;
    }
}