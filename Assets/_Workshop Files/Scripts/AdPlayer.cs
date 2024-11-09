using System.Collections;
using UnityEngine.Advertisements;
using UnityEngine;

public class AdPlayer : MonoBehaviour
{
    public void ShowSimpleAd()
    {
        if (Advertisement.isInitialized)
            Advertisement.Show("video");
    }
}
