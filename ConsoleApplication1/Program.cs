﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.SignalR.Client;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var hubConnection = new HubConnection("http://localhost:55565/");
            IHubProxy stockTickerHubProxy = hubConnection.CreateHubProxy("Venda");
            hubConnection.Start().Wait();
            int count = 0;
            while (true)
            {
                count++;
                Console.ReadKey();
                stockTickerHubProxy.Invoke("NovaVenda", "Notebook "+count);
            }
        }
    }
}
