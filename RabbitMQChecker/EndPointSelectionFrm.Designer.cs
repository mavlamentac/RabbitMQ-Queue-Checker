namespace RabbitMQChecker
{
    partial class EndPointSelectionFrm
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
            ListViewGroup listViewGroup1 = new ListViewGroup("TDI", HorizontalAlignment.Left);
            ListViewGroup listViewGroup2 = new ListViewGroup("Infront", HorizontalAlignment.Left);
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "amqps://sdp-tdi-dev-acct-rabbit-mq.tdi-sdp-dev.championdata.io", "5671", "uat" }, -1);
            ListViewItem listViewItem2 = new ListViewItem(new string[] { "amqps://rabbitmq.atp.data.tennis", "5671", "production" }, -1);
            ListViewItem listViewItem3 = new ListViewItem(new string[] { "amqps://sdp-infront-dev-acct-rabbit-mq.infront-sdp-dev.championdata.io", "5671", "uat" }, -1);
            ListViewItem listViewItem4 = new ListViewItem(new string[] { "amqps://rabbitmq.bettor.infront.sport", "5671", "sit" }, -1);
            ListViewItem listViewItem5 = new ListViewItem(new string[] { "amqps://rabbitmq.bettor.infront.sport", "5671", "prod" }, -1);
            SelectionList = new ListView();
            EndPointCol = new ColumnHeader();
            Port = new ColumnHeader();
            VirtualHostCol = new ColumnHeader();
            SelectBtn = new Button();
            SuspendLayout();
            // 
            // SelectionList
            // 
            SelectionList.Columns.AddRange(new ColumnHeader[] { EndPointCol, Port, VirtualHostCol });
            SelectionList.FullRowSelect = true;
            SelectionList.GridLines = true;
            listViewGroup1.Header = "TDI";
            listViewGroup1.Name = "lvTDIgroup";
            listViewGroup2.Header = "Infront";
            listViewGroup2.Name = "lvInfrontgroup";
            SelectionList.Groups.AddRange(new ListViewGroup[] { listViewGroup1, listViewGroup2 });
            SelectionList.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listViewItem1.Group = listViewGroup1;
            listViewItem1.StateImageIndex = 0;
            listViewItem2.Group = listViewGroup1;
            listViewItem2.StateImageIndex = 0;
            listViewItem3.Group = listViewGroup2;
            listViewItem3.StateImageIndex = 0;
            listViewItem4.Group = listViewGroup2;
            listViewItem4.StateImageIndex = 0;
            listViewItem5.Group = listViewGroup2;
            listViewItem5.StateImageIndex = 0;
            SelectionList.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3, listViewItem4, listViewItem5 });
            SelectionList.Location = new Point(12, 12);
            SelectionList.MultiSelect = false;
            SelectionList.Name = "SelectionList";
            SelectionList.Size = new Size(587, 214);
            SelectionList.TabIndex = 0;
            SelectionList.UseCompatibleStateImageBehavior = false;
            SelectionList.View = View.Details;
            SelectionList.MouseDoubleClick += SelectionList_MouseDoubleClick;
            // 
            // EndPointCol
            // 
            EndPointCol.Text = "End Point";
            EndPointCol.Width = 450;
            // 
            // Port
            // 
            Port.Text = "Port";
            Port.Width = 50;
            // 
            // VirtualHostCol
            // 
            VirtualHostCol.Text = "Virtual Host";
            VirtualHostCol.Width = 80;
            // 
            // SelectBtn
            // 
            SelectBtn.DialogResult = DialogResult.OK;
            SelectBtn.Location = new Point(501, 232);
            SelectBtn.Name = "SelectBtn";
            SelectBtn.Size = new Size(98, 32);
            SelectBtn.TabIndex = 1;
            SelectBtn.Text = "Select";
            SelectBtn.UseVisualStyleBackColor = true;
            SelectBtn.Click += SelectBtn_Click;
            // 
            // EndPointSelectionFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(611, 268);
            Controls.Add(SelectBtn);
            Controls.Add(SelectionList);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "EndPointSelectionFrm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Please select";
            ResumeLayout(false);
        }

        #endregion

        private ListView SelectionList;
        private ColumnHeader VirtualHostCol;
        private ColumnHeader EndPointCol;
        private ColumnHeader Port;
        private Button SelectBtn;
    }
}