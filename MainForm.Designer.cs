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

        private void InitializeFormRenderValues()
        {
            // Initialize formRenderValues here
            formRenderValues = new List<FormRenderFrom>()
                {
                    new FormRenderFrom { FormName = "Form1", RenderFrom = 0 },
                    new FormRenderFrom { FormName = "Form2", RenderFrom = 0 },
                    new FormRenderFrom { FormName = "Form3", RenderFrom = 0 }
                };
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
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(6, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(907, 349);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "Purchase Order Entry";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(233, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 31);
            this.button2.TabIndex = 2;
            this.button2.Text = "SmartPO Import";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(401, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(217, 31);
            this.button3.TabIndex = 3;
            this.button3.Text = "Purchase Order Reports";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(918, 426);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.ResumeLayout(false);

            var form1 = new Form1();
            form1.TopLevel = false;
            form1.FormBorderStyle = FormBorderStyle.None;
            form1.ControlBox = false;
            form1.Dock = DockStyle.Fill;
            panel1.Controls.Add(form1);
            form1.Show();
        }
        #endregion

        private Panel panel1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}