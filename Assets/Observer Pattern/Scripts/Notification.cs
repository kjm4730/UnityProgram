using UnityEngine;

public class Notification : MonoBehaviour
{
    private void OnEnable()
    {
       // QuestManager.OnQuestCompleted += ShowDetailsOptions;
    }

    private void OnDisable()
    {
       // QuestManager.OnQuestCompleted -= Show();
    }

    //public void Show(Quest quest)
   // {
       // Debug.Log("Quest Name : " + quest.title + " Clear");
   // }


}
