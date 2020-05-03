using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class start_button_script : MonoBehaviour
{
    public void StartGame ()
    {
      SceneManager.LoadScene("Scene01");
    }
}
