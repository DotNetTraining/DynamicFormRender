using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Windows.Forms;
using CefSharp.WinForms;

namespace DynamicFormRender
{
    public class FormRenderFrom
    {
        public string FormName { get; set; }
        public int RenderFrom { get; set; }
    }
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public List<FormRenderFrom> formRenderValues = new List<FormRenderFrom>();

        private ChromiumWebBrowser chromeBrowser;

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

        private void InitializeCefSharpBrowser()
        {
            chromeBrowser = new ChromiumWebBrowser("http://localhost:5173/")
            {
                Dock = DockStyle.Fill,
            };

            panel1.Controls.Add(chromeBrowser);
        }

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(6, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(907, 337);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(222, 362);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(435, 362);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 31);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(666, 362);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 31);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(918, 426);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            var form1 = new Form1();
            form1.TopLevel = false;
            form1.Dock = DockStyle.Fill;
            panel1.Controls.Add(form1);
            form1.Show();

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
                panel1.Controls.Add(form3);
                form3.Show();
            }
            else
            {
                InitializeCefSharpBrowser();
                chromeBrowser.Load("http://localhost:5173/");
            }
        }
        #endregion

        private Panel panel1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}