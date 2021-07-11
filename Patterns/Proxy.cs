﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;

public sealed class Program 
{
    public interface ISubject
    {
        void Request();
    }

    class RealSubject : ISubject
    {
        public void Request()
        {
            Console.WriteLine("RealSubject: Handling Request.");
        }
    }

    class Proxy : ISubject
    {
        private RealSubject realSubject = new RealSubject();

        public Proxy(RealSubject realSubject)
        {
            this.realSubject = realSubject;
        }

        public void Request()
        {
            if (CheckAccess())
            {
                realSubject.Request();
                LogAccess();
            }
        }

        public bool CheckAccess()
        {
            Console.WriteLine("Proxy: Checking access prior to firing a real request.");
            return true;
        }

        public void LogAccess()
        {
            Console.WriteLine("Proxy: Logging the time of request.");
        }
    }

    public class Client
    {
        public void ClientCode(ISubject subject)
        {
            subject.Request();
        }
    }

    public static void Main() 
    {
        Client client = new Client();

        Console.WriteLine("Client: Executing the client code with a real subject:");
        RealSubject realSubject = new RealSubject();
        client.ClientCode(realSubject);

        Console.WriteLine();

        Console.WriteLine("Client: Executing the same client code with a proxy:");
        Proxy proxy = new Proxy(realSubject);
        client.ClientCode(proxy);
        Console.ReadKey();
    }
}

