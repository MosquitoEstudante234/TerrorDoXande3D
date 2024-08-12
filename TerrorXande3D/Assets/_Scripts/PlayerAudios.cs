using UnityEngine;

public class PlayerAudios : MonoBehaviour
{
    public GameObject[] playerAudios = new GameObject[0];
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D))
        {
            playerAudios[0].SetActive(true);
        }
        else
        {
            playerAudios[0].SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {

        }
    }
}