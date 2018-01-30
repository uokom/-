using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FizzBuzz : MonoBehaviour {

	// Use this for initialization
	void Start () {
        FizzBuzzout();
	}

    // Update is called once per frame
    void Update()
    { }
        
        void FizzBuzzout(){
            for (int hoge = 1; hoge <= 30; hoge++)
            {
                if (hoge % 3 == 0 && hoge % 5 == 0)
                    Debug.Log("FizzBuzz");
                else
                    if (hoge % 3 == 0)
                    Debug.Log("Fizz");
                else
                    if (hoge % 5 == 0)
                    Debug.Log("Buzz");
                else
                    Debug.Log(hoge);
            }
        }
    

}
