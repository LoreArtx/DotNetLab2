using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Sorted_Array
{
    public static class Extension_Array
    {
        public class RequireClass<TypeArr> where TypeArr : class { }
        public static int Count<TypeArr>(this TypeArr[] arr, TypeArr elem) where TypeArr :
             struct
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (object.Equals(arr[i], elem))
                {
                    count++;
                }
            }
            return count;
        }
        public static int Count<TypeArr>(this TypeArr[] arr, TypeArr elem, RequireClass<TypeArr> ignore = null) where TypeArr :
             class
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (object.Equals(arr[i], elem))
                {
                    count++;
                }
            }
            return count;
        }
        public static TypeArr[] Special<TypeArr>(this TypeArr[] arr) where TypeArr :
            struct
        {
            List<TypeArr> list = new List<TypeArr>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (list.IndexOf(arr[i]) == -1)
                {
                    list.Add(arr[i]);
                }
            }
            TypeArr[] ArrUniq = new TypeArr[list.Count];
            for (int i = 0; i < ArrUniq.Length; i++)
            {
                ArrUniq[i] = list[i];
            }
            return ArrUniq;
        }
        public static TypeArr[] Special<TypeArr>(this TypeArr[] arr, RequireClass<TypeArr> ignore = null) where TypeArr :
            class
        {
            List<TypeArr> list = new List<TypeArr>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (list.IndexOf(arr[i]) == -1)
                {
                    list.Add(arr[i]);
                }
            }
            TypeArr[] ArrUniq = new TypeArr[list.Count];
            for (int i = 0; i < ArrUniq.Length; i++)
            {
                ArrUniq[i] = list[i];
            }
            return ArrUniq;
        }
    }
}
