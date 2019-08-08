using System;
using System.Collections.Generic;
using System.Text;

namespace HashTable.Classes
{
    class Hashtable
    {
        //Instance of linklist array
        public LinkedList<Node>[] HashMap { get; set; }

        //Creates array of linklist with given size
        public Hashtable(int arraySize)
        {
            HashMap = new LinkedList<Node>[arraySize];
        }

        /// <summary>
        /// Creates hash number from given key
        /// </summary>
        /// <param name="key">Key that will be hashed</param>
        /// <returns>Hash number</returns>
        public int Hash(string key)
        {
            int total = 0;

            //add up the character values of each character in given key
            for (int i = 0; i < key.Length; i++)
            {
                total += key[i];
            }

            //Sum of key character values multiplied with a high prime number
            int primeTotal = total * 929;

            //Divide the result of prime total with the length of the hashmap
            int hashedKey = primeTotal % HashMap.Length;

            return hashedKey;
        }

    }
}
