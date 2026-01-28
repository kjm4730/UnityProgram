using UnityEngine;

public class RewardManager : MonoBehaviour
{
    [SerializeField] int createCount;
    [SerializeField] Bundle bundle;

    [SerializeField] Reward reward;
    [SerializeField] GameObject panel;
    [SerializeField] Transform parentTransform;

    private void Awake()
    {
        createCount = Random.Range(1, 5);
    }

    private void Start()
    {
        Create();
    }

    private void Create()
    {
        for (int i = 0; i < createCount; i++)
        {
            bundle.Add(Instantiate(reward,parentTransform));
        }
    }

    public void Accept()
    {
        bundle.Receive();

        panel.SetActive(false);
    }

}
