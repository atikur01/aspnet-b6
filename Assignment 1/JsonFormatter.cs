using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Assignment_1
{
    public class JsonFormatter
    {
        private static string str ;
        public static string Convert<T>(object item)
        {
            var itemType = item.GetType();
            var properties = itemType.GetProperties();   
            foreach (var property in properties)
            {
                var propValue = property.GetValue(item, null);
                var elements = propValue as ICollection;
                if (elements != null)
                {
                    foreach (var i in elements)
                    {
                        Convert<T>(i);
                    }
                }
                else
                {
                    if (property.PropertyType.Assembly == itemType.Assembly)
                    {
                        str += " \"" + property.Name + "\" : ";
                        str += System.Environment.NewLine;
                        Convert<T>(propValue);
                    }
                    else
                    {
                        str += " \"" + property.Name + "\" : \"" + propValue + "\", ";
                        str += System.Environment.NewLine;
                    }
                }
            }
            return str;
        }
 
    }
}