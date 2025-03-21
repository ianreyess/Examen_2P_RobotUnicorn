using UnityEngine;
using UnityEngine.Events;
public class PlataformTrigger : MonoBehaviour
{
    [SerializeField]
    private UnityEvent onPlataformTriggered;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("DeadZone"))
        {
            Destroy(other.gameObject);
            onPlataformTriggered?.Invoke();
        }
    }
}
