using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Ink.Runtime;
using UnityEngine.EventSystems;

public class DialogueManager : MonoBehaviour
{
    [Header("Params")]
    [SerializeField] private float typingSpeed = 0.04f;

    [Header("Dialogue UI")]
    [SerializeField] private GameObject speechPanel;
    [SerializeField] private GameObject portrait;
    [SerializeField] private GameObject infoPanel;
    [SerializeField] private TextMeshProUGUI speechText;
    [SerializeField] private TextAsset inkJSON;
    [SerializeField] private TextMeshProUGUI portraitText;
    [SerializeField] private TextMeshProUGUI observationsText;
    [SerializeField] private Animator portraitAnimator;

    [Header("Choices UI")]
    [SerializeField] private GameObject[] choices;
    private TextMeshProUGUI[] choicesText;

    [Header("Load Globals JSON")]
    [SerializeField] private TextAsset loadGlobalsJSON;

    [Header("Ink tags")]
    private const string POPUP_TAG = "popup";
    private const string OBSERVATION_TAG = "observations";
    private const string PORTRAIT_TEXT = "portraitText";
    private const string PORTRAIT_IMG = "portraitImg";

    private Story currentStory;

    private bool dialogueIsPlaying;

    private bool textAdvancePressed;

    private bool canContinueToNextLine = false;

    private Coroutine displayLineCoroutine;

    private DialogueVariables dialogueVariables;

    private static DialogueManager instance;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Found more than one Dialogue Manager in the scene.");
        }
        instance = this;

        dialogueVariables = new DialogueVariables(loadGlobalsJSON);
    }

    public static DialogueManager GetInstance()
    {
        return instance;
    }

    public void Start()
    {
        dialogueIsPlaying = true;

        // get all of the choices text
        choicesText = new TextMeshProUGUI[choices.Length];
        int index = 0;
        foreach (GameObject choice in choices)
        {
            choicesText[index] = choice.GetComponentInChildren<TextMeshProUGUI>();
            index++;
        }
        EnterDialogueMode(inkJSON);
    }

    private void Update()
    {
        // return right away if dialogue isn't playing
        if (!dialogueIsPlaying)
        {
            return;
        }
    }

    public void EnterDialogueMode(TextAsset inkJSON)
    {
        currentStory = new Story(inkJSON.text);
        dialogueIsPlaying = true;
        ContinueStory(); 

        dialogueVariables.StartListening(currentStory);
    }

    private void ExitDialogueMode()
    {
        speechText.text = "";
        dialogueIsPlaying = false;
        dialogueVariables.StopListening(currentStory);
    }

    public void TextAdvance()
    {
        textAdvancePressed = true;
        if (canContinueToNextLine
            && currentStory.currentChoices.Count == 0)
        {
            ContinueStory();
        }
    }
    public void ContinueStory()
    {
        if (currentStory.canContinue)
        {
            if (displayLineCoroutine != null)
            {
                StopCoroutine(displayLineCoroutine);
            }
            Debug.Log("handling tags");
            textAdvancePressed = false;
            displayLineCoroutine = StartCoroutine(DisplayLine(currentStory.Continue()));
        }
        else
        {
            Debug.LogWarning("No more lines");
        }
    }

    private void HandleTags(List<string> currentTags)
    {
        // loop through each tag and handle it accordingly
        foreach (string tag in currentTags)
        {
            // split tag into key/value pair
            string[] splitTag = tag.Split(':');
            if (splitTag.Length != 2)
            {
                Debug.LogError("Tag could not be appropriately split: " + tag);
            }
            string tagKey = splitTag[0].Trim();
            string tagValue = splitTag[1].Trim();

            // handle the tag
            switch (tagKey)
            {
                case PORTRAIT_TEXT: // For some reason, this only applies the line after the tag.
                    Debug.Log(tagValue);
                    portraitText.text = tagValue;
                    break;
                case OBSERVATION_TAG:
                    if (tagValue == "empty")
                    {
                        observationsText.text = "";
                        infoPanel.SetActive(false);
                        break;
                    }
                    else
                    {
                        Debug.Log(tagValue);
                        infoPanel.SetActive(true);
                        observationsText.text += " " + tagValue;
                        break;
                    }
                case PORTRAIT_IMG:
                    if (tagValue == "none")
                    {
                        portrait.SetActive(false);
                        break;
                    }
                    else
                    {
                        Debug.Log(tagValue);
                        portrait.SetActive(true);
                        portraitAnimator.Play(tagValue);
                        break;
                    }
                default:
                    Debug.LogWarning("Tag came in but is not currently being handled: " + tag);
                    break;
            }
        }
    }

    private IEnumerator DisplayLine(string line)
    {
        // empty the speech text
        speechText.text = line;
        speechText.maxVisibleCharacters = 0;
        canContinueToNextLine = false;
        HandleTags(currentStory.currentTags);
        HideChoices();
         
        bool isAddingRichTextTag = false;

        // display each letter one at a time
        foreach (char letter in line.ToCharArray())
        {
            
            if (textAdvancePressed)//if (InputManager.GetInstance().GetSubmitPressed())
            {
                speechText.maxVisibleCharacters = line.Length;
                textAdvancePressed = false;
                break;
            }

            // check for rich text tag, if found, add it without waiting
            if (letter == '<' || isAddingRichTextTag)
            {
                isAddingRichTextTag = true;
                speechText.text += letter;
                if (letter == '>')
                {
                    isAddingRichTextTag = false;
                }
            }

            else
            {
                speechText.maxVisibleCharacters++;
                yield return new WaitForSeconds(typingSpeed);
            }

        }
        // display choices, if any, for this dialogue line
        DisplayChoices();
        canContinueToNextLine = true;
    }

    private void DisplayChoices()
    {
        List<Choice> currentChoices = currentStory.currentChoices;

        // defensive check to make sure our UI can support the number of choices coming in
        if (currentChoices.Count > choices.Length)
        {
            Debug.LogError("More choices were given than the UI can support. Number of choices given: "
                + currentChoices.Count);
        }

        int index = 0;
        // enable and initialize the choices up to the amount of choices for this line of dialogue
        foreach (Choice choice in currentChoices)
        {
            choices[index].gameObject.SetActive(true);
            choicesText[index].text = choice.text;
            index++;
        }
        // go through the remaining choices the UI supports and make sure they're hidden
        for (int i = index; i < choices.Length; i++)
        {
            choices[i].gameObject.SetActive(false);
        }
    }

    private void HideChoices()
    {
        foreach (GameObject choiceButton in choices)
        {
            choiceButton.SetActive(false);
        }
    }

    public void MakeChoice(int choiceIndex)
    {
        if (canContinueToNextLine)
        {
            currentStory.ChooseChoiceIndex(choiceIndex);
            InputManager.GetInstance().RegisterSubmitPressed();
            ContinueStory();
        }
    }
    public Ink.Runtime.Object GetVariableState(string variableName)
    {
        Ink.Runtime.Object variableValue = null;
        dialogueVariables.variables.TryGetValue(variableName, out variableValue);
        if (variableValue == null)
        {
            Debug.LogWarning("Ink Variable was found to be null: " + variableName);
        }
        return variableValue;
    }
}
