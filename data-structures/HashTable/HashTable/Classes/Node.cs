﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HashTable.Classes
{
    class Node
    {
        public string Key { get; set; }
        public string Value { get; set; }
        public Node Next {get;set;}

        //Node constructor, nodes hold key value pairs
        public Node(string key, string value)
        {
            Key = key;
            Value = value;
        }
    }
}
