using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractHandler
{

    class Program
    {
        static string Extention(string d)
        {
            string s = null;
            for (int k = d.Length - 3; k < d.Length; k++)
            {
                s += d[k];
            }
            return s;
        }
        static void Main()
        {
            Console.WriteLine("Choose what to do: open or create a document.");
            string a = Console.ReadLine();
            //string b=null;
            #region
            if (a == "open")
            {
                Console.WriteLine("Type the name of the document.");
                string document = Console.ReadLine();

                //Console.Write(Extention(document));
                string b = Extention(document);
                /*  for (int i = document.Length - 3; i < document.Length; i++)
                {
                    b += document[i];
                }*/

                if (b == "doc")
                {
                    DOCHandler doc = new DOCHandler();
                    doc.Open();
                    string edit = Console.ReadLine();
                    if (edit != document)
                    {
                        doc.Chenge();
                        Console.Write("Would you like to save changes?");
                        string changes = Console.ReadLine();
                        if (changes == "yes")
                        {
                            doc.Save();
                        }
                        /* else
                         {
                             goto f;
                         }*/
                    }
                }
                else if (b == "xml")
                {
                    XMLHandler xml = new XMLHandler();
                    xml.Open();
                    string edit = Console.ReadLine();
                    if (edit != document)
                    {
                        xml.Chenge();
                        Console.Write("Would you like to save changes?");
                        string changes = Console.ReadLine();
                        if (changes == "yes")
                        {
                            xml.Save();
                        }

                    }
                    else if (b == "txt")
                    {
                        TXTHandler txt = new TXTHandler();
                        txt.Open();
                        string edite = Console.ReadLine();
                        if (edite != document)
                        {
                            txt.Chenge();
                            Console.Write("Would you like to save changes?");
                            string changes = Console.ReadLine();
                            if (changes == "yes")
                            {
                                txt.Save();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Unknown format");
                            Main();
                        }
                    }
                }
                }
            #endregion
            #region
            else if (a == "create")
                    {
                    r: Console.WriteLine("Choose document format: .doc, .xml., .txt");
                        string document = Console.ReadLine();

                        string b1 = Extention(document);
                        /*  for (int i = document.Length - 3; i < document.Length; i++)
                        {
                            b += document[i];
                        }
                        */
                        if (b1 == "doc")
                        {
                            DOCHandler doc = new DOCHandler();
                            doc.Create();
                            string edite = Console.ReadLine();
                            if (edite != document)
                            {
                                doc.Chenge();
                                Console.Write("Would you like to save changes?");
                                string changes = Console.ReadLine();
                                if (changes == "yes")
                                {
                                    doc.Save();
                                }
                            }
                        }
                        else if (b1 == "xml")
                        {
                            XMLHandler xml1 = new XMLHandler();
                            xml1.Create();
                            string edite = Console.ReadLine();
                            if (edite != document)
                            {
                                xml1.Chenge();
                                Console.Write("Would you like to save changes?");
                                string changes = Console.ReadLine();
                                if (changes == "yes")
                                {
                                    xml1.Save();
                                }
                            }
                        }
                        else if (b1 == "txt")
                        {
                            TXTHandler txt = new TXTHandler();
                            txt.Create();
                            string edite = Console.ReadLine();
                            if (edite != document)
                            {
                                txt.Chenge();
                                Console.Write("Would you like to save changes?");
                                string changes = Console.ReadLine();
                                if (changes == "yes")
                                {
                                    txt.Save();
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("You've selected wrong format.");
                            goto r;
                        }
                    }
            #endregion
            #region
            /*
                for (int i = a.Length-3; i< a.Length; i++)
                {
                    b += a[i];
                }
                Console.WriteLine(b);


                if (b == "doc")
                {
                    string action = Console.ReadLine();
                    DOCHandler doc = new DOCHandler();
                    if(action == "open")
                    {
                        doc.Open();
                    }else if (action == "create") {
                        doc.Create();
                    }
                    else if (action == "change")
                    {
                        doc.Chenge();
                    }
                    else if (action == "save")
                    {

                        doc.Save();
                    }
                }
                else if (b =="xml")
                {
                    string action = Console.ReadLine();
                    XMLHandler xml = new XMLHandler();
                    if (action == "open")
                    {
                        xml.Open();
                    }
                    else if (action == "create")
                    {
                        xml.Create();
                    }
                    else if (action == "change")
                    {
                        xml.Chenge();
                    }
                    else if (action == "save")
                    {
                        xml.Save();
                    }
                }
                else if (b == "txt")
                {
                    string action = Console.ReadLine();
                    TXTHandler txt = new TXTHandler();
                    if (action == "open")
                    {
                        txt.Open();
                    }
                    else if (action == "create")
                    {
                        txt.Create();
                    }
                    else if (action == "change")
                    {
                        txt.Chenge();
                    }
                    else if (action == "save")
                    {
                        txt.Save();
                    }
                
                */
#endregion}
                 Console.ReadKey();
                
            }
        }
    }
    