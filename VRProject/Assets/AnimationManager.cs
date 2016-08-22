using UnityEngine;
using System.Collections;
namespace VRProjectSctipt
{
    public class AnimationManager : MonoBehaviour
    {

        public static AnimationManager animationManager;//静态成员，到哪都能访问

        private Animator myAnimator;

        void Awake()//比start先
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

