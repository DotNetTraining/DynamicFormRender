using System.Windows.Forms;
using CefSharp.WinForms;

namespace DynamicFormRender
{
    partial class Form3Cef : Form
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
            this.Text = "Form3Cef";

            chromeBrowser = new ChromiumWebBrowser("http://55.55.55.133:8085/")
            {
                Dock = DockStyle.Fill,
            };
            this.Controls.Add(chromeBrowser);
            chromeBrowser.Load("http://55.55.55.133:8085/form3");
        }

        #endregion
    }
}