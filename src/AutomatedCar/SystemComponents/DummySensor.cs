namespace AutomatedCar.SystemComponents
{
    using AutomatedCar.Models;
    using AutomatedCar.SystemComponents.Packets;
    using System;
    using System.Linq;

    internal class DummySensor : SystemComponent
    {
        private DummyPacket dummyPacket;
        public DummySensor(VirtualFunctionBus virtualFunctionBus) : base(virtualFunctionBus)
        {
            this.dummyPacket = new DummyPacket();
            virtualFunctionBus.DummyPacket = this.dummyPacket;
        }

        public override void Process()
        {
            Circle circle = World.Instance.WorldObjects.OfType<Circle>().FirstOrDefault();
            AutomatedCar car = World.Instance.ControlledCar;

            this.dummyPacket.DistanceX = Math.Abs(car.X - circle.X);
            this.dummyPacket.DistanceY = Math.Abs(car.Y - circle.Y);
        }
    }
}
