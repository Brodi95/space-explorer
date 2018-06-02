using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNightCycle : MonoBehaviour {
    private Color maskColor;
	// Use this for initialization
	void Start () {
        Color maskColor = GetComponent<SpriteRenderer>().color;
        GameTimer.Timer.DayMode += SetDay;
        GameTimer.Timer.NightMode += SetNight;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

   public void SetNight()
    {
        maskColor.a += 0.2f;
    }

    public void SetDay()
    {
        maskColor.a -= 0.2f;
    }
}
