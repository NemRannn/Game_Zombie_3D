using UnityEngine;

public class Objective2Trigger : MonoBehaviour
{
    public float radius = 100f; 
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            
           
            Collider[] hitColliders = Physics.OverlapSphere(transform.position, radius);
            foreach (var hitCollider in hitColliders)
            {
                if (hitCollider.gameObject.tag == "Hostage")
                {
                    Destroy(hitCollider.gameObject);
                }
            }
            Destroy(gameObject, 2f);
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, radius);
    }
}
