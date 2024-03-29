﻿namespace Observer
{
    public class Car : ObserversBase
    {
        protected string _description;
        protected double _price;

        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
                Notify();
            }
        }

        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
                Notify();
            }
        }
    }
}
