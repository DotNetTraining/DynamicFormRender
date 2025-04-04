using System;
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
    }
}
