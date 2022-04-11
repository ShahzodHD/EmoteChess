using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField] private AudioSource audioPawn;
    [SerializeField] private AudioSource audioRock;
    [SerializeField] private AudioSource audioKnight;
    [SerializeField] private AudioSource audioBishop;
    [SerializeField] private AudioSource audioQueen;
    [SerializeField] private AudioSource audioKing;
    public void DefineTypeFigure(string name)
    {
        if (name.Contains("Pawn")) { PawnPlayClip(); }
        if (name.Contains("Rock")) { RockPlayClip(); }
        if (name.Contains("Knight")) { KnightPlayClip(); }
        if (name.Contains("Bishop")) { BishopPlayClip(); }
        if (name.Contains("Queen")) { QueenPlayClip(); }
        if (name.Contains("King")) { KingPlayClip(); }
    }
    private void PawnPlayClip()
    {
        print("œ¿¬Õ");
        audioPawn.Play();
    }
    private void RockPlayClip()
    {
        print("¡¿ÿÕﬂ");
        audioRock.Play();
    }
    private void KnightPlayClip()
    {
        print(" ŒÕ‹");
        audioKnight.Play();
    }
    private void BishopPlayClip()
    {
        print("—ÀŒÕ");
        audioBishop.Play();
    }
    private void QueenPlayClip()
    {
        print("‘≈–«");
        audioQueen.Play();
    }
    private void KingPlayClip()
    {
        print(" Œ–ŒÀ‹");
        audioKing.Play();
    }
}
