using System;
using UnityEngine;

public class Notification : MonoBehaviour
{
    private void OnEnable()
    {
      //  QuestManager.onQuestCompleted += Show();
    }

    private void OnDisable()
    {
        QuestManager.onQuestCompleted -= Show();
    }

    private Action<Quest> Show()
    {
        throw new NotImplementedException();
    }

    public void Show(Quest quest)
    {
        Debug.Log("Quest Name : " + quest.Title + " Clear");
    }


}
