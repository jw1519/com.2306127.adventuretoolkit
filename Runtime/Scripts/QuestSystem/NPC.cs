using System.Collections;
using System.Collections.Generic;
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
            Quest quest = QuestManager.instance.quests.Find(q => q.questName == questMarker.questName);
            questDialogueTrigger.TriggerDialogue();

            if (quest == null) // quest not yet started
            {
                QuestManager.instance.AddQuest(questMarker.questName, questMarker.questDescription);
                questMarker.gameObject.SetActive(true);
                Debug.Log(questMarker.questDescription);
            }
            else if (quest.isCompleted == true)
            {
                QuestManager.instance.RemoveQuest(questMarker.questName);
                Debug.Log(questMarker.questCompletionMessage);
                endQuestDialogueTrigger.TriggerDialogue();

                QuestManager.instance.questMenu.text = " Quests: \n";
                foreach (string name in QuestManager.instance.Quests) // doesnt work with more than two quests
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
