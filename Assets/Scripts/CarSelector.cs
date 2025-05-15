using UnityEngine;

public class CarSelector : MonoBehaviour
{
    public static int selectedCarIndex = 0;

    public void SelectCar(int index)
    {
        selectedCarIndex = index;
    }
}
