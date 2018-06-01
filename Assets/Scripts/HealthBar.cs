using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour {

    public Image foreground;
    private Player player;
    private Animator anim;

    void Start()
    {
        player = Player.player;
        player.FlipCharacter += Flip;
        player.UpdateHealthbar += UpdateHealthbar;

        anim = GetComponent<Animator>();
    }

	private void Flip()
    {
        transform.localScale *= -1;
    }

    private void UpdateHealthbar()
    {
        if(player.CurrentHealth != player.MaxHealth)
        {
            anim.SetBool("FadeIn", true);
            anim.SetBool("FadeOut", false);
        }
        else
        {
            anim.SetBool("FadeIn", false);
            anim.SetBool("FadeOut", true);
        }
        foreground.fillAmount = Mathf.Clamp01(player.CurrentHealth/player.MaxHealth);
    }
}
