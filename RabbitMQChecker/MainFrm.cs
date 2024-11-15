﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;

namespace RabbitMQChecker
{
    public partial class MainFrm : Form
    {
        public IConnection? _connection;
        public IModel? _channel;
        int PrevLine = 0;
        Boolean IsConsuming;
        public MainFrm()
        {
            InitializeComponent();
            Assembly assembly = Assembly.GetCallingAssembly();
            string? strVersion = assembly.GetName()?.Version?.ToString();
            Text = "RabbitMQ Queue Checker - v" + strVersion;
        }

        public void StartConsumer()
        {
            IsConsuming = false;
            try
            {
                var uri = new Uri(EndPointTxt.Text);
                var factory = new ConnectionFactory
                {
                    HostName = uri.Host,
                    Port = int.Parse(PortTxt.Text),
                    UserName = UsernameTxt.Text,
                    Password = PasswordTxt.Text,
                    VirtualHost = VirtualHostTxt.Text,
                    Ssl = new SslOption
                    {
                        Enabled = true,
                        ServerName = uri.Host,
                    },
                };
                _connection = factory.CreateConnection();
                _channel = _connection.CreateModel();
                _channel.BasicQos(prefetchSize: 0, prefetchCount: 5, global: false);
                var consumer = new EventingBasicConsumer(_channel);
                consumer.Received += (model, ea) =>
                {
                    IsConsuming = true;
                    var body = ea.Body.ToArray();
                    var message = Encoding.UTF8.GetString(body);

                    Invoke(new Action(() =>
                    {
                        LogMessages(message + Environment.NewLine);
                    }));

                };

                // Start consuming messages from the queue
                _channel.BasicConsume(QueueTxt.Text,
                                     false,
                                     consumer);

                LogMessages("Consumer started. Waiting for messages..." + Environment.NewLine);
            }
            catch (Exception ex)
            {
                LogMessages($"Error: {ex.Message}");
            }

        }

        public void LogMessages(string msg)
        {
            LogsTxt.AppendText(msg);
            LogsTxt.SelectionStart = LogsTxt.TextLength;
            LogsTxt.ScrollToCaret();
        }

        public void CloseConnection()
        {
            if (_channel != null)
                _channel.Close();

            if (_connection != null)
                _connection.Close();
        }

        public bool FieldsValidation()
        {
            bool IsEmpty = false;

            if (string.IsNullOrEmpty(EndPointTxt.Text))
            {
                IsEmpty = true;
                EndPointTxt.Focus();
                MessageBox.Show("Error: End point cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(PortTxt.Text))
            {
                IsEmpty = true;
                PortTxt.Focus();
                MessageBox.Show("Error: Port cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(UsernameTxt.Text))
            {
                IsEmpty = true;
                UsernameTxt.Focus();
                MessageBox.Show("Error: Username cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(PasswordTxt.Text))
            {
                IsEmpty = true;
                PasswordTxt.Focus();
                MessageBox.Show("Error: Password cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(VirtualHostTxt.Text))
            {
                IsEmpty = true;
                VirtualHostTxt.Focus();
                MessageBox.Show("Error: Virtual host cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(QueueTxt.Text))
            {
                IsEmpty = true;
                QueueTxt.Focus();
                MessageBox.Show("Error: Queue cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return IsEmpty;
        }

        //-------------- Events -------------------------------------------
        private void StopBtn_Click(object sender, EventArgs e)
        {
       
            //Close the connection and channel
            CloseConnection();
            //ConsumingMessageTimer.Enabled = true;
            StartBtn.Enabled = true;
            StopBtn.Enabled = false;
            ClearBtn.Enabled = true;
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            LogsTxt.Clear();
            if (FieldsValidation() != true)
            {
                StartBtn.Enabled = false;
                StopBtn.Enabled = true;
                ClearBtn.Enabled = false;
                StopBtn.Focus();
                EmptyMessagesTimer.Enabled = true;
     
                StartConsumer();
            }
        }

        private void ConsumingMessageTimer_Tick(object sender, EventArgs e)
        {
            int CurrLine;
           
            CurrLine = LogsTxt.Lines.Count();
            if (CurrLine == PrevLine)
            {
                ConsumingMessageTimer.Enabled = false;
                StartBtn.Enabled = true;
                StopBtn.Enabled = false;
                ClearBtn.Enabled = true;
                LogMessages(Environment.NewLine + "Message consumption has finished. Please check the processed data or logs for details.");
            }
            else
            {
                PrevLine = CurrLine;
            }
            
        }

        private void EmptyMessagesTimer_Tick(object sender, EventArgs e)
        {
            if (IsConsuming == false)
            {
                EmptyMessagesTimer.Enabled = false;
                LogMessages("No available messages to process");
                StartBtn.Enabled = true;
                StopBtn.Enabled = false;
                ClearBtn.Enabled = true;
                CloseConnection();
            }
            else
            {
                EmptyMessagesTimer.Enabled = false;
                ConsumingMessageTimer.Enabled = true;
            }
        }
        

        private void SelectionBtn_Click(object sender, EventArgs e)
        {
            EndPointSelectionFrm modalForm = new EndPointSelectionFrm();
            DialogResult result = modalForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                EndPointTxt.Text = modalForm.SelectedEndPoint;
                PortTxt.Text = modalForm.SelectedPort;
                VirtualHostTxt.Text = modalForm.SelectedVirtualHost;
                UsernameTxt.Focus();
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            EndPointTxt.Clear();
            PortTxt.Clear();
            VirtualHostTxt.Clear();
            QueueTxt.Clear();
            VirtualHostTxt.Clear();
            LogsTxt.Clear();
            UsernameTxt.Clear();
            PasswordTxt.Clear();
        }
    }
}
