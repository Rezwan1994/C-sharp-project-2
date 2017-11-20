namespace SAMMS
{
    partial class Email
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
            this.backButton = new System.Windows.Forms.Button();
            this.sentButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.recipentText = new System.Windows.Forms.TextBox();
            this.SubjectText = new System.Windows.Forms.TextBox();
            this.MessageBodyText = new System.Windows.Forms.TextBox();
            this.FromText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PassText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Yellow;
            this.backButton.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(74, 449);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(164, 43);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // sentButton
            // 
            this.sentButton.BackColor = System.Drawing.Color.Red;
            this.sentButton.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sentButton.ForeColor = System.Drawing.Color.Black;
            this.sentButton.Location = new System.Drawing.Point(876, 449);
            this.sentButton.Name = "sentButton";
            this.sentButton.Size = new System.Drawing.Size(164, 43);
            this.sentButton.TabIndex = 1;
            this.sentButton.Text = "Sent";
            this.sentButton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(544, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "Email Service";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(154, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "To Recipent";
            // 
            // recipentText
            // 
            this.recipentText.ForeColor = System.Drawing.Color.Gray;
            this.recipentText.Location = new System.Drawing.Point(332, 111);
            this.recipentText.Multiline = true;
            this.recipentText.Name = "recipentText";
            this.recipentText.Size = new System.Drawing.Size(411, 24);
            this.recipentText.TabIndex = 4;
            this.recipentText.Text = "email@domain.com";
            this.recipentText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SubjectText
            // 
            this.SubjectText.Font = new System.Drawing.Font("Lucida Bright", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubjectText.ForeColor = System.Drawing.Color.Gray;
            this.SubjectText.Location = new System.Drawing.Point(154, 157);
            this.SubjectText.Multiline = true;
            this.SubjectText.Name = "SubjectText";
            this.SubjectText.Size = new System.Drawing.Size(589, 42);
            this.SubjectText.TabIndex = 5;
            this.SubjectText.Text = "Subject";
            this.SubjectText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MessageBodyText
            // 
            this.MessageBodyText.Font = new System.Drawing.Font("Lucida Bright", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageBodyText.ForeColor = System.Drawing.Color.Gray;
            this.MessageBodyText.Location = new System.Drawing.Point(154, 223);
            this.MessageBodyText.Multiline = true;
            this.MessageBodyText.Name = "MessageBodyText";
            this.MessageBodyText.Size = new System.Drawing.Size(589, 175);
            this.MessageBodyText.TabIndex = 6;
            this.MessageBodyText.Text = "Message Body";
            this.MessageBodyText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FromText
            // 
            this.FromText.Location = new System.Drawing.Point(765, 111);
            this.FromText.Multiline = true;
            this.FromText.Name = "FromText";
            this.FromText.Size = new System.Drawing.Size(286, 24);
            this.FromText.TabIndex = 7;
            this.FromText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(765, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "From";
            // 
            // PassText
            // 
            this.PassText.Font = new System.Drawing.Font("Lucida Bright", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassText.Location = new System.Drawing.Point(765, 175);
            this.PassText.Multiline = true;
            this.PassText.Name = "PassText";
            this.PassText.PasswordChar = '*';
            this.PassText.Size = new System.Drawing.Size(286, 24);
            this.PassText.TabIndex = 9;
            this.PassText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(765, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Password";
            // 
            // Email
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SAMMS.Properties.Resources.Lamborghini_Logo_032;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1063, 541);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PassText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FromText);
            this.Controls.Add(this.MessageBodyText);
            this.Controls.Add(this.SubjectText);
            this.Controls.Add(this.recipentText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sentButton);
            this.Controls.Add(this.backButton);
            this.Font = new System.Drawing.Font("Lucida Bright", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Email";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Email";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Email_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button sentButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox recipentText;
        private System.Windows.Forms.TextBox SubjectText;
        private System.Windows.Forms.TextBox MessageBodyText;
        private System.Windows.Forms.TextBox FromText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PassText;
        private System.Windows.Forms.Label label4;
    }
}