using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    public float moveSpeed = 5f;
    public GameObject finishMessage;
    private AudioSource myAudio;
    public GameObject[] allCookies;
    public int cookiesCollected = 0;
    public TextMeshProUGUI cookiesDisplay;

    private Rigidbody2D myRigidbody;

    

    // Start is called before the first frame update
    void Start()
    {
        allCookies = GameObject.FindGameObjectsWithTag("Cookie");
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
            // Quaternion rotation = Quaternion.EulerAngles(0,0,180);
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

        

        // if(allCookiesCount.Length == 0) 
        // {
        //     print("You won! Cookies: " + allCookiesCount);
        //     Instantiate(finishMessage);
        // }
    }


    void OnTriggerEnter2D(Collider2D coll) {
        if(coll.gameObject.tag.Equals("Cookie")) {
            cookiesCollected += 1;
            Destroy(coll.gameObject);
            myAudio.Play(); 
            // print(cookiesCollected);
            cookiesDisplay.text = cookiesCollected.ToString();
        }



        // if(cookiesCollected == 5)
        //     {
        //         Instantiate(finishMessage);
        //     }

        // foreach (GameObject cookie in allCookies)
        //     {
        //         if(cookie == null) 
        //             {
                        
        //             }
        //         print(allCookies);
        //     // print("You won! Cookies: " + .Length);
                
        //     }

    }

}
