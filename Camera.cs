using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public float speed = 2f;
    public Transform player;

    void Update()
    {
        Vector3 newPos = new Vector3(
            player.transform.position.x,
            Mathf.Max(player.transform.position.y, 0f), // Y stops at 0
            -10f
        );

        transform.position = Vector3.Slerp(transform.position, newPos, speed * Time.deltaTime);
    }
}