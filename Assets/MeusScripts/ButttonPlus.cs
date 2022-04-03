using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButttonPlus : MonoBehaviour
{
    public GameObject estadoPrefab;
    public GameObject workspace;
 
    // Update is called once per frame

   public void NovoEstado()
    {
        //SSTools.ShowMessage("Novo Estado Adicionado", SSTools.Position.bottom, SSTools.Time.threeSecond);
        GameObject estadoObj = Instantiate(estadoPrefab,workspace.transform);
        string nometemp = "Q";
        nometemp = nometemp + (workspace.GetComponent<Workspace>().GetQuantosEstados().ToString());
        estadoObj.GetComponent<Estado>().SetNomeDoEstado(nometemp);
        workspace.GetComponent<Workspace>().AddEstado(estadoObj);

    }
}
