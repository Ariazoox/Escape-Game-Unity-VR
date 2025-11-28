using UnityEngine;

public class DoorTriggerZone : MonoBehaviour
{
    public PortalEffectController door;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            door.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            door.SetActive(false);
        }
    }
}
