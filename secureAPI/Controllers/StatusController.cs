using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace secureAPI.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    public class StatusController: ControllerBase
    {

        //[HttpGet]
        //[Authorize]
        //public async Task<string> GetUserInfo()
        //{
        //    string output = await $"systemctl status wg-quick@wg0.service".Bash();
        //    return output;
        //}

        //[HttpPost]
        //public async Task CreateClientConf(WireGuardInfo client)
        //{
        //    await $@"umask 077 && cd /home/wireguard/wireguard && mkdir {client.clientName} && cd {client.clientName} &&
        //          wg genkey > {client.clientName}.key &&  wg pubkey<{client.clientName}.key > {client.clientName}.pub &&
        //          echo ""[Interface]"" >> {client.clientName}.conf &&
        //          echo ""PublicKey = $(cat {client.clientName}.pub)"" >> {client.clientName}.conf &&
        //          echo ""PrivateKey = $(cat {client.clientName}.key)"" >> {client.clientName}.conf && 
        //          echo ""Address = {client.ipAddress}"" >> {client.clientName}.conf &&
        //          echo ""DNS = 8.8.8.8"" >> {client.clientName}.conf &&
        //          echo ""[Peer]"" >> {client.clientName}.conf &&
        //          echo ""AllowedIPs = 10.254.0.0/24"" >> {client.clientName}.conf &&
        //          echo ""Endpoint = 74.207.244.207:51820"" >> {client.clientName}.conf &&
        //          echo ""AllowedIPs = 0.0.0.0/0"" >> {client.clientName}.conf".Bash();
        //}

        //public async Task updateSeverInfo(WireGuardInfo client)
        //{
        //     string clientKey =await $"cat /home/wireguard/wireguard/{client.clientName}/{client.clientName}.key".Bash();

        //    await $@"
        //          sudo systemctl stop wg-quick@wg0.service &&
        //          cd /etc/wireguard && echo ""[Peer]"" >> wg0.conf &&
        //          echo ""AllowedIPs = {client.ipAddress}"" >> wg0.conf &&
        //          echo ""PublicKey = {clientKey}"" >> wg0.conf &&
        //          sudo systemctl start wg-quick@wg0.service".Bash();
        //}
    }
}
