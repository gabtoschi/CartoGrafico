using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

/* A singleton that manages all questions in a level of the game. */
public class QuestionManager : MonoBehaviour
{

    [HideInInspector] public static QuestionManager instance;

    [Header("Question Pack References")]
    public string packFilename;
    public char[] checker;
    public QuestionPack currentPack;

    [Header("Question Manager Variables")]
    public int nextQuestion = -1;

    private string checkerSuffix = "-checker";
    private bool packIsReady = false;
    private char usedToken = 't';
    private char notUsedToken = 'f';

    /* In the instant that the object are instantiated, this method is called. */
    void Awake()
    {
        // creating a singleton instance
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);

        DontDestroyOnLoad(gameObject);

        loadQuestionPackFile();
    }

    /* Load a question pack by a JSON file. */
    public void loadQuestionPackFile()
    {
        // load the file content to a variable
        TextAsset txtAsset = Resources.Load(packFilename) as TextAsset; 
        Debug.Log(txtAsset);
        string dataAsJson = txtAsset.text;

        // get packs and questions
        currentPack = JsonUtility.FromJson<QuestionPack>(dataAsJson);
        shuffleQuestions();

        Debug.Log("Pack '" + currentPack.name + "' opened.");

        // checking used questions string for this pack
        if (PlayerPrefs.HasKey(packFilename + checkerSuffix))
        {
            Debug.Log("checker for " + packFilename + " exists in playerprefs");

            // get current checker
            checker = PlayerPrefs.GetString(packFilename + checkerSuffix).ToCharArray();
            Debug.Log(PlayerPrefs.GetString(packFilename + checkerSuffix));

            // if the length of the checker is less than the number of questions, update it
            if (checker.Length != currentPack.capacity)
                createChecker();

        }
        else
        {
            // create a new checker
            Debug.Log("checker for " + packFilename + " DON'T exists in playerprefs");
            createChecker();
            saveChecker();
        }

        Debug.Log(StringTools.charArrayToString(checker));
        packIsReady = true;
    }

    /* Shuffle the Question array inside the current pack. */
    private void shuffleQuestions()
    {
        for (int t = 0; t < currentPack.capacity; t++)
        {
            Question tmp = currentPack.questions[t];
            int r = Random.Range(t, currentPack.capacity);
            currentPack.questions[t] = currentPack.questions[r];
            currentPack.questions[r] = tmp;
        }
    }

    /* Create a new checker (full with not-used tokens) to the current pack. */
    private void createChecker()
    {
        checker = new char[currentPack.capacity];
        for (int i = 0; i < currentPack.capacity; i++) checker[i] = notUsedToken;
    }

    /* Return true if the indicate question have already been used. */
    private bool isQuestionUsed(int id)
    {
        return checker[id] == usedToken ? true : false;
    }

    /* Marks in the checker that a question has used. */
    private void useQuestion(int id)
    {
        checker[id] = usedToken;
    }

    /* Save the current checker in the system. */
    private void saveChecker()
    {
        PlayerPrefs.SetString(packFilename + checkerSuffix, StringTools.charArrayToString(checker));
        PlayerPrefs.Save();
    }

    /* When the checker is full, recreate them and reshuffle the pack. */
    private void resetChecker()
    {
        shuffleQuestions();
        createChecker();
        saveChecker();
        nextQuestion = 0;
        Debug.Log("checker reset: " + checker);
    }

    /* Return true if the manager finished the load pack process.*/
    public bool isReady()
    {
        return packIsReady;
    }

    /* Return the next question (and update the checker and pack if necessary) */
    public Question getNextQuestion()
    {
        if (nextQuestion >= currentPack.capacity) resetChecker();

        do
        {
            nextQuestion++;
            if (nextQuestion >= currentPack.capacity) resetChecker();
        } while (isQuestionUsed(currentPack.questions[nextQuestion].id));

        Question returnQuestion = currentPack.questions[nextQuestion];
        useQuestion(returnQuestion.id);
        nextQuestion++;
        saveChecker();

        Debug.Log("return question " + returnQuestion.question);

        return returnQuestion;
    }
}