using System.Collections;
using System.Numerics;
using System.Collections.Generic;
using UnityEngine;

public class ERC1155BalanceOfExample : MonoBehaviour
{
    async void Start()
    {
        string chain = "binance";
        string network = "mainnet";
        string contract = "0x1dDB2C0897daF18632662E71fdD2dbDC0eB3a9Ec";
        string account = "0x1e86B43665d6CBf3101Ff73fbc5488140039cF34";
        string tokenId = "100300183199";

        BigInteger balanceOf = await ERC1155.BalanceOf(chain, network, contract, account, tokenId);
        print(balanceOf);
    }
}
