using UnityEngine;
using System.Collections;

public class trainSoundScript : MonoBehaviour {

    public GameObject car;
    private AudioSource trainSound;
    private Vector3 lastPosition;
    private float fixPicth = 0.4f;
    private float fixVolume = 0.5f;
    // Use this for initialization
    void Start () {
        trainSound = gameObject.GetComponent<AudioSource>();
        lastPosition = car.transform.position;
        //Debug.Log(lastPosition);
    }
	
	// Update is called once per frame
	void Update () {
        Vector3 nowPosition = car.transform.position;
        float distancePerFrame = Vector3.Distance(nowPosition, lastPosition);
        //Debug.Log(distancePerFrame);
        float fixPictchFinal = fixPicth + distancePerFrame * 2;
        

        float fixVolumeFinal = distancePerFrame * 40;

        //Debug.Log(fixPictchFinal);
        trainSound.pitch = fixPictchFinal;
        trainSound.volume = fixVolumeFinal;

        lastPosition = nowPosition;
    }
}
