using UnityEngine;


public sealed class CharacterService : MonoBehaviour
{
    [SerializeField]
    private Entity character;

    public Entity GetCharacter()
    {
        return character;
    }
}
