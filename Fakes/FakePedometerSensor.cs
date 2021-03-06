﻿using System;
using Microsoft.Band.Sensors;

namespace MSBandAzure.Services.Fakes
{
    internal class FakePedometerSensor : FakeBandSensor<IBandPedometerReading>
    {
        public override IBandSensorReading CreateReading()
        {
            Random rand = new Random();
            return new FakeBandPedometerReading(rand.Next(1,5000));
        }
    }
}