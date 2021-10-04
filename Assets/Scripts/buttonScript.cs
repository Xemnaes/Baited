using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class buttonScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Button btn = gameObject.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame (currently unused)
    void Update()
    {
        // TODO Update?    
    }

    void TaskOnClick()
    {
        Debug.Log("You have clicked " + gameObject.name);
        switch (gameObject.name)
        {
            case "startGameButton":
                SceneManager.LoadScene("DebateScene");
                break;
            case "exitGameButton":
                Application.Quit();
                break;
            case "readyButton":
                Destroy(GameObject.Find("readyOverlay"));
                Destroy(gameObject);

                GameObject EventSys = GameObject.Find("EventSystem");
                EventSys.GetComponent<debateStateScript>().beginDebate();

                //TODO Destroy object and initiate Debate logic
                break;
            case "yesButton":
                SceneManager.LoadScene("DebateScene");
                break;
            case "noButton":
                SceneManager.LoadScene("MainMenuScene");
                break;
            default:
                Debug.LogError("Invalid button click (did you forget to add a button case?");
                break;
        }
    }

    private void OnMouseOver()
    {
        Debug.Log("hahahahah");
    }
}
