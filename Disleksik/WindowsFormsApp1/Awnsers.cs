﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Awnsers
    {
        public int Index_of_asked_question { get; private set; }
        public int Index_of_awnser { get; private set; }
        public int Index_of_next_question { get; private set; }

        public string Content { get; private set; }

        public Awnsers(int ioaq,int ioa, int ionq, string content)
        {
            Index_of_asked_question = ioaq;
            Index_of_awnser = ioa;
            Index_of_next_question = ionq;
            Content = content;
        }
    }
}
