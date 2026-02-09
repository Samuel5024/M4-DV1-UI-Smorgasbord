using UnityEngine;

public class GameObjectToggleOn : MonoBehaviour
{
    [SerializeField] bool checkIfOn;
    public GameObject _gameObject;

    // void awake()
    // {
    //     // get the gameobject of the script
    //     _gameObject = gameObject;
    // }
    void Start()
    {
        // is the game object active? It should be.
        checkIfOn = _gameObject.activeSelf;

        if(checkIfOn)
        {
            // turns off object when scene starts
            checkIfOn = false;
            _gameObject.SetActive(false);
        }
    }
    
    public void ToggleOnOff()
    {
        // if true, set it to false and vice versa
        checkIfOn = checkIfOn ? false : true;
        // if (checkIfOn)
        //     checkIfOn = false;
        // else
        //     checkIfOn = true;
        // set state of game object
        _gameObject.SetActive(checkIfOn);
    }
}
