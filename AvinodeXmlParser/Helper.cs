﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;

namespace AvinodeXmlParser
{
    public class Helper
    {
        public string Arg1;
        public object Arg2;
        public XmlDocument XmlStuff;

        public void Validate(string[] args)
        {
            if (!File.Exists(args[0]))
                throw new ArgumentException(args[0]);
            if (!Uri.IsWellFormedUriString(args[1], UriKind.Relative))
                throw new ArgumentException(args[1]);
            Arg1 = args[0];
            Arg2 = args[1];
        }

        public void ParseXml()
        {
            var doc = new XmlDocument();
            doc.Load(Arg1);
            //var nodes = doc.GetElementsByTagName("item");
            XmlStuff = doc;
        }
    }
}
