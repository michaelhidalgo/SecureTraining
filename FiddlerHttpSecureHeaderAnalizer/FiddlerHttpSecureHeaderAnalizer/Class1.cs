
using System;
using System.Windows.Forms;
using Fiddler;
namespace FiddlerHttpSecureHeaderAnalizer
{
    public class CustomInspector : Inspector2,IResponseInspector2
    {
        public override void AddToTab(TabPage o)
        {
            var button = new Button();
            button.Text = "Click here";
            o.Controls.Add(button);
        }

        public override int GetOrder()
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public byte[] body { get; set; }
        public bool bDirty { get; private set; }
        public bool bReadOnly { get; set; }
        public HTTPResponseHeaders headers { get; set; }
    }
}
