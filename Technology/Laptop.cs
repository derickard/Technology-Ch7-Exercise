using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace Technology
{
    public class Laptop : Computer
    {

        public double Weight { get; set; }
        public bool IsTabletMode { get; set; } = false;
        public Laptop(double weight, double ram, double cpuSpeed, double diskSize) : base(ram, cpuSpeed, diskSize)
        {
            Weight = weight;
        }

        public void ToggleTabletMode()
        {
            IsTabletMode = !IsTabletMode;
        }
    }
}
