using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ERC721OwnerOfExample : MonoBehaviour
{
    async void Start()
    {
        string chain = "binance";
        string network = "mainnet";
        string contract = "0x1dDB2C0897daF18632662E71fdD2dbDC0eB3a9Ec";
        string tokenId = "100300140897";

        string ownerOf = await ERC721.OwnerOf(chain, network, contract, tokenId);
        print(ownerOf);
    }
}
