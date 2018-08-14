//created by rampage_terranius

/* 
	This program is free software: you can redistribute it and/or modify

	it under the terms of the GNU General Public License as published by

	the Free Software Foundation, either version 3 of the License, or
	(at your option) any later version.

	This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of

	MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.See the

	GNU General Public License for more details.

	You should have received a copy of the GNU General Public License
	along with this program.If not, see<https://www.gnu.org/licenses/>.
*/

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
		private LinkedList<string> outputData = new LinkedList<string>();

		//how many lines will be allowed into the output box
		private const int MAX_OUTPUT_LENGTH = 1000;

		//runs the command line
		private void RunCMD()
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

			//prepare output
			process.OutputDataReceived += processDataReceived;
			process.ErrorDataReceived += processDataReceived;

			//make sure the outputdata list is clear BEFORE we grab all the output from the command line
			outputData.Clear();

			//start the command line and begin outputting
			process.Start();
			process.BeginErrorReadLine();
			process.BeginOutputReadLine();

			//give the command line our arguments
			process.StandardInput.WriteLine(tboxCMD.Text);
			process.StandardInput.WriteLine("exit");

			//wait for command line to exit
			process.WaitForExit();

			//wait for a little bit as the command line may have not finished up yet
			System.Threading.Thread.Sleep(1000);

			//clear up the unneeded lines from the output
			for (int i = 3; i < outputData.Count - 3; i++)
				output.AddLast(outputData.ElementAt(i));

			tboxOutput.Text = "";

			//output the text from the command line
			for (int i = output.Count-1; i >= 0; i--)
				tboxOutput.AppendText(output.ElementAt(i) + "\r\n");

			//makes sure we are always looking at the top most text after a command is run
			tboxOutput.SelectionStart = 0;
			tboxOutput.SelectionLength = 1;
			tboxOutput.ScrollToCaret();
		}

		//on click of run CMD button
		private void btnRunCMD_Click(object sender, EventArgs e)
		{
			RunCMD();
		}

		//event handler for output from command line
		private void processDataReceived(object sender, DataReceivedEventArgs e)
		{
			Process process = sender as Process;

			if (process != null)			
				outputData.AddFirst(e.Data);
		}

		//hnadles when enter button is pressed while in command text box
		private void OnKeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)Keys.Enter)
				RunCMD();
		}
	}
}
