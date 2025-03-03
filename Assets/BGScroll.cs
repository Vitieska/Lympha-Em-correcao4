using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScroll : MonoBehaviour
{
    public float speed = 4f;
    private Vector3 StartPosition;

    private void Start()
    {
        {
            StartPosition = transform.position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(translation: Vector3.down*speed*Time.deltaTime);
        if (transform.position.y < -33.70f)
        {
            transform.position = StartPosition;
        }
    }
}
