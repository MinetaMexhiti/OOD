using System;
namespace AbstractFactory_2
{
    public interface IGUIFac
    {
        public abstract IButton createButton();
        public abstract ICheckbox CreateCheckbox();
        public abstract IWindow CreateWindow();
    }

    public interface IWindow
    {
        void Render();
    }

    public interface ICheckbox
    {
        void Render();
    }

    public interface IButton
    {
        void Render();
    }
}


