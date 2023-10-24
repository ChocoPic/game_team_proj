using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*게임이 시작되면 처음 실행되는 클래스*/

public class GameManager : MonoBehaviour
{
    public GameObject RoomLv1;
    public GameObject RoomLv2;
    public GameObject RoomLv3;
    public GameObject RoomLv4;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("조각상번호"+Player.curSculpID);
        Debug.Log("현재레벨"+Player.Level);

        RoomLv1 = GameObject.Find("Lv1");
        RoomLv2 = GameObject.Find("Lv2");
        RoomLv3 = GameObject.Find("Lv3");
        RoomLv4 = GameObject.Find("Lv4");
    }

    // Update is called once per frame
    void Update()
    {
        setRoom();
    }
   
    public void setRoom()
    {
        if ( Player.doneCount >= 4 && Player.doneCount < 8) Player.Level = 2; 
        else if (Player.doneCount >= 8 && Player.doneCount < 12) Player.Level = 3; 
        else if (Player.doneCount >= 12 && Player.doneCount < 16) Player.Level = 4; 
        else if (Player.doneCount == 16) Player.Level = 5;

        switch (Player.Level)
        {
            case 1:
                RoomLv1.SetActive(true);
                RoomLv2.SetActive(false);
                RoomLv3.SetActive(false);
                RoomLv4.SetActive(false);
                break;
            case 2:
                RoomLv1.SetActive(true);
                RoomLv2.SetActive(true);
                RoomLv3.SetActive(false);
                RoomLv4.SetActive(false);
                break;
            case 3:
                RoomLv1.SetActive(true);
                RoomLv2.SetActive(true);
                RoomLv3.SetActive(true);
                RoomLv4.SetActive(false);
                break;
            default:
                RoomLv1.SetActive(true);
                RoomLv2.SetActive(true);
                RoomLv3.SetActive(true);
                RoomLv4.SetActive(true);
                break;
        }
    }

    

    //조각상 리스트
    

    //게임 저장
   /* public void GameSave()
    {
        //Player의 레벨 저장
        PlayerPrefs.SetInt("Level", player.Level);

        //Player가 완성한 작품의 번호 리스트 저장
        int[] doneList = new int[COUNT];
        string s = "";
        for (int i = 0; i < doneList.Length; i++)
        {
            s = s + doneList[i];
            if (i < doneList.Length - 1)
                s = s + ",";
        }
        PlayerPrefs.SetString("List", s);

        PlayerPrefs.Save();
    }
    //게임 불러오기
    public void GameLoad()
    {
        player = new Player();  //플레이어를 생성합니다.

        
        //처음 플레이
        if (PlayerPrefs.HasKey("Level"))
        {
            player = new Player();
        }
        //플레이 기록 있음
        else
        {
            int level = PlayerPrefs.GetInt("Level");    //플레이어 레벨
            string[] arr = PlayerPrefs.GetString("List").Split(',');
            List<int> numList = new List<int>();    //완성한 작품번호 리스트
            for (int i = 0; i < arr.Length; i++)
            {
                numList.Add(System.Convert.ToInt32(arr[i]));
            }
            player = new Player(level, numList);
        }
    }*/
}