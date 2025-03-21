using UnityEngine;

public class PlayerPositioner : MonoBehaviour
{
    [SerializeField]
    private Transform player;
    [SerializeField]
    private Transform startingPosition;
    public void SetPlayePosition()
    {
        player.position = startingPosition.position;
    }
    public void SetPlayerPositioner()
    {
            player.position = startingPosition.position;
            Rigidbody playerRigibody = player.GetComponent<Rigidbody>();
            playerRigibody.linearVelocity = Vector3.zero;
            playerRigibody.angularVelocity = Vector3.zero;
    }
}
