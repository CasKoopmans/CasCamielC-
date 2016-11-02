using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stratego.Forms
{
    public partial class Lobby : Form
    {
        private List<string> online = new List<string>();

        public Lobby()
        {
            FormClosing += formClosing;
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            startup();
        }

        private void startup()
        {
            try { onlineBox.Items.Clear(); }
            catch (Exception exception) { Console.WriteLine(exception.StackTrace); }

            online = StartScreen.ServerConnection.getOnlineClients();
            online.Sort();
            for (int i = 0; i < online.Count; i++)
            {
                onlineBox.Items.Add(online[i]);
            }
        }

        private void formClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            //Refreshing the online players box
            try { onlineBox.Items.Clear(); }
            catch (Exception exception) { Console.WriteLine(exception.StackTrace); }

            online = StartScreen.ServerConnection.getOnlineClients();
            online.Sort();
            for (int i = 0; i < online.Count; i++)
            {
                onlineBox.Items.Add(online[i]);
            }
        }
    }
}
