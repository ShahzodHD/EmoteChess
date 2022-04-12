using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField] private AudioSource audioPawn;
    [SerializeField] private AudioClip[] clipsPawn;
    [SerializeField] private AudioSource audioRock;
    [SerializeField] private AudioClip[] clipsRock;
    [SerializeField] private AudioSource audioKnight;
    [SerializeField] private AudioClip[] clipsKnight;
    [SerializeField] private AudioSource audioBishop;
    [SerializeField] private AudioSource audioQueen;
    [SerializeField] private AudioClip[] clipsQueen;
    [SerializeField] private AudioSource audioKing;
    [SerializeField] private AudioClip[] clipsKing;

    private AudioClip _tempClipPawn;
    private AudioClip _tempClipRock;
    private AudioClip _tempClipKnight;
    private AudioClip _tempClipQueen;
    private AudioClip _tempClipKing;
    public void DefineTypeFigure(string name)
    {
        if (name.Contains("Pawn")) { PawnPlayClip(); }
        if (name.Contains("Rook")) { RookPlayClip(); }
        if (name.Contains("Knight")) { KnightPlayClip(); }
        if (name.Contains("Bishop")) { BishopPlayClip(); }
        if (name.Contains("Queen")) { QueenPlayClip(); }
        if (name.Contains("King")) { KingPlayClip(); }
    }
    private void PawnPlayClip()
    {
        int index = Random.Range(0, 2);
        _tempClipPawn = clipsPawn[index];
        audioPawn.clip = _tempClipPawn;
        audioPawn.Play();
    }
    private void RookPlayClip()
    {
        int index = Random.Range(0, 2);
        _tempClipRock = clipsRock[index];
        audioRock.clip = _tempClipRock;
        audioRock.Play();
    }
    private void KnightPlayClip()
    {
        int index = Random.Range(0, 2);
        _tempClipKnight = clipsKnight[index];
        audioKnight.clip = _tempClipKnight;
        audioKnight.Play();
    }
    private void BishopPlayClip()
    {
        audioBishop.Play();
    }
    private void QueenPlayClip()
    {
        int index = Random.Range(0, 2);
        _tempClipQueen = clipsQueen[index];
        audioQueen.clip = _tempClipQueen;
        audioQueen.Play();
    }
    private void KingPlayClip()
    {
        int index = Random.Range(0, 2);
        _tempClipKing = clipsKing[index];
        audioKing.clip = _tempClipKing;
        audioKing.Play();
    }
}
