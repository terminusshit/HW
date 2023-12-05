using UnityEngine;

public class FadeAndScaleEffect : MonoBehaviour
{
    public float fadeDuration = 1f; 
    public float scaleDuration = 1f; 

    private CanvasGroup canvasGroup;
    private Transform objTransform;

    void Start()
    {
        canvasGroup = GetComponent<CanvasGroup>();
        objTransform = transform;
    }

    public void PlayFadeAndScaleEffect()
    {
        StartCoroutine(FadeAndScale());
    }

    private System.Collections.IEnumerator FadeAndScale()
    {
        float startTime = Time.time;
        
        while (Time.time < startTime + fadeDuration)
        {
            float progress = (Time.time - startTime) / fadeDuration;
            canvasGroup.alpha = progress;
            objTransform.localScale = Vector3.Lerp(Vector3.zero, Vector3.one, progress);
            yield return null;
        }
        
        yield return new WaitForSeconds(1f);

        startTime = Time.time;
        
        while (Time.time < startTime + fadeDuration)
        {
            float progress = (Time.time - startTime) / fadeDuration;
            canvasGroup.alpha = 1f - progress;
            objTransform.localScale = Vector3.Lerp(Vector3.one, Vector3.zero, progress);
            yield return null;
        }
    }
}