﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class EnemyAnimationScript : MonoBehaviour
{
    //UPDATE FUNCTION
    void Update()
    {
        Vector2 velocity = GetComponent<Rigidbody2D>().velocity;
        velocity.Normalize();
        GetComponent<Animator>().SetFloat("x", velocity.x);
        GetComponent<Animator>().SetFloat("y", velocity.y);
    }
}
