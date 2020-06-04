using System;
using System.Collections.Generic;
using System.Text;

namespace Technology
{
    public class Computer : AbstractEntity
    {
        public double Ram { get; set; }
        public double CpuSpeed { get; set; }
        public double DiskSize { get; set; }

        public bool IsOn { get; set; } = false;

        public Computer(double ram, double cpuSpeed, double diskSize)
        {
            Ram = ram;
            CpuSpeed = cpuSpeed;
            DiskSize = diskSize;
        }

        public void TogglePower()
        {
            IsOn = !IsOn;
        }

    }
}
