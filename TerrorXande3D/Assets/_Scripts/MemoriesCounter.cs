using TMPro;
using UnityEngine;
public class MemoriesCounter : MonoBehaviour
{
    public static MemoriesCounter Instance;
    public TextMeshProUGUI memoriesCounter;
    public int memoriesCount;

    public bool[] whatScene = new bool[3];

    private void Awake()
    {
        Instance = this;
    }
    private void Update()
    {
        memoriesCounter.text = "Collect 5 candles " + "Collected: " + memoriesCount.ToString() + "/5";

            if(memoriesCount == 5)
            {
                memoriesCount = 0;
            }
    }
}
