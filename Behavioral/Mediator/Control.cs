using System;
namespace Mediator
{
    public abstract class Control
    {
        public string Value { get; protected set; }
        public Form MainForm { get; set; }
        public string Name { get; protected set; }

        public Control(string name)
        {
            Name = name;
            Value = "";
        }

        public abstract void Input();
        protected void Modify()
        {
            MainForm.ModifyControl(this);
        }
    }
}
