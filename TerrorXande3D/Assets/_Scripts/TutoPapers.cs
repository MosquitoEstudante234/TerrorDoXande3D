using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutoPapers : MonoBehaviour
{
    public GameObject Paper;
    public static int PaperCount;
    void Start()
    {
        PaperCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnMouseOver()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            Paper.SetActive(true);
            Destroy(gameObject);
            PaperCount++;
        }
    }
}
