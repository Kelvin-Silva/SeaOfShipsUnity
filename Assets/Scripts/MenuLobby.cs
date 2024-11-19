﻿using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using TMPro;

public class MenuLobby : MonoBehaviourPunCallbacks
{
    [SerializeField] private TextMeshProUGUI _listaDeJogadores;
    [SerializeField] private Button _comecaJogo;

    [PunRPC]
    public void AtualizaLista()
    {
        _listaDeJogadores.text = GestorDeRede.Instancia.ObterListaDeJogadores();
        _comecaJogo.interactable = GestorDeRede.Instancia.DonoDaSala();

    }

}
