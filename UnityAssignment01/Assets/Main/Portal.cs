using System.Collections;
using UnityEngine;

public class Portal : MonoBehaviour
{

    [SerializeField] private Transform _portalEnd;
    void OnTriggerEnter2D(Collider2D collider2D)
    {
        if (collider2D.CompareTag("Ball"))
        {
            GameObject ball = collider2D.gameObject;
            ball.transform.position = _portalEnd.position;
            
        }
    }
}
