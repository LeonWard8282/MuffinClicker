using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstScript : MonoBehaviour
{
   public int m_counter = 0;

  public void OnMuffinClicked()
    {
        m_counter = m_counter + 1;

        Debug.Log( m_counter );

    }


}
