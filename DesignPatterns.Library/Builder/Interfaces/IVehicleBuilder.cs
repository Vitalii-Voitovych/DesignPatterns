using DesignPatterns.Library.Builder.Models;

namespace DesignPatterns.Library.Builder.Interfaces
{
    public interface IVehicleBuilder
    {
        void Reset();
        void SetModelName(string name);
        void SetEngine(Engine engine);
        void SetBody(Body body);
        void SetTank(Tank tank);
    }
}
