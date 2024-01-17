using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using Wisej.Web;
using System.Diagnostics;
using System.Reflection;
using System.Web;
using System.IO;


namespace LinkedList
{
    public partial class FlipBoard : UserControl
    {
       

        bool IsDesignMode = (LicenseManager.UsageMode == LicenseUsageMode.Designtime);
        bool checkCancel = true;

        [Category("Board")]
        [Description("Number to display")]
        private void Boards_Selecting(object sender, TabControlCancelEventArgs e)
        {
            e.Cancel = checkCancel;
            checkCancel = true;
        }
        private BoardId showBoard = BoardId.Home;
        public BoardId ShowBoard
        {
            get
            {
                return showBoard;
            }
            set
            {
                showBoard = value;
                checkCancel = false;

                //Change Boards
                Boards.SelectedIndex = (int)showBoard;
                Boards.Refresh();

                //Exectute Board Show Code
                switch (ShowBoard)
                {
                    case BoardId.Home:

                        string LoggedIn = "True";
                        if (LoggedIn == "True")
                        {
                            Boards.SelectedIndex = (int)BoardId.Home;
                            Boards.Refresh();
                        }
                        else
                        {
                            //txtUserName.Text = txtEmpId.Text = txtPassword.Text = "";
                            //if (txtUserName.Text == "")
                            //    txtUserName.Text = Environment.UserName;

                            Boards.SelectedIndex = (int)BoardId.Home;
                        }

                        break;
                    case BoardId.PopUp:
                        break;
                }
            }
        }

        public enum BoardId
        {
            Home = 0,
            PopUp = 1,
            Datasheet = 2
        }

        public FlipBoard()
        {
            InitializeComponent();

            Boards.BorderStyle = Wisej.Web.BorderStyle.None;
            Boards.ItemSize = new Size(1, 1); //Hide Tabs - they are not selectable
            Boards.SizeMode = TabSizeMode.Fixed;

            foreach (TabPage tab in Boards.TabPages)
            {
                tab.Text = "";
                tab.BackColor = Color.White;
            }
        }

        private void btnWelderQualification_Click(object sender, EventArgs e)
        {
            this.ShowBoard = BoardId.Datasheet;
            this.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.ShowBoard = BoardId.Home;
            this.Refresh();
        }
    }
}
