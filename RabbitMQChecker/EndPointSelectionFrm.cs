using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RabbitMQChecker
{
    public partial class EndPointSelectionFrm : Form
    {
        public string SelectedEndPoint { get; set; } = "";
        public string SelectedPort { get; set; } = "";
        public string SelectedVirtualHost { get; set; } = "";
        public EndPointSelectionFrm()
        {
            InitializeComponent();
        }

        private void SelectBtn_Click(object sender, EventArgs e)
        {
            if (SelectionList.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = SelectionList.SelectedItems[0];

                SelectedEndPoint = selectedItem.Text; // Access the second subitem
                SelectedPort = selectedItem.SubItems[1].Text;
                SelectedVirtualHost = selectedItem.SubItems[2].Text;

            }
            this.Close();
        }

        private void SelectionList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            SelectBtn.PerformClick();
        }
    }
}
