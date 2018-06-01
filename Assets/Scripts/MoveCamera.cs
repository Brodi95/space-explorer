using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour {

    public Transform Player;

    public Transform CurrentTarget;

    public float CameraDistance = 5f;

    private void Start()
    {
        CurrentTarget = Player;
    }

    void Update () {
        Vector2 destination = Vector2.MoveTowards(transform.position, CurrentTarget.position, 0.1f);
        transform.position = new Vector3(destination.x, destination.y, -CameraDistance);

	}
}
