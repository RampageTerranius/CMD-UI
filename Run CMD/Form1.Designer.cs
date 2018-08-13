namespace Run_CMD
{
	partial class frmMain
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
			this.lblCommand = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.btnRunCMD = new System.Windows.Forms.Button();
			this.cboxShowCMD = new System.Windows.Forms.CheckBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.lblOutput = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblCommand
			// 
			this.lblCommand.AutoSize = true;
			this.lblCommand.Location = new System.Drawing.Point(12, 9);
			this.lblCommand.Name = "lblCommand";
			this.lblCommand.Size = new System.Drawing.Size(54, 13);
			this.lblCommand.TabIndex = 0;
			this.lblCommand.Text = "Command";
			// 
			// textBox1
			// 
			this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox1.Location = new System.Drawing.Point(12, 25);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(760, 20);
			this.textBox1.TabIndex = 1;
			// 
			// btnRunCMD
			// 
			this.btnRunCMD.Location = new System.Drawing.Point(12, 51);
			this.btnRunCMD.Name = "btnRunCMD";
			this.btnRunCMD.Size = new System.Drawing.Size(75, 23);
			this.btnRunCMD.TabIndex = 2;
			this.btnRunCMD.Text = "Run CMD";
			this.btnRunCMD.UseVisualStyleBackColor = true;
			this.btnRunCMD.Click += new System.EventHandler(this.btnRunCMD_Click);
			// 
			// cboxShowCMD
			// 
			this.cboxShowCMD.AutoSize = true;
			this.cboxShowCMD.Location = new System.Drawing.Point(93, 55);
			this.cboxShowCMD.Name = "cboxShowCMD";
			this.cboxShowCMD.Size = new System.Drawing.Size(80, 17);
			this.cboxShowCMD.TabIndex = 3;
			this.cboxShowCMD.Text = "Show CMD";
			this.cboxShowCMD.UseVisualStyleBackColor = true;
			// 
			// textBox2
			// 
			this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox2.Location = new System.Drawing.Point(12, 93);
			this.textBox2.Multiline = true;
			this.textBox2.Name = "textBox2";
			this.textBox2.ReadOnly = true;
			this.textBox2.Size = new System.Drawing.Size(760, 457);
			this.textBox2.TabIndex = 4;
			// 
			// lblOutput
			// 
			this.lblOutput.AutoSize = true;
			this.lblOutput.Location = new System.Drawing.Point(12, 77);
			this.lblOutput.Name = "lblOutput";
			this.lblOutput.Size = new System.Drawing.Size(39, 13);
			this.lblOutput.TabIndex = 5;
			this.lblOutput.Text = "Output";
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(784, 562);
			this.Controls.Add(this.lblOutput);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.cboxShowCMD);
			this.Controls.Add(this.btnRunCMD);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.lblCommand);
			this.MinimumSize = new System.Drawing.Size(480, 320);
			this.Name = "frmMain";
			this.ShowIcon = false;
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblCommand;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button btnRunCMD;
		private System.Windows.Forms.CheckBox cboxShowCMD;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label lblOutput;
	}
}

