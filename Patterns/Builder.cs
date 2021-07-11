using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;

public sealed class Program 
{
    public interface IBuilder
    {
        void BuildPartA();
        void BuildPartB();
        void BuildPartC();
    }

    public class ConcreteBuilder : IBuilder
    {
        private Product product = new Product();

        public ConcreteBuilder()
        {
            Reset();
        }

        public void Reset()
        {
            product = new Product();
        }

        public void BuildPartA()
        {
            product.Add("PartA1");
        }

        public void BuildPartB()
        {
            product.Add("PartB1");
        }

        public void BuildPartC()
        {
            product.Add("PartC1");
        }

        public Product GetProduct()
        {
            var result = product;
            Reset();
            return result;
        }
    }

    public class BreadBuilder : IBuilder
    {
        private Bread bread = new Bread();

        public void Reset()
        {
            bread = new Bread();
        }

        public void BuildPartA()
        {
            bread.Add("Мука");
        }

        public void BuildPartB()
        {
            bread.Add("Соль");
        }

        public void BuildPartC()
        {
            bread.Add("Добавки");
        }

        public Product GetProduct()
        {
            var result = bread;
            Reset();
            return result;
        }
    }

    public class Product
    {
        protected List<object> parts = new List<object>();

        public void Add(string part)
        {
            parts.Add(part);
        }

        public virtual string ListParts()
        {
            string str = string.Join(", ", parts);
            return "Product parts: " + str + "\n";
        }
    }

    public class Bread : Product
    {
        public override string ListParts()
        {
            string str = string.Join(", ", parts);
            return "Bread parts: " + str + "\n";
        }
    }

    public class Director
    {
        private IBuilder builder;

        public IBuilder Builder
        {
            set { builder = value; }
        }

        public void BuildMinimalViableProduct()
        {
            builder.BuildPartA();
        }

        public void BuildFullFeaturedProduct()
        {
            builder.BuildPartA();
            builder.BuildPartB();
            builder.BuildPartC();
        }
    }

    public static void Main() 
    {
        var director = new Director();
        var builder = new ConcreteBuilder();
        director.Builder = builder;

        Console.WriteLine("Standard basic product:");
        director.BuildMinimalViableProduct();
        Console.WriteLine(builder.GetProduct().ListParts());

        Console.WriteLine("Standard full featured product:");
        director.BuildFullFeaturedProduct();
        Console.WriteLine(builder.GetProduct().ListParts());

        var breadBuilder = new BreadBuilder();
        director.Builder = breadBuilder;
        Console.WriteLine("Standard basic product:");
        director.BuildMinimalViableProduct();
        Console.WriteLine(breadBuilder.GetProduct().ListParts());

        Console.WriteLine("Standard full featured product:");
        director.BuildFullFeaturedProduct();
        Console.WriteLine(breadBuilder.GetProduct().ListParts());

        Console.WriteLine("Custom product:");
        builder.BuildPartA();
        builder.BuildPartC();
        Console.Write(builder.GetProduct().ListParts());
        Console.ReadKey();
    }
}

