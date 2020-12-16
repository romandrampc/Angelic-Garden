using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Linq;

[RequireComponent(typeof(Text))]

public class DialogueErin1 : MonoBehaviour {

    private Text _textComponent;

    public string[] DialogueStrings;
    public float SecondsBetweenCharacters = 0.1f;
    public float CharacterRateMutiplier = 0.3f;

    public KeyCode DialogueInput = KeyCode.Return;

    private bool _isStringBeingReveled = false;
    private bool _isDialoguePlaying = false ;
    private bool _isEndOfDialogue = false;

    public GameObject ContinueIcon;
    public GameObject StopIcon;
    public GameObject player;
    public GameObject QA;
    public GameObject Dialogue1;
    public GameObject ADialogue;



    public int c;
   
    // Use this for initialization
    void Start() {
        _textComponent = GetComponent<Text>();
        _textComponent.text = "";
        HideIcon();
        c = DialogueStrings.Count();

    }
	
	// Update is called once per frame
	void Update () {

        
      
            if (Input.GetKeyDown(KeyCode.Return))
            {
                
            if (!_isDialoguePlaying)
                {
                        if (c == DialogueStrings.Count())
                        {
                             _isDialoguePlaying = true;
                            StartCoroutine(StartDialogue());
                            c--;
                            Debug.Log(c);
                        }
                else
                {

                    Dialogue1.SetActive(false);
                    QA.SetActive(true);
                }
            }
            
        }
        
        
            		
	}


    private IEnumerator StartDialogue()
    {
        int dialogueLength = DialogueStrings.Length;
        int currentDialogueIndex = 0;

        while (currentDialogueIndex < dialogueLength || !_isStringBeingReveled)
        {
           
            if (!_isStringBeingReveled)
            {
                _isStringBeingReveled = true;
                StartCoroutine(DisplayString(DialogueStrings[currentDialogueIndex++]));
                if (currentDialogueIndex >= dialogueLength)
                {
                    _isEndOfDialogue = true;
                    
                }
            }

            yield return 0;
        }

        while (true)
        {
            if (Input.GetKeyDown(DialogueInput))
            {
                break;
            }

            yield return 0;
        }

        HideIcon();
        _isEndOfDialogue = false;
        _isDialoguePlaying = false;
    }

    private IEnumerator DisplayString(string stringToDisplay)
    {
        int stringLength = stringToDisplay.Length;
        int CurrentCharacterIndex = 0;

        _textComponent.text = "";

        while (CurrentCharacterIndex < stringLength)
        {
            _textComponent.text += stringToDisplay[CurrentCharacterIndex];
            CurrentCharacterIndex++;

            if (CurrentCharacterIndex < stringLength)
            {
                if (Input.GetKey(DialogueInput))
                {
                    yield return new WaitForSeconds(SecondsBetweenCharacters * CharacterRateMutiplier);
                }
                else
                {
                    yield return new WaitForSeconds(SecondsBetweenCharacters);
                }
                
            }
            else
            {
                break;
            }
        }

        while (true)
        {
            if (Input.GetKeyDown(DialogueInput))
            {
                break;
            }
            yield return 0;
        }

        _isStringBeingReveled = false;
        _textComponent.text = "";
    }

    private void HideIcon()
    {
        ContinueIcon.SetActive(false);
        StopIcon.SetActive(false);
    }

    private void ShowIcon()
    {
        if (_isEndOfDialogue)
        {
            StopIcon.SetActive(true);
            return;
        }
        ContinueIcon.SetActive(true);
    }

    
}


