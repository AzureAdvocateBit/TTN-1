using Microsoft.Maps.Unity;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetMapsKey : MonoBehaviour
{
    private GameObject map;
    private MapRenderer mapRenderer;
    private string bingMapsKey;
    // Start is called before the first frame update
    void Awake()
    {
        map = GameObject.Find("Map");
        mapRenderer = map.GetComponent<MapRenderer>();
        bingMapsKey = Environment.GetEnvironmentVariable("BingMapsKey");
        mapRenderer.BingMapsKey = bingMapsKey;
    }
}
