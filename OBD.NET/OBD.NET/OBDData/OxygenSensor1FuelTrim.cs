﻿namespace OBD.NET.OBDData
{
    public class OxygenSensor1FuelTrim : AbstractOBDData
    {
        #region Properties & Fields

        public double Voltage => A / 200.0;
        public double ShortTermFuelTrim => (B / 1.28) - 100;
        public bool IsSensorUsed => B != 0xFF;

        #endregion

        #region Constructors

        public OxygenSensor1FuelTrim()
            : base(0x14, 2)
        { }

        #endregion
    }
}