

namespace SOLID._3_l
{
    public abstract class Surgeon
    {
        public abstract void PerformSurgery();
    }

    public class HeartSurgeon : Surgeon
    {
        public override void PerformSurgery()
        {
            Console.WriteLine("Performing heart surgery");
        }
    }

    public class NeuroSurgeon : Surgeon
    {
        public override void PerformSurgery()
        {
            Console.WriteLine("Performing brain surgery");
        }
    }
}