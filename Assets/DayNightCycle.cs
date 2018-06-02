using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNightCycle : MonoBehaviour {
    public Color maskColor;
    public SpriteRenderer spriteRenderer;
	// Use this for initialization
	void Start () {
        spriteRenderer = GetComponent<SpriteRenderer>();
        maskColor = spriteRenderer.color;
        GameTimer.Timer.DayMode += SetDay;
        GameTimer.Timer.NightMode += SetNight;
        maskColor.a = 0.6f;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

   public void SetNight()
    {
        maskColor.a += 0.2f;
        spriteRenderer.color = maskColor;
    }

    public void SetDay()
    {
        maskColor.a -= 0.2f;
        spriteRenderer.color = maskColor;
    }
}
