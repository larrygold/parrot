using System;

namespace Parrot
{
    public class Parrot
    {
        protected const double BaseSpeed = 12.0;

        public virtual double GetSpeed()
        {
            throw new Exception("Should be unreachable");
        }

    }

    public class EuropeanParrot : Parrot
    {
        public EuropeanParrot(double voltage, bool isNailed)
        {

        }

        public override double GetSpeed() => BaseSpeed;

    }

    public class AfricanParrot : Parrot
    {
        private readonly double _loadFactor;
        private readonly int _numberOfCoconuts;

        public AfricanParrot(int numberOfCoconuts, double voltage, bool isNailed)
        {
            _numberOfCoconuts = numberOfCoconuts;
            _loadFactor = 9.0;
        }

        public override double GetSpeed() => Math.Max(0, BaseSpeed - _loadFactor * _numberOfCoconuts);
    }

    public class NorwegianBlueParrot: Parrot
    {
        private readonly double _voltage;
        private readonly bool _isNailed;
        public NorwegianBlueParrot(double voltage, bool isNailed)
        {
            _voltage = voltage;
            _isNailed = isNailed;
        }

        public override double GetSpeed() => _isNailed ? 0 : GetBaseSpeed(_voltage);

        private double GetBaseSpeed(double voltage)
        {
            return Math.Min(24.0, voltage * BaseSpeed);
        }

    }

}