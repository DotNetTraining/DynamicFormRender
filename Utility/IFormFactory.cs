using System.Windows.Forms;

namespace DynamicFormRender.Utility
{
    public interface IFormFactory
    {
        Form GetFormInstance(RenderFrom renderFromType);
    }
}
