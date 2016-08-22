using UnityEngine;
using System.Collections;
namespace VRProjectSctipt
{
    public class AnimationManager : MonoBehaviour
    {

        public static AnimationManager animationManager;

        private Animator myAnimator;

        void Awake()
        {
            animationManager = this;
            myAnimator = gameObject.GetComponent<Animator>();
        }

        // Use this for initialization
        void Start()
        {

        }

        public void beginMoving()
        {
            myAnimator.Play("carAnimation");
        }


        // Update is called once per frame
        void Update()
        {
        }
    }
}

