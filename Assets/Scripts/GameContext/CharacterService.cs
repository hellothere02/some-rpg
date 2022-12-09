using UnityEngine;


public sealed class CharacterService : MonoBehaviour
{
    [SerializeField]
    private Entity character;

    [SerializeField]
    private Transform characterTransform;

    public Entity GetCharacter()
    {
        return character;
    }

    public Transform GetCharacterTransform()
    {
        return characterTransform;
    }
}
