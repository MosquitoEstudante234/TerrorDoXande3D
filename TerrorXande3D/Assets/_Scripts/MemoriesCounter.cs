using TMPro;
using UnityEngine;
public class MemoriesCounter : MonoBehaviour
{
    public static MemoriesCounter Instance;
    public TextMeshProUGUI memoriesCounter;
    public int memoriesCount;

    public int Artifact = 10;

    public bool[] whatScene = new bool[3];

    private void Awake()
    {
        Instance = this;
    }
    public void Start()
    {
        memoriesCount = 0;
    }
    private void Update()
    {
        memoriesCounter.text = "Collect " + Artifact.ToString() + " Artifacts ";

            if(memoriesCount == 5)
            {
                memoriesCount = 0;
            }
            if(memoriesCount == 1)
            {
                PickFlashlight.IsPicked = true;
            }
            
    }

}
