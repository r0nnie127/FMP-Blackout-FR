using System.Collections;
using UnityEngine;

public class BounceEffect : MonoBehaviour
{
    public float bounceHeight = 0.3f;

    public float bounceDuration = 0.4f;

    public int bounceCount = 2;

    public void StartBounce()
    {

    }

    private IEnumerator(Transform transform)
    {
        Vector3 startPosition = transform.position;
        float localHeight = bounceHeight;
        float localDuration = bounceDuration;

        for(int i=0; i < bounceCount, i++)
        {

        }
    }
}
