using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public Transform newTarget;
    public float targetSize;

    private SpriteRenderer _spriteRenderer;
    private CameraScript _cc;

    // Start is called before the first frame update
    void Start()
    {
        _spriteRenderer = gameObject.GetComponent<SpriteRenderer>();

        _spriteRenderer.enabled = false;

        _cc = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<CameraScript>();

        //newTarget = GameObject.FindGameObjectWithTag("Camera2").GetComponent<Transform>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            _cc.ChangeTarget(newTarget, targetSize);
        }
    }
    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Hello");
        }
    }
}
