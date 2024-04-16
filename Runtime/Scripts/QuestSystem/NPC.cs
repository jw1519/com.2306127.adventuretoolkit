using UnityEngine;

public class NPC : MonoBehaviour
{

    public QuestMarker questMarker;
    public DialogueTrigger questDialogueTrigger;
    public DialogueTrigger endQuestDialogueTrigger;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Quest quest = QuestManager.instance.quests.Find(q => q.questName == questMarker.QuestName);
            questDialogueTrigger.TriggerDialogue();

            if (quest == null) // quest not yet started
            {
                QuestManager.instance.AddQuest(questMarker.QuestName, questMarker.QuestDescription);
                questMarker.gameObject.SetActive(true);
                Debug.Log(questMarker.QuestDescription);
            }
            else if (quest.isCompleted == true)
            {
                QuestManager.instance.RemoveQuest(questMarker.QuestName);
                Debug.Log(questMarker.QuestCompletionMessage);
                endQuestDialogueTrigger.TriggerDialogue();

                QuestManager.instance.questMenu.text = " Quests: \n";
                foreach (string name in QuestManager.instance.Quests) 
                {
                    string itemtext = name.ToString();
                    QuestManager.instance.questMenu.text = "Quest: \n" + itemtext;
                }
            }
        }
    }
    private void OnTriggerExit(Collider other) 
    {
        FindObjectOfType<DialogueManager>().EndDialogue();
    }
}
