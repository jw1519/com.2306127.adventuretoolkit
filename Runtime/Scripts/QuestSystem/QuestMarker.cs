using UnityEngine;

public class QuestMarker : MonoBehaviour
{
    public string questName;
    public string questDescription;
    public string questCompletionMessage;

    void Start()
    {
        QuestManager.instance.RegisterQuestMarker(this);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            QuestManager.instance.CompleteQuest(questName);
            gameObject.SetActive(false);
        }
    }
}
