﻿using System;
using System.Xml;
using System.Collections.Generic;

// TODO : Create config components & implements getter/setter

namespace MangaDownloader
{
    public class Config
    {
        private static Dictionary<String, String> values;


        public static void loadConfig()
        {
            values = new Dictionary<String, String>();

            values.Clear();

            XmlDocument doc = new XmlDocument();
            doc.Load("config.xml");

            XmlNode node = doc.DocumentElement.SelectSingleNode("/config");

            values["filenameScheme"] = node.SelectSingleNode("filenameScheme").InnerText;
            values["savePath"] = node.SelectSingleNode("savePath").InnerText;
            values["saveOutput"] = node.SelectSingleNode("saveOutput").InnerText;
            values["useFileOutput"] = node.SelectSingleNode("useFileOutput").InnerText;
            values["pathScheme"] = node.SelectSingleNode("pathScheme").InnerText;
            values["version"] = node.SelectSingleNode("version").InnerText;
            values["timeInterval"] = node.SelectSingleNode("timeInterval").InnerText;
        }

        public static void saveConfig()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("config.xml");

            XmlNode node = doc.DocumentElement.SelectSingleNode("/config");

            foreach(String key in values.Keys)
            {
                node.SelectSingleNode(key).InnerText = values[key];
            }

            doc.Save("config.xml");
        }

        public static void setSavePath(String path)
        {
            values["savePath"] = path;
        }

        public static String getFilenameScheme()
        {
            return values["filenameScheme"];
        }

        public static void setFilenameScheme(String scheme)
        {
            values["filenameScheme"] = scheme;
        }

        public static String getSaveOutput()
        {
            return values["saveOutput"];
        }

        public static void setSaveOutput(String path)
        {
            if (path != "")
                values["saveOutput"] = path;
            else
                values["saveOutput"] = "news.txt";
        }

        public static Boolean getUseFileOutput()
        {
            return (values["useFileOutput"] == "True") ? true : false;
        }

        public static void setUseFileOutput(Boolean use)
        {
            if(use)
                values["useFileOutput"] = "True";
            else
                values["useFileOutput"] = "False";
        }

        public static String getSavePath()
        {
            return values["savePath"];
        }

        public static String getPathScheme()
        {
            return values["pathScheme"];
        }

        public static String getVersion()
        {
            return values["version"];
        }

        public static String getLicence()
        {
            try
            {
                string[] lines = System.IO.File.ReadAllLines("LICENSE");

                return String.Join("\n", lines);
            }
            catch(Exception e)
            {
                return "GPL V2";
            }
        }


        public static Boolean getUseWebInterface()
        {
            return false;
        }

        public static void setUseWebInterface(Boolean use)
        {

        }

        public static int getTimeInterval()
        {
            return int.Parse(values["timeInterval"]);
        }

        public static void setTimeInterval(int value)
        {
            values["timeInterval"] = value.ToString();
        }

    }
}
