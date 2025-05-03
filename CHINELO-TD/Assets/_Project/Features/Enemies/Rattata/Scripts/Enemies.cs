using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies : MonoBehaviour
{
[SerializeField] private float movespeed = 2f;

    private Rigidbody2D rb;

    private Transform checkpoint;

    private int index = 0;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        checkpoint = EnemyManager.main.checkpoints[index];
    }

    void Update()
    {
        checkpoint = EnemyManager.main.checkpoints[index];

        if (Vector2.Distance(checkpoint.transform.position, transform.position) <= 0.1f)
        {
            index++;

            if (index >= EnemyManager.main.checkpoints.Length)
            {
                Destroy(gameObject);
            }
        }
    }

    void FixedUpdate()
    {
        Vector2 direction = (checkpoint.position - transform.position).normalized;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, angle);
        rb.linearVelocity = direction * movespeed;
    }
}