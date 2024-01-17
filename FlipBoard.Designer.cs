
namespace LinkedList
{
    partial class FlipBoard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Boards = new Wisej.Web.TabControl();
            this.tabMDRList = new Wisej.Web.TabPage();
            this.tableLayoutPanel1 = new Wisej.Web.TableLayoutPanel();
            this.tableLayoutPanel3 = new Wisej.Web.TableLayoutPanel();
            this.tableLayoutPanel4 = new Wisej.Web.TableLayoutPanel();
            this.button7 = new Wisej.Web.Button();
            this.button1 = new Wisej.Web.Button();
            this.btnWelderQualification = new Wisej.Web.Button();
            this.button3 = new Wisej.Web.Button();
            this.button4 = new Wisej.Web.Button();
            this.button5 = new Wisej.Web.Button();
            this.button6 = new Wisej.Web.Button();
            this.lvHome = new Wisej.Web.ListView();
            this.tableLayoutPanel2 = new Wisej.Web.TableLayoutPanel();
            this.lblHomeNote = new Wisej.Web.Label();
            this.lblHomeTitle = new Wisej.Web.Label();
            this.tabPopup = new Wisej.Web.TabPage();
            this.tableLayoutPanel10 = new Wisej.Web.TableLayoutPanel();
            this.tableLayoutPanel11 = new Wisej.Web.TableLayoutPanel();
            this.lblPopup = new Wisej.Web.Label();
            this.tableLayoutPanel12 = new Wisej.Web.TableLayoutPanel();
            this.btnNo = new Wisej.Web.Button();
            this.btnYes = new Wisej.Web.Button();
            this.tabDatasheet = new Wisej.Web.TabPage();
            this.Boards.SuspendLayout();
            this.tabMDRList.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabPopup.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            this.tableLayoutPanel12.SuspendLayout();
            this.SuspendLayout();
            // 
            // Boards
            // 
            this.Boards.Alignment = Wisej.Web.TabAlignment.Top;
            this.Boards.BorderStyle = Wisej.Web.BorderStyle.None;
            this.Boards.Controls.Add(this.tabMDRList);
            this.Boards.Controls.Add(this.tabPopup);
            this.Boards.Controls.Add(this.tabDatasheet);
            this.Boards.Display = Wisej.Web.Display.Label;
            this.Boards.Dock = Wisej.Web.DockStyle.Fill;
            this.Boards.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Boards.Location = new System.Drawing.Point(0, 0);
            this.Boards.Name = "Boards";
            this.Boards.Orientation = Wisej.Web.Orientation.Horizontal;
            this.Boards.PageInsets = new Wisej.Web.Padding(0, 35, 0, 0);
            this.Boards.SelectedIndex = 0;
            this.Boards.Size = new System.Drawing.Size(1212, 650);
            this.Boards.TabIndex = 1;
            this.Boards.TabStop = false;
            this.Boards.Selecting += new Wisej.Web.TabControlCancelEventHandler(this.Boards_Selecting);
            // 
            // tabMDRList
            // 
            this.tabMDRList.Controls.Add(this.tableLayoutPanel1);
            this.tabMDRList.Location = new System.Drawing.Point(0, 35);
            this.tabMDRList.Name = "tabMDRList";
            this.tabMDRList.Size = new System.Drawing.Size(1212, 615);
            this.tabMDRList.Text = "Home";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 2.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 95F));
            this.tableLayoutPanel1.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 2.5F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Dock = Wisej.Web.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 2.5F));
            this.tableLayoutPanel1.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 2.5F));
            this.tableLayoutPanel1.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 72.5F));
            this.tableLayoutPanel1.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 2.5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1212, 615);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 85F));
            this.tableLayoutPanel3.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 15F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.lvHome, 0, 0);
            this.tableLayoutPanel3.Dock = Wisej.Web.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(33, 156);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1145, 439);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.button7, 0, 6);
            this.tableLayoutPanel4.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnWelderQualification, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.button3, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.button4, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.button5, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.button6, 0, 5);
            this.tableLayoutPanel4.Dock = Wisej.Web.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(976, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 7;
            this.tableLayoutPanel4.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(166, 433);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // button7
            // 
            this.button7.Dock = Wisej.Web.DockStyle.Fill;
            this.button7.Location = new System.Drawing.Point(3, 369);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(160, 61);
            this.button7.TabIndex = 7;
            this.button7.Text = "button7";
            // 
            // button1
            // 
            this.button1.Dock = Wisej.Web.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 55);
            this.button1.TabIndex = 1;
            this.button1.Text = "Request Welding\r\non Job";
            // 
            // btnWelderQualification
            // 
            this.btnWelderQualification.Dock = Wisej.Web.DockStyle.Fill;
            this.btnWelderQualification.Location = new System.Drawing.Point(3, 64);
            this.btnWelderQualification.Name = "btnWelderQualification";
            this.btnWelderQualification.Size = new System.Drawing.Size(160, 55);
            this.btnWelderQualification.TabIndex = 2;
            this.btnWelderQualification.Text = "Complete Welder Qualification";
            this.btnWelderQualification.Click += new System.EventHandler(this.btnWelderQualification_Click);
            // 
            // button3
            // 
            this.button3.Dock = Wisej.Web.DockStyle.Fill;
            this.button3.Location = new System.Drawing.Point(3, 125);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(160, 55);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            // 
            // button4
            // 
            this.button4.Dock = Wisej.Web.DockStyle.Fill;
            this.button4.Location = new System.Drawing.Point(3, 186);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(160, 55);
            this.button4.TabIndex = 4;
            this.button4.Text = "button4";
            // 
            // button5
            // 
            this.button5.Dock = Wisej.Web.DockStyle.Fill;
            this.button5.Location = new System.Drawing.Point(3, 247);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(160, 55);
            this.button5.TabIndex = 5;
            this.button5.Text = "button5";
            // 
            // button6
            // 
            this.button6.Dock = Wisej.Web.DockStyle.Fill;
            this.button6.Location = new System.Drawing.Point(3, 308);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(160, 55);
            this.button6.TabIndex = 6;
            this.button6.Text = "button6";
            // 
            // lvHome
            // 
            this.lvHome.Dock = Wisej.Web.DockStyle.Fill;
            this.lvHome.Location = new System.Drawing.Point(3, 3);
            this.lvHome.Name = "lvHome";
            this.lvHome.Size = new System.Drawing.Size(967, 433);
            this.lvHome.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.lblHomeNote, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblHomeTitle, 0, 0);
            this.tableLayoutPanel2.Dock = Wisej.Web.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(33, 18);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 65F));
            this.tableLayoutPanel2.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 35F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1145, 117);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lblHomeNote
            // 
            this.lblHomeNote.AutoSize = true;
            this.lblHomeNote.BackColor = System.Drawing.Color.FromName("@focusFrame");
            this.lblHomeNote.BorderStyle = Wisej.Web.BorderStyle.Solid;
            this.lblHomeNote.Dock = Wisej.Web.DockStyle.Fill;
            this.lblHomeNote.Location = new System.Drawing.Point(3, 79);
            this.lblHomeNote.Name = "lblHomeNote";
            this.lblHomeNote.Size = new System.Drawing.Size(1139, 35);
            this.lblHomeNote.TabIndex = 1;
            this.lblHomeNote.Text = "Note";
            this.lblHomeNote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHomeTitle
            // 
            this.lblHomeTitle.AutoSize = true;
            this.lblHomeTitle.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.lblHomeTitle.BorderStyle = Wisej.Web.BorderStyle.Solid;
            this.lblHomeTitle.Dock = Wisej.Web.DockStyle.Fill;
            this.lblHomeTitle.Location = new System.Drawing.Point(3, 3);
            this.lblHomeTitle.Name = "lblHomeTitle";
            this.lblHomeTitle.Size = new System.Drawing.Size(1139, 70);
            this.lblHomeTitle.TabIndex = 0;
            this.lblHomeTitle.Text = "Title";
            this.lblHomeTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPopup
            // 
            this.tabPopup.Controls.Add(this.tableLayoutPanel10);
            this.tabPopup.Location = new System.Drawing.Point(0, 35);
            this.tabPopup.Name = "tabPopup";
            this.tabPopup.Size = new System.Drawing.Size(1212, 615);
            this.tabPopup.Text = "Popup";
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 5;
            this.tableLayoutPanel10.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Absolute, 20F));
            this.tableLayoutPanel10.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 50F));
            this.tableLayoutPanel10.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Absolute, 250F));
            this.tableLayoutPanel10.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 50F));
            this.tableLayoutPanel10.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Absolute, 20F));
            this.tableLayoutPanel10.Controls.Add(this.tableLayoutPanel11, 2, 2);
            this.tableLayoutPanel10.Dock = Wisej.Web.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 5;
            this.tableLayoutPanel10.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 20F));
            this.tableLayoutPanel10.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 40F));
            this.tableLayoutPanel10.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 160F));
            this.tableLayoutPanel10.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 60F));
            this.tableLayoutPanel10.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 20F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(1212, 615);
            this.tableLayoutPanel10.TabIndex = 0;
            this.tableLayoutPanel10.TabStop = true;
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.BorderStyle = Wisej.Web.BorderStyle.Solid;
            this.tableLayoutPanel11.ColumnCount = 1;
            this.tableLayoutPanel11.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 50F));
            this.tableLayoutPanel11.Controls.Add(this.lblPopup, 0, 0);
            this.tableLayoutPanel11.Controls.Add(this.tableLayoutPanel12, 0, 1);
            this.tableLayoutPanel11.Dock = Wisej.Web.DockStyle.Fill;
            this.tableLayoutPanel11.Location = new System.Drawing.Point(484, 189);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 2;
            this.tableLayoutPanel11.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 70F));
            this.tableLayoutPanel11.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 30F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(244, 154);
            this.tableLayoutPanel11.TabIndex = 0;
            this.tableLayoutPanel11.TabStop = true;
            // 
            // lblPopup
            // 
            this.lblPopup.AutoSize = true;
            this.lblPopup.Dock = Wisej.Web.DockStyle.Fill;
            this.lblPopup.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPopup.Location = new System.Drawing.Point(3, 3);
            this.lblPopup.Name = "lblPopup";
            this.lblPopup.Size = new System.Drawing.Size(236, 100);
            this.lblPopup.TabIndex = 1;
            this.lblPopup.Text = "Do You Wish To Delete This Item?";
            this.lblPopup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel12
            // 
            this.tableLayoutPanel12.ColumnCount = 3;
            this.tableLayoutPanel12.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Absolute, 70F));
            this.tableLayoutPanel12.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 50F));
            this.tableLayoutPanel12.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Absolute, 70F));
            this.tableLayoutPanel12.Controls.Add(this.btnNo, 2, 0);
            this.tableLayoutPanel12.Controls.Add(this.btnYes, 0, 0);
            this.tableLayoutPanel12.Dock = Wisej.Web.DockStyle.Fill;
            this.tableLayoutPanel12.Location = new System.Drawing.Point(3, 109);
            this.tableLayoutPanel12.Name = "tableLayoutPanel12";
            this.tableLayoutPanel12.RowCount = 1;
            this.tableLayoutPanel12.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 50F));
            this.tableLayoutPanel12.Size = new System.Drawing.Size(236, 40);
            this.tableLayoutPanel12.TabIndex = 0;
            this.tableLayoutPanel12.TabStop = true;
            // 
            // btnNo
            // 
            this.btnNo.Dock = Wisej.Web.DockStyle.Fill;
            this.btnNo.Location = new System.Drawing.Point(169, 3);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(64, 34);
            this.btnNo.TabIndex = 1;
            this.btnNo.Text = "No";
            // 
            // btnYes
            // 
            this.btnYes.Dock = Wisej.Web.DockStyle.Fill;
            this.btnYes.Location = new System.Drawing.Point(3, 3);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(64, 34);
            this.btnYes.TabIndex = 0;
            this.btnYes.Text = "Yes";
            // 
            // tabDatasheet
            // 
            this.tabDatasheet.Location = new System.Drawing.Point(0, 35);
            this.tabDatasheet.Name = "tabDatasheet";
            this.tabDatasheet.Size = new System.Drawing.Size(1212, 615);
            this.tabDatasheet.Text = "Datasheet";
            // 
            // FlipBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Boards);
            this.Name = "FlipBoard";
            this.Size = new System.Drawing.Size(1212, 650);
            this.Boards.ResumeLayout(false);
            this.tabMDRList.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tabPopup.ResumeLayout(false);
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel11.ResumeLayout(false);
            this.tableLayoutPanel11.PerformLayout();
            this.tableLayoutPanel12.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private Wisej.Web.TabControl Boards;
        private Wisej.Web.TabPage tabMDRList;
        private Wisej.Web.TabPage tabPopup;
        private Wisej.Web.TableLayoutPanel tableLayoutPanel10;
        private Wisej.Web.TableLayoutPanel tableLayoutPanel11;
        private Wisej.Web.Label lblPopup;
        private Wisej.Web.TableLayoutPanel tableLayoutPanel12;
        private Wisej.Web.Button btnNo;
        private Wisej.Web.Button btnYes;
        private Wisej.Web.TabPage tabDatasheet;
        private Wisej.Web.TableLayoutPanel tableLayoutPanel1;
        private Wisej.Web.TableLayoutPanel tableLayoutPanel3;
        private Wisej.Web.TableLayoutPanel tableLayoutPanel2;
        private Wisej.Web.Label lblHomeTitle;
        private Wisej.Web.ListView lvHome;
        private Wisej.Web.Label lblHomeNote;
        private Wisej.Web.TableLayoutPanel tableLayoutPanel4;
        private Wisej.Web.Button button7;
        private Wisej.Web.Button button1;
        private Wisej.Web.Button btnWelderQualification;
        private Wisej.Web.Button button3;
        private Wisej.Web.Button button4;
        private Wisej.Web.Button button5;
        private Wisej.Web.Button button6;

        #endregion
        // private Wisej.Web.ContextMenuStrip contextMenuStrip1;
    }
}
