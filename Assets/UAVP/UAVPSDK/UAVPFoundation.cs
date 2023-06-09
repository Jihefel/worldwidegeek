﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Use this delegate function to receive event from UAVPSource
public delegate void EventNotify(int type, float param1, float param2, float param3);

public abstract class UAVPFoundation
{   
    public static EventNotify onEvent;

    public abstract Texture2D videoTexture { get; }

    public abstract UAVPStatus playerStatus { get; }

    /*
    Initializes the player
    - logLevel: Set the LogLevel(Debug, Source, Porting, System)
    */
    public virtual UAVPError InitPlayer(UAVPLogLevel logLevel) { return UAVPError.UAVP_ERROR_NONE; }

    /*
    Open the media with player
    - URI: Media Location 
    - mediaType: Types of media
    */
    public virtual UAVPError OpenMedia(string URI, UAVPMediaType mediaType) { return UAVPError.UAVP_ERROR_NONE; }

    /*
    Playing the Media
    */
    abstract public void Start();

    /*
    Pause the Media
    */
    abstract public void Pause();

    /*
    Seek the Media

    param1: time is seconds
    */
    abstract public void Seek(int time);

    /*
    Release the Player
    */
    abstract public void Release();

    /*
    Set Property to Player
    */
    abstract public void setProperty(UAVPProperty type, int param);
}
