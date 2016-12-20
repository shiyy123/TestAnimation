using UnityEngine;
using UnityEditor;
using System.Collections;

public class HeroController : MonoBehaviour {

    public GameObject hero = null;


	void Start () {
        //hero.GetComponent<Animation>().Play("Swing");
        //hero.GetComponent<Animation>().wrapMode = WrapMode.Loop;
        //AnimationState animState = new AnimationState();
        
        
	}
	
	void Update () {

        if (Input.GetKey(KeyCode.S))
        {
            hero.GetComponent<Animator>().Stop();            
        }
        if (Input.GetKey(KeyCode.Alpha1))
        {
            if(!hero.GetComponent<Animator>().GetBool("IdleToOne"))
            {
                hero.GetComponent<Animator>().SetBool("IdleToOne", true);
                hero.GetComponent<Animator>().SetBool("OneToIdle", false);
            }
            ////hero.GetComponent<Animator>().Play("Swing", 0, 0.5f);
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            if (!hero.GetComponent<Animator>().GetBool("OneToTwo"))
            {
                hero.GetComponent<Animator>().SetBool("OneToTwo", true);
                hero.GetComponent<Animator>().SetBool("TwoToOne", false);
            }
        }

        if (Input.GetKey(KeyCode.Z))
        {
            if (!hero.GetComponent<Animator>().GetBool("OneToIdle"))
            {
                hero.GetComponent<Animator>().SetBool("OneToIdle", true);
                hero.GetComponent<Animator>().SetBool("IdleToOne", false);
            }
            ////hero.GetComponent<Animator>().Play("Swing", 0, 0.5f);
        }
        if (Input.GetKey(KeyCode.X))
        {
            if (!hero.GetComponent<Animator>().GetBool("TwoToOne"))
            {
                hero.GetComponent<Animator>().SetBool("TwoToOne", true);
                hero.GetComponent<Animator>().SetBool("OneToTwo", false);
            }
        }

	}
}
