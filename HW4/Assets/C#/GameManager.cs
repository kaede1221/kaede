using UnityEngine;

public class GameManager : MonoBehaviour
{
    public CharacterData_SO characterData; // ��CharacterData_SOʵ����ק��GameManager��Inspector��

    private void Awake()
    {
        if (characterData != null)
        {
            // ����Ϸ����ʱ��CrossingNum����Ϊ0
            characterData.CrossingNum = 0;
        }
    }
}
