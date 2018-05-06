using System;
using System.Collections.Generic;
using System.Text;

using System.Xml;
using System.Xml.Xsl;
using System.Xml.Serialization;

namespace ApplyXSLT
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 3)
            {
                Console.WriteLine("Usage: input_xml input_xslt output_html");
            }

            try
            {
                XslCompiledTransform trans = new XslCompiledTransform();
                trans.Load(args[1]);
                trans.Transform(args[0], args[2]);
            }
            catch (Exception e)
            {
                while (e != null)
                {
                    Console.WriteLine("Exception: {0}\n\n{1}\n\n", e.Message, e.StackTrace, e.Data);
                    e = e.InnerException;
                }
            }
        }
    }
}
