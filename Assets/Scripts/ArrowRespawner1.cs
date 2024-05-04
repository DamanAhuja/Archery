using UnityEngine;

public class Respawn1 : MonoBehaviour
{
    private Vector3 bowPositionAtCollision;
    public GameObject Arrow;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Target"))
        {
            if (!Arrow.activeSelf)
            {
                Arrow.SetActive(true);
            }
            bowPositionAtCollision = FindObjectOfType<BowMovement>().transform.position;

            Arrow.transform.position = bowPositionAtCollision;

            BowMovement bowMovement = Arrow.GetComponent<BowMovement>();
            if (bowMovement != null)
            {
                bowMovement.enabled = true;
            }
        }
    }
}
