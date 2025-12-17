using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    internal class Register
    {
        IDocument[] docs = new IDocument[10];
        private int docsCount = 0;

        public void SaveDocument(IDocument document)
        {
            if (docsCount > 0 && docsCount <= 10)
            {
                docs[docsCount] = document;
                docsCount++;
            }
            else if (docsCount == 0)
            {
                docs[docsCount] = document;
                docsCount++;
            }
            else
            {
                Console.WriteLine("Register overflow.");
            }
        }

        public void PrintDocument(IDocument document)
        {
            document.PrintDocument();
        }

        public void PrintDocument(int i)
        {
            if (i > 0 && i <= 10)
            {
                docs[i - 1].PrintDocument();
            }
        }

        public void PrintAll()
        {
            for (int i = 0; i < docsCount; i++)
            {
                docs[i].PrintDocument();
            }
        }
    }
}
