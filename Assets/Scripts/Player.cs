using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 1.0f;
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private GameObject _plantPrefab;
    [SerializeField] private int _numSeeds = 5; 
    [SerializeField] private PlantCountUI _plantCountUI;

    private int _numSeedsLeft;
    private int _numSeedsPlanted;

    private void Start ()
    {
        _numSeedsLeft = _numSeeds;
    }

    private void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 move = new Vector3(horizontal, vertical, 0f);
        _playerTransform.Translate(move * _speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(_numSeedsLeft > 0)
            {
                PlantSeed();
                _numSeedsLeft--;
                _numSeedsPlanted++;
            }
            else
            {
                Debug.Log("no seeds left");
            }
        }
        _plantCountUI.UpdateSeeds(_numSeedsLeft,_numSeedsPlanted);
    }

    public void PlantSeed ()
    {
        Instantiate(
        _plantPrefab,
        _playerTransform.position,
        Quaternion.identity
    );
    }
}
