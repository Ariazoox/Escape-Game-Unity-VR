using System.Collections;
using System.IO;
using UnityEngine;
using UnityEngine.Networking;
using static GestureRecognition;

public class GestureLoader : MonoBehaviour
{
    public string gesturesFileName = "both.dat";
    public GestureRecognition gr;

    IEnumerator Start()
    {
        gr = new GestureRecognition();

        string fullPath = null;

#if UNITY_EDITOR
        fullPath = Application.streamingAssetsPath + "/" + gesturesFileName;

#elif UNITY_ANDROID
        string destination = Path.Combine(Application.persistentDataPath, gesturesFileName);

        // Si le fichier n'est pas encore dans le cache → on le copie depuis l'APK
        if (!File.Exists(destination))
        {
            string src = Path.Combine(Application.streamingAssetsPath, gesturesFileName);

            UnityWebRequest req = UnityWebRequest.Get(src);
            yield return req.SendWebRequest();

            if (req.result != UnityWebRequest.Result.Success)
            {
                Debug.LogError("💥 Impossible d’extraire le fichier gestures depuis l'APK : " + req.error);
                yield break; // OK car la fonction renvoie IEnumerator
            }

            File.WriteAllBytes(destination, req.downloadHandler.data);
        }

        fullPath = destination;

#else
        fullPath = Application.streamingAssetsPath + "/" + gesturesFileName;
#endif

        // Maintenant on charge dans MiVRy
        int result = gr.loadFromFile(fullPath);

        if (result != 0)
        {
            Debug.LogError("💥 Erreur MiVRy : impossible de charger le fichier : " + fullPath);
        }
        else
        {
            Debug.Log("Gestes chargés depuis : " + fullPath);
        }

        yield break; // Toujours finir une coroutine
    }
}
