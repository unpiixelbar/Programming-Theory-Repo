using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static Vehicel;

public class GameManager : MonoBehaviour
{
    static GameManager instance;
    public static GameManager Instance { get => instance; private set => instance = value; }

    private VehicleType choosenVehicle;
    public VehicleType ChoosenVehicle { get => choosenVehicle; private set => choosenVehicle = value; }

    // Start is called before the first frame update
    void Start()
    {

        if(Instance != null)
        {
            Destroy(gameObject);
        }
        Instance = this;

        DontDestroyOnLoad(gameObject);
    }

    public void test()
    {

    }

    public void startMain(int vehicel)
    {
        ChoosenVehicle = (VehicleType) vehicel;

        SceneManager.LoadScene(1);
    }

    
}
