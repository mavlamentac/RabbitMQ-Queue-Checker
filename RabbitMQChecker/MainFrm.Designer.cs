namespace RabbitMQChecker
{
    partial class MainFrm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            EndPointTxt = new TextBox();
            UsernameTxt = new TextBox();
            PasswordTxt = new TextBox();
            VirtualHostTxt = new TextBox();
            QueueTxt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            StartBtn = new Button();
            label6 = new Label();
            PortTxt = new TextBox();
            EmptyMessagesTimer = new System.Windows.Forms.Timer(components);
            LogsTxt = new TextBox();
            timer2 = new System.Windows.Forms.Timer(components);
            ConsumingMessageTimer = new System.Windows.Forms.Timer(components);
            SelectionBtn = new Button();
            ClearBtn = new Button();
            SuspendLayout();
            // 
            // EndPointTxt
            // 
            EndPointTxt.Location = new Point(96, 12);
            EndPointTxt.Name = "EndPointTxt";
            EndPointTxt.Size = new Size(403, 23);
            EndPointTxt.TabIndex = 0;
            // 
            // UsernameTxt
            // 
            UsernameTxt.Location = new Point(96, 70);
            UsernameTxt.Name = "UsernameTxt";
            UsernameTxt.Size = new Size(438, 23);
            UsernameTxt.TabIndex = 3;
            // 
            // PasswordTxt
            // 
            PasswordTxt.Location = new Point(96, 99);
            PasswordTxt.Name = "PasswordTxt";
            PasswordTxt.Size = new Size(438, 23);
            PasswordTxt.TabIndex = 4;
            PasswordTxt.UseSystemPasswordChar = true;
            // 
            // VirtualHostTxt
            // 
            VirtualHostTxt.Location = new Point(96, 41);
            VirtualHostTxt.Name = "VirtualHostTxt";
            VirtualHostTxt.Size = new Size(288, 23);
            VirtualHostTxt.TabIndex = 1;
            // 
            // QueueTxt
            // 
            QueueTxt.Location = new Point(96, 128);
            QueueTxt.Name = "QueueTxt";
            QueueTxt.Size = new Size(438, 23);
            QueueTxt.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 5;
            label1.Text = "End Point:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 73);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 6;
            label2.Text = "Username:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 102);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 7;
            label3.Text = "Password:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 44);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 8;
            label4.Text = "Virtual Host:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 131);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 9;
            label5.Text = "Queue:";
            // 
            // StartBtn
            // 
            StartBtn.Location = new Point(434, 157);
            StartBtn.Name = "StartBtn";
            StartBtn.Size = new Size(100, 32);
            StartBtn.TabIndex = 6;
            StartBtn.Text = "Start Consume";
            StartBtn.UseVisualStyleBackColor = true;
            StartBtn.Click += StartBtn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(398, 44);
            label6.Name = "label6";
            label6.Size = new Size(32, 15);
            label6.TabIndex = 14;
            label6.Text = "Port:";
            // 
            // PortTxt
            // 
            PortTxt.Location = new Point(443, 41);
            PortTxt.Name = "PortTxt";
            PortTxt.Size = new Size(91, 23);
            PortTxt.TabIndex = 2;
            // 
            // EmptyMessagesTimer
            // 
            EmptyMessagesTimer.Interval = 3000;
            EmptyMessagesTimer.Tick += EmptyMessagesTimer_Tick;
            // 
            // LogsTxt
            // 
            LogsTxt.Location = new Point(12, 195);
            LogsTxt.Multiline = true;
            LogsTxt.Name = "LogsTxt";
            LogsTxt.ScrollBars = ScrollBars.Vertical;
            LogsTxt.Size = new Size(522, 243);
            LogsTxt.TabIndex = 11;
            LogsTxt.TabStop = false;
            // 
            // timer2
            // 
            timer2.Interval = 3000;
            // 
            // ConsumingMessageTimer
            // 
            ConsumingMessageTimer.Interval = 2000;
            ConsumingMessageTimer.Tick += ConsumingMessageTimer_Tick;
            // 
            // SelectionBtn
            // 
            SelectionBtn.Location = new Point(505, 12);
            SelectionBtn.Name = "SelectionBtn";
            SelectionBtn.Size = new Size(29, 23);
            SelectionBtn.TabIndex = 16;
            SelectionBtn.TabStop = false;
            SelectionBtn.Text = "...";
            SelectionBtn.UseVisualStyleBackColor = true;
            SelectionBtn.Click += SelectionBtn_Click;
            // 
            // ClearBtn
            // 
            ClearBtn.Location = new Point(328, 157);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(100, 32);
            ClearBtn.TabIndex = 17;
            ClearBtn.Text = "Clear all";
            ClearBtn.UseVisualStyleBackColor = true;
            ClearBtn.Click += ClearBtn_Click;
            // 
            // MainFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(546, 450);
            Controls.Add(ClearBtn);
            Controls.Add(SelectionBtn);
            Controls.Add(label6);
            Controls.Add(PortTxt);
            Controls.Add(LogsTxt);
            Controls.Add(StartBtn);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(QueueTxt);
            Controls.Add(VirtualHostTxt);
            Controls.Add(PasswordTxt);
            Controls.Add(UsernameTxt);
            Controls.Add(EndPointTxt);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MainFrm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RabbitMQ Queue Checker v1.0";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox EndPointTxt;
        private TextBox UsernameTxt;
        private TextBox PasswordTxt;
        private TextBox VirtualHostTxt;
        private TextBox QueueTxt;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button StartBtn;
        private Label label6;
        private TextBox PortTxt;
        private System.Windows.Forms.Timer EmptyMessagesTimer;
        private TextBox LogsTxt;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer ConsumingMessageTimer;
        private Button SelectionBtn;
        private Button ClearBtn;
    }
}