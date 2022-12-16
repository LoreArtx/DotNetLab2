using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Dict
{
    internal class Dict
    {
        public class ExtendedDictionaryElement<Key, Value1, Value2>
        {
            public Key key { set; get; }
            public Value1 value1 { set; get; }
            public Value2 value2 { set; get; }
        }
        public class ExtendedDictionary<Key, Value1, Value2>
        {

            protected List<ExtendedDictionaryElement<Key, Value1, Value2>> dict = new List<ExtendedDictionaryElement<Key, Value1, Value2>>();
            public void Add(Key key, Value1 val1, Value2 val2)
            {
                foreach (ExtendedDictionaryElement<Key, Value1, Value2> i in dict)
                {
                    if (object.Equals(i.key, key))
                    {
                        Console.WriteLine("Ключ існує");
                        return;
                    }
                }
                ExtendedDictionaryElement<Key, Value1, Value2> line = new ExtendedDictionaryElement<Key, Value1, Value2>();
                line.key = key;
                line.value1 = val1;
                line.value2 = val2;
                dict.Add(line);
            }

            public void Print()
            {
                foreach (ExtendedDictionaryElement<Key, Value1, Value2> i in dict)
                {
                    Console.WriteLine($"{i.key}-{i.value1}-{i.value2}");
                }
            }

            public void Remove(Key elem)
            {
                for (int i = 0; i < dict.Count; i++)
                {
                    if (object.Equals(dict[i].key, elem)) { dict.RemoveAt(i); return; }
                }
            }
            public void ExistKey(Key elem)
            {
                int iss = 0; int ind = 0;
                for (int i = 0; i < dict.Count; i++)
                {
                    if (object.Equals(dict[i].key, elem))
                    {
                        iss++;
                        ind = i;
                    }
                }
                if (iss == 0) Console.WriteLine("Немає такого ключа ;(");
                else Console.WriteLine($"Ключ знайдено:{ind}");
            }
            public int Count() { return dict.Count; }


            public void ExistValues(Value1 val1, Value2 val2)
            {
                bool ter = false;
                for (int i = 0; i < dict.Count; i++)
                {
                    if ((object.Equals(dict[i].value1, val1)) && (object.Equals(dict[i].value2, val2)))
                    {
                        ter = true;
                    }
                }
                if (ter)
                {
                    Console.WriteLine($"Елемент із значеннями {val1} і {val2} існує");
                }
                else Console.WriteLine($"Елемент із значеннями {val1} і {val2} не існує");
            }

            private int ind = 0;
            public ExtendedDictionaryElement<Key, Value1, Value2> this[Key key]
            {
                get
                {
                    for (int i = 0; i < dict.Count; i++)
                    {
                        if (object.Equals(dict[i].key, key))
                        {
                            ind = i;
                        }
                    }
                    return dict[ind];
                }
            }

            public IEnumerator<ExtendedDictionaryElement<Key, Value1, Value2>> GetEnumerator()
            {
                for (int i = 0; i < dict.Count; i++)
                {
                    yield return dict[i];
                }
            }
        }
    }
}
