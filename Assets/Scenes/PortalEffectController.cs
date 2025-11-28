using UnityEngine;
using static GestureRecognition;

public class PortalEffectController : MonoBehaviour
{
    // 🆕 Porte actuellement "active"
    public static PortalEffectController activeDoor;

    public MeshRenderer meshRenderer;

    public GameObject fireballPrefab;
    public Transform firePoint;    
    public Transform playerHead;   // 🎯 LA CAMÉRA VR !
    public float fireForce = 10f;

    public GameObject wallToDestroy;

    public void OnGestureCompleted(GestureCompletionData data)
    {

        Debug.Log($"Geste reconnu: ID={data.gestureID}, Similarité={data.similarity}");
        // 🆕 Si ce n'est pas la porte active, on ignore le geste
        

        if (data.gestureID == 0 && data.similarity > 0.3f)
        {
            HideElement1();
        }

        if (data.gestureID == 1 && data.similarity > 0.3f)
        {
            LaunchFireball();
        }
    }

    private void HideElement1()
    {
        var mats = meshRenderer.materials;

        if (mats.Length > 1)
        {
            Material[] newMats = new Material[] { mats[0] };
            meshRenderer.materials = newMats;
        }

        if (wallToDestroy != null)
        {
            Destroy(wallToDestroy);
        }
    }

    private void LaunchFireball()
    {
        Debug.Log("🔥 FIREBALL!");

        GameObject fireball = Instantiate(fireballPrefab, firePoint.position, playerHead.rotation);

        Rigidbody rb = fireball.GetComponent<Rigidbody>();
        rb.linearVelocity = playerHead.forward * fireForce; // ou rb.velocity
    }

    // 🆕 Appelé par la trigger zone
    public void SetActive(bool isActive)
    {
        if (isActive)
        {
            activeDoor = this;
        }
        else
        {
            if (activeDoor == this)
                activeDoor = null;
        }
    }
}
