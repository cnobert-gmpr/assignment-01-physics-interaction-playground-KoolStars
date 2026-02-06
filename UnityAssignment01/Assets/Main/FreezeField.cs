using System.Collections;
using UnityEngine;

public class FreezeField : MonoBehaviour
{
    [SerializeField] private float _freezeDuration = 1;
    private bool _coolDown = false;
    private float _coolDownTime = 1;

    void OnTriggerEnter2D(Collider2D collider2D)
    {
        if (collider2D.CompareTag("Ball"))
        {
            GameObject ball = collider2D.gameObject;
            if (!_coolDown)
            {
                StartCoroutine(FreezeBall(ball));
            }
            

        }
    }

    private IEnumerator FreezeBall(GameObject ball)
    {
        _coolDown = true;

        Rigidbody2D ballRB = ball.GetComponent<Rigidbody2D>();
        if (ballRB != null)
        {
            ballRB.simulated = false;
        }

        yield return new WaitForSeconds(_freezeDuration);

        if (ballRB != null)
        {
            ballRB.simulated = true;
        }

        yield return new WaitForSeconds(_coolDownTime);

        _coolDown = false;
    }
}
