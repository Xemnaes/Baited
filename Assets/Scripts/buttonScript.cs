using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class buttonScript : MonoBehaviour
{
    public GameObject button;
    // Start is called before the first frame update
    void Start()
    {
        button = gameObject;
        Button btn = button.GetComponent<Button>();
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
                SceneManager.LoadScene(sceneName: "DebateScene");
                break;
            case "exitGameButton":
                Application.Quit();
                break;
            case "readyButton":
                Destroy(GameObject.Find("readyOverlay"));
                Destroy(gameObject);

                //GameObject 

                //TODO Destroy object and initiate Debate logic
                break;
            default:
                Debug.LogError("Invalid button click (did you forget to add a button case?");
                break;
        }
    }

    private void OnMouseOver()
    {
        print("yeet");
    }
}
