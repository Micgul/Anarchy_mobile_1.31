using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.EventSystems;

public class TextManager : MonoBehaviour
{
    public Text TutorialText;
    public int ClickNum = 0;
    int emphasis_int = 0;
    GameObject Symbol;
    GameObject Unit_button;
    public GameObject cube;
    
    void Start()
    {
        TutorialText = GetComponent<Text>();
        Symbol = GameObject.Find("Team_symbol");
        Unit_button = GameObject.Find("Unit_button");
        TutorialText.text = "�ȳ��ϼ��� �� �Ƴ�Ű�� ���Ű� ȯ���մϴ�.\n �� ���� Ŭ�����ּ���.";
    }

    void Update()
    {
        SetText();
        Debug.Log(emphasis_int);
    }

    void SetText()
    {
        if(Input.GetMouseButtonDown(0))
        {
            ClickNum += 1;
            switch (ClickNum)
            {
                case 1:
                    TutorialText.text = "�������� �������� ������ �̲��� ��ӵǴ� �������� �¸��ؾ� �մϴ�.";
                    break;
                case 2:
                    TutorialText.text = "�������� �������̽��� ���� ������ �帮�ڽ��ϴ�.";
                    break;
                case 3:
                    emphasis_int = Symbol.transform.GetSiblingIndex();
                    Symbol.transform.SetAsLastSibling();
                    TutorialText.text = "���� ���� ��ũ�Դϴ�.�̴� �������� ������ ���������� ǥ���մϴ�.";
                    break;
                case 4:
                    Symbol.transform.SetSiblingIndex(emphasis_int);
                    emphasis_int = Unit_button.transform.GetSiblingIndex();
                    Unit_button.transform.SetAsLastSibling();
                    TutorialText.text = "���� ���� ��ư�Դϴ�. �������� �� ��ư�� ���� ���ο� ������ ���� �� �ֽ��ϴ�.";
                    break;
                case 5:
                    Unit_button.transform.SetSiblingIndex(emphasis_int);
                    cube.SetActive(true);
                    TutorialText.text = "���� Ȯ��";
                    break;
                case 6:
                    cube.SetActive(false);
                    TutorialText.text = "������ üũ";
                    break;
            }
        }
    }
}