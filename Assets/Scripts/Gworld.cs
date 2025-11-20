using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class Gworld
{
    private static readonly Gworld instance = new Gworld();
    private static WorldStates world;

    static Gworld()
    {
        world = new WorldStates();
    }
    private Gworld()
    {

    }

    public static Gworld Instance
    {
        get { return instance; }
    }

    public WorldStates GetWorld()
    {
        return world;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
