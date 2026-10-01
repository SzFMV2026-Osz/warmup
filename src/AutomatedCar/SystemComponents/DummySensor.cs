namespace AutomatedCar.SystemComponents
{
    using AutomatedCar.Models;
    using AutomatedCar.SystemComponents.Packets;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class DummySensor : SystemComponent
    {
        private DummyPacket dummyPacket;

        public DummySensor(VirtualFunctionBus vfb) : base(vfb)
        {
            this.dummyPacket = new DummyPacket();
            vfb.DummyPacket = this.dummyPacket;
        }

        public override void Process()
        {
            Circle circle = World.Instance.WorldObjects.OfType<Circle>().FirstOrDefault();
            AutomatedCar car = World.Instance.ControlledCar;

            this.dummyPacket.DistanceX = car.X - circle.X;
            this.dummyPacket.DistanceY = car.Y - circle.Y;
        }
    }
}
