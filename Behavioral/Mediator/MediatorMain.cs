namespace Mediator
{
    /*
     * Mediator's Concept :
     * Lets you reduce chaotic dependencies between objects. 
     * The pattern restricts direct communications between the objects 
     * and forces them to collaborate only via a mediator object.
     */
    public static class MediatorMain
    {
        public static void Main()
        {
            var form = new Form();
            form.AddBasicControl(new TextArea("First Name"));
            form.AddBasicControl(new TextArea("Last Name"));
            var menu = new PopupMenu("Additional Controls");
            menu.AddOption("without Additional Controls");
            menu.AddOption("with Additional Controls");
            form.AddBasicControl(menu);
            form.PopupMenu = menu;
            var button = new Button("OK");
            form.AddBasicControl(button);
            form.OkButton = button;
            form.AddAdditionalControls(
                new TextArea("BirthDate"));
            form.AddAdditionalControls(
                new TextArea("BitrhPlace"));
            form.Input();

        }
    }
}
