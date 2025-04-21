using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Windows.Forms;
using CefSharp.WinForms;
using Newtonsoft.Json;

namespace DynamicFormRender
{
    public class FormRenderFrom
    {
        public string FormName { get; set; }
        public RenderFrom RenderFrom { get; set; }
    }

    public enum RenderFrom
    {
        WindowsForm = 0,
        Cef = 1,
    }

    public enum RenderFormName
    {
        Form1 = 0,
        Form2 = 1,
        Form3 = 2
    }

    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private ChromiumWebBrowser chromeBrowser;
        private MenuStrip menuStrip;
        private ToolStripMenuItem purchaseOrderEntryMenuItem;
        private ToolStripMenuItem smartPoImportMenuItem;
        private ToolStripMenuItem purchaseOrderReportsMenuItem;

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

        private void InitializeFormRenderValues()
        {
            //string jsonFilePath = "C:\\POC\\DynamicFormRender\\FormRenderValues.json";
            string projectRoot = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\.."));
            string jsonFilePath = Path.Combine(projectRoot, "FormRenderValues.json");
            //formRenderValues = ReadFormRenderValuesFromJson(relativePath);
            formRenderValues = ReadFormRenderValuesFromJson(jsonFilePath);
        }

        private void InitializeCefSharpBrowser()
        {
            chromeBrowser = new ChromiumWebBrowser("http://55.55.55.133:8085/")
            {
                Dock = DockStyle.Fill,
            };

            panel1.Controls.Add(chromeBrowser);
        }

        // Method to read and deserialize JSON file into a List<FormRenderFrom>
        public static List<FormRenderFrom> ReadFormRenderValuesFromJson(string filePath)
        {
            string jsonContent = File.ReadAllText(filePath);
            List<FormRenderFrom> formRenderValues = JsonConvert.DeserializeObject<List<FormRenderFrom>>(jsonContent);

            return formRenderValues;
        }

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.purchaseOrderEntryMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smartPoImportMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseOrderReportsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(6, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1497, 494);
            this.panel1.TabIndex = 0;
            // 
            // menuStrip
            // 
            this.menuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.purchaseOrderEntryMenuItem,
            this.smartPoImportMenuItem,
            this.purchaseOrderReportsMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1515, 33);
            this.menuStrip.TabIndex = 4;
            this.menuStrip.Text = "menuStrip";
            // 
            // purchaseOrderEntryMenuItem
            // 
            this.purchaseOrderEntryMenuItem.Name = "purchaseOrderEntryMenuItem";
            this.purchaseOrderEntryMenuItem.Size = new System.Drawing.Size(194, 29);
            this.purchaseOrderEntryMenuItem.Text = "Purchase Order Entry";
            this.purchaseOrderEntryMenuItem.ShortcutKeys = Keys.Control | Keys.D1; // Ctrl+1
            this.purchaseOrderEntryMenuItem.ShowShortcutKeys = true;
            this.purchaseOrderEntryMenuItem.Click += new System.EventHandler(this.purchaseOrderEntryMenuItem_Click);
            // 
            // smartPoImportMenuItem
            // 
            this.smartPoImportMenuItem.Name = "smartPoImportMenuItem";
            this.smartPoImportMenuItem.Size = new System.Drawing.Size(159, 29);
            this.smartPoImportMenuItem.Text = "SmartPO Import";
            this.smartPoImportMenuItem.ShortcutKeys = Keys.Control | Keys.D2; // Ctrl+2
            this.smartPoImportMenuItem.ShowShortcutKeys = true;
            this.smartPoImportMenuItem.Click += new System.EventHandler(this.smartPoImportMenuItem_Click);
            // 
            // purchaseOrderReportsMenuItem
            // 
            this.purchaseOrderReportsMenuItem.Name = "purchaseOrderReportsMenuItem";
            this.purchaseOrderReportsMenuItem.Size = new System.Drawing.Size(215, 29);
            this.purchaseOrderReportsMenuItem.Text = "Purchase Order Reports";
            this.purchaseOrderReportsMenuItem.ShortcutKeys = Keys.Control | Keys.D3; // Ctrl+3
            this.purchaseOrderReportsMenuItem.ShowShortcutKeys = true;
            this.purchaseOrderReportsMenuItem.Click += new System.EventHandler(this.purchaseOrderReportsMenuItem_Click);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(1515, 543);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
    }
}
