using TMPro;
using UnityEngine;
public class MemoriesCounter : MonoBehaviour
{
    public static MemoriesCounter Instance;
    public TextMeshProUGUI memoriesCounter;
    public int memoriesCount;
    public Animator animator;

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
            if (Artifact == 8) 
            {
                FindObjectOfType<AudioManager>().Play("TheTragicEnd");
            }
            if (Artifact == 3)
            {
                FindObjectOfType<AudioManager>().Play("ScreamsOfLoss");
            }
            if (Artifact == 5)
            {
            FindObjectOfType<AudioManager>().Play("CryingofLoss");
            }
            animator.SetFloat("Artifacts", Artifact);
    }

}
