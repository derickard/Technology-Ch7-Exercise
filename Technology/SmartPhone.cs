using System;
using System.Collections.Generic;
using System.Text;

namespace Technology
{
    public class SmartPhone : Computer
    {
        public double CameraMp { get; set; }
        public SmartPhone(double cameraMp, double ram, double cpuSpeed, double diskSize) : base(ram, cpuSpeed, diskSize)
        {
            CameraMp = cameraMp;
        }

        public string TakePicture()
        {
            return "Great shot!";
        }
    }
}
