using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Principal;
using System.Diagnostics;

namespace Run_CMD
{
	public partial class frmMain : Form
	{
		public frmMain()
		{
			InitializeComponent();

			//checking if the user is an admin and warning them if they are not
			using (WindowsIdentity identity = WindowsIdentity.GetCurrent())
			{
				WindowsPrincipal principal = new WindowsPrincipal(identity);
				if (!principal.IsInRole(WindowsBuiltInRole.Administrator))
					MessageBox.Show("Non administrator user detected.\nSome commands may not work.", "Warning", MessageBoxButtons.OK);
			}
		}

		private LinkedList<string> output = new LinkedList<string>();

		private const int MAX_OUTPUT_LENGTH = 25;

		//on click of run CMD button
		private void btnRunCMD_Click(object sender, EventArgs e)
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo()
			{
				FileName = "CMD.exe",
				UseShellExecute = false,
				RedirectStandardOutput = true,
				RedirectStandardError = true,
				RedirectStandardInput = true,
				CreateNoWindow = true
			};	
			
			process.OutputDataReceived += processDataReceived;
			process.ErrorDataReceived += processDataReceived;

			process.Start();
			process.BeginErrorReadLine();
			process.BeginOutputReadLine();

			process.StandardInput.WriteLine(tboxCMD.Text);
			process.StandardInput.WriteLine("exit");

			process.WaitForExit();

			//wait for a little bit as the command line may have nto finished up yet
			System.Threading.Thread.Sleep(1000);

			tboxOutput.Text = "";

			//output the text from the command line
			foreach (string s in output)
				tboxOutput.AppendText(s + "\r\n");
		}

		//event handler for output from command line
		private void processDataReceived(object sender, DataReceivedEventArgs e)
		{
			Process process = sender as Process;

			if (process != null)
			{
				output.AddLast(e.Data);

				if (output.Count > MAX_OUTPUT_LENGTH)
					output.RemoveFirst();
			}				
		}
	}
}
