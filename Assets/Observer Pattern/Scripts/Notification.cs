using UnityEngine;

public class Notification : MonoBehaviour
{
    private void Awake()
    {
        //canvas = transform.GetChlid(0).GetComponent<Canvas>();   

    }

    private void OnEnable()
    {
        QuestManager.onQuestCompleted += Show;
    }

    private void OnDisable()
    {
        QuestManager.onQuestCompleted -= Show;
    }

    public void Show(Quest quest)
    {
        if(quest.Completed)
        {
           // Canvas.gameObject.SetActive(true);

           // questImage.sprite = sprtie;

            
        }
    }


}
