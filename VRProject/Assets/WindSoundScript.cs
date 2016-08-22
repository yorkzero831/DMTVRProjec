using UnityEngine;
using System.Collections;

public class WindSoundScript : MonoBehaviour {

    public GameObject car;
    private AudioSource windSound;
    private Vector3 lastPosition;
    private float fixPicth = 0.4f;
    private float fixVolume = 0.3f;
	// Use this for initialization
	void Start () {
        windSound = gameObject.GetComponent<AudioSource>();
        lastPosition = car.transform.position;
        //Debug.Log(lastPosition);
	}
	
	// Update is called once per frame
	void Update () {

        Vector3 nowPosition = car.transform.position;
        float distancePerFrame = Vector3.Distance(nowPosition, lastPosition);
        //Debug.Log(distancePerFrame);
        float fixPictchFinal = fixPicth + distancePerFrame * 1;
        float fixVolumeFinal = fixVolume + distancePerFrame * 3;


        //Debug.Log(fixPictchFinal);
        windSound.pitch = fixPictchFinal;
        windSound.volume = fixVolumeFinal;

        lastPosition = nowPosition;

	}
}
