using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] bool state;

    public bool State {  get { return state; } }

    public static GameManager instance;

    public static GameManager Instance
    {
        get
        {
            if(instance == null)
            {
                instance = FindObjectOfType<GameManager>();
            }

            return instance;
        }
    }

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }

    }

    private void Start()
    {
        state = true;
    }

    public void Pause()
    {
        state = false;
    }
}
