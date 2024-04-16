using UnityEngine;

public class QuestMarker : MonoBehaviour
{
    public string QuestName;
    public string QuestDescription;
    public string QuestCompletionMessage;

    void Start()
    {
        QuestManager.instance.RegisterQuestMarker(this);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            QuestManager.instance.CompleteQuest(QuestName);
            gameObject.SetActive(false);
        }
    }
}
