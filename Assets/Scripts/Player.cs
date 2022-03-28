using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 5f;
    // public AudioClip crunchAudioClip;
    private AudioSource myAudio;

    private Rigidbody2D myRigidbody;

    [Header("-- Private references --")]
    [SerializeField] private int cookiesCollected = 0;
    [SerializeField] private GameObject winningFlag;

    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        myAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
        Vector3 newPosition = transform.position;
        // Quaternion newRotation = transform.rotation;
            if(Input.GetKey(KeyCode.A)) {
                // newPosition.x -= moveSpeed * Time.deltaTime;
                // Quaternion rotation = Quaternion.Euler(0,0,180);
                myRigidbody.velocity = new Vector2(-5, 0);
            }

            if(Input.GetKey(KeyCode.D)) {
                // newPosition.x += moveSpeed * Time.deltaTime;
                myRigidbody.velocity = new Vector2(5, 0);
            }

            if(Input.GetKey(KeyCode.W)) {
                // newPosition.y += moveSpeed * Time.deltaTime;
                myRigidbody.velocity = new Vector2(0, 5);
            }

            if(Input.GetKey(KeyCode.S)) {
                myRigidbody.velocity = new Vector2(0, -5);
                // newPosition.y -= moveSpeed * Time.deltaTime;
            }
        transform.position = newPosition;
    }

    // OnTriggerEnter2D is called once, when two GameObjects with Collider2Ds hit each other
        // - One GameObject must have a Rigidbody2D as well
        // - One of the Collider2Ds must be a Trigger
    void OnTriggerEnter2D(Collider2D coll) {
        if(coll.gameObject.tag.Equals("Cookie")) {
            cookiesCollected += 1;
            Destroy(coll.gameObject);
            myAudio.Play(); 
        }

        // if(coinsCollected == 3) {
        //     Instantiate(winningFlag);
        // }
    }

    // OnCollisionEnter2D is called once, when two GameObjects with Collider2Ds hit each other
        // - One GameObject must have a Rigidbody2D as well
    void OnCollisionEnter2D(Collision2D coll) {
        // if(coll.gameObject.tag.Equals("Finish")) {
        //     print("You have won the game!");
        // }
    }
}
