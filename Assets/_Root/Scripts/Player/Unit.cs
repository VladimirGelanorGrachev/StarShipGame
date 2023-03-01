using System.Collections;
using UnityEngine;

public class Unit : MonoBehaviour
{

    [SerializeField] private int _health;
    [SerializeField] private int _time;
    [SerializeField] private int _healingPower;
    [SerializeField] private bool _courOn;    
    [SerializeField] private GameObject _popUp;

    private void Start()
    {
        if (_courOn)
        {
            Debug.Log("Coroutine On, no more Healing effect!!!");
        }
        else
        {
            RecerveHealing();
        }
    }

    public void RecerveHealing()
    {
        
        StartCoroutine(HealingCour(_time, _health));
        
    }

    IEnumerator HealingCour(float time, int hp)
    {
        _courOn= true;
        Debug.Log("Start Healing");

        while (hp < 100)
        {
            yield return new WaitForSeconds(time);
            hp = hp + _healingPower;
            if (hp > 100)
            {
                hp = 100;
                
            }
            Debug.Log(hp);
            PopUpOn();
        }
    }

    public void PopUpOn()
    {       
       _popUp.gameObject.SetActive(true);
        
    }
}
