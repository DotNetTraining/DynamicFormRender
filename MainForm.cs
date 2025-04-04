﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamicFormRender
{
    public partial class MainForm : Form
    {
        public List<FormRenderFrom> formRenderValues = new List<FormRenderFrom>();
        public MainForm()
        {
            InitializeComponent();
            InitializeFormRenderValues();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int renderFrom = formRenderValues.FirstOrDefault(x => x.FormName == "Form1").RenderFrom;
            // Clear any existing controls inside the panel
            panel1.Controls.Clear();

            if (renderFrom == 0)
            {
                // Create a new instance of Form1 and set it to dock inside the panel
                var form1 = new Form1();
                form1.TopLevel = false;
                form1.FormBorderStyle = FormBorderStyle.None;
                form1.ControlBox = false;
                form1.Dock = DockStyle.Fill;
                panel1.Controls.Add(form1);
                form1.Show();
            }
            else
            {
                InitializeCefSharpBrowser();
                chromeBrowser.Load("http://localhost:5173/");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Clear any existing controls inside the panel
            panel1.Controls.Clear();

            // Create a new instance of Form2 and set it to dock inside the panel
            var form2 = new Form2();
            form2.TopLevel = false;
            form2.FormBorderStyle = FormBorderStyle.None;
            form2.ControlBox = false;
            form2.Dock = DockStyle.Fill;
            panel1.Controls.Add(form2);
            form2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int renderFrom = formRenderValues.FirstOrDefault(x => x.FormName == "Form3").RenderFrom;
            // Clear any existing controls inside the panel
            panel1.Controls.Clear();
            if (renderFrom == 0)
            {
                // Create a new instance of Form2 and set it to dock inside the panel
                var form3 = new Form3();
                form3.TopLevel = false;
                form3.Dock = DockStyle.Fill;
                form3.FormBorderStyle = FormBorderStyle.None;
                form3.ControlBox = false;
                panel1.Controls.Add(form3);
                form3.Show();
            }
            else
            {
                InitializeCefSharpBrowser();
                chromeBrowser.Load("http://localhost:5173/");
            }
        }
    }
}
