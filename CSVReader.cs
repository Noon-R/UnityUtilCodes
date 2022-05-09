using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEditor;

public class CSVReader
{
                                                  
    /// <summary>
    /// remain headLine
    /// </summary>
    /// <param name="filePath"></param>
    /// <param name="fileName"></param>
    /// <returns></returns>
    public static List<List<string>> Create(string filePath, string fileName)
    {
        List<List<string>> ret = new List<List<string>>();

        using (StreamReader reader = new StreamReader(filePath + fileName + ".csv"))
        {
            while (reader.Peek() != -1)
            {
                string line = reader.ReadLine();                                                   
                string[] stack = line.Split(',');

                List<string> lineData = new List<string>();
                foreach (string str in stack) {
                    lineData.Add(str);
                }

                ret.Add(lineData);

            }

        }

        return ret;
    }
}
