﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Debugging Log Level
public enum UAVPLogLevel
{
    Debug = 0,      // Level of UAVP Script
    Source = 1,     // Level of Unity Script
    Porting = 2,    // Level of Plugin
    System = 3      // Level of Frameworks
};

// Error Types
public enum UAVPError
{
    UAVP_ERROR_NONE = 0,            // No Error
    UAVP_Error_OPENFAILED = 1001    //Fail to Open the Media
}

// Media Types
public enum UAVPMediaType
{
    UAVP_Streaming_Media = 0,           // Streaming Media(like HLS, Dash, ....)
    UAVP_Local_Media = 1,               // Local Media(Media in StreamingAssets Directory)
    UAVP_StreamingAsset_Media = 2       // Media in StreamingAssets Directory
}

// Player Status
public enum UAVPStatus
{
    UAVP_NONE = 0,
    UAVP_INIT = 1,
    UAVP_OPEN = 2,
    UAVP_START = 3,
    UAVP_PAUSE = 4,
    UAVP_RELEASE = 5
}

// Property Type
public enum UAVPProperty
{
    UAVP_AUTOPLAY = 0,
    UAVP_LOOP = 1,
    UAVP_MUTE = 2
}