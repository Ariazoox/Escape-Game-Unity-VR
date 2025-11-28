using UnityEngine;

public class WinZone : MonoBehaviour
{
    public GameObject winText; // ton texte UI

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            winText.SetActive(true);
        }
    }
}
