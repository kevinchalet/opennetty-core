﻿/*
 * Licensed under the Apache License, Version 2.0 (http://www.apache.org/licenses/LICENSE-2.0)
 * See https://github.com/opennetty/opennetty-core for more information concerning
 * the license and the contributors participating to this project.
 */

namespace OpenNetty;

/// <summary>
/// Exposes common capabilities supported by OpenNetty endpoints or devices.
/// </summary>
public static class OpenNettyCapabilities
{
    /// <summary>
    /// Advanced dimming control.
    /// </summary>
    public static readonly OpenNettyCapability AdvancedDimmingControl = new("Advanced dimming control");

    /// <summary>
    /// Advanced dimming state.
    /// </summary>
    public static readonly OpenNettyCapability AdvancedDimmingState = new("Advanced dimming state");

    /// <summary>
    /// Advanced shutter control.
    /// </summary>
    public static readonly OpenNettyCapability AdvancedShutterControl = new("Advanced shutter control");

    /// <summary>
    /// Advanced shutter state.
    /// </summary>
    public static readonly OpenNettyCapability AdvancedShutterState = new("Advanced shutter state");

    /// <summary>
    /// Basic dimming control.
    /// </summary>
    public static readonly OpenNettyCapability BasicDimmingControl = new("Basic dimming control");

    /// <summary>
    /// Basic dimming state.
    /// </summary>
    public static readonly OpenNettyCapability BasicDimmingState = new("Basic dimming state");

    /// <summary>
    /// Basic scenario.
    /// </summary>
    public static readonly OpenNettyCapability BasicScenario = new("Basic scenario");

    /// <summary>
    /// Basic shutter control.
    /// </summary>
    public static readonly OpenNettyCapability BasicShutterControl = new("Basic shutter control");

    /// <summary>
    /// Basic shutter state.
    /// </summary>
    public static readonly OpenNettyCapability BasicShutterState = new("Basic shutter state");

    /// <summary>
    /// Battery.
    /// </summary>
    public static readonly OpenNettyCapability Battery = new("Battery");

    /// <summary>
    /// Date/time.
    /// </summary>
    public static readonly OpenNettyCapability DateTime = new("Date/time");

    /// <summary>
    /// Device description.
    /// </summary>
    public static readonly OpenNettyCapability DeviceDescription = new("Device description");

    /// <summary>
    /// Dimming scenario.
    /// </summary>
    public static readonly OpenNettyCapability DimmingScenario = new("Dimming scenario");

    /// <summary>
    /// Memory reading.
    /// </summary>
    public static readonly OpenNettyCapability MemoryReading = new("Memory reading");

    /// <summary>
    /// Memory writing.
    /// </summary>
    public static readonly OpenNettyCapability MemoryWriting = new("Memory writing");

    /// <summary>
    /// On/off scenario.
    /// </summary>
    public static readonly OpenNettyCapability OnOffScenario = new("On/off scenario");

    /// <summary>
    /// On/off switching.
    /// </summary>
    public static readonly OpenNettyCapability OnOffSwitching = new("On/off switching");

    /// <summary>
    /// On/off switch state.
    /// </summary>
    public static readonly OpenNettyCapability OnOffSwitchState = new("On/off switch state");

    /// <summary>
    /// OpenWebNet gateway.
    /// </summary>
    public static readonly OpenNettyCapability OpenWebNetGateway = new("OpenWebNet gateway");

    /// <summary>
    /// OpenWebNet command session.
    /// </summary>
    public static readonly OpenNettyCapability OpenWebNetCommandSession = new("OpenWebNet command session");

    /// <summary>
    /// OpenWebNet event session.
    /// </summary>
    public static readonly OpenNettyCapability OpenWebNetEventSession = new("OpenWebNet event session");

    /// <summary>
    /// OpenWebNet generic session.
    /// </summary>
    public static readonly OpenNettyCapability OpenWebNetGenericSession = new("OpenWebNet generic session");

    /// <summary>
    /// Pilot wire heating.
    /// </summary>
    public static readonly OpenNettyCapability PilotWireHeating = new("Pilot wire heating");

    /// <summary>
    /// Pilot wire scenario.
    /// </summary>
    public static readonly OpenNettyCapability PilotWireScenario = new("Pilot wire scenario");

    /// <summary>
    /// Progressive scenario.
    /// </summary>
    public static readonly OpenNettyCapability ProgressiveScenario = new("Progressive scenario");

    /// <summary>
    /// Smart meter indexes.
    /// </summary>
    public static readonly OpenNettyCapability SmartMeterIndexes = new("Smart meter indexes");

    /// <summary>
    /// Smart meter information.
    /// </summary>
    public static readonly OpenNettyCapability SmartMeterInformation = new("Smart meter information");

    /// <summary>
    /// Stop/up/down scenario.
    /// </summary>
    public static readonly OpenNettyCapability StopUpDownScenario = new("Stop/up/down scenario");

    /// <summary>
    /// Timed scenario.
    /// </summary>
    public static readonly OpenNettyCapability TimedScenario = new("Timed scenario");

    /// <summary>
    /// Toggle scenario.
    /// </summary>
    public static readonly OpenNettyCapability ToggleScenario = new("Toggle scenario");

    /// <summary>
    /// Unit description.
    /// </summary>
    public static readonly OpenNettyCapability UnitDescription = new("Unit description");

    /// <summary>
    /// Uptime.
    /// </summary>
    public static readonly OpenNettyCapability Uptime = new("Uptime");

    /// <summary>
    /// Water heating.
    /// </summary>
    public static readonly OpenNettyCapability WaterHeating = new("Water heating");

    /// <summary>
    /// Wireless burglar alarm scenario.
    /// </summary>
    public static readonly OpenNettyCapability WirelessBurglarAlarmScenario = new("Wireless burglar alarm scenario");

    /// <summary>
    /// Wireless burglar alarm state.
    /// </summary>
    public static readonly OpenNettyCapability WirelessBurglarAlarmState = new("Wireless burglar alarm state");

    /// <summary>
    /// Zigbee binding.
    /// </summary>
    public static readonly OpenNettyCapability ZigbeeBinding = new("Zigbee binding");

    /// <summary>
    /// Zigbee supervision.
    /// </summary>
    public static readonly OpenNettyCapability ZigbeeSupervision = new("Zigbee supervision");
}
