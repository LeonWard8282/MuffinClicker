using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MyFirstScript : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _totalMuffinsText;
   public int m_counter = 0;

  public void OnMuffinClicked()
    {
        m_counter = m_counter + 1;
        _totalMuffinsText.text =  m_counter.ToString() + " Muffins" ;
        Debug.Log( m_counter );

    }


}
