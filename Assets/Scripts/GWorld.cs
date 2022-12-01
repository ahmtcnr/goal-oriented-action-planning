using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  sealed class GWorld
{
    private static readonly GWorld instance = new GWorld();
    private static WorldStates _world;
    
    static GWorld()
    {
        _world = new WorldStates();
        Debug.Log("sss");
      
    }


    private GWorld()
    {
        
    }

    public static GWorld Instance => instance;


    public WorldStates GetWorld() => _world;
}


