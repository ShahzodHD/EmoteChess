using UnityEngine;

public class RenameFigure : MonoBehaviour
{
    [HideInInspector] public string attackingName;
    [HideInInspector] public string destroyedName;
    [HideInInspector] public string answer;
    public void Raname(string attacking, string destroyed)
    {
        if (attacking.Contains("Pawn")) { attackingName = "�����������"; }
        if (attacking.Contains("Rook")) { attackingName = "����"; }
        if (attacking.Contains("Knight")) { attackingName = "�����"; }
        if (attacking.Contains("Bishop")) { attackingName = "������"; }
        if (attacking.Contains("Queen")) { attackingName = "���������"; }
        if (attacking.Contains("King")) { attackingName = "�������"; }

        if (destroyed.Contains("Pawn")) { destroyedName = "�����������"; }
        if (destroyed.Contains("Rook")) { destroyedName = "����"; }
        if (destroyed.Contains("Knight")) { destroyedName = "�����"; }
        if (destroyed.Contains("Bishop")) { destroyedName = "������"; }
        if (destroyed.Contains("Queen")) { destroyedName = "���������"; }
        if (attacking.Contains("King")) { attackingName = "�������"; }

        answer = attackingName + " " + "������" + " " + destroyedName;
    }
}
