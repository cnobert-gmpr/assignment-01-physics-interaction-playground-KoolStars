using System.Collections;
using UnityEngine;

namespace GMPR2512.Lesson05Coroutines
{
    public class DeathZone : MonoBehaviour
    {

        void OnTriggerEnter2D(Collider2D collider2D)
        {
            if(collider2D.CompareTag("Ball"))
            {
                GameObject ball = collider2D.gameObject;
                StartCoroutine(RespawnBall(ball));
            }
        }

        private IEnumerator RespawnBall(GameObject ball)
        {

            yield return new WaitForSeconds(2);

            Rigidbody2D ballRB = ball.GetComponent<Rigidbody2D>();
            if(ballRB != null)
            {
                ballRB.linearVelocity = Vector2.zero;
                ballRB.angularVelocity = 0;
            }

            ball.transform.position = new Vector3(0,2,0);
        }
    }
}
