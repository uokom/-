using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
	
	public GameObject cube;
	public Transform SpownPoint;
	//問題６
    //int型のClickCountをpublicで宣言する
	public int ClickCount;

	void Start () {
		//問題７
        //SpawnCube()という関数を呼び出す
		SpawnCube();
	}
	
	void Update () {
		if(Input.GetMouseButtonDown(0)){
			//問題８
            //マウスがクリックされたらClickCountを1増やす
			ClickCount++;
		}
	}
	public void SpawnCube(){
		//問題９
		GameObject newCube = (GameObject)Instantiate (cube, SpownPoint);
		if(ClickCount == 0){
			//問題１０
            //まだクリックされていない時はCubeのサイズを2.5fにする
			newCube.transform.localScale *= 2.5f;
		}
		else if(ClickCount % 15 == 0){
			newCube.transform.localScale *= 4;
			newCube.GetComponent<Renderer>().material.color = Color.yellow;
		}
		else if(ClickCount % 5 == 0){
			newCube.transform.localScale *= 3.5f;
			newCube.GetComponent<Renderer>().material.color = Color.green;
		}
		else if(ClickCount % 3 == 0){
			newCube.transform.localScale *= 3;
			newCube.GetComponent<Renderer>().material.color = Color.red;
		}
		else{
			newCube.transform.localScale *= 2.5f;
		}
	}
}
