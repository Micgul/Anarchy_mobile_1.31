using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class TutorialMain : MonoBehaviour
{
    public Text TutorialText;
    public int ClickNum = -3;
    public GameObject[] Units;
    public GameObject[] UIs;
    public GameObject Building;
    string BtnName;
    public bool UnitBtn, Unit2Btn, Unit3Btn, BuildBtn, Build1Btn, MinimapBtn, Minimap2Btn, Minimap3Btn, TurnNextBtn, SettingBtn, Unit3DBtn, MvBtn, AtkBtn, MvokBtn, LocateBtn = false;
    public bool ButtonLimit = false;
    public Color panelColor;
    public bool Unit2nd = false;
    public bool UnitLimit = false;
    public bool BtnClicked = false;


    void Start()
    {
        TutorialText = GetComponent<Text>();
        TutorialText.text = "�ȳ��ϼ��� �� �Ƴ�Ű�� ���Ű� ȯ���մϴ�.\n �� ���� Ŭ�����ּ���.";
    }

    void Update()
    {
        SetText();
    }
    void SetText()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (ClickNum == -3)
            {
                ClickNum += 1;
            }
            switch (ClickNum)
            {
                case -2:
                    TutorialText.text = "�������� �������� ������ �̲��� ��ӵǴ� �������� �¸��ؾ� �մϴ�.\n\n�����Ϸ��� Ŭ���ϼ���.";
                    ClickNum += 1;
                    break;
                case -1:
                    TutorialText.text = "�������� �������̽��� ���� ������ �帮�ڽ��ϴ�.\n\n�����Ϸ��� Ŭ���ϼ���.";
                    ClickNum += 1;
                    break;
                case 0:
                    UIs[0].transform.SetAsLastSibling();
                    TutorialText.text = "���� ���� ��ũ�� ���� �� ǥ��, �� Ÿ�̸��Դϴ�. �̴� �������� ������ ����������, ���� �� ���� ������, ���� �󸶳� ���Ҵ����� ǥ���մϴ�.\n\n�����Ϸ��� Ŭ���ϼ���.";
                    ClickNum += 1;
                    break;
                case 1:
                    UIs[9].transform.SetAsLastSibling();
                    UIs[10].transform.SetAsLastSibling();
                    UIs[1].transform.SetAsLastSibling();
                    TutorialText.text = "�ܾ�â�Դϴ�. �������� ���� �󸶳� ���Ҵ��� ǥ���մϴ�.\n\n�����Ϸ��� Ŭ���ϼ���.";
                    ClickNum += 2;
                    break;
                case 2:
                    UIs[9].transform.SetAsLastSibling();
                    UIs[10].transform.SetAsLastSibling();
                    UIs[2].transform.SetAsLastSibling();
                    TutorialText.text = "��Ÿ�̸��Դϴ�. �������� ���� �󸶳� ���Ҵ��� ǥ���մϴ�. ���� ���ѽð��� 3���Դϴ�.\n\n�����Ϸ��� Ŭ���ϼ���.";
                    ClickNum += 1;
                    break;
                case 3:
                    UIs[9].transform.SetAsLastSibling();
                    UIs[10].transform.SetAsLastSibling();
                    UIs[3].transform.SetAsLastSibling();
                    TutorialText.text = "���� ���� ��ư�Դϴ�. �������� �� ��ư�� ���� ���ο� ������ ���� �� �ֽ��ϴ�.\n\n�����Ϸ��� Ŭ���ϼ���.";
                    ClickNum += 1;
                    break;
                case 4:
                    UIs[9].transform.SetAsLastSibling();
                    UIs[10].transform.SetAsLastSibling();
                    UIs[10].transform.SetAsLastSibling();
                    UIs[4].transform.SetAsLastSibling();
                    TutorialText.text = "�ǹ� �Ǽ� ��ư�Դϴ�. �������� �� ��ư�� ���� ���ο� �ǹ��� ���� �� �ֽ��ϴ�.\n\n�����Ϸ��� Ŭ���ϼ���.";
                    ClickNum += 1;
                    break;
                case 5:
                    UIs[9].transform.SetAsLastSibling();
                    UIs[10].transform.SetAsLastSibling();
                    UIs[5].transform.SetAsLastSibling();
                    TutorialText.text = "�̴ϸ��Դϴ�. �������� �� �̴ϸ��� ���� ȭ���� �̵��ϰ� ������ ��ġ�� �� �� �ֽ��ϴ�.\n\n�����Ϸ��� Ŭ���ϼ���.";
                    ClickNum += 1;
                    break;
                case 6:
                    UIs[9].transform.SetAsLastSibling();
                    UIs[10].transform.SetAsLastSibling();
                    UIs[6].transform.SetAsLastSibling();
                    TutorialText.text = "�� �����Դϴ�. �������� �� ��ư�� ���� ��뿡�� ���� �ѱ� �� �ֽ��ϴ�.\n\n�����Ϸ��� Ŭ���ϼ���.";
                    ClickNum += 1;
                    break;
                case 7:
                    UIs[9].transform.SetAsLastSibling();
                    UIs[10].transform.SetAsLastSibling();
                    UIs[7].transform.SetAsLastSibling();
                    TutorialText.text = "���� ��ư�Դϴ�. �������� �� ��ư�� ���� ������ ������ �� �ֽ��ϴ�.\n\n�����Ϸ��� Ŭ���ϼ���.";
                    ClickNum += 1;
                    break;
                case 8:
                    UIs[9].transform.SetAsLastSibling();
                    UIs[10].transform.SetAsLastSibling();
                    UIs[8].transform.SetAsLastSibling();
                    TutorialText.text = "���� ���� ��ư�Դϴ�. �������� �� ��ư�� ���� ������ ������ �� �ֽ��ϴ�.\n\n�����Ϸ��� Ŭ���ϼ���.";
                    ClickNum += 1;
                    break;
                case 9:
                    UIs[9].transform.SetAsLastSibling();
                    UIs[10].transform.SetAsLastSibling();
                    panelColor = UIs[9].GetComponent<Image>().color;
                    UIs[9].GetComponent<Image>().color = new Color(panelColor.r, panelColor.g, panelColor.b, 0f);
                    Units[0].SetActive(true);
                    TutorialText.text = "�̰��� �������� ������ �����Դϴ�. �������� �� ���ֵ��� ���� ������ �����ϰ� ���� ������ ������ �մϴ�.\n\n�����Ϸ��� Ŭ���ϼ���.";
                    ClickNum += 1;
                    break;
                case 10:
                    TutorialText.text = "���ֿ��� 3���� ������ �ֽ��ϴ�. �� ������ ���� �����Դϴ�. �� Ưȭ�� �������� ������ ����, ������ �� �ڽ��� �������� �� ���ٸ� ���ظ� �Խ��ϴ�.\n\n�����Ϸ��� Ŭ���ϼ���.";
                    ClickNum += 1;
                    break;
                case 11:
                    ButtonLimit = true;
                    TutorialText.text = "���� ���� ��ư�� Ŭ���ϼ���.";
                    UIs[3].transform.SetAsLastSibling();
                    break;
                case 13:
                    TutorialText.text = "�ٽ� �ѹ� ���� ���� ��ư�� Ŭ���ϼ���.";
                    UIs[3].transform.SetAsLastSibling();
                    Unit2nd = true;
                    break;
                case 15:
                    TutorialText.text = "���� ������ �ִ� ���� ������ �����̶�� �մϴ�. �������� �ٽɱ���, �߸�����, ���� ������ �ֽ��ϴ�. ���� ������ �ִ� ������ �ٽ� �����Դϴ�.";
                    ClickNum++;
                    break;
                case 16:
                    TutorialText.text = "�ٽ� ������ �ϴ� 40�� ���� �����ϸ�, �ٽ� ������ ���ɴ����� ���, ���ӿ��� �й��ϰ� �˴ϴ�.";
                    ClickNum++;
                    break;
                case 17:
                    TutorialText.text = "���� ���� ��ư�� ����������";
                    UIs[4].transform.SetAsLastSibling();
                    ClickNum++;
                    break;
                case 20:
                    TutorialText.text = "�ǹ��� ���¿��� ������ �ִ� ��ҷ�, �� �Ͽ� ��� ��ȭ ����, �� ������ ������ ����, ���ְ� �ǹ��� ����µ� ��� ��� ����, �� 3������ �ǹ��� �ֽ��ϴ�.";
                    ClickNum++;
                    break;
                case 21:
                    TutorialText.text = "���� ù��° ������ Ŭ���غ�����.";
                    UnitLimit = true;
                    UIs[9].SetActive(false);
                    ClickNum++;
                    break;
                case 23:
                    TutorialText.text = "���� ���� ��ư�� �̵� ��ư�� ����������.";
                    ClickNum++;
                    break;
                    /*
                    case 24:
                    panelColor = UIs[17].GetComponent<Image>().color;
                    UIs[17].GetComponent<Image>().color = new Color(0, 0, 255, 255f);
                    break;
                    */
            }
        }
    }
}
