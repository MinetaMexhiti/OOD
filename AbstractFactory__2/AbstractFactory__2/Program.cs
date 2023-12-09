using AbstractFactory_2;

class Program
{

    static void Main()
    {
        IGUIFac factory;

        factory = new WindowGUIFactory();


        IButton button = factory.createButton();
        ICheckbox checkbox = factory.CreateCheckbox();
        IWindow window = factory.CreateWindow();



        button.Render();
        checkbox.Render();
        window.Render();
    }

}

