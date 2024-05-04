using UnityEngine;

public class Arrow : MonoBehaviour
{
    public float launchSpeed = 10f;

    public GameObject arrow;
    private Rigidbody2D arrowRigidbody;
    private BowMovement arrowMovementScript;
    private BowMovement bowMovement;
    //private GameObject bow;

    void Start()
    {
        arrowRigidbody = GetComponent<Rigidbody2D>();
        arrowMovementScript = GetComponent<BowMovement>();
        //bow = GameObject.Find("Bow");
    }

    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began || Input.GetKeyDown(KeyCode.Space)) 
        {
            BowMovement.speed *= 1.1f;
            //BowMovement bowMovement = bow.GetComponent<BowMovement>();
            //bowMovement.speed *= 1.2f;

            //arrowMovementScript.speed *= 1.2f;
            
            //BowMovement arrow2 = arrow.GetComponent<BowMovement>();
            //arrow2.speed *= 1.2f;

            arrow.SetActive(false);
            
            arrowMovementScript.enabled = false;

            arrowRigidbody.velocity = new Vector2(launchSpeed,0);

            UIManager.arrowdec(1);
        }
    }
}

