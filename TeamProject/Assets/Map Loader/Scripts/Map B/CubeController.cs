using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    private new Renderer renderer;

    public GameObject effect;

    private void Awake()
    {
        renderer = GetComponent<Renderer>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            renderer.material.color = Color.white;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Instantiate(effect, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}