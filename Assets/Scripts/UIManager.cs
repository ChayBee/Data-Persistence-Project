using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartGame();
        }
    }

    public void StartGame()
    {
        // get the text from the input field and save it to the persistence manager
        GameObject inputField = GameObject.Find("InputField (TMP)");
        PersistenceManager.instance.name = inputField.GetComponent<TMP_InputField>().text;

        // load the main scene
        SceneManager.LoadScene(0);
    }
}
