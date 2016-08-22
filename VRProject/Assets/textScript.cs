using UnityEngine;
using System.Collections;
using System;

namespace VRProjectSctipt
{
    [RequireComponent(typeof(Collider))]
    public class textScript : MonoBehaviour,IGvrGazeResponder
    {
        private TextMesh thisTextMesh;
        private bool isSelecting = false;
        private DateTime lastTime;
        // Use this for initialization
        void Start()
        {
            //SetGazedAt(false);
            thisTextMesh = gameObject.GetComponent<TextMesh>();
        }
        void LateUdate()
        {
        }
        // Update is called once per frame
        void Update()
        {
            if (isSelecting)
            {
                TimeSpan timeDif = DateTime.Now - lastTime;
                double tSeconds = timeDif.TotalSeconds;
                if (tSeconds >= 2.0f)
                {
                    Debug.Log("getIn");
                    lastTime = DateTime.Now;

                    thisTextMesh.text = "  GO";
                    thisTextMesh.color = new Color(0, 0.5f, 0);

                    AnimationManager.animationManager.beginMoving();
                    StartCoroutine(textDisapeared());
                    
                }
            }
        }

        IEnumerator textDisapeared()
        {
            yield return new WaitForSeconds(1.0f);
            Destroy(gameObject);

        }

        public void Reset()
        {
        }
        public void OnGazeEnter()
        {
            SetGazedAt(true);
            throw new NotImplementedException();
        }

        public void OnGazeExit()
        {
            SetGazedAt(false);
            throw new NotImplementedException();
        }

        public void OnGazeTrigger()
        {
            throw new NotImplementedException();
        }
        public void SetGazedAt(bool gazedAt)
        {
            Debug.Log("IN");
            isSelecting = true;
            lastTime = DateTime.Now;
        }
        public void SetGazedOut(bool gazedOut)
        {

            Debug.Log("out");
            isSelecting = false;
            lastTime = DateTime.Now;
        }

    }
}

