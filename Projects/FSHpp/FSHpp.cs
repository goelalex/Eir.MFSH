﻿using Antlr4.Runtime;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Antlr4.Runtime.Tree;

namespace FSHpp
{
    public class FSHpp
    {
        public NodeDocument ProcessInput(String fshText)
        {
            fshText = fshText.Replace("\r", "");
            FSHLexer lexer = new FSHLexer(new AntlrInputStream(fshText));

            //lexer.RemoveErrorListeners();
            //lexer.AddErrorListener(new ThrowingErrorListener());

            FSHParser parser = new FSHParser(new CommonTokenStream(lexer));

            //parser.RemoveErrorListeners();
            //parser.AddErrorListener(new ThrowingErrorListener());

            VisitorInfo info = new VisitorInfo
            {
                Input = fshText
            };

            FSHVisitor fsh = new FSHVisitor(info);
            return (NodeDocument) fsh.VisitDoc(parser.doc());
        }

        public void ProcessFile(String path)
        {
            String fshText = File.ReadAllText(path);
            NodeDocument d = ProcessInput(fshText);
            d.FileName = path;
        }

        public void ProcessDir(String path, String filter)
        {
            foreach (String subDir in Directory.GetDirectories(path))
                ProcessDir(subDir, filter);

            foreach (String file in Directory.GetFiles(path, filter))
                ProcessFile(file);
        }
    }

}