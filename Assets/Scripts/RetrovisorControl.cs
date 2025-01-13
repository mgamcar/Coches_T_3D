using UnityEngine;

public class RetrovisorControl : MonoBehaviour
{
    [SerializeField] GameObject retrovisor;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)){
            retrovisor.SetActive(true);
        }

        if (Input.GetKeyUp(KeyCode.E)){
            retrovisor.SetActive(false);
        }
    }
}
