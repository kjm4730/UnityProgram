using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] bool state;

    private void Start()
    {
        state = true;
    }

    public void Pause()
    {
        state = false;
    }
}
