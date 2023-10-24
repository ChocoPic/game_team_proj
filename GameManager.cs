using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*������ ���۵Ǹ� ó�� ����Ǵ� Ŭ����*/

public class GameManager : MonoBehaviour
{
    public GameObject RoomLv1;
    public GameObject RoomLv2;
    public GameObject RoomLv3;
    public GameObject RoomLv4;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("�������ȣ"+Player.curSculpID);
        Debug.Log("���緹��"+Player.Level);

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

    

    //������ ����Ʈ
    

    //���� ����
   /* public void GameSave()
    {
        //Player�� ���� ����
        PlayerPrefs.SetInt("Level", player.Level);

        //Player�� �ϼ��� ��ǰ�� ��ȣ ����Ʈ ����
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
    //���� �ҷ�����
    public void GameLoad()
    {
        player = new Player();  //�÷��̾ �����մϴ�.

        
        //ó�� �÷���
        if (PlayerPrefs.HasKey("Level"))
        {
            player = new Player();
        }
        //�÷��� ��� ����
        else
        {
            int level = PlayerPrefs.GetInt("Level");    //�÷��̾� ����
            string[] arr = PlayerPrefs.GetString("List").Split(',');
            List<int> numList = new List<int>();    //�ϼ��� ��ǰ��ȣ ����Ʈ
            for (int i = 0; i < arr.Length; i++)
            {
                numList.Add(System.Convert.ToInt32(arr[i]));
            }
            player = new Player(level, numList);
        }
    }*/
}