using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    #region Variables

    public static Player player;
    public bool facingRight = false;
    public LayerMask layerMask;

    public Transform HungerBar;
    private List<GameObject> hungerGOs;
    public GameObject HungerPrefab;
    public GameObject HalfHungerPrefab;

    public float MaxHealth = 100f;
    public float CurrentHealth;

    public float MaxHunger;
    public float CurrentHunger;
    private readonly float hungerDamageInterval = 10f;
    private readonly float hungerDamage = 5f;

    public delegate void Flip();
    public Flip FlipCharacter;

    public delegate void UpdateHealth();
    public UpdateHealth UpdateHealthbar;


    #endregion

    private void Awake()
    {
        player = this;
        hungerGOs = new List<GameObject>();
    }

    private void Start()
    {
        CurrentHealth = MaxHealth;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
            ApplyDamage(10f);

        if (Input.GetKeyDown(KeyCode.R))
            ApplyHunger(1f);

        if (Input.GetKeyDown(KeyCode.E))
            Interact();

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
        float newHunger = CurrentHunger - hunger;
        CurrentHunger =  newHunger < 0 ? 0 : newHunger;
        float newHealth = CurrentHealth + heal;
        CurrentHealth = newHealth > MaxHealth ? MaxHealth : newHealth;
    }

    public void ApplyHunger(float hunger)
    {
        CurrentHunger += hunger;
        if(CurrentHunger >= MaxHunger)
        {
            CurrentHunger = MaxHunger;
            ApplyHungerDamage();
        }

        UpdateHungerSymbol();
    }

    private IEnumerator ApplyHungerDamage()
    {
        yield return new WaitForSeconds(hungerDamageInterval);
        if(CurrentHunger == MaxHunger)
        {
            ApplyDamage(hungerDamage);
        }
        
    }

    private void UpdateHungerSymbol()
    {
        int hunger = Mathf.FloorToInt(CurrentHunger);
        Debug.Log(hunger);
        if (hunger % 2 != 0 && hunger > hungerGOs.Count)
        {
            GameObject go = Instantiate(HalfHungerPrefab, HungerBar);
            hungerGOs.Add(go);
        }
        else if (hunger % 2 == 0 && hunger != 0)
        {
            //Destroy half hunger symbol
            Destroy(hungerGOs[hungerGOs.Count - 1]);
            hungerGOs.RemoveAt(hungerGOs.Count - 1);
            GameObject go = Instantiate(HungerPrefab, HungerBar);
            hungerGOs.Add(go);
        }
    }

    private void Interact()
    {
        var direction = facingRight ? Vector2.right : -Vector2.right;
        RaycastHit2D hit = Physics2D.Raycast(transform.position, direction, 0.5f, layerMask);
        Debug.DrawRay(transform.position, direction, Color.red, 2f);
        if (hit.collider != null && hit.collider.gameObject != gameObject)
        {
            Debug.Log(hit.collider.gameObject);
            var target = hit.collider.GetComponent<Interactable>();
            if(target != null)
            {
                target.Interact();
            }
            
        }
    }

    public void Dead()
    {
        
    }
}
