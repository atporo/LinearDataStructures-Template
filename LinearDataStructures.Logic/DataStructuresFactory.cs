﻿namespace LinearDataStructures.Logic
{
    public static class DataStructuresFactory
    {
        public static IStack<T> CreateStack<T>()
        {
            throw new NotImplementedException();
        }
        public static IQueue<T> CreateQueue<T>()
        {
            return new Queue<T>();
        }
        public static IUniversalQueue<T> CreateUniversalQueue<T>()
        {
            throw new NotImplementedException();
        }
    }
}
