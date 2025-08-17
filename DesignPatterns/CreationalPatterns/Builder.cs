using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns
{
    public class Computer
    {
        public string CPU { get; set; }
        public string RAM { get; set; }
        public string Storage { get; set; }
        public string GraphicsCard { get; set; }
        public string PowerSupply { get; set; }
        public string Case { get; set; }

        public override string ToString()
        {
            return $"CPU: {CPU}, RAM: {RAM}, Storage: {Storage}, GraphicsCard: {GraphicsCard}, PowerSupply: {PowerSupply}, Case: {Case}";
        }
    }

    public interface IComputerBuilder
    {
        void SetCPU();
        void SetRAM();
        void SetStorage();
        void SetGraphicsCard();
        void SetPowerSupply();
        void SetCase();
        Computer GetComputer();
    }

    public class GamingComputerBuilder : IComputerBuilder
    {
        private Computer _computer = new Computer();

        public void SetCPU()
        {
            _computer.CPU = "Intel Core i9";
        }

        public void SetRAM()
        {
            _computer.RAM = "32GB";
        }

        public void SetStorage()
        {
            _computer.Storage = "1TB SSD";
        }

        public void SetGraphicsCard()
        {
            _computer.GraphicsCard = "NVIDIA GeForce RTX 3080";
        }

        public void SetPowerSupply()
        {
            _computer.PowerSupply = "750W";
        }

        public void SetCase()
        {
            _computer.Case = "Cooler Master";
        }

        public Computer GetComputer()
        {
            return _computer;
        }
    }

    public class OfficeComputerBuilder : IComputerBuilder
    {
        private Computer _computer = new Computer();

        public void SetCPU()
        {
            _computer.CPU = "Intel Core i5";
        }

        public void SetRAM()
        {
            _computer.RAM = "16GB";
        }

        public void SetStorage()
        {
            _computer.Storage = "512GB SSD";
        }

        public void SetGraphicsCard()
        {
            _computer.GraphicsCard = "Integrated";
        }

        public void SetPowerSupply()
        {
            _computer.PowerSupply = "500W";
        }

        public void SetCase()
        {
            _computer.Case = "Generic Case";
        }

        public Computer GetComputer()
        {
            return _computer;
        }
    }

    public class ComputerDirector
    {
        private readonly IComputerBuilder _builder;

        public ComputerDirector(IComputerBuilder builder)
        {
            _builder = builder;
        }

        public void BuildComputer()
        {
            _builder.SetCPU();
            _builder.SetRAM();
            _builder.SetStorage();
            _builder.SetGraphicsCard();
            _builder.SetPowerSupply();
            _builder.SetCase();
        }

        public Computer GetComputer()
        {
            return _builder.GetComputer();
        }
    }


}
