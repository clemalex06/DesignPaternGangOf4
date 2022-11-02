using System;
using System.Collections.Generic;
namespace Mediator
{
    public class Form
    {
        protected IList<Control> BasicControls = new List<Control>();
        protected IList<Control> AdditionalControls =
            new List<Control>();
        public PopupMenu PopupMenu { protected get; set; }
        public Button OkButton { protected get; set; }

        protected bool InProgress = true;

        public void AddBasicControl(Control control)
        {
            BasicControls.Add(control);
            control.MainForm = this;
        }

        public void AddAdditionalControls(Control control)
        {
            AdditionalControls.Add(control);
            control.MainForm = this;
        }

        public void ModifyControl(Control control)
        {
            if (control == PopupMenu)
            {
                if (control.Value == "with Additional Controls")
                {
                    foreach (var cont in AdditionalControls)
                    {
                        cont.Input();
                    }
                }
            }
            if (control == OkButton)
            {
                InProgress = false;
            }
        }

        public void Input()
        {
            while (true)
            {
                foreach (var control in BasicControls)
                {
                    control.Input();
                    if (!InProgress)
                        return;
                }
            }
        }
    }
}
