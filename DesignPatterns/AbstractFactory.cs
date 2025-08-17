using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public interface Monitor
    {
        void assemble();
    }
    public interface Gpu
    {
        void assemble();
    }

    public class MsiMonitor : Monitor
    {
        public void assemble()
        {
            Console.WriteLine("Msi Monitor");
        }
    }

    public class AsusMonitor : Monitor
    {
        public void assemble()
        {
            Console.WriteLine("Asus Monitor");
        }
    }

    public class MsiGpu : Gpu
    {
        public void assemble()
        {
            Console.WriteLine("Msi Gpu");
        }
    }

    public class AsusGpu : Gpu
    {
        public void assemble()
        {
            Console.WriteLine("Asus Gpu");
        }
    }

    public abstract class Company
    {
        public abstract Gpu CreateGpu();
        public abstract Monitor CreateMonitor();
    }

    public class MsiManufacturer : Company
    {
        public override Gpu CreateGpu()
        {
            return new MsiGpu();
        }
        public override Monitor CreateMonitor()
        {
            return new MsiMonitor();
        }
    }
    public class AsusManufacturer : Company
    {
        public override Gpu CreateGpu()
        {
            return new AsusGpu();
        }
        public override Monitor CreateMonitor()
        {
            return new AsusMonitor();
        }
    }


    public interface IButton
    {
        void Render();
    }

    public interface ICheckbox
    {
        void Render();
    }

    public class WinButton : IButton
    {
        public void Render() => Console.WriteLine("Windows Button");
    }

    public class WinCheckbox : ICheckbox
    {
        public void Render() => Console.WriteLine("Windows Checkbox");
    }

    public class MacButton : IButton
    {
        public void Render() => Console.WriteLine("Mac Button");
    }

    public class MacCheckbox : ICheckbox
    {
        public void Render() => Console.WriteLine("Mac Checkbox");
    }
    /// <summary>
    /// Another example
    /// </summary>
    public abstract class GUIFactory
    {
        public abstract IButton CreateButton();
        public abstract ICheckbox CreateCheckbox();

        // ✅ هنا نقدر نضيف method مشتركة فيها logic
        public void RenderUI()
        {
            var button = CreateButton();
            var checkbox = CreateCheckbox();
            button.Render();
            checkbox.Render();
        }
    }

    // Concrete Factories
    public class WinFactory : GUIFactory
    {
        public override IButton CreateButton() => new WinButton();
        public override ICheckbox CreateCheckbox() => new WinCheckbox();
    }

    public class MacFactory : GUIFactory
    {
        public override IButton CreateButton() => new MacButton();
        public override ICheckbox CreateCheckbox() => new MacCheckbox();
    }

}
