using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Player : MonoBehaviour
{
    [SerializeField]

    private float speed = 0.1f;
    private Vector3 startPos = new Vector3(0.3f, 0.15f, 1f);


    void Start()
    {
        transform.position = startPos;
        transform.DOJump(transform.position + transform.forward, 2, 1, 1f).SetDelay(1f);
        //Invoke(nameof(Move), 2f);
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        Vector3 direction = new Vector3(0, 0, 1);
        transform.Translate(direction * Time.deltaTime * speed);
    }
}
