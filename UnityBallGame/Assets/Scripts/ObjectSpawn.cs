using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class ObjectSpawn : MonoBehaviour {
    public GameObject[] spawnedObjs;//the array of 6 objects that will spawn in
    public GameObject currObj;//the current object that is spawned in.
    private GameObject target;//the object that has been chosen to be the target object the player will try and match
    private GameObject starting = null;
    private int index;//the index of which the target is located in the spawnedObjs array

    //this is the int that shows how many time the user hasn't pressed space when the wrong item shows up
    private int winStrk;
    private bool winStrkIncrease;//increases user's score
    //refrence to the canvas
    public GameObject hub;
    Transform scoreText;//the score
    Transform shownTarget;//message that tells user this is the target
    Transform wrongTarget;//this tells user they hit the wrong target
    Transform hitTarget;//tells user they got the right target

    //this is the time for spawning 
    private float timeSpawned = 2f;
    private int trialsLeft = 0;//the number of trials left.
    private int numThings;
    private bool startDone;
    private bool ballRemove;//tells if a ball can be removed.

    private ScoreManager scoring;//will be the access to increasing or decreasing score
    private int score;//the total score of the player
    private int loseStreak;//how many times the player has pressed space when it was not the target

    private bool spacePressed;//tells if the space bar was pressed when the target comes up
                              //public GameObject trialKeeper;//refrence to the object that holds the number of trials
                              //private TrialObject trialObj;//refrence to the trialObject script

    private bool gameOver;//tells if the game is over.


    //showing score
    Text showScore;
    Text showT;
    Text wrongT;
    Text hitT;
    public float time;//the current time in the 3second cycle
    //TrialSelect trials;//the number of trials the user has selected.
    List<GameObject> balls = new List<GameObject>();

    GameObject trialSet;//trialsetter gameobject

	// Use this for initialization
	void Start () {

        //trialKeeper = GameObject.Find("TrialSetter");
        //trialObj = trialKeeper.GetComponent<TrialObject>();

        //start off by chosing a target object from the array.
        index = Random.Range(0, 6);//choosing the index for the random object that will be the target
        target = spawnedObjs[index];//getting the target object 
       // trialsLeft = this.GetComponent<TrialObject>().GameTrials();//the number of cycles there will be

        trialSet = GameObject.Find("TrialSetter");
        trialsLeft = trialSet.GetComponent<TrialObject>().GameTrials();
        //trialsLeft = 2;
        starting = (GameObject)Instantiate(spawnedObjs[index], new Vector3(0, 0, 0), target.transform.rotation);
        scoring = this.GetComponent<ScoreManager>();

        hub = GameObject.Find("Canvas");
        scoreText = hub.GetComponent<Transform>().GetChild(0);
        shownTarget = hub.GetComponent<Transform>().GetChild(1);
        wrongTarget=hub.GetComponent<Transform>().GetChild(2);
        hitTarget= hub.GetComponent<Transform>().GetChild(3);
        //by default lose streak is 0
        loseStreak = 0;
        winStrkIncrease = false;

        score = 300;//the player starts out with 300 at the start.
        startDone = false;//if the start of the game(showing the target) has been done
        time = 0f;
        MakingCycle();//adding the objects to thelist. 
        ballRemove = false;
        spacePressed = false;

        showScore = GetComponent<Text>();
        showT = GetComponent<Text>();
        wrongT = GetComponent<Text>();
        hitT = GetComponent<Text>();


        gameOver = false;//game starts off true
    }
	
	// Update is called once per frame
	void Update () {
        time += Time.deltaTime;
        //Debug.Log(scoreText);
        Text tempText = scoreText.GetComponent<Text>();
        //Debug.Log(tempText);
        tempText.text = "Score: " + score;
        //showScore.text = "Score: " + score;
        if (startDone == false)
        {
            Destroy(starting, timeSpawned);
            if(time >=0 && time <= 2)
            {
                showT = shownTarget.GetComponent<Text>();
                showT.text = "This is the target";
            }

        }
        if(time >= 3f)
        {
            //once the starting target has despawned, the user will be able to hit the spacebar
            startDone = true;
            //  time = 0f;
            Text tarText = shownTarget.GetComponent<Text>();
            tarText.text = "";
        }
        //Debug.Log(time);
        //while the game is going, display the objects
        if (gameOver == false)
        {

            SpawningObjects();
        }
        else if (gameOver == true)
        {
            //game over code
            Application.LoadLevel("FinishGame");
        }
        
    }

    public int FinalScore()
    {
        return score;
    }

    /// <summary>
    /// Choosing objects from the array and adding them to a list
    /// based on the number of trials the user wants.
    /// Will then add a certain amount of targets to the list.
    /// </summary>
    void MakingCycle()
    {
        Debug.Log("there are " + trialsLeft);
        if(trialsLeft == 0)//setting default number of trials to 2 trials
        {
            trialsLeft = 2;
        }
        int targetsIn = 0;//the number of targets that are in the cycle. There will
        int numTar = Random.Range(1, trialsLeft + 1);//the number of possible targets there can be
        for (int f = 0; f < trialsLeft; f++)
        {
            List<GameObject> ballIndex = new List<GameObject>();//there is 6 position indecies
            for (int i = 1; i < 7; i++)
            {
                //adding a random object in
                int pos = Random.Range(0, spawnedObjs.Length);
                GameObject GO = spawnedObjs[pos];
                // while (balls.Contains())
                //ballIndex.Add(pos);
                
                while (ballIndex.Contains(GO))//if there is already that ball in a cycle then choose another number
                {
                    pos = Random.Range(0, spawnedObjs.Length);
                    GO = spawnedObjs[pos];
                }
                    if (GO == spawnedObjs[index])//if  object is the same as the target
                    {
                    if (targetsIn == 0)
                    {
                        balls.Add(GO);
                        ballIndex.Add(GO);
                        targetsIn++;
                    }
                        else if (targetsIn < numTar )//if there is enough room to add another target
                        {
                            balls.Add(GO);
                        ballIndex.Add(GO);
                        targetsIn++;
                        }
                        else if(targetsIn >= numTar)//if there is already too many targets, choose another number
                        {
                            while(pos == index)//keep chosing a new target until one has been chosen
                            {
                                pos = Random.Range(0, spawnedObjs.Length);
                            GO = spawnedObjs[pos];
                        }
                            balls.Add(GO);//adding it to the list if is not the target.
                        ballIndex.Add(GO);
                    }
                        
                    }
                    else
                    {
                        balls.Add(GO);
                    ballIndex.Add(GO);
                }
            }
            Debug.Log(balls.Count);
            //refreshing the list
            ballIndex.Clear();
        }
    }

    //used for spawning in the object
    public void SpawningObjects()
    {


        //Debug.Log("HERE I AM");
        if (balls.Count <= 0)
        {
            gameOver = true;
            
        }
        else if (balls.Count > 0 && gameOver==false && startDone==true )
        {
      
            //Debug.Log("COUNT WORKS");
            if (time >= 3f)
            {
                //Debug.Log("IN THE 3");
                time = 0f;
                currObj = (GameObject)Instantiate(balls[0], new Vector3(0, 0, 0), balls[0].transform.rotation);
                ballRemove = true;
               spacePressed = false;//resetting it so user can press space again
                winStrkIncrease = false;//reset score increase;
                Debug.Log(balls.Count);
            }
           else if (time >= 2f && ballRemove==true)
            {
                //spacePressed = false; 
                Destroy(currObj);
                balls.Remove(balls[0]);//removing the first object in the list and shifting the other objects down
                ballRemove = false;
                //Debug.Log("STUFF 2");
                //resetting textboxes
                Text tarText = hitTarget.GetComponent<Text>();
                tarText.text = "";
                Text tarText2 = wrongTarget.GetComponent<Text>();
                tarText2.text = "";
            }

            //if the space bar is pressed within the time the ball is on the screen
            if (Input.GetKey("space") && spacePressed == false && (time >= 0 && time <= 2))
            {
               // Debug.Log("WE'RE HERE");
                // if (spacePressed == false)//if the spacebar has not been pressed yet for that ball
                //{
                if (spawnedObjs[index] == balls[0])//if it is the target and the space bar hasnt been pressed for that target yet.
                {
                    score += scoring.TargetScore();//will increase score when they press it(more if faster)
                    spacePressed = true;
                    //this is for telling the user the tart was hit
                    Text tarText = hitTarget.GetComponent<Text>();
                    tarText.text = "WOW! You hit a target!";
                }
                else if (currObj != target)
                {
                    loseStreak++;
                    score -= scoring.ScoreDecrease(loseStreak);
                    spacePressed = true;
                    //this is for telling the user they hit the wrong user
                    Text tarText = wrongTarget.GetComponent<Text>();
                    tarText.text = "Woops! That is not the target!";
                    winStrk = 0;//reset winStreak
                }
                
                //}
            }
            else if(Input.GetKey("space") != true && time >= 2 && winStrkIncrease == false && spacePressed==false)
            {
                if(target == balls[0])//if user doesn't hit trarget, the winstreak resets
                {
                    winStrk = 0;
                }
                else if(currObj != target)
                {
                    //increasing score if the wrong object is not hit
                    winStrk++;
                    score += scoring.IncreaseOverTime(winStrk);
                    winStrkIncrease = true;
                }
            }
        }
       
    }

    /// <summary>
    /// used for showing the final score
    /// </summary>
    /// <returns></returns>
    public int ShowingScore()
    {
        return score;
    }

   
}
