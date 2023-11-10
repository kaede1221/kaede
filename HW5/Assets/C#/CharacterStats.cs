using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CharacterStats : MonoBehaviour
{
    //���ڻ�ȡ��ɫ��ֵ

    public CharacterData_SO characterData;
   

    private void Start()
    {
        // ע��һ�������л��¼�������
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        // ÿ���л�����ʱ����CrossingNum
        characterData.CrossingNum++;
    }

    //�۵�����
    #region Read for Data_SO
    public int MaxHealth
    {
        get { if (characterData != null) return characterData.CrossingNum; else return 0; }
        set { characterData.CrossingNum = value; }
    }
    /*    public int CurrentHealth
        {
            get { if (characterData != null) return characterData.currentHealth; else return 0; }
            set { characterData.currentHealth = value; }
        }
        public int BaseDefence
        {
            get { if (characterData != null) return characterData.baseDefence; else return 0; }
            set { characterData.baseDefence = value; }
        }
        public int CurrentDefence
        {
            get { if (characterData != null) return characterData.currentDefence; else return 0; }
            set { characterData.currentDefence = value; }
        }*/
    #endregion
}