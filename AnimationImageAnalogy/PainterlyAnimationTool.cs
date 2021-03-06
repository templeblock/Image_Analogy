﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimationImageAnalogy
{
    public partial class PainterlyAnimationTool : Form
    {

        public PainterlyAnimationTool()
        {
            InitializeComponent();
            
        }

        private void PainterlyAnimationTool_Load(object sender, EventArgs e)
        {
            Logger.LogAdded += new EventHandler(Logger_LogAdded);
        }

        private void PainterlyAnimationTool_Closed(object sender, EventArgs e)
        {
            Logger.LogAdded -= new EventHandler(Logger_LogAdded);
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void pathA1Browse_Click(object sender, EventArgs e)
        {
            //Choose a folder and display in path dialog box.
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                this.pathA1Text.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void pathA2Browse_Click(object sender, EventArgs e)
        {
            //Choose a folder and display in path dialog box.
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                this.pathA2Text.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void pathB1Browse_Click(object sender, EventArgs e)
        {
            //Choose a folder and display in path dialog box.
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                this.pathB1Text.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void pathB2Browse_Click(object sender, EventArgs e)
        {
            //Choose a folder and display in path dialog box.
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                this.pathB2Text.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        /* Create the frames using the provided paths and parameters. */
        private void createFramesButton_Click(object sender, EventArgs e)
        {
            //TODO: ADD ERROR CHECKING FOR IF THE USER DIDNT CORRECTLY PUT IN INPUT
            CreateFrames cf = new CreateFrames(pathA1Text.Text, pathA2Text.Text, pathB1Text.Text, pathB2Text.Text, 
                Int32.Parse(sizeText.Text), Int32.Parse(iterText.Text), Int32.Parse(randText.Text), 10);
        }

        /* Log stuff in the output box. */
        void Logger_LogAdded(object sender, EventArgs e)
        {
            //MethodInvoker action = delegate{ outputBox.Text += Environment.NewLine + Logger.GetLastLog(); };
            //outputBox.Invoke(action);

            outputBox.Text = Logger.GetLastLog() + Environment.NewLine + outputBox.Text;
            Application.DoEvents();
        }

    }
}
