namespace Login_UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelUsername = new Label();
            Lastname = new Label();
            Age = new Label();
            nametextbox = new TextBox();
            agetextbox = new TextBox();
            lastnametextbox = new TextBox();
            checkBox1 = new CheckBox();
            send = new Button();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label1 = new Label();
            label2 = new Label();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            SuspendLayout();
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Location = new Point(124, 32);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(64, 28);
            labelUsername.TabIndex = 0;
            labelUsername.Text = "Username";
            labelUsername.Click += name_click;
            // 
            // Lastname
            // 
            Lastname.AutoSize = true;
         
            Lastname.Location = new Point(124, 94);
            Lastname.Name = "Lastname";
            Lastname.Size = new Size(94, 28);
            Lastname.TabIndex = 1;
            Lastname.Text = "Lastname";
            Lastname.Click += lastname_click;
            // 
            // Age
            // 
            Age.AutoSize = true;
     
            Age.Location = new Point(124, 155);
            Age.Name = "Age";
            Age.Size = new Size(47, 28);
            Age.TabIndex = 2;
            Age.Text = "Password";
            Age.Click += age_click;
            // 
            // nametextbox
            // 
           
            nametextbox.Location = new Point(270, 32);
            nametextbox.Name = "nametextbox";
            nametextbox.PlaceholderText = "Username...";
            nametextbox.Size = new Size(241, 34);
            nametextbox.TabIndex = 3;
            nametextbox.TextChanged += nametextbox_TextChanged;
            // 
            // agetextbox
            // 
           
            agetextbox.Location = new Point(270, 155);
            agetextbox.Name = "agetextbox";
            agetextbox.PlaceholderText = "Password...";
            agetextbox.Size = new Size(241, 34);
            agetextbox.TabIndex = 5;
            agetextbox.UseSystemPasswordChar = true;
            agetextbox.TextChanged += agetextbox_TextChanged;
            // 
            // lastnametextbox
            // 
           
            lastnametextbox.Location = new Point(270, 94);
            lastnametextbox.Name = "lastnametextbox";
            lastnametextbox.PlaceholderText = "Your lastname...";
            lastnametextbox.Size = new Size(241, 34);
            lastnametextbox.TabIndex = 6;
            lastnametextbox.TextChanged += lastnametextbox_TextChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;

            checkBox1.Location = new Point(270, 342);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(182, 23);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "I agree to Term of service";
            checkBox1.UseVisualStyleBackColor = true;
            // checkbox left without CheckedChanged handler so it does not affect the Login button
            // 
            // send
            // 
          
            send.Location = new Point(270, 371);
            send.Name = "send";
            send.Size = new Size(88, 27);
            send.TabIndex = 8;
            send.Text = "Login";
            send.UseVisualStyleBackColor = true;
            send.Enabled = false;
            send.Click += send_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(270, 252);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(47, 19);
            radioButton1.TabIndex = 9;
            radioButton1.TabStop = true;
            radioButton1.Text = "Thai";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(270, 286);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(41, 19);
            radioButton2.TabIndex = 10;
            radioButton2.TabStop = true;
            radioButton2.Text = "No";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(270, 225);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 11;
            label1.Text = "Thai ?";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(378, 225);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 12;
            label2.Text = "Class";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(378, 286);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(57, 19);
            radioButton3.TabIndex = 14;
            radioButton3.TabStop = true;
            radioButton3.Text = "Upper";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(378, 252);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(57, 19);
            radioButton4.TabIndex = 13;
            radioButton4.TabStop = true;
            radioButton4.Text = "Lower";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(radioButton3);
            Controls.Add(radioButton4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(send);
            Controls.Add(checkBox1);
            Controls.Add(lastnametextbox);
            Controls.Add(agetextbox);
            Controls.Add(nametextbox);
            Controls.Add(Age);
            Controls.Add(Lastname);
            Controls.Add(labelUsername);

            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelUsername;
        private Label Lastname;
        private Label Age;
        private TextBox nametextbox;
        private TextBox textBox2;
        private TextBox agetextbox;
        private TextBox lastnametextbox;
        private CheckBox checkBox1;
        private Button send;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label1;
        private Label label2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
    }
}