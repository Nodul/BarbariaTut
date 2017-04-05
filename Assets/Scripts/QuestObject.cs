using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestObject : MonoBehaviour {

    public int QuestNum;
    public QuestManager QM;

    public string startText;
    public string endText;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void StartQuest()
    {
        QM.ShowQuestText(startText);
    }

    public void EndQuest()
    {
        QM.ShowQuestText(endText);
        QM.questsCompleted[QuestNum] = true;
        this.gameObject.SetActive(false);
    }
}
