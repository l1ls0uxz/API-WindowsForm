namespace Client
{
    partial class Load
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
            btnLog = new Button();
            textPass = new TextBox();
            textUser = new TextBox();
            SuspendLayout();
            // 
            // btnLog
            // 
            btnLog.Location = new Point(96, 333);
            btnLog.Name = "btnLog";
            btnLog.Size = new Size(165, 35);
            btnLog.TabIndex = 0;
            btnLog.Text = "Log";
            btnLog.UseVisualStyleBackColor = true;
            // 
            // textPass
            // 
            textPass.Location = new Point(96, 151);
            textPass.Name = "textPass";
            textPass.Size = new Size(165, 23);
            textPass.TabIndex = 1;
            // 
            // textUser
            // 
            textUser.Location = new Point(96, 97);
            textUser.Name = "textUser";
            textUser.Size = new Size(165, 23);
            textUser.TabIndex = 2;
            textUser.TextChanged += textBox2_TextChanged;
            // 
            // Load
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(359, 405);
            Controls.Add(textUser);
            Controls.Add(textPass);
            Controls.Add(btnLog);
            Name = "Load";
            Text = "Load";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLog;
        private TextBox textPass;
        private TextBox textUser;
    }
}