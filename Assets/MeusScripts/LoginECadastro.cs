using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Para mudar de scenes

public class LoginECadastro : MonoBehaviour
{
    public void LoginEfetuado()
    {
        Debug.Log("Teste!!!");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
