using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour {

    public Text hourText;
    public Text dayText;

    public static GameTimer Timer;

    private int daysAlive = 0;
    private const int hourInterval = 3;
    private int currentTime = 0;
    private float timer = 0;

    private const float hunger = 0.5f;

    public delegate void Night();
    public Night NightMode;
    public delegate void Day();
    public Day DayMode;

    private void Awake()
    {
        Timer = this;
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        // 1 hour has passed
        if(timer >= hourInterval)
        {
            timer = 0;
            NextHour();
        }
	}

    private void NextHour()
    {
        currentTime += 1;
        hourText.text = currentTime.ToString();
        Player.player.ApplyHunger(hunger);
        if (currentTime == 24)
        {
            daysAlive += 1;
            dayText.text = daysAlive.ToString();
            currentTime = 0;
        }
    }
}
