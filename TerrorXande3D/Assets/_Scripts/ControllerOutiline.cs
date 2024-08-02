using UnityEngine;

public class ControllerOutiline : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            gameObject.GetComponent<Outline>().enabled = true;
        }
        if (Input.GetButtonUp("Jump"))
        {
            gameObject.GetComponent<Outline>().enabled = false;
        }
    }
}
