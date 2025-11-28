using UnityEngine;
using System.Collections;

public class FireballController : MonoBehaviour
{
    public float lifeTime = 5f;           // Sécurité au cas où elle ne touche rien
    public GameObject hitEffectPrefab;    // Optionnel : particules d'impact

    IEnumerator Start()
    {
        Collider col = GetComponent<Collider>();
        col.enabled = false;
        yield return new WaitForSeconds(0.5f);
        col.enabled = true;
                // Détruire automatiquement après X secondes
        Destroy(gameObject, lifeTime);
    }
    


    void OnCollisionEnter(Collision collision)
    {
        // Effet d'impact (particules, flash, etc.)
        if (hitEffectPrefab != null)
        {
            Vector3 hitPos = collision.GetContact(0).point;
            Instantiate(hitEffectPrefab, hitPos, Quaternion.identity);
        }

        // Récupérer l'objet touché
        GameObject other = collision.collider.attachedRigidbody
            ? collision.collider.attachedRigidbody.gameObject
            : collision.collider.gameObject;

        // S’il a un certain tag → on le détruit
        if (other.CompareTag("DestroyOnHit"))
        {
            Destroy(other);
        }

        // Détruire la boule de feu
        Destroy(gameObject);
    }
}
