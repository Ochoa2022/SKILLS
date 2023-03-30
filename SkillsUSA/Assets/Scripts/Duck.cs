using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Duck : MonoBehaviour
{
    [SerializeField] private float speed = 9;
    private Transform target;
    public GameObject robot;
    Vector3 offset = new Vector2(2.0f, 0.0f);
    void Awake()
    {
        target = robot.transform;
    }

    
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target.position + offset, speed * Time.deltaTime);
    }
}
