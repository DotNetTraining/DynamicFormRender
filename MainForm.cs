using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DynamicFormRender.Utility;

namespace DynamicFormRender
{
    public partial class MainForm : Form
    {
        public List<FormRenderFrom> formRenderValues = new List<FormRenderFrom>();
        public MainForm()
        {
            InitializeComponent();
            InitializeFormRenderValues();
            RenderForm(RenderFormName.Form1.ToString());
        }
       
        private void purchaseOrderEntryMenuItem_Click(object sender, EventArgs e)
        {
            RenderForm(RenderFormName.Form1.ToString());
        }

        private void smartPoImportMenuItem_Click(object sender, EventArgs e)
        {
            RenderForm(RenderFormName.Form2.ToString());
        }

        private void purchaseOrderReportsMenuItem_Click(object sender, EventArgs e)
        {
            RenderForm(RenderFormName.Form3.ToString());
        }

        private void RenderForm(string formName)
        {
            var renderFrom = formRenderValues.FirstOrDefault(x => x.FormName == formName)?.RenderFrom ?? RenderFrom.WindowsForm;
            panel1.Controls.Clear();
            IFormFactory formFactory = FormFactory.GetFactoryForForm(formName);
            Form form = formFactory.GetFormInstance(renderFrom);
            SetFormProperties(form);
            panel1.Controls.Add(form);
            form.Show();
        }

        private Form SetFormProperties(Form form)
        {
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            form.FormBorderStyle = FormBorderStyle.None;
            form.ControlBox = false;
            return form;
        }
    }
}
