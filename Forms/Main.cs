using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

public partial class Main : Form
{
    public Main()
    {
        InitializeComponent();

        btnConnect.Click += new EventHandler(btnConnect_Click);
        btnStartServer.Click += new EventHandler(btnStartServer_Click);
        btnStopServer.Click += new EventHandler(btnStopServer_Click);
        btnSendFile.Click += new EventHandler(btnSendFile_Click);
        btnPauseTransfer.Click += new EventHandler(btnPauseTransfer_Click);
        btnStopTransfer.Click += new EventHandler(btnStopTransfer_Click);
        btnOpenDir.Click += new EventHandler(btnOpenDir_Click);
        btnClearComplete.Click += new EventHandler(btnClearComplete_Click);

        btnStopServer.Enabled = false;
    }

    private void btnConnect_Click(object sender, EventArgs e)
    {
		
    }

    private void btnStartServer_Click(object sender, EventArgs e)
    {
		
    }

    private void btnStopServer_Click(object sender, EventArgs e)
    {
		
    }

    private void btnClearComplete_Click(object sender, EventArgs e)
    {
		
    }

    private void btnOpenDir_Click(object sender, EventArgs e)
    {
		
    }

    private void btnSendFile_Click(object sender, EventArgs e)
    {
		
    }

    private void btnPauseTransfer_Click(object sender, EventArgs e)
    {
		
    }

    private void btnStopTransfer_Click(object sender, EventArgs e)
    {
		
    }
}