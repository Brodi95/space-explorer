﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour {

    public ItemTemplate item;

    public void Interact()
    {
        Destroy(gameObject);
    }
}
