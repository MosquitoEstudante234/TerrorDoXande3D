using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TutorialMission : MonoBehaviour
{
    public static int PaperCount;
    public TMP_Text PaperCountTxt;
    public GameObject ExitTutorialCol, OtherMissions;
    // Start is called before the first frame update
    void Start()
    {
        PaperCount = 3;
    }

    // Update is called once per frame
    void Update()
    {
        PaperCountTxt.text = "Find" + PaperCount.ToString() + "Papers";

        if (PaperCount == 0)
        {
            PaperCountTxt.text = "Unlock the door";
        }
    }
    public void OnTriggerEnter(Collider col)
    {
        if (PaperCount == 0 && col.CompareTag("Tutorial"))
        {
            ExitTutorialCol.SetActive(false);
            OtherMissions.SetActive(true);
        }
    }
}
