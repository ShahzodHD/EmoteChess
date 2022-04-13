using UnityEngine;
using UnityEngine.UI;

public class StatusOutputController : MonoBehaviour
{
    [SerializeField] private RenameFigure rename;

    [SerializeField] private Text text;
    public void Output()
    {
        text.text = rename.answer;
    }
    public void OutputResultBlack()
    {
        text.text = "������ ������ ��� �����";
    }
    public void OutputResultWhite()
    {
        text.text = "����� ������ ��� �����";
    }
}
