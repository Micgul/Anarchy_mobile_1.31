using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tutorial_Btn : MonoBehaviour
{
    public TutorialMain tutorialMain;

    public void UnitBtn()
    {
        if (tutorialMain.ButtonLimit)
        {
            if (tutorialMain.Unit2nd)
            {
                tutorialMain.TutorialText.text = "�̹����� ����° ��ư�� Ŭ���غ�����.";
                tutorialMain.UIs[9].transform.SetAsLastSibling();
                tutorialMain.UIs[11].transform.SetAsLastSibling();
                tutorialMain.UIs[11].SetActive(true);
                tutorialMain.UIs[12].SetActive(true);
                tutorialMain.UIs[12].transform.SetAsLastSibling();
                tutorialMain.UIs[10].transform.SetAsLastSibling();
                tutorialMain.ClickNum++;
            }
            else
            {
                tutorialMain.TutorialText.text = "���� ����â�Դϴ�. �ι�° ��ư�� Ŭ���غ�����.";
                tutorialMain.UIs[9].transform.SetAsLastSibling();
                tutorialMain.UIs[11].transform.SetAsLastSibling();
                tutorialMain.UIs[11].SetActive(true);
                tutorialMain.UIs[12].SetActive(true);
                tutorialMain.UIs[12].transform.SetAsLastSibling();
                tutorialMain.UIs[10].transform.SetAsLastSibling();
                tutorialMain.ClickNum++;
            }
        }
        
    }
    public void Unit2Btn()
    {
        if (tutorialMain.ButtonLimit)
        {
                tutorialMain.UIs[11].SetActive(false);
                tutorialMain.UIs[12].SetActive(false);
                tutorialMain.Units[1].SetActive(true);
                tutorialMain.ClickNum++;
                tutorialMain.TutorialText.text = "�� ������ ���Ÿ� �����Դϴ�. ���ݿ� Ưȭ�� �������� ���ݷ��� �����ϴ�.";
        }
    }
    public void Unit3Btn()
    {
        if (tutorialMain.ButtonLimit)
        {
            tutorialMain.UIs[11].SetActive(false);
            tutorialMain.UIs[12].SetActive(false);
            tutorialMain.Units[2].SetActive(true);
            tutorialMain.TutorialText.text = "�� ������ ���� �����Դϴ�. ����ɷ��� ��� ���� �������� ���� ������ �����Դϴ�.";
            tutorialMain.ClickNum++;
        }
    }
    public void BuildBtn()
    {
        if (tutorialMain.ButtonLimit)
        {
            tutorialMain.TutorialText.text = "�ǹ� ����â�Դϴ�. ù��° ��ư�� Ŭ���غ�����.";
            tutorialMain.UIs[9].transform.SetAsLastSibling();
            tutorialMain.UIs[11].transform.SetAsLastSibling();
            tutorialMain.UIs[11].SetActive(true);
            tutorialMain.UIs[13].SetActive(true);
            tutorialMain.UIs[13].transform.SetAsLastSibling();
            tutorialMain.UIs[10].transform.SetAsLastSibling();
            tutorialMain.ClickNum++;
        }
            tutorialMain.BuildBtn = true;
    }
    public void Build1Btn()
    {
        if (tutorialMain.ButtonLimit)
        {
            tutorialMain.TutorialText.text = "�̷��� �ǹ��� �Ǽ��� �� �ֽ��ϴ�.";
            tutorialMain.Building.SetActive(true);
            tutorialMain.UIs[11].SetActive(false);
            tutorialMain.UIs[13].SetActive(false);
            tutorialMain.ClickNum++;
        }
    }
    public void Unit3DBtn()
    {
        if (tutorialMain.ButtonLimit)
        {
            Debug.Log(tutorialMain.ClickNum);
            tutorialMain.TutorialText.text = "���� ����â�Դϴ�. ������ ���ɰ� ���� ���¸� �� �� �ְ�, ���ֿ��� �̵�, ���� ����� ���� �� �ֽ��ϴ�.";
            tutorialMain.UIs[14].SetActive(true);
            tutorialMain.UIs[15].SetActive(true);
            tutorialMain.ClickNum++;
        }
    }
    public void MvBtn()
    {
        if (tutorialMain.UnitLimit)
        {
            tutorialMain.TutorialText.text = "���� �̵� �̴ϸ��Դϴ�. ������ �̵��� ���� ���� �� �ֽ��ϴ�. ǥ�õ� �κ��� Ŭ���غ�����.";
            tutorialMain.UIs[14].SetActive(false);
            tutorialMain.UIs[15].SetActive(false);
            tutorialMain.UIs[11].SetActive(true);
            tutorialMain.UIs[16].SetActive(true);
        }
    }
    /*
    public void LocateBtn()
    {
        tutorialMain.TutorialText.text = "�̵��� ���� ���õǾ����ϴ�. ���� �ϴ��� ���� ��ư�� �����ּ���.";
        tutorialMain.BtnClicked = true;
    }
    */
    public void MvokBtn()
    {
        tutorialMain.ClickNum++;
    }
    public void MinimapBtn()
    {
        if (tutorialMain.ButtonLimit)
            tutorialMain.MinimapBtn = true;
    }
    public void Minimap2Btn()
    {
        if (tutorialMain.ButtonLimit)
            tutorialMain.Minimap2Btn = true;
    }
    public void Minimap3Btn()
    {
        if (tutorialMain.ButtonLimit)
            tutorialMain.Minimap3Btn = true;
    }
    public void TurnNextBtn()
    {
        if (tutorialMain.ButtonLimit)
            tutorialMain.TurnNextBtn = true;
    }
    public void SettingBtn()
    {
        if (tutorialMain.ButtonLimit)
            tutorialMain.SettingBtn = true;
    }
    public void AtkBtn()
    {

    }

}
