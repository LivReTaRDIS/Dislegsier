﻿using Disleksia;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace WindowsFormsApp1
{
    public partial class FRM_Text : Form
    {
        Updater updater = new Updater();
        Font font_ui_Text = new Font("Applau", 12, FontStyle.Regular);
        Font font_player_Text_Handwritten = new Font("ApplauseFont", 22, FontStyle.Bold);
        Font font_player_Text_Handwritten_larger = new Font("ApplauseFont", 30, FontStyle.Bold);
        int current_question_index = 0;
        List<Awnsers> current_awnsers = new List<Awnsers>();
        Form child;

        /// <summary>
        /// hir kann du ein beisoiel liste nachschlagen
        /// </summary>
        List<Awnsers> Awnsers_Test = new List<Awnsers>()
        {
            new Awnsers(0,0,1,"Hi"),

            new Awnsers(1,0,2,"I'm pretty bad"),
            new Awnsers(1,0,3,"I´m really good"),
            new Awnsers(1,0,4,"Who the hell are you "),

            new Awnsers(2,0,2,"Nah dont wanna "),
            new Awnsers(2,0,5,"I guess why not "),

            new Awnsers(3,0,5,"YEEEES"),
            new Awnsers(3,0,5,"yes"),
            new Awnsers(3,0,5,"yes?"),

            new Awnsers(4,0,4,"Why should i go whith you?"),
            new Awnsers(4,0,5,"My choices seem very limetet right now"),


            new Awnsers(5,1,6,"Yes!"),
            new Awnsers(5,0,7,"I'm not ready!"),


            new Awnsers(6,0,8,"Horrible"),

            new Awnsers(7,0,6,"I'm ready now"),
            new Awnsers(7,0,7,"Still need some time"),

            new Awnsers(8,0,9,"This bitch empty"),

            new Awnsers(10,0,14,"This bitch emptier"),
            new Awnsers(10,0,14,"This bitch emptier"),
            new Awnsers(10,0,11,"This bitch emptier"),
            new Awnsers(10,0,11,"This bitch emptier"),



            new Awnsers(14,0,10,"This bitch emptier"),







        };
        /// <summary>
        /// Wenn eine Frage keine antworten hat wird die nächste gleich darunter angezeit
        /// </summary>
        List<string> Questions_Test = new List<string>()
        {
         "welcome ",//0
         "How are you",//1
         "Thats a shame. But lets begin any way ", //2
         "Oh thats good lets begin",//3
         "I'm Slartyblartfast lets go on an adventure", //4
         "We are about to uncover a totally secret Are you ready for level 1?", //5
         "Wow was it? ",// 6
         "No worries just tell me once you are",//7
         "Thats Good to know ready for level 2?",//8

        };
        List<Awnsers> Awnsers_Kapite_1 = new List<Awnsers>()
        {
        new Awnsers(5,0, 6,"``...´´"),
        new Awnsers(5,0 ,7,"``Wie bitte Frau Brandt?´´"),

        new Awnsers(8,0 ,9,"``Naja, zusammengfast sind Parabeln epische Kurzformen, die zur Veranschaulichung eines Gedanken dienen.´´"),
        new Awnsers(8,0, 9,"``Alsooo...´´"),
        new Awnsers(8,0, 9,"``Natürlich...´´"),

        new Awnsers(9,0,10,"``Klar, ich muss nur...´´"),
        new Awnsers(9,0,10,"``Ja, warten sie bitte kurz...´´"),

        new Awnsers(11,0,12,"*flüsternd* ``Fuck wo muss ich hin´´"),
        new Awnsers(11,0,18,"``Ähm. Warum muss ich den jetzt? Ich konnte ihre frage doch beantworten´´"),
        new Awnsers(11,0,12,"*flüsternd* ``oh nein´´"),

        new Awnsers(12,0,13,"*in Gedanken* `hier oder? hier´"),
        new Awnsers(12,0,13,"`Stimmt war ja 2 Seiten weiter´"),

        new Awnsers(13,0,14,"`137??´"),
        new Awnsers(13,0,14,"`ich will nicht´"),
        new Awnsers(13,0,14,"`141 ist es bestimmt´"),

        new Awnsers(15,0,16,"*flüsternd* ``Danke ERIK.´´"),
        new Awnsers(15,1,17,"``Ok... ehem... 'GIBS AUF' von Franz Kafka aus dem Jahr 1922.´´"),

        new Awnsers(16,1,17,"``Ok... ehem... 'GIBS AUF' von Franz Kafka aus dem Jahr 1922.´´"),

        new Awnsers(18,0,19,"``Das ist doch nicht fair´´"),
        new Awnsers(18,0,20,"``....... okay...´´"),

        new Awnsers(20,0,12,"*in Gedanken* `Ich glaub ...ah.. da hab ich doch gesehen Seite 12...´"),
        
        };


        List<string> Questions_Kapite_1 = new List<string>()
        {
         "Die Stunde ist im vollen Gange",//0
         "und alle Mitschüler schauen vertieft in ihre Lehrbücher.",//1
         "Nur JACOB lässt den Blick aus dem Fenster schweifen.", //2
         "Der Himmel ist klar mit einer aufgelößten Horde einzelner Kummulus Wolken, ",//3
         "und die Linden am Friedhof tanzen zum Rhytmus des Windes.",//4
         "???:'JACOB... '",//5+
         "???:'JACOB!''",//6+
         "FRAU BRANDT:'Hast du bereits den Sachtext gelesen?",//7
         "Oder hast du wieder nur Löcher in die Luft gestart?'",//8+
         "FRAU BRANDT:'Okey, dann ließ doch bitte gleich die Parabel von Kafka aus der ersten Aufgabe vor.'",//9+
         "Leicht verzweifelt schlägt JACOB sein bis dahin geschlossenes Buch auf.",//10
         "Er versucht die passende Seite zu finden ",//11+
         "JACOB blättert nervös weiter",//12+
         "Dort scheint er auch nicht zu finden was er Sucht",//13+
         "Wärend des herum blätterns wird ein aufgeschlagenes Buch in JACOBS Sichtfelt geschoben,",//14
         "und es ist auf der SEITE:123 mit der Parabel von Kafka aufgeschlagen.",//15+
         "ERIK : 'Nun ließ schon du Holzkopf.Eh die Alte dich noch grillt'",//16+
         "",
         " FRAU BRANDT: 'Wer meckert kommt erstrech dran'", //18
         " FRAU BRANDT: 'Was fair ist und was nicht entscheide immer noch ich!'", //19
         "JACOB sicht weiter im Buch nach dem Text",//20

        };

        List<Awnsers> Awnsers_Kapite_2 = new List<Awnsers>()
        {
            new Awnsers(0,0,0,"Ist okay."),
            new Awnsers(0,3,0,"Okay dan schüss"),
            new Awnsers(0,2,0,"Ich würde trotddem gerne lvel 2 sehgen"),

        };


        List<string> Questions_Kapite_2 = new List<string>()
        {
           " Sorry weitter geht die Story gerade nicht", //0

        };
        
        List<Awnsers> Awnsers_Kapite_3 = new List<Awnsers>()
        {
            new Awnsers(0,3,0,"Tüdelü")
        };


        List<string> Questions_Kapite_3 = new List<string>()
        {
            " jetzt gibts wirklich nichts mehr"
        };





        List<Awnsers> current_Awnserlist ;
        List<string> current_Questionlist;

        public FRM_Text()
        {
            InitializeComponent();

        
            current_Awnserlist = Awnsers_Kapite_1;
            current_Questionlist = Questions_Kapite_1;
        
           
            updater.Updating();
            Display_awnsers_and_question();
            
            
        }


        public class MyListBoxItem
        {
            public MyListBoxItem(Color c, string m, Font f)
            {
                ItemColor = c;
                Message = m;
                Fontstyle = f;
            }
            public Color ItemColor { get; set; }
            public string Message { get; set; }
            public Font Fontstyle { get; set; }
        }
        private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            MyListBoxItem item = LBX_MainWindow.Items[e.Index] as MyListBoxItem; // Get the current item and cast it to MyListBoxItem
            if (item != null)
            {

                e.Graphics.DrawString( // Draw the appropriate text in the ListBox
                    item.Message, // The message linked to the item
                    item.Fontstyle, // Take the font from the listbox
                    new SolidBrush(item.ItemColor), // Set the color 
                    e.Bounds // Y pixel coordinate.  Multiply the index by the ItemHeight defined in the listbox.
                );
                //listBox1.TopIndex = listBox1.Items.Count - 1;

            }
            else
            {
                // The item isn't a MyListBoxItem, do  something about it
            }


        }


        public void Display_awnsers_and_question()
        {
            int counter = LBX_MainWindow.Items.Count;
            while (counter > 16)
            {
                LBX_MainWindow.Items.RemoveAt(0);
                counter = LBX_MainWindow.Items.Count;
            }
            LBX_Awnsers.Items.Clear();
            current_awnsers.Clear();
            LBX_MainWindow.Items.Add((new MyListBoxItem(Color.Black,$"{current_Questionlist[current_question_index]}", font_ui_Text)));
            
            int awnsercounter = 0;
            foreach (Awnsers awnser in current_Awnserlist)
            {
                if (awnser.Index_of_asked_question == current_question_index)
                {
                    current_awnsers.Add(awnser);
                    LBX_Awnsers.Items.Add($"{awnser.Content}");
                    awnsercounter++;
                }
            }

            if (awnsercounter == 0 )
            {
                if(current_question_index < current_Questionlist.Count - 1)
                {
                current_question_index ++ ;

                }
                Display_awnsers_and_question();
            } 

        }


        /// <summary>
        /// function to mix Up words from the input consolos onto the 
        /// lBx_MainWindow
        /// </summary>
        /// <param name="playerimput"></param>
        /// <returns></returns>

        private void LBX_Awnsers_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case (char)13:
                    if (LBX_Awnsers.SelectedIndex > -1)
                    {
                        Awnsers selected_awnser = current_awnsers[LBX_Awnsers.SelectedIndex];
                        current_question_index = selected_awnser.Index_of_next_question;
                        LBX_MainWindow.Items.Add((new MyListBoxItem(Color.Black, $"{selected_awnser.Content}", font_player_Text_Handwritten)));
                        if (selected_awnser.Index_of_awnser != 0)
                        {
                            switch (selected_awnser.Index_of_awnser)
                            {
                                case 2:
                                    Formloader(new FRM_Level_Schreiben(this), Awnsers_Kapite_3, Questions_Kapite_3);
                                
                                    break;
                                case 1:

                                    Formloader(new FRM_Level_Lesen(this), Awnsers_Kapite_2, Questions_Kapite_2);
                                    break;
                                case 3:
                                    Environment.Exit(0);
                                    break;
                            }
                        }

                        Display_awnsers_and_question();

                    }
                    break;
                case 'w':
                    LBX_Awnsers.SelectedIndex--;
                    break;
                case 's':
                    LBX_Awnsers.SelectedIndex++;
                    break;
            }
        }

        private void Formloader(Form form, List<Awnsers> lista, List<string> listb)
        {
            child = form;
            child.Visible = true;
            child.Location = this.Location;
            current_question_index = 0;
            LBX_MainWindow.Items.Clear();
            current_Awnserlist = lista;
            current_Questionlist =listb;
         
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void FRM_Level_1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

    }
}
