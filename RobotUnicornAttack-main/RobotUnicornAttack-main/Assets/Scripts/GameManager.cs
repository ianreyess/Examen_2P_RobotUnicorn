using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private UnityEvent onGameStart;
    [SerializeField]
    private UnityEvent onRespawnGame;
    [SerializeField]
    private UnityEvent onFinishGame;
    [SerializeField]
    private float secondsToRestart = 3f;
    [SerializeField]
    private float finalSecondsToRestart = 5f;
    void Start()
    {
        onGameStart?.Invoke();
    }

    public void RespawnGame()
    {
        Invoke("RestartGame", secondsToRestart);
    }
    public void FinishGame()
    {
        onFinishGame?.Invoke();
        Invoke("Start", finalSecondsToRestart);
        Invoke("RestartGame", finalSecondsToRestart);
    }
    private void RestartGame()
    {
        onRespawnGame?.Invoke();
    }
}
