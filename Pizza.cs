using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza
{
    class Pizza
    {
        //Globale variabler. Gør sig gældende til hele klassen//
        private string _pizzaA;
        private string _pizzaB;
        private string _pizzaC;

        private string _toppingA;
        private string _toppingB;
        private string _toppingC;

        private int _priceA = 50;
        private int _priceB = 55;
        private int _priceC = 60;

        public Pizza(string pizzaA, string pizzaB, string pizzaC, string toppingA, string toppingB, string toppingC, int priceA, int priceB, int priceC)
        {
            _pizzaA = pizzaA;
            _pizzaB = pizzaB;
            _pizzaC = pizzaC;
            _toppingA = toppingA;
            _toppingB = toppingB;
            _toppingC = toppingC;
            _priceA = priceA;
            _priceB = priceB;
            _priceC = priceC;
        }
        public string pizzaA
        {
            get { return _pizzaA; }
            set { _pizzaA = pizzaA; }
        }
        public string pizzaB
        {
            get { return _pizzaB; }
            set { _pizzaB = pizzaB; }
        }
        public string pizzaC
        {
            get { return _pizzaC; }
            set { _pizzaC = pizzaC; }
        }
        public string toppingA
        {
            get { return _toppingA; }
            set { _toppingA = toppingA; }
        }
        public string toppingB
        {
            get { return toppingB; }
            set { _toppingB = toppingB; }
        }
        public string toppingC
        {
            get { return toppingC; }
            set { _toppingC = toppingC; }
        }
        public int priceA
        {
            get { return _priceA; }
            set { _priceA = priceA; }
        }
        public int priceB
        {
            get { return _priceB; }
            set { _priceB = priceB;}
        }
        public int priceC
        {
            get { return _priceC; }
            set { _priceC = priceC; }

        }
            
            /*{
        this.pizzaA = pizzaA;
        this.pizzaB = pizzaB;
        this.pizzaC = pizzaC;
        this.toppingA = toppingA;
        this.toppingB = toppingB;
        this.toppingC = toppingC;
        this.priceA = priceA;
        this.priceB = priceB;
        this.priceC = priceC; 
    }
    public void SetPizzaA(string pizzaA)
    {
        this.pizzaA = pizzaA;
    }
    public string GetPizzaA()
    {
        return pizzaA;
    }
    public void setpizzaB(string pizzaB)
    {
        this.pizzaB = pizzaB;
    }
    return pizzaB;
    */

    }
}
