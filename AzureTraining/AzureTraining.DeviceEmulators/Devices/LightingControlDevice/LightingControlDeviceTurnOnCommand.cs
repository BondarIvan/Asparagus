﻿using AzureTraining.DeviceEmulators.Abstractions.Command;

namespace AzureTraining.DeviceEmulators.Devices.LightingControlDevice
{
    public class LightingControlDeviceTurnOnCommand : ISpecialDeviceCommand
    {
        private readonly AzureTraining.DeviceEmulators.Devices.LightingControlDevice.LightingControlDevice _device;

        public LightingControlDeviceTurnOnCommand(AzureTraining.DeviceEmulators.Devices.LightingControlDevice.LightingControlDevice device)
        {
            _device = device;
        }

        /// <inheritdoc />
        public void Execute() => _device.TurnOn();
    }
}
