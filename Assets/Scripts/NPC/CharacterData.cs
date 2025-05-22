using UnityEngine;

[CreateAssetMenu(fileName = "CharacterData", menuName = "Scriptable Objects/CharacterData")]
public class CharacterData : ScriptableObject
{
    public string fullName;
    public string nationality;
    public string idNumber;

    public int birthYear;
    public int arrivalYear;

    public bool isTimeCorrect;
}
