namespace AutomatedCar.SystemComponents
{
    using AutomatedCar.SystemComponents.Packets;
    using AutomatedCar.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class DummySensor : SystemComponent
    {
        private DummyPacket dummypacket;

        public DummySensor(VirtualFunctionBus virtualFunctionBus) : base(virtualFunctionBus)
        {
            this.dummypacket = new DummyPacket();
            virtualFunctionBus.DummyPacket = this.dummypacket;
        }

        public override void Process()
        {
            var circle = World.Instance.WorldObjects.OfType<Circle>().First();
            var automatedCar = World.Instance.ControlledCar;

            this.dummypacket.DistanceX = circle.X - automatedCar.X;
            this.dummypacket.DistanceY = circle.Y - automatedCar.Y;
        }
    }
}
