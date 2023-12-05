using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shaking : MonoBehaviour
{
    public static IEnumerator Shake(float duration, float magnitude)
    {
        Vector3 originalPos = Camera.main.transform.localPosition;
        float elapsed = 0.0f;

        while (elapsed < duration)
        {
            float x = Random.Range(-1f, 1f) * magnitude;
            float y = Random.Range(-1f, 1f) * magnitude;

            Camera.main.transform.localPosition = new Vector3(x, y, originalPos.z);

            elapsed += Time.deltaTime;

            yield return null;
        }

        //Camera.main.transform.localPosition = originalPos;
    }
}


public class CameraShake : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Make the game run as fast as possible
        Application.targetFrameRate = 10;
    }

    // Update is called once per frame
    void Update()
    {
        // 例: カメラを2秒間、振幅0.1で揺らす
        StartCoroutine(Shaking.Shake(2.0f, 1.0f));

    }
}
