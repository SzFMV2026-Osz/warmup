namespace AutomatedCar.SystemComponents
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using AutomatedCar.Models;
    using AutomatedCar.SystemComponents.Packets;

    internal class DummySensor : SystemComponent
    {
        private DummyPacket dummyPacket;

        public DummySensor(VirtualFunctionBus virtualFunctionBus) : base(virtualFunctionBus)
        {
            dummyPacket = new DummyPacket();
            virtualFunctionBus.DummyPacket = dummyPacket;
        }

        public override void Process()
        {
            AutomatedCar car = World.Instance.ControlledCar;
            Circle circle = World.Instance.WorldObjects.OfType<Circle>().FirstOrDefault();
            this.dummyPacket.DistanceX = Math.Abs(car.X - circle.X);
            this.dummyPacket.DistanceY = Math.Abs(car.Y - circle.Y);
        }
    }
}
