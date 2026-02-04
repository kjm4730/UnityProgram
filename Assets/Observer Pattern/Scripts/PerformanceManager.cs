using UnityEngine;

public class PerformanceManager : MonoBehaviour
{
    [SerializeField] string [ ] questTitle;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {


            QuestManager.Instance.Complete(Random.Range(0, questTitle.Length).ToString());
        }
    }
}

