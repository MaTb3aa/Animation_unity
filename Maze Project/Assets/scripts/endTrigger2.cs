using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endTrigger2 : MonoBehaviour
{

    private void OnTriggerEnter()
    {
        SceneManager.LoadScene("end");
    }
}
