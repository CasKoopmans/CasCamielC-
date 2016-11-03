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
        private List<string> searching = new List<string>();

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

            //Refreshing the searching players box
            try { searchingBox.Items.Clear(); }
            catch (Exception exception) { Console.WriteLine(exception.StackTrace); }

            searching = StartScreen.ServerConnection.getSearchingClients();
            searching.Sort();
            for (int i = 0; i < searching.Count; i++)
            {
                searchingBox.Items.Add(searching[i]);
            }
        }

        private void formClosing(object sender, FormClosingEventArgs e)
        {
            StartScreen.ServerConnection.disconnect();
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

            //Refreshing the searching players box
            try { searchingBox.Items.Clear(); }
            catch (Exception exception) { Console.WriteLine(exception.StackTrace); }

            searching = StartScreen.ServerConnection.getSearchingClients();
            searching.Sort();
            for (int i = 0; i < searching.Count; i++)
            {
                searchingBox.Items.Add(searching[i]);
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            StartScreen.ServerConnection.findMatch();
        }

        private void searchingBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
