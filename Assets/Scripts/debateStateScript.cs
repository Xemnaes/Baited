using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class debateStateScript : MonoBehaviour
{
    GameObject eli, enemy;

    public enum Stage { Planning, Resolution };
    public enum Debator { Eli, Enemy};

    private int currentRound;
    private Stage currentStage;
    private Debator currentDebator;
    private 

    // Start is called before the first frame update
    void Start()
    {
        //Initialize beginning debate state
        eli = GameObject.Find("eli");
        enemy = GameObject.Find("enemy");
        currentRound = 0;
        currentStage = Stage.Planning;
        currentDebator = Debator.Eli;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void beginDebate()
    {
        planningStage();
    }

    private void planningStage()
    {
        //displayHand();

    }

    private void resolutionStage()
    {

    }

    private void checkEndState()
    {
        
    }

    public Stage getStage()
    {
        return currentStage;
    }

    public Debator getDebator()
    {
        return currentDebator;
    }

    private void setStage(Stage stage)
    {
        currentStage = stage;
    }

    private void setDebator(Debator debator)
    {
        currentDebator = debator;
    }

    private void incrementRound()
    {
        currentRound++;
        GameObject roundCounter = GameObject.Find("roundNumberText");
        roundCounter.GetComponent<UnityEngine.UI.Text>().text = currentRound.ToString();
    }
}
