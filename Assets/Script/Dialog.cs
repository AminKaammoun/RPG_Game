using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialog : MonoBehaviour
{

    public GameObject dialogBox;
    public bool playerInRange;
    public Text text;
    public string dialog;
    public GameObject key;
    public bool keyPressed;
    public AudioSource Audio;
    private Animator animator;

    [SerializeField] private Texture2D NormalCursor;
    private Vector2 cursorHotspot;

    // Start is called before the first frame update
    void Start()
    {
        if (this.gameObject.tag == "blacksmith")
        {
            animator = GetComponent<Animator>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (playerInRange && keyPressed == false)
        {

            key.SetActive(true);

            if (Input.GetKeyDown(KeyCode.E))
            {
                text.text = dialog;
                dialogBox.SetActive(true);
                Audio.Play();
                keyPressed = true;
                key.SetActive(false);
            }
            {

            }
        }
        else if(playerInRange && keyPressed == true)
        {
            key.SetActive(false);
            dialogBox.SetActive(true);

        }
        else
        {
            key.SetActive(false);
            dialogBox.SetActive(false);
            keyPressed = false;
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerInRange = true;
            if(this.gameObject.tag == "blacksmith")
            {
                animator.SetBool("dialog", true);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerInRange = false;
            cursorHotspot = new Vector2(NormalCursor.width / 2, NormalCursor.height / 2);
            Cursor.SetCursor(NormalCursor, cursorHotspot, CursorMode.Auto);
            if (this.gameObject.tag == "blacksmith")
            {
                animator.SetBool("dialog", false);
            }
        }
    }


}
