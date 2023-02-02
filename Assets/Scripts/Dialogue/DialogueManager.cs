using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Ink.Runtime;
using UnityEngine.EventSystems;

public class DialogueManager : MonoBehaviour
{
    private static DialogueManager instance;
    #region Fields
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
    private const string MUSIC_TAG = "playMusic";
    private const string SFX_TAG = "playSFX";

    private Story currentStory;

    private bool dialogueIsPlaying;

    private bool textAdvancePressed;

    private bool canContinueToNextLine = false;

    private Coroutine displayLineCoroutine;

    private DialogueVariables dialogueVariables;

    #endregion
    private void Awake()
    {
        #region Static Instance
        if (instance != null)
        {
            Debug.LogWarning("Found more than one Dialogue Manager in the scene.");
        }
        instance = this;
        #endregion
        // Load dialogue variables
        dialogueVariables = new DialogueVariables(loadGlobalsJSON);
    }

    public static DialogueManager GetInstance()
    {
        return instance;
    }

    public void Start()
    {
        dialogueIsPlaying = true;

        // Get all of the choices text
        choicesText = new TextMeshProUGUI[choices.Length];
        int index = 0;
        foreach (GameObject choice in choices)
        {
            choicesText[index] = choice.GetComponentInChildren<TextMeshProUGUI>();
            index++;
        }
        EnterDialogueMode(inkJSON); // to test: unsure if necessary
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
        // Initialize story from inkJSON
        currentStory = new Story(inkJSON.text);
        dialogueIsPlaying = true;
        ContinueStory(); 

        // Check variables in the ink story file
        dialogueVariables.StartListening(currentStory);
    }

    private void ExitDialogueMode() // to test: unsure if this is necessary
    {
        speechText.text = "";
        dialogueIsPlaying = false;
        dialogueVariables.StopListening(currentStory);
    }

    public void TextAdvance()
    {
        textAdvancePressed = true;
        // Check if there's no choices on the screen and if the player can continue
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
            if (displayLineCoroutine != null) // Stop coroutine if it already is playing
            {
                StopCoroutine(displayLineCoroutine);
            }
            textAdvancePressed = false; // i dont really understand why it needs to be changed specifically here
            displayLineCoroutine = StartCoroutine(DisplayLine(currentStory.Continue()));
        }
        else
        {
            Debug.LogWarning("No more lines");
        }
    }

    private void HandleTags(List<string> currentTags)
    {
        // Loop through each tag and handle it accordingly
        foreach (string tag in currentTags)
        {
            // Split tag into key/value pair
            string[] splitTag = tag.Split(':');
            if (splitTag.Length != 2)
            {
                Debug.LogError("Tag could not be appropriately split: " + tag);
            }
            string tagKey = splitTag[0].Trim();
            string tagValue = splitTag[1].Trim();
            #region Tags
            // Handle the tag
            switch (tagKey)
            {
                case PORTRAIT_TEXT:
                    // note: it's probably better to have a defensive check here in case i forget to change the portrait text but it shouldn't really come up
                    portraitText.text = tagValue;
                    break;
                case OBSERVATION_TAG:
                    if (tagValue == "empty")
                    {
                        // Reset text and set panel to inactive
                        observationsText.text = "";
                        infoPanel.SetActive(false);
                        break;
                    }
                    else
                    {
                        // Add whatever was in the tag onto the existing observations text and set the panel to active
                        infoPanel.SetActive(true);
                        observationsText.text += " " + tagValue;
                        break;
                        // to do: add pages to panel (probably in seperate script) and find a way to split different observations from the same tag
                    }
                case PORTRAIT_IMG:
                    if (tagValue == "none")
                    {
                        portrait.SetActive(false);
                        break;
                    }
                    else
                    {
                        // Set the portrait panel to active and change the portrait based on the tag value
                        portrait.SetActive(true);
                        portraitAnimator.Play(tagValue); // to test: game might crash if this throws an error
                        break;
                    }
                case MUSIC_TAG:
                    if (tagValue == "menuMusic")
                    {
                        AudioManagerTest.GetInstance().PlayMenuMusic();
                        break;
                    }
                    if (tagValue == "battleMusic")
                    {
                        AudioManagerTest.GetInstance().PlayBattleMusic();
                        break;
                    }
                    if (tagValue == "menuToBattleMusic")
                    {
                        AudioManagerTest.GetInstance().TransitionMenuToBattleMusic();
                        break;
                    }
                    else
                    {
                        break;
                    }
                case SFX_TAG:
                    if (tagValue == "stat_check_pass")
                    {
                        AudioManagerTest.GetInstance().PlayPassSFX();
                        break;
                    }
                    if (tagValue == "stat_check_fail")
                    {
                        AudioManagerTest.GetInstance().PlayFailSFX();
                        break;
                    }
                    if (tagValue == "yay")
                    {
                        AudioManagerTest.GetInstance().playYaySFX();
                        break;
                    }
                    if (tagValue == "encounterWin")
                    {
                        AudioManagerTest.GetInstance().WinEncounterSFX();
                        break;
                    }
                    else
                    {
                        break;
                    }
                default:
                    Debug.LogWarning("Tag came in but is not currently being handled: " + tag);
                    break;
            }
            #endregion
        }
    }

    private IEnumerator DisplayLine(string line)
    {
        // empty the speech text
        speechText.text = line;
        speechText.maxVisibleCharacters = 0;

        canContinueToNextLine = false; // Can't continue to next line until the coroutine is finished
        HandleTags(currentStory.currentTags);
        HideChoices();
        
        bool isAddingRichTextTag = false;

        // Display each letter one at a time
        foreach (char letter in line.ToCharArray())
        {
            // Skip the animation if the player presses the button after it starts
            if (textAdvancePressed)
            {
                speechText.maxVisibleCharacters = line.Length;
                textAdvancePressed = false;
                break;
            }

            // Check for rich text tag, if found, add it without waiting
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
                // Add a character to the line then add an interval between this and the next loop
                speechText.maxVisibleCharacters++;
                yield return new WaitForSeconds(typingSpeed);
            }

        }
        // Display choices, if any, for this dialogue line
        DisplayChoices();
        canContinueToNextLine = true;
    }

    private void DisplayChoices()
    {
        // to test: an option will have the selected option color seemingly at random. wtf???
        List<Choice> currentChoices = currentStory.currentChoices;

        // Defensive check to make sure our UI can support the number of choices coming in
        if (currentChoices.Count > choices.Length)
        {
            Debug.LogError("More choices were given than the UI can support. Number of choices given: "
                + currentChoices.Count);
        }

        int index = 0;
        // Enable and initialize the choices up to the amount of choices for this line of dialogue
        foreach (Choice choice in currentChoices)
        {
            choices[index].gameObject.SetActive(true);
            choicesText[index].text = choice.text;
            index++;
        }
        // Go through the remaining choices the UI supports and make sure they're hidden
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
            ContinueStory();
        }
    }
    public Ink.Runtime.Object GetVariableState(string variableName) // honestly i'm kind of confused as to how this works
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
