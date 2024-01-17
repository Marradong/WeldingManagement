namespace WeldingManagement
{
	partial class WebApplication
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

		#region Wisej Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.flipBoard1 = new LinkedList.FlipBoard();
            this.SuspendLayout();
            // 
            // flipBoard1
            // 
            this.flipBoard1.Dock = Wisej.Web.DockStyle.Fill;
            this.flipBoard1.Name = "flipBoard1";
            this.flipBoard1.Size = new System.Drawing.Size(1274, 717);
            this.flipBoard1.TabIndex = 0;
            // 
            // WebApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.Controls.Add(this.flipBoard1);
            this.Name = "WebApplication";
            this.Size = new System.Drawing.Size(1274, 717);
            this.Text = "Form1";
            this.ResumeLayout(false);

		}

        #endregion

        private LinkedList.FlipBoard flipBoard1;
    }
}

