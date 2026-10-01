namespace AutomatedCar.SystemComponents
{
    using System.Linq;
    using AutomatedCar.Models;
    using AutomatedCar.SystemComponents.Packets;

    public class DummySensor : SystemComponent
    {
        private readonly WorldObject circle;
        private readonly Car car;
        private readonly DummyPacket packet;

        /// <summary>
        /// Initializes a new instance of the <see cref="DummySensor"/> class.
        /// </summary>
        public DummySensor(VirtualFunctionBus virtualFunctionBus, Car car)
            : base(virtualFunctionBus)
        {
            this.car = car;

            this.circle = World.Instance.WorldObjects
                .First(x => x.Filename == "circle.png");

            this.packet = new DummyPacket();
            this.virtualFunctionBus.DummyPacket = this.packet;
        }

        public override void Process()
        {
            this.packet.DistanceX = this.circle.X - this.car.X;
            this.packet.DistanceY = this.circle.Y - this.car.Y;
        }
    }
}