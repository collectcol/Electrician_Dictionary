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
            txtQuestion = new TextBox();
            txtAnswer = new TextBox();
            btnRequest = new Button();
            SuspendLayout();
            // 
            // txtQuestion
            // 
            txtQuestion.Location = new Point(12, 12);
            txtQuestion.Multiline = true;
            txtQuestion.Name = "txtQuestion";
            txtQuestion.Size = new Size(347, 346);
            txtQuestion.TabIndex = 0;
            txtQuestion.KeyDown += txtQuestion_KeyDown;
            // 
            // txtAnswer
            // 
            txtAnswer.Location = new Point(426, 12);
            txtAnswer.Multiline = true;
            txtAnswer.Name = "txtAnswer";
            txtAnswer.Size = new Size(347, 346);
            txtAnswer.TabIndex = 1;
            // 
            // btnRequest
            // 
            btnRequest.Location = new Point(292, 393);
            btnRequest.Name = "btnRequest";
            btnRequest.Size = new Size(205, 27);
            btnRequest.TabIndex = 2;
            btnRequest.Text = "질문하기";
            btnRequest.UseVisualStyleBackColor = true;
            btnRequest.Click += btnRequest_Click;
            // 
            // InformationFind
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRequest);
            Controls.Add(txtAnswer);
            Controls.Add(txtQuestion);
            Name = "InformationFind";
            Text = "InformationFind";
            Load += InformationFind_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtQuestion;
        private TextBox txtAnswer;
        private Button btnRequest;
    }
}