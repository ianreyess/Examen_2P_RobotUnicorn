using UnityEngine;
using UnityEngine.Events;
using System.Collections;

public class PlayerCollision : MonoBehaviour
{
    [SerializeField]
    private UnityEvent onPlayerLose;
    private Dash dash;

    private void Start()
    {
        dash = GetComponent<Dash>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            if (dash.IsDashing)
            {
                Destroy(collision.gameObject);
            }
            else
            {
                SoundManager.instance.Play("Damage");
                onPlayerLose?.Invoke();
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("DeadZone"))
        {
            onPlayerLose?.Invoke();
        }
    }
}
