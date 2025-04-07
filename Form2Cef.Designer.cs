using CefSharp.WinForms;
using System.Windows.Forms;

namespace DynamicFormRender
{
    partial class Form2Cef : Form
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1535, 703);
            this.Text = "Form2Cef";

            // Initialize the ChromiumWebBrowser without parameters
            chromeBrowser = new ChromiumWebBrowser("http://localhost:5173/") // This is the URL you want to load
            {
                Dock = DockStyle.Fill, // Make the browser fill the form
            };

            // Add the browser control to the form
            this.Controls.Add(chromeBrowser);

            // Load the specific route/form after the browser is initialized
            chromeBrowser.Load("http://localhost:5173/form2"); // Load the desired route
        }

        #endregion
    }
}