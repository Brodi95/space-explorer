using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    #region Variables

    public static Player player;

    public float MaxHealth = 100f;
    public float CurrentHealth;

    public float MaxHunger;
    public float HungerPoints;

    public delegate void Flip();
    public Flip FlipCharacter;

    public delegate void UpdateHealth();
    public UpdateHealth UpdateHealthbar;


    #endregion

    private void Awake()
    {
        player = this;
    }

    private void Start()
    {
        CurrentHealth = MaxHealth;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
            ApplyDamage(10f);
    }

    public void ApplyDamage(float damage)
    {
        
        CurrentHealth -= damage;
        UpdateHealthbar();
        if(CurrentHealth <= 0)
        {
            Dead();
        }

    }

    public void Eat(float heal, float hunger)
    {
        float newHunger = HungerPoints - hunger;
        HungerPoints =  newHunger < 0 ? 0 : newHunger;
        float newHealth = CurrentHealth + heal;
        CurrentHealth = newHealth > MaxHealth ? MaxHealth : newHealth;
    }

    public void Dead()
    {
        
    }
}
