using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine;

public class Button_Action : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject image;
	public GameObject menu;
	public GameObject gameSet;
	public GameObject blue;
	public GameObject red;
	public float mod;

	public void OnClick()
	{
		StartCoroutine("GameStart"); //버튼 클릭시 실행되는 함수
	}

	IEnumerator GameStart()
	{
		image.SetActive(true); //메달 모양 이미지 활성화
		yield return new WaitForSeconds(0.5f);
		GameManager.instance.mod = mod; //게임 매니저에 선택한 난이도 전달
		GameManager.instance.PlayGame = true;
		menu.SetActive(false); //메뉴 비활성화
		gameSet.SetActive(true);
		red.SetActive(true); //레드 진영 활성화	
		blue.SetActive(true); //블루 진영 활성화
	}
}
