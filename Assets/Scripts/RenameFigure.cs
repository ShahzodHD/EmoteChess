using UnityEngine;

public class RenameFigure : MonoBehaviour
{
    [HideInInspector] public string attackingName;
    [HideInInspector] public string destroyedName;
    [HideInInspector] public string answer;
    public void Raname(string attacking, string destroyed)
    {
        if (attacking.Contains("Pawn")) { attackingName = "Спокойствие"; }
        if (attacking.Contains("Rook")) { attackingName = "Гнев"; }
        if (attacking.Contains("Knight")) { attackingName = "Страх"; }
        if (attacking.Contains("Bishop")) { attackingName = "Печаль"; }
        if (attacking.Contains("Queen")) { attackingName = "Ненависть"; }
        if (attacking.Contains("King")) { attackingName = "Счастье"; }

        if (destroyed.Contains("Pawn")) { destroyedName = "Спокойствие"; }
        if (destroyed.Contains("Rook")) { destroyedName = "Гнев"; }
        if (destroyed.Contains("Knight")) { destroyedName = "Страх"; }
        if (destroyed.Contains("Bishop")) { destroyedName = "Печаль"; }
        if (destroyed.Contains("Queen")) { destroyedName = "Ненависть"; }
        if (attacking.Contains("King")) { attackingName = "Счастье"; }

        answer = attackingName + " " + "срубил" + " " + destroyedName;
    }
}
