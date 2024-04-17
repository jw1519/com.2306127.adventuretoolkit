using System.IO;
using System.Xml.Serialization;
using TMPro;
using UnityEngine;

public class characterStats : MonoBehaviour
{
    public Stat stat;
    private string charcterFilePath;
    public TextMeshProUGUI StatsText;


    // Start is called before the first frame update
    public void Start()
    {
        charcterFilePath = Application.persistentDataPath + "/charcterStats.xml";
        LoadStats();
        DisplayStats();
    }

    public void SaveStats(Stat stat)
    {
        XmlSerializer serializer = new XmlSerializer(typeof(Stat));
        using (FileStream stream = new FileStream(charcterFilePath, FileMode.Create))
        {
            serializer.Serialize(stream, stat);
        }
    }
    public void LoadStats()
    {
        if (File.Exists(charcterFilePath))
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Stat));
            using (FileStream stream = new FileStream(charcterFilePath, FileMode.Open))
            {
                stat = serializer.Deserialize(stream) as Stat;
            }
        }
        else
        {
            int newStrength = Random.Range(1, 20);
            int newWisdom = Random.Range(1, 20);
            int newcharisma = Random.Range(1, 20);
            SaveStats(new Stat(newStrength, newWisdom, newcharisma));
        }
    }
    public void DisplayStats()
    {
        StatsText.text = $"Strength: {stat.Strength} \n Wisdom: {stat.Wisdom} \n Charisma: {stat.Charisma}"; 
    }
}
