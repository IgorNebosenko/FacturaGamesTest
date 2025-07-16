using Core.Entities.Interfaces.Motors;

namespace Core.Entities.Interfaces
{
    public interface IHaveMotor
    {
        public IMotor Motor { get; }
    }
}