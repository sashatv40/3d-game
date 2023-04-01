using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using StarterAssets;

public class Note : MonoBehaviour
{
    private bool inTrigger = false;


    [Header("Текст записки")]
    [TextArea(minLines: 10, maxLines: 20)] public string text;

    private CanvasGroup notePanel;
    private Text noteText;
    private GameObject player;
    private FirstPersonController fpc;
    // Start is called before the first frame update
    void Start()
    {
        notePanel = GameObject.FindGameObjectWithTag("NotePanel").GetComponent<CanvasGroup>();
        noteText = notePanel.GetComponentInChildren<Text>();
        player = GameObject.FindGameObjectWithTag("Player");
        fpc = player.GetComponent<FirstPersonController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && inTrigger == true && notePanel.alpha == 0)
        {
            OpenNote();
        }

        if (Input.GetKeyDown(KeyCode.Escape) && inTrigger == true && notePanel.alpha == 1)
        {
            CloseNote();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            inTrigger = true;
        }
    } 
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            inTrigger = false;
        }
    }
    private void OpenNote()
    {
        notePanel.alpha = 1;
        noteText.text = text;
        fpc.RotationSpeed = 0;
        fpc.MoveSpeed = 0;
    }

    private void CloseNote()
    {
        notePanel.alpha = 0;
        Destroy(gameObject);
        fpc.RotationSpeed = 4;
        fpc.MoveSpeed = 4;
    }
}
