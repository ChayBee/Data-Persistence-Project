using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public void StartGame()
    {
        GameObject inputField = GameObject.Find("InputField (TMP)");
        PersistenceManager.instance.name = inputField.GetComponent<TMP_InputField>().text;

        SceneManager.LoadScene(0);
    }
}
