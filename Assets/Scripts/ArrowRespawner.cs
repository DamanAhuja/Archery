using UnityEngine;
using UnityEngine.SceneManagement;

public class Respawn : MonoBehaviour
{
    private Vector3 bowPositionAtCollision;
    public GameObject arrow;
    private Rigidbody2D rb;
    private static int x = 0;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Target"))
        {
            if (UIManager.count == 0)
            {
                SceneManager.LoadScene("Result");
            }
            if (!arrow.activeSelf)
            {
                arrow.SetActive(true);
            }
            
            rb = GetComponent<Rigidbody2D>();
            rb.velocity = Vector2.zero; 
            
            Arrow launch = GetComponent<Arrow>();
            launch.enabled = false;

            BowMovement bowMovement = arrow.GetComponent<BowMovement>();
            if (bowMovement != null)
            {
                bowMovement.enabled = true;
            }

            Arrow launch2 = arrow.GetComponent<Arrow>();
            
            if (launch2.enabled == false)
            {
                launch2.enabled = true;
            }
        }
        
        if (other.CompareTag("7"))
        {
            Debug.Log("" + x);
            UIManager.AddScore(7);
            if (x == 7)
            {
                UIManager.arrowinc(2);
                Debug.Log("2 arrows increased");
            }
            else
            {
                UIManager.arrowinc(1);
                Debug.Log("1 arrow increased");
                x = 7;
            }
        }
        
        if (other.CompareTag("6"))
        {
            UIManager.AddScore(6);
            x = 6;
        }
        
        if (other.CompareTag("5"))
        {
            UIManager.AddScore(5);
            x = 5;
        }
        
        if (other.CompareTag("4"))
        {
            UIManager.AddScore(4);
            x = 4;
        }
        
        if (other.CompareTag("3"))
        {
            UIManager.AddScore(3);
            x = 3;
        }
        
        if (other.CompareTag("2"))
        {
            UIManager.AddScore(2);
            x = 2;
        }
        
        if (other.CompareTag("1"))
        {
            UIManager.AddScore(1);
            x = 1;
        }
    }
}
